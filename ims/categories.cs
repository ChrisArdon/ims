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
    public partial class categories : Sample2
    {
        int edit = 0; //This 0 is an indication to SAVE operation and 1 is an indication to UPDATE operation
        int catID;
        short stat;
        retrieval r = new retrieval();
        public categories()
        {
            InitializeComponent();
        }

        private void categories_Load(object sender, EventArgs e)
        {
            MainClass.disable(leftPanel);
        }

        public override void rightPanel_Paint(object sender, PaintEventArgs e)
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
                    d.delete(catID, "st_deleteCategory", "@id");
                    r.showCategories(dataGridView1, catIDGV, NameGV, StatusGV);
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
            if (catTxt.Text == "") { catErrorLabel.Visible = true; } else { catErrorLabel.Visible = false; }            
            if (activeDD.SelectedIndex == -1) { activeErrorLabel.Visible = true; } else { activeErrorLabel.Visible = false; }

            if (catErrorLabel.Visible || activeErrorLabel.Visible)
            {
                MainClass.ShowMSG("Fields with * are mandatory", "Stop", "Error"); //Error is the type of msg
            }
            else
            {

                if (activeDD.SelectedIndex == 0)
                {
                    stat = 1; //this is sent to the stored procedure: status = 1 then 'Yes'
                }
                else if (activeDD.SelectedIndex == 1)
                {
                    stat = 0;
                }
                if (edit == 0) //Code for SAVE operation
                {

                    insertion i = new insertion();

                    i.insertCat(catTxt.Text, stat);
                    r.showCategories(dataGridView1, catIDGV, NameGV, StatusGV);
                    MainClass.disable_reset(leftPanel);

                }
                else if (edit == 1) //Code for UPDATE operation
                {
                    DialogResult dr = MessageBox.Show("Are you sure , you want to update record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        updation u = new updation();
                        u.updateCat(catID, catTxt.Text, stat);
                        r.showCategories(dataGridView1, catIDGV, NameGV, StatusGV);
                        MainClass.disable_reset(leftPanel);
                    }



                }
            }
        }

        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        public override void viewBtn_Click(object sender, EventArgs e) //Public override void to inherit: Build >> rebuild solution in Users form
        {
            r.showCategories(dataGridView1, catIDGV, NameGV, StatusGV);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) //e is referencing to the column index and row index
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                catID = Convert.ToInt32(row.Cells["catIDGV"].Value.ToString()); 
                catTxt.Text = row.Cells["NameGV"].Value.ToString();                
                activeDD.SelectedItem = row.Cells["StatusGV"].Value.ToString();
                MainClass.disable(leftPanel);
            }
        }
    }
}
