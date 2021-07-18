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
    }
}
