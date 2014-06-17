using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            { "DATETIME", "As Date"}
        };

        public static string MakeProperty(string name, string type)
        {
            string prefixName;
            string typeDef = typeDefinitions[type.Trim().ToUpper()];

            //Capitalise first property
            name = Utilities.CapitaliseFirst(name);

            //Use prefix if required
            if (usePrefixOnPrivate)
                prefixName = prefix + name;
            else
                prefixName = name;

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
    }
}
