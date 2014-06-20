namespace SQL_Creator
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.settingsText = new System.Windows.Forms.TextBox();
            this.saveSettingsBtn = new System.Windows.Forms.Button();
            this.closeSettingsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // settingsText
            // 
            this.settingsText.Location = new System.Drawing.Point(12, 12);
            this.settingsText.Multiline = true;
            this.settingsText.Name = "settingsText";
            this.settingsText.Size = new System.Drawing.Size(614, 321);
            this.settingsText.TabIndex = 0;
            // 
            // saveSettingsBtn
            // 
            this.saveSettingsBtn.Location = new System.Drawing.Point(404, 339);
            this.saveSettingsBtn.Name = "saveSettingsBtn";
            this.saveSettingsBtn.Size = new System.Drawing.Size(108, 37);
            this.saveSettingsBtn.TabIndex = 1;
            this.saveSettingsBtn.Text = "Save";
            this.saveSettingsBtn.UseVisualStyleBackColor = true;
            this.saveSettingsBtn.Click += new System.EventHandler(this.saveSettingsBtn_Click);
            // 
            // closeSettingsBtn
            // 
            this.closeSettingsBtn.Location = new System.Drawing.Point(518, 339);
            this.closeSettingsBtn.Name = "closeSettingsBtn";
            this.closeSettingsBtn.Size = new System.Drawing.Size(108, 37);
            this.closeSettingsBtn.TabIndex = 2;
            this.closeSettingsBtn.Text = "Close";
            this.closeSettingsBtn.UseVisualStyleBackColor = true;
            this.closeSettingsBtn.Click += new System.EventHandler(this.closeSettingsBtn_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 388);
            this.Controls.Add(this.closeSettingsBtn);
            this.Controls.Add(this.saveSettingsBtn);
            this.Controls.Add(this.settingsText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox settingsText;
        private System.Windows.Forms.Button saveSettingsBtn;
        private System.Windows.Forms.Button closeSettingsBtn;
    }
}