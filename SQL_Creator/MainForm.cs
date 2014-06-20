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
            Reset();
        }

        private void Reset()
        {
            findText.Text = "";
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

            if(serverName.Trim().Length < 1 || username.Trim().Length < 1 || dbName.Trim().Length < 1)
            {
                MessageBox.Show("Cannot connect to database, ensure all details have been entered and try again.", "Connection Error");
                return;
            }

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
            try
            {
                tablesComboBox.Items.AddRange(DatabaseHandler.GetTables().ToArray());
            }
            catch(Exception e)
            {
                MessageBox.Show("Unable to load table. Check the table is correct and try again.", "Table Error", MessageBoxButtons.OK);
            }
        }

        private void buildBtn_Click(object sender, EventArgs e)
        {
            if(tablesComboBox.SelectedText != null)
            {
                Reset();

                List<string> columns = DatabaseHandler.OrganiseColumns(tablesComboBox.SelectedItem.ToString());
                List<Column> cols = new List<Column>();
 
                for(int i = 0; i < columns.Count(); ++i)
                {
                    string[] splitColData = columns[i].Split(',');

                    Column c = new Column();

                    c.columnName = splitColData[0];
                    c.columnType = splitColData[1];
                    c.columnDefaultVal = splitColData[2];

                    cols.Add(c);
                }

                //Make Update
                updateText.Text = VisualBasic.MakeUpdate(tablesComboBox.SelectedItem.ToString(), cols);

                //Make Properties
                for(int i = 0; i < cols.Count(); ++i)
                {
                    privateVarsText.Text += VisualBasic.MakeProperty(cols[i].columnName, cols[i].columnType);
                }

                privateVarsText.Text += VisualBasic.MakeConnectionString(settingsConnectionStringTest.Text);

                //Make Delete
                deleteText.Text = VisualBasic.MakeDelete(tablesComboBox.SelectedItem.ToString(), cols[0].columnName);

                //Make Find
                findText.Text = VisualBasic.MakeFind(tablesComboBox.SelectedItem.ToString(), cols);

                //Make Create
                insertText.Text = VisualBasic.MakeCreate(tablesComboBox.SelectedItem.ToString(), cols);

                //Make Defaults
                defaultText.Text = VisualBasic.MakeDefaults(cols);
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings s = new Settings();
            s.ShowDialog();

            if(s.reloadForm)
            {
                LoadSettings();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        public void LoadSettings()
        {
            serverNameText.Text = Properties.Settings.Default.ServerName;
            usernameText.Text = Properties.Settings.Default.UserName;
        }

        

    }
}
