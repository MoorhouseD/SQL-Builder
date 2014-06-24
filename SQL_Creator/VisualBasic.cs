using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SQL_Creator
{
    internal static class VisualBasic
    {
        private static string regexBracketMatch = @"[(](?!\))|(?<!\()[)]"; //Matches a ( or ) but not when they're together, e.g. date() won't match but (' ') will
        private static string tab = "\t";
        private static string nl = "\r\n";

        private static bool usePrefixOnPrivate = true;
        private static string prefix = "_";

        private static readonly Dictionary<string, string> typeDefinitions = new Dictionary<string, string>()
        {
            { "INT", "As Integer"},
            { "BIT", "As Boolean"},
            { "NCHAR", "As String"},
            { "VARCHAR", "As String"},
            { "SMALLMONEY", "As Double"},
            { "DATE", "As Date"},
            { "DATETIME", "As Date"},
            { "NULL", "As Null"}
        };

        private static string GetDefault(string type)
        {
            string def = "";

            switch(type.ToUpper())
            {
                case "INT":
                    def = "0";
                    break;
                case "BIT":
                    def = "0";
                    break;
                case "SMALLMONEY":
                    def = "0.00";
                    break;
                case "DATE":
                case "DATETIME":
                    def = "Now()";
                    break;
                case "NCHAR":
                case "VARCHAR":
                default:
                    def = "\"\"";
                    break;
                    
            }

            return def;
        }

        public static string[] HandleName(string name)
        {
            string[] result = new string[2];

            string n = Utilities.CapitaliseFirst(name);

            string prefixed = usePrefixOnPrivate ? prefix + n : n;

            result[0] = n;
            result[1] = prefixed;

            return result;
        }

        public static string MakeDefaults(List<Column> cols)
        {
            string defaults = "Private Sub PopulateDefault()" + nl;

            for(int i = 0; i < cols.Count(); ++i)
            {
                if(usePrefixOnPrivate)
                {
                    string capitalName = Utilities.CapitaliseFirst(cols[i].columnName);
                    string defaultVal = GetDefault(cols[i].columnType);

                    defaults += tab + prefix + Utilities.CapitaliseFirst(cols[i].columnName) + " = " + defaultVal + nl;
                }
            }

            defaults += "End Sub" + nl;

            defaults += "Public Sub New()" + nl + nl +
                        tab + "' This call is required by the Windows Form Designer." + nl +
                        tab + "InitializeComponent()" + nl + nl +
                        tab + "' Add any initialization after the InitializeComponent() call." + nl +
                        tab + "PopulateDefault()" + nl +
                        "End Sub";

            return defaults;
        }

        public static string MakeProperty(string name, string type)
        {
            string typeDef = typeDefinitions[type.Trim().ToUpper()];

            string[] names = HandleName(name);

            name = names[0];
            string prefixName = names[1];

            string declaration = "Private " + prefixName + " " + typeDef + nl + nl;
            string gettersetter = "Public Property " + name + "() " + typeDef + nl +
                                  tab + "Get" + nl +
                                  tab + tab + "Return " + prefixName + nl +
                                  tab + "End Get" + nl +
                                  tab + "Set(ByVal value " + typeDef + ")" + nl +
                                  tab + tab + prefixName + "= value" + nl +
                                  tab + "End Set" + nl +
                                  "End Property" + nl + nl;

            string property = declaration + gettersetter;

            return property;
        }

        public static string MakeConnectionString(string settingsStringName)
        {
            if (settingsStringName != null && settingsStringName.Trim().Length > 0)
                return "Private sConnectionString = My.Settings." + settingsStringName + " 'Get ConnectionString from My.Settings";
            else
                return "";
        }

        public static string MakeFind(string table, List<Column> cols)
        {

            string find = "";

            //Build method start
            find += "Public Sub New(ByVal KeyRef As Integer)" + nl + nl +
                    tab + "InitializeComponent()" + nl + nl +
                    tab + "Dim objConnection As New SqlConnection(sConnectionString)" + nl +
                    tab + "objConnection.Open()" + nl + nl +
                    tab + "Dim objCommand As New SqlCommand(\"SELECT * FROM " + table + " WHERE KeyRef = @KeyRef\", objConnection)" + nl +
                    tab + "objCommand.Parameters.AddWithValue(\"@KeyRef\", Keyref)" + nl +
                    tab + "Dim objReader As SqlDataReader = objCommand.ExecuteReader()" + nl +
                    tab + "If objReader.Read() Then" + nl;

            //Build Parameters
            string parameters = "";

            for(int i = 0; i < cols.Count(); ++i)
            {
                string[] names = HandleName(cols[i].columnName);
                string prefixName = names[1];

                string defaultItem = names[1].ToLower() == "keyref" ? "0" : GetDefault(cols[i].columnType);

                parameters += tab + tab + prefixName + " = IIf(IsDBNull(objReader.Item(" + i + ")), " + defaultItem + ", objReader.Item(" + i + "))" + nl;
            }

            find += parameters;

            find += tab + "Else" + nl +
                    tab + tab + "PopulateDefault()" + nl +
                    tab + "End If" + nl +
                    tab + "objReader.Close()" + nl +
                    tab + "objConnection.Close()" + nl + nl +
                    "End Sub";

            return find;
        }

        public static string MakeCreate(string table, List<Column> cols)
        {
            string create;

            create = "Public Function Create() As Integer" + nl +
                        tab + "Dim objConnection As New SqlConnection(sConnectionString)" + nl +
                        tab + "objConnection.Open()" + nl +
                        tab + "Dim objCommand As New SqlCommand(\"INSERT INTO " + table + " ";

            //Build fields and values
            string fields = "(";
            string values = "\" _" + nl + tab + tab + "& \"VALUES (";

            for (int i = 1; i < cols.Count(); ++i)
            {
                if (i != cols.Count() - 1)
                {
                    fields += Utilities.CapitaliseFirst(cols[i].columnName) + ", ";
                    values += "@" + Utilities.CapitaliseFirst(cols[i].columnName) + ", ";
                }
                else
                {
                    fields += Utilities.CapitaliseFirst(cols[i].columnName) + ") ";
                    values += "@" + Utilities.CapitaliseFirst(cols[i].columnName) + ") ";
                }
            }

            //Add fields and values
            create += fields + values + "\", objConnection)" + nl + nl;

            //Build Parameters
            string parameterHolder = "";

            for(int i = 1; i < cols.Count(); ++i)
            {
                string[] names = HandleName(cols[i].columnName);

                string capitalisedName = names[0];
                string prefixName = names[1];

                if(capitalisedName.ToUpper() == "CUSTOMERREF")
                {
                    parameterHolder += tab + "objCommand.Parameters.AddWithValue(\"@" + capitalisedName + "\", GetNextCustomerNumber.RecordNum)" + nl;
                }
                else
                {
                    parameterHolder += tab + "objCommand.Parameters.AddWithValue(\"@" + capitalisedName + "\", " + prefixName + ")" + nl;
                }

            }

            //Add parameters
            create += parameterHolder;

            create += tab + "objCommand.ExecuteNonQuery()" + nl +
                        tab + "objCommand.Parameters.Clear()" + nl +
                        tab + "objCommand.CommandText = \"SELECT @@IDENTITY\"" + nl +
                        tab + "Dim intNewKeyRefID As Integer = Convert.ToInt32(objCommand.ExecuteScalar())" + nl +
                        tab + "objConnection.Close()" + nl +
                        tab + prefix + Utilities.CapitaliseFirst(cols[0].columnName) + " = intNewKeyRefID" + nl +
                        tab + "Return intNewKeyRefID" + nl +
                        "End Function";

            return create;

        }

        public static string MakeUpdate(string table, List<Column> cols)
        {
            string prefixKeyRef;

            if(usePrefixOnPrivate)
                prefixKeyRef = prefix + cols[0].columnName;
            else
                prefixKeyRef = cols[0].columnName;

            string update;
            string parameterHolder = "";

            update = "Public Overloads Function Update() As Boolean" + nl +
                        tab + "If " + prefixKeyRef + "= 0 Then Throw New Exception(\"Record does not exist in table.\")" + nl +
                        tab + "Dim objConnection As New SqlConnection(sConnectionString)" + nl +
                        tab + "objConnection.Open()" + nl +
                        tab + "Dim objCommand As New SqlCommand(\"Update " + table + " SET ";

            for (int i = 0; i < cols.Count(); ++i)
            {
                string capitalisedName = Utilities.CapitaliseFirst(cols[i].columnName);

                parameterHolder += tab + "objCommand.Parameters.AddWithValue(\"@" + capitalisedName + "\", " + prefix + capitalisedName + ")" + nl;

                if (i == 0)
                {

                }
                else if (i != cols.Count() - 1)
                    update += capitalisedName + " = @" + capitalisedName + ", ";
                else
                    update += capitalisedName + " = @" + capitalisedName;
            }

            update += " WHERE (" + Utilities.CapitaliseFirst(cols[0].columnName) + " = @" + Utilities.CapitaliseFirst(cols[0].columnName) + ")\", objConnection)" + nl;

            //Add parameters
            update += parameterHolder;

            update +=   tab + "Dim boolResult As Boolean = False" + nl +
                        tab + "If objCommand.ExecuteNonQuery() > 0 Then boolResult = True" + nl +
                        tab + "objConnection.Close" + nl +
                        tab + "Return boolResult" + nl +
                        "End Function";

            return update;
        }

        public static string MakeDelete(string table, string name)
        {
            string[] names = HandleName(name);

            name = names[0];
            string prefixName = names[1];

            string delete = "Public Sub Delete()" + nl +
                            tab + "Dim objConnection As New SqlConnection(sConnectionString)" + nl +
                            tab + "objConnection.Open()" + nl +
                            tab + "Dim objCommand As New SqlCommand(\"DELETE FROM " + table + " WHERE " + name + " = @" + name + "\",objConnection)" + nl +
                            tab + "objCommand.Parameters.AddWithValue(\"@" + name + "\", " + prefixName + ")" + nl +
                            tab + "objCommand.ExecuteNonQuery()" + nl +
                            tab + "objConnection.Close()" + nl +
                            "End Sub";

            return delete;
        }
    }
}
