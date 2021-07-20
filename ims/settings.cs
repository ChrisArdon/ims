using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ims
{
    public partial class settings : Sample
    {
        public settings()
        {
            InitializeComponent();
        }

        private void settings_Load(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            
            string s;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (isCB.Checked)
            {
                if (serverTxt.Text != "" && databaseTxt.Text != "")
                {
                    s = "Data Source=" + serverTxt.Text + ";Initial Catalog=" + databaseTxt.Text + ";Integrated Security=true;MultipleActiveResultsSets=true";
                    File.WriteAllText(path+"\\connect", s);
                    DialogResult dr = MessageBox.Show("Settings Saved Successfully...", "Information...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        login log = new login();
                        MainClass.showWindow(log, this, MDI.ActiveForm);
                    }
                }
                else 
                {
                    MessageBox.Show("Please give complete data to continue...");
                }
            }
            else
            {
                //SQL server authentication
                if (serverTxt.Text != "" && databaseTxt.Text != "" && userTxt.Text != "" && passTxt.Text != "")
                {
                    s = "Data Source=" + serverTxt.Text + ";Initial Catalog=" + databaseTxt.Text + ";User ID="+userTxt.Text+";Password="+passTxt.Text+ ";MultipleActiveResultsSets=true";
                    File.WriteAllText(path + "\\connect", s);
                    DialogResult dr = MessageBox.Show("Settings Saved Successfully...", "Information...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        login log = new login();
                        MainClass.showWindow(log, this, MDI.ActiveForm);
                    }
                }
                else
                {
                    MessageBox.Show("Please give complete data to continue...");
                }
            }
            
            
        }

        private void isCB_CheckedChanged(object sender, EventArgs e)
        {
            if (isCB.Checked)
            {
                userTxt.Enabled = false;
                passTxt.Enabled = false;
                userTxt.Text = "";
                passTxt.Text = "";
            }
            else
            {
                userTxt.Enabled = true;
                passTxt.Enabled = true;
            }
        }

        private void rightPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
