using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net; // Used for hashing passwords
using System.IO;// Used for file operations
using System.Data.SqlClient;// Used for interacting with SQL Server database

namespace E_Shift
{
    // Represents the Customer Management form
    public partial class frmCustomer : Form
    {

        // Stores the file path of the selected photo for upload or display
        private string _selectedPhotoPath = null;

        // Stores the ID of the currently selected customer from the data grid
        private int _selectedCustomerId = -1;
        private object customerId; // This variable seems to be a remnant or unused

        // Constructor for the frmCustomer form
        public frmCustomer()
        {
            InitializeComponent(); // Initializes the form components (controls)

            SetupDataGridView(); // Configures the DataGridView columns
            LoadCustomersIntoGrid(""); // Loads all customer data into the grid upon form initialization

            txtCustomerId.ReadOnly = false; // Makes the Customer ID text box editable (though often read-only for new entries)
        }

        private void LoadCustomersIntoGrid(string searchTerm = "", bool searchById = false) // Reverting to simpler parameters
        {
            // Establishes a connection to the database using the connection string from DbConnection class
            using (SqlConnection con = new SqlConnection(DbConnection.ConnectionString)) // Assuming DbConnection.ConnectionString is still available
            {
                try
                {
                    con.Open(); // Opens the database connection
                    // Base SQL query to select all customer details
                    string query = "SELECT CustomerID, Name, Email, ContactNumber, Address, PhotoPath, Username FROM Customers";

                    SqlCommand cmd; // Declares a SqlCommand object

                    // Checks if a search term is provided
                    if (!string.IsNullOrWhiteSpace(searchTerm))
                    {
                        if (searchById) // If searching by Customer ID
                        {
                            query += " WHERE CustomerID = @SearchTerm"; // Appends WHERE clause for ID search
                            cmd = new SqlCommand(query, con); // Creates a new command with the query and connection
                            // Adds parameter for CustomerID, converting searchTerm to int
                            cmd.Parameters.AddWithValue("@SearchTerm", int.Parse(searchTerm));
                        }
                        else // If searching by Username or Name
                        {
                            query += " WHERE Username LIKE @SearchTerm OR Name LIKE @SearchTerm"; // Appends WHERE clause for text search
                            cmd = new SqlCommand(query, con); // Creates a new command
                            // Adds parameter for search term, using '%' for partial matching
                            cmd.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
                        }
                    }
                    else
                    {
                        // No search term, so the query remains to load all customers
                        cmd = new SqlCommand(query, con);
                    }

                    SqlDataAdapter da = new SqlDataAdapter(cmd); // Creates a data adapter to fill a DataTable
                    DataTable dt = new DataTable(); // Creates a new DataTable to hold the results
                    da.Fill(dt); // Fills the DataTable with data from the query

                    dgvCustomer.DataSource = dt; // Sets the DataTable as the data source for the DataGridView
                }
                catch (Exception ex)
                {
                    // Displays an error message if data loading fails
                    MessageBox.Show("Error loading customer data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void SetupDataGridView()
        {
            dgvCustomer.AutoGenerateColumns = false; // Prevents automatic column generation

            dgvCustomer.Columns.Clear(); // Clears any pre-existing columns

            // Defines and adds columns to the DataGridView, mapping them to database column names
            dgvCustomer.Columns.Add("CustomerID", "Customer ID");
            dgvCustomer.Columns["CustomerID"].DataPropertyName = "CustomerID";
            dgvCustomer.Columns["CustomerID"].ReadOnly = true; // Makes Customer ID column read-only

            dgvCustomer.Columns.Add("Name", "Name");
            dgvCustomer.Columns["Name"].DataPropertyName = "Name";

            dgvCustomer.Columns.Add("Email", "Email");
            dgvCustomer.Columns["Email"].DataPropertyName = "Email";

            dgvCustomer.Columns.Add("ContactNumber", "Contact No.");
            dgvCustomer.Columns["ContactNumber"].DataPropertyName = "ContactNumber";

            dgvCustomer.Columns.Add("Address", "Address");
            dgvCustomer.Columns["Address"].DataPropertyName = "Address";

            dgvCustomer.Columns.Add("Username", "Username");
            dgvCustomer.Columns["Username"].DataPropertyName = "Username";

            dgvCustomer.Columns.Add("PhotoPath", "PhotoPath");
            dgvCustomer.Columns["PhotoPath"].DataPropertyName = "PhotoPath";
            dgvCustomer.Columns["PhotoPath"].Visible = false; // Hides the PhotoPath column from the user

            dgvCustomer.ReadOnly = true; // Makes the entire DataGridView read-only
            dgvCustomer.AllowUserToAddRows = false; // Prevents users from adding new rows directly in the grid
            dgvCustomer.AllowUserToDeleteRows = false; // Prevents users from deleting rows directly in the grid
            dgvCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Configures selection to highlight entire rows
        }

        // Event handler for the "Home" menu item click
        private void Home_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome(); // Creates a new instance of the Home form
            home.Show(); // Displays the Home form
            this.Hide(); // Hides the current form
        }

        // Event handler for the "Main Admin" menu item click
        private void tsmMain_Click(object sender, EventArgs e)
        {
            frmMainAdmin admin = new frmMainAdmin(); // Creates a new instance of the Main Admin form
            admin.Show(); // Displays the Main Admin form
            this.Hide(); // Hides the current form
        }

        // Event handler for the "Customer" menu item click (currently empty, implies this is the current form)
        private void tsmCustomer_Click(object sender, EventArgs e)
        {
            // No action needed as this is likely the current form.
        }

        // Event handler for the "Job" menu item click
        private void tsmJob_Click(object sender, EventArgs e)
        {
            frmJob job = new frmJob(); // Creates a new instance of the Job form
            job.Show(); // Displays the Job form
            this.Hide(); // Hides the current form
        }

        // Event handler for the "Load" menu item click
        private void tsmLoad_Click(object sender, EventArgs e)
        {
            frmLoad load = new frmLoad(); // Creates a new instance of the Load form
            load.Show(); // Displays the Load form
            this.Hide(); // Hides the current form
        }

        // Event handler for the "Transport Unit" menu item click
        private void tsmTransportUnit_Click(object sender, EventArgs e)
        {
            frmTransportUnit transportUnit = new frmTransportUnit(); // Creates a new instance of the Transport Unit form
            transportUnit.Show(); // Displays the Transport Unit form
            this.Hide(); // Hides the current form
        }

        // Event handler for the "Invoice" menu item click
        private void tsmInvoice_Click(object sender, EventArgs e)
        {
            frmInvoice invoice = new frmInvoice(); // Creates a new instance of the Invoice form
            invoice.Show(); // Displays the Invoice form
            this.Hide(); // Hides the current form
        }

        // Event handler for the "Dashboard" menu item click (Admin Dashboard)
        private void tsmDashboard_Click(object sender, EventArgs e)
        {
            frmAdminDashboard adminDashboard = new frmAdminDashboard(); // Creates a new instance of the Admin Dashboard form
            adminDashboard.Show(); // Displays the Admin Dashboard form
            this.Hide(); // Hides the current form
        }

        // Event handler for the "Admin Management" menu item click
        private void tsmAdminManagement_Click(object sender, EventArgs e)
        {
            frmAdminManagement adminManagement = new frmAdminManagement(); // Creates a new instance of the Admin Management form
            adminManagement.Show(); // Displays the Admin Management form
            this.Hide(); // Hides the current form
        }

        // Event handler for the "Reports" menu item click (currently empty, likely a parent menu item)
        private void tsmReports_Click(object sender, EventArgs e)
        {
            // No direct action as this is likely a parent menu item for various reports.
        }

        // Event handler for the "Customer and Their Jobs" report menu item click
        private void tsmCustomerTheirJobs_Click(object sender, EventArgs e)
        {
            frmCustomerAndTheirJobsReport customerAndTheirJobsReport = new frmCustomerAndTheirJobsReport(); // Creates a new instance of the Customer and Their Jobs Report form
            customerAndTheirJobsReport.Show(); // Displays the report form
            this.Hide(); // Hides the current form
        }

        // Event handler for the "Jobs By Date Range" report menu item click
        private void tsmJobsByDateRange_Click(object sender, EventArgs e)
        {
            frmJobsByDateRangeReport jobsByDateRangeReport = new frmJobsByDateRangeReport(); // Creates a new instance of the Jobs By Date Range Report form
            jobsByDateRangeReport.Show(); // Displays the report form
            this.Hide(); // Hides the current form
        }

        // Event handler for the "Loads By Transport Unit" report menu item click
        private void tsmLoadsByTransportUnit_Click(object sender, EventArgs e)
        {
            frmLoadsByTransportUnitReport loadsByTransportUnitReport = new frmLoadsByTransportUnitReport(); // Creates a new instance of the Loads By Transport Unit Report form
            loadsByTransportUnitReport.Show(); // Displays the report form
            this.Hide(); // Hides the current form
        }

        // Event handler for the "Delivery Performance" report menu item click
        private void tsmDeliveryPerformance_Click(object sender, EventArgs e)
        {
            frmDeliveryPerformanceReport deliveryPerformanceReport = new frmDeliveryPerformanceReport(); // Creates a new instance of the Delivery Performance Report form
            deliveryPerformanceReport.Show(); // Displays the report form
            this.Hide(); // Hides the current form
        }

        // Event handler for the "Daily End Of The Loads" report menu item click
        private void tsmDailyEndOfTheLoads_Click(object sender, EventArgs e)
        {
            frmDailyEndOfTheLoadsReport dailyEndOfTheLoadsReport = new frmDailyEndOfTheLoadsReport(); // Creates a new instance of the Daily End Of The Loads Report form
            dailyEndOfTheLoadsReport.Show(); // Displays the report form
            this.Hide(); // Hides the current form
        }

        // Event handler for the "Customer Management" label click (currently empty)
        private void lblCustomerManagement_Click(object sender, EventArgs e)
        {
            // No specific action defined for this label click.
        }

        // Event handler for the "Customer ID" label click (currently empty)
        private void lblCustomerId_Click(object sender, EventArgs e)
        {
            // No specific action defined for this label click.
        }

        // Event handler for the frmCustomer form loading event
        private void frmCustomer_Load(object sender, EventArgs e)
        {
            LoadCustomersIntoGrid(""); // Reloads all customer data when the form loads
        }

        // Event handler for the Customer ID text box text changed event (currently empty)
        private void txtCustomerId_TextChanged(object sender, EventArgs e)
        {
            // No specific action defined when Customer ID text changes.
        }

        // Event handler for the "Username" label click (currently empty)
        private void lblUsername_Click(object sender, EventArgs e)
        {
            // No specific action defined for this label click.
        }

        // Event handler for the Username text box text changed event (currently empty)
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            // No specific action defined when Username text changes.
        }

        // Event handler for the "Name" label click (currently empty)
        private void lblName_Click(object sender, EventArgs e)
        {
            // No specific action defined for this label click.
        }

        // Event handler for the Name text box text changed event (currently empty)
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            // No specific action defined when Name text changes.
        }

        // Event handler for the "Email" label click (currently empty)
        private void lblEmail_Click(object sender, EventArgs e)
        {
            // No specific action defined for this label click.
        }

        // Event handler for the Email text box text changed event (currently empty)
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            // No specific action defined when Email text changes.
        }

