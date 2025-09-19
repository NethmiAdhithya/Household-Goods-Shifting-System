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
    public partial class frmAdminDashboard : Form
    {
        // Constructor for the Admin Dashboard form
        public frmAdminDashboard()
        {
            InitializeComponent(); // Initializes the components defined in the designer
        }

        // Event handler for the "Home" menu item click
        private void Home_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome(); // Create an instance of the Home form
            home.Show(); // Display the Home form
            this.Hide(); // Hide the current Admin Dashboard form
        }

        // Event handler for the "Main" menu item click (likely for Admin Main form)
        private void tsmMain_Click(object sender, EventArgs e)
        {
            frmMainAdmin mainAdmin = new frmMainAdmin(); // Create an instance of the Admin Main form
            mainAdmin.Show(); // Display the Admin Main form
            this.Hide(); // Hide the current Admin Dashboard form
        }

        // Event handler for the "Customer Management" menu item click
        private void tsmCustomer_Click(object sender, EventArgs e)
        {
            frmCustomer customer = new frmCustomer(); // Create an instance of the Customer management form
            customer.Show(); // Display the Customer management form
            this.Hide(); // Hide the current Admin Dashboard form
        }

        // Event handler for the "Job Management" menu item click
        private void tsmJob_Click(object sender, EventArgs e)
        {
            frmJob job = new frmJob(); // Create an instance of the Job management form
            job.Show(); // Display the Job management form
            this.Hide(); // Hide the current Admin Dashboard form
        }

        // Event handler for the "Load Management" menu item click
        private void tsmLoad_Click(object sender, EventArgs e)
        {
            frmLoad load = new frmLoad(); // Create an instance of the Load management form
            load.Show(); // Display the Load management form
            this.Hide(); // Hide the current Admin Dashboard form
        }

        // Event handler for the "Transport Unit Management" menu item click
        private void tsmTransportUnit_Click(object sender, EventArgs e)
        {
            frmTransportUnit transportUnit = new frmTransportUnit(); // Create an instance of the Transport Unit management form
            transportUnit.Show(); // Display the Transport Unit management form
            this.Hide(); // Hide the current Admin Dashboard form
        }

        // Event handler for the "Invoice Management" menu item click
        private void tsmInvoice_Click(object sender, EventArgs e)
        {
            frmInvoice invoice = new frmInvoice(); // Create an instance of the Invoice management form
            invoice.Show(); // Display the Invoice management form
            this.Hide(); // Hide the current Admin Dashboard form
        }

        // Event handler for the "Dashboard" menu item click (current form, no action needed)
        private void tsmDashboard_Click(object sender, EventArgs e)
        {
            // Already on the dashboard, so no action needed.
        }

        // Event handler for the "Admin Management" menu item click
        private void tsmAdminManagement_Click(object sender, EventArgs e)
        {
            frmAdminManagement adminManagement = new frmAdminManagement(); // Create an instance of the Admin Management form
            adminManagement.Show(); // Display the Admin Management form
            this.Hide(); // Hide the current Admin Dashboard form
        }

        // Event handler for the "Reports" menu item click (likely a parent menu, no direct action)
        private void tsmReports_Click(object sender, EventArgs e)
        {
            // This is likely a placeholder or a parent menu item, so no direct form redirection.
        }

        // Event handler for the "Customer Their Jobs Report" menu item click
        private void tsmCustomerTheirJobs_Click(object sender, EventArgs e)
        {
            frmCustomerAndTheirJobsReport customerAndTheirJobsReport = new frmCustomerAndTheirJobsReport(); // Create an instance of the Customer and Their Jobs Report form
            customerAndTheirJobsReport.Show(); // Display the report form
            this.Hide(); // Hide the current Admin Dashboard form
        }

        // Event handler for the "Jobs By Date Range Report" menu item click
        private void tsmJobsByDateRange_Click(object sender, EventArgs e)
        {
            frmJobsByDateRangeReport jobsByDateRangeReport = new frmJobsByDateRangeReport(); // Create an instance of the Jobs By Date Range Report form
            jobsByDateRangeReport.Show(); // Display the report form
            this.Hide(); // Hide the current Admin Dashboard form
        }

        // Event handler for the "Loads By Transport Unit Report" menu item click
        private void tsmLoadsByTransportUnit_Click(object sender, EventArgs e)
        {
            frmLoadsByTransportUnitReport loadsByTransportUnitReport = new frmLoadsByTransportUnitReport(); // Create an instance of the Loads By Transport Unit Report form
            loadsByTransportUnitReport.Show(); // Display the report form
            this.Hide(); // Hide the current Admin Dashboard form
        }

        // Event handler for the "Delivery Performance Report" menu item click
        private void tsmDeliveryPerformance_Click(object sender, EventArgs e)
        {
            frmDeliveryPerformanceReport deliveryPerformanceReport = new frmDeliveryPerformanceReport(); // Create an instance of the Delivery Performance Report form
            deliveryPerformanceReport.Show(); // Display the report form
            this.Hide(); // Hide the current Admin Dashboard form
        }

        // Event handler for the "Daily End of the Loads Report" menu item click
        private void tsmDailyEndOfTheLoads_Click(object sender, EventArgs e)
        {
            frmDailyEndOfTheLoadsReport dailyEndOfTheLoadsReport = new frmDailyEndOfTheLoadsReport(); // Create an instance of the Daily End of the Loads Report form
            dailyEndOfTheLoadsReport.Show(); // Display the report form
            this.Hide(); // Hide the current Admin Dashboard form
        }

        // Event handler for when the Admin Dashboard form loads
        private void frmAdminDashboard_Load(object sender, EventArgs e)
        {
            // These lines of code typically load data into various tables of a DataSet
            // for displaying reports or populating controls on the form.
            // They are usually generated automatically by Visual Studio when binding data sources.

            // Fills the 'LoadsByTransportUnit' table in 'e_ShiftDBDataSet'
            this.loadsByTransportUnitTableAdapter.Fill(this.e_ShiftDBDataSet.LoadsByTransportUnit);
            // Fills the 'JobsByDateRange' table in 'e_ShiftDBDataSet'
            this.jobsByDateRangeTableAdapter.Fill(this.e_ShiftDBDataSet.JobsByDateRange);
            // Fills the '_Customer_theirJobs' table in 'e_ShiftDBDataSet'
            this.customer_theirJobsTableAdapter.Fill(this.e_ShiftDBDataSet._Customer_theirJobs);
            // Fills the 'TransportUnits' table in 'e_ShiftDBDataSet'
            this.transportUnitsTableAdapter.Fill(this.e_ShiftDBDataSet.TransportUnits);
            // Fills the 'Admins' table in 'e_ShiftDBDataSet'
            this.adminsTableAdapter.Fill(this.e_ShiftDBDataSet.Admins);
            // Fills the 'Loads' table in 'e_ShiftDBDataSet'
            this.loadsTableAdapter.Fill(this.e_ShiftDBDataSet.Loads);
            // Fills the 'Customers' table in 'e_ShiftDBDataSet'
            this.customersTableAdapter.Fill(this.e_ShiftDBDataSet.Customers);
        }

        // Empty event handler for the Paint event of panel5
        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            // This event handler is typically for custom drawing operations on the panel.
            // It is empty here, meaning no custom drawing is performed.
        }
    }
}