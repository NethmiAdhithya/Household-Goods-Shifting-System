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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void tsmHome_Click(object sender, EventArgs e)
        {
            frmHome Home = new frmHome();

            Home.Show();

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
            frmRegister Register = new frmRegister();

            Register.Show();

            this.Hide();
        }

        private void tsmLogin_Click(object sender, EventArgs e)
        {
            frmLogin Login = new frmLogin();

            Login.Show();

            this.Hide();
        }

        private void tsmContactUs_Click(object sender, EventArgs e)
        {
            frmContact contact = new frmContact();

            contact.Show();

            this.Hide();
        }

        private void picLogo_Click(object sender, EventArgs e)
        {

        }

        private void frmHome_Load(object sender, EventArgs e)
        {

        }
    }
}
