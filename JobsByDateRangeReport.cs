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
    public partial class frmJobsByDateRangeReport : Form
    {
        public frmJobsByDateRangeReport()
        {
            InitializeComponent();

            dtpStartDate.Value = DateTime.Today.AddMonths(-1); // Example: default to last month
            dtpEndDate.Value = DateTime.Today; // Example: default to today
        }

        // Method to load the report data based on selected dates
        private void LoadJobsByDateRangeReport(DateTime startDate, DateTime endDate)
        {
            using (SqlConnection connection = new SqlConnection(DbConnection.ConnectionString)) // Assuming DbConnection.ConnectionString provides your connection string
            {
                try
                {
                    connection.Open();

                    // SQL query with parameters for date range
                    SqlCommand command = new SqlCommand(@"
                        SELECT
                            J.JobID,
                            C.Name AS CustomerName,
                            J.Description,
                            J.JobDate,
                            J.JobStatus
                        FROM
                            Jobs AS J
                        INNER JOIN
                            Customers AS C ON J.CustomerID = C.CustomerID
                        WHERE
                            J.JobDate >= @StartDate AND J.JobDate <= @EndDate
                        ORDER BY
                            J.JobDate;
                    ", connection);

                    // Add parameters to the SQL command
                    command.Parameters.AddWithValue("@StartDate", startDate.Date); // Use .Date to remove time component for pure date comparison
                    command.Parameters.AddWithValue("@EndDate", endDate.Date);   // Use .Date to remove time component for pure date comparison

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Clear any existing data sources from the report viewer
                    rvwJobsByDateRangeReport.LocalReport.DataSources.Clear();

                    // Create a new ReportDataSource.
                    // "DataSet1" must match the name of the DataSet in your RDLC file's "Report Data" pane.
                    ReportDataSource reportDataSource = new ReportDataSource("DataSet1", dataTable);

                    // Set the path to your RDLC report file.
                    // Ensure the "Copy to Output Directory" property of your .rdlc file is set to "Copy if newer" or "Copy always".
                    rvwJobsByDateRangeReport.LocalReport.ReportPath = "JobsByDateRangeReport.rdlc"; // <-- IMPORTANT: Replace with your actual RDLC file name

                    // Add the data source to the report viewer
                    rvwJobsByDateRangeReport.LocalReport.DataSources.Add(reportDataSource);

                    // If you want to display the date range on the report itself, you can pass them as parameters to the report
                    // You would define these parameters in your JobsByDateRangeReport.rdlc file.
                    ReportParameter pStartDate = new ReportParameter("ReportStartDate", startDate.ToShortDateString());
                    ReportParameter pEndDate = new ReportParameter("ReportEndDate", endDate.ToShortDateString());
                    rvwJobsByDateRangeReport.LocalReport.SetParameters(new ReportParameter[] { pStartDate, pEndDate });


                    // Refresh the report to display the data
                    rvwJobsByDateRangeReport.RefreshReport();
                }
                catch (SqlException sqlEx)
                {
                    // Handle SQL-specific errors
                    MessageBox.Show("Database error loading report: " + sqlEx.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    // Handle other general errors
                    string errorMessage = "Error loading report: " + ex.Message;
                    if (ex.InnerException != null)
                    {
                        errorMessage += "\nInner Exception: " + ex.InnerException.Message;
                        // Optionally, if there are multiple layers of inner exceptions
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
            frmMainAdmin mainAdmin = new frmMainAdmin();

            mainAdmin.Show();

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

        private void lblJobsByDateRangeReport_Click(object sender, EventArgs e)
        {

        }

        private void rvwJobsByDateRangeReport_Load(object sender, EventArgs e)
        {

        }

        private void frmJobsByDateRangeReport_Load(object sender, EventArgs e)
        {
            LoadJobsByDateRangeReport(dtpStartDate.Value, dtpEndDate.Value);
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            LoadJobsByDateRangeReport(dtpStartDate.Value, dtpEndDate.Value);
        }
    }
}
