using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ims
{
    public partial class Users : Sample2 //This will inherit the Sample2 traits, which is the users' interface
    {
        int edit = 0; //This 0 is an indication to SAVE operation and 1 is an indication to UPDATE operation
        int userID;
        short stat;
        public Users()
        {
            InitializeComponent();
        }

        retrieval r = new retrieval();

        private void Users_Load(object sender, EventArgs e)
        {
            MainClass.disable(leftPanel); //we disable the elements from leftpanel with the method of MainClass
            //r.showUsers(dataGridView1, UserIDGV, NameGV, UserNameGV, PassGV, EmailGV, PhoneGV, StatusGV); //Load the Grid View
        }

        private void rightPanel_Paint(object sender, PaintEventArgs e)
        {

        }





        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure , you want to delete record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    deletion d = new deletion();
                    d.delete(userID, "st_deleteUser", "@id");
                    r.showUsers(dataGridView1, UserIDGV, NameGV, UserNameGV, PassGV, EmailGV, PhoneGV, StatusGV);
                }             
            }
        }

        public override void addBtn_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(leftPanel); //after we click "add" the register panel will be unlocked
            edit = 0;
        }

        public override void editBtn_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.enable(leftPanel);
        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            //Here we enable and disable the red asterisc "*" in the form, validating that no txt left unfilled
            if (nameTxt.Text == "") { nameErrorLabel.Visible = true; } else { nameErrorLabel.Visible = false; }
            if (usernameTxt.Text == "") { usernameErrorLabel.Visible = true; } else { usernameErrorLabel.Visible = false; }
            if (passwordTxt.Text == "") { passwordErrorLabel.Visible = true; } else { passwordErrorLabel.Visible = false; }
            if (emailTxt.Text == "") { emailErrorLabel.Visible = true; } else { emailErrorLabel.Visible = false; }
            if (phoneTxt.Text == "") { phoneErrorLabel.Visible = true; } else { phoneErrorLabel.Visible = false; }
            if (statusDD.SelectedIndex == -1) { statusErrorLabel.Visible = true; } else { statusErrorLabel.Visible = false; }

            if (nameErrorLabel.Visible || usernameErrorLabel.Visible || passwordErrorLabel.Visible || emailErrorLabel.Visible || phoneErrorLabel.Visible || statusErrorLabel.Visible)
            {
                MainClass.ShowMSG("Fields with * are mandatory", "Stop", "Error"); //Error is the type of msg
            }
            else
            {
                
                if (statusDD.SelectedIndex == 0)
                {
                    stat = 1;
                }
                else if (statusDD.SelectedIndex == 1)
                {
                    stat = 0;
                }
                if (edit == 0) //Code for SAVE operation
                {
                  
                    insertion i = new insertion();
                   
                    i.insertUser(nameTxt.Text, usernameTxt.Text, passwordTxt.Text, emailTxt.Text, phoneTxt.Text, stat);
                    r.showUsers(dataGridView1, UserIDGV, NameGV, UserNameGV, PassGV, EmailGV, PhoneGV, StatusGV);
                    MainClass.disable_reset(leftPanel);

                }
                else if (edit == 1) //Code for UPDATE operation
                {
                    DialogResult dr = MessageBox.Show("Are you sure , you want to update record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        updation u = new updation();
                        if (statusDD.SelectedIndex == 0)
                        {
                            stat = 1;
                        }
                        else if (statusDD.SelectedIndex == 1)
                        {
                            stat = 0;
                        }
                        u.updateUser(userID, nameTxt.Text, usernameTxt.Text, passwordTxt.Text, emailTxt.Text, phoneTxt.Text, stat);
                        r.showUsers(dataGridView1, UserIDGV, NameGV, UserNameGV, PassGV, EmailGV, PhoneGV, StatusGV);
                        MainClass.disable_reset(leftPanel);
                    }
                    
                    
                    
                }
            }
        }

        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {
            if (searchTxt.Text != "")
            {
                r.showUsers(dataGridView1, UserIDGV, NameGV, UserNameGV, PassGV, EmailGV, PhoneGV, StatusGV, searchTxt.Text);
            }
            else
            {
                r.showUsers(dataGridView1, UserIDGV, NameGV, UserNameGV, PassGV, EmailGV, PhoneGV, StatusGV);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void leftPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        public override void viewBtn_Click(object sender, EventArgs e) //Public override void to inherit: Build >> rebuild solution in Users form
        {
            r.showUsers(dataGridView1, UserIDGV, NameGV, UserNameGV, PassGV, EmailGV, PhoneGV, StatusGV);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) //This is for the VIEW section
        {
            if (e.RowIndex != -1) //e is referencing to the column index and row index
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                userID = Convert.ToInt32(row.Cells["userIDGV"].Value.ToString()); // We get the userID of the selected cell. https://youtu.be/B5td7E7YGeA min 11:10
                nameTxt.Text = row.Cells["NameGV"].Value.ToString();
                usernameTxt.Text = row.Cells["UserNameGV"].Value.ToString();
                passwordTxt.Text = row.Cells["PassGV"].Value.ToString();
                phoneTxt.Text = row.Cells["PhoneGV"].Value.ToString();
                emailTxt.Text = row.Cells["EmailGV"].Value.ToString();
                statusDD.SelectedItem = row.Cells["StatusGV"].Value.ToString();
                MainClass.disable(leftPanel);
            }
        }
    }
}
