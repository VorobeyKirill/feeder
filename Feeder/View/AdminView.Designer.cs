namespace View
{
    partial class AdminView
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
            this.logPage = new System.Windows.Forms.TabPage();
            this.logs = new System.Windows.Forms.DataGridView();
            this.exportLog = new System.Windows.Forms.Button();
            this.mainPage = new System.Windows.Forms.TabPage();
            this.screwFeeder = new System.Windows.Forms.RadioButton();
            this.dispencerFeeder = new System.Windows.Forms.RadioButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.userSelect = new System.Windows.Forms.ComboBox();
            this.feederNameInput = new System.Windows.Forms.TextBox();
            this.userNameInput = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.addFeeder = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.userList = new System.Windows.Forms.DataGridView();
            this.addUser = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.logPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logs)).BeginInit();
            this.mainPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userList)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logPage
            // 
            this.logPage.Controls.Add(this.logs);
            this.logPage.Controls.Add(this.exportLog);
            this.logPage.Location = new System.Drawing.Point(4, 22);
            this.logPage.Name = "logPage";
            this.logPage.Padding = new System.Windows.Forms.Padding(3);
            this.logPage.Size = new System.Drawing.Size(502, 316);
            this.logPage.TabIndex = 1;
            this.logPage.Text = "Log";
            this.logPage.UseVisualStyleBackColor = true;
            // 
            // logs
            // 
            this.logs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.logs.Location = new System.Drawing.Point(131, 22);
            this.logs.Name = "logs";
            this.logs.Size = new System.Drawing.Size(240, 150);
            this.logs.TabIndex = 2;
            // 
            // exportLog
            // 
            this.exportLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exportLog.Location = new System.Drawing.Point(197, 187);
            this.exportLog.Name = "exportLog";
            this.exportLog.Size = new System.Drawing.Size(104, 33);
            this.exportLog.TabIndex = 1;
            this.exportLog.Text = "Export log";
            this.exportLog.UseVisualStyleBackColor = true;
            this.exportLog.Click += new System.EventHandler(this.button4_Click);
            // 
            // mainPage
            // 
            this.mainPage.Controls.Add(this.screwFeeder);
            this.mainPage.Controls.Add(this.dispencerFeeder);
            this.mainPage.Controls.Add(this.listView1);
            this.mainPage.Controls.Add(this.userSelect);
            this.mainPage.Controls.Add(this.feederNameInput);
            this.mainPage.Controls.Add(this.userNameInput);
            this.mainPage.Controls.Add(this.dataGridView3);
            this.mainPage.Controls.Add(this.addFeeder);
            this.mainPage.Controls.Add(this.button1);
            this.mainPage.Controls.Add(this.userList);
            this.mainPage.Controls.Add(this.addUser);
            this.mainPage.Location = new System.Drawing.Point(4, 22);
            this.mainPage.Name = "mainPage";
            this.mainPage.Padding = new System.Windows.Forms.Padding(3);
            this.mainPage.Size = new System.Drawing.Size(502, 316);
            this.mainPage.TabIndex = 0;
            this.mainPage.Text = "Register and add feeders";
            this.mainPage.UseVisualStyleBackColor = true;
            this.mainPage.Click += new System.EventHandler(this.mainPage_Click);
            // 
            // screwFeeder
            // 
            this.screwFeeder.AutoSize = true;
            this.screwFeeder.Location = new System.Drawing.Point(140, 190);
            this.screwFeeder.Name = "screwFeeder";
            this.screwFeeder.Size = new System.Drawing.Size(78, 17);
            this.screwFeeder.TabIndex = 21;
            this.screwFeeder.TabStop = true;
            this.screwFeeder.Text = "With screw";
            this.screwFeeder.UseVisualStyleBackColor = true;
            this.screwFeeder.CheckedChanged += new System.EventHandler(this.screwFeeder_CheckedChanged);
            // 
            // dispencerFeeder
            // 
            this.dispencerFeeder.AutoSize = true;
            this.dispencerFeeder.Checked = true;
            this.dispencerFeeder.Location = new System.Drawing.Point(18, 190);
            this.dispencerFeeder.Name = "dispencerFeeder";
            this.dispencerFeeder.Size = new System.Drawing.Size(95, 17);
            this.dispencerFeeder.TabIndex = 20;
            this.dispencerFeeder.TabStop = true;
            this.dispencerFeeder.Text = "With dispenser";
            this.dispencerFeeder.UseVisualStyleBackColor = true;
            this.dispencerFeeder.CheckedChanged += new System.EventHandler(this.dispencerFeeder_CheckedChanged);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(299, 136);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(177, 128);
            this.listView1.TabIndex = 19;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // userSelect
            // 
            this.userSelect.FormattingEnabled = true;
            this.userSelect.Location = new System.Drawing.Point(127, 163);
            this.userSelect.Name = "userSelect";
            this.userSelect.Size = new System.Drawing.Size(121, 21);
            this.userSelect.TabIndex = 18;
            // 
            // feederNameInput
            // 
            this.feederNameInput.Location = new System.Drawing.Point(6, 164);
            this.feederNameInput.Name = "feederNameInput";
            this.feederNameInput.Size = new System.Drawing.Size(107, 20);
            this.feederNameInput.TabIndex = 17;
            // 
            // userNameInput
            // 
            this.userNameInput.Location = new System.Drawing.Point(299, 101);
            this.userNameInput.Name = "userNameInput";
            this.userNameInput.Size = new System.Drawing.Size(100, 20);
            this.userNameInput.TabIndex = 8;
            this.userNameInput.TextChanged += new System.EventHandler(this.userNameInput_TextChanged);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 6);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(242, 152);
            this.dataGridView3.TabIndex = 16;
            // 
            // addFeeder
            // 
            this.addFeeder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addFeeder.Location = new System.Drawing.Point(67, 213);
            this.addFeeder.Name = "addFeeder";
            this.addFeeder.Size = new System.Drawing.Size(110, 33);
            this.addFeeder.TabIndex = 15;
            this.addFeeder.Text = "Add";
            this.addFeeder.UseVisualStyleBackColor = true;
            this.addFeeder.Click += new System.EventHandler(this.addFeeder_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(353, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 14;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // userList
            // 
            this.userList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userList.Location = new System.Drawing.Point(299, 6);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(177, 77);
            this.userList.TabIndex = 6;
            // 
            // addUser
            // 
            this.addUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addUser.Location = new System.Drawing.Point(401, 100);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(75, 20);
            this.addUser.TabIndex = 1;
            this.addUser.Text = "Register";
            this.addUser.UseVisualStyleBackColor = true;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.mainPage);
            this.tabControl1.Controls.Add(this.logPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(510, 342);
            this.tabControl1.TabIndex = 0;
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 342);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminView";
            this.Text = "Admin";
            this.logPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logs)).EndInit();
            this.mainPage.ResumeLayout(false);
            this.mainPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userList)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage logPage;
        private System.Windows.Forms.DataGridView logs;
        private System.Windows.Forms.Button exportLog;
        private System.Windows.Forms.TabPage mainPage;
        private System.Windows.Forms.RadioButton screwFeeder;
        private System.Windows.Forms.RadioButton dispencerFeeder;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox userSelect;
        private System.Windows.Forms.TextBox feederNameInput;
        private System.Windows.Forms.TextBox userNameInput;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button addFeeder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView userList;
        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.TabControl tabControl1;
    }
}