        // Event handler for the "Contact Number" label click (currently empty)
        private void lblContactNumber_Click(object sender, EventArgs e)
        {
            // No specific action defined for this label click.
        }

        // Event handler for the Contact Number text box text changed event (currently empty)
        private void txtContactNumber_TextChanged(object sender, EventArgs e)
        {
            // No specific action defined when Contact Number text changes.
        }

        // Event handler for the "Address" label click (currently empty)
        private void lblAddress_Click(object sender, EventArgs e)
        {
            // No specific action defined for this label click.
        }

        // Event handler for the Address text box text changed event (currently empty)
        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            // No specific action defined when Address text changes.
        }

        // Event handler for the "Photo" label click (currently empty)
        private void lblPhoto_Click(object sender, EventArgs e)
        {
            // No specific action defined for this label click.
        }

        // Event handler for the "Upload Photo" button click
        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog(); // Creates a new OpenFileDialog instance
            // Sets the filter to allow selection of common image file types
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK) // If the user selects a file and clicks OK
            {
                _selectedPhotoPath = openFileDialog.FileName; // Stores the selected file's full path
                try
                {
                    // Loads the selected image into the PictureBox
                    picUploadedPhoto.Image = Image.FromFile(_selectedPhotoPath);
                    // Sets the PictureBox size mode to zoom the image to fit
                    picUploadedPhoto.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch (Exception ex)
                {
                    // Displays an error if image loading fails
                    MessageBox.Show("Error loading image: " + ex.Message, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _selectedPhotoPath = null; // Resets the photo path on error
                }
            }
        }

        // Event handler for the PictureBox click (currently empty)
        private void picUploadedPhoto_Click(object sender, EventArgs e)
        {
            // No specific action defined for PictureBox click.
        }

        // Event handler for clicking a cell within the dgvCustomer DataGridView
        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensures a valid data row (not header row) was clicked
            {
                DataGridViewRow row = dgvCustomer.Rows[e.RowIndex]; // Gets the clicked row
                // Retrieves the CustomerID from the clicked row and converts it to an integer
                int customerId = Convert.ToInt32(row.Cells["CustomerID"].Value);
                LoadCustomerDetails(customerId); // Calls a method to load full details into form fields
            }
        }

        // Event handler for the "Search Customer" button click
        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            // Do NOT ClearFormFields() here if the search is meant to only populate the DGV.
            // The details form should be cleared by the 'View' button or DGV click.

            string searchKeyword = "";
            int idToSearch = 0;
            bool searchById = false;

            // Prioritizes search by CustomerID if something is entered there and is a valid integer
            if (!string.IsNullOrWhiteSpace(txtCustomerId.Text) && int.TryParse(txtCustomerId.Text, out idToSearch))
            {
                searchById = true; // Sets flag to search by ID
                searchKeyword = idToSearch.ToString(); // Sets the search keyword to the ID
                                                       // Note: For ID search, the other fields (Username, Name) will be ignored here.
            }
            else if (!string.IsNullOrWhiteSpace(txtUsername.Text)) // If CustomerID is empty/invalid, checks Username field
            {
                searchKeyword = txtUsername.Text.Trim(); // Uses Username as search keyword
                searchById = false; // Important: ensure this is false for non-ID search
            }
            else if (!string.IsNullOrWhiteSpace(txtName.Text)) // If Username is also empty, checks Name field
            {
                searchKeyword = txtName.Text.Trim(); // Uses Name as search keyword
                searchById = false; // Important: ensure this is false for non-ID search
            }
            else // If all search fields are empty
            {
                // Prompts the user to enter a search term
                MessageBox.Show("Please enter Customer ID, Username, or Name to search.", "Search Input", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCustomersIntoGrid(""); // Calls LoadCustomersIntoGrid with no search term to load all customers
                return; // Exits the method
            }

            // Calls the LoadCustomersIntoGrid method which now handles both ID and text searches
            LoadCustomersIntoGrid(searchKeyword, searchById);

            // After a search, you might want to auto-select the first row if only one result,
            // or just leave the DGV populated for the user to click 'View' or double-click.
            if (dgvCustomer.Rows.Count > 0) // If any results were found
            {
                // Informs the user about the number of results and how to view details
                MessageBox.Show($"{dgvCustomer.Rows.Count} customer(s) found. Select a row and click 'View' to see details.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvCustomer.Rows[0].Selected = true; // Auto-selects the first row
                dgvCustomer.CurrentCell = dgvCustomer.Rows[0].Cells[0]; // Sets focus to the first cell of the first row
            }
            else // If no results were found
            {
                // Informs the user that no matching customers were found
                MessageBox.Show("No customers found matching your search criteria.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // No need to ClearFormFields here, as this button only affects the DGV.
            }
        }

        private void ClearFormFields()
        {
            _selectedCustomerId = -1; // Resets the selected customer ID to indicate no customer is selected
            _selectedPhotoPath = null; // Resets the photo path when clearing the form

            // Clears text from all input text boxes
            txtCustomerId.Clear();
            txtUsername.Clear();
            txtName.Clear();
            txtEmail.Clear();
            txtContactNumber.Clear();
            txtAddress.Clear();
            picUploadedPhoto.Image = null; // Clears the image from the PictureBox

            dgvCustomer.ClearSelection(); // Clears any selected rows in the DataGridView
            dgvCustomer.CurrentCell = null; // Removes focus from any cell in the DataGridView
        }

        // Event handler for the "Add Customer" button click
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            // Reset _selectedCustomerId to -1 to indicate 'Add' mode
            _selectedCustomerId = -1;
            txtCustomerId.Clear(); // Clear the ID field for new entry

            // Retrieves data from form input fields
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string contactNumber = txtContactNumber.Text.Trim();
            string address = txtAddress.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = "DefaultPassword123"; // Placeholder. Consider dedicated password fields for security.

            // Performs basic validation to ensure required fields are not empty
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in Name, Email, Username, and Password for the new customer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exits if validation fails
            }

            // Hashes the password using BCrypt for security before storing
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            string photoDbPath = null; // Variable to store the path of the photo in the database
            if (_selectedPhotoPath != null) // Checks if a photo was selected for upload
            {
                try
                {
                    // Defines the directory where customer photos will be stored
                    string photosDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CustomerPhotos");
                    if (!Directory.Exists(photosDirectory)) // Creates the directory if it doesn't exist
                    {
                        Directory.CreateDirectory(photosDirectory);
                    }

                    // Generates a unique file name for the photo to prevent conflicts
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(_selectedPhotoPath);
                    string destinationPath = Path.Combine(photosDirectory, fileName); // Defines the full destination path
                    File.Copy(_selectedPhotoPath, destinationPath, true); // Copies the selected photo to the destination
                    photoDbPath = "CustomerPhotos\\" + fileName; // Stores the relative path for the database
                }
                catch (Exception ex)
                {
                    // Displays an error if photo upload fails
                    MessageBox.Show("Error uploading photo: " + ex.Message, "Photo Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    photoDbPath = null; // Resets photoDbPath on error
                }
            }

            // Establishes a database connection
            using (SqlConnection con = new SqlConnection(DbConnection.ConnectionString))
            {
                try
                {
                    con.Open(); // Opens the connection
                    // SQL query to insert new customer data into the Customers table
                    string query = "INSERT INTO Customers (Name, Email, ContactNumber, Address, PhotoPath, Username, Password) " +
                                   "VALUES (@Name, @Email, @ContactNumber, @Address, @PhotoPath, @Username, @Password)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Adds parameters to the SQL command to prevent SQL injection
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Email", email);
                        // Handles nullable fields: if empty, inserts DBNull.Value
                        cmd.Parameters.AddWithValue("@ContactNumber", string.IsNullOrEmpty(contactNumber) ? (object)DBNull.Value : contactNumber);
                        cmd.Parameters.AddWithValue("@Address", string.IsNullOrEmpty(address) ? (object)DBNull.Value : address);
                        cmd.Parameters.AddWithValue("@PhotoPath", string.IsNullOrEmpty(photoDbPath) ? (object)DBNull.Value : photoDbPath);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", hashedPassword);

                        cmd.ExecuteNonQuery(); // Executes the SQL INSERT command
                        MessageBox.Show("New customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFormFields(); // Clears the form fields after successful addition
                        LoadCustomersIntoGrid(""); // Refreshes the customer data in the grid
                    }
                }
                catch (SqlException ex) // Catches specific SQL exceptions
                {
                    if (ex.Number == 2627) // Error number for unique constraint violation
                    {
                        // Checks if the unique constraint violation is for Email or Username
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
                        // Displays a generic database error for other SQL exceptions
                        MessageBox.Show("Database error adding customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex) // Catches any other unexpected exceptions
                {
                    MessageBox.Show("An unexpected error occurred while adding customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Event handler for the "Update Customer Details" button click
        private void btnUpdateCustomerDetails_Click(object sender, EventArgs e)
        {
            if (_selectedCustomerId == -1) // Checks if a customer is selected for update
            {
                MessageBox.Show("Please select a customer from the grid or load details to update.", "No Customer Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exits if no customer is selected
            }

            // Retrieves updated data from form input fields
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string contactNumber = txtContactNumber.Text.Trim();
            string address = txtAddress.Text.Trim();
            string username = txtUsername.Text.Trim();

            // Validates required fields for update
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Name, Email, and Username are required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exits if validation fails
            }

            // Handle photo update/re-upload logic
            string photoDbPath = null;

            // If a new photo was selected via btnUploadPhoto_Click, _selectedPhotoPath will hold its new local path
            if (_selectedPhotoPath != null && File.Exists(_selectedPhotoPath))
            {
                // Check if the _selectedPhotoPath is a new local path or already the DB path
                // This prevents re-copying if the image was just loaded from DB and not changed
                string existingDbPhotoPath = GetCurrentCustomerPhotoPath(_selectedCustomerId); // Gets the current photo path from DB
                // Combines base directory with existing DB path to get full path for comparison
                string fullExistingDbPath = existingDbPhotoPath != null ? Path.Combine(AppDomain.CurrentDomain.BaseDirectory, existingDbPhotoPath) : null;

                if (_selectedPhotoPath != fullExistingDbPath) // Only re-copy if it's a new file path
                {
                    try
                    {
                        // Defines the directory for customer photos
                        string photosDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CustomerPhotos");
                        if (!Directory.Exists(photosDirectory)) // Creates directory if it doesn't exist
                        {
                            Directory.CreateDirectory(photosDirectory);
                        }

                        // Generates a unique file name for the new photo
                        string fileName = Guid.NewGuid().ToString() + Path.GetExtension(_selectedPhotoPath);
                        string destinationPath = Path.Combine(photosDirectory, fileName); // Defines destination path
                        File.Copy(_selectedPhotoPath, destinationPath, true); // Copies the new photo
                        photoDbPath = "CustomerPhotos\\" + fileName; // Sets the new relative path for DB
                    }
                    catch (Exception ex)
                    {
                        // Displays an error if photo upload fails during update
                        MessageBox.Show("Error uploading photo for update: " + ex.Message, "Photo Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        photoDbPath = existingDbPhotoPath; // Retain old path if new upload fails
                    }
                }
                else
                {
                    photoDbPath = existingDbPhotoPath; // No new file selected, retain current DB path
                }
            }
            else // If _selectedPhotoPath is null (e.g., photo was cleared or never uploaded)
            {
                photoDbPath = null; // Set to null in DB if no photo is present/selected
            }

            // Establishes a database connection
            using (SqlConnection con = new SqlConnection(DbConnection.ConnectionString))
            {
                try
                {
                    con.Open(); // Opens the connection
                    // SQL query to update customer data based on CustomerID
                    string query = "UPDATE Customers SET Name = @Name, Email = @Email, ContactNumber = @ContactNumber, " +
                                   "Address = @Address, PhotoPath = @PhotoPath, Username = @Username " +
                                   "WHERE CustomerID = @CustomerID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Adds parameters for the update query
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Email", email);
                        // Handles nullable fields for update
                        cmd.Parameters.AddWithValue("@ContactNumber", string.IsNullOrEmpty(contactNumber) ? (object)DBNull.Value : contactNumber);
                        cmd.Parameters.AddWithValue("@Address", string.IsNullOrEmpty(address) ? (object)DBNull.Value : address);
                        cmd.Parameters.AddWithValue("@PhotoPath", string.IsNullOrEmpty(photoDbPath) ? (object)DBNull.Value : photoDbPath);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@CustomerID", _selectedCustomerId); // Uses the selected customer ID for the WHERE clause

                        int rowsAffected = cmd.ExecuteNonQuery(); // Executes the SQL UPDATE command

                        if (rowsAffected > 0) // Checks if any rows were affected (update successful)
                        {
                            MessageBox.Show("Customer details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFormFields(); // Clears the form fields
                            LoadCustomersIntoGrid(""); // Refreshes the grid
                        }
                        else
                        {
                            // Informs if no customer was found or no changes were made
                            MessageBox.Show("No customer found with the selected ID or no changes were made.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (SqlException ex) // Catches specific SQL exceptions during update
                {
                    if (ex.Number == 2627) // Unique constraint violation
                    {
                        // Handles duplicate Email or Username errors
                        if (ex.Message.Contains("Email"))
                        {
                            MessageBox.Show("This email is already registered to another customer. Please use a different email.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (ex.Message.Contains("Username"))
                        {
                            MessageBox.Show("This username is already taken by another customer. Please choose a different username.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("A duplicate entry was found. Please check your inputs.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        // Displays a generic database error for other SQL exceptions
                        MessageBox.Show("Database error updating customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex) // Catches any other unexpected exceptions
                {
                    MessageBox.Show("An unexpected error occurred while updating customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string GetCurrentCustomerPhotoPath(int selectedCustomerId)
        {
            string photoPath = null; // Initializes photoPath to null
            using (SqlConnection con = new SqlConnection(DbConnection.ConnectionString))
            {
                try
                {
                    con.Open(); // Opens the database connection
                    // SQL query to select the PhotoPath for a specific CustomerID
                    string query = "SELECT PhotoPath FROM Customers WHERE CustomerID = @CustomerID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // CORRECTED LINE: Use the parameter passed to the method
                        cmd.Parameters.AddWithValue("@CustomerID", selectedCustomerId); // Adds parameter for CustomerID
                        object result = cmd.ExecuteScalar(); // Executes the query and retrieves a single value
                        if (result != null && result != DBNull.Value) // Checks if a value was returned and is not DBNull
                        {
                            photoPath = result.ToString(); // Converts the result to a string (the photo path)
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Logs any errors during photo path retrieval
                    System.Diagnostics.Debug.WriteLine("Error fetching current photo path: " + ex.Message);
                }
            }
            return photoPath; // Returns the retrieved photo path
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            // Check if a customer is selected for deletion.
            if (_selectedCustomerId == -1)
            {
                MessageBox.Show("Please select a customer from the grid or load details to delete.", "No Customer Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirm deletion with the user.
            DialogResult confirm = MessageBox.Show($"Are you sure you want to delete customer ID: {_selectedCustomerId} ({txtName.Text})?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If user confirms deletion.
            if (confirm == DialogResult.Yes)
            {
                // Establish a new SQL connection.
                using (SqlConnection con = new SqlConnection(DbConnection.ConnectionString))
                {
                    try
                    {
                        con.Open(); // Open the database connection.
                                    // Define the SQL query for deleting a customer.
                        string query = "DELETE FROM Customers WHERE CustomerID = @CustomerID";

                        // Create a SQL command with the query and connection.
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            // Add the CustomerID parameter to the command.
                            cmd.Parameters.AddWithValue("@CustomerID", _selectedCustomerId);

                            // Execute the delete command and get the number of rows affected.
                            int rowsAffected = cmd.ExecuteNonQuery();

                            // Check if deletion was successful.
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Customer deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearFormFields(); // Clear form fields after successful deletion.
                                LoadCustomersIntoGrid(""); // Refresh the customer grid.
                            }
                            else
                            {
                                MessageBox.Show("No customer found with the selected ID.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        // Handle specific SQL exception for foreign key constraint violation.
                        if (ex.Number == 547)
                        {
                            MessageBox.Show("Cannot delete customer because there are associated records (e.g., jobs, invoices). Please delete those first.", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            // Handle other database-related errors.
                            MessageBox.Show("Database error deleting customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle any other unexpected errors.
                        MessageBox.Show("An unexpected error occurred while deleting customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void SearchAndLoadCustomerDetails()
        {
            // Get trimmed username and email from text fields.
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();

            // Validate if at least one search criterion is provided.
            if (string.IsNullOrWhiteSpace(username) && string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please enter a Username or Email to search and view.", "Search Input Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Establish a new SQL connection.
            using (SqlConnection con = new SqlConnection(DbConnection.ConnectionString))
            {
                try
                {
                    con.Open(); // Open the database connection.
                                // Base SQL query to select customer details.
                    string query = "SELECT CustomerID, Username, Name, Email, ContactNumber, Address, PhotoPath FROM Customers WHERE ";
                    List<string> conditions = new List<string>(); // List to hold dynamic WHERE clause conditions.
                    SqlCommand cmd = new SqlCommand(); // Create a new SQL command.
                    cmd.Connection = con; // Assign the connection to the command.

                    // Add username condition if provided.
                    if (!string.IsNullOrWhiteSpace(username))
                    {
                        conditions.Add("Username = @Username");
                        cmd.Parameters.AddWithValue("@Username", username);
                    }
                    // Add email condition if provided.
                    if (!string.IsNullOrWhiteSpace(email))
                    {
                        conditions.Add("Email = @Email");
                        cmd.Parameters.AddWithValue("@Email", email);
                    }

                    // Construct the final query string.
                    cmd.CommandText = query + string.Join(" OR ", conditions);

                    SqlDataAdapter da = new SqlDataAdapter(cmd); // Create a data adapter.
                    DataTable dt = new DataTable(); // Create a data table to hold results.
                    da.Fill(dt); // Fill the data table with query results.

                    // Check the number of rows returned.
                    if (dt.Rows.Count == 1)
                    {
                        // If exactly one customer found, load its details.
                        int customerId = Convert.ToInt32(dt.Rows[0]["CustomerID"]);
                        LoadCustomerDetails(customerId);
                        MessageBox.Show("Customer found and details loaded.", "Search Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (dt.Rows.Count > 1)
                    {
                        // If multiple customers found, display a message and show them in the grid.
                        MessageBox.Show("Multiple customers found. Please refine your search or select from the grid.", "Multiple Matches", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvCustomer.DataSource = dt; // Bind the results to the data grid view.
                        ClearFormFields(); // Clear form fields.
                    }
                    else
                    {
                        // If no customer found.
                        MessageBox.Show("No customer found matching your criteria.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFormFields(); // Clear form fields.
                    }
                }
                catch (Exception ex)
                {
                    // Handle any errors during search and load.
                    MessageBox.Show("Error searching and loading customer details: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadCustomerDetails(int customerIdToLoad)
        {
            ClearFormFields(); // Clear existing data in form fields.

            // Establish a new SQL connection.
            using (SqlConnection con = new SqlConnection(DbConnection.ConnectionString))
            {
                try
                {
                    con.Open(); // Open the database connection.
                                // Define the SQL query to select customer details by ID.
                    string query = "SELECT CustomerID, Username, Name, Email, ContactNumber, Address, PhotoPath FROM Customers WHERE CustomerID = @CustomerID";
                    // Create a SQL command with the query and connection.
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Add the CustomerID parameter to the command.
                        cmd.Parameters.AddWithValue("@CustomerID", customerIdToLoad);

                        SqlDataReader reader = cmd.ExecuteReader(); // Execute query and get a data reader.
                        if (reader.Read()) // If a customer record is found.
                        {
                            // Populate form fields with retrieved customer data.
                            _selectedCustomerId = Convert.ToInt32(reader["CustomerID"]);
                            txtCustomerId.Text = reader["CustomerID"].ToString();
                            txtUsername.Text = reader["Username"].ToString();
                            txtName.Text = reader["Name"].ToString();
                            txtEmail.Text = reader["Email"].ToString();
                            txtContactNumber.Text = reader["ContactNumber"].ToString();
                            txtAddress.Text = reader["Address"].ToString();

                            string storedPhotoPath = reader["PhotoPath"] as string; // Get photo path.
                            if (!string.IsNullOrEmpty(storedPhotoPath))
                            {
                                // Construct the full path to the photo.
                                string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, storedPhotoPath);
                                if (File.Exists(fullPath)) // Check if the photo file exists.
                                {
                                    try
                                    {
                                        // Load and display the photo.
                                        using (var ms = new MemoryStream(File.ReadAllBytes(fullPath)))
                                        {
                                            picUploadedPhoto.Image = Image.FromStream(ms);
                                        }
                                        picUploadedPhoto.SizeMode = PictureBoxSizeMode.Zoom; // Set picture box size mode.
                                        _selectedPhotoPath = fullPath; // Store the selected photo path.
                                    }
                                    catch (Exception ex)
                                    {
                                        // Handle errors during photo loading.
                                        MessageBox.Show("Error loading photo: " + ex.Message, "Photo Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        picUploadedPhoto.Image = null; // Clear image on error.
                                        _selectedPhotoPath = null;
                                    }
                                }
                                else
                                {
                                    // If photo file not found.
                                    picUploadedPhoto.Image = null; // Clear image.
                                    _selectedPhotoPath = null;
                                    MessageBox.Show($"Photo file not found at: {fullPath}", "Photo Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                // If no photo path is stored.
                                picUploadedPhoto.Image = null; // Clear image.
                                _selectedPhotoPath = null;
                            }
                        }
                        else
                        {
                            // If no customer found with the given ID.
                            MessageBox.Show("No customer found with the provided ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFormFields(); // Clear fields.
                        }
                        reader.Close(); // Close the data reader.
                    }
                }
                catch (SqlException ex)
                {
                    // Handle database-related errors during loading.
                    MessageBox.Show("Database error loading customer details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    // Handle any other unexpected errors during loading.
                    MessageBox.Show("An unexpected error occurred while loading customer details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFormFields(); // Clear all input fields on the form.
            LoadCustomersIntoGrid(""); // Reload the customer grid (presumably with all customers).
        }

        private void btnAddJobToCustomer_Click(object sender, EventArgs e)
        {
            // Check if a customer is selected.
            if (_selectedCustomerId == -1)
            {
                MessageBox.Show("Please select a customer from the grid or load details to add a job to.", "No Customer Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create a new instance of the job form, passing the selected customer ID.
            frmJob jobForm = new frmJob(_selectedCustomerId);

            jobForm.Show(); // Display the job form.
            this.Hide(); // Hide the current customer form.
        }

        private void btnViewCustomer_Click(object sender, EventArgs e)
        {
            ClearFormFields(); // Clear form fields before loading new details.

            // Validate if Customer ID text field is empty.
            if (string.IsNullOrWhiteSpace(txtCustomerId.Text))
            {
                MessageBox.Show("Please enter a Customer ID in the 'Customer ID' field to view details, or select a row in the grid.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Attempt to parse the Customer ID from text to integer.
            if (!int.TryParse(txtCustomerId.Text, out int idToView))
            {
                MessageBox.Show("Please enter a valid numeric Customer ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoadCustomerDetails(idToView); // Load customer details using the helper method.
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Event handler for menu strip item clicks (currently empty).
        }
    }
}
