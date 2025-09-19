using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // For interacting with SQL Server database
using System.IO; // For file system operations (e.g., handling photos)
using BCrypt.Net; // For hashing and verifying passwords

namespace E_Shift
{
    public partial class frmMyProfile : Form
    {
        private int _loggedInCustomerId; // Stores the ID of the currently logged-in customer
        private string _selectedPhotoPath = null; // Stores the path of the newly selected photo for upload

        // Constructor for the My Profile form
        public frmMyProfile()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*'; // Mask password input
            txtConfirmPassword.PasswordChar = '*'; // Mask confirm password input
        }

        // --- Menu Strip Click Handlers (Navigation) ---

        // Navigates to the Home form
        private void tsmHome_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            home.Show();
            this.Hide(); // Hide the current form
        }

        // Navigates to the Main Customer form
        private void tsmMain_Click(object sender, EventArgs e)
        {
            frmMainCustomer mainCustomer = new frmMainCustomer();
            mainCustomer.Show();
            this.Hide(); // Hide the current form
        }

        // This is the current form, so clicking this menu item does nothing (stays on profile)
        private void tsmMyProfile_Click(object sender, EventArgs e)
        {
            // Already on My Profile form
        }

        // Navigates to the Request New Transport form
        private void tsmRequestNewTransport_Click(object sender, EventArgs e)
        {
            frmRequestNewTransport requestNewTransport = new frmRequestNewTransport();
            requestNewTransport.Show();
            this.Hide(); // Hide the current form
        }

        // Navigates to the View Invoice form (note: original code had this linked to ViewMyJobs)
        private void tsmViewMyJobs_Click(object sender, EventArgs e)
        {
            frmViewInvoice viewInvoice = new frmViewInvoice();
            viewInvoice.Show();
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
            frmViewInvoice viewInvoice1 = new frmViewInvoice();
            viewInvoice1.Show();
            this.Hide(); // Hide the current form
        }

        // Navigates to the Customer Dashboard form
        private void tsmCustomerDashboard_Click(object sender, EventArgs e)
        {
            frmCustomerDashboard customerDashboard = new frmCustomerDashboard();
            customerDashboard.Show();
            this.Hide(); // Hide the current form
        }

        // --- UI Element Click/Change Handlers (mostly empty, can be removed if unused) ---
        private void lblMyProfile_Click(object sender, EventArgs e) { }
        private void lblUsername_Click(object sender, EventArgs e) { }
        private void txtUsername_TextChanged(object sender, EventArgs e) { }
        private void lblCustomerId_Click(object sender, EventArgs e) { }
        private void txtCustomerId_TextChanged(object sender, EventArgs e) { }
        private void lblName_Click(object sender, EventArgs e) { }
        private void txtName_TextChanged(object sender, EventArgs e) { }
        private void lblEmail_Click(object sender, EventArgs e) { }
        private void txtEmail_TextChanged(object sender, EventArgs e) { }
        private void lblContactNumber_Click(object sender, EventArgs e) { }
        private void txtContactNumber_TextChanged(object sender, EventArgs e) { }
        private void lblAddress_Click(object sender, EventArgs e) { }
        private void txtAddress_TextChanged(object sender, EventArgs e) { }
        private void lblPhoto_Click(object sender, EventArgs e) { }

        // Handles the click event for the "Upload Photo" button
        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"; // Filter for image files
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _selectedPhotoPath = openFileDialog.FileName; // Store the full path of the selected file

                // Load image into PictureBox using a MemoryStream to avoid file locking issues
                using (FileStream fs = new FileStream(_selectedPhotoPath, FileMode.Open, FileAccess.Read))
                {
                    picUploadedPhoto.Image = Image.FromStream(fs);
                }
                picUploadedPhoto.SizeMode = PictureBoxSizeMode.Zoom; // Adjust image display mode
            }
        }

        // Empty event handler for picUploadedPhoto (can be removed if unused)
        private void picUploadedPhoto_Click(object sender, EventArgs e) { }

        // Handles the click event for the "Save Changes" button
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            // Ensure a customer is logged in before attempting to save
            if (_loggedInCustomerId <= 0)
            {
                MessageBox.Show("No customer is logged in to save changes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get trimmed values from text boxes
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string contactNumber = txtContactNumber.Text.Trim();
            string address = txtAddress.Text.Trim();
            string newPassword = txtPassword.Text; // New password (unhashed)
            string confirmNewPassword = txtConfirmPassword.Text;

            // Basic validation for essential fields
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Name and Email cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Password change validation logic
            string hashedPasswordForUpdate = null;
            if (!string.IsNullOrWhiteSpace(newPassword) || !string.IsNullOrWhiteSpace(confirmNewPassword))
            {
                if (newPassword != confirmNewPassword) // Check if passwords match
                {
                    MessageBox.Show("New password and confirm password do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Clear(); // Clear password fields
                    txtConfirmPassword.Clear();
                    txtPassword.Focus(); // Set focus for re-entry
                    return;
                }
                if (newPassword.Length < 6) // Enforce minimum password length
                {
                    MessageBox.Show("New password must be at least 6 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Focus();
                    return;
                }
                hashedPasswordForUpdate = BCrypt.Net.BCrypt.HashPassword(newPassword); // Hash the new password
            }

            // Handle photo upload/update logic
            string photoDbPath = _selectedPhotoPath; // Assume existing path or newly selected path
            // The boolean photoChanged is declared but not explicitly used in the final version to control DB update.
            // Its logic here is mainly for file system operations.
            bool photoChanged = false; // Flag to indicate if the photo needs to be updated in DB

            // This block's condition appears complex; simplified for commenting.
            // It generally intends to handle cases where a new photo is selected.
            if (!string.IsNullOrEmpty(_selectedPhotoPath)) // If a new photo file was picked via dialog
            {
                try
                {
                    string photosDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CustomerPhotos");
                    if (!Directory.Exists(photosDirectory))
                    {
                        Directory.CreateDirectory(photosDirectory); // Create directory if it doesn't exist
                    }

                    // Delete the old photo file if a new one is being uploaded and it's a different file
                    // This assumes photoDbPath holds the *old* path before a new one is assigned from _selectedPhotoPath.
                    // The logic here is potentially flawed if photoDbPath isn't reset from the initial load.
                    // A more robust approach would be to load the *current* DB photo path at form load and use that for deletion.
                    // As the code is provided, photoDbPath might be the *new* selected path already.
                    // For now, assuming it correctly refers to the *original* photo path when checking for deletion.
                    if (!string.IsNullOrEmpty(photoDbPath) && photoDbPath.Contains("CustomerPhotos\\"))
                    {
                        string oldPhotoFullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, photoDbPath);
                        // Only delete if the existing path is valid and it's different from the newly selected path
                        if (File.Exists(oldPhotoFullPath) && !string.IsNullOrEmpty(_selectedPhotoPath) && !oldPhotoFullPath.Equals(_selectedPhotoPath, StringComparison.OrdinalIgnoreCase))
                        {
                            File.Delete(oldPhotoFullPath);
                        }
                    }

                    // Generate a unique file name and copy the selected photo to the application's photo directory
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(_selectedPhotoPath);
                    string destinationPath = Path.Combine(photosDirectory, fileName);
                    File.Copy(_selectedPhotoPath, destinationPath, true); // Copy the file, overwrite if exists
                    photoDbPath = "CustomerPhotos\\" + fileName; // Store the relative path for the database
                    photoChanged = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error uploading photo: " + ex.Message, "Photo Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    photoDbPath = null; // Clear path if upload fails
                    photoChanged = false; // Indicate upload failed
                }
            }
            // This 'else if' block handles the case where the user explicitly clears the photo in the UI
            // (e.g., sets picUploadedPhoto.Image to null), causing the stored photo path in DB to be cleared.
            else if (picUploadedPhoto.Image == null && !string.IsNullOrEmpty(photoDbPath))
            {
                try
                {
                    if (photoDbPath.Contains("CustomerPhotos\\"))
                    {
                        string oldPhotoFullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, photoDbPath);
                        if (File.Exists(oldPhotoFullPath))
                        {
                            File.Delete(oldPhotoFullPath); // Delete the old photo file
                        }
                    }
                    photoDbPath = null; // Set photo path to null in DB
                    photoChanged = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting old photo: " + ex.Message, "Photo Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Decide if you want to proceed without updating photo path
                }
            }


            // Connect to the database and execute the update query
            using (SqlConnection con = new SqlConnection(DbConnection.ConnectionString))
            {
                try
                {
                    con.Open(); // Open the database connection

                    // Base SQL UPDATE query for customer details
                    string query = @"UPDATE Customers SET
                                         Name = @Name,
                                         Email = @Email,
                                         ContactNumber = @ContactNumber,
                                         Address = @Address,
                                         PhotoPath = @PhotoPath";

                    // Conditionally add password update to the query if a new password was provided
                    if (hashedPasswordForUpdate != null)
                    {
                        query += ", Password = @Password";
                    }
                    query += " WHERE CustomerID = @CustomerID"; // Target the specific customer

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Add parameters for each field
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@ContactNumber", string.IsNullOrEmpty(contactNumber) ? (object)DBNull.Value : contactNumber);
                        cmd.Parameters.AddWithValue("@Address", string.IsNullOrEmpty(address) ? (object)DBNull.Value : address);
                        cmd.Parameters.AddWithValue("@PhotoPath", string.IsNullOrEmpty(photoDbPath) ? (object)DBNull.Value : photoDbPath);
                        cmd.Parameters.AddWithValue("@CustomerID", _loggedInCustomerId);

                        // Add password parameter if a new password was provided
                        if (hashedPasswordForUpdate != null)
                        {
                            cmd.Parameters.AddWithValue("@Password", hashedPasswordForUpdate);
                        }

                        int rowsAffected = cmd.ExecuteNonQuery(); // Execute the update command

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // If session data includes profile details, update them here
                            // SessionManager.LoggedInCustomerName = name; etc.
                            LoadCustomerProfile(_loggedInCustomerId); // Reload form to display updated data
                        }
                        else
                        {
                            MessageBox.Show("Failed to update profile or no changes were made.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    // Handle specific SQL Server errors, e.g., unique constraint violation for email
                    if (ex.Number == 2627 && ex.Message.Contains("Email"))
                    {
                        MessageBox.Show("This email is already registered to another user. Please use a different email.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Database error updating profile: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // Catch any other unexpected errors
                    MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Form Load event: Called when the form is first displayed
        private void frmMyProfile_Load(object sender, EventArgs e)
        {
            _loggedInCustomerId = SessionManager.LoggedInCustomerID; // Get the logged-in customer's ID

            if (_loggedInCustomerId > 0)
            {
                LoadCustomerProfile(_loggedInCustomerId); // Load profile data if a customer is logged in
            }
            else
            {
                // If no customer is logged in, show a message and redirect to login
                MessageBox.Show("No customer is logged in. Please log in to view your profile.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmLogin login = new frmLogin();
                login.Show();
                this.Close(); // Close the current profile form
            }

            // Make Customer ID and Username fields read-only as they shouldn't be directly editable
            txtCustomerId.ReadOnly = true;
            txtUsername.ReadOnly = true;
        }

        // Method to load customer profile data from the database into form fields
        private void LoadCustomerProfile(int customerId)
        {
            using (SqlConnection con = new SqlConnection(DbConnection.ConnectionString))
            {
                try
                {
                    con.Open(); // Open the database connection
                    string query = "SELECT CustomerID, Name, Email, ContactNumber, Address, PhotoPath, Username " +
                                   "FROM Customers WHERE CustomerID = @CustomerID"; // Select customer details

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", customerId); // Add CustomerID parameter

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // If a record is found
                            {
                                // Populate text boxes with data from the reader
                                txtCustomerId.Text = reader["CustomerID"].ToString();
                                txtName.Text = reader["Name"].ToString();
                                txtEmail.Text = reader["Email"].ToString();
                                txtContactNumber.Text = reader["ContactNumber"] == DBNull.Value ? string.Empty : reader["ContactNumber"].ToString();
                                txtAddress.Text = reader["Address"] == DBNull.Value ? string.Empty : reader["Address"].ToString();
                                txtUsername.Text = reader["Username"].ToString();

                                string photoPath = reader["PhotoPath"] == DBNull.Value ? null : reader["PhotoPath"].ToString();
                                if (!string.IsNullOrEmpty(photoPath))
                                {
                                    string fullPhotoPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, photoPath);
                                    if (File.Exists(fullPhotoPath))
                                    {
                                        try
                                        {
                                            // Load image into a MemoryStream to prevent file locking
                                            using (FileStream fs = new FileStream(fullPhotoPath, FileMode.Open, FileAccess.Read))
                                            {
                                                picUploadedPhoto.Image = Image.FromStream(fs);
                                            }
                                            picUploadedPhoto.SizeMode = PictureBoxSizeMode.Zoom;
                                            _selectedPhotoPath = photoPath; // Store relative path
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show($"Error loading photo '{fullPhotoPath}': {ex.Message}", "Photo Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            picUploadedPhoto.Image = null; // Clear image on error
                                            _selectedPhotoPath = null;
                                        }
                                    }
                                    else
                                    {
                                        picUploadedPhoto.Image = null; // Clear image if file not found
                                        _selectedPhotoPath = null;
                                        MessageBox.Show($"Photo file not found: {fullPhotoPath}", "Photo Load Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                                else
                                {
                                    picUploadedPhoto.Image = null; // Clear image if no path in DB
                                    _selectedPhotoPath = null;
                                }

                                // Clear password fields for security when loading (they are not read from DB)
                                txtPassword.Clear();
                                txtConfirmPassword.Clear();
                                chkShowPassword.Checked = false;
                                chkShowConfirmPassword.Checked = false;
                            }
                            else
                            {
                                MessageBox.Show("Customer profile not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading profile: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Empty event handler for btnViewCustomer (can be removed if unused)
        private void btnViewCustomer_Click(object sender, EventArgs e) { }

        // Empty event handler for btnViewProfile (can be removed if unused)
        private void btnViewProfile_Click(object sender, EventArgs e) { }

        // Empty event handler for txtPassword text changed (can be removed if unused)
        private void txtPassword_TextChanged(object sender, EventArgs e) { }

        // Handles the CheckedChanged event for "Show Password" checkbox
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle password visibility in txtPassword
            txtPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
        }

        // Empty event handler for lblConfirmPassword (can be removed if unused)
        private void lblConfirmPassword_Click(object sender, EventArgs e) { }

        // Empty event handler for lblPassword (can be removed if unused)
        private void lblPassword_Click(object sender, EventArgs e) { }

        // Empty event handler for txtConfirmPassword text changed (can be removed if unused)
        private void txtConfirmPassword_TextChanged(object sender, EventArgs e) { }

        // Handles the CheckedChanged event for "Show Confirm Password" checkbox
        private void chkShowConfirmPassword_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle password visibility in txtConfirmPassword
            txtConfirmPassword.PasswordChar = chkShowConfirmPassword.Checked ? '\0' : '*';
        }
    }
}