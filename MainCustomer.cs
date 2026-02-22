using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Shift
{
    public partial class frmMainCustomer : Form
    {
        // Constructor that takes a customerId (might be used for initial setup if needed)
        public frmMainCustomer(int customerId)
        {
            InitializeComponent();
            // _customerId = customerId; // Store it if necessary for this form's direct use
        }

        // Default constructor, typically used after a successful login when customer ID is in session
        public frmMainCustomer()
        {
            InitializeComponent();
            // You can optionally check SessionManager.LoggedInCustomerID here if needed
            // int loggedInId = SessionManager.LoggedInCustomerID;
        }

        // --- Menu Strip Click Handlers (Navigation) ---

        // Navigates to the Home form
        private void tsmHome_Click(object sender, EventArgs e)
        {
            frmHome Home = new frmHome();
            Home.Show();
            this.Hide(); // Hide the current form
        }

        // This is the current form, so clicking this menu item typically does nothing or refreshes
        private void tsmMain_Click(object sender, EventArgs e)
        {
            // Already on the main customer form
        }

        // Navigates to the My Profile form
        private void tsmMyProfile_Click(object sender, EventArgs e)
        {
            frmMyProfile MyProfile = new frmMyProfile();
            MyProfile.Show();
            this.Hide(); // Hide the current form
        }

        // Handles the click event for "Request New Transport"
        private void tsmRequestNewTransport_Click(object sender, EventArgs e) // Or your button click event
        {
            // Check if a customer is logged in before proceeding
            if (SessionManager.IsCustomerLoggedIn())
            {
                // Create and show the RequestNewTransport form
                // The new form will retrieve the customer ID from SessionManager itself
                frmRequestNewTransport requestForm = new frmRequestNewTransport();
                requestForm.Show();
                this.Hide(); // Hide the current main customer form
            }
            else
            {
                // If not logged in, inform the user and redirect to the login page
                MessageBox.Show("Your session has expired or you are not logged in. Please log in again.", "Session Expired", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                new frmLogin().Show(); // Show the login form
                this.Close(); // Close the current form
            }
        }

        // Navigates to the View Invoice form (note: original code had this linked to ViewMyJobs)
        private void tsmViewMyJobs_Click(object sender, EventArgs e)
        {
            // Based on the code, this leads to frmViewInvoice, not a dedicated ViewMyJobs form.
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

        // Empty event handler for the lbleShift label (can be removed if unused)
        private void lbleShift_Click(object sender, EventArgs e)
        {
            // No specific action defined for this label click
        }

        // Form Load event handler (currently empty)
        private void frmMainCustomer_Load(object sender, EventArgs e)
        {
            // Logic to execute when the form loads can be added here
        }
    }
}