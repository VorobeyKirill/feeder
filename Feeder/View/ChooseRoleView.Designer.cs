using System;

namespace View
{
    partial class ChooseRoleView
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
            this.SelectAdmin = new System.Windows.Forms.Button();
            this.SelectUser = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectAdmin
            // 
            this.SelectAdmin.Location = new System.Drawing.Point(66, 44);
            this.SelectAdmin.Name = "SelectAdmin";
            this.SelectAdmin.Size = new System.Drawing.Size(128, 45);
            this.SelectAdmin.TabIndex = 0;
            this.SelectAdmin.Text = "Admin";
            this.SelectAdmin.UseVisualStyleBackColor = true;
            this.SelectAdmin.Click += new System.EventHandler(this.SelectAdmin_Click);
            // 
            // SelectUser
            // 
            this.SelectUser.Location = new System.Drawing.Point(264, 44);
            this.SelectUser.Name = "SelectUser";
            this.SelectUser.Size = new System.Drawing.Size(128, 45);
            this.SelectUser.TabIndex = 1;
            this.SelectUser.Text = "User";
            this.SelectUser.UseVisualStyleBackColor = true;
            this.SelectUser.Click += new System.EventHandler(this.SelectUser_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(109, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // ChooseRoleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 261);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SelectUser);
            this.Controls.Add(this.SelectAdmin);
            this.Name = "ChooseRoleView";
            this.Text = "ChooseRole";
            this.Load += new System.EventHandler(this.ChooseRoleView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

       

        #endregion

        private System.Windows.Forms.Button SelectAdmin;
        private System.Windows.Forms.Button SelectUser;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}