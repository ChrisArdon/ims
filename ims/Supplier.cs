using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ims
{
    public partial class Supplier : Sample2
    {
        public Supplier()
        {
            InitializeComponent();
        }

        int edit = 0;
        int userID;
        short stat;
        retrieval r = new retrieval();

        private void Supplier_Load(object sender, EventArgs e)
        {
            MainClass.disable(leftPanel); //we disable the elements from leftpanel with the method of MainClass
        }


        private void leftPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        public virtual void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void addBtn_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(leftPanel); //after we click "add" the register panel will be unlocked
            edit = 0;
        }

        public virtual void editBtn_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.enable(leftPanel);
        }

        public virtual void saveBtn_Click(object sender, EventArgs e)
        {
            //Here we enable and disable the red asterisc "*" in the form, validating that no txt left unfilled
            if (supplierCompanyTxt.Text == "") { supplierNameErrorLbl.Visible = true; } else { supplierNameErrorLbl.Visible = false; }
            if (personNameTxt.Text == "") { contactPersonErrorLbl.Visible = true; } else { contactPersonErrorLbl.Visible = false; }
            if (Phone1Txt.Text == "") { phone1ErrorLbl.Visible = true; } else { phone1ErrorLbl.Visible = false; }
            if (addressTxt.Text == "") { addressErrorLbl.Visible = true; } else { addressErrorLbl.Visible = false; }
            if (statusDD.SelectedIndex == -1) { statusErrorLbl.Visible = true; } else { statusErrorLbl.Visible = false; }

            if (supplierNameErrorLbl.Visible || contactPersonErrorLbl.Visible || phone1ErrorLbl.Visible || addressErrorLbl.Visible || statusErrorLbl.Visible)
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
                        u.updateUser(userID, nameTxt.Text, usernameTxt.Text, passwordTxt.Text, emailTxt.Text, phoneTxt.Text, stat);
                        r.showUsers(dataGridView1, UserIDGV, NameGV, UserNameGV, PassGV, EmailGV, PhoneGV, StatusGV);
                        MainClass.disable_reset(leftPanel);
                    }



                }
            }
        }

        public virtual void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        public virtual void viewBtn_Click(object sender, EventArgs e) //Public virtual void to inherit: Build >> rebuild solution in Users form
        {

        }
    }
}
