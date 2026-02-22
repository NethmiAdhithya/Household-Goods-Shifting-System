using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Shift
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void tsmHome_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();

            home.Show();

            this.Hide();
        }

        private void tsmAbout_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();

            about.Show();

            this.Hide();
        }

        private void tsmRegister_Click(object sender, EventArgs e)
        {
            frmRegister register = new frmRegister();

            register.Show();

            this.Hide();
        }

        private void tsmLogin_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();

            login.Show();

            this.Hide();
        }

        private void tsmContactUs_Click(object sender, EventArgs e)
        {
            frmContact contact = new frmContact();

            contact.Show();

            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
