namespace View
{
    partial class UserView
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selectFeeder = new System.Windows.Forms.ComboBox();
            this.feedFeeder = new System.Windows.Forms.Button();
            this.removeTag = new System.Windows.Forms.Button();
            this.deleteFeeder = new System.Windows.Forms.Button();
            this.addFeederTag = new System.Windows.Forms.Button();
            this.tagFeeder = new System.Windows.Forms.TextBox();
            this.feederName = new System.Windows.Forms.Label();
            this.feederNameInput = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(793, 444);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.feederName);
            this.tabPage1.Controls.Add(this.feederNameInput);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(785, 418);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Feeders";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.selectFeeder);
            this.groupBox1.Controls.Add(this.feedFeeder);
            this.groupBox1.Controls.Add(this.removeTag);
            this.groupBox1.Controls.Add(this.deleteFeeder);
            this.groupBox1.Controls.Add(this.addFeederTag);
            this.groupBox1.Controls.Add(this.tagFeeder);
            this.groupBox1.Location = new System.Drawing.Point(346, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 191);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // selectFeeder
            // 
            this.selectFeeder.FormattingEnabled = true;
            this.selectFeeder.Location = new System.Drawing.Point(6, 19);
            this.selectFeeder.Name = "selectFeeder";
            this.selectFeeder.Size = new System.Drawing.Size(152, 21);
            this.selectFeeder.TabIndex = 6;
            // 
            // feedFeeder
            // 
            this.feedFeeder.Location = new System.Drawing.Point(241, 60);
            this.feedFeeder.Name = "feedFeeder";
            this.feedFeeder.Size = new System.Drawing.Size(72, 23);
            this.feedFeeder.TabIndex = 5;
            this.feedFeeder.Text = "Feed";
            this.feedFeeder.UseVisualStyleBackColor = true;
            // 
            // removeTag
            // 
            this.removeTag.Location = new System.Drawing.Point(319, 20);
            this.removeTag.Name = "removeTag";
            this.removeTag.Size = new System.Drawing.Size(71, 21);
            this.removeTag.TabIndex = 4;
            this.removeTag.Text = "Untag";
            this.removeTag.UseVisualStyleBackColor = true;
            this.removeTag.Click += new System.EventHandler(this.removeTag_Click);
            // 
            // deleteFeeder
            // 
            this.deleteFeeder.Location = new System.Drawing.Point(319, 62);
            this.deleteFeeder.Name = "deleteFeeder";
            this.deleteFeeder.Size = new System.Drawing.Size(71, 21);
            this.deleteFeeder.TabIndex = 3;
            this.deleteFeeder.Text = "Delete";
            this.deleteFeeder.UseVisualStyleBackColor = true;
            // 
            // addFeederTag
            // 
            this.addFeederTag.Location = new System.Drawing.Point(241, 20);
            this.addFeederTag.Name = "addFeederTag";
            this.addFeederTag.Size = new System.Drawing.Size(72, 21);
            this.addFeederTag.TabIndex = 2;
            this.addFeederTag.Text = "Tag";
            this.addFeederTag.UseVisualStyleBackColor = true;
            // 
            // tagFeeder
            // 
            this.tagFeeder.Location = new System.Drawing.Point(164, 20);
            this.tagFeeder.Name = "tagFeeder";
            this.tagFeeder.Size = new System.Drawing.Size(59, 20);
            this.tagFeeder.TabIndex = 1;
            // 
            // feederName
            // 
            this.feederName.AutoSize = true;
            this.feederName.Location = new System.Drawing.Point(365, 47);
            this.feederName.Name = "feederName";
            this.feederName.Size = new System.Drawing.Size(76, 13);
            this.feederName.TabIndex = 4;
            this.feederName.Text = "Feeder\'s name";
            this.feederName.Click += new System.EventHandler(this.label2_Click);
            // 
            // feederNameInput
            // 
            this.feederNameInput.Location = new System.Drawing.Point(346, 63);
            this.feederNameInput.Name = "feederNameInput";
            this.feederNameInput.Size = new System.Drawing.Size(108, 20);
            this.feederNameInput.TabIndex = 3;
            this.feederNameInput.TextChanged += new System.EventHandler(this.feederNameInput_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(272, 191);
            this.dataGridView1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(482, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Create a feeder with screw";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create a feeder with dispenser";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.checkedListBox1);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(785, 418);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Timetable and Logs";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(445, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "every";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(405, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(34, 20);
            this.textBox1.TabIndex = 8;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(225, 93);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(117, 21);
            this.comboBox2.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(318, 307);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(346, 349);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Export log";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(296, 175);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(171, 109);
            this.checkedListBox1.TabIndex = 4;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(458, 131);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Import";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(225, 131);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Export";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(293, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Set timetable for feeders";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // UserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "UserView";
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label feederName;
        private System.Windows.Forms.TextBox feederNameInput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button removeTag;
        private System.Windows.Forms.Button deleteFeeder;
        private System.Windows.Forms.Button addFeederTag;
        private System.Windows.Forms.TextBox tagFeeder;
        private System.Windows.Forms.ComboBox selectFeeder;
        private System.Windows.Forms.Button feedFeeder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}