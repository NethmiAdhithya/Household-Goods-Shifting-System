using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // Required for SQL database operations.
using System.Data.Common; // Provides generic classes for data access.

namespace E_Shift
{
    public partial class frmInvoice : Form
    {
        private int _jobIdForInvoice; // Stores the Job ID passed to the form, if any.
        private bool _isAddingNewInvoice = false; // Flag to indicate if a new invoice is being added.

        // Constructor for the frmInvoice form, accepts an optional jobId.
        public frmInvoice(int jobId = -1)
        {
            InitializeComponent(); // Initializes the form's visual components.
            _jobIdForInvoice = jobId; // Assigns the passed Job ID to the private field.

            // Populates the Invoice Status combo box with predefined statuses.
            cmbInvoiceStatus.Items.Add("Pending");
            cmbInvoiceStatus.Items.Add("Paid");
            cmbInvoiceStatus.Items.Add("Overdue");
            cmbInvoiceStatus.Items.Add("Cancelled");
            cmbInvoiceStatus.SelectedIndex = 0; // Sets "Pending" as the default selected status.

            // Checks if a Job ID was provided in the constructor.
            if (_jobIdForInvoice != -1)
            {
                txtJobId.Text = _jobIdForInvoice.ToString(); // Pre-fills Job ID text box.
                txtJobId.ReadOnly = false; // Make Job ID editable (original code had true, changed to false based on context of pre-filling).
            }
            else
            {
                txtJobId.ReadOnly = false; // Allows manual entry of Job ID.
                txtJobId.Clear(); // Clears Job ID text box if no ID was passed.
            }

            // Sets initial read-only status for Amount and Invoice ID fields.
            txtInvoiceId.ReadOnly = false; // Setting to false based on original code, often auto-generated.
            txtAmount.ReadOnly = false;
        }

        // Handles click event for the Home navigation button.
        private void Home_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome(); // Creates a new instance of the Home form.
            home.Show(); // Displays the Home form.
            this.Hide(); // Hides the current Invoice form.
        }

        // Handles click event for the Main Admin navigation menu item.
        private void tsmMain_Click(object sender, EventArgs e)
        {
            frmMainAdmin mainAdmin = new frmMainAdmin(); // Creates a new instance of the Main Admin form.
            mainAdmin.Show(); // Displays the Main Admin form.
            this.Hide(); // Hides the current Invoice form.
        }

        // Handles click event for the Customer navigation menu item.
        private void tsmCustomer_Click(object sender, EventArgs e)
        {
            frmCustomer customer = new frmCustomer(); // Creates a new instance of the Customer form.
            customer.Show(); // Displays the Customer form.
            this.Hide(); // Hides the current Invoice form.
        }

        // Handles click event for the Job navigation menu item.
        private void tsmJob_Click(object sender, EventArgs e)
        {
            frmJob job = new frmJob(); // Creates a new instance of the Job form.
            job.Show(); // Displays the Job form.
            // Note: 'this.Hide()' is missing here compared to other navigation methods.
        }

        // Handles click event for the Load navigation menu item.
        private void tsmLoad_Click(object sender, EventArgs e)
        {
            frmLoad load = new frmLoad(); // Creates a new instance of the Load form.
            load.Show(); // Displays the Load form.
            this.Hide(); // Hides the current Invoice form.
        }

        // Handles click event for the Transport Unit navigation menu item.
        private void tsmTransportUnit_Click(object sender, EventArgs e)
        {
            frmTransportUnit transportUnit = new frmTransportUnit(); // Creates a new instance of the Transport Unit form.
            transportUnit.Show(); // Displays the Transport Unit form.
            this.Hide(); // Hides the current Invoice form.
        }

        // Handles click event for the Invoice navigation menu item (currently no specific action).
        private void tsmInvoice_Click(object sender, EventArgs e)
        {
            // This event handler is for the current form, so no navigation needed.
        }

        // Handles click event for the Dashboard navigation menu item.
        private void tsmDashboard_Click(object sender, EventArgs e)
        {
            frmAdminDashboard adminDashboard = new frmAdminDashboard(); // Creates a new instance of the Admin Dashboard form.
            adminDashboard.Show(); // Displays the Admin Dashboard form.
            this.Hide(); // Hides the current Invoice form.
        }

        // Handles click event for the Admin Management navigation menu item.
        private void tsmAdminManagement_Click(object sender, EventArgs e)
        {
            frmAdminManagement adminManagement = new frmAdminManagement(); // Creates a new instance of the Admin Management form.
            adminManagement.Show(); // Displays the Admin Management form.
            this.Hide(); // Hides the current Invoice form.
        }

        // Handles click event for the Reports navigation menu item (currently no specific action for the parent menu).
        private void tsmReports_Click(object sender, EventArgs e)
        {
            // No direct action for a parent menu item.
        }

        // Handles click event for the "Customer and Their Jobs" report menu item.
        private void tsmCustomerTheirJobs_Click(object sender, EventArgs e)
        {
            frmCustomerAndTheirJobsReport customerAndTheirJobsReport = new frmCustomerAndTheirJobsReport(); // Creates a new instance of the report form.
            customerAndTheirJobsReport.Show(); // Displays the report form.
            this.Hide(); // Hides the current Invoice form.
        }

        // Handles click event for the "Jobs By Date Range" report menu item.
        private void tsmJobsByDateRange_Click(object sender, EventArgs e)
        {
            frmJobsByDateRangeReport jobsByDateRangeReport = new frmJobsByDateRangeReport(); // Creates a new instance of the report form.
            jobsByDateRangeReport.Show(); // Displays the report form.
            this.Hide(); // Hides the current Invoice form.
        }

        // Handles click event for the "Loads By Transport Unit" report menu item.
        private void tsmLoadsByTransportUnit_Click(object sender, EventArgs e)
        {
            frmLoadsByTransportUnitReport loadsByTransportUnitReport = new frmLoadsByTransportUnitReport(); // Creates a new instance of the report form.
            loadsByTransportUnitReport.Show(); // Displays the report form.
            this.Hide(); // Hides the current Invoice form.
        }

        // Handles click event for the "Delivery Performance" report menu item.
        private void tsmDeliveryPerformance_Click(object sender, EventArgs e)
        {
            frmDeliveryPerformanceReport deliveryPerformanceReport = new frmDeliveryPerformanceReport(); // Creates a new instance of the report form.
            deliveryPerformanceReport.Show(); // Displays the report form.
            this.Hide(); // Hides the current Invoice form.
        }

        // Handles click event for the "Daily End Of The Loads" report menu item.
        private void tsmDailyEndOfTheLoads_Click(object sender, EventArgs e)
        {
            frmDailyEndOfTheLoadsReport dailyEndOfTheLoadsReport = new frmDailyEndOfTheLoadsReport(); // Creates a new instance of the report form.
            dailyEndOfTheLoadsReport.Show(); // Displays the report form.
            this.Hide(); // Hides the current Invoice form.
        }

        // Event handler for when the Invoice form loads.
        private void frmInvoice_Load(object sender, EventArgs e)
        {
            LoadInvoicesIntoGrid(); // Loads all invoices into the DataGridView.

            // If a Job ID was passed to the constructor, attempts to search for its invoice.
            if (_jobIdForInvoice != -1)
            {
                SearchInvoiceByJobId(_jobIdForInvoice); // Calls search function with the provided Job ID.
            }
            else
            {
                ClearFormFields(); // Clears input fields for a fresh start.
            }
        }

