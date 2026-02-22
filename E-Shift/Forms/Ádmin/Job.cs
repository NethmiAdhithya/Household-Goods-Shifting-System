using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // Required for SQL Server database interaction

namespace E_Shift
{
    // Partial class for the frmJob Windows Form
    public partial class frmJob : Form
    {
        // Private field to store the Customer ID passed from the frmCustomer form.
        private int _customerIdForJob;
        // Private field to store the JobID of the currently selected or viewed job. Default to -1 (no job selected).
        private int _selectedJobId = -1;

        // Constructor for the frmJob form.
        // It can optionally receive a customerId when opened from the customer management form.
        public frmJob(int customerId = -1)
        {
            InitializeComponent(); // Initializes components defined in the designer.
            _customerIdForJob = customerId; // Assigns the passed customer ID to the private field.

            // Checks if a Customer ID was passed to the form.
            if (_customerIdForJob != -1)
            {
                txtCustomerId.Text = _customerIdForJob.ToString(); // Displays the customer ID in the respective text box.
                txtCustomerId.ReadOnly = true; // Makes the Customer ID text box read-only if pre-filled.
            }
            else
            {
                // If no CustomerID is passed, allow the admin to input it for new jobs.
                txtCustomerId.ReadOnly = false;
            }

            txtJobId.ReadOnly = true; // Makes the Job ID text box read-only as it's typically auto-generated or display-only.
            SetupDataGridView(); // Calls a method to configure the DataGridView for displaying jobs.
            PopulateJobStatusComboBoxes(); // Fills the combo boxes with job status options.
            LoadJobsIntoGrid(); // Loads all jobs into the DataGridView upon form initialization.
        }

        // Method to load job data into the DataGridView based on various filters.
        private void LoadJobsIntoGrid(int customerIdSearch = -1, int jobIdSearch = -1, string statusFilter = "All", DateTime fromDateFilter = default(DateTime), DateTime toDateFilter = default(DateTime))
        {
            // Establishes a connection to the database using the connection string from DbConnection.
            using (SqlConnection con = new SqlConnection(DbConnection.ConnectionString))
            {
                try
                {
                    con.Open(); // Opens the database connection.
                    // Base SQL query to select all job details. "WHERE 1=1" is a common trick to simplify appending conditions.
                    string query = "SELECT JobID, CustomerID, StartLocation, Destination, JobDate, CompletionDate, JobStatus, Description FROM Jobs WHERE 1=1";

                    SqlCommand cmd = new SqlCommand(query, con); // Creates a SQL command object.

                    // Adds a CustomerID filter to the query if a search ID is provided.
                    if (customerIdSearch != -1)
                    {
                        cmd.CommandText += " AND CustomerID = @CustomerID";
                        cmd.Parameters.AddWithValue("@CustomerID", customerIdSearch);
                    }

                    // Adds a JobID filter to the query if a search ID is provided.
                    if (jobIdSearch != -1)
                    {
                        cmd.CommandText += " AND JobID = @JobID";
                        cmd.Parameters.AddWithValue("@JobID", jobIdSearch);
                    }

                    // Adds a JobStatus filter to the query if a specific status is selected (not "All").
                    if (statusFilter != "All")
                    {
                        cmd.CommandText += " AND JobStatus = @JobStatus";
                        cmd.Parameters.AddWithValue("@JobStatus", statusFilter);
                    }

                    // Handles date range filtering for JobDate.
                    if (fromDateFilter != default(DateTime) && toDateFilter != default(DateTime))
                    {
                        // Adjusts toDateFilter to include the entire end day.
                        toDateFilter = toDateFilter.Date.AddDays(1).AddSeconds(-1);
                        cmd.CommandText += " AND JobDate BETWEEN @FromDate AND @ToDate";
                        cmd.Parameters.AddWithValue("@FromDate", fromDateFilter.Date);
                        cmd.Parameters.AddWithValue("@ToDate", toDateFilter);
                    }
                    else if (fromDateFilter != default(DateTime)) // Handles only "from" date filter.
                    {
                        cmd.CommandText += " AND JobDate >= @FromDate";
                        cmd.Parameters.AddWithValue("@FromDate", fromDateFilter.Date);
                    }
                    else if (toDateFilter != default(DateTime)) // Handles only "to" date filter.
                    {
                        toDateFilter = toDateFilter.Date.AddDays(1).AddSeconds(-1);
                        cmd.CommandText += " AND JobDate <= @ToDate";
                        cmd.Parameters.AddWithValue("@ToDate", toDateFilter);
                    }

                    // Orders the results for better display.
                    cmd.CommandText += " ORDER BY JobDate DESC, JobID DESC";

                    SqlDataAdapter da = new SqlDataAdapter(cmd); // Creates a data adapter to fill a DataTable.
                    DataTable dt = new DataTable(); // Creates a new DataTable.
                    da.Fill(dt); // Fills the DataTable with data from the query.

                    dgvJob.DataSource = dt; // Sets the DataGridView's data source to the filled DataTable.

                    // Clears form fields if no specific search (customer ID or job ID) was applied.
                    if (customerIdSearch == -1 && jobIdSearch == -1)
                    {
                        // Only clear txtCustomerId if it wasn't pre-set from the customer form.
                        if (_customerIdForJob == -1)
                        {
                            txtCustomerId.Clear();
                        }
                        txtJobId.Clear();
                        txtStartLocation.Clear();
                        txtDestination.Clear();
                        dtpJobDate.Value = DateTime.Now; // Resets job date to current date/time.
                        dtpCompletionDate.Value = DateTime.Now; // Resets completion date to current date/time.
                        cmbJobStatus.SelectedIndex = 0; // Resets job status to the first item (e.g., "Pending").
                        txtDescription.Clear();
                        _selectedJobId = -1; // Resets the selected job ID.
                    }
                    // If a search resulted in exactly one job, load its details into the form fields.
                    else if (dt.Rows.Count == 1 && (customerIdSearch != -1 || jobIdSearch != -1))
                    {
                        LoadJobDetails(Convert.ToInt32(dt.Rows[0]["JobID"])); // Calls method to load job details.
                    }
                    else
                    {
                        // Clears all form fields except potentially the customer ID if it was pre-filled.
                        ClearFormFields(false);
                    }
                }
                catch (Exception ex)
                {
                    // Displays an error message if loading job data fails.
                    MessageBox.Show("Error loading job data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Method to clear all input fields on the form.
        private void ClearFormFields(bool clearCustomerId = true)
        {
            _selectedJobId = -1; // Resets the selected job ID.
            if (clearCustomerId) // Optionally clears the Customer ID field.
            {
                txtCustomerId.Clear();
            }
            txtJobId.Clear();
            txtStartLocation.Clear();
            txtDestination.Clear();
            dtpJobDate.Value = DateTime.Now; // Resets date pickers to current date/time.
            dtpCompletionDate.Value = DateTime.Now;
            cmbJobStatus.SelectedIndex = 0; // Sets job status combo box to its default (first) item.
            txtDescription.Clear();
        }

        // Method to load detailed information of a specific job into the form fields.
        private void LoadJobDetails(int jobId)
        {
            ClearFormFields(true); // Clears all fields before loading new details.
            _selectedJobId = jobId; // Sets the current selected job ID.

            using (SqlConnection con = new SqlConnection(DbConnection.ConnectionString))
            {
                try
                {
                    con.Open(); // Opens the database connection.
                    // SQL query to retrieve all details for a specific job by JobID.
                    string query = "SELECT JobID, CustomerID, StartLocation, Destination, JobDate, CompletionDate, JobStatus, Description FROM Jobs WHERE JobID = @JobID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@JobID", jobId); // Adds the JobID parameter to the command.
                        using (SqlDataReader reader = cmd.ExecuteReader()) // Executes the query and gets a data reader.
                        {
                            if (reader.Read()) // If a job record is found.
                            {
                                // Populates form fields with data from the database.
                                txtJobId.Text = reader["JobID"].ToString();
                                txtCustomerId.Text = reader["CustomerID"].ToString();
                                txtStartLocation.Text = reader["StartLocation"]?.ToString();
                                txtDestination.Text = reader["Destination"]?.ToString();
                                dtpJobDate.Value = Convert.ToDateTime(reader["JobDate"]);
                                // Handles potential DBNull for CompletionDate.
                                dtpCompletionDate.Value = reader["CompletionDate"] == DBNull.Value ? DateTime.Now : Convert.ToDateTime(reader["CompletionDate"]);
                                cmbJobStatus.SelectedItem = reader["JobStatus"]?.ToString();
                                // Handles potential DBNull for Description.
                                txtDescription.Text = reader["Description"] == DBNull.Value ? "" : reader["Description"].ToString();

                                MessageBox.Show("Job details loaded.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                // Displays an error if the job is not found.
                                MessageBox.Show("Job not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                ClearFormFields(); // Clears fields if job is not found.
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Displays an error message if loading job details fails.
                    MessageBox.Show("Error loading job details: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Method to populate the job status combo boxes with predefined options.
        private void PopulateJobStatusComboBoxes()
        {
            // Populates the combo box for job details (cmbJobStatus).
            cmbJobStatus.Items.Clear();
            cmbJobStatus.Items.Add("Pending");
            cmbJobStatus.Items.Add("In Progress");
            cmbJobStatus.Items.Add("Completed");
            cmbJobStatus.Items.Add("Cancelled");
            cmbJobStatus.SelectedIndex = 0; // Sets "Pending" as the default selected item.

            // Populates the combo box for filtering jobs (cmbFilterByJobStatus).
            cmbFilterByJobStatus.Items.Clear();
            cmbFilterByJobStatus.Items.Add("All"); // Adds an "All" option for filtering.
            cmbFilterByJobStatus.Items.Add("Pending");
            cmbFilterByJobStatus.Items.Add("In Progress");
            cmbFilterByJobStatus.Items.Add("Completed");
            cmbFilterByJobStatus.Items.Add("Cancelled");
            cmbFilterByJobStatus.SelectedIndex = 0; // Sets "All" as the default selected item.
        }

        // Method to configure the columns of the DataGridView.
        private void SetupDataGridView()
        {
            dgvJob.AutoGenerateColumns = false; // Prevents auto-generation of columns.
            dgvJob.Columns.Clear(); // Clears any existing columns.

            // Defines and adds each column to the DataGridView.
            // DataPropertyName must match the database column name for data binding.
            dgvJob.Columns.Add("JobID", "Job ID");
            dgvJob.Columns["JobID"].DataPropertyName = "JobID";
            dgvJob.Columns["JobID"].ReadOnly = true;

            dgvJob.Columns.Add("CustomerID", "Customer ID");
            dgvJob.Columns["CustomerID"].DataPropertyName = "CustomerID";

            dgvJob.Columns.Add("StartLocation", "Start Location");
            dgvJob.Columns["StartLocation"].DataPropertyName = "StartLocation";

            dgvJob.Columns.Add("Destination", "Destination");
            dgvJob.Columns["Destination"].DataPropertyName = "Destination";

            dgvJob.Columns.Add("JobDate", "Job Date");
            dgvJob.Columns["JobDate"].DataPropertyName = "JobDate";
            dgvJob.Columns["JobDate"].DefaultCellStyle.Format = "yyyy-MM-dd"; // Formats the date display.

            dgvJob.Columns.Add("CompletionDate", "Completion Date");
            dgvJob.Columns["CompletionDate"].DataPropertyName = "CompletionDate";
            dgvJob.Columns["CompletionDate"].DefaultCellStyle.Format = "yyyy-MM-dd"; // Formats the date display.

            dgvJob.Columns.Add("JobStatus", "Status");
            dgvJob.Columns["JobStatus"].DataPropertyName = "JobStatus";

            dgvJob.Columns.Add("Description", "Description");
            dgvJob.Columns["Description"].DataPropertyName = "Description";
            dgvJob.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Makes description column fill remaining space.

            dgvJob.ReadOnly = true; // Makes the entire DataGridView read-only.
            dgvJob.AllowUserToAddRows = false; // Disables adding new rows via the grid.
            dgvJob.AllowUserToDeleteRows = false; // Disables deleting rows via the grid.
            dgvJob.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Configures row selection mode.
        }

        // Event handler for the "Home" menu item click.
        private void Home_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome(); // Creates a new instance of the Home form.
            home.Show(); // Shows the Home form.
            this.Hide(); // Hides the current form.
        }

        // Event handler for the "Main Admin" menu item click.
        private void tsmMain_Click(object sender, EventArgs e)
        {
            frmMainAdmin mainAdmin = new frmMainAdmin(); // Creates a new instance of the Main Admin form.
            mainAdmin.Show(); // Shows the Main Admin form.
            this.Hide(); // Hides the current form.
        }

        // Event handler for the "Customer" menu item click.
        private void tsmCustomer_Click(object sender, EventArgs e)
        {
            frmCustomer customer = new frmCustomer(); // Creates a new instance of the Customer form.
            customer.Show(); // Shows the Customer form.
            this.Hide(); // Hides the current form.
        }

        // Event handler for the "Job" menu item click (currently empty).
        private void tsmJob_Click(object sender, EventArgs e)
        {
            // This event is likely for navigating to the current form itself, or a placeholder.
        }

        // Event handler for the "Load" menu item click.
        private void tsmLoad_Click(object sender, EventArgs e)
        {
            frmLoad load = new frmLoad(); // Creates a new instance of the Load form.
            load.Show(); // Shows the Load form.
            this.Hide(); // Hides the current form.
        }

        // Event handler for the "Transport Unit" menu item click.
        private void tsmTransportUnit_Click(object sender, EventArgs e)
        {
            frmTransportUnit transportUnit = new frmTransportUnit(); // Creates a new instance of the Transport Unit form.
            transportUnit.Show(); // Shows the Transport Unit form.
            this.Hide(); // Hides the current form.
        }

        // Event handler for the "Invoice" menu item click.
        private void tsmInvoice_Click(object sender, EventArgs e)
        {
            frmInvoice invoice = new frmInvoice(); // Creates a new instance of the Invoice form.
            invoice.Show(); // Shows the Invoice form.
            this.Hide(); // Hides the current form.
        }

        // Event handler for the "Dashboard" menu item click.
        private void tsmDashboard_Click(object sender, EventArgs e)
        {
            frmAdminDashboard adminDashboard = new frmAdminDashboard(); // Creates a new instance of the Admin Dashboard form.
            adminDashboard.Show(); // Shows the Admin Dashboard form.
            this.Hide(); // Hides the current form.
        }

        // Event handler for the "Admin Management" menu item click.
        private void tsmAdminManagement_Click(object sender, EventArgs e)
        {
            frmAdminManagement adminManagement = new frmAdminManagement(); // Creates a new instance of the Admin Management form.
            adminManagement.Show(); // Shows the Admin Management form.
            this.Hide(); // Hides the current form.
        }

        // Event handler for the "Reports" menu item click (currently empty).
        private void tsmReports_Click(object sender, EventArgs e)
        {
            // This event is likely a parent menu item for various reports.
        }

        // Event handler for the "Customer and Their Jobs Report" menu item click.
        private void tsmCustomerTheirJobs_Click(object sender, EventArgs e)
        {
            frmCustomerAndTheirJobsReport customerAndTheirJobsReport = new frmCustomerAndTheirJobsReport(); // Creates a new instance of the Customer and Their Jobs Report form.
            customerAndTheirJobsReport.Show(); // Shows the report form.
            this.Hide(); // Hides the current form.
        }

        // Event handler for the "Jobs By Date Range Report" menu item click.
        private void tsmJobsByDateRange_Click(object sender, EventArgs e)
        {
            frmJobsByDateRangeReport jobsByDateRangeReport = new frmJobsByDateRangeReport(); // Creates a new instance of the Jobs By Date Range Report form.
            jobsByDateRangeReport.Show(); // Shows the report form.
            this.Hide(); // Hides the current form.
        }

        // Event handler for the "Loads By Transport Unit Report" menu item click.
        private void tsmLoadsByTransportUnit_Click(object sender, EventArgs e)
        {
            frmLoadsByTransportUnitReport loadsByTransportUnitReport = new frmLoadsByTransportUnitReport(); // Creates a new instance of the Loads By Transport Unit Report form.
            loadsByTransportUnitReport.Show(); // Shows the report form.
            this.Hide(); // Hides the current form.
        }

        // Event handler for the "Delivery Performance Report" menu item click.
        private void tsmDeliveryPerformance_Click(object sender, EventArgs e)
        {
            frmDeliveryPerformanceReport deliveryPerformanceReport = new frmDeliveryPerformanceReport(); // Creates a new instance of the Delivery Performance Report form.
            deliveryPerformanceReport.Show(); // Shows the report form.
            this.Hide(); // Hides the current form.
        }

        // Event handler for the "Daily End Of The Loads Report" menu item click.
        private void tsmDailyEndOfTheLoads_Click(object sender, EventArgs e)
        {
            frmDailyEndOfTheLoadsReport dailyEndOfTheLoadsReport = new frmDailyEndOfTheLoadsReport(); // Creates a new instance of the Daily End Of The Loads Report form.
            dailyEndOfTheLoadsReport.Show(); // Shows the report form.
            this.Hide(); // Hides the current form.
        }

        // Event handler for the "lblJobManagement" label click (currently empty).
        private void lblJobManagement_Click(object sender, EventArgs e)
        {
            // Placeholder for click event on the Job Management label.
        }

        // Event handler for the form's Load event (when the form is loaded).
        private void frmJob_Load(object sender, EventArgs e)
        {
            LoadJobsIntoGrid(); // Loads all jobs into the grid upon form load.
            dtpJobDate.Value = DateTime.Now; // Sets default value for Job Date picker to current date.
            dtpCompletionDate.Value = DateTime.Now; // Sets default value for Completion Date picker to current date.
            dtpFromDate.Value = DateTime.Today.AddMonths(-1); // Sets default "From" date for filter to one month ago.
            dtpToDate.Value = DateTime.Today; // Sets default "To" date for filter to today.
        }

        // Event handlers for various label and text box click/change events (mostly empty placeholders).
        private void lblCustomerId_Click(object sender, EventArgs e) { }
        private void txtCustomerId_TextChanged(object sender, EventArgs e) { }
        private void lblJobId_Click(object sender, EventArgs e) { }
        private void txtJobId_TextChanged(object sender, EventArgs e) { }
        private void lblStartLocation_Click(object sender, EventArgs e) { }
        private void txtStartLocation_TextChanged(object sender, EventArgs e) { }
        private void lblDestination_Click(object sender, EventArgs e) { }
        private void txtDestination_TextChanged(object sender, EventArgs e) { }
        private void lblJobDate_Click(object sender, EventArgs e) { }
        private void dtpJobDate_ValueChanged(object sender, EventArgs e) { }
        private void lblCompletionDate_Click(object sender, EventArgs e) { }
        private void dtpCompletionDate_ValueChanged(object sender, EventArgs e) { }
        private void lblJobStatus_Click(object sender, EventArgs e) { }
        private void cmbJobStatus_SelectedIndexChanged(object sender, EventArgs e) { }
        private void lblDescription_Click(object sender, EventArgs e) { }
        private void txtDescription_TextChanged(object sender, EventArgs e) { }
        private void lblFilterByJobStatus_Click(object sender, EventArgs e) { }
        private void cmbFilterByJobStatus_SelectedIndexChanged(object sender, EventArgs e) { }
        private void pnlFilter_Paint(object sender, PaintEventArgs e) { }
        private void lblFilterByJobDate_Click(object sender, EventArgs e) { }
        private void dtpFromDate_ValueChanged(object sender, EventArgs e) { }
        private void dtpToDate_ValueChanged(object sender, EventArgs e) { }

        // Event handler for the "Apply Status Filter" button click.
        private void btnApplyStatusFilter_Click(object sender, EventArgs e)
        {
            string selectedStatus = cmbFilterByJobStatus.SelectedItem?.ToString(); // Gets the selected status from the filter combo box.
            if (selectedStatus != null)
            {
                LoadJobsIntoGrid(statusFilter: selectedStatus); // Reloads the grid with the selected status filter.
            }
        }

        // Event handler for the "Apply Date Filter" button click.
        private void btnApplyDateFilter_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dtpFromDate.Value.Date; // Gets the "From" date from the date picker.
            DateTime toDate = dtpToDate.Value.Date; // Gets the "To" date from the date picker.

            // Validates that "From Date" is not after "To Date".
            if (fromDate > toDate)
            {
                MessageBox.Show(" 'From Date' cannot be after 'To Date'.", "Date Filter Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exits the method if validation fails.
            }

            LoadJobsIntoGrid(fromDateFilter: fromDate, toDateFilter: toDate); // Reloads the grid with the applied date range filter.
        }

        // Event handler for a cell click within the DataGridView.
        private void dgvJob_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensures a valid row (not header) was clicked.
            {
                DataGridViewRow row = dgvJob.Rows[e.RowIndex]; // Gets the clicked row.
                int jobId = Convert.ToInt32(row.Cells["JobID"].Value); // Extracts the JobID from the clicked row.
                LoadJobDetails(jobId); // Loads the full details of the selected job into the form fields.
            }
        }

        // Event handler for the "Search Job" button click.
        private void btnSearchJob_Click(object sender, EventArgs e)
        {
            if (dgvJob.SelectedRows.Count > 0) // Checks if a row is selected in the grid.
            {
                int jobId = Convert.ToInt32(dgvJob.SelectedRows[0].Cells["JobID"].Value); // Gets JobID from the selected row.
                LoadJobDetails(jobId); // Loads job details.
            }
            // If no row is selected, tries to parse JobID from the input text box.
            else if (!string.IsNullOrWhiteSpace(txtJobId.Text) && int.TryParse(txtJobId.Text, out int jobIdFromInput))
            {
                LoadJobDetails(jobIdFromInput); // Loads job details based on the input JobID.
            }
            else
            {
                // Prompts the user to select a job or enter an ID if neither is done.
                MessageBox.Show("Please select a job from the grid or enter a Job ID to view.", "View Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Event handler for the "Add Job" button click.
        private void btnAddJob_Click(object sender, EventArgs e)
        {
            _selectedJobId = -1; // Resets selected Job ID to indicate "add" mode.
            txtJobId.Clear(); // Clears Job ID field for new entry.

            // Validates Customer ID input.
            if (!int.TryParse(txtCustomerId.Text, out int customerId))
            {
                MessageBox.Show("Please enter a valid Customer ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCustomerId.Focus(); // Sets focus back to Customer ID field.
                return;
            }

            // Retrieves and trims values from input fields.
            string startLocation = txtStartLocation.Text.Trim();
            string destination = txtDestination.Text.Trim();
            DateTime jobDate = dtpJobDate.Value.Date; // Gets only the date part.
            DateTime completionDate = dtpCompletionDate.Value.Date;
            string jobStatus = cmbJobStatus.SelectedItem?.ToString();
            string description = txtDescription.Text.Trim();

            // Validates required fields are not empty.
            if (string.IsNullOrWhiteSpace(startLocation) || string.IsNullOrWhiteSpace(destination) || string.IsNullOrWhiteSpace(jobStatus))
            {
                MessageBox.Show("Start Location, Destination, and Job Status are required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Basic date validation: Job Date cannot be after Completion Date.
            if (jobDate > completionDate)
            {
                MessageBox.Show("Job Date cannot be after Completion Date.", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection(DbConnection.ConnectionString))
            {
                try
                {
                    con.Open(); // Opens the database connection.
                    // First, verifies if the entered CustomerID exists in the Customers table.
                    using (SqlCommand checkCmd = new SqlCommand("SELECT COUNT(1) FROM Customers WHERE CustomerID = @CustomerID", con))
                    {
                        checkCmd.Parameters.AddWithValue("@CustomerID", customerId);
                        if ((int)checkCmd.ExecuteScalar() == 0) // If customer does not exist.
                        {
                            MessageBox.Show("Customer ID does not exist. Please enter a valid Customer ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return; // Exits if customer ID is invalid.
                        }
                    }

                    // SQL query to insert a new job record.
                    string query = "INSERT INTO Jobs (CustomerID, StartLocation, Destination, JobDate, CompletionDate, JobStatus, Description) " +
                                   "VALUES (@CustomerID, @StartLocation, @Destination, @JobDate, @CompletionDate, @JobStatus, @Description)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Adds parameters to the SQL command.
                        cmd.Parameters.AddWithValue("@CustomerID", customerId);
                        cmd.Parameters.AddWithValue("@StartLocation", startLocation);
                        cmd.Parameters.AddWithValue("@Destination", destination);
                        cmd.Parameters.AddWithValue("@JobDate", jobDate);
                        // Handles CompletionDate possibly being null in the database.
                        cmd.Parameters.AddWithValue("@CompletionDate", completionDate);
                        cmd.Parameters.AddWithValue("@JobStatus", jobStatus);
                        // Handles Description possibly being null/empty.
                        cmd.Parameters.AddWithValue("@Description", string.IsNullOrEmpty(description) ? (object)DBNull.Value : description);

                        cmd.ExecuteNonQuery(); // Executes the insert command.
                        MessageBox.Show("Job added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFormFields(false); // Clears form fields but keeps Customer ID if it was pre-filled.
                        LoadJobsIntoGrid(); // Refreshes the DataGridView to show the newly added job.
                    }
                }
                catch (SqlException ex)
                {
                    // Catches and displays specific SQL-related errors.
                    MessageBox.Show("Database error adding job: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    // Catches and displays any other unexpected errors.
                    MessageBox.Show("An unexpected error occurred while adding job: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Event handler for the "Update Job Details" button click.
        private void btnUpdateJobDetails_Click(object sender, EventArgs e)
        {
            // Checks if a job is currently selected for update.
            if (_selectedJobId == -1)
            {
                MessageBox.Show("Please select a job from the grid or load details to update.", "No Job Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validates Customer ID input.
            if (!int.TryParse(txtCustomerId.Text, out int customerId))
            {
                MessageBox.Show("Please enter a valid Customer ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCustomerId.Focus();
                return;
            }

            // Retrieves and trims values from input fields for updating.
            string startLocation = txtStartLocation.Text.Trim();
            string destination = txtDestination.Text.Trim();
            DateTime jobDate = dtpJobDate.Value.Date;
            DateTime completionDate = dtpCompletionDate.Value.Date;
            string jobStatus = cmbJobStatus.SelectedItem?.ToString();
            string description = txtDescription.Text.Trim();

            // Validates required fields are not empty.
            if (string.IsNullOrWhiteSpace(startLocation) || string.IsNullOrWhiteSpace(destination) || string.IsNullOrWhiteSpace(jobStatus))
            {
                MessageBox.Show("Start Location, Destination, and Job Status are required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Basic date validation: Job Date cannot be after Completion Date.
            if (jobDate > completionDate)
            {
                MessageBox.Show("Job Date cannot be after Completion Date.", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection(DbConnection.ConnectionString))
            {
                try
                {
                    con.Open(); // Opens the database connection.
                    // First, verifies if the entered CustomerID exists in the Customers table.
                    using (SqlCommand checkCmd = new SqlCommand("SELECT COUNT(1) FROM Customers WHERE CustomerID = @CustomerID", con))
                    {
                        checkCmd.Parameters.AddWithValue("@CustomerID", customerId);
                        if ((int)checkCmd.ExecuteScalar() == 0) // If customer does not exist.
                        {
                            MessageBox.Show("Customer ID does not exist. Please enter a valid Customer ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return; // Exits if customer ID is invalid.
                        }
                    }

                    // SQL query to update an existing job record.
                    string query = "UPDATE Jobs SET CustomerID = @CustomerID, StartLocation = @StartLocation, " +
                                   "Destination = @Destination, JobDate = @JobDate, CompletionDate = @CompletionDate, " +
                                   "JobStatus = @JobStatus, Description = @Description " +
                                   "WHERE JobID = @JobID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Adds parameters to the SQL command for updating.
                        cmd.Parameters.AddWithValue("@CustomerID", customerId);
                        cmd.Parameters.AddWithValue("@StartLocation", startLocation);
                        cmd.Parameters.AddWithValue("@Destination", destination);
                        cmd.Parameters.AddWithValue("@JobDate", jobDate);
                        cmd.Parameters.AddWithValue("@CompletionDate", completionDate);
                        cmd.Parameters.AddWithValue("@JobStatus", jobStatus);
                        cmd.Parameters.AddWithValue("@Description", string.IsNullOrEmpty(description) ? (object)DBNull.Value : description);
                        cmd.Parameters.AddWithValue("@JobID", _selectedJobId); // Uses the stored selected JobID for the WHERE clause.

                        int rowsAffected = cmd.ExecuteNonQuery(); // Executes the update command and gets the number of rows affected.

                        if (rowsAffected > 0) // If the update was successful (at least one row affected).
                        {
                            MessageBox.Show("Job details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFormFields(false); // Clears fields but keeps Customer ID if it was pre-filled.
                            LoadJobsIntoGrid(); // Refreshes the DataGridView to reflect the changes.
                        }
                        else
                        {
                            // Informs if no job was found or no changes were made.
                            MessageBox.Show("No job found with the selected ID or no changes were made.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    // Catches and displays specific SQL-related errors during update.
                    MessageBox.Show("Database error updating job: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    // Catches and displays any other unexpected errors during update.
                    MessageBox.Show("An unexpected error occurred while updating job: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDeleteJob_Click(object sender, EventArgs e)
        {
            // Check if a job is selected for deletion
            if (_selectedJobId == -1)
            {
                // Show a warning if no job is selected
                MessageBox.Show("Please select a job from the grid or load details to delete.", "No Job Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method
            }

            // Confirm deletion with the user
            DialogResult confirm = MessageBox.Show($"Are you sure you want to delete Job ID: {_selectedJobId}?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Proceed with deletion if user confirms
            if (confirm == DialogResult.Yes)
            {
                // Establish a new SQL connection
                using (SqlConnection con = new SqlConnection(DbConnection.ConnectionString))
                {
                    try
                    {
                        con.Open(); // Open the database connection
                                    // SQL query to delete a job by its ID
                        string query = "DELETE FROM Jobs WHERE JobID = @JobID";

                        // Create a new SQL command
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            // Add JobID parameter to the command to prevent SQL injection
                            cmd.Parameters.AddWithValue("@JobID", _selectedJobId);

                            // Execute the DELETE query and get the number of rows affected
                            int rowsAffected = cmd.ExecuteNonQuery();

                            // Check if deletion was successful
                            if (rowsAffected > 0)
                            {
                                // Show success message
                                MessageBox.Show("Job deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearFormFields(false); // Clear form fields but keep customer ID if pre-filled
                                LoadJobsIntoGrid(); // Refresh the job grid
                            }
                            else
                            {
                                // Show warning if no job was found with the selected ID
                                MessageBox.Show("No job found with the selected ID.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        // Handle specific SQL errors
                        if (ex.Number == 547) // Foreign key constraint violation error
                        {
                            MessageBox.Show("Cannot delete job because there are associated records (e.g., loads). Please delete those first.", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            // Handle other database errors
                            MessageBox.Show("Database error deleting job: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle any other unexpected errors
                        MessageBox.Show("An unexpected error occurred while deleting job: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnViewJob_Click(object sender, EventArgs e)
        {
            // This method is currently empty and does not perform any action.
            // It could be used to open a form to view job details.
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFormFields(true); // Clear all input fields on the form, including customer ID
            LoadJobsIntoGrid(); // Reload all jobs into the data grid
        }

        private void btnAddLoadToJob_Click(object sender, EventArgs e)
        {
            // Check if a job is selected
            if (_selectedJobId == -1)
            {
                // Show a warning if no job is selected
                MessageBox.Show("Please select a job from the grid or load details before adding a load.", "No Job Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method
            }

            // Create a new instance of the frmLoad form, passing the selected Job ID
            frmLoad loadForm = new frmLoad(_selectedJobId);
            loadForm.Show(); // Display the frmLoad form
            this.Hide(); // Hide the current form
        }
    }
}
