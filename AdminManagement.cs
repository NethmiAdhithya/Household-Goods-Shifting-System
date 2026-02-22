using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // For SQL database interaction
using System.Text.RegularExpressions; // For regular expression validation (e.g., email)
using System.Data.Common; // Base classes for database interaction

namespace E_Shift
{
    public partial class frmAdminManagement : Form
    {
        // Constructor for the Admin Management form
        public frmAdminManagement()
        {
            InitializeComponent(); // Initializes components defined in the designer
        }

        // --- Menu Strip Click Handlers (Navigation) ---

        // Navigates to the Main Admin form
        private void tsmMain_Click(object sender, EventArgs e)
        {
            frmMainAdmin mainAdmin = new frmMainAdmin();
            mainAdmin.Show();
            this.Hide(); // Hide the current form
        }

        // Navigates to the Home form
        private void Home_Click(object sender, EventArgs e)
        {
            frmHome Home = new frmHome();
            Home.Show();
            this.Hide(); // Hide the current form
        }

        // Navigates to the Customer Management form
        private void tsmCustomer_Click(object sender, EventArgs e)
        {
            frmCustomer customer = new frmCustomer();
            customer.Show();
            this.Hide(); // Hide the current form
        }

        // Navigates to the Job Management form
        private void tsmJob_Click(object sender, EventArgs e)
        {
            frmJob job = new frmJob();
            job.Show();
            this.Hide(); // Hide the current form
        }

        // Navigates to the Load Management form
        private void tsmLoad_Click(object sender, EventArgs e)
        {
            frmLoad load = new frmLoad();
            load.Show();
            this.Hide(); // Hide the current form
        }

        // Navigates to the Transport Unit Management form
        private void tsmTransportUnit_Click(object sender, EventArgs e)
        {
            frmTransportUnit transportUnit = new frmTransportUnit();
            transportUnit.Show();
            this.Hide(); // Hide the current form
        }

        // Navigates to the Invoice Management form
        private void tsmInvoice_Click(object sender, EventArgs e)
        {
            frmInvoice invoice = new frmInvoice();
            invoice.Show();
            this.Hide(); // Hide the current form
        }

        // Navigates to the Admin Dashboard form
        private void tsmDashboard_Click(object sender, EventArgs e)
        {
            frmAdminDashboard dashboard = new frmAdminDashboard();
            dashboard.Show();
            this.Hide(); // Hide the current form
        }

        // This is the current form, so clicking this menu item does nothing
        private void tsmAdminManagement_Click(object sender, EventArgs e)
        {
            // Already on this form, no action needed.
        }

        // Event handler for the "Reports" menu item (likely a parent, no direct navigation)
        private void tsmReports_Click(object sender, EventArgs e)
        {
            // No direct action for a parent menu item.
        }

        // Navigates to the Customer and Their Jobs Report form
        private void tsmCustomerTheirJobs_Click(object sender, EventArgs e)
        {
            frmCustomerAndTheirJobsReport customerAndTheirJobsReport = new frmCustomerAndTheirJobsReport();
            customerAndTheirJobsReport.Show();
            this.Hide(); // Hide the current form
        }

        // Navigates to the Jobs By Date Range Report form
        private void tsmJobsByDateRange_Click(object sender, EventArgs e)
        {
            frmJobsByDateRangeReport jobsByDateRangeReport = new frmJobsByDateRangeReport();
            jobsByDateRangeReport.Show();
            this.Hide(); // Hide the current form
        }

        // Navigates to the Loads By Transport Unit Report form
        private void tsmLoadsByTransportUnit_Click(object sender, EventArgs e)
        {
            frmLoadsByTransportUnitReport loadsByTransportUnitReport = new frmLoadsByTransportUnitReport();
            loadsByTransportUnitReport.Show();
            this.Hide(); // Hide the current form
        }

