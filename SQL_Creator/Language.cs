using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQL_Creator
{
    public static class Language
    {

        private static Lang _language = Lang.VisualBasic; //default

        public enum Lang
        {
            VisualBasic,
            CSharp,
            JavaScript
        }

        public static void SetLanguage(Lang language)
        {
            _language = language;
        }

        internal static String GetLanguage()
        {
            return _language.ToString();
        }
    }
}
