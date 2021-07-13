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
        int supplierID;
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
                    //validating the null fields 
                    if (phone2Txt.Text == "" && ntnTxt.Text != "")
                    {
                        i.insertSupplier(supplierCompanyTxt.Text, personNameTxt.Text, Phone1Txt.Text, addressTxt.Text, stat, null, ntnTxt.Text);
                    }
                    else if (phone2Txt.Text != "" && ntnTxt.Text == "")
                    {
                        i.insertSupplier(supplierCompanyTxt.Text, personNameTxt.Text, Phone1Txt.Text, addressTxt.Text, stat, phone2Txt.Text, null);
                    }
                    else if (phone2Txt.Text == "" && ntnTxt.Text == "")
                    {
                        i.insertSupplier(supplierCompanyTxt.Text, personNameTxt.Text, Phone1Txt.Text, addressTxt.Text, stat, null, null);
                    }
                    else
                    {
                        i.insertSupplier(supplierCompanyTxt.Text, personNameTxt.Text, Phone1Txt.Text, addressTxt.Text, stat, phone2Txt.Text, ntnTxt.Text);
                    }

                    r.showSuppliers(dataGridView1, SuppIDGV,companyGV , personGV, phone1GV, phone2GV, addressGV, ntnGV,StatusGV);
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
                        //validating the null fields 
                        if (phone2Txt.Text == "" && ntnTxt.Text != "")
                        {
                            u.updateSupplier(supplierID, supplierCompanyTxt.Text, personNameTxt.Text, Phone1Txt.Text, addressTxt.Text, stat,null, ntnTxt.Text);
                        }
                        else if (phone2Txt.Text != "" && ntnTxt.Text == "")
                        {
                            u.updateSupplier(supplierID, supplierCompanyTxt.Text, personNameTxt.Text, Phone1Txt.Text, addressTxt.Text, stat, phone2Txt.Text, null);
                        }
                        else if (phone2Txt.Text == "" && ntnTxt.Text == "")
                        {
                            u.updateSupplier(supplierID, supplierCompanyTxt.Text, personNameTxt.Text, Phone1Txt.Text, addressTxt.Text, stat, null, null);
                        }
                        else
                        {
                            u.updateSupplier(supplierID, supplierCompanyTxt.Text, personNameTxt.Text, Phone1Txt.Text, addressTxt.Text, stat, phone2Txt.Text, ntnTxt.Text);
                        }
                        
                        r.showSuppliers(dataGridView1, SuppIDGV, companyGV, personGV, phone1GV, phone2GV, addressGV, ntnGV, StatusGV);
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
