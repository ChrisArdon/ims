using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ims
{
    public partial class PurchaseInvoice : Sample2
    {
        retrieval r = new retrieval();
        float productID;
        float gt; //gross total
        float tot;
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$"); //validate the currency format
        public PurchaseInvoice()
        {
            InitializeComponent();
        }

        private void PurchaseInvoice_Load(object sender, EventArgs e)
        {
            r.getList("st_getSupplierList", supplierDD, "Company", "ID");
        }
        string[] prodARR = new string[4]; // Array to capture the data from the retrieval array
        private void barcodeTxt_TextChanged(object sender, EventArgs e)
        {
            if (barcodeTxt.Text != "")
            {
                prodARR = r.getProductsWRTBarcodeList(barcodeTxt.Text);
                productID = Convert.ToInt32(prodARR[0]);
                productTxt.Text = prodARR[1];
                pupTxt.Text = prodARR[2];
                string barco = prodARR[3];

                //Deactivate the field so it can no be altered
                productTxt.Enabled = false;
                pupTxt.Enabled = false;

                if (barco != null) //Once the product is finded, the cursor will focus be set in the quantity textbox automatically
                {
                    quanTxt.Focus();
                }
            }
            else
            {
                //fields reset
                productID = 0;
                productTxt.Text = "";
                pupTxt.Text = "";
                Array.Clear(prodARR, 0, prodARR.Length);
            }
        }

        private void barcodeTxt_Validated(object sender, EventArgs e)
        {
            
        }

        private void quanTxt_TextChanged(object sender, EventArgs e)
        {
            if (quanTxt.Text != "")
            {
                //Once the quantity has been validated 
                if (rg.Match(quanTxt.Text).Success)
                {
                    float quan, price, tot;
                    quan = Convert.ToSingle(quanTxt.Text);
                    price = Convert.ToSingle(pupTxt.Text);
                    tot = quan * price;
                    totLbl.Text = tot.ToString("###########.##");
                }
                else
                {
                    quanTxt.SelectAll();
                }
            }
            else
            {
                totLbl.Text = "0.00";
            }
        }

        private void cartBtn_Click(object sender, EventArgs e)
        {
            if (supplierDD.SelectedIndex == -1) { suppErrorLbl.Visible = true; } else { suppErrorLbl.Visible = false; }
            if (quanTxt.Text == "") { quantErrorLbl.Visible = true; } else { quantErrorLbl.Visible = false; }
            if (barcodeTxt.Text == "") { barcodeErrorLbl.Visible = true; } else { barcodeErrorLbl.Visible = false; }
            if (suppErrorLbl.Visible || quantErrorLbl.Visible || barcodeErrorLbl.Visible)
            {
                MainClass.ShowMSG("Fields with * are mandatory", "Stop", "Error");
            }
            else
            {
                dataGridView1.Rows.Add(productID, productTxt.Text, quanTxt.Text, pupTxt.Text, totLbl.Text);
                gt += Convert.ToSingle(totLbl.Text);
                grossTotalLbl.Text = gt.ToString();
                productID = 0;
                productTxt.Text = "";
                pupTxt.Text = "";
                barcodeTxt.Text = "";
                totLbl.Text = "0.00";
                quanTxt.Text = "";
                Array.Clear(prodARR, 0, prodARR.Length);

            }
            //else //section where we restrict the product quantity entered in the datagridview purchase
            //{
            //    if (dataGridView1.Rows.Count == 0) // if the datagridview is empty, we add the purchase
            //    {
            //        dataGridView1.Rows.Add(productID, productTxt.Text, quanTxt.Text, pupTxt.Text, totLbl.Text);
            //        //fields reset
            //        productID = 0;
            //        productTxt.Text = "";
            //        pupTxt.Text = "";
            //        Array.Clear(prodARR, 0, prodARR.Length);
            //    }
            //    else
            //    {
            //        foreach (DataGridViewRow row in dataGridView1.Rows)
            //        {
            //            if (row.Cells["proIDGV"].Value.ToString() != productID.ToString()) //if the product ID entered is different from the other products, we add. Else we don't add.
            //            {
            //                dataGridView1.Rows.Add(productID, productTxt.Text, quanTxt.Text, pupTxt.Text, totLbl.Text);
            //                //fields reset
            //                productID = 0;
            //                productTxt.Text = "";
            //                pupTxt.Text = "";
            //                Array.Clear(prodARR, 0, prodARR.Length);
            //                break;
            //            }
            //        }
            //    }                               
            //}
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.ColumnIndex == 5)//If we click the Delete button in column number 5
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    gt -= Convert.ToSingle(row.Cells["totGV"].Value.ToString()); //we sustract the total of the deleted row
                    grossTotalLbl.Text = gt.ToString();
                    dataGridView1.Rows.Remove(row);
                }
            }
        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        public override void addBtn_Click(object sender, EventArgs e)
        {

        }

        public override void editBtn_Click(object sender, EventArgs e)
        {

        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {

        }

        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        public override void viewBtn_Click(object sender, EventArgs e) //Public override void to inherit: Build >> rebuild solution in Users form
        {

        }
    }
}