        // Navigates to the Delivery Performance Report form
        private void tsmDeliveryPerformance_Click(object sender, EventArgs e)
        {
            frmDeliveryPerformanceReport deliveryPerformanceReport = new frmDeliveryPerformanceReport();
            deliveryPerformanceReport.Show();
            this.Hide(); // Hide the current form
        }

        // Navigates to the Daily End Of The Loads Report form
        private void tsmDailyEndOfTheLoads_Click(object sender, EventArgs e)
        {
            frmDailyEndOfTheLoadsReport dailyEndOfTheLoadsReport = new frmDailyEndOfTheLoadsReport();
            dailyEndOfTheLoadsReport.Show();
            this.Hide(); // Hide the current form
        }

        // Empty event handler for lblAdminManagement click
        private void lblAdminManagement_Click(object sender, EventArgs e)
        {

        }

        // Event handler for DataGridView Cell Content Click (when a cell is clicked)
        private void dgvAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure a valid row is clicked (not header)
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAdmin.Rows[e.RowIndex]; // Get the selected row

                // Populate textboxes with data from the selected row
                txtAdminId.Text = row.Cells["AdminID"].Value?.ToString(); // Safe null-check
                txtName.Text = row.Cells["Name"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
                txtUsername.Text = row.Cells["Username"].Value?.ToString();
                // IMPORTANT: For security, never load sensitive data like passwords directly into a textbox
                txtPassword.Clear();
                txtConfirmPassword.Clear();

                // Make AdminID textbox read-only as it's the primary key and should not be editable directly after selection
                txtAdminId.ReadOnly = true;
            }
        }

        // --- Empty Event Handlers for UI Elements (labels and textboxes) ---
        // These handlers are often generated by the designer but may not have specific logic.
        private void lblAdminId_Click(object sender, EventArgs e) { }
        private void txtAdminId_TextChanged(object sender, EventArgs e) { }
        private void lblName_Click(object sender, EventArgs e) { }
        private void txtName_TextChanged(object sender, EventArgs e) { }
        private void lblEmail_Click(object sender, EventArgs e) { }
        private void txtEmail_TextChanged(object sender, EventArgs e) { }
        private void lblUsername_Click(object sender, EventArgs e) { }
        private void txtUsername_TextChanged(object sender, EventArgs e) { }
        private void lblPassword_Click(object sender, EventArgs e) { }
        private void txtPassword_TextChanged(object sender, EventArgs e) { }
        private void lblConfirmPassword_Click(object sender, EventArgs e) { }
        private void txtConfirmPassword_TextChanged(object sender, EventArgs e) { }

