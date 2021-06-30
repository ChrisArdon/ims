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

//MDI = Multiple Documents Interface

namespace ims
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            string Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (File.Exists(Path + "\\connect"))
            {
                login log = new login();
                MainClass.showWindow(log, this);
            }
            else
            {
                settings set = new settings();
                MainClass.showWindow(set, this);
            }
            
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settings set = new settings();
            MainClass.showWindow(set, this);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login set = new login();
            MainClass.showWindow(set, this);
            MDI.logoutToolStripMenuItem.Enabled = false; //If we click logout we are no longer in the HomeScreen, therefore there is nowhere to log out
        }
    }
}
