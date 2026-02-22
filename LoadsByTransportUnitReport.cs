using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // Needed for SQL operations
using Microsoft.Reporting.WinForms; // Needed for ReportViewer

namespace E_Shift
{
    public partial class frmLoadsByTransportUnitReport : Form
    {
        public frmLoadsByTransportUnitReport()
        {
            InitializeComponent();
        }

        private void LoadLoadsByTransportUnitReport()
        {
            using (SqlConnection connection = new SqlConnection(DbConnection.ConnectionString)) // Assuming DbConnection.ConnectionString provides your connection string
            {
                try
                {
                    connection.Open();

                    // Your SQL query to fetch loads by transport unit data
                    SqlCommand command = new SqlCommand(@"
                SELECT
                    TU.TransportUnitID AS TransportUnit,
                    L.LoadID,
                    L.ProductItem,
                    L.Weight,
                    L.Quantity,
                    L.LoadStatus AS DeliveryStatus,
                    J.JobID,
                    C.Name AS CustomerName
                FROM
                    TransportUnits TU
                JOIN
                    Loads L ON TU.TransportUnitID = L.TransportUnitID
                JOIN
                    Jobs J ON L.JobID = J.JobID
                JOIN
                    Customers C ON J.CustomerID = C.CustomerID
                ORDER BY
                    TU.TransportUnitID, L.LoadID;
            ", connection);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Clear any existing data sources from the report viewer
                    rvwLoadsByTransportUnitReport.LocalReport.DataSources.Clear();

                    // Create a new ReportDataSource.
                    // "DataSet1" must match the name of the DataSet in your RDLC file's "Report Data" pane.
                    ReportDataSource reportDataSource = new ReportDataSource("DataSet1", dataTable);

                    // Set the path to your RDLC report file.
                    // Ensure the "Copy to Output Directory" property of your .rdlc file is set to "Copy if newer" or "Copy always".
                    // It's recommended to use a relative path if your .rdlc is copied to the debug folder.
                    rvwLoadsByTransportUnitReport.LocalReport.ReportPath = "C:\\Adhithya\\TOP-UP\\Assignments\\07.20_AD_Assignment-01\\AD-Final\\E-Shift\\E-Shift\\bin\\Debug\\LoadsByTransportUnitReport.rdlc"; // Adjust path if your RDLC is in a subfolder

                    // Add the data source to the report viewer
                    rvwLoadsByTransportUnitReport.LocalReport.DataSources.Add(reportDataSource);

                    // Refresh the report to display the data
                    rvwLoadsByTransportUnitReport.RefreshReport();
                }
                catch (SqlException sqlEx)
                {
                    // Handle SQL-specific errors
                    MessageBox.Show("Database error loading report: " + sqlEx.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    // Handle other general errors with detailed inner exception
                    string errorMessage = "Error loading report: " + ex.Message;
                    if (ex.InnerException != null)
                    {
                        errorMessage += "\nInner Exception: " + ex.InnerException.Message;
                        if (ex.InnerException.InnerException != null)
                        {
                            errorMessage += "\nDeep Inner Exception: " + ex.InnerException.InnerException.Message;
                        }
                    }
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Home_Click(object sender, EventArgs e)
        {
            frmHome Home = new frmHome();

            Home.Show();

            this.Hide();
        }

        private void tsmMain_Click(object sender, EventArgs e)
        {
            frmMainAdmin frmMainAdmin = new frmMainAdmin();

            frmMainAdmin.Show();

            this.Hide();
        }

        private void tsmCustomer_Click(object sender, EventArgs e)
        {
            frmCustomer customer = new frmCustomer();

            customer.Show();

            this.Hide();
        }

        private void tsmJob_Click(object sender, EventArgs e)
        {
            frmJob job  = new frmJob();

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
            frmTransportUnit transportUnit = new frmTransportUnit();

            transportUnit.Show();

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

        private void frmLoadsByTransportUnitReport_Load(object sender, EventArgs e)
        {
            // Call the method to load data and set up the report viewer
            LoadLoadsByTransportUnitReport();

            // This RefreshReport call might be redundant if already called at the end of LoadLoadsByTransportUnitReport()
            // but it doesn't hurt to keep it for certainty.
            this.rvwLoadsByTransportUnitReport.RefreshReport();
        }

        private void lblLoadsByTransportUnitReport_Click(object sender, EventArgs e)
        {

        }

        private void rvwLoadsByTransportUnitReport_Load(object sender, EventArgs e)
        {

        }
    }
}
