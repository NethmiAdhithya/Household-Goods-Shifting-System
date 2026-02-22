using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // Needed for SQL operations

namespace E_Shift
{
    public partial class frmViewInvoice : Form
    {
        private DataTable customerInvoices; // DataTable to store all invoices for the logged-in customer

        // Constructor for the form
        public frmViewInvoice()
        {
            InitializeComponent();

            // Make all invoice detail text boxes read-only to prevent user editing
            txtInvoiceId.ReadOnly = true;
            txtJobId.ReadOnly = true;
            txtAmount.ReadOnly = true;
            txtInvoiceStatus.ReadOnly = true;
            txtDateIssued.ReadOnly = true;
            txtDateDue.ReadOnly = true;
        }

        // Method to load all invoice data for the currently logged-in customer
        private void LoadCustomerInvoiceData()
        {
            int customerID = SessionManager.LoggedInCustomerID; // Get the ID of the logged-in customer

            if (customerID <= 0) // Check if a valid customer ID exists (i.e., customer is logged in)
            {
                MessageBox.Show("No customer is logged in. Please log in to view invoices.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Optionally, redirect to login or home page if no customer is logged in
                // frmHome home = new frmHome();
                // home.Show();
                // this.Hide();
                return; // Exit the method
            }

            using (SqlConnection connection = new SqlConnection(DbConnection.ConnectionString)) // Create a new SQL connection
            {
                try
                {
                    connection.Open(); // Open the database connection

                    // SQL query to retrieve invoice details for the specific customer, ordered by issue date descending
                    SqlCommand command = new SqlCommand(@"
                        SELECT
                            I.InvoiceID,
                            I.JobID,
                            I.Amount,
                            I.Status AS InvoiceStatus, -- Alias 'Status' column from Invoices table as 'InvoiceStatus'
                            I.DateIssued,
                            I.DateDue,
                            J.Description AS JobDescription -- Optional: Fetch job description for context
                        FROM
                            Invoices AS I
                        JOIN
                            Jobs AS J ON I.JobID = J.JobID
                        WHERE
                            J.CustomerID = @CustomerID -- Filter by the logged-in customer's ID
                        ORDER BY
                            I.DateIssued DESC; -- Order by the most recently issued invoice first
                    ", connection);

                    command.Parameters.AddWithValue("@CustomerID", customerID); // Add the CustomerID parameter to the SQL command

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command); // Create a data adapter
                    customerInvoices = new DataTable(); // Initialize the DataTable to store the query results
                    dataAdapter.Fill(customerInvoices); // Fill the DataTable with data

                    // Populate the ComboBox with invoice selection options
                    PopulateInvoiceComboBox();

                    // If invoices are found, display the details of the first (latest) invoice
                    if (customerInvoices.Rows.Count > 0)
                    {
                        cmbInvoiceSelection.SelectedIndex = 0; // Select the first item in the ComboBox
                    }
                    else
                    {
                        ClearInvoiceDetails(); // Clear detail text boxes if no invoices are found
                        MessageBox.Show("No invoices found for your account.", "No Invoices", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (SqlException sqlEx) // Catch specific SQL database errors
                {
                    MessageBox.Show("Database error loading invoices: " + sqlEx.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex) // Catch any other general exceptions
                {
                    MessageBox.Show("Error loading invoices: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Method to populate the ComboBox with invoice identifiers
        private void PopulateInvoiceComboBox()
        {
            cmbInvoiceSelection.DataSource = null; // Clear any existing data source binding
            cmbInvoiceSelection.Items.Clear(); // Clear all items from the ComboBox

            if (customerInvoices != null && customerInvoices.Rows.Count > 0)
            {
                // Project the DataTable rows into a list of anonymous objects for ComboBox binding
                var invoiceList = customerInvoices.AsEnumerable()
                                                .Select(row => new
                                                {
                                                    DisplayText = $"Invoice ID: {row["InvoiceID"]} (Job: {row["JobID"]})", // Text displayed to the user
                                                    Value = row["InvoiceID"] // Actual value (InvoiceID) associated with the item
                                                })
                                                .ToList(); // Convert to a list

                cmbInvoiceSelection.DataSource = invoiceList; // Bind the list to the ComboBox
                cmbInvoiceSelection.DisplayMember = "DisplayText"; // Set the property to display
                cmbInvoiceSelection.ValueMember = "Value";         // Set the property for the item's actual value
            }
        }

        // Method to clear the text boxes displaying invoice details
        private void ClearInvoiceDetails()
        {
            txtInvoiceId.Text = string.Empty;
            txtJobId.Text = string.Empty;
            txtAmount.Text = string.Empty;
            txtInvoiceStatus.Text = string.Empty;
            txtDateIssued.Text = string.Empty;
            txtDateDue.Text = string.Empty;
        }

        // Method to display details of a selected invoice in the text boxes
        private void DisplayInvoiceDetails(int invoiceID)
        {
            // Find the row corresponding to the selected InvoiceID in the customerInvoices DataTable
            DataRow[] selectedRows = customerInvoices.Select($"InvoiceID = {invoiceID}");

            if (selectedRows.Length > 0) // If a matching row is found
            {
                DataRow row = selectedRows[0]; // Get the first matching row
                txtInvoiceId.Text = row["InvoiceID"]?.ToString(); // Populate Invoice ID
                txtJobId.Text = row["JobID"]?.ToString();         // Populate Job ID
                // Format Amount as currency (e.g., "$123.45")
                txtAmount.Text = Convert.ToDecimal(row["Amount"]).ToString("C2");
                txtInvoiceStatus.Text = row["InvoiceStatus"]?.ToString(); // Populate Invoice Status
                // Format dates to a short date string (e.g., "M/d/yyyy")
                txtDateIssued.Text = Convert.ToDateTime(row["DateIssued"]).ToShortDateString();
                txtDateDue.Text = Convert.ToDateTime(row["DateDue"]).ToShortDateString();
            }
            else
            {
                ClearInvoiceDetails(); // Clear details if no matching invoice is found
            }
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
            frmMyProfile myProfile = new frmMyProfile();
            myProfile.Show();
            this.Hide(); // Hide the current form
        }

        // Navigates to the Request New Transport form
        private void tsmRequestNewTransport_Click(object sender, EventArgs e)
        {
            frmRequestNewTransport requestNewTransport = new frmRequestNewTransport();
            requestNewTransport.Show();
            this.Hide(); // Hide the current form
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

        // This is the current form, so clicking this menu item does nothing
        private void tsmViewInvoice_Click(object sender, EventArgs e)
        {
            // No action needed as already on this form.
        }

        // Navigates to the Customer Dashboard form
        private void tsmCustomerDashboard_Click(object sender, EventArgs e)
        {
            frmCustomerDashboard customerDashboard = new frmCustomerDashboard();
            customerDashboard.Show();
            this.Hide(); // Hide the current form
        }

        // --- Empty Event Handlers for UI Elements ---
        private void lblJobId_Click(object sender, EventArgs e) { }
        private void txtJobId_TextChanged(object sender, EventArgs e) { }
        private void lblInvoiceId_Click(object sender, EventArgs e) { }
        private void txtInvoiceId_TextChanged(object sender, EventArgs e) { }
        private void lblAmount_Click(object sender, EventArgs e) { }

        // --- Form Load Event ---
        // Executed when the form is loaded and displayed
        private void frmViewInvoice_Load(object sender, EventArgs e)
        {
            LoadCustomerInvoiceData(); // Call the method to load and display invoice data
        }

        private void txtAmount_TextChanged(object sender, EventArgs e) { }
        private void lblStatus_Click(object sender, EventArgs e) { }
        private void txtInvoiceStatus_TextChanged(object sender, EventArgs e) { }
        private void lblDateIssued_Click(object sender, EventArgs e) { }
        private void txtDateIssued_TextChanged(object sender, EventArgs e) { }
        private void lblDateDue_Click(object sender, EventArgs e) { }
        private void txtDateDue_TextChanged(object sender, EventArgs e) { }

        // Event handler for ComboBox selection change
        // This method is called whenever the user selects a different invoice from the ComboBox
        private void cmbInvoiceSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ensure there's a selected item and its 'Value' property (InvoiceID) is not null
            if (cmbInvoiceSelection.SelectedItem != null)
            {
                // Retrieve the selected item. Use 'dynamic' because the DataSource is a list of anonymous types.
                dynamic selectedItem = cmbInvoiceSelection.SelectedItem;

                // Check if the 'Value' property of the selected anonymous object is not null
                if (selectedItem.Value != null)
                {
                    // Convert the 'Value' (which is the InvoiceID) to an integer
                    int selectedInvoiceID = Convert.ToInt32(selectedItem.Value);
                    // Call the method to display the details of the selected invoice
                    DisplayInvoiceDetails(selectedInvoiceID);
                }
                else
                {
                    // If the selected item's value is null, clear the displayed invoice details
                    ClearInvoiceDetails();
                }
            }
            else
            {
                // If nothing is selected in the ComboBox (e.g., if it was cleared), clear the details
                ClearInvoiceDetails();
            }
        }
    }
}