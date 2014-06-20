using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SQL_Creator
{
    public partial class Settings : Form
    {
        private bool SettingsChanged = false;
        public bool reloadForm = false;

        public Settings()
        {
            InitializeComponent();
        }

        private void closeSettingsBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            /*
             *  Settings for: 
             *      Default Language: Name - DefaultLanguage, Value - string
             *      Server Name: Name - ServerName, Value - string
             *      Username: Name - UserName, Value - string
             * 
             */

            settingsText.Text += "DefaultLanguage=" + Properties.Settings.Default.DefaultLanguage + "\r\n";
            settingsText.Text += "ServerName=" + Properties.Settings.Default.ServerName + "\r\n";
            settingsText.Text += "UserName=" + Properties.Settings.Default.UserName;

            settingsText.TextChanged += new EventHandler(Settings_TextChanged);
        }

        private void Settings_TextChanged(object sender, EventArgs e)
        {
            if (!SettingsChanged)
            {
                SettingsChanged = true;
            }
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            CheckForSave();
        }

        private void CheckForSave()
        {
            if (SettingsChanged)
            {
                if (MessageBox.Show("The settings seem to have been changed. Save Changes?", "Settings Changed", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SaveSettings();
                }
            }
        }

        private void SaveSettings()
        {
            string[] settingsLines = new string[settingsText.Lines.Length];

            for (int i = 0; i < settingsText.Lines.Length; ++i)
            {
                string[] line = settingsText.Lines[i].Split('=');

                string name = line[0];
                string val = line[1];

                name = name.Replace(" ", "").ToLower();

                switch (name)
                {
                    case "defaultlanguage":
                        Properties.Settings.Default.DefaultLanguage = val.Trim();
                        break;
                    case "servername":
                        Properties.Settings.Default.ServerName = val.Trim();
                        break;
                    case "username":
                        Properties.Settings.Default.UserName = val.Trim();
                        break;
                    default:
                        break;
                }

            }

            Properties.Settings.Default.Save();
            reloadForm = true;
        }

        private void saveSettingsBtn_Click(object sender, EventArgs e)
        {
            SaveSettings();
            SettingsChanged = false;
        }
    }
}
