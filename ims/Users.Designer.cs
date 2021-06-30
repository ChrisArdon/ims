
namespace ims
{
    partial class Users
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
            this.label3 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.usernameErrorLabel = new System.Windows.Forms.Label();
            this.passwordErrorLabel = new System.Windows.Forms.Label();
            this.phoneErrorLabel = new System.Windows.Forms.Label();
            this.emailErrorLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UserIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.statusDD = new System.Windows.Forms.ComboBox();
            this.statusErrorLabel = new System.Windows.Forms.Label();
            this.nameErrorLabel = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTxt
            // 
            this.searchTxt.Size = new System.Drawing.Size(142, 23);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.statusDD);
            this.leftPanel.Controls.Add(this.label8);
            this.leftPanel.Controls.Add(this.panel5);
            this.leftPanel.Controls.Add(this.emailTxt);
            this.leftPanel.Controls.Add(this.label7);
            this.leftPanel.Controls.Add(this.phoneTxt);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.passwordTxt);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.usernameTxt);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.nameTxt);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.nameErrorLabel);
            this.leftPanel.Controls.Add(this.usernameErrorLabel);
            this.leftPanel.Controls.Add(this.passwordErrorLabel);
            this.leftPanel.Controls.Add(this.phoneErrorLabel);
            this.leftPanel.Controls.Add(this.emailErrorLabel);
            this.leftPanel.Controls.Add(this.statusErrorLabel);
            this.leftPanel.Size = new System.Drawing.Size(250, 732);
            this.leftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.leftPanel_Paint);
            this.leftPanel.Controls.SetChildIndex(this.statusErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.emailErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.phoneErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.passwordErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.usernameErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.nameErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.nameTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.usernameTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label5, 0);
            this.leftPanel.Controls.SetChildIndex(this.passwordTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label6, 0);
            this.leftPanel.Controls.SetChildIndex(this.phoneTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label7, 0);
            this.leftPanel.Controls.SetChildIndex(this.emailTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel5, 0);
            this.leftPanel.Controls.SetChildIndex(this.label8, 0);
            this.leftPanel.Controls.SetChildIndex(this.statusDD, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel1, 0);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 80);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.dataGridView1);
            this.rightPanel.Size = new System.Drawing.Size(914, 732);
            this.rightPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.rightPanel_Paint);
            this.rightPanel.Controls.SetChildIndex(this.panel2, 0);
            this.rightPanel.Controls.SetChildIndex(this.dataGridView1, 0);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(914, 40);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // nameTxt
            // 
            this.nameTxt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxt.Location = new System.Drawing.Point(15, 145);
            this.nameTxt.MaxLength = 30;
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(229, 23);
            this.nameTxt.TabIndex = 0;
            // 
            // usernameTxt
            // 
            this.usernameTxt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxt.Location = new System.Drawing.Point(15, 189);
            this.usernameTxt.MaxLength = 30;
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(229, 23);
            this.usernameTxt.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Username";
            // 
            // passwordTxt
            // 
            this.passwordTxt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.Location = new System.Drawing.Point(15, 233);
            this.passwordTxt.MaxLength = 30;
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(229, 23);
            this.passwordTxt.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Password";
            // 
            // phoneTxt
            // 
            this.phoneTxt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTxt.Location = new System.Drawing.Point(15, 277);
            this.phoneTxt.MaxLength = 15;
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(229, 23);
            this.phoneTxt.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Phone (03XX-XXXXXXX)";
            // 
            // emailTxt
            // 
            this.emailTxt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxt.Location = new System.Drawing.Point(15, 321);
            this.emailTxt.MaxLength = 50;
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(229, 23);
            this.emailTxt.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Email";
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(250, 29);
            this.panel5.TabIndex = 11;
            // 
            // usernameErrorLabel
            // 
            this.usernameErrorLabel.AutoSize = true;
            this.usernameErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.usernameErrorLabel.Location = new System.Drawing.Point(68, 167);
            this.usernameErrorLabel.Name = "usernameErrorLabel";
            this.usernameErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.usernameErrorLabel.TabIndex = 13;
            this.usernameErrorLabel.Text = "*";
            this.usernameErrorLabel.Visible = false;
            // 
            // passwordErrorLabel
            // 
            this.passwordErrorLabel.AutoSize = true;
            this.passwordErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.passwordErrorLabel.Location = new System.Drawing.Point(64, 211);
            this.passwordErrorLabel.Name = "passwordErrorLabel";
            this.passwordErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.passwordErrorLabel.TabIndex = 14;
            this.passwordErrorLabel.Text = "*";
            this.passwordErrorLabel.Visible = false;
            // 
            // phoneErrorLabel
            // 
            this.phoneErrorLabel.AutoSize = true;
            this.phoneErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.phoneErrorLabel.Location = new System.Drawing.Point(139, 255);
            this.phoneErrorLabel.Name = "phoneErrorLabel";
            this.phoneErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.phoneErrorLabel.TabIndex = 15;
            this.phoneErrorLabel.Text = "*";
            this.phoneErrorLabel.Visible = false;
            // 
            // emailErrorLabel
            // 
            this.emailErrorLabel.AutoSize = true;
            this.emailErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.emailErrorLabel.Location = new System.Drawing.Point(44, 298);
            this.emailErrorLabel.Name = "emailErrorLabel";
            this.emailErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.emailErrorLabel.TabIndex = 16;
            this.emailErrorLabel.Text = "*";
            this.emailErrorLabel.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserIDGV,
            this.NameGV,
            this.UserNameGV,
            this.PassGV,
            this.EmailGV,
            this.PhoneGV,
            this.StatusGV});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(914, 641);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // UserIDGV
            // 
            this.UserIDGV.HeaderText = "UserID";
            this.UserIDGV.Name = "UserIDGV";
            this.UserIDGV.ReadOnly = true;
            this.UserIDGV.Visible = false;
            // 
            // NameGV
            // 
            this.NameGV.HeaderText = "Name";
            this.NameGV.Name = "NameGV";
            this.NameGV.ReadOnly = true;
            // 
            // UserNameGV
            // 
            this.UserNameGV.HeaderText = "Username";
            this.UserNameGV.Name = "UserNameGV";
            this.UserNameGV.ReadOnly = true;
            // 
            // PassGV
            // 
            this.PassGV.HeaderText = "Password";
            this.PassGV.Name = "PassGV";
            this.PassGV.ReadOnly = true;
            this.PassGV.Visible = false;
            // 
            // EmailGV
            // 
            this.EmailGV.HeaderText = "Email";
            this.EmailGV.Name = "EmailGV";
            this.EmailGV.ReadOnly = true;
            // 
            // PhoneGV
            // 
            this.PhoneGV.HeaderText = "Phone #";
            this.PhoneGV.Name = "PhoneGV";
            this.PhoneGV.ReadOnly = true;
            // 
            // StatusGV
            // 
            this.StatusGV.HeaderText = "Status";
            this.StatusGV.Name = "StatusGV";
            this.StatusGV.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Status";
            // 
            // statusDD
            // 
            this.statusDD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusDD.FormattingEnabled = true;
            this.statusDD.Items.AddRange(new object[] {
            "Active",
            "In-active"});
            this.statusDD.Location = new System.Drawing.Point(15, 366);
            this.statusDD.Name = "statusDD";
            this.statusDD.Size = new System.Drawing.Size(229, 23);
            this.statusDD.TabIndex = 18;
            // 
            // statusErrorLabel
            // 
            this.statusErrorLabel.AutoSize = true;
            this.statusErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.statusErrorLabel.Location = new System.Drawing.Point(50, 343);
            this.statusErrorLabel.Name = "statusErrorLabel";
            this.statusErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.statusErrorLabel.TabIndex = 19;
            this.statusErrorLabel.Text = "*";
            this.statusErrorLabel.Visible = false;
            // 
            // nameErrorLabel
            // 
            this.nameErrorLabel.AutoSize = true;
            this.nameErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.nameErrorLabel.Location = new System.Drawing.Point(52, 123);
            this.nameErrorLabel.Name = "nameErrorLabel";
            this.nameErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.nameErrorLabel.TabIndex = 12;
            this.nameErrorLabel.Text = "*";
            this.nameErrorLabel.Visible = false;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 732);
            this.Name = "Users";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label usernameErrorLabel;
        private System.Windows.Forms.Label passwordErrorLabel;
        private System.Windows.Forms.Label phoneErrorLabel;
        private System.Windows.Forms.Label emailErrorLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusGV;
        private System.Windows.Forms.ComboBox statusDD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label statusErrorLabel;
        private System.Windows.Forms.Label nameErrorLabel;
    }
}