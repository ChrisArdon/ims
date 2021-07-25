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
    public partial class PurchaseINvoiceDetails : Sample2
    {
        public PurchaseINvoiceDetails()
        {
            InitializeComponent();
        }
        retrieval r = new retrieval();

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            r.getListWithTwoParameters("st_getPurchaseInvoiceList", purDD, "Company", "ID", "@month", datePicker.Value.Month, "@year", datePicker.Value.Year);
        }
        public override void backBtn_Click(object sender, EventArgs e) // In this form, when we select 'back' we need to go back to the purchaseInvoice form
        {
            PurchaseInvoice obj = new PurchaseInvoice();
            MainClass.showWindow(obj, this, MDI.ActiveForm);
        }

        private void rightPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void PurchaseINvoiceDetails_Load(object sender, EventArgs e)
        {
            r.getListWithTwoParameters("st_getPurchaseInvoiceList", purDD, "Company", "ID", "@month", datePicker.Value.Month, "@year", datePicker.Value.Year);
        }
    }
}
