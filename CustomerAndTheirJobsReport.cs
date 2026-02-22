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
    public partial class frmCustomerAndTheirJobsReport : Form
    {
        public frmCustomerAndTheirJobsReport()
        {
            InitializeComponent(); // Initializes the form components.
        }

        // Method to load the report data for customers and their associated jobs.
        private void LoadCustomerAndTheirJobsReport()
        {
            // Establishes a connection to the database using the connection string.
            using (SqlConnection connection = new SqlConnection(DbConnection.ConnectionString))
            {
                try
                {
                    connection.Open(); // Opens the database connection.

                    // SQL query to fetch customer and job data by joining Customers and Jobs tables.
                    // Aliases 'C.Name AS CustomerName' to match expected RDLC DataSet field.
                    SqlCommand command = new SqlCommand(@"
                        SELECT
                            C.CustomerID,
                            C.Name AS CustomerName,
                            C.Email,
                            C.ContactNumber,
                            J.JobID,
                            J.Description,
                            J.JobDate,
                            J.JobStatus
                        FROM
                            Customers AS C
                        INNER JOIN
                            Jobs AS J ON C.CustomerID = J.CustomerID
                        ORDER BY
                            C.Name, J.JobDate;
                        ", connection);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command); // Creates a data adapter to fill a DataTable.
                    DataTable dataTable = new DataTable(); // Creates a new DataTable to hold the query results.
                    dataAdapter.Fill(dataTable); // Fills the DataTable with data from the database.

                    // Clears any existing data sources from the report viewer to prepare for new data.
                    rvwCustomerAndTheirJobsReport.LocalReport.DataSources.Clear();

                    // Creates a new ReportDataSource. "DataSet1" must match the name of the DataSet in the RDLC file.
                    ReportDataSource reportDataSource = new ReportDataSource("DataSet1", dataTable);

                    // Sets the path to the RDLC report file. 
                    // IMPORTANT: Ensure the RDLC file's "Copy to Output Directory" property is set.
                    rvwCustomerAndTheirJobsReport.LocalReport.ReportPath = "C:\\Adhithya\\TOP-UP\\Assignments\\07.20_AD_Assignment-01\\AD-Final\\E-Shift\\E-Shift\\bin\\Debug\\CustomerAndTheirJobsReport.rdlc";

                    // Adds the created data source to the report viewer.
                    rvwCustomerAndTheirJobsReport.LocalReport.DataSources.Add(reportDataSource);

                    // Refreshes the report viewer to display the loaded data.
                    rvwCustomerAndTheirJobsReport.RefreshReport();
                }
                catch (SqlException sqlEx)
                {
                    // Catches and displays specific SQL-related errors.
                    MessageBox.Show("Database error loading report: " + sqlEx.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    // Catches and displays any other general errors that occur.
                    MessageBox.Show("Error loading report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // --- Navigation Menu Click Event Handlers ---

        // Handles click event for the Home menu item, opens Home form and hides current.
        private void Home_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            home.Show();
            this.Hide();
        }

        // Handles click event for the Main Admin menu item, opens Main Admin form and hides current.
        private void tsmMain_Click(object sender, EventArgs e)
        {
            frmMainAdmin admin = new frmMainAdmin();
            admin.Show();
            this.Hide();
        }

        // Handles click event for the Customer menu item, opens Customer form and hides current.
        private void tsmCustomer_Click(object sender, EventArgs e)
        {
            frmCustomer customer = new frmCustomer();
            customer.Show();
            this.Hide();
        }

        // Handles click event for the Job menu item, opens Job form and hides current.
        private void tsmJob_Click(object sender, EventArgs e)
        {
            frmJob job = new frmJob();
            job.Show();
            this.Hide();
        }

        // Handles click event for the Load menu item, opens Load form and hides current.
        private void tsmLoad_Click(object sender, EventArgs e)
        {
            frmLoad load = new frmLoad();
            load.Show();
            this.Hide();
        }

        // Handles click event for the Transport Unit menu item, opens Transport Unit form and hides current.
        private void tsmTransportUnit_Click(object sender, EventArgs e)
        {
            frmTransportUnit transportUnit = new frmTransportUnit();
            transportUnit.Show();
            this.Hide();
        }

        // Handles click event for the Invoice menu item, opens Invoice form and hides current.
        private void tsmInvoice_Click(object sender, EventArgs e)
        {
            frmInvoice invoice = new frmInvoice();
            invoice.Show();
            this.Hide();
        }

        // Handles click event for the Dashboard menu item, opens Admin Dashboard form and hides current.
        private void tsmDashboard_Click(object sender, EventArgs e)
        {
            frmAdminDashboard adminDashboard = new frmAdminDashboard();
            adminDashboard.Show();
            this.Hide();
        }

        // Handles click event for the Admin Management menu item, opens Admin Management form and hides current.
        private void tsmAdminManagement_Click(object sender, EventArgs e)
        {
            frmAdminManagement adminManagement = new frmAdminManagement();
            adminManagement.Show();
            this.Hide();
        }

        // Handles click event for the Reports menu item (currently empty, likely a parent menu item).
        private void tsmReports_Click(object sender, EventArgs e)
        {
            // No action needed for parent menu item click.
        }

        // Handles click event for the "Customer and Their Jobs" report menu item (currently empty).
        private void tsmCustomerTheirJobs_Click(object sender, EventArgs e)
        {
            // No action needed as this is the current form's report.
        }

        // Handles click event for the "Jobs By Date Range" report menu item, opens its form and hides current.
        private void tsmJobsByDateRange_Click(object sender, EventArgs e)
        {
            frmJobsByDateRangeReport jobsByDateRangeReport = new frmJobsByDateRangeReport();
            jobsByDateRangeReport.Show();
            this.Hide();
        }

        // Handles click event for the "Loads By Transport Unit" report menu item, opens its form and hides current.
        private void tsmLoadsByTransportUnit_Click(object sender, EventArgs e)
        {
            frmLoadsByTransportUnitReport loadsByTransportUnitReport = new frmLoadsByTransportUnitReport();
            loadsByTransportUnitReport.Show();
            this.Hide();
        }

        // Handles click event for the "Delivery Performance" report menu item, opens its form and hides current.
        private void tsmDeliveryPerformance_Click(object sender, EventArgs e)
        {
            frmDeliveryPerformanceReport deliveryPerformanceReport = new frmDeliveryPerformanceReport();
            deliveryPerformanceReport.Show();
            this.Hide();
        }

        // Handles click event for the "Daily End Of The Loads" report menu item, opens its form and hides current.
        private void tsmDailyEndOfTheLoads_Click(object sender, EventArgs e)
        {
            frmDailyEndOfTheLoadsReport dailyEndOfTheLoadsReport = new frmDailyEndOfTheLoadsReport();
            dailyEndOfTheLoadsReport.Show();
            this.Hide();
        }

        // Event handler for when the form loads.
        private void frmCustomerAndTheirJobsReport_Load(object sender, EventArgs e)
        {
            // Calls the method to load data and configure the report viewer.
            LoadCustomerAndTheirJobsReport();

            // Refreshes the report viewer. This might be redundant if already called within LoadCustomerAndTheirJobsReport().
            this.rvwCustomerAndTheirJobsReport.RefreshReport();
        }

        // Event handler for clicking the label (currently empty).
        private void lblCustomerAndTheirJobsReport_Click(object sender, EventArgs e)
        {
            // No action.
        }

        // Event handler for the report viewer loading (currently empty).
        private void rvwCustomerAndTheirJobsReport_Load(object sender, EventArgs e)
        {
            // No action.
        }
    }
}