        // Event handler for the "Search Admin" button click
        private void btnSearchAdmin_Click(object sender, EventArgs e)
        {
            // Validate if Admin ID is entered for search
            if (string.IsNullOrWhiteSpace(txtAdminId.Text))
            {
                MessageBox.Show("Please enter an Admin ID to search.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAdminId.Focus();
                return;
            }
            // Validate if Admin ID is numeric
            if (!int.TryParse(txtAdminId.Text.Trim(), out int adminId))
            {
                MessageBox.Show("Please enter a valid numeric Admin ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAdminId.Focus();
                return;
            }

            SearchAdminById(adminId); // Call method to search for admin
        }

        // Method to search for an admin by Admin ID and populate fields
        private void SearchAdminById(int adminId)
        {
            ClearFormFields(); // Clear previous data in textboxes

            using (SqlConnection connection = new SqlConnection(DbConnection.ConnectionString))
            {
                try
                {
                    connection.Open(); // Open database connection
                    string query = "SELECT AdminID, Name, Email, Username, Password FROM Admins WHERE AdminID = @AdminID"; // SQL query to select admin
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@AdminID", adminId); // Add parameter to prevent SQL injection

                    SqlDataReader reader = command.ExecuteReader(); // Execute query and get data reader

                    if (reader.Read()) // If an admin is found
                    {
                        // Populate textboxes with retrieved data
                        txtAdminId.Text = reader["AdminID"].ToString();
                        txtName.Text = reader["Name"].ToString();
                        txtEmail.Text = reader["Email"].ToString();
                        txtUsername.Text = reader["Username"].ToString();
                        // Do NOT load password into txtPassword for security reasons
                        txtPassword.Text = "";
                        txtConfirmPassword.Text = "";

                        MessageBox.Show("Admin details loaded successfully!", "Search Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else // If no admin is found
                    {
                        MessageBox.Show("No admin found for the provided Admin ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtAdminId.Text = adminId.ToString(); // Keep the searched ID in the textbox
                    }
                    reader.Close(); // Close the data reader
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("Database error during search: " + sqlEx.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred during search: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    LoadAdminsIntoGrid(); // Always refresh the grid after search
                }
            }
        }

        // Event handler for the "Add Admin" button click
        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) // Validate all required input fields
            {
                return; // Stop if validation fails
            }

            // Check for duplicate username
            if (CheckUsernameExists(txtUsername.Text.Trim()))
            {
                MessageBox.Show("Username already exists. Please choose a different username.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }
            // Check for duplicate email
            if (CheckEmailExists(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Email address already registered. Please use a different email.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            // In a real application, hash the password before storing in the database
            string hashedPassword = txtPassword.Text; // Placeholder: Ideally use a strong hashing algorithm

            using (SqlConnection connection = new SqlConnection(DbConnection.ConnectionString))
            {
                try
                {
                    connection.Open(); // Open database connection
                    string query = @"INSERT INTO Admins (Name, Email, Username, Password)
                                     VALUES (@Name, @Email, @Username, @Password);
                                     SELECT SCOPE_IDENTITY();"; // SQL query to insert new admin and get its ID

                    SqlCommand command = new SqlCommand(query, connection);
                    // Add parameters to the command
                    command.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                    command.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                    command.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                    command.Parameters.AddWithValue("@Password", hashedPassword);

                    // ExecuteScalar returns the first column of the first row (the new AdminID)
                    int newAdminId = Convert.ToInt32(command.ExecuteScalar());

                    MessageBox.Show($"Admin added successfully! New Admin ID: {newAdminId}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFormFields(); // Clear form fields after successful add
                    LoadAdminsIntoGrid(); // Refresh DataGridView to show the new admin
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("Database error adding admin: " + sqlEx.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred while adding admin: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Event handler for the "Update Admin Details" button click
        private void btnUpdateAdminDetails_Click(object sender, EventArgs e)
        {
            // Validate if an Admin ID is selected or entered for update
            if (string.IsNullOrWhiteSpace(txtAdminId.Text) || !int.TryParse(txtAdminId.Text, out int adminIdToUpdate))
            {
                MessageBox.Show("Please select an Admin from the grid or search for one to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput(isUpdate: true)) // Validate input, password is optional for update
            {
                return; // Stop if validation fails
            }

            // Check for duplicate username/email, excluding the current admin being updated
            if (CheckUsernameExists(txtUsername.Text.Trim(), adminIdToUpdate))
            {
                MessageBox.Show("Username already exists for another admin. Please choose a different username.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }
            if (CheckEmailExists(txtEmail.Text.Trim(), adminIdToUpdate))
            {
                MessageBox.Show("Email address already registered for another admin. Please use a different email.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            // Determine if password needs to be updated (only if password fields are non-empty)
            string hashedPassword = txtPassword.Text.Trim(); // Placeholder: Ideally use a strong hashing algorithm
            string updatePasswordClause = string.Empty;
            if (!string.IsNullOrWhiteSpace(hashedPassword))
            {
                updatePasswordClause = ", Password = @Password"; // Add password update clause to query
            }

            using (SqlConnection connection = new SqlConnection(DbConnection.ConnectionString))
            {
                try
                {
                    connection.Open(); // Open database connection
                    // SQL query to update admin details. Dynamically adds password update if provided.
                    string query = $@"UPDATE Admins SET
                                     Name = @Name,
                                     Email = @Email,
                                     Username = @Username
                                     {updatePasswordClause}
                                     WHERE AdminID = @AdminID";

                    SqlCommand command = new SqlCommand(query, connection);
                    // Add parameters
                    command.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                    command.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                    command.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                    command.Parameters.AddWithValue("@AdminID", adminIdToUpdate);
                    if (!string.IsNullOrWhiteSpace(hashedPassword))
                    {
                        command.Parameters.AddWithValue("@Password", hashedPassword); // Add password parameter if updating
                    }

                    int rowsAffected = command.ExecuteNonQuery(); // Execute the update query

                    if (rowsAffected > 0) // If update was successful
                    {
                        MessageBox.Show("Admin details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFormFields(); // Clear form fields
                        LoadAdminsIntoGrid(); // Refresh DataGridView
                    }
                    else // If admin not found or no changes were made
                    {
                        MessageBox.Show("Admin not found or no changes were made.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("Database error updating admin: " + sqlEx.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred while updating admin: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Event handler for the "Delete Admin" button click
        private void btnDeleteAdmin_Click(object sender, EventArgs e)
        {
            // Validate if an Admin ID is selected or entered for deletion
            if (string.IsNullOrWhiteSpace(txtAdminId.Text) || !int.TryParse(txtAdminId.Text, out int adminIdToDelete))
            {
                MessageBox.Show("Please select an Admin from the grid or search for one to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Optional: Prevent deleting the currently logged-in admin (requires a SessionManager or similar)
            // if (adminIdToDelete == SessionManager.LoggedInAdminID) { MessageBox.Show("Cannot delete the currently logged-in admin account."); return; }

            // Confirm deletion with the user
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this admin permanently?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No)
            {
                return; // Abort deletion if user clicks No
            }

            using (SqlConnection connection = new SqlConnection(DbConnection.ConnectionString))
            {
                try
                {
                    connection.Open(); // Open database connection
                    string query = "DELETE FROM Admins WHERE AdminID = @AdminID"; // SQL query to delete admin
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@AdminID", adminIdToDelete); // Add parameter

                    int rowsAffected = command.ExecuteNonQuery(); // Execute the delete query

                    if (rowsAffected > 0) // If deletion was successful
                    {
                        MessageBox.Show("Admin deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFormFields(); // Clear form fields
                        LoadAdminsIntoGrid(); // Refresh DataGridView
                    }
                    else // If admin not found
                    {
                        MessageBox.Show("Admin not found.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (SqlException sqlEx)
                {
                    // Catch specific error for foreign key constraint violation (e.g., if admin is referenced by other tables)
                    if (sqlEx.Number == 547) // SQL Server error number for FK violation
                    {
                        MessageBox.Show("Cannot delete admin: This admin is linked to other records in the system (e.g., jobs, reports). Please remove associated records first.", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Database error deleting admin: " + sqlEx.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred while deleting admin: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Event handler for the "Clear" button click
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFormFields(); // Call method to clear all input fields
        }

        // Event handler for when the Admin Management form loads
        private void frmAdminManagement_Load(object sender, EventArgs e)
        {
            LoadAdminsIntoGrid(); // Load existing admin data into the DataGridView
            ClearFormFields(); // Clear input fields for a fresh start
            txtAdminId.ReadOnly = false; // Ensure Admin ID textbox is editable initially for new entries or searches
        }

        // Method to validate input fields
        private bool ValidateInput(bool isUpdate = false)
        {
            // Name validation: Must not be empty
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }

            // Email validation: Must not be empty and must be a valid email format
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$"; // Regex for email format
            if (!Regex.IsMatch(txtEmail.Text.Trim(), emailPattern))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            // Username validation: Must not be empty and at least 5 characters long
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Username cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return false;
            }
            if (txtUsername.Text.Trim().Length < 5)
            {
                MessageBox.Show("Username must be at least 5 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return false;
            }

            // Password validation:
            // For 'Add' operation, password fields are mandatory.
            // For 'Update' operation, password fields are optional, but if either is filled, both must be filled and match.
            if (!isUpdate || (!string.IsNullOrWhiteSpace(txtPassword.Text) || !string.IsNullOrWhiteSpace(txtConfirmPassword.Text)))
            {
                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("Password cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Focus();
                    return false;
                }
                if (txtPassword.Text.Length < 6)
                {
                    MessageBox.Show("Password must be at least 6 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Focus();
                    return false;
                }
                if (txtPassword.Text != txtConfirmPassword.Text)
                {
                    MessageBox.Show("Password and Confirm Password do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtConfirmPassword.Focus();
                    return false;
                }
            }
            return true; // All validations passed
        }

        // Method to check if an Admin ID already exists in the database
        private bool CheckAdminIdExists(int adminId)
        {
            using (SqlConnection connection = new SqlConnection(DbConnection.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Admins WHERE AdminID = @AdminID"; // Count admins with the given ID
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@AdminID", adminId);
                    return (int)command.ExecuteScalar() > 0; // Returns true if count > 0 (ID exists)
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error checking Admin ID existence: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false; // Assume not exists on error
                }
            }
        }

        // Method to check if a username already exists (optionally excluding a specific Admin ID for updates)
        private bool CheckUsernameExists(string username, int? excludeAdminId = null)
        {
            using (SqlConnection connection = new SqlConnection(DbConnection.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Admins WHERE Username = @Username"; // Base query
                    if (excludeAdminId.HasValue) // If an Admin ID is provided to exclude (for update scenarios)
                    {
                        query += " AND AdminID != @AdminID"; // Add condition to exclude current admin
                    }
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);
                    if (excludeAdminId.HasValue)
                    {
                        command.Parameters.AddWithValue("@AdminID", excludeAdminId.Value);
                    }
                    return (int)command.ExecuteScalar() > 0; // Returns true if count > 0 (username exists)
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error checking username existence: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false; // Assume not exists on error
                }
            }
        }

        // Method to check if an email already exists (optionally excluding a specific Admin ID for updates)
        private bool CheckEmailExists(string email, int? excludeAdminId = null)
        {
            using (SqlConnection connection = new SqlConnection(DbConnection.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Admins WHERE Email = @Email"; // Base query
                    if (excludeAdminId.HasValue) // If an Admin ID is provided to exclude (for update scenarios)
                    {
                        query += " AND AdminID != @AdminID"; // Add condition to exclude current admin
                    }
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Email", email);
                    if (excludeAdminId.HasValue)
                    {
                        command.Parameters.AddWithValue("@AdminID", excludeAdminId.Value);
                    }
                    return (int)command.ExecuteScalar() > 0; // Returns true if count > 0 (email exists)
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error checking email existence: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false; // Assume not exists on error
                }
            }
        }

        // Method to clear all input textboxes and reset Admin ID read-only state
        private void ClearFormFields()
        {
            txtAdminId.Clear();
            txtName.Clear();
            txtEmail.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            txtAdminId.ReadOnly = false; // Make Admin ID editable for new entries
        }

        // Method to load all admin data into the DataGridView
        private void LoadAdminsIntoGrid()
        {
            using (SqlConnection connection = new SqlConnection(DbConnection.ConnectionString))
            {
                try
                {
                    connection.Open(); // Open database connection
                    string query = "SELECT AdminID, Name, Email, Username, Password FROM Admins"; // Select all admin details
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable(); // Create a new DataTable
                    adapter.Fill(dt); // Fill the DataTable with data
                    dgvAdmin.DataSource = dt; // Set the DataTable as the DataGridView's data source

                    // Hide the password column in the DataGridView for security
                    if (dgvAdmin.Columns.Contains("Password"))
                    {
                        dgvAdmin.Columns["Password"].Visible = false;
                    }
                    // Auto-size columns for better readability
                    dgvAdmin.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("Database error loading admins: " + sqlEx.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading admins: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}