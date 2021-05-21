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
    public partial class products : Sample2
    {

        int edit = 0; //This 0 is an indication to SAVE operation and 1 is an indication to UPDATE operation
        int prodID;
        retrieval r = new retrieval();
        public products()
        {
            InitializeComponent();
        }
       
        private void products_Load(object sender, EventArgs e)
        {
            MainClass.enable_reset(leftPanel);
            edit = 0;
            MainClass.disable_reset(leftPanel); //we stablish by default that the panels are reset when we load the program, until we select an option
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
                    d.delete(prodID, "st_productDelete", "@prodID");
                    r.showProducts(dataGridView1, proIDGV, proGV, expiryGV, catGV, priceGV, barcodeGV, catIDGV);
                }
            }
        }

        public override void addBtn_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(leftPanel);

            r.getCategoriesList("st_getCategoriesList", categoryDD, "Category", "ID");
        }

        public override void editBtn_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.enable(leftPanel);
        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (proTxt.Text == "") { proErrorLabel.Visible = true; } else { proErrorLabel.Visible = false; }
            if (barcodeTxt.Text == "") { barcodeErrorLabel.Visible = true; } else { barcodeErrorLabel.Visible = false; }
            if (expiryPicker.Value < DateTime.Now) { expiryErrorLabel.Visible = true; expiryErrorLabel.Text = "Invalid Date"; } else { expiryErrorLabel.Visible = false; }
            if (priceTxt.Text == "") { priceErrorLabel.Visible = true; } else { priceErrorLabel.Visible = false; }
            if (categoryDD.SelectedIndex == -1 || categoryDD.SelectedIndex == 0) { catErrorLabel.Visible = true; } else { catErrorLabel.Visible = false; }

            //final if
            if (proErrorLabel.Visible || barcodeErrorLabel.Visible || expiryErrorLabel.Visible || priceErrorLabel.Visible || catErrorLabel.Visible)
            {
                MainClass.ShowMSG("Fields with * are mandatory", "Stop", "Error");
            }
            else
            {
                if (edit == 0) //Code for SAVE operation
                {
                    insertion i = new insertion();
                    i.insertProduct(proTxt.Text, barcodeTxt.Text, Convert.ToSingle(priceTxt.Text), expiryPicker.Value, Convert.ToInt32(categoryDD.SelectedValue));
                    r.showProducts(dataGridView1, proIDGV, proGV, expiryGV, catGV, priceGV, barcodeGV, catIDGV);
                    MainClass.disable_reset(leftPanel);
                }
                else if (edit == 1) //Code for UPDATE operation
                {
                    DialogResult dr = MessageBox.Show("Are you sure , you want to update record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        updation u = new updation();
                        u.updateProduct(prodID, proTxt.Text, barcodeTxt.Text, Convert.ToSingle(priceTxt.Text), expiryPicker.Value, Convert.ToInt32(categoryDD.SelectedValue));
                        r.showProducts(dataGridView1, proIDGV, proGV, expiryGV, catGV, priceGV, barcodeGV, catIDGV);
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
            r.showProducts(dataGridView1, proIDGV, proGV, expiryGV, catGV, priceGV, barcodeGV, catIDGV);
        }

        private void categoryDD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rightPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1) //e is referencing to the column index and row index
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                prodID = Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()); // We get the userID of the selected cell. https://youtu.be/B5td7E7YGeA min 11:10
                proTxt.Text = row.Cells["proGV"].Value.ToString();
                priceTxt.Text = row.Cells["priceGV"].Value.ToString();
                barcodeTxt.Text = row.Cells["barcodeGV"].Value.ToString();
                expiryPicker.Value = Convert.ToDateTime(row.Cells["expiryGV"].Value.ToString());
                categoryDD.SelectedItem = row.Cells["catGV"].Value.ToString();
                MainClass.disable(leftPanel);
            }
        }
    }
}
