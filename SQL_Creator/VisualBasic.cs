﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SQL_Creator
{
    internal static class VisualBasic
    {
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

        public static string[] HandleName(string name)
        {
            string[] result = new string[2];

            string n = Utilities.CapitaliseFirst(name);

            string prefixed = usePrefixOnPrivate ? prefix + name : name;

            result[0] = n;
            result[1] = prefixed;

            return result;
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

        public static string MakeFind(string table, string name, string defaultValue)
        {
            string[] names = HandleName(name);

            name = names[0];
            string prefixName = names[1];
            string regexBracketMatch = @"[(](?!\))|(?<!\()[)]"; //Matches a ( or ) but not when they're together, e.g. date() won't match but (' ') will


            string defaultVal = defaultValue != null && defaultValue.Trim().Length > 0 ? Regex.Replace(defaultValue, regexBracketMatch, "") : "";



            return prefixName;
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
                        tab + "Dim objCommand As New SqlCommand(\"Update " + table + "SET ";

            for (int i = 0; i < cols.Count(); ++i)
            {
                string capitalisedName = Utilities.CapitaliseFirst(cols[i].columnName);

                parameterHolder += tab + "objCommand.Parameters.AddWithValue(\"@" + capitalisedName + "\", " + prefix + capitalisedName + nl;

                if (i != cols.Count() - 1)
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
                            tab + "Dim objCommand As New SqlCommand('DELETE FROM " + table + " WHERE " + name + " = @" + name + "',objConnection)" + nl +
                            tab + "objCommand.Parameters.AddWithValue('@" + name + "', " + prefixName + ")" + nl +
                            tab + "objCommand.ExecuteNonQuery()" + nl +
                            tab + "objConnection.Close()" + nl +
                            "End Sub";

            return delete;
        }
    }
}
