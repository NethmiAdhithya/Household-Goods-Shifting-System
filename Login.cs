using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; // For SQL database interaction
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net; // For password hashing and verification

namespace E_Shift
{
    public partial class frmLogin : Form
    {
        // Constructor for the Login form
        public frmLogin()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*'; // Mask password characters
        }

        // --- Menu Strip Click Handlers ---
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

        // Navigates to the Register form
        private void tsmRegister_Click(object sender, EventArgs e)
        {
            frmRegister register = new frmRegister();
            register.Show();
            this.Hide();
        }

        // Navigates to the Login form (current form, effectively a refresh or no-op)
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
        private void lblLogin_Click(object sender, EventArgs e) { }
        private void lblLoginAs_Click(object sender, EventArgs e) { }
        private void cmbLoginAs_SelectedIndexChanged(object sender, EventArgs e) { }
        private void lblUserName_Click(object sender, EventArgs e) { }
        private void txtUserName_TextChanged(object sender, EventArgs e) { }
        private void lblPassword_Click(object sender, EventArgs e) { }
        private void txtPassword_TextChanged(object sender, EventArgs e) { }

        // Toggles password visibility in the text box
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
        }

        // --- Main Login Button Click Handler ---
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Get selected login type, username, and password
            string loginAs = cmbLoginAs.SelectedItem?.ToString();
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text;

            // Validate input fields are not empty
            if (string.IsNullOrWhiteSpace(loginAs) || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please select a login type, enter username, and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Establish database connection
            using (SqlConnection con = new SqlConnection(DbConnection.ConnectionString))
            {
                try
                {
                    con.Open(); // Open the database connection
                    string tableName;
                    string idColumn;
                    string query;

                    // Determine table and query based on login type (Customer or Admin)
                    if (loginAs == "Customer")
                    {
                        tableName = "Customers";
                        idColumn = "CustomerID";
                        // Select customer details including hashed password
                        query = $"SELECT {idColumn}, Username, Password, Name FROM {tableName} WHERE Username = @Username";
                    }
                    else // loginAs == "Admin"
                    {
                        tableName = "Admins";
                        idColumn = "AdminID";
                        // Select admin details including hashed password
                        query = $"SELECT {idColumn}, Username, Password, Name FROM {tableName} WHERE Username = @Username";
                    }

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Username", username); // Add username parameter

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // If a user with the username is found
                            {
                                string storedHashedPassword = reader["Password"].ToString();

                                // Handle cases where password might be empty or corrupted in DB
                                if (string.IsNullOrWhiteSpace(storedHashedPassword))
                                {
                                    MessageBox.Show("Invalid username or password (password not set or corrupted).", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtPassword.Clear();
                                    txtPassword.Focus();
                                    return;
                                }

                                // Verify the entered password against the stored hashed password using BCrypt
                                if (BCrypt.Net.BCrypt.Verify(password, storedHashedPassword))
                                {
                                    MessageBox.Show($"Login successful as {loginAs}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    if (loginAs == "Customer")
                                    {
                                        // Set customer session details upon successful login
                                        int customerId = Convert.ToInt32(reader[idColumn]);
                                        string customerUsername = reader["Username"].ToString();
                                        string customerName = reader["Name"].ToString();

                                        SessionManager.SetCustomerSession(customerId, customerUsername, customerName);

                                        // Navigate to the main customer form/dashboard
                                        frmMainCustomer mainCustomerForm = new frmMainCustomer();
                                        mainCustomerForm.Show();
                                    }
                                    else // Admin
                                    {
                                        // Navigate to the main admin form/dashboard
                                        // (Assuming you have an AdminSessionManager or pass admin details directly)
                                        frmMainAdmin mainAdminForm = new frmMainAdmin();
                                        mainAdminForm.Show();
                                    }
                                    this.Hide(); // Hide the current login form
                                }
                                else
                                {
                                    // Password verification failed
                                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtPassword.Clear();
                                    txtPassword.Focus();
                                }
                            }
                            else
                            {
                                // No user found with the given username
                                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtPassword.Clear();
                                txtPassword.Focus();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Catch and display any database or other errors during login
                    MessageBox.Show("An error occurred during login: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // --- Other UI Element Click/Load Handlers ---
        private void lblForgot_Click(object sender, EventArgs e) { }
        private void lblClick_Click(object sender, EventArgs e) { }

        // Form Load event: Initializes ComboBox items if empty and sets default selection
        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (cmbLoginAs.Items.Count == 0) // Prevent adding items multiple times
            {
                cmbLoginAs.Items.Add("Customer");
                cmbLoginAs.Items.Add("Admin");
            }
            cmbLoginAs.SelectedIndex = 0; // Select "Customer" as default
        }
    }
}