using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SQL_Creator
{
    static class DatabaseHandler
    {
        private static string _connectionString = string.Empty;
        private static string _getTablesQuery = "SELECT name FROM sys.tables";
        private static string _getColumnInfo = "SELECT COLUMN_NAME, DATA_TYPE, COLUMN_DEFAULT FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = ";
        
        public static bool SetConnectionString(string connectionString)
        {
            bool stringSet = false;

            if(connectionString != null && connectionString.Trim().Length > 0)
            {
                _connectionString = connectionString;
                stringSet = true;
            }
            else
            {
                stringSet = false;
            }

            return stringSet;
        }

        public static List<string> GetTables()
        {
            return Execute(_getTablesQuery);
        }

        public static List<string> OrganiseColumns(string tableName)
        {
            List<string> columnData = Execute(_getColumnInfo + "'" + tableName + "'");

            return columnData;
        }

        public static List<string> Execute(string query)
        {
            List<string> results = new List<string>();

            if(_connectionString == string.Empty)
                return null;

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    
                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataReader reader = command.ExecuteReader();

                    while(reader.Read())
                    {
                        int readerLength = reader.FieldCount;
                        string[] resultString = new string[readerLength];

                        for (int i = 0; i < readerLength; ++i)
                        {
                            resultString[i] = reader[i].ToString();
                        }

                        string resultRow = "";

                        for (int i = 0; i < readerLength; ++i)
                        {
                            if (i == readerLength -1)
                                resultRow += resultString[i];
                            else
                                resultRow += resultString[i] + ",";
                        }

                        results.Add(resultRow);
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Error executing query: " + e.Message);
                return null;
            }

            return results;
        }

    }
}
