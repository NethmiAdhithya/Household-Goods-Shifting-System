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
    public partial class frmContact : Form
    {
        // Constructor for the Contact Us form
        public frmContact()
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

        // Navigates to the Login form
        private void tsmLogin_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        // This is the current form, effectively a refresh or no-op
        private void tsmContactUs_Click(object sender, EventArgs e)
        {
            frmContact contact = new frmContact();
            contact.Show();
            this.Hide();
        }

        // --- UI Element Click/Change Handlers (mostly empty, can be removed if unused) ---
        private void lblGet_Click(object sender, EventArgs e) { }
        private void lblContact_Click(object sender, EventArgs e) { }
        private void lblFullName_Click(object sender, EventArgs e) { }
        private void txtFullName_TextChanged(object sender, EventArgs e) { }
        private void lblEmailAddress_Click(object sender, EventArgs e) { }
        private void txtEmailAddress_TextChanged(object sender, EventArgs e) { }
        private void lblPhoneNumber_Click(object sender, EventArgs e) { }
        private void txtPhoneNumber_TextChanged(object sender, EventArgs e) { }
        private void lblSubject_Click(object sender, EventArgs e) { }
        private void txtSubject_TextChanged(object sender, EventArgs e) { }
        private void lblMessage_Click(object sender, EventArgs e) { }
        private void txtMessage_TextChanged(object sender, EventArgs e) { }

        // Handles click event for the "Send Message" button
        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            // 1. Retrieve user input from form fields
            string fullName = txtFullName.Text.Trim();
            string emailAddress = txtEmailAddress.Text.Trim();
            string phoneNumber = txtPhoneNumber.Text.Trim();
            string subject = txtSubject.Text.Trim();
            string messageText = txtMessage.Text.Trim();

            // 2. Perform basic input validation
            // Check if essential fields are empty
            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(emailAddress) || string.IsNullOrEmpty(messageText))
            {
                MessageBox.Show("Please fill in your Full Name, Email Address, and Message.", "Form Submission Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Stop execution if validation fails
            }

            // Simple email format validation
            if (!emailAddress.Contains("@") || !emailAddress.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address.", "Form Submission Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Stop execution if validation fails
            }

            // 3. Database Insertion Logic: Connect to DB and insert message
            using (SqlConnection con = new SqlConnection(DbConnection.ConnectionString))
            {
                try
                {
                    con.Open(); // Open the database connection

                    // SQL INSERT query with parameterized values to prevent SQL Injection
                    string query = "INSERT INTO ContactMessages (FullName, EmailAddress, PhoneNumber, Subject, MessageText) " +
                                   "VALUES (@FullName, @EmailAddress, @PhoneNumber, @Subject, @MessageText)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Add parameters for each input field
                        cmd.Parameters.AddWithValue("@FullName", fullName);
                        cmd.Parameters.AddWithValue("@EmailAddress", emailAddress);

                        // For optional fields (PhoneNumber, Subject), use DBNull.Value if empty
                        cmd.Parameters.AddWithValue("@PhoneNumber", string.IsNullOrEmpty(phoneNumber) ? (object)DBNull.Value : phoneNumber);
                        cmd.Parameters.AddWithValue("@Subject", string.IsNullOrEmpty(subject) ? (object)DBNull.Value : subject);
                        cmd.Parameters.AddWithValue("@MessageText", messageText);

                        cmd.ExecuteNonQuery(); // Execute the SQL command to insert data

                        // Display success message to the user
                        MessageBox.Show("Your message has been sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // 4. Clear the input fields after successful submission
                        ClearFormFields();
                    }
                }
                catch (SqlException ex)
                {
                    // Catch and display specific SQL database errors
                    MessageBox.Show($"A database error occurred: {ex.Message}\nError Number: {ex.Number}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    // Catch any other unexpected errors during the process
                    MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Submission Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Helper method to clear all text boxes and reset the form
        private void ClearFormFields()
        {
            txtFullName.Clear();
            txtEmailAddress.Clear();
            txtPhoneNumber.Clear();
            txtSubject.Clear();
            txtMessage.Clear();
        }

        // --- Empty Event Handlers (can be removed if no custom logic is added) ---
        private void pnlContact_Paint(object sender, PaintEventArgs e) { }
        private void frmContact_Load(object sender, EventArgs e) { }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) { }
    }
}