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
    public partial class frmMainAdmin : Form
    {
        public frmMainAdmin()
        {
            InitializeComponent();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            frmHome Home = new frmHome();

            Home.Show();

            this.Hide();
        }

        private void tsmMain_Click(object sender, EventArgs e)
        {
            
        }

        private void tsmCustomer_Click(object sender, EventArgs e)
        {
            frmCustomer customer = new frmCustomer();

            customer.Show();

            this.Hide();
        }

        private void tsmJob_Click(object sender, EventArgs e)
        {
            frmJob job = new frmJob();

            job.Show();

            this.Hide();
        }

        private void tsmLoad_Click(object sender, EventArgs e)
        {
            frmLoad load = new frmLoad();

            load.Show();

            this.Hide();
        }

        private void tsmTransportUnit_Click(object sender, EventArgs e)
        {
            frmTransportUnit unit = new frmTransportUnit();

            unit.Show();

            this.Hide();
        }

        private void tsmInvoice_Click(object sender, EventArgs e)
        {
            frmInvoice invoice = new frmInvoice();

            invoice.Show();

            this.Hide();
        }

        private void tsmDashboard_Click(object sender, EventArgs e)
        {
            frmAdminDashboard adminDashboard = new frmAdminDashboard();

            adminDashboard.Show();

            this.Hide();
        }

        private void tsmAdminManagement_Click(object sender, EventArgs e)
        {
            frmAdminManagement adminManagement = new frmAdminManagement();

            adminManagement.Show();

            this.Hide();
        }

        private void tsmReports_Click(object sender, EventArgs e)
        {

        }

        private void tsmCustomerTheirJobs_Click(object sender, EventArgs e)
        {
            frmCustomerAndTheirJobsReport customerAndTheirJobsReport = new frmCustomerAndTheirJobsReport();

            customerAndTheirJobsReport.Show();

            this.Hide();
        }

        private void tsmJobsByDateRange_Click(object sender, EventArgs e)
        {
            frmJobsByDateRangeReport jobsByDateRangeReport = new frmJobsByDateRangeReport();

            jobsByDateRangeReport.Show();

            this.Hide();
        }

        private void tsmLoadsByTransportUnit_Click(object sender, EventArgs e)
        {
            frmLoadsByTransportUnitReport loadsByTransportUnitReport = new frmLoadsByTransportUnitReport();

            loadsByTransportUnitReport.Show();

            this.Hide();
        }

        private void tsmDeliveryPerformance_Click(object sender, EventArgs e)
        {
            frmDeliveryPerformanceReport deliveryPerformanceReport = new frmDeliveryPerformanceReport();

            deliveryPerformanceReport.Show();

            this.Hide();
        }

        private void tsmDailyEndOfTheLoads_Click(object sender, EventArgs e)
        {
            frmDailyEndOfTheLoadsReport dailyEndOfTheLoadsReport = new frmDailyEndOfTheLoadsReport();

            dailyEndOfTheLoadsReport.Show();

            this.Hide();
        }

        private void lble_Shift_Click(object sender, EventArgs e)
        {

        }

        private void frmMainAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
