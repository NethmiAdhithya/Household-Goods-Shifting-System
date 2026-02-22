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

namespace E_Shift
{
    public partial class frmViewMyJobs : Form
    {
        // Constructor for the form
        public frmViewMyJobs()
        {
            InitializeComponent();
            // Attach the CellClick event handler to the DataGridView programmatically
            this.dgvMyJobs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMyJobs_CellClick);
        }

        // Method to load customer's job data into the DataGridView
        private void LoadCustomerJobs()
        {
            // 1. Get the LoggedInCustomerID from SessionManager
            int customerId = SessionManager.LoggedInCustomerID;

            // Display the Customer ID in the txtCustomerId textbox if it exists
            if (txtCustomerId != null) // Ensure the textbox control exists on the form
            {
                txtCustomerId.Text = customerId.ToString(); // Set text to the customer ID
                txtCustomerId.ReadOnly = true; // Make the textbox read-only
            }

            // Check if a valid customer is logged in
            if (customerId <= 0)
            {
                MessageBox.Show("No customer is logged in. Please log in to view your jobs.", "Session Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Optionally, redirect to the login form if the session is invalid
                new frmLogin().Show();
                this.Close(); // Close the current form
                return; // Exit the method
            }

            // 2. Query the database for jobs related to this CustomerID
            using (SqlConnection con = new SqlConnection(DbConnection.ConnectionString)) // Create a new SQL connection
            {
                try
                {
                    con.Open(); // Open the database connection
                    // SQL query to select relevant job details for the logged-in customer
                    string query = @"SELECT JobID, StartLocation, Destination, JobDate, CompletionDate, JobStatus, Description
                                     FROM Jobs
                                     WHERE CustomerID = @CustomerID
                                     ORDER BY CreatedDate DESC, JobDate DESC"; // Order by most recent jobs first

                    using (SqlCommand cmd = new SqlCommand(query, con)) // Create a SQL command
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", customerId); // Add the CustomerID parameter to the command

                        // Use a SqlDataAdapter to fill a DataTable with the query results
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable(); // Create a new DataTable
                        da.Fill(dt); // Fill the DataTable with data from the database

                        // 3. Display the results in the DataGridView
                        if (dgvMyJobs != null) // Check if the DataGridView control exists
                        {
                            dgvMyJobs.DataSource = dt; // Set the DataTable as the DataGridView's data source

                            // Optional: Customize DataGridView appearance and behavior for better user experience
                            dgvMyJobs.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells); // Adjust column widths automatically
                            dgvMyJobs.ReadOnly = true; // Make the entire grid read-only
                            dgvMyJobs.AllowUserToAddRows = false; // Prevent users from adding new rows directly
                            dgvMyJobs.AllowUserToDeleteRows = false; // Prevent users from deleting rows directly
                            dgvMyJobs.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Select the entire row on click
                            dgvMyJobs.MultiSelect = false; // Allow only single row selection

                            // Clear detail textboxes when jobs are loaded initially or refreshed
                            ClearJobDetailsTextBoxes();
                        }
                        else
                        {
                            MessageBox.Show("Error: DataGridView 'dgvMyJobs' not found on this form. Please ensure it is named correctly in the designer.", "Configuration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        // Inform the user if no jobs were found
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("You have no jobs recorded yet.", "No Jobs Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (SqlException ex) // Catch specific SQL database exceptions
                {
                    MessageBox.Show("Database error loading jobs: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex) // Catch any other general exceptions
                {
                    MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Method to clear the job detail textboxes on the form
        private void ClearJobDetailsTextBoxes()
        {
            // Clear textboxes only if they are not null to prevent NullReferenceException
            if (txtJobId != null) txtJobId.Clear();
            if (txtStartLocation != null) txtStartLocation.Clear();
            if (txtDestination != null) txtDestination.Clear();
            if (txtJobDate != null) txtJobDate.Clear();
            if (txtCompletionDate != null) txtCompletionDate.Clear();
            if (txtJobStatus != null) txtJobStatus.Clear();
            if (txtDescription != null) txtDescription.Clear();
        }

        // --- Menu Strip Click Handlers (Navigation) ---

        // Navigates to the Home form
        private void tsmHome_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            home.Show();
            this.Hide(); // Hide the current form
        }

        // Navigates to the Main Customer dashboard form
        private void tsmMain_Click(object sender, EventArgs e)
        {
            frmMainCustomer mainCustomer = new frmMainCustomer();
            mainCustomer.Show();
            this.Hide(); // Hide the current form
        }

        // Navigates to the My Profile form
        private void tsmMyProfile_Click(object sender, EventArgs e)
        {
            frmMyProfile mainProfile = new frmMyProfile();
            mainProfile.Show();
            this.Hide(); // Hide the current form
        }

        // Navigates to the Request New Transport form
        private void tsmRequestNewTransport_Click(object sender, EventArgs e)
        {
            frmRequestNewTransport requestNewTransport = new frmRequestNewTransport();
            requestNewTransport.Show();
            this.Hide(); // Hide the current form
        }

        // This is the current form, so clicking this menu item does nothing
        private void tsmViewMyJobs_Click(object sender, EventArgs e)
        {
            // No action needed as already on this form.
        }

        // Navigates to the Tracking Status form
        private void tsmTrackingStatus_Click(object sender, EventArgs e)
        {
            frmTrackStatus trackStatus = new frmTrackStatus();
            trackStatus.Show();
            this.Hide(); // Hide the current form
        }

        // Navigates to the View Invoice form
        private void tsmViewInvoice_Click(object sender, EventArgs e)
        {
            frmViewInvoice viewInvoice = new frmViewInvoice();
            viewInvoice.Show();
            this.Hide(); // Hide the current form
        }

        // Navigates to the Customer Dashboard form
        private void tsmCustomerDashboard_Click(object sender, EventArgs e)
        {
            frmCustomerDashboard customerDashboard = new frmCustomerDashboard();
            customerDashboard.Show();
            this.Hide(); // Hide the current form
        }

        // Empty event handler for lblViewMyJobs click
        private void lblViewMyJobs_Click(object sender, EventArgs e)
        {

        }

        // Form Load event handler: called when the form is first displayed
        private void frmViewMyJobs_Load(object sender, EventArgs e)
        {
            LoadCustomerJobs(); // Call method to load customer's job data
        }

        // --- Empty Event Handlers for UI Elements (labels and textboxes) ---
        // These handlers are often generated by the designer but may not have specific logic.
        private void lblCustomerId_Click(object sender, EventArgs e) { }
        private void txtCustomerId_TextChanged(object sender, EventArgs e) { }
        private void lblCustomerId_Click_1(object sender, EventArgs e) { }
        private void txtCustomerId_TextChanged_1(object sender, EventArgs e) { }
        private void lblJobId_Click(object sender, EventArgs e) { }
        private void txtJobId_TextChanged(object sender, EventArgs e) { }
        private void lblStartLocation_Click(object sender, EventArgs e) { }
        private void txtStartLocation_TextChanged(object sender, EventArgs e) { }
        private void lblDestination_Click(object sender, EventArgs e) { }
        private void txtDestination_TextChanged(object sender, EventArgs e) { }
        private void lblJobDate_Click(object sender, EventArgs e) { }
        private void txtJobDate_TextChanged(object sender, EventArgs e) { }
        private void lblCompletionDate_Click(object sender, EventArgs e) { }
        private void txtCompletionDate_TextChanged(object sender, EventArgs e) { }
        private void lblJobStatus_Click(object sender, EventArgs e) { }
        private void txtJobStatus_TextChanged(object sender, EventArgs e) { }
        private void lblDescription_Click(object sender, EventArgs e) { }
        private void txtDescription_TextChanged(object sender, EventArgs e) { }

        // Event handler for DataGridView Cell Click
        private void dgvMyJobs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a valid row was clicked (not the header or an empty row)
            if (e.RowIndex >= 0 && e.RowIndex < dgvMyJobs.Rows.Count)
            {
                DataGridViewRow selectedRow = dgvMyJobs.Rows[e.RowIndex]; // Get the selected row

                // Populate textboxes with data from the selected row using the helper method
                txtJobId.Text = GetCellValue(selectedRow, "JobID");
                txtStartLocation.Text = GetCellValue(selectedRow, "StartLocation");
                txtDestination.Text = GetCellValue(selectedRow, "Destination");
                txtJobDate.Text = FormatDateForDisplay(GetCellValue(selectedRow, "JobDate")); // Format date for display
                txtCompletionDate.Text = FormatDateForDisplay(GetCellValue(selectedRow, "CompletionDate")); // Format date for display
                txtJobStatus.Text = GetCellValue(selectedRow, "JobStatus");
                txtDescription.Text = GetCellValue(selectedRow, "Description");

                // Make sure all detail textboxes are read-only to prevent user modification
                SetTextBoxesReadOnly(true);
            }
        }

        // Helper method to safely retrieve cell values from a DataGridView row, handling DBNull values
        private string GetCellValue(DataGridViewRow row, string columnName)
        {
            // Check if the column exists by name using the Cells collection indexer and if its value is not DBNull
            if (row.Cells[columnName] != null && row.Cells[columnName].Value != DBNull.Value)
            {
                return row.Cells[columnName].Value.ToString(); // Return the cell value as a string
            }
            return string.Empty; // Return an empty string if the value is null, DBNull, or column doesn't exist
        }

        // Helper method to format date strings into a user-friendly format
        private string FormatDateForDisplay(string dateString)
        {
            // Attempt to parse the string into a DateTime object
            if (DateTime.TryParse(dateString, out DateTime date))
            {
                return date.ToShortDateString(); // Return the date in a short date format (e.g., "M/d/yyyy")
            }
            return dateString; // If parsing fails, return the original string
        }

        // Helper method to set the ReadOnly property of all job detail textboxes
        private void SetTextBoxesReadOnly(bool readOnly)
        {
            // Set ReadOnly property for each textbox, checking if it exists
            if (txtJobId != null) txtJobId.ReadOnly = readOnly;
            if (txtStartLocation != null) txtStartLocation.ReadOnly = readOnly;
            if (txtDestination != null) txtDestination.ReadOnly = readOnly;
            if (txtJobDate != null) txtJobDate.ReadOnly = readOnly;
            if (txtCompletionDate != null) txtCompletionDate.ReadOnly = readOnly;
            if (txtJobStatus != null) txtJobStatus.ReadOnly = readOnly;
            if (txtDescription != null) txtDescription.ReadOnly = readOnly;
        }

        // Empty event handler for DataGridView CellContentClick (typically for button clicks within cells)
        private void dgvMyJobs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}