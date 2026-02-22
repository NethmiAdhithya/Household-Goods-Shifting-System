using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace E_Shift
{
    // frmLoad class: Manages the "Load" operations in the E-Shift application,
    // including adding, updating, deleting, searching, and displaying load details.
    public partial class frmLoad : Form
    {
        // Private field to store the Job ID, primarily used when the form is opened
        // from a specific job, making the Job ID read-only.
        private int _jobIdForLoad;

        // Constructor for frmLoad.
        // It can optionally accept a jobId, typically when opened from a Job management screen.
        public frmLoad(int jobId = -1)
        {
            InitializeComponent(); // Initializes the form's components.
            _jobIdForLoad = jobId; // Assigns the passed Job ID.

            SetupDataGridView(); // Configures the DataGridView for displaying load data.
            PopulateComboBoxes(); // Fills status dropdowns (e.g., LoadStatus, FilterByLoadStatus).
            LoadTransportUnitsIntoComboBox(); // Populates the Transport Unit dropdown with available units.

            // Checks if a specific Job ID was passed to the constructor.
            if (_jobIdForLoad != -1)
            {
                txtJobId.Text = _jobIdForLoad.ToString(); // Displays the Job ID.
                txtJobId.ReadOnly = true; // Makes the Job ID field read-only.
                LoadLoadsIntoGridByJobId(_jobIdForLoad); // Loads loads specifically for this job.
            }
            else
            {
                txtJobId.ReadOnly = false; // Allows manual entry of Job ID if not passed.
                LoadLoadsIntoGrid(); // Loads all loads into the grid if no specific Job ID.
            }
        }

        // Loads load records into the DataGridView based on a specific Job ID.
        private void LoadLoadsIntoGridByJobId(int jobId)
        {
            // Establishes a connection to the database.
            using (SqlConnection con = new SqlConnection(DbConnection.ConnectionString))
            {
                try
                {
                    con.Open(); // Opens the database connection.
                    // SQL query to select all relevant load details for a specific Job ID.
                    string query = "SELECT LoadID, JobID, ProductItem, Quantity, Weight, Size, Description, LoadStatus, TransportUnitID FROM Loads WHERE JobID = @JobID ORDER BY LoadID DESC";
                    SqlDataAdapter da = new SqlDataAdapter(query, con); // Creates a data adapter.
                    da.SelectCommand.Parameters.AddWithValue("@JobID", jobId); // Adds Job ID parameter to the query.
                    DataTable dt = new DataTable(); // Creates a new DataTable.
                    da.Fill(dt); // Fills the DataTable with query results.
                    dgvLoad.DataSource = dt; // Sets the DataGridView's data source.
                    dgvLoad.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells); // Auto-resizes columns for better fit.
                }
                catch (Exception ex)
                {
                    // Displays an error message if loading loads for the job fails.
                    MessageBox.Show("Error loading loads for job " + jobId + ": " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Searches for a load based on Load ID or Job ID and populates the form fields.
        private void SearchLoad(int? loadId = null, int? jobId = null)
        {
            ClearForm(); // Clears all form fields.
            picUploadedPhoto.Image = null; // Clears any displayed image.

            // Establishes a connection to the database.
            using (SqlConnection con = new SqlConnection(DbConnection.ConnectionString))
            {
                try
                {
                    con.Open(); // Opens the database connection.
                    string query = "SELECT * FROM Loads WHERE "; // Base query.
                    SqlCommand cmd = new SqlCommand(); // Creates a new SQL command.
                    cmd.Connection = con; // Sets the connection for the command.

                    // Appends conditions based on whether Load ID or Job ID is provided.
                    if (loadId.HasValue && loadId > 0)
                    {
                        query += "LoadID = @LoadID";
                        cmd.Parameters.AddWithValue("@LoadID", loadId.Value);
                    }
                    else if (jobId.HasValue && jobId > 0)
                    {
                        query += "JobID = @JobID";
                        cmd.Parameters.AddWithValue("@JobID", jobId.Value);
                    }
                    else
                    {
                        // Prompts the user to enter a search ID if neither is provided.
                        MessageBox.Show("Please enter a Load ID or Job ID to search.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Exits the method.
                    }

                    cmd.CommandText = query; // Sets the command text.
                    SqlDataReader reader = cmd.ExecuteReader(); // Executes the query and gets a data reader.

                    if (reader.Read()) // If a record is found.
                    {
                        // Populates form fields with retrieved data.
                        txtLoadId.Text = reader["LoadID"].ToString();
                        txtJobId.Text = reader["JobID"].ToString();
                        txtProductItem.Text = reader["ProductItem"].ToString();
                        txtQuantity.Text = reader["Quantity"].ToString();
                        txtWeight.Text = reader["Weight"].ToString();
                        txtSize.Text = reader["Size"].ToString();
                        txtDescription.Text = reader["Description"].ToString();

                        // Sets the selected item in the Load Status ComboBox.
                        string loadStatus = reader["LoadStatus"].ToString();
                        cmbLoadStatus.SelectedIndex = cmbLoadStatus.FindStringExact(loadStatus);

                        // Sets the selected item in the Transport Unit ID ComboBox.
                        if (reader["TransportUnitID"] != DBNull.Value)
                        {
                            cmbTransportUnitId.SelectedValue = Convert.ToInt32(reader["TransportUnitID"]);
                        }
                        else
                        {
                            cmbTransportUnitId.SelectedIndex = -1; // Clears the selection if null.
                        }

                        // Displays the item photo if available.
                        if (reader["ItemPhoto"] != DBNull.Value)
                        {
                            _itemPhotoBytes = (byte[])reader["ItemPhoto"];
                            DisplayImageFromBytes(_itemPhotoBytes); // Assumes DisplayImageFromBytes method exists.
                        }
                        else
                        {
                            _itemPhotoBytes = null;
                            picUploadedPhoto.Image = null; // Clears the image.
                        }

                        MessageBox.Show("Load details found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No Load found with the provided ID.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error searching load: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Adds a new load record to the database.
        private void AddLoad()
        {
            // 1. Validates user inputs before proceeding.
            if (!ValidateLoadInputs()) return;

            // Parses and retrieves data from form fields.
            int jobId = int.Parse(txtJobId.Text.Trim());
            string productItem = txtProductItem.Text.Trim();
            int? quantity = int.TryParse(txtQuantity.Text.Trim(), out int qty) ? (int?)qty : null;
            decimal? weight = decimal.TryParse(txtWeight.Text.Trim(), out decimal wt) ? (decimal?)wt : null;
            string size = txtSize.Text.Trim();
            string description = txtDescription.Text.Trim();
            string loadStatus = cmbLoadStatus.SelectedItem?.ToString();
            // Retrieves the selected transport unit ID, handling potential null values.
            object transportUnitIdValue = (cmbTransportUnitId.SelectedItem as ComboBoxItem)?.Value;

            // Establishes a connection to the database.
            using (SqlConnection con = new SqlConnection(DbConnection.ConnectionString))
            {
                try
                {
                    con.Open(); // Opens the database connection.
                    // SQL query to insert a new load record and retrieve its new LoadID.
                    string query = @"INSERT INTO Loads (JobID, ProductItem, ItemPhoto, Quantity, Weight, Size, Description, LoadStatus, TransportUnitID, CreatedDate)
                                     VALUES (@JobID, @ProductItem, @ItemPhoto, @Quantity, @Weight, @Size, @Description, @LoadStatus, @TransportUnitID, GETDATE());
                                     SELECT SCOPE_IDENTITY();"; // Returns the identity value of the last inserted row.

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Adds parameters to the SQL command, handling nulls for optional fields.
                        cmd.Parameters.AddWithValue("@JobID", jobId);
                        cmd.Parameters.AddWithValue("@ProductItem", productItem);
                        cmd.Parameters.AddWithValue("@ItemPhoto", _itemPhotoBytes ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Quantity", quantity.HasValue ? (object)quantity.Value : DBNull.Value);
                        cmd.Parameters.AddWithValue("@Weight", weight.HasValue ? (object)weight.Value : DBNull.Value);
                        cmd.Parameters.AddWithValue("@Size", string.IsNullOrWhiteSpace(size) ? (object)DBNull.Value : size);
                        cmd.Parameters.AddWithValue("@Description", string.IsNullOrWhiteSpace(description) ? (object)DBNull.Value : description);
                        cmd.Parameters.AddWithValue("@LoadStatus", loadStatus);
                        cmd.Parameters.AddWithValue("@TransportUnitID", transportUnitIdValue == DBNull.Value ? (object)DBNull.Value : transportUnitIdValue);

                        int newLoadId = Convert.ToInt32(cmd.ExecuteScalar()); // Executes the query and gets the new Load ID.

                        MessageBox.Show($"Load added successfully! New Load ID: {newLoadId}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm(); // Clears form fields.
                        LoadLoadsIntoGrid(); // Refreshes the DataGridView.
                    }
                }
                catch (SqlException ex)
                {
                    // Handles specific SQL errors (e.g., foreign key violations).
                    if (ex.Number == 547)
                    {
                        MessageBox.Show("Invalid Job ID or Transport Unit ID. Please ensure they exist.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Database error adding load: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Updates an existing load record in the database.
        private void UpdateLoad()
        {
            // 1. Validates if a valid Load ID is entered/selected.
            if (!int.TryParse(txtLoadId.Text, out int loadId) || loadId <= 0)
            {
                MessageBox.Show("Please select a Load from the grid or enter a valid Load ID to update.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Validates other user inputs.
            if (!ValidateLoadInputs()) return;

            // Parses and retrieves data from form fields.
            int jobId = int.Parse(txtJobId.Text.Trim());
            string productItem = txtProductItem.Text.Trim();
            int? quantity = int.TryParse(txtQuantity.Text.Trim(), out int qty) ? (int?)qty : null;
            decimal? weight = decimal.TryParse(txtWeight.Text.Trim(), out decimal wt) ? (decimal?)wt : null;
            string size = txtSize.Text.Trim();
            string description = txtDescription.Text.Trim();
            string loadStatus = cmbLoadStatus.SelectedItem?.ToString();

            // Retrieves the selected TransportUnitID value, handling potential nulls.
            object transportUnitIdValue = DBNull.Value;
            if (cmbTransportUnitId.SelectedValue != null)
            {
                if (int.TryParse(cmbTransportUnitId.SelectedValue.ToString(), out int selectedTransportUnitId))
                {
                    transportUnitIdValue = selectedTransportUnitId;
                }
            }

            // Establishes a connection to the database.
            using (SqlConnection con = new SqlConnection(DbConnection.ConnectionString))
            {
                try
                {
                    con.Open(); // Opens the database connection.
                    // SQL query to update an existing load record.
                    string query = @"UPDATE Loads SET
                                 JobID = @JobID,
                                 ProductItem = @ProductItem,
                                 ItemPhoto = @ItemPhoto,
                                 Quantity = @Quantity,
                                 Weight = @Weight,
                                 Size = @Size,
                                 Description = @Description,
                                 LoadStatus = @LoadStatus,
                                 TransportUnitID = @TransportUnitID,
                                 LastModifiedDate = GETDATE()
                             WHERE LoadID = @LoadID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Adds parameters to the SQL command, handling nulls for optional fields.
                        cmd.Parameters.AddWithValue("@JobID", jobId);
                        cmd.Parameters.AddWithValue("@ProductItem", productItem);
                        cmd.Parameters.AddWithValue("@ItemPhoto", _itemPhotoBytes ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Quantity", quantity.HasValue ? (object)quantity.Value : DBNull.Value);
                        cmd.Parameters.AddWithValue("@Weight", weight.HasValue ? (object)weight.Value : DBNull.Value);
                        cmd.Parameters.AddWithValue("@Size", string.IsNullOrWhiteSpace(size) ? (object)DBNull.Value : size);
                        cmd.Parameters.AddWithValue("@Description", string.IsNullOrWhiteSpace(description) ? (object)DBNull.Value : description);
                        cmd.Parameters.AddWithValue("@LoadStatus", loadStatus);
                        cmd.Parameters.AddWithValue("@TransportUnitID", transportUnitIdValue);
                        cmd.Parameters.AddWithValue("@LoadID", loadId); // Condition for the update.

                        int rowsAffected = cmd.ExecuteNonQuery(); // Executes the update query.

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Load updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm(); // Clears form fields.
                            LoadLoadsIntoGrid(); // Refreshes the DataGridView.
                        }
                        else
                        {
                            MessageBox.Show("Load not found or no changes made.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    // Handles specific SQL errors.
                    if (ex.Number == 547)
                    {
                        MessageBox.Show("Invalid Job ID or Transport Unit ID. Please ensure they exist.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Database error updating load: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Deletes a load record from the database.
        private void DeleteLoad()
        {
            // Validates if a valid Load ID is entered/selected.
            if (!int.TryParse(txtLoadId.Text, out int loadId) || loadId <= 0)
            {
                MessageBox.Show("Please select a Load from the grid or enter a valid Load ID to delete.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirms deletion with the user.
            DialogResult confirm = MessageBox.Show($"Are you sure you want to delete Load ID: {loadId}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes) // If user confirms deletion.
            {
                // Establishes a connection to the database.
                using (SqlConnection con = new SqlConnection(DbConnection.ConnectionString))
                {
                    try
                    {
                        con.Open(); // Opens the database connection.
                        string query = "DELETE FROM Loads WHERE LoadID = @LoadID"; // SQL query for deletion.
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@LoadID", loadId); // Adds Load ID parameter.
                            int rowsAffected = cmd.ExecuteNonQuery(); // Executes the delete query.

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Load deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearForm(); // Clears form fields.
                                LoadLoadsIntoGrid(); // Refreshes the DataGridView.
                            }
                            else
                            {
                                MessageBox.Show("Load not found.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting load: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // --- Validation ---
        // Validates input fields for adding or updating a load.
        private bool ValidateLoadInputs()
        {
            // Validates Job ID.
            if (!int.TryParse(txtJobId.Text.Trim(), out int jobId) || jobId <= 0)
            {
                MessageBox.Show("Please enter a valid Job ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtJobId.Focus();
                return false;
            }
            // Validates Product Item.
            if (string.IsNullOrWhiteSpace(txtProductItem.Text))
            {
                MessageBox.Show("Product Item is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProductItem.Focus();
                return false;
            }
            // Validates Load Status selection.
            if (cmbLoadStatus.SelectedItem == null)
            {
                MessageBox.Show("Load Status is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbLoadStatus.Focus();
                return false;
            }

            // Validates Quantity if not empty.
            if (!string.IsNullOrWhiteSpace(txtQuantity.Text) && !int.TryParse(txtQuantity.Text, out _))
            {
                MessageBox.Show("Quantity must be a valid whole number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantity.Focus();
                return false;
            }
            // Validates Weight if not empty.
            if (!string.IsNullOrWhiteSpace(txtWeight.Text) && !decimal.TryParse(txtWeight.Text, out _))
            {
                MessageBox.Show("Weight must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtWeight.Focus();
                return false;
            }
            return true; // All inputs are valid.
        }

        // --- Form Utility Methods ---
        // Clears all input fields on the form.
        private void ClearForm()
        {
            txtLoadId.Clear(); // Clears Load ID text box.
            txtProductItem.Clear(); // Clears Product Item text box.
            txtQuantity.Clear(); // Clears Quantity text box.
            txtWeight.Clear(); // Clears Weight text box.
            txtSize.Clear(); // Clears Size text box.
            txtDescription.Clear(); // Clears Description text box.
            cmbLoadStatus.SelectedIndex = 0; // Resets Load Status to default (Pending).
            cmbTransportUnitId.SelectedIndex = 0; // Resets Transport Unit ID to default (Unassigned).
            picUploadedPhoto.Image = null; // Clears the displayed photo.
            _itemPhotoBytes = null; // Clears stored photo bytes.

            // Handles the Job ID field based on whether it was passed or user-entered.
            if (_jobIdForLoad == -1) // If Job ID was not passed (user-entered).
            {
                txtJobId.Clear(); // Clears Job ID text box.
                txtJobId.ReadOnly = false; // Makes Job ID editable.
                txtJobId.Focus(); // Sets focus to Job ID.
            }
            else
            {
                // If Job ID was passed, it remains read-only and filled.
                txtProductItem.Focus(); // Sets focus to Product Item.
            }
        }

        // Loads all load records into the DataGridView, with optional status filtering.
        private void LoadLoadsIntoGrid(string statusFilter = "All")
        {
            // Establishes a connection to the database.
            using (SqlConnection con = new SqlConnection(DbConnection.ConnectionString))
            {
                try
                {
                    con.Open(); // Opens the database connection.
                    string query = "SELECT LoadID, JobID, ProductItem, Quantity, Weight, Size, Description, LoadStatus, TransportUnitID FROM Loads";

                    // Appends WHERE clause if a status filter is applied.
                    if (statusFilter != "All")
                    {
                        query += " WHERE LoadStatus = @LoadStatus";
                    }
                    query += " ORDER BY LoadID DESC"; // Orders results by Load ID descending.

                    SqlDataAdapter da = new SqlDataAdapter(query, con); // Creates a data adapter.
                    if (statusFilter != "All")
                    {
                        da.SelectCommand.Parameters.AddWithValue("@LoadStatus", statusFilter); // Adds status parameter.
                    }

                    DataTable dt = new DataTable(); // Creates a new DataTable.
                    da.Fill(dt); // Fills the DataTable.
                    dgvLoad.DataSource = dt; // Sets the DataGridView's data source.
                    dgvLoad.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells); // Auto-resizes columns.
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading loads: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Loads available transport units into the Transport Unit ComboBox.
        private void LoadTransportUnitsIntoComboBox()
        {
            // Sets the display and value members for the ComboBox.
            cmbTransportUnitId.DisplayMember = "LorryNumberPlate";
            cmbTransportUnitId.ValueMember = "TransportUnitID";

            // Establishes a connection to the database.
            using (SqlConnection con = new SqlConnection(DbConnection.ConnectionString))
            {
                try
                {
                    con.Open(); // Opens the database connection.
                    // SQL query to select available transport units.
                    string query = "SELECT TransportUnitID, LorryNumberPlate FROM TransportUnits WHERE IsAvailable = 1 ORDER BY LorryNumberPlate";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt); // Fills the DataTable with transport unit data.

                        cmbTransportUnitId.DataSource = dt; // Sets the DataTable as the ComboBox's data source.
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading transport units: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Helper class for ComboBox items that need both a display text and a value.
        public class ComboBoxItem
        {
            public string Text { get; set; } // The text displayed in the ComboBox.
            public object Value { get; set; } // The underlying value (e.g., ID).

            // Constructor to initialize Text and Value.
            public ComboBoxItem(string text, object value)
            {
                Text = text;
                Value = value;
            }

            // Overrides ToString() to display the Text property in the ComboBox.
            public override string ToString()
            {
                return Text;
            }
        }

        // Private field to store item photo as a byte array.
        private byte[] _itemPhotoBytes = null;

        // Populates the Load Status and Filter By Load Status ComboBoxes with predefined options.
        private void PopulateComboBoxes()
        {
            // Populates cmbLoadStatus (for Add/Update functionality).
            cmbLoadStatus.Items.Clear();
            cmbLoadStatus.Items.Add("Pending");
            cmbLoadStatus.Items.Add("Loaded");
            cmbLoadStatus.Items.Add("In Transit");
            cmbLoadStatus.Items.Add("Delivered");
            cmbLoadStatus.Items.Add("Cancelled");
            cmbLoadStatus.SelectedIndex = 0; // Sets default to "Pending".

            // Populates cmbFilterByLoadStatus (for filtering the DataGridView).
            cmbFilterByLoadStatus.Items.Clear();
            cmbFilterByLoadStatus.Items.Add("All"); // Option to display all loads.
            cmbFilterByLoadStatus.Items.Add("Pending");
            cmbFilterByLoadStatus.Items.Add("Loaded");
            cmbFilterByLoadStatus.Items.Add("In Transit");
            cmbFilterByLoadStatus.Items.Add("Delivered");
            cmbFilterByLoadStatus.Items.Add("Cancelled");
            cmbFilterByLoadStatus.SelectedIndex = 0; // Sets default to "All".
        }

        // Configures the DataGridView columns and properties.
        private void SetupDataGridView()
        {
            dgvLoad.AutoGenerateColumns = false; // Prevents auto-generation of columns.
            dgvLoad.Columns.Clear(); // Clears existing columns.

            // Adds and configures columns for displaying load data.
            dgvLoad.Columns.Add("LoadID", "Load ID");
            dgvLoad.Columns["LoadID"].DataPropertyName = "LoadID";
            dgvLoad.Columns["LoadID"].ReadOnly = true;
            dgvLoad.Columns["LoadID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvLoad.Columns.Add("JobID", "Job ID");
            dgvLoad.Columns["JobID"].DataPropertyName = "JobID";
            dgvLoad.Columns["JobID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvLoad.Columns.Add("ProductItem", "Product Item");
            dgvLoad.Columns["ProductItem"].DataPropertyName = "ProductItem";
            dgvLoad.Columns["ProductItem"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // ItemPhoto column is not added to DGV for performance; loaded to PictureBox on demand.

            dgvLoad.Columns.Add("Quantity", "Qty");
            dgvLoad.Columns["Quantity"].DataPropertyName = "Quantity";
            dgvLoad.Columns["Quantity"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvLoad.Columns.Add("Weight", "Weight");
            dgvLoad.Columns["Weight"].DataPropertyName = "Weight";
            dgvLoad.Columns["Weight"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvLoad.Columns.Add("Size", "Size");
            dgvLoad.Columns["Size"].DataPropertyName = "Size";
            dgvLoad.Columns["Size"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvLoad.Columns.Add("Description", "Description");
            dgvLoad.Columns["Description"].DataPropertyName = "Description";
            dgvLoad.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvLoad.Columns.Add("LoadStatus", "Status");
            dgvLoad.Columns["LoadStatus"].DataPropertyName = "LoadStatus";
            dgvLoad.Columns["LoadStatus"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvLoad.Columns.Add("TransportUnitID", "Transport Unit ID");
            dgvLoad.Columns["TransportUnitID"].DataPropertyName = "TransportUnitID";
            dgvLoad.Columns["TransportUnitID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Sets DataGridView properties.
            dgvLoad.ReadOnly = true; // Makes the grid read-only.
            dgvLoad.AllowUserToAddRows = false; // Disallows adding new rows directly in the grid.
            dgvLoad.AllowUserToDeleteRows = false; // Disallows deleting rows directly in the grid.
            dgvLoad.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Enables full row selection.
        }

        private void Home_Click(object sender, EventArgs e)
        {
            frmHome Home = new frmHome();

            Home.Show();

            this.Hide();
        }

        private void tsmMain_Click(object sender, EventArgs e)
        {
            frmMainAdmin mainAdmin = new frmMainAdmin();

            mainAdmin.Show();

            this.Hide();
        }

        private void tsmCustomer_Click(object sender, EventArgs e)
        {
            frmCustomer customer = new frmCustomer();

            customer.Show();

            this.Hide();
        }

        private void tsmJob_Click(object sender, EventArgs e)
        {
            frmJob job = new frmJob();

            job.Show();

            this.Hide();
        }

        private void tsmLoad_Click(object sender, EventArgs e)
        {
            
        }

        private void tsmTransportUnit_Click(object sender, EventArgs e)
        {
            frmTransportUnit transportUnit = new frmTransportUnit();

            transportUnit.Show();

            this.Hide();
        }

        private void tsmInvoice_Click(object sender, EventArgs e)
        {
            frmInvoice invoice = new frmInvoice();

            invoice.Show();

            this.Hide();
        }

        private void tsmDashboard_Click(object sender, EventArgs e)
        {
            frmAdminDashboard adminDashboard = new frmAdminDashboard();

            adminDashboard.Show();

            this.Hide();
        }

        private void tsmAdminManagement_Click(object sender, EventArgs e)
        {
            frmAdminManagement adminManagement = new frmAdminManagement();

            adminManagement.Show();

            this.Hide();
        }

        private void tsmReports_Click(object sender, EventArgs e) { }

        private void tsmCustomerTheirJobs_Click(object sender, EventArgs e)
        {
            frmCustomerAndTheirJobsReport customerAndTheirJobsReport = new frmCustomerAndTheirJobsReport();

            customerAndTheirJobsReport.Show();

            this.Hide();
        }

        private void tsmJobsByDateRange_Click(object sender, EventArgs e)
        {
            frmJobsByDateRangeReport jobsByDateRangeReport = new frmJobsByDateRangeReport();

            jobsByDateRangeReport.Show();

            this.Hide();
        }

        private void tsmLoadsByTransportUnit_Click(object sender, EventArgs e)
        {
            frmLoadsByTransportUnitReport loadsByTransportUnitReport = new frmLoadsByTransportUnitReport();

            loadsByTransportUnitReport.Show();

            this.Hide();
        }

        private void tsmDeliveryPerformance_Click(object sender, EventArgs e)
        {
            frmDeliveryPerformanceReport deliveryPerformanceReport = new frmDeliveryPerformanceReport();

            deliveryPerformanceReport.Show();

            this.Hide();
        }

        private void tsmDailyEndOfTheLoads_Click(object sender, EventArgs e)
        {
            frmDailyEndOfTheLoadsReport dailyEndOfTheLoadsReport = new frmDailyEndOfTheLoadsReport();

            dailyEndOfTheLoadsReport.Show();

            this.Hide();
        }

        private void lblLoadManagement_Click(object sender, EventArgs e)
        {

        }

        private void frmLoad_Load(object sender, EventArgs e)
        {

        }

        private void lblJobId_Click(object sender, EventArgs e)
        {

        }

        private void txtJobId_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLoadId_Click(object sender, EventArgs e)
        {

        }

        private void txtLoadId_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblProductItem_Click(object sender, EventArgs e)
        {

        }

        private void txtProductItem_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblItemphoto_Click(object sender, EventArgs e)
        {

        }

        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            // Create a new OpenFileDialog instance to allow the user to select an image file.
            OpenFileDialog openFile = new OpenFileDialog();
            // Set the filter to only show image files (BMP, JPG, PNG, GIF) and all files.
            openFile.Filter = "Image Files(*.BMP;*.JPG;*.PNG;*.GIF)|*.BMP;*.JPG;*.PNG;*.GIF|All files (*.*)|*.*";
            // Check if the user selected a file and clicked OK.
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Load the selected image into the picUploadedPhoto PictureBox.
                    picUploadedPhoto.Image = new Bitmap(openFile.FileName);
                    // Create a MemoryStream to convert the image to a byte array.
                    using (MemoryStream ms = new MemoryStream())
                    {
                        // Save the image from the PictureBox into the MemoryStream.
                        picUploadedPhoto.Image.Save(ms, picUploadedPhoto.Image.RawFormat);
                        // Convert the MemoryStream to a byte array and store it.
                        _itemPhotoBytes = ms.ToArray();
                    }
                }
                catch (Exception ex)
                {
                    // Display an error message if there's an issue during photo upload.
                    MessageBox.Show("Error uploading photo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DisplayImageFromBytes(byte[] imageData)
        {
            // Check if the image data is not null and has content.
            if (imageData != null && imageData.Length > 0)
            {
                // Create a MemoryStream from the byte array.
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    // Load the image from the MemoryStream into the picUploadedPhoto PictureBox.
                    picUploadedPhoto.Image = Image.FromStream(ms);
                }
            }
            else
            {
                // Clear the image in the PictureBox if no data is provided.
                picUploadedPhoto.Image = null;
            }
        }

        private void picUploadedPhoto_Click(object sender, EventArgs e)
        {
            // Event handler for clicking the picUploadedPhoto PictureBox (currently empty).
        }

        private void lblQuantity_Click(object sender, EventArgs e)
        {
            // Event handler for clicking the lblQuantity label (currently empty).
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            // Event handler for text changing in the txtQuantity text box (currently empty).
        }

        private void lblWeight_Click(object sender, EventArgs e)
        {
            // Event handler for clicking the lblWeight label (currently empty).
        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {
            // Event handler for text changing in the txtWeight text box (currently empty).
        }

        private void lblSize_Click(object sender, EventArgs e)
        {
            // Event handler for clicking the lblSize label (currently empty).
        }

        private void txtSize_TextChanged(object sender, EventArgs e)
        {
            // Event handler for text changing in the txtSize text box (currently empty).
        }

        private void lblDescription_Click(object sender, EventArgs e)
        {
            // Event handler for clicking the lblDescription label (currently empty).
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            // Event handler for text changing in the txtDescription text box (currently empty).
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {
            // Event handler for clicking the lblStatus label (currently empty).
        }

        private void cmbLoadStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Event handler for selected index changing in the cmbLoadStatus ComboBox (currently empty).
        }

        private void lblTransportUnitId_Click(object sender, EventArgs e)
        {
            // Event handler for clicking the lblTransportUnitId label (currently empty).
        }

        private void cmbTransportUnitId_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Event handler for selected index changing in the cmbTransportUnitId ComboBox (currently empty).
        }

        private void pnlFilter_Paint(object sender, PaintEventArgs e)
        {
            // Event handler for painting the pnlFilter panel (currently empty).
        }

        private void lblFilterByStatus_Click(object sender, EventArgs e)
        {
            // Event handler for clicking the lblFilterByStatus label (currently empty).
        }

        private void cmbFilterByLoadStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Event handler for selected index changing in the cmbFilterByLoadStatus ComboBox (currently empty).
        }

        private void btnApplyStatusFilter_Click(object sender, EventArgs e)
        {
            // Get the selected status from the filter ComboBox.
            string selectedStatus = cmbFilterByLoadStatus.SelectedItem?.ToString();
            // Check if a status has been selected.
            if (!string.IsNullOrEmpty(selectedStatus))
            {
                // Load loads into the grid based on the selected status.
                LoadLoadsIntoGrid(selectedStatus);
            }
            else
            {
                // Warn the user if no status is selected for filtering.
                MessageBox.Show("Please select a status to filter by.", "Filter Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvLoad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure a valid row was clicked (not the header).
            if (e.RowIndex >= 0)
            {
                // Get the clicked row.
                DataGridViewRow row = dgvLoad.Rows[e.RowIndex];

                // Populate text boxes with data from the selected row.
                txtLoadId.Text = row.Cells["LoadID"].Value.ToString();
                txtJobId.Text = row.Cells["JobID"].Value.ToString(); // Update JobId, keeping it read-only.
                txtProductItem.Text = row.Cells["ProductItem"].Value?.ToString() ?? "";
                txtQuantity.Text = row.Cells["Quantity"].Value?.ToString() ?? "";
                txtWeight.Text = row.Cells["Weight"].Value?.ToString() ?? "";
                txtSize.Text = row.Cells["Size"].Value?.ToString() ?? "";
                txtDescription.Text = row.Cells["Description"].Value?.ToString() ?? "";

                // Set the selected item in the LoadStatus ComboBox.
                string loadStatus = row.Cells["LoadStatus"].Value?.ToString() ?? "";
                cmbLoadStatus.SelectedIndex = cmbLoadStatus.FindStringExact(loadStatus);

                // Set the selected item in the TransportUnitID ComboBox.
                if (row.Cells["TransportUnitID"].Value != DBNull.Value)
                {
                    // Convert TransportUnitID to integer.
                    int transportUnitId = Convert.ToInt32(row.Cells["TransportUnitID"].Value);
                    // Iterate through ComboBox items to find and select the matching Transport Unit ID.
                    foreach (ComboBoxItem item in cmbTransportUnitId.Items)
                    {
                        if (item.Value is int intValue && intValue == transportUnitId)
                        {
                            cmbTransportUnitId.SelectedItem = item;
                            break;
                        }
                    }
                }
                else
                {
                    // Set to "Unassigned" if no Transport Unit ID is present.
                    cmbTransportUnitId.SelectedIndex = 0;
                }

                // Re-fetch the load details, including the image, by its ID.
                if (int.TryParse(txtLoadId.Text, out int loadIdToView))
                {
                    SearchLoad(loadId: loadIdToView);
                }
            }
        }

        private void btnSearchLoad_Click(object sender, EventArgs e)
        {
            // Attempt to parse Load ID or Job ID for searching.
            if (int.TryParse(txtLoadId.Text, out int loadId) && loadId > 0)
            {
                // Search for a load using Load ID.
                SearchLoad(loadId: loadId);
            }
            else if (int.TryParse(txtJobId.Text, out int jobId) && jobId > 0)
            {
                // Search for a load using Job ID.
                SearchLoad(jobId: jobId);
            }
            else
            {
                // Prompt the user to enter a Load ID or Job ID.
                MessageBox.Show("Please enter a Load ID or Job ID to search.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAddLoad_Click(object sender, EventArgs e)
        {
            // Call the method to add a new load.
            AddLoad();
        }

        private void btnUpdateLoadDetails_Click(object sender, EventArgs e)
        {
            // Call the method to update existing load details.
            UpdateLoad();
        }

        private void btnDeleteLoad_Click(object sender, EventArgs e)
        {
            // Call the method to delete a load.
            DeleteLoad();
        }

        private void btnViewLoad_Click(object sender, EventArgs e)
        {
            // Re-use the search functionality to view load details.
            btnSearchLoad_Click(sender, e);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Call the method to clear the form fields.
            ClearForm();
        }

        private void btnAddInvoiceToJob_Click(object sender, EventArgs e)
        {
            // Validate that a valid Job ID is selected or entered.
            if (!int.TryParse(txtJobId.Text, out int currentJobId) || currentJobId <= 0)
            {
                // Warn the user if no valid Job ID is present.
                MessageBox.Show("Please ensure a valid Job ID is selected or entered before proceeding to Invoice.", "No Job ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create a new instance of frmInvoice and pass the current Job ID.
            frmInvoice invoiceForm = new frmInvoice(currentJobId);
            // Show the invoice form.
            invoiceForm.Show();
            // Hide the current form.
            this.Hide();
        }
    }
}
