using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQL_Creator
{
    static class Utilities
    {
        public static string CapitaliseFirst(string text)
        {
            string temp = text.Substring(0,1);

            return temp.ToUpper() + text.Substring(1).ToLower();            
        }

    }
}
