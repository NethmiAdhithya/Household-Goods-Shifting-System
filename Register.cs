using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; // For SQL database interaction
using System.Drawing;
using System.IO; // For file operations (image saving)
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net; // For password hashing

namespace E_Shift
{
    public partial class frmRegister : Form
    {
        // Stores the file path of the selected photo for upload
        private string _selectedPhotoPath = null;

        // Constructor for the Register form
        public frmRegister()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';         // Mask password input
            txtConfirmPassword.PasswordChar = '*';  // Mask confirm password input
        }

        // --- Menu Strip Click Handlers (Navigation) ---
        // Navigates to the Home form
        private void tsmHome_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            home.Show();
            this.Hide();
        }

        // Navigates to the About form
        private void tsmAbout_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.Show();
            this.Hide();
        }

        // This is the current form, so it's a no-op or refresh if clicked
        private void tsmRegister_Click(object sender, EventArgs e)
        {
            // Already on the register page, typically do nothing or clear form
        }

        // Navigates to the Login form
        private void tsmLogin_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        // Navigates to the Contact Us form
        private void tsmContactUs_Click(object sender, EventArgs e)
        {
            frmContact contact = new frmContact();
            contact.Show();
            this.Hide();
        }

        // --- UI Element Click/Change Handlers (mostly empty, can be removed if unused) ---
        private void lblRegister_Click(object sender, EventArgs e) { }
        private void lblName_Click(object sender, EventArgs e) { }
        private void txtName_TextChanged(object sender, EventArgs e) { }
        private void lblEmail_Click(object sender, EventArgs e) { }
        private void txtEmail_TextChanged(object sender, EventArgs e) { }
        private void lblContactNumber_Click(object sender, EventArgs e) { }
        private void txtContactNumber_TextChanged(object sender, EventArgs e) { }
        private void lblAddress_Click(object sender, EventArgs e) { }
        private void txtAddress_TextChanged(object sender, EventArgs e) { }
        private void lblPhoto_Click(object sender, EventArgs e) { }

        // Handles click event for the "Upload Photo" button
        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            // Opens a file dialog to select an image file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"; // Filter for image file types
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _selectedPhotoPath = openFileDialog.FileName; // Store selected file path
                picUploadedPhoto.Image = Image.FromFile(_selectedPhotoPath); // Display image in PictureBox
                picUploadedPhoto.SizeMode = PictureBoxSizeMode.Zoom; // Adjust image to fit
            }
        }

        private void picUploadedPhoto_Click(object sender, EventArgs e) { } // Empty handler
        private void lblUsername_Click(object sender, EventArgs e) { }    // Empty handler
        private void txtUsername_TextChanged(object sender, EventArgs e) { } // Empty handler
        private void lblPassword_Click(object sender, EventArgs e) { }     // Empty handler
        private void txtPassword_TextChanged(object sender, EventArgs e) { } // Empty handler

        // Toggles visibility of the password in the password text box
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
        }

        private void lblConfirmPassword_Click(object sender, EventArgs e) { } // Empty handler
        private void txtConfirmPassword_TextChanged(object sender, EventArgs e) { } // Empty handler

        // Toggles visibility of the password in the confirm password text box
        private void chkShowConfirmPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtConfirmPassword.PasswordChar = chkShowConfirmPassword.Checked ? '\0' : '*';
        }

        // --- Main Register Button Click Handler ---
        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Get all user input from text boxes
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string contactNumber = txtContactNumber.Text.Trim();
            string address = txtAddress.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            // Basic input validation: Check for empty required fields
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Please fill in all required fields (Name, Email, Username, Password, Confirm Password).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate if password and confirm password match
            if (password != confirmPassword)
            {
                MessageBox.Show("Password and Confirm Password do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Clear();        // Clear passwords for re-entry
                txtConfirmPassword.Clear();
                txtPassword.Focus();
                return;
            }

            // Hash the password using BCrypt for security
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            // Handle photo upload: Copy the selected photo to a local directory
            string photoDbPath = null; // Path to store in the database
            if (_selectedPhotoPath != null)
            {
                try
                {
                    // Define directory for storing customer photos
                    string photosDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CustomerPhotos");
                    if (!Directory.Exists(photosDirectory))
                    {
                        Directory.CreateDirectory(photosDirectory); // Create directory if it doesn't exist
                    }

                    // Generate a unique file name for the photo
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(_selectedPhotoPath);
                    string destinationPath = Path.Combine(photosDirectory, fileName);
                    File.Copy(_selectedPhotoPath, destinationPath, true); // Copy file to destination
                    photoDbPath = "CustomerPhotos\\" + fileName; // Store relative path
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error uploading photo: " + ex.Message, "Photo Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    photoDbPath = null; // If upload fails, set path to null
                }
            }

            // --- Database Insertion ---
            using (SqlConnection con = new SqlConnection(DbConnection.ConnectionString))
            {
                try
                {
                    con.Open(); // Open database connection
                    // SQL query to insert new customer data
                    string query = "INSERT INTO Customers (Name, Email, ContactNumber, Address, PhotoPath, Username, Password) " +
                                   "VALUES (@Name, @Email, @ContactNumber, @Address, @PhotoPath, @Username, @Password)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Add parameters to the SQL command to prevent SQL injection
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Email", email);
                        // Handle nullable fields for ContactNumber, Address, PhotoPath
                        cmd.Parameters.AddWithValue("@ContactNumber", string.IsNullOrEmpty(contactNumber) ? (object)DBNull.Value : contactNumber);
                        cmd.Parameters.AddWithValue("@Address", string.IsNullOrEmpty(address) ? (object)DBNull.Value : address);
                        cmd.Parameters.AddWithValue("@PhotoPath", string.IsNullOrEmpty(photoDbPath) ? (object)DBNull.Value : photoDbPath);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", hashedPassword);

                        cmd.ExecuteNonQuery(); // Execute the insert command
                        MessageBox.Show("Customer registered successfully! You will now be redirected to the login page.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ClearFormFields(); // Clear all input fields after successful registration

                        // Navigate to the Login form
                        frmLogin login = new frmLogin();
                        login.Show();
                        this.Hide();
                    }
                }
                catch (SqlException ex)
                {
                    // Handle specific SQL errors (e.g., unique constraint violations)
                    if (ex.Number == 2627) // Error code for unique constraint violation
                    {
                        if (ex.Message.Contains("Email"))
                        {
                            MessageBox.Show("This email is already registered. Please use a different email.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (ex.Message.Contains("Username"))
                        {
                            MessageBox.Show("This username is already taken. Please choose a different username.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("A duplicate entry was found. Please check your inputs.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        // Handle other general database errors
                        MessageBox.Show("Database error during registration: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // Catch any other unexpected errors
                    MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Resets all form input fields and photo display
        private void ClearFormFields()
        {
            txtName.Clear();
            txtEmail.Clear();
            txtContactNumber.Clear();
            txtAddress.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            picUploadedPhoto.Image = null; // Clear the displayed image
            _selectedPhotoPath = null;    // Reset the photo path
            chkShowPassword.Checked = false;      // Uncheck show password checkboxes
            chkShowConfirmPassword.Checked = false;
        }

        // Navigates to the Login form (used for "Already have an account? Login now")
        private void lblLoginNow_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void frmRegister_Load(object sender, EventArgs e) { } // Form Load event (empty)
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) { } // Empty handler

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}