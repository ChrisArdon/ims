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
    public partial class login : Sample
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (usernameTxt.Text == "") { usernameErrorLbl.Visible = true; } else { usernameErrorLbl.Visible = false; }
            if (passwordTxt.Text == "") { passErrorLbl.Visible = true; } else { passErrorLbl.Visible = false; }
            if (usernameErrorLbl.Visible || passErrorLbl.Visible)
            {
                MainClass.ShowMSG("Fields with * are mandatory", "Stop", "Error");
            }
            else
            {
                if (retrieval.getUserDetails(usernameTxt.Text, passwordTxt.Text))
                {
                    HomeScreen hm = new HomeScreen();
                    MainClass.showWindow(hm, this, MDI.ActiveForm);
                }
                else
                {

                }
            }            
        }
    }
}
