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
            this.listView1 = new System.Windows.Forms.ListView();
            this.userSelect = new System.Windows.Forms.ComboBox();
            this.feederNameInput = new System.Windows.Forms.TextBox();
            this.userNameInput = new System.Windows.Forms.TextBox();
            this.addFeeder = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.addUser = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.logPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logs)).BeginInit();
            this.mainPage.SuspendLayout();
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
            this.mainPage.Controls.Add(this.label4);
            this.mainPage.Controls.Add(this.label3);
            this.mainPage.Controls.Add(this.label2);
            this.mainPage.Controls.Add(this.label1);
            this.mainPage.Controls.Add(this.textBox1);
            this.mainPage.Controls.Add(this.listView1);
            this.mainPage.Controls.Add(this.userSelect);
            this.mainPage.Controls.Add(this.feederNameInput);
            this.mainPage.Controls.Add(this.userNameInput);
            this.mainPage.Controls.Add(this.addFeeder);
            this.mainPage.Controls.Add(this.button1);
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
            this.userSelect.Location = new System.Drawing.Point(150, 69);
            this.userSelect.Name = "userSelect";
            this.userSelect.Size = new System.Drawing.Size(121, 21);
            this.userSelect.TabIndex = 18;
            this.userSelect.SelectedIndexChanged += new System.EventHandler(this.userSelect_SelectedIndexChanged_1);
            // 
            // feederNameInput
            // 
            this.feederNameInput.Location = new System.Drawing.Point(8, 70);
            this.feederNameInput.Name = "feederNameInput";
            this.feederNameInput.Size = new System.Drawing.Size(107, 20);
            this.feederNameInput.TabIndex = 17;
            this.feederNameInput.TextChanged += new System.EventHandler(this.feederNameInput_TextChanged);
            // 
            // userNameInput
            // 
            this.userNameInput.Location = new System.Drawing.Point(299, 101);
            this.userNameInput.Name = "userNameInput";
            this.userNameInput.Size = new System.Drawing.Size(100, 20);
            this.userNameInput.TabIndex = 8;
            this.userNameInput.TextChanged += new System.EventHandler(this.userNameInput_TextChanged);
            // 
            // addFeeder
            // 
            this.addFeeder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addFeeder.Location = new System.Drawing.Point(82, 208);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 136);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(107, 20);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Create feeder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "User";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Type";
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
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage logPage;
        private System.Windows.Forms.DataGridView logs;
        private System.Windows.Forms.Button exportLog;
        private System.Windows.Forms.TabPage mainPage;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox userSelect;
        private System.Windows.Forms.TextBox feederNameInput;
        private System.Windows.Forms.TextBox userNameInput;
        private System.Windows.Forms.Button addFeeder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}