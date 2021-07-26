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
            dataGridView1.AutoGenerateColumns = false;
            r.getListWithTwoParameters("st_getPurchaseInvoiceList", purDD, "Company", "ID", "@month", datePicker.Value.Month, "@year", datePicker.Value.Year);
        }

        private void purDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (purDD.SelectedIndex != -1 && purDD.SelectedIndex != 0)
            {
                float gt=0; //grand total
                r.showPurchaseInvoiceDetails(Convert.ToInt64(purDD.SelectedValue.ToString()),dataGridView1, proIDGV, proGV, quantGV, pupGV, totGV);
                //total amount 
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    gt += Convert.ToSingle(row.Cells["totGV"].Value.ToString());
                }
                grossTotalLbl.Text = gt.ToString();
                gt = 0;
            }
        }
    }
}
