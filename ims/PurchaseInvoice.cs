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
    public partial class PurchaseInvoice : Sample2
    {
        retrieval r = new retrieval();
        float productID;
        public PurchaseInvoice()
        {
            InitializeComponent();
        }

        private void PurchaseInvoice_Load(object sender, EventArgs e)
        {
            r.getList("st_getSupplierList", supplierDD, "Company", "ID");
        }
        string[] prodARR = new string[3]; // Array to capture the data from the retrieval array
        private void barcodeTxt_TextChanged(object sender, EventArgs e)
        {
            if (barcodeTxt.Text != "")
            {
                prodARR = r.getProductsWRTBarcodeList(barcodeTxt.Text);
                productID = Convert.ToInt32(prodARR[0]);
                productTxt.Text = prodARR[1];
                pupTxt.Text = prodARR[2];

                //Deactivate the field so it can no be altered
                productTxt.Enabled = false;
                pupTxt.Enabled = false;
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
    }
}
