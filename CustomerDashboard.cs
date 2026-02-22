using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // Required for SQL database interaction
using System.Windows.Forms.DataVisualization.Charting; // Required for Chart control (for creating graphs)

namespace E_Shift
{
    public partial class frmCustomerDashboard : Form
    {
        // Constructor for the Customer Dashboard form
        public frmCustomerDashboard()
        {
            InitializeComponent();
        }

        // --- Menu Strip Click Handlers (Navigation) ---
        // Navigates to the Home form
        private void tsmHome_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            home.Show();
            this.Hide();
        }

        // Navigates to the Main Customer form
        private void tsmMain_Click(object sender, EventArgs e)
        {
            frmMainCustomer mainCustomer = new frmMainCustomer();
            mainCustomer.Show();
            this.Hide();
        }

        // Navigates to the My Profile form
        private void tsmMyProfile_Click(object sender, EventArgs e)
        {
            frmMyProfile myProfile = new frmMyProfile();
            myProfile.Show();
            this.Hide();
        }

        // Navigates to the Request New Transport form
        private void tsmRequestNewTransport_Click(object sender, EventArgs e)
        {
            frmRequestNewTransport requestNewTransport = new frmRequestNewTransport();
            requestNewTransport.Show();
            this.Hide();
        }

        // Navigates to the View My Jobs form
        private void tsmViewMyJobs_Click(object sender, EventArgs e)
        {
            frmViewMyJobs viewMyJobs = new frmViewMyJobs();
            viewMyJobs.Show();
            this.Hide();
        }

        // Navigates to the Tracking Status form
        private void tsmTrackingStatus_Click(object sender, EventArgs e)
        {
            frmTrackStatus trackStatus = new frmTrackStatus();
            trackStatus.Show();
            this.Hide();
        }

        // Navigates to the View Invoice form
        private void tsmViewInvoice_Click(object sender, EventArgs e)
        {
            frmViewInvoice viewInvoice = new frmViewInvoice();
            viewInvoice.Show();
            this.Hide();
        }

        // This is the current form, effectively a no-op or refresh if clicked
        private void tsmCustomerDashboard_Click(object sender, EventArgs e)
        {
            // Already on the customer dashboard
        }

        // Form Load event: Called when the form is first displayed
        private void frmCustomerDashboard_Load(object sender, EventArgs e)
        {
            // Check if a customer is currently logged in using the SessionManager
            if (SessionManager.IsCustomerLoggedIn())
            {
                // Load data for the job status chart if logged in
                LoadJobStatusChart();
            }
            else
            {
                // If not logged in, show a warning and close the form
                MessageBox.Show("You must be logged in to view the dashboard.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close(); // Close the dashboard form
            }
        }

        // Method to load and display the job status pie chart
        private void LoadJobStatusChart()
        {
            // Clear any existing chart data, titles, and areas to start fresh
            chtJobStatus.Series.Clear();
            chtJobStatus.Titles.Clear();
            chtJobStatus.ChartAreas.Clear();

            // Create and add a Chart Area to the chart control
            ChartArea chartArea = new ChartArea("JobStatusArea");
            chtJobStatus.ChartAreas.Add(chartArea);

            // Add a main title to the chart
            chtJobStatus.Titles.Add("Your Job Status Overview");
            chtJobStatus.Titles[0].Font = new Font("Arial", 12, FontStyle.Bold); // Set title font

            // Create a new Series for the chart and set its type to Pie
            Series series = new Series("JobStatuses");
            series.ChartType = SeriesChartType.Pie;
            chtJobStatus.Series.Add(series);

            // Customize the appearance of the pie chart series
            series.IsValueShownAsLabel = true; // Show data labels on slices
            series.LabelFormat = "{0} ({1} Jobs)"; // Format labels to show status and job count
            series.Font = new Font("Arial", 9, FontStyle.Regular); // Font for labels
            series.LegendText = "#VALX: #VALY"; // Format text shown in the legend (Status: Count)

            // Further visual customizations for the pie chart
            series.CustomProperties = "PieDrawingStyle=Concave, PieStartAngle=270";
            series.BorderColor = Color.Black;
            series.BorderWidth = 1;

            // Retrieve data from the database to populate the chart
            using (SqlConnection con = new SqlConnection(DbConnection.ConnectionString))
            {
                try
                {
                    con.Open(); // Open the database connection

                    // SQL query to count jobs by their status for the logged-in customer
                    string query = @"
                        SELECT
                            j.JobStatus,
                            COUNT(j.JobID) AS NumberOfJobs
                        FROM
                            Jobs j
                        WHERE
                            j.CustomerID = @CustomerID -- Filter by the current logged-in customer's ID
                        GROUP BY
                            j.JobStatus;"; // Group results by job status

                    SqlCommand cmd = new SqlCommand(query, con);
                    // Add parameter for CustomerID from the SessionManager
                    cmd.Parameters.AddWithValue("@CustomerID", SessionManager.LoggedInCustomerID);

                    SqlDataReader reader = cmd.ExecuteReader(); // Execute query and get results

                    bool hasData = false; // Flag to check if any job data was retrieved
                    while (reader.Read()) // Loop through each row of results
                    {
                        string jobStatus = reader["JobStatus"].ToString(); // Get job status
                        int numberOfJobs = Convert.ToInt32(reader["NumberOfJobs"]); // Get count of jobs for that status

                        // Add data point to the chart series
                        DataPoint point = new DataPoint();
                        point.SetValueXY(jobStatus, numberOfJobs); // Set X-value (status) and Y-value (count)
                        series.Points.Add(point);
                        hasData = true; // Mark that data was found
                    }
                    reader.Close(); // Close the data reader

                    // Handle scenario where no job data is found for the customer
                    if (!hasData)
                    {
                        // Add a placeholder slice to indicate no jobs
                        DataPoint noDataPoint = new DataPoint();
                        noDataPoint.SetValueXY("No Jobs", 1); // Single slice for "No Jobs"
                        noDataPoint.Label = "No Jobs";
                        noDataPoint.Color = Color.LightGray; // Gray color for no data
                        series.Points.Add(noDataPoint);
                        chtJobStatus.Legends[0].Enabled = false; // Disable legend if only "No Jobs" is present
                    }
                    else
                    {
                        // Ensure legend is enabled and positioned if actual data exists
                        if (chtJobStatus.Legends.Count == 0) // Add legend if it doesn't exist
                        {
                            Legend legend = new Legend("DefaultLegend");
                            chtJobStatus.Legends.Add(legend);
                        }
                        chtJobStatus.Legends[0].Docking = Docking.Bottom; // Position legend at the bottom
                        chtJobStatus.Legends[0].Alignment = StringAlignment.Center; // Center align legend
                    }
                }
                catch (Exception ex)
                {
                    // Catch and display any errors during data loading
                    MessageBox.Show("Error loading job status data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Clear the chart on error to show nothing or an error state
                    chtJobStatus.Series.Clear();
                    chtJobStatus.Titles.Clear();
                }
            }
        }

        // Empty event handler for lblCustomerDashboard (can be removed if unused)
        private void lblCustomerDashboard_Click(object sender, EventArgs e) { }
    }
}