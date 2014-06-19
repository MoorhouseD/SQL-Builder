namespace SQL_Creator
{
    partial class MainForm
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
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.findTab = new System.Windows.Forms.TabPage();
            this.findText = new System.Windows.Forms.TextBox();
            this.insertTab = new System.Windows.Forms.TabPage();
            this.insertText = new System.Windows.Forms.TextBox();
            this.updateTab = new System.Windows.Forms.TabPage();
            this.updateText = new System.Windows.Forms.TextBox();
            this.deleteTab = new System.Windows.Forms.TabPage();
            this.deleteText = new System.Windows.Forms.TextBox();
            this.privateVarsTab = new System.Windows.Forms.TabPage();
            this.privateVarsText = new System.Windows.Forms.TextBox();
            this.settingsGroup = new System.Windows.Forms.GroupBox();
            this.connectBtn = new System.Windows.Forms.Button();
            this.tablesComboBox = new System.Windows.Forms.ComboBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.buildBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dbText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.serverNameText = new System.Windows.Forms.TextBox();
            this.mainMenuStrip.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.findTab.SuspendLayout();
            this.insertTab.SuspendLayout();
            this.updateTab.SuspendLayout();
            this.deleteTab.SuspendLayout();
            this.privateVarsTab.SuspendLayout();
            this.settingsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.languageToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(1106, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vBToolStripMenuItem,
            this.cToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // vBToolStripMenuItem
            // 
            this.vBToolStripMenuItem.Checked = true;
            this.vBToolStripMenuItem.CheckOnClick = true;
            this.vBToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.vBToolStripMenuItem.Name = "vBToolStripMenuItem";
            this.vBToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.vBToolStripMenuItem.Text = "Visual Basic";
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.CheckOnClick = true;
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.cToolStripMenuItem.Text = "C#";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.findTab);
            this.tabControl1.Controls.Add(this.insertTab);
            this.tabControl1.Controls.Add(this.updateTab);
            this.tabControl1.Controls.Add(this.deleteTab);
            this.tabControl1.Controls.Add(this.privateVarsTab);
            this.tabControl1.Location = new System.Drawing.Point(446, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(648, 556);
            this.tabControl1.TabIndex = 2;
            // 
            // findTab
            // 
            this.findTab.Controls.Add(this.findText);
            this.findTab.Location = new System.Drawing.Point(4, 22);
            this.findTab.Name = "findTab";
            this.findTab.Padding = new System.Windows.Forms.Padding(3);
            this.findTab.Size = new System.Drawing.Size(640, 530);
            this.findTab.TabIndex = 4;
            this.findTab.Text = "Find";
            this.findTab.UseVisualStyleBackColor = true;
            // 
            // findText
            // 
            this.findText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.findText.Location = new System.Drawing.Point(9, 9);
            this.findText.Multiline = true;
            this.findText.Name = "findText";
            this.findText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.findText.Size = new System.Drawing.Size(623, 513);
            this.findText.TabIndex = 2;
            // 
            // insertTab
            // 
            this.insertTab.Controls.Add(this.insertText);
            this.insertTab.Location = new System.Drawing.Point(4, 22);
            this.insertTab.Name = "insertTab";
            this.insertTab.Padding = new System.Windows.Forms.Padding(3);
            this.insertTab.Size = new System.Drawing.Size(640, 530);
            this.insertTab.TabIndex = 0;
            this.insertTab.Text = "Insert";
            this.insertTab.UseVisualStyleBackColor = true;
            // 
            // insertText
            // 
            this.insertText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.insertText.Location = new System.Drawing.Point(9, 9);
            this.insertText.Multiline = true;
            this.insertText.Name = "insertText";
            this.insertText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.insertText.Size = new System.Drawing.Size(623, 513);
            this.insertText.TabIndex = 1;
            // 
            // updateTab
            // 
            this.updateTab.Controls.Add(this.updateText);
            this.updateTab.Location = new System.Drawing.Point(4, 22);
            this.updateTab.Name = "updateTab";
            this.updateTab.Padding = new System.Windows.Forms.Padding(3);
            this.updateTab.Size = new System.Drawing.Size(640, 530);
            this.updateTab.TabIndex = 1;
            this.updateTab.Text = "Update";
            this.updateTab.UseVisualStyleBackColor = true;
            // 
            // updateText
            // 
            this.updateText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updateText.Location = new System.Drawing.Point(9, 9);
            this.updateText.Multiline = true;
            this.updateText.Name = "updateText";
            this.updateText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.updateText.Size = new System.Drawing.Size(623, 513);
            this.updateText.TabIndex = 1;
            // 
            // deleteTab
            // 
            this.deleteTab.Controls.Add(this.deleteText);
            this.deleteTab.Location = new System.Drawing.Point(4, 22);
            this.deleteTab.Name = "deleteTab";
            this.deleteTab.Padding = new System.Windows.Forms.Padding(3);
            this.deleteTab.Size = new System.Drawing.Size(640, 530);
            this.deleteTab.TabIndex = 2;
            this.deleteTab.Text = "Delete";
            this.deleteTab.UseVisualStyleBackColor = true;
            // 
            // deleteText
            // 
            this.deleteText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteText.Location = new System.Drawing.Point(9, 9);
            this.deleteText.Multiline = true;
            this.deleteText.Name = "deleteText";
            this.deleteText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.deleteText.Size = new System.Drawing.Size(623, 513);
            this.deleteText.TabIndex = 1;
            // 
            // privateVarsTab
            // 
            this.privateVarsTab.Controls.Add(this.privateVarsText);
            this.privateVarsTab.Location = new System.Drawing.Point(4, 22);
            this.privateVarsTab.Name = "privateVarsTab";
            this.privateVarsTab.Padding = new System.Windows.Forms.Padding(3);
            this.privateVarsTab.Size = new System.Drawing.Size(640, 530);
            this.privateVarsTab.TabIndex = 3;
            this.privateVarsTab.Text = "Private Vars";
            this.privateVarsTab.UseVisualStyleBackColor = true;
            // 
            // privateVarsText
            // 
            this.privateVarsText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.privateVarsText.Location = new System.Drawing.Point(8, 7);
            this.privateVarsText.Multiline = true;
            this.privateVarsText.Name = "privateVarsText";
            this.privateVarsText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.privateVarsText.Size = new System.Drawing.Size(623, 513);
            this.privateVarsText.TabIndex = 0;
            // 
            // settingsGroup
            // 
            this.settingsGroup.Controls.Add(this.connectBtn);
            this.settingsGroup.Controls.Add(this.tablesComboBox);
            this.settingsGroup.Controls.Add(this.resetBtn);
            this.settingsGroup.Controls.Add(this.buildBtn);
            this.settingsGroup.Controls.Add(this.label5);
            this.settingsGroup.Controls.Add(this.label4);
            this.settingsGroup.Controls.Add(this.label3);
            this.settingsGroup.Controls.Add(this.label2);
            this.settingsGroup.Controls.Add(this.label1);
            this.settingsGroup.Controls.Add(this.dbText);
            this.settingsGroup.Controls.Add(this.passwordText);
            this.settingsGroup.Controls.Add(this.usernameText);
            this.settingsGroup.Controls.Add(this.serverNameText);
            this.settingsGroup.Location = new System.Drawing.Point(12, 27);
            this.settingsGroup.Name = "settingsGroup";
            this.settingsGroup.Size = new System.Drawing.Size(416, 552);
            this.settingsGroup.TabIndex = 3;
            this.settingsGroup.TabStop = false;
            this.settingsGroup.Text = "Settings";
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(248, 222);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(162, 55);
            this.connectBtn.TabIndex = 13;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // tablesComboBox
            // 
            this.tablesComboBox.FormattingEnabled = true;
            this.tablesComboBox.Location = new System.Drawing.Point(135, 367);
            this.tablesComboBox.Name = "tablesComboBox";
            this.tablesComboBox.Size = new System.Drawing.Size(275, 21);
            this.tablesComboBox.TabIndex = 12;
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(249, 441);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(161, 55);
            this.resetBtn.TabIndex = 11;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // buildBtn
            // 
            this.buildBtn.Location = new System.Drawing.Point(81, 441);
            this.buildBtn.Name = "buildBtn";
            this.buildBtn.Size = new System.Drawing.Size(162, 55);
            this.buildBtn.TabIndex = 10;
            this.buildBtn.Text = "Build";
            this.buildBtn.UseVisualStyleBackColor = true;
            this.buildBtn.Click += new System.EventHandler(this.buildBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Table Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Database Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Server Name";
            // 
            // dbText
            // 
            this.dbText.Location = new System.Drawing.Point(135, 173);
            this.dbText.Name = "dbText";
            this.dbText.Size = new System.Drawing.Size(275, 20);
            this.dbText.TabIndex = 3;
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(135, 130);
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '*';
            this.passwordText.Size = new System.Drawing.Size(275, 20);
            this.passwordText.TabIndex = 2;
            this.passwordText.Text = "gkm@2836";
            // 
            // usernameText
            // 
            this.usernameText.Location = new System.Drawing.Point(135, 89);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(275, 20);
            this.usernameText.TabIndex = 1;
            this.usernameText.Text = "gkmtest";
            // 
            // serverNameText
            // 
            this.serverNameText.Location = new System.Drawing.Point(135, 47);
            this.serverNameText.Name = "serverNameText";
            this.serverNameText.Size = new System.Drawing.Size(275, 20);
            this.serverNameText.TabIndex = 0;
            this.serverNameText.Text = "fm7ohm9oxy";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 595);
            this.Controls.Add(this.settingsGroup);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL Builder";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.findTab.ResumeLayout(false);
            this.findTab.PerformLayout();
            this.insertTab.ResumeLayout(false);
            this.insertTab.PerformLayout();
            this.updateTab.ResumeLayout(false);
            this.updateTab.PerformLayout();
            this.deleteTab.ResumeLayout(false);
            this.deleteTab.PerformLayout();
            this.privateVarsTab.ResumeLayout(false);
            this.privateVarsTab.PerformLayout();
            this.settingsGroup.ResumeLayout(false);
            this.settingsGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage insertTab;
        private System.Windows.Forms.TabPage updateTab;
        private System.Windows.Forms.TabPage deleteTab;
        private System.Windows.Forms.TabPage privateVarsTab;
        private System.Windows.Forms.GroupBox settingsGroup;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button buildBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dbText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.TextBox serverNameText;
        private System.Windows.Forms.TextBox insertText;
        private System.Windows.Forms.TextBox updateText;
        private System.Windows.Forms.TextBox deleteText;
        private System.Windows.Forms.TextBox privateVarsText;
        private System.Windows.Forms.ComboBox tablesComboBox;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.TabPage findTab;
        private System.Windows.Forms.TextBox findText;
    }
}

