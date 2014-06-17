using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQL_Creator
{
    class Column
    {
        private string _columnName;
        private string _columnType;

        public string columnName
        {
            get
            {
                return _columnName;
            }
            set
            {
                _columnName = value;
            }
        }

        public string columnType
        {
            get
            {
                return _columnType;
            }
            set
            {
                _columnType = value;
            }
        }

    }
}
