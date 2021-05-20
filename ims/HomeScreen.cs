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
    public partial class HomeScreen : Sample //We always change this to the form that is showing everything and for inherit
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {

        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            Users u = new Users();
            MainClass.showWindow(u, this, MDI.ActiveForm); //This is a method that controls which window is open and which is closed
        }

        private void catBtn_Click(object sender, EventArgs e)
        {
            categories u = new categories();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }

        private void productsBtn_Click(object sender, EventArgs e)
        {
            products u = new products();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }
    }
}
