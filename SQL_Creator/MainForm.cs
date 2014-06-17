using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SQL_Creator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            insertText.Text = "";
            updateText.Text = "";
            deleteText.Text = "";
            privateVarsText.Text = "";
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            string serverName = serverNameText.Text;
            string username = usernameText.Text;
            string password = passwordText.Text;
            string dbName = dbText.Text;

            string azureConnectionString = new SqlConnectionStringBuilder
            {
                DataSource = serverName + ".database.windows.net",
                InitialCatalog = dbName,
                Encrypt = false,
                TrustServerCertificate = false,
                UserID = username,
                Password = password
            }.ToString();

            DatabaseHandler.SetConnectionString(azureConnectionString);

            PopulateTables();
        }

        private void PopulateTables()
        {
            tablesComboBox.Items.AddRange(DatabaseHandler.GetTables().ToArray());
        }

        private void buildBtn_Click(object sender, EventArgs e)
        {
            string findOutput;
            string insertOutput;
            string updateOutput;
            string deleteOutput;
            string propertiesOutput;

            if(tablesComboBox.SelectedText != null)
            {
                List<string> columns = DatabaseHandler.OrganiseColumns(tablesComboBox.SelectedItem.ToString());
                List<Column> cols = new List<Column>();
 
                for(int i = 0; i < columns.Count(); ++i)
                {
                    string[] splitColData = columns[i].Split(',');

                    Column c = new Column();

                    c.columnName = splitColData[0];
                    c.columnType = splitColData[1];

                    cols.Add(c);
                }

                //Make Properties
                for(int i = 0; i < cols.Count(); ++i)
                {
                    privateVarsText.Text += VisualBasic.MakeProperty(cols[i].columnName, cols[i].columnType);
                }


            }
        }

        

    }
}
