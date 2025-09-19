using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace E_Shift
{
    public partial class frmTransportUnit : Form
    {
        public frmTransportUnit()
        {
            // Initializes the form components.
            InitializeComponent();
            // Configures the DataGridView columns for displaying transport units.
            SetupDataGridView();
            // Loads all transport units from the database into the DataGridView when the form loads.
            LoadTransportUnitsIntoGrid();
            // Populates the ComboBoxes with predefined options.
            PopulateComboBoxes();
            // Ensures the TransportUnitId text box is editable initially.
            txtTransportUnitId.ReadOnly = false;
        }

        private void PopulateComboBoxes()
        {
            // Clear existing items for cmbContainerCondition.
            cmbContainerCondition.Items.Clear();
            // Add predefined conditions for containers.
            cmbContainerCondition.Items.Add("Good");
            cmbContainerCondition.Items.Add("Fair");
            cmbContainerCondition.Items.Add("Needs Repair");
            cmbContainerCondition.Items.Add("Damaged");
            // Set no default selection.
            cmbContainerCondition.SelectedIndex = -1;

            // Clear existing items for cmbIsAvailable.
            cmbIsAvailable.Items.Clear();
            // Add options for availability (Yes/No) with corresponding boolean values.
            cmbIsAvailable.Items.Add(new ComboBoxItem("Yes", true)); // Display "Yes", value true
            cmbIsAvailable.Items.Add(new ComboBoxItem("No", false));  // Display "No", value false
            // Set no default selection.
            cmbIsAvailable.SelectedIndex = -1;
        }

        public class ComboBoxItem
        {
            // Property to store the text displayed in the ComboBox.
            public string Text { get; set; }
            // Property to store the actual value associated with the ComboBox item.
            public object Value { get; set; }

            // Constructor to initialize Text and Value.
            public ComboBoxItem(string text, object value)
            {
                Text = text;
                Value = value;
            }

            // Overrides ToString to display the Text property in the ComboBox.
            public override string ToString()
            {
                return Text;
            }
        }

        private void LoadTransportUnitsIntoGrid()
        {
            // Establish a SQL connection using the predefined connection string.
            using (SqlConnection con = new SqlConnection(DbConnection.ConnectionString))
            {
                try
                {
                    // Open the database connection.
                    con.Open();
                    // Define the SQL query to select all transport units, ordered by ID descending.
                    string query = "SELECT * FROM TransportUnits ORDER BY TransportUnitID DESC";
                    // Create a SqlDataAdapter to fill a DataTable with query results.
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    // Create a new DataTable to hold the data.
                    DataTable dt = new DataTable();
                    // Fill the DataTable with data from the database.
                    da.Fill(dt);
                    // Set the DataGridView's data source to the filled DataTable.
                    dgvTransportUnit.DataSource = dt;
                    // Automatically resize all columns to fit their content.
                    dgvTransportUnit.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
                catch (Exception ex)
                {
                    // Display an error message if loading transport units fails.
                    MessageBox.Show("Error loading transport units: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SetupDataGridView()
        {
            // Prevent automatic column generation to manually define them.
            dgvTransportUnit.AutoGenerateColumns = false;
            // Clear any existing columns.
            dgvTransportUnit.Columns.Clear();

            // Add columns for Transport Units table with specific names, headers, and data property bindings.
            // Transport Unit ID column setup.
            dgvTransportUnit.Columns.Add("TransportUnitID", "Unit ID");
            dgvTransportUnit.Columns["TransportUnitID"].DataPropertyName = "TransportUnitID";
            dgvTransportUnit.Columns["TransportUnitID"].ReadOnly = true;
            dgvTransportUnit.Columns["TransportUnitID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Lorry Number Plate column setup.
            dgvTransportUnit.Columns.Add("LorryNumberPlate", "Lorry Plate");
            dgvTransportUnit.Columns["LorryNumberPlate"].DataPropertyName = "LorryNumberPlate";
            dgvTransportUnit.Columns["LorryNumberPlate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Lorry Model column setup.
            dgvTransportUnit.Columns.Add("LorryModel", "Model");
            dgvTransportUnit.Columns["LorryModel"].DataPropertyName = "LorryModel";
            dgvTransportUnit.Columns["LorryModel"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Lorry Capacity column setup.
            dgvTransportUnit.Columns.Add("LorryCapacity", "Capacity");
            dgvTransportUnit.Columns["LorryCapacity"].DataPropertyName = "LorryCapacity";
            dgvTransportUnit.Columns["LorryCapacity"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Driver Name column setup.
            dgvTransportUnit.Columns.Add("DriverName", "Driver");
            dgvTransportUnit.Columns["DriverName"].DataPropertyName = "DriverName";
            dgvTransportUnit.Columns["DriverName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Driver NIC column setup.
            dgvTransportUnit.Columns.Add("DriverNIC", "Driver NIC");
            dgvTransportUnit.Columns["DriverNIC"].DataPropertyName = "DriverNIC";
            dgvTransportUnit.Columns["DriverNIC"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Driver Contact column setup.
            dgvTransportUnit.Columns.Add("DriverContact", "Driver Contact");
            dgvTransportUnit.Columns["DriverContact"].DataPropertyName = "DriverContact";
            dgvTransportUnit.Columns["DriverContact"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Assistant Name column setup.
            dgvTransportUnit.Columns.Add("AssistantName", "Assistant");
            dgvTransportUnit.Columns["AssistantName"].DataPropertyName = "AssistantName";
            dgvTransportUnit.Columns["AssistantName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Assistant Contact column setup.
            dgvTransportUnit.Columns.Add("AssistantContact", "Assistant Contact");
            dgvTransportUnit.Columns["AssistantContact"].DataPropertyName = "AssistantContact";
            dgvTransportUnit.Columns["AssistantContact"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Container Number column setup.
            dgvTransportUnit.Columns.Add("ContainerNumber", "Container No.");
            dgvTransportUnit.Columns["ContainerNumber"].DataPropertyName = "ContainerNumber";
            dgvTransportUnit.Columns["ContainerNumber"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Container Size column setup.
            dgvTransportUnit.Columns.Add("ContainerSize", "Container Size");
            dgvTransportUnit.Columns["ContainerSize"].DataPropertyName = "ContainerSize";
            dgvTransportUnit.Columns["ContainerSize"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Container Condition column setup.
            dgvTransportUnit.Columns.Add("ContainerCondition", "Container Condition");
            dgvTransportUnit.Columns["ContainerCondition"].DataPropertyName = "ContainerCondition";
            dgvTransportUnit.Columns["ContainerCondition"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Is Available column setup.
            dgvTransportUnit.Columns.Add("IsAvailable", "Available?");
            dgvTransportUnit.Columns["IsAvailable"].DataPropertyName = "IsAvailable";
            dgvTransportUnit.Columns["IsAvailable"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Make the entire DataGridView read-only to prevent direct editing.
            dgvTransportUnit.ReadOnly = true;
            // Disable adding new rows via the UI.
            dgvTransportUnit.AllowUserToAddRows = false;
            // Disable deleting rows via the UI.
            dgvTransportUnit.AllowUserToDeleteRows = false;
            // Allow full row selection when clicking a cell.
            dgvTransportUnit.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


        }

        private void Home_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Home form.
            frmHome home = new frmHome();
            // Show the Home form.
            home.Show();
            // Hide the current form.
            this.Hide();
        }

        private void tsmMain_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Main Admin form.
            frmMainAdmin mainAdmin = new frmMainAdmin();
            // Show the Main Admin form.
            mainAdmin.Show();
            // Hide the current form.
            this.Hide();
        }

        private void tsmCustomer_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Customer form.
            frmCustomer customer = new frmCustomer();
            // Show the Customer form.
            customer.Show();
            // Hide the current form.
            this.Hide();
        }

        private void tsmJob_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Job form.
            frmJob job = new frmJob();
            // Show the Job form.
            job.Show();
            // Hide the current form.
            this.Hide();
        }

        private void tsmLoad_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Load form.
            frmLoad load = new frmLoad();
            // Show the Load form.
            load.Show();
            // Hide the current form.
            this.Hide();
        }

        private void tsmTransportUnit_Click(object sender, EventArgs e)
        {
            // Event handler for clicking the Transport Unit menu item (currently empty, likely because it's the current form).
        }

        private void tsmInvoice_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Invoice form.
            frmInvoice invoice = new frmInvoice();
            // Show the Invoice form.
            invoice.Show();
            // Hide the current form.
            this.Hide();
        }

        private void tsmDashboard_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Admin Dashboard form.
            frmAdminDashboard adminDashboard = new frmAdminDashboard();
            // Show the Admin Dashboard form.
            adminDashboard.Show();
            // Hide the current form.
            this.Hide();
        }

        private void tsmAdminManagement_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Admin Management form.
            frmAdminManagement adminManagement = new frmAdminManagement();
            // Show the Admin Management form.
            adminManagement.Show();
            // Hide the current form.
            this.Hide();
        }

        private void tsmReports_Click(object sender, EventArgs e)
        {
            // Event handler for clicking the Reports menu item (currently empty, likely a parent menu).
        }

        private void tsmCustomerTheirJobs_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Customer And Their Jobs Report form.
            frmCustomerAndTheirJobsReport customerAndTheirJobsReport = new frmCustomerAndTheirJobsReport();
            // Show the report form.
            customerAndTheirJobsReport.Show();
            // Hide the current form.
            this.Hide();
        }

        private void tsmJobsByDateRange_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Jobs By Date Range Report form.
            frmJobsByDateRangeReport jobsByDateRangeReport = new frmJobsByDateRangeReport();
            // Show the report form.
            jobsByDateRangeReport.Show();
            // Hide the current form.
            this.Hide();
        }

        private void tsmLoadsByTransportUnit_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Loads By Transport Unit Report form.
            frmLoadsByTransportUnitReport loadsByTransportUnitReport = new frmLoadsByTransportUnitReport();
            // Show the report form.
            loadsByTransportUnitReport.Show();
            // Hide the current form.
            this.Hide();
        }

        private void tsmDeliveryPerformance_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Delivery Performance Report form.
            frmDeliveryPerformanceReport deliveryPerformanceReport = new frmDeliveryPerformanceReport();
            // Show the report form.
            deliveryPerformanceReport.Show();
            // Hide the current form.
            this.Hide();
        }

        private void tsmDailyEndOfTheLoads_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Daily End Of The Loads Report form.
            frmDailyEndOfTheLoadsReport dailyEndOfTheLoadsReport = new frmDailyEndOfTheLoadsReport();
            // Show the report form.
            dailyEndOfTheLoadsReport.Show();
            // Hide the current form.
            this.Hide();
        }

        private void lblTransportUnitManagement_Click(object sender, EventArgs e)
        {
            // Event handler for clicking the Transport Unit Management label (currently empty).
        }

        private void lblTransportUnitId_Click(object sender, EventArgs e)
        {
            // Event handler for clicking the Transport Unit ID label (currently empty).
        }

        private void txtTransportUnitId_TextChanged(object sender, EventArgs e)
        {
            // Event handler for text changing in the Transport Unit ID text box (currently empty).
        }

        private void lblLorry_Click(object sender, EventArgs e)
        {
            // Event handler for clicking the Lorry label (currently empty).
        }

        private void frmTransportUnit_Load(object sender, EventArgs e)
        {
            // Reload all transport units into the grid when the form loads.
            LoadTransportUnitsIntoGrid();
        }

        private void lblLorryNumberPlate_Click(object sender, EventArgs e)
        {
            // Event handler for clicking the Lorry Number Plate label (currently empty).
        }

        private void txtLorryNumberPlate_TextChanged(object sender, EventArgs e)
        {
            // Event handler for text changing in the Lorry Number Plate text box (currently empty).
        }

        private void lblLorryModel_Click(object sender, EventArgs e)
        {
            // Event handler for clicking the Lorry Model label (currently empty).
        }

        private void txtLorryModel_TextChanged(object sender, EventArgs e)
        {
            // Event handler for text changing in the Lorry Model text box (currently empty).
        }

        private void lblLorryCapacity_Click(object sender, EventArgs e)
        {
            // Event handler for clicking the Lorry Capacity label (currently empty).
        }

        private void txtLorryCapacity_TextChanged(object sender, EventArgs e)
        {
            // Event handler for text changing in the Lorry Capacity text box (currently empty).
        }

        private void lblAssistant_Click(object sender, EventArgs e)
        {
            // Event handler for clicking the Assistant label (currently empty).
        }

        private void lblAssistantName_Click(object sender, EventArgs e)
        {
            // Event handler for clicking the Assistant Name label (currently empty).
        }

        private void txtAssistantName_TextChanged(object sender, EventArgs e)
        {
            // Event handler for text changing in the Assistant Name text box (currently empty).
        }

        private void lblAssistantContact_Click(object sender, EventArgs e)
        {
            // Event handler for clicking the Assistant Contact label (currently empty).
        }

        private void txtAssistantContact_TextChanged(object sender, EventArgs e)
        {
            // Event handler for text changing in the Assistant Contact text box (currently empty).
        }

        private void lblAssistantAddress_Click(object sender, EventArgs e)
        {
            // Event handler for clicking the Assistant Address label (currently empty).
        }

        private void txtAssistantAddress_TextChanged(object sender, EventArgs e)
        {
            // Event handler for text changing in the Assistant Address text box (currently empty).
        }

        private void lblDriver_Click(object sender, EventArgs e)
        {
            // Event handler for clicking the Driver label (currently empty).
        }

        private void lblDriverName_Click(object sender, EventArgs e)
        {
            // Event handler for clicking the Driver Name label (currently empty).
        }

        private void txtDriverName_TextChanged(object sender, EventArgs e)
        {
            // Event handler for text changing in the Driver Name text box (currently empty).
        }

        private void lblDriverNIC_Click(object sender, EventArgs e)
        {
            // Event handler for clicking the Driver NIC label (currently empty).
        }

        private void txtDriverNIC_TextChanged(object sender, EventArgs e)
        {
            // Event handler for text changing in the Driver NIC text box (currently empty).
        }

        private void lblDriverContact_Click(object sender, EventArgs e)
        {
            // Event handler for clicking the Driver Contact label (currently empty).
        }

        private void txtDriverContact_TextChanged(object sender, EventArgs e)
        {
            // Event handler for text changing in the Driver Contact text box (currently empty).
        }

        private void lblContainer_Click(object sender, EventArgs e)
        {
            // Event handler for clicking the Container label (currently empty).
        }

        private void lblContainerNumber_Click(object sender, EventArgs e)
        {
            // Event handler for clicking the Container Number label (currently empty).
        }

        private void txtContainerNumber_TextChanged(object sender, EventArgs e)
        {
            // Event handler for text changing in the Container Number text box (currently empty).
        }

        private void lblContainerSize_Click(object sender, EventArgs e)
        {
            // Event handler for clicking the Container Size label (currently empty).
        }

        private void txtContainerSize_TextChanged(object sender, EventArgs e)
        {
            // Event handler for text changing in the Container Size text box (currently empty).
        }

        private void lblContainerCondition_Click(object sender, EventArgs e)
        {
            // Event handler for clicking the Container Condition label (currently empty).
        }

        private void cmbContainerCondition_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Event handler for selected index changing in the Container Condition ComboBox (currently empty).
        }

        private void lblIsAvailable_Click(object sender, EventArgs e)
        {
            // Event handler for clicking the Is Available label (currently empty).
        }

        private void cmbIsAvailable_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Event handler for selected index changing in the Is Available ComboBox (currently empty).
        }

        private void dgvTransportUnit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a valid row was clicked (not a header or empty area).
            if (e.RowIndex >= 0)
            {
                // Get the DataGridView row that was clicked.
                DataGridViewRow row = dgvTransportUnit.Rows[e.RowIndex];

                // Populate form fields with data from the selected row.
                txtTransportUnitId.Text = row.Cells["TransportUnitID"].Value.ToString();
                txtLorryNumberPlate.Text = row.Cells["LorryNumberPlate"].Value.ToString();
                txtLorryModel.Text = row.Cells["LorryModel"].Value?.ToString() ?? ""; // Handle potential DBNull
                txtLorryCapacity.Text = row.Cells["LorryCapacity"].Value?.ToString() ?? "";
                txtDriverName.Text = row.Cells["DriverName"].Value.ToString();
                txtDriverNIC.Text = row.Cells["DriverNIC"].Value.ToString();
                txtDriverContact.Text = row.Cells["DriverContact"].Value?.ToString() ?? "";
                txtAssistantName.Text = row.Cells["AssistantName"].Value?.ToString() ?? "";
                txtAssistantContact.Text = row.Cells["AssistantContact"].Value?.ToString() ?? "";
                txtAssistantAddress.Text = row.Cells["AssistantAddress"].Value?.ToString() ?? "";
                txtContainerNumber.Text = row.Cells["ContainerNumber"].Value?.ToString() ?? "";
                txtContainerSize.Text = row.Cells["ContainerSize"].Value?.ToString() ?? "";

                // Set the selected item in the ContainerCondition ComboBox.
                string containerCondition = row.Cells["ContainerCondition"].Value?.ToString() ?? "";
                cmbContainerCondition.SelectedIndex = cmbContainerCondition.FindStringExact(containerCondition);
                // If the condition from the database doesn't exactly match an item, add it or handle.
                if (cmbContainerCondition.SelectedIndex == -1 && !string.IsNullOrEmpty(containerCondition))
                {
                    cmbContainerCondition.Items.Add(containerCondition);
                    cmbContainerCondition.SelectedItem = containerCondition;
                }
                else if (string.IsNullOrEmpty(containerCondition))
                {
                    // Clear selection if database value is empty.
                    cmbContainerCondition.SelectedIndex = -1;
                }

                // Set the selected item in the IsAvailable ComboBox, handling boolean conversion.
                if (row.Cells["IsAvailable"].Value != null)
                {
                    bool isAvailable = Convert.ToBoolean(row.Cells["IsAvailable"].Value);
                    // Iterate through items to find the corresponding boolean value.
                    foreach (ComboBoxItem item in cmbIsAvailable.Items)
                    {
                        if (item.Value is bool boolValue && boolValue == isAvailable)
                        {
                            cmbIsAvailable.SelectedItem = item;
                            break;
                        }
                    }
                }
                else
                {
                    // Clear selection if database value is null/DBNull.
                    cmbIsAvailable.SelectedIndex = -1;
                }
            }
        }

        private void btnSearchTransportunit_Click(object sender, EventArgs e)
        {
            // Attempt to parse the Transport Unit ID from the text box.
            if (int.TryParse(txtTransportUnitId.Text, out int unitId))
            {
                // Call the search method with the parsed ID.
                SearchTransportUnitByID(unitId);
            }
            else
            {
                // Show an error message for invalid input.
                MessageBox.Show("Please enter a valid Transport Unit ID to search.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAddTransportunit_Click(object sender, EventArgs e)
        {
            // Call the method responsible for adding a new transport unit.
            AddTransportUnit();
        }

        private void btnUpdateTransportunit_Click(object sender, EventArgs e)
        {
            // Call the method responsible for updating an existing transport unit.
            UpdateTransportUnit();
        }

        private void btnDeleteTransportunit_Click(object sender, EventArgs e)
        {
            // Call the method responsible for deleting a transport unit.
            DeleteTransportUnit();
        }

        private void btnViewTransportunit_Click(object sender, EventArgs e)
        {
            // Attempt to parse the Transport Unit ID from the text box for viewing details.
            if (int.TryParse(txtTransportUnitId.Text, out int unitId))
            {
                // Call the search method to display the details of the transport unit.
                SearchTransportUnitByID(unitId);
            }
            else
            {
                // Inform the user to enter an ID to view details.
                MessageBox.Show("Please enter a Transport Unit ID in the ID field to view its details.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Call the method to clear all input fields on the form.
            ClearForm();
        }

        private void SearchTransportUnitByID(int unitId)
        {
            // Clear any previously displayed data in the form fields.
            ClearForm();

            // Establish a SQL connection using the predefined connection string.
            using (SqlConnection con = new SqlConnection(DbConnection.ConnectionString))
            {
                try
                {
                    // Open the database connection.
                    con.Open();
                    // Define the SQL query to select a transport unit by its ID.
                    string query = "SELECT * FROM TransportUnits WHERE TransportUnitID = @TransportUnitID";
                    // Create a SqlCommand with the query and connection.
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Add the TransportUnitID parameter to the command to prevent SQL injection.
                        cmd.Parameters.AddWithValue("@TransportUnitID", unitId);
                        // Execute the command and get a SqlDataReader.
                        SqlDataReader reader = cmd.ExecuteReader();

                        // Check if a record was found.
                        if (reader.Read())
                        {
                            // Populate form text boxes with data from the reader.
                            txtTransportUnitId.Text = reader["TransportUnitID"].ToString();
                            txtLorryNumberPlate.Text = reader["LorryNumberPlate"].ToString();
                            txtLorryModel.Text = reader["LorryModel"].ToString();
                            txtLorryCapacity.Text = reader["LorryCapacity"].ToString();
                            txtDriverName.Text = reader["DriverName"].ToString();
                            txtDriverNIC.Text = reader["DriverNIC"].ToString();
                            txtDriverContact.Text = reader["DriverContact"].ToString();
                            txtAssistantName.Text = reader["AssistantName"].ToString();
                            txtAssistantContact.Text = reader["AssistantContact"].ToString();
                            txtAssistantAddress.Text = reader["AssistantAddress"].ToString();
                            txtContainerNumber.Text = reader["ContainerNumber"].ToString();
                            txtContainerSize.Text = reader["ContainerSize"].ToString();

                            // Set the selected item in the ContainerCondition ComboBox based on the database value.
                            string containerCondition = reader["ContainerCondition"].ToString();
                            cmbContainerCondition.SelectedIndex = cmbContainerCondition.FindStringExact(containerCondition);

                            // Set the selected item in the IsAvailable ComboBox based on the boolean value from the database.
                            bool isAvailable = Convert.ToBoolean(reader["IsAvailable"]);
                            cmbIsAvailable.SelectedItem = isAvailable ?
                                new ComboBoxItem("Yes", true) : new ComboBoxItem("No", false); // Find by value

                            // Inform the user that the transport unit was found.
                            MessageBox.Show($"Transport Unit ID: {unitId} found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            // Inform the user if no transport unit was found with the given ID.
                            MessageBox.Show($"No Transport Unit found with ID: {unitId}.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Display an error message if an exception occurs during search.
                    MessageBox.Show("Error searching transport unit: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearForm()
        {
            // Clear the text from all input text boxes.
            txtTransportUnitId.Clear();
            txtLorryNumberPlate.Clear();
            txtLorryModel.Clear();
            txtLorryCapacity.Clear();
            txtDriverName.Clear();
            txtDriverNIC.Clear();
            txtDriverContact.Clear();
            txtAssistantName.Clear();
            txtAssistantContact.Clear();
            txtAssistantAddress.Clear();
            txtContainerNumber.Clear();
            txtContainerSize.Clear();
            // Reset the selected index for ComboBoxes to no selection.
            cmbContainerCondition.SelectedIndex = -1;
            cmbIsAvailable.SelectedIndex = -1;

            // Set focus to the Lorry Number Plate text box for convenience.
            txtLorryNumberPlate.Focus();
        }
        private void AddTransportUnit()
        {
            // 1. Validate inputs to ensure all mandatory fields are filled correctly.
            if (!ValidateInputs()) return;

            // Get values from controls, trimming whitespace and handling potential nulls/conversions for numeric types.
            string lorryNumberPlate = txtLorryNumberPlate.Text.Trim();
            string lorryModel = txtLorryModel.Text.Trim();
            decimal? lorryCapacity = decimal.TryParse(txtLorryCapacity.Text.Trim(), out decimal cap) ? (decimal?)cap : null;
            string driverName = txtDriverName.Text.Trim();
            string driverNIC = txtDriverNIC.Text.Trim();
            string driverContact = txtDriverContact.Text.Trim();
            string assistantName = txtAssistantName.Text.Trim();
            string assistantContact = txtAssistantContact.Text.Trim();
            string assistantAddress = txtAssistantAddress.Text.Trim();
            string containerNumber = txtContainerNumber.Text.Trim();
            string containerSize = txtContainerSize.Text.Trim();
            string containerCondition = cmbContainerCondition.SelectedItem?.ToString();
            // Get the boolean value for availability, defaulting to true if not selected.
            bool isAvailable = (cmbIsAvailable.SelectedItem as ComboBoxItem)?.Value as bool? ?? true;

            // Establish a new SQL connection using the predefined connection string.
            using (SqlConnection con = new SqlConnection(DbConnection.ConnectionString))
            {
                try
                {
                    // Open the database connection.
                    con.Open();
                    // Define the SQL INSERT query with parameters to add a new transport unit.
                    // SELECT SCOPE_IDENTITY() is used to retrieve the ID of the newly inserted row.
                    string query = @"INSERT INTO TransportUnits (LorryNumberPlate, LorryModel, LorryCapacity, 
                                            DriverName, DriverNIC, DriverContact, 
                                            AssistantName, AssistantContact, AssistantAddress, 
                                            ContainerNumber, ContainerSize, ContainerCondition, IsAvailable, CreatedDate)
                               VALUES (@LorryNumberPlate, @LorryModel, @LorryCapacity, 
                                       @DriverName, @DriverNIC, @DriverContact, 
                                       @AssistantName, @AssistantContact, @AssistantAddress, 
                                       @ContainerNumber, @ContainerSize, @ContainerCondition, @IsAvailable, GETDATE());
                               SELECT SCOPE_IDENTITY();"; // Get the newly created ID

                    // Create a SqlCommand object with the query and connection.
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Add parameters to the SQL command, handling DBNull for optional/empty fields.
                        cmd.Parameters.AddWithValue("@LorryNumberPlate", lorryNumberPlate);
                        cmd.Parameters.AddWithValue("@LorryModel", string.IsNullOrWhiteSpace(lorryModel) ? (object)DBNull.Value : lorryModel);
                        cmd.Parameters.AddWithValue("@LorryCapacity", lorryCapacity.HasValue ? (object)lorryCapacity.Value : DBNull.Value);
                        cmd.Parameters.AddWithValue("@DriverName", driverName);
                        cmd.Parameters.AddWithValue("@DriverNIC", driverNIC);
                        cmd.Parameters.AddWithValue("@DriverContact", string.IsNullOrWhiteSpace(driverContact) ? (object)DBNull.Value : driverContact);
                        cmd.Parameters.AddWithValue("@AssistantName", string.IsNullOrWhiteSpace(assistantName) ? (object)DBNull.Value : assistantName);
                        cmd.Parameters.AddWithValue("@AssistantContact", string.IsNullOrWhiteSpace(assistantContact) ? (object)DBNull.Value : assistantContact);
                        cmd.Parameters.AddWithValue("@AssistantAddress", string.IsNullOrWhiteSpace(assistantAddress) ? (object)DBNull.Value : assistantAddress);
                        cmd.Parameters.AddWithValue("@ContainerNumber", string.IsNullOrWhiteSpace(containerNumber) ? (object)DBNull.Value : containerNumber);
                        cmd.Parameters.AddWithValue("@ContainerSize", string.IsNullOrWhiteSpace(containerSize) ? (object)DBNull.Value : containerSize);
                        cmd.Parameters.AddWithValue("@ContainerCondition", string.IsNullOrWhiteSpace(containerCondition) ? (object)DBNull.Value : containerCondition);
                        cmd.Parameters.AddWithValue("@IsAvailable", isAvailable);

                        // Execute the query and retrieve the new Transport Unit ID.
                        int newUnitId = Convert.ToInt32(cmd.ExecuteScalar());

                        // Display a success message with the new ID.
                        MessageBox.Show($"Transport Unit added successfully! New Unit ID: {newUnitId}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Clear the form fields.
                        ClearForm();
                        // Reload and refresh the DataGridView to show the new unit.
                        LoadTransportUnitsIntoGrid();
                    }
                }
                catch (SqlException ex)
                {
                    // Catch specific SQL exceptions.
                    if (ex.Number == 2627) // Unique constraint violation (e.g., LorryNumberPlate, DriverNIC already exists)
                    {
                        // Inform the user about duplicate entries.
                        MessageBox.Show("Duplicate entry detected. Lorry Number Plate or Driver NIC might already exist.", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // Handle other database-related errors.
                        MessageBox.Show("Database error adding transport unit: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // Catch any other unexpected errors.
                    MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateTransportUnit()
        {
            // 1. Validate that a TransportUnitID is entered or selected for update.
            if (!int.TryParse(txtTransportUnitId.Text, out int unitId) || unitId <= 0)
            {
                MessageBox.Show("Please select a Transport Unit from the grid or enter a valid ID to update.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Validate other input fields using the common validation method.
            if (!ValidateInputs()) return;

            // Get updated values from controls, trimming whitespace and handling conversions.
            string lorryNumberPlate = txtLorryNumberPlate.Text.Trim();
            string lorryModel = txtLorryModel.Text.Trim();
            decimal? lorryCapacity = decimal.TryParse(txtLorryCapacity.Text.Trim(), out decimal cap) ? (decimal?)cap : null;
            string driverName = txtDriverName.Text.Trim();
            string driverNIC = txtDriverNIC.Text.Trim();
            string driverContact = txtDriverContact.Text.Trim();
            string assistantName = txtAssistantName.Text.Trim();
            string assistantContact = txtAssistantContact.Text.Trim();
            string assistantAddress = txtAssistantAddress.Text.Trim();
            string containerNumber = txtContainerNumber.Text.Trim();
            string containerSize = txtContainerSize.Text.Trim();
            string containerCondition = cmbContainerCondition.SelectedItem?.ToString();
            bool isAvailable = (cmbIsAvailable.SelectedItem as ComboBoxItem)?.Value as bool? ?? true;

            // Establish a new SQL connection.
            using (SqlConnection con = new SqlConnection(DbConnection.ConnectionString))
            {
                try
                {
                    // Open the database connection.
                    con.Open();
                    // Define the SQL UPDATE query with parameters to modify an existing transport unit.
                    string query = @"UPDATE TransportUnits SET 
                                LorryNumberPlate = @LorryNumberPlate, 
                                LorryModel = @LorryModel, 
                                LorryCapacity = @LorryCapacity, 
                                DriverName = @DriverName, 
                                DriverNIC = @DriverNIC, 
                                DriverContact = @DriverContact, 
                                AssistantName = @AssistantName, 
                                AssistantContact = @AssistantContact, 
                                AssistantAddress = @AssistantAddress, 
                                ContainerNumber = @ContainerNumber, 
                                ContainerSize = @ContainerSize, 
                                ContainerCondition = @ContainerCondition, 
                                IsAvailable = @IsAvailable,
                                LastModifiedDate = GETDATE()
                             WHERE TransportUnitID = @TransportUnitID";

                    // Create a SqlCommand object with the query and connection.
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Add parameters to the SQL command, handling DBNull for optional/empty fields.
                        cmd.Parameters.AddWithValue("@LorryNumberPlate", lorryNumberPlate);
                        cmd.Parameters.AddWithValue("@LorryModel", string.IsNullOrWhiteSpace(lorryModel) ? (object)DBNull.Value : lorryModel);
                        cmd.Parameters.AddWithValue("@LorryCapacity", lorryCapacity.HasValue ? (object)lorryCapacity.Value : DBNull.Value);
                        cmd.Parameters.AddWithValue("@DriverName", driverName);
                        cmd.Parameters.AddWithValue("@DriverNIC", driverNIC);
                        cmd.Parameters.AddWithValue("@DriverContact", string.IsNullOrWhiteSpace(driverContact) ? (object)DBNull.Value : driverContact);
                        cmd.Parameters.AddWithValue("@AssistantName", string.IsNullOrWhiteSpace(assistantName) ? (object)DBNull.Value : assistantName);
                        cmd.Parameters.AddWithValue("@AssistantContact", string.IsNullOrWhiteSpace(assistantContact) ? (object)DBNull.Value : assistantContact);
                        cmd.Parameters.AddWithValue("@AssistantAddress", string.IsNullOrWhiteSpace(assistantAddress) ? (object)DBNull.Value : assistantAddress);
                        cmd.Parameters.AddWithValue("@ContainerNumber", string.IsNullOrWhiteSpace(containerNumber) ? (object)DBNull.Value : containerNumber);
                        cmd.Parameters.AddWithValue("@ContainerSize", string.IsNullOrWhiteSpace(containerSize) ? (object)DBNull.Value : containerSize);
                        cmd.Parameters.AddWithValue("@ContainerCondition", string.IsNullOrWhiteSpace(containerCondition) ? (object)DBNull.Value : containerCondition);
                        cmd.Parameters.AddWithValue("@IsAvailable", isAvailable);
                        cmd.Parameters.AddWithValue("@TransportUnitID", unitId); // Parameter for the WHERE clause

                        // Execute the update query and get the number of rows affected.
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Check if the update was successful.
                        if (rowsAffected > 0)
                        {
                            // Display a success message.
                            MessageBox.Show("Transport Unit updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Clear the form fields.
                            ClearForm();
                            // Refresh the DataGridView to show updated data.
                            LoadTransportUnitsIntoGrid();
                        }
                        else
                        {
                            // Inform the user if the unit was not found or no changes were made.
                            MessageBox.Show("Transport Unit not found or no changes made.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    // Handle specific SQL exceptions, like unique constraint violations.
                    if (ex.Number == 2627) // Unique constraint violation (e.g., LorryNumberPlate, DriverNIC already exists)
                    {
                        MessageBox.Show("Duplicate entry detected. Lorry Number Plate or Driver NIC might already exist for another unit.", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // Handle other database-related errors during update.
                        MessageBox.Show("Database error updating transport unit: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // Catch any other unexpected errors.
                    MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DeleteTransportUnit()
        {
            // Validate that a TransportUnitID is entered or selected for deletion.
            if (!int.TryParse(txtTransportUnitId.Text, out int unitId) || unitId <= 0)
            {
                MessageBox.Show("Please select a Transport Unit from the grid or enter a valid ID to delete.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ask for user confirmation before proceeding with deletion.
            DialogResult confirm = MessageBox.Show($"Are you sure you want to delete Transport Unit ID: {unitId}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Proceed only if the user confirms.
            if (confirm == DialogResult.Yes)
            {
                // Establish a new SQL connection.
                using (SqlConnection con = new SqlConnection(DbConnection.ConnectionString))
                {
                    try
                    {
                        // Open the database connection.
                        con.Open();
                        // Define the SQL DELETE query with a parameter for the unit ID.
                        string query = "DELETE FROM TransportUnits WHERE TransportUnitID = @TransportUnitID";
                        // Create a SqlCommand object.
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            // Add the TransportUnitID parameter.
                            cmd.Parameters.AddWithValue("@TransportUnitID", unitId);
                            // Execute the delete query and get the number of rows affected.
                            int rowsAffected = cmd.ExecuteNonQuery();

                            // Check if the deletion was successful.
                            if (rowsAffected > 0)
                            {
                                // Display a success message.
                                MessageBox.Show("Transport Unit deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // Clear the form fields.
                                ClearForm();
                                // Refresh the DataGridView to reflect the deletion.
                                LoadTransportUnitsIntoGrid();
                            }
                            else
                            {
                                // Inform the user if the unit was not found.
                                MessageBox.Show("Transport Unit not found.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        // Handle specific SQL exceptions, like foreign key constraint violations.
                        if (ex.Number == 547) // Foreign Key constraint violation
                        {
                            // Inform the user if the unit cannot be deleted due to linked records.
                            MessageBox.Show("Cannot delete this Transport Unit because it is currently linked to existing loads or jobs. Please unlink it first.", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            // Handle other database-related errors during deletion.
                            MessageBox.Show("Database error deleting transport unit: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Catch any other unexpected errors.
                        MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        // --- Validation ---
        private bool ValidateInputs()
        {
            // Check for mandatory fields and display warnings if they are empty.
            if (string.IsNullOrWhiteSpace(txtLorryNumberPlate.Text))
            {
                MessageBox.Show("Lorry Number Plate is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLorryNumberPlate.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDriverName.Text))
            {
                MessageBox.Show("Driver Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDriverName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDriverNIC.Text))
            {
                MessageBox.Show("Driver NIC is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDriverNIC.Focus();
                return false;
            }
            if (cmbIsAvailable.SelectedItem == null)
            {
                MessageBox.Show("Availability status is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbIsAvailable.Focus();
                return false;
            }

            // Validate Lorry Capacity to ensure it's a valid number if entered.
            if (!string.IsNullOrWhiteSpace(txtLorryCapacity.Text) && !decimal.TryParse(txtLorryCapacity.Text, out _))
            {
                MessageBox.Show("Lorry Capacity must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLorryCapacity.Focus();
                return false;
            }

            // Optional: Add regex for contact numbers, NIC, etc. if needed
            // If all validations pass, return true.
            return true;
        }
    }
}