        // Clears all input fields on the form and resets default values.
        private void ClearFormFields()
        {
            txtJobId.Clear(); // Clears Job ID text box.
            txtInvoiceId.Clear(); // Clears Invoice ID text box.
            txtAmount.Clear(); // Clears Amount text box.
            cmbInvoiceStatus.SelectedIndex = 0; // Sets Invoice Status to the first item (e.g., "Pending").
            dtpDateIssued.Value = DateTime.Now; // Sets Date Issued to the current date and time.
            dtpDateDue.Value = DateTime.Now; // Sets Date Due to the current date and time.

            // Resets read-only status for Job ID if it wasn't pre-filled by the constructor.
            if (_jobIdForInvoice == -1)
            {
                txtJobId.ReadOnly = false;
            }
            txtInvoiceId.ReadOnly = true; // Invoice ID is typically auto-generated, making it read-only.
            _isAddingNewInvoice = false; // Resets the flag indicating adding a new invoice.
        }

        // Validates user input in the form fields.
        private bool ValidateInput()
        {
            // Checks if Job ID is empty.
            if (string.IsNullOrWhiteSpace(txtJobId.Text))
            {
                MessageBox.Show("Job ID cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtJobId.Focus();
                return false;
            }
            // Checks if Job ID is a valid number.
            if (!int.TryParse(txtJobId.Text.Trim(), out int jobId))
            {
                MessageBox.Show("Please enter a valid numeric Job ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtJobId.Focus();
                return false;
            }

            // Checks if Amount is empty.
            if (string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                MessageBox.Show("Amount cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAmount.Focus();
                return false;
            }
            // Checks if Amount is a valid decimal number.
            if (!decimal.TryParse(txtAmount.Text.Trim(), out decimal amount))
            {
                MessageBox.Show("Please enter a valid numeric amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAmount.Focus();
                return false;
            }
            // Checks if Amount is negative.
            if (amount < 0)
            {
                MessageBox.Show("Amount cannot be negative.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAmount.Focus();
                return false;
            }

            // Checks if an Invoice Status is selected.
            if (cmbInvoiceStatus.SelectedItem == null)
            {
                MessageBox.Show("Please select an Invoice Status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbInvoiceStatus.Focus();
                return false;
            }

            // Checks if Date Issued is in the future.
            if (dtpDateIssued.Value > DateTime.Now)
            {
                MessageBox.Show("Date Issued cannot be in the future.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDateIssued.Focus();
                return false;
            }

            // Checks if Date Due is earlier than Date Issued.
            if (dtpDateDue.Value < dtpDateIssued.Value)
            {
                MessageBox.Show("Date Due cannot be earlier than Date Issued.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDateDue.Focus();
                return false;
            }

            return true; // Returns true if all validations pass.
        }

        // Searches for an invoice by Job ID and populates the form fields if found.
        private void SearchInvoiceByJobId(int jobId)
        {
            ClearFormFields(); // Clears form fields before displaying search results.

            using (SqlConnection connection = new SqlConnection(DbConnection.ConnectionString))
            {
                try
                {
                    connection.Open(); // Opens the database connection.
                    string query = "SELECT InvoiceID, JobID, Amount, Status, DateIssued, DateDue FROM Invoices WHERE JobID = @JobID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@JobID", jobId); // Adds Job ID parameter to the query.

                    SqlDataReader reader = command.ExecuteReader(); // Executes the query and gets a data reader.

                    if (reader.Read()) // If a record is found.
                    {
                        txtInvoiceId.Text = reader["InvoiceID"].ToString(); // Populates Invoice ID.
                        txtJobId.Text = reader["JobID"].ToString(); // Populates Job ID.
                        txtAmount.Text = reader["Amount"].ToString(); // Populates Amount.
                        cmbInvoiceStatus.Text = reader["Status"].ToString(); // Populates Status.
                        dtpDateIssued.Value = Convert.ToDateTime(reader["DateIssued"]); // Populates Date Issued.
                        dtpDateDue.Value = Convert.ToDateTime(reader["DateDue"]); // Populates Date Due.

                        MessageBox.Show("Invoice details loaded successfully!", "Search Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else // If no record is found.
                    {
                        MessageBox.Show("No invoice found for the provided Job ID. You can add a new invoice.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtJobId.Text = jobId.ToString(); // Keeps the searched Job ID in the text box.
                        _isAddingNewInvoice = true; // Sets flag to indicate readiness for adding a new invoice.
                        txtInvoiceId.Clear(); // Clears Invoice ID for a new entry.
                    }
                    reader.Close(); // Closes the data reader.
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
                    LoadInvoicesIntoGrid(); // Refreshes the DataGridView after search.
                }
            }
        }

        // Loads invoices into the DataGridView, with an optional filter by Job ID.
        private void LoadInvoicesIntoGrid(int? filterJobId = null)
        {
            using (SqlConnection connection = new SqlConnection(DbConnection.ConnectionString))
            {
                try
                {
                    connection.Open(); // Opens the database connection.
                    string query = "SELECT InvoiceID, JobID, Amount, Status, DateIssued, DateDue FROM Invoices";
                    // Appends WHERE clause if a filter Job ID is provided.
                    if (filterJobId.HasValue && filterJobId.Value != -1)
                    {
                        query += " WHERE JobID = @JobID";
                    }
                    query += " ORDER BY DateIssued DESC"; // Orders results by Date Issued in descending order.

                    SqlCommand command = new SqlCommand(query, connection);
                    // Adds parameter if filtering by Job ID.
                    if (filterJobId.HasValue && filterJobId.Value != -1)
                    {
                        command.Parameters.AddWithValue("@JobID", filterJobId.Value);
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command); // Creates a data adapter.
                    DataTable dt = new DataTable(); // Creates a new DataTable.
                    adapter.Fill(dt); // Fills the DataTable with invoice data.
                    dgvInvoice.DataSource = dt; // Sets the DataGridView's data source.

                    dgvInvoice.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells); // Auto-sizes columns.
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("Database error loading invoices: " + sqlEx.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading invoices: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Handles cell content click event in the DataGridView to populate form fields.
        private void dgvInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensures a valid row is clicked (not header row).
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvInvoice.Rows[e.RowIndex]; // Gets the clicked row.

                // Populates text boxes and combo box from the selected row's cell values.
                txtInvoiceId.Text = row.Cells["InvoiceID"].Value?.ToString();
                txtJobId.Text = row.Cells["JobID"].Value?.ToString();
                txtAmount.Text = row.Cells["Amount"].Value?.ToString();
                cmbInvoiceStatus.Text = row.Cells["Status"].Value?.ToString();

                // Handles Date Issued and Date Due, converting DBNull values to DateTime.Now.
                if (row.Cells["DateIssued"].Value != DBNull.Value && row.Cells["DateIssued"].Value != null)
                {
                    dtpDateIssued.Value = Convert.ToDateTime(row.Cells["DateIssued"].Value);
                }
                else
                {
                    dtpDateIssued.Value = DateTime.Now;
                }
                if (row.Cells["DateDue"].Value != DBNull.Value && row.Cells["DateDue"].Value != null)
                {
                    dtpDateDue.Value = Convert.ToDateTime(row.Cells["DateDue"].Value);
                }
                else
                {
                    dtpDateDue.Value = DateTime.Now;
                }

                // Makes Job ID editable if it wasn't pre-filled by the constructor.
                if (_jobIdForInvoice == -1)
                {
                    txtJobId.ReadOnly = false;
                }
                // Sets flag to indicate that we are now updating an existing invoice.
                _isAddingNewInvoice = false;
            }
        }

        // Handles click event for the Search Invoice button.
        private void btnSearchInvoice_Click(object sender, EventArgs e)
        {
            // Validates if Job ID is entered for search.
            if (string.IsNullOrWhiteSpace(txtJobId.Text))
            {
                MessageBox.Show("Please enter a Job ID to search for.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtJobId.Focus();
                return;
            }
            // Validates if Job ID is a valid number.
            if (!int.TryParse(txtJobId.Text.Trim(), out int jobId))
            {
                MessageBox.Show("Please enter a valid numeric Job ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtJobId.Focus();
                return;
            }

            SearchInvoiceByJobId(jobId); // Calls the search function.
        }

        // Handles click event for the Update Invoice button.
        private void btnUpdateInvoice_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) // Validates all input fields.
            {
                return; // Stops if validation fails.
            }

            // Checks if an Invoice ID is selected for update.
            if (string.IsNullOrWhiteSpace(txtInvoiceId.Text) || !int.TryParse(txtInvoiceId.Text, out int invoiceIdToUpdate))
            {
                MessageBox.Show("Please select an Invoice from the grid or search for one to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(DbConnection.ConnectionString))
            {
                try
                {
                    connection.Open(); // Opens the database connection.
                    // SQL query to update an existing invoice record.
                    string query = @"UPDATE Invoices SET
                                            JobID = @JobID,
                                            Amount = @Amount,
                                            Status = @Status,
                                            DateIssued = @DateIssued,
                                            DateDue = @DateDue
                                            WHERE InvoiceID = @InvoiceID";

                    SqlCommand command = new SqlCommand(query, connection);
                    // Adds parameters for the update query.
                    command.Parameters.AddWithValue("@JobID", int.Parse(txtJobId.Text.Trim()));
                    command.Parameters.AddWithValue("@Amount", decimal.Parse(txtAmount.Text.Trim()));
                    command.Parameters.AddWithValue("@Status", cmbInvoiceStatus.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@DateIssued", dtpDateIssued.Value.Date);
                    command.Parameters.AddWithValue("@DateDue", dtpDateDue.Value.Date);
                    command.Parameters.AddWithValue("@InvoiceID", invoiceIdToUpdate);

                    int rowsAffected = command.ExecuteNonQuery(); // Executes the update query.

                    if (rowsAffected > 0) // If update was successful.
                    {
                        MessageBox.Show("Invoice updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFormFields(); // Clears form fields.
                        LoadInvoicesIntoGrid(); // Refreshes DataGridView.
                    }
                    else // If no invoice was found or no changes were made.
                    {
                        MessageBox.Show("Invoice not found or no changes were made.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("Database error updating invoice: " + sqlEx.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred while updating invoice: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Handles click event for the Add Invoice button.
        private void btnAddInvoice_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) // Validates all input fields.
            {
                return; // Stops if validation fails.
            }

            // Checks if a job exists for the entered Job ID.
            if (!CheckJobExists(int.Parse(txtJobId.Text)))
            {
                MessageBox.Show("No job found with the entered Job ID. Please enter a valid Job ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtJobId.Focus();
                return;
            }

            // Checks if an invoice already exists for this Job ID, preventing duplicates for a single job.
            if (CheckInvoiceExistsForJob(int.Parse(txtJobId.Text)) && !_isAddingNewInvoice)
            {
                MessageBox.Show("An invoice already exists for this Job ID. Use 'Update' instead.", "Duplicate Invoice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(DbConnection.ConnectionString))
            {
                try
                {
                    connection.Open(); // Opens the database connection.
                    // SQL query to insert a new invoice and retrieve the new Invoice ID.
                    string query = @"INSERT INTO Invoices (JobID, Amount, Status, DateIssued, DateDue)
                                            VALUES (@JobID, @Amount, @Status, @DateIssued, @DateDue);
                                            SELECT SCOPE_IDENTITY();";

                    SqlCommand command = new SqlCommand(query, connection);
                    // Adds parameters for the insert query.
                    command.Parameters.AddWithValue("@JobID", int.Parse(txtJobId.Text.Trim()));
                    command.Parameters.AddWithValue("@Amount", decimal.Parse(txtAmount.Text.Trim()));
                    command.Parameters.AddWithValue("@Status", cmbInvoiceStatus.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@DateIssued", dtpDateIssued.Value.Date);
                    command.Parameters.AddWithValue("@DateDue", dtpDateDue.Value.Date);

                    int newInvoiceId = Convert.ToInt32(command.ExecuteScalar()); // Executes query and gets the new Invoice ID.

                    MessageBox.Show($"Invoice added successfully! New Invoice ID: {newInvoiceId}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFormFields(); // Clears form fields.
                    LoadInvoicesIntoGrid(); // Refreshes DataGridView.
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("Database error adding invoice: " + sqlEx.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred while adding invoice: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Checks if an invoice already exists for a given Job ID.
        private bool CheckInvoiceExistsForJob(int jobId)
        {
            using (SqlConnection connection = new SqlConnection(DbConnection.ConnectionString))
            {
                try
                {
                    connection.Open(); // Opens the database connection.
                    string query = "SELECT COUNT(*) FROM Invoices WHERE JobID = @JobID"; // Query to count invoices for a job.
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@JobID", jobId);
                    return (int)command.ExecuteScalar() > 0; // Returns true if count is greater than 0.
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error checking existing invoice for job: " + ex.Message, "Database Check Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        // Checks if a job with the given Job ID exists in the database.
        private bool CheckJobExists(int jobId)
        {
            using (SqlConnection connection = new SqlConnection(DbConnection.ConnectionString))
            {
                try
                {
                    connection.Open(); // Opens the database connection.
                    string query = "SELECT COUNT(*) FROM Jobs WHERE JobID = @JobID"; // Query to count jobs.
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@JobID", jobId);
                    return (int)command.ExecuteScalar() > 0; // Returns true if count is greater than 0.
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error checking job existence: " + ex.Message, "Database Check Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        // Handles click event for the Delete Invoice button.
        private void btnDeleteInvoice_Click(object sender, EventArgs e)
        {
            // Validates if an Invoice ID is selected for deletion.
            if (string.IsNullOrWhiteSpace(txtInvoiceId.Text) || !int.TryParse(txtInvoiceId.Text, out int invoiceIdToDelete))
            {
                MessageBox.Show("Please select an Invoice from the grid or search for one to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirms deletion with the user.
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this invoice?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No)
            {
                return; // Aborts deletion if user selects No.
            }

            using (SqlConnection connection = new SqlConnection(DbConnection.ConnectionString))
            {
                try
                {
                    connection.Open(); // Opens the database connection.
                    string query = "DELETE FROM Invoices WHERE InvoiceID = @InvoiceID"; // SQL query to delete an invoice.
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@InvoiceID", invoiceIdToDelete); // Adds Invoice ID parameter.

                    int rowsAffected = command.ExecuteNonQuery(); // Executes the delete query.

                    if (rowsAffected > 0) // If deletion was successful.
                    {
                        MessageBox.Show("Invoice deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFormFields(); // Clears form fields.
                        LoadInvoicesIntoGrid(); // Refreshes DataGridView.
                    }
                    else // If invoice not found.
                    {
                        MessageBox.Show("Invoice not found.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("Database error deleting invoice: " + sqlEx.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred while deleting invoice: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Handles click event for the Clear button, clears all form fields.
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFormFields(); // Calls the method to clear and reset form fields.
        }

        // Empty event handlers for various UI elements (labels, text boxes, menu strip).
        private void lblInvoiceManagement_Click(object sender, EventArgs e) { }
        private void lblJobId_Click(object sender, EventArgs e) { }
        private void txtJobId_TextChanged(object sender, EventArgs e) { }
        private void lblInvoiceId_Click(object sender, EventArgs e) { }
        private void txtInvoiceId_TextChanged(object sender, EventArgs e) { }
        private void lblAmount_Click(object sender, EventArgs e) { }
        private void txtAmount_TextChanged(object sender, EventArgs e) { }
        private void lblStatus_Click(object sender, EventArgs e) { }
        private void cmbInvoiceStatus_SelectedIndexChanged(object sender, EventArgs e) { }
        private void lblDateIssued_Click(object sender, EventArgs e) { }
        private void dtpDateIssued_ValueChanged(object sender, EventArgs e) { }
        private void lblDateDue_Click(object sender, EventArgs e) { }
        private void dtpDateDue_ValueChanged(object sender, EventArgs e) { }
        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e) { }
    }
}