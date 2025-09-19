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
using System.Data.SqlClient; // For MemoryStream and Image

namespace E_Shift
{
    public partial class frmTrackStatus : Form
    {
        // No need for a constructor with parameters, as we'll use SessionManager
        public frmTrackStatus()
        {
            InitializeComponent();
            SetupDataGridView(); // Setup DGV columns on initialization
        }

        

        // --- DataGridView Setup ---
        private void SetupDataGridView()
        {
            dgvLoadsTracking.AutoGenerateColumns = false;
            dgvLoadsTracking.Columns.Clear();

            // Define columns
            dgvLoadsTracking.Columns.Add("LoadID", "Load ID");
            dgvLoadsTracking.Columns["LoadID"].DataPropertyName = "LoadID";
            dgvLoadsTracking.Columns["LoadID"].ReadOnly = true;
            dgvLoadsTracking.Columns["LoadID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvLoadsTracking.Columns.Add("JobID", "Job ID");
            dgvLoadsTracking.Columns["JobID"].DataPropertyName = "JobID";
            dgvLoadsTracking.Columns["JobID"].ReadOnly = true;
            dgvLoadsTracking.Columns["JobID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvLoadsTracking.Columns.Add("ProductItem", "Product Item");
            dgvLoadsTracking.Columns["ProductItem"].DataPropertyName = "ProductItem";
            dgvLoadsTracking.Columns["ProductItem"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvLoadsTracking.Columns.Add("LoadStatus", "Status Text"); // Display the text status
            dgvLoadsTracking.Columns["LoadStatus"].DataPropertyName = "LoadStatus";
            dgvLoadsTracking.Columns["LoadStatus"].ReadOnly = true;
            dgvLoadsTracking.Columns["LoadStatus"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Add the custom progress bar column
            DataGridViewProgressBarColumn progressBarColumn = new DataGridViewProgressBarColumn();
            progressBarColumn.Name = "LoadProgress";
            progressBarColumn.HeaderText = "Progress";
            progressBarColumn.DataPropertyName = "ProgressValue"; // This will be a calculated column in DataTable
            progressBarColumn.ReadOnly = true;
            progressBarColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvLoadsTracking.Columns.Add(progressBarColumn);

            dgvLoadsTracking.Columns.Add("TransportUnit", "Assigned Vehicle");
            dgvLoadsTracking.Columns["TransportUnit"].DataPropertyName = "LorryNumberPlate";
            dgvLoadsTracking.Columns["TransportUnit"].ReadOnly = true;
            dgvLoadsTracking.Columns["TransportUnit"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Optional: You might want to display Estimated Delivery Date here too if available
            // dgvLoadsTracking.Columns.Add("EstDelivery", "Est. Delivery Date");
            // dgvLoadsTracking.Columns["EstDelivery"].DataPropertyName = "EstimatedDeliveryDate";
            // dgvLoadsTracking.Columns["EstDelivery"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvLoadsTracking.ReadOnly = true;
            dgvLoadsTracking.AllowUserToAddRows = false;
            dgvLoadsTracking.AllowUserToDeleteRows = false;
            dgvLoadsTracking.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        // --- Load Data into DataGridView ---
        private void LoadCustomerLoadsIntoGrid()
        {
            using (SqlConnection con = new SqlConnection(DbConnection.ConnectionString))
            {
                try
                {
                    con.Open();
                    string query = @"
                        SELECT
                            L.LoadID,
                            L.JobID,
                            L.ProductItem,
                            L.Quantity,
                            L.Weight,
                            L.Size,
                            L.Description,
                            L.LoadStatus,
                            TU.LorryNumberPlate,
                            L.ItemPhoto -- Assuming you still want this for potential future detail view
                        FROM
                            Loads L
                        INNER JOIN
                            Jobs J ON L.JobID = J.JobID
                        LEFT JOIN
                            TransportUnits TU ON L.TransportUnitID = TU.TransportUnitID
                        WHERE
                            J.CustomerID = @CustomerID -- Filter by logged-in customer's jobs
                        ORDER BY
                            L.LoadID DESC;";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.SelectCommand.Parameters.AddWithValue("@CustomerID", SessionManager.LoggedInCustomerID);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Add a calculated 'ProgressValue' column to the DataTable
                    dt.Columns.Add("ProgressValue", typeof(int));
                    foreach (DataRow row in dt.Rows)
                    {
                        string status = row["LoadStatus"].ToString();
                        row["ProgressValue"] = GetProgressPercentage(status);
                    }

                    dgvLoadsTracking.DataSource = dt;
                    // dgvLoadsTracking.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells); // Often looks better without this for Fill column

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No active loads found for your account.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading your load data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // --- Helper to convert LoadStatus to a percentage for the progress bar ---
        private int GetProgressPercentage(string status)
        {
            switch (status)
            {
                case "Pending":
                    return 0; // Or a small non-zero like 10% if "pending" means acknowledged
                case "Loaded":
                    return 30;
                case "In Transit":
                    return 70;
                case "Delivered":
                    return 100;
                case "Cancelled":
                    return 0; // Or indicate visually somehow else
                default:
                    return 0;
            }
        }

        private void tsmHome_Click(object sender, EventArgs e)
        {
            frmHome Home = new frmHome();

            Home.Show();

            this.Hide();
        }

        private void tsmMain_Click(object sender, EventArgs e)
        {
            frmMainCustomer mainCustomer = new frmMainCustomer();

            mainCustomer.Show();

            this.Hide();
        }

        private void tsmMyProfile_Click(object sender, EventArgs e)
        {
            frmMyProfile myProfile = new frmMyProfile();

            myProfile.Show();

            this.Hide();
        }

        private void tsmRequestNewTransport_Click(object sender, EventArgs e)
        {
            frmRequestNewTransport frmRequestNewTransport = new frmRequestNewTransport();

            frmRequestNewTransport.Show();

            this.Hide();
        }

        private void tsmViewMyJobs_Click(object sender, EventArgs e)
        {
            frmViewMyJobs viewMyJobs = new frmViewMyJobs();

            viewMyJobs.Show();

            this.Hide();
        }

        private void tsmTrackingStatus_Click(object sender, EventArgs e)
        {

        }

        private void tsmViewInvoice_Click(object sender, EventArgs e)
        {
            frmViewInvoice viewInvoice = new frmViewInvoice();

            viewInvoice.Show();

            this.Hide();
        }

        private void tsmCustomerDashboard_Click(object sender, EventArgs e)
        {
            frmCustomerDashboard customerDashboard = new frmCustomerDashboard();

            customerDashboard.Show();

            this.Hide();
        }

        // --- Form Load Event ---
        private void frmTrackStatus_Load(object sender, EventArgs e)
        {
            if (SessionManager.IsCustomerLoggedIn())
            {
                lblWelcomeMessage.Text = $"Welcome, {SessionManager.LoggedInCustomerName}! Here are your active loads:";
                LoadCustomerLoadsIntoGrid();
            }
            else
            {
                MessageBox.Show("You must be logged in to view tracking status.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Optionally redirect to login page
                // frmLoginCustomer loginForm = new frmLoginCustomer();
                // loginForm.Show();
                this.Close(); // Close this form if not logged in
            }
        }

        private void dgvLoadsTracking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // --- Navigation Buttons ---
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadCustomerLoadsIntoGrid();
        }

    }
}
