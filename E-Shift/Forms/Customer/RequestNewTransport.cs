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
    public partial class frmRequestNewTransport : Form
    {
        // Removed private fields _loggedInCustomerId and _loggedInUsername as they are now accessed directly from SessionManager

        // Constructor for the form, initializes components
        public frmRequestNewTransport()
        {
            InitializeComponent();
        }

        // Removed the parameterized constructor as customer ID will be obtained from SessionManager
        // public frmRequestNewTransport(int customerId, string username) : this()
        // {
        //      _loggedInCustomerId = customerId;
        //      _loggedInUsername = username;
        //      txtCustomerId.Text = _loggedInCustomerId.ToString();
        //      txtCustomerId.ReadOnly = true;
        // }

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
            // Assumes frmMainCustomer will get session data from SessionManager
            frmMainCustomer mainCustomer = new frmMainCustomer();
            mainCustomer.Show();
            this.Hide(); // Hide the current form
        }

        // Navigates to the My Profile form
        private void tsmMyProfile_Click(object sender, EventArgs e)
        {
            // Assumes frmMyProfile will also get the CustomerID from SessionManager
            frmMyProfile myProfile = new frmMyProfile();
            myProfile.Show();
            this.Hide(); // Hide the current form
        }

        // This is the current form, so clicking this menu item does nothing
        private void tsmRequestNewTransport_Click(object sender, EventArgs e)
        {
            // No action needed as already on this form.
        }

        // Navigates to the View My Jobs form
        private void tsmViewMyJobs_Click(object sender, EventArgs e)
        {
            frmViewMyJobs viewMyJobs = new frmViewMyJobs();
            viewMyJobs.Show();
            this.Hide(); // Hide the current form
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

        // --- Keep other empty event handlers for UI elements if they exist ---
        private void lblRequestNewTransport_Click(object sender, EventArgs e) { }
        private void lblCustomerId_Click(object sender, EventArgs e) { }
        private void txtCustomerId_TextChanged(object sender, EventArgs e) { }
        private void lblStartLocation_Click(object sender, EventArgs e) { }
        private void txtStartLocation_TextChanged(object sender, EventArgs e) { }
        private void lblDestination_Click(object sender, EventArgs e) { }
        private void txtDestination_TextChanged(object sender, EventArgs e) { }
        private void lblJobDate_Click(object sender, EventArgs e) { }
        private void dtpJobDate_ValueChanged(object sender, EventArgs e) { }
        private void lblDescription_Click(object sender, EventArgs e) { }
        private void txtDescription_TextChanged(object sender, EventArgs e) { }
        // --- End of empty event handlers ---


        // Handles the click event for the "Submit Request" button
        private void btnSubmitRequest_Click(object sender, EventArgs e)
        {
            // Get the currently logged-in customer ID from the SessionManager
            int customerId = SessionManager.LoggedInCustomerID;

            // Perform an immediate check if a customer is indeed logged in
            if (customerId <= 0)
            {
                MessageBox.Show("You must be logged in as a customer to submit a request. Please log in again.", "Session Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                new frmLogin().Show(); // Redirect to the login form
                this.Close(); // Close the current form instance
                return; // Stop further execution
            }

            // Get user input from form controls
            string startLocation = txtStartLocation.Text.Trim();
            string destination = txtDestination.Text.Trim();
            DateTime jobDate = dtpJobDate.Value;
            string description = txtDescription.Text.Trim();

            // --- Input Validation ---
            if (string.IsNullOrWhiteSpace(startLocation))
            {
                MessageBox.Show("Please enter the Start Location.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStartLocation.Focus(); // Set focus to the problematic field
                return;
            }

            if (string.IsNullOrWhiteSpace(destination))
            {
                MessageBox.Show("Please enter the Destination.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDestination.Focus();
                return;
            }

            if (jobDate.Date < DateTime.Today.Date) // Check if the selected date is in the past
            {
                MessageBox.Show("Job Date cannot be in the past. Please select a future or today's date.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpJobDate.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("Please provide a brief Description of the items.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescription.Focus();
                return;
            }

            // --- Database Insertion ---
            using (SqlConnection con = new SqlConnection(DbConnection.ConnectionString)) // Establish a SQL connection
            {
                try
                {
                    con.Open(); // Open the database connection
                    // SQL query to insert a new job request into the Jobs table
                    string query = @"INSERT INTO Jobs
                                       (CustomerID, StartLocation, Destination, JobDate, JobStatus, Description, CreatedDate)
                                       VALUES
                                       (@CustomerID, @StartLocation, @Destination, @JobDate, @JobStatus, @Description, @CreatedDate);
                                       SELECT SCOPE_IDENTITY();"; // Retrieve the ID of the newly inserted row

                    using (SqlCommand cmd = new SqlCommand(query, con)) // Create a SQL command
                    {
                        // Add parameters to the SQL command to prevent SQL injection
                        cmd.Parameters.AddWithValue("@CustomerID", customerId); // Use customer ID from session
                        cmd.Parameters.AddWithValue("@StartLocation", startLocation);
                        cmd.Parameters.AddWithValue("@Destination", destination);
                        cmd.Parameters.AddWithValue("@JobDate", jobDate.Date); // Store only the date part
                        cmd.Parameters.AddWithValue("@JobStatus", "Pending"); // Set initial status to 'Pending'
                        cmd.Parameters.AddWithValue("@Description", description);
                        cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now); // Record the current date and time of creation

                        int newJobId = Convert.ToInt32(cmd.ExecuteScalar()); // Execute the query and get the new Job ID

                        // Inform the user about the successful submission
                        MessageBox.Show($"Transport request submitted successfully!\nYour Job ID is: {newJobId}\nStatus: Pending approval.",
                                        "Request Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ClearForm(); // Clear the form fields after successful submission
                    }
                }
                catch (SqlException ex) // Catch SQL-specific exceptions
                {
                    if (ex.Number == 547) // Foreign key violation error code (e.g., CustomerID does not exist)
                    {
                        MessageBox.Show("The Customer ID associated with your session does not exist in the database. Please contact support.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Database error submitting request: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex) // Catch any other general exceptions
                {
                    MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Clears all input fields on the form
        private void ClearForm()
        {
            // txtCustomerId is read-only and populated on Load, so no need to clear it here.
            txtStartLocation.Clear();
            txtDestination.Clear();
            dtpJobDate.Value = DateTime.Today; // Reset date to today
            txtDescription.Clear();

            txtStartLocation.Focus(); // Set focus to the first input field for convenience
        }

        // Handles the click event for the "Reset Form" button, calls ClearForm
        private void btnResetForm_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        // Handles the Load event of the form, executed when the form is displayed
        private void frmRequestNewTransport_Load(object sender, EventArgs e)
        {
            // Check if a customer is logged in via SessionManager
            if (SessionManager.IsCustomerLoggedIn())
            {
                txtCustomerId.Text = SessionManager.LoggedInCustomerID.ToString(); // Display the logged-in customer's ID
                txtCustomerId.ReadOnly = true; // Ensure the customer ID field is read-only
                dtpJobDate.Value = DateTime.Today; // Set the default job date to today's date
                txtStartLocation.Focus(); // Set initial focus to the start location field
            }
            else
            {
                // If no customer is logged in, show an error and redirect to the login form
                MessageBox.Show("You must be logged in as a customer to request transport.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                new frmLogin().Show(); // Open the login form
                this.Close(); // Close the current "Request New Transport" form
            }
        }
    }
}