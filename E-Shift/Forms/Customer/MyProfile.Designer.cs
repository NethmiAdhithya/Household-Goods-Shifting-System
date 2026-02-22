namespace E_Shift
{
    partial class frmMyProfile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmCustomerDashboard = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmViewInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTrackingStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmViewMyJobs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRequestNewTransport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMyProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMain = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHome = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMyProfile = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnUploadPhoto = new System.Windows.Forms.Button();
            this.lblPhoto = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.picUploadedPhoto = new System.Windows.Forms.PictureBox();
            this.chkShowConfirmPassword = new System.Windows.Forms.CheckBox();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUploadedPhoto)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::E_Shift.Properties.Resources.Delivery_Express_Logo__3_;
            this.pictureBox1.Location = new System.Drawing.Point(104, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 133;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(61)))), ((int)(((byte)(113)))));
            this.menuStrip1.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCustomerDashboard,
            this.tsmViewInvoice,
            this.tsmTrackingStatus,
            this.tsmViewMyJobs,
            this.tsmRequestNewTransport,
            this.tsmMyProfile,
            this.tsmMain,
            this.tsmHome});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1920, 63);
            this.menuStrip1.TabIndex = 132;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmCustomerDashboard
            // 
            this.tsmCustomerDashboard.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmCustomerDashboard.ForeColor = System.Drawing.Color.White;
            this.tsmCustomerDashboard.Name = "tsmCustomerDashboard";
            this.tsmCustomerDashboard.Size = new System.Drawing.Size(310, 59);
            this.tsmCustomerDashboard.Text = "CUSTOMER DASHBOARD";
            this.tsmCustomerDashboard.Click += new System.EventHandler(this.tsmCustomerDashboard_Click);
            // 
            // tsmViewInvoice
            // 
            this.tsmViewInvoice.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmViewInvoice.ForeColor = System.Drawing.Color.White;
            this.tsmViewInvoice.Name = "tsmViewInvoice";
            this.tsmViewInvoice.Size = new System.Drawing.Size(198, 59);
            this.tsmViewInvoice.Text = "VIEW INVOICE";
            this.tsmViewInvoice.Click += new System.EventHandler(this.tsmViewInvoice_Click);
            // 
            // tsmTrackingStatus
            // 
            this.tsmTrackingStatus.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmTrackingStatus.ForeColor = System.Drawing.Color.White;
            this.tsmTrackingStatus.Name = "tsmTrackingStatus";
            this.tsmTrackingStatus.Size = new System.Drawing.Size(237, 59);
            this.tsmTrackingStatus.Text = "TRACKING STATUS";
            this.tsmTrackingStatus.Click += new System.EventHandler(this.tsmTrackingStatus_Click);
            // 
            // tsmViewMyJobs
            // 
            this.tsmViewMyJobs.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmViewMyJobs.ForeColor = System.Drawing.Color.White;
            this.tsmViewMyJobs.Name = "tsmViewMyJobs";
            this.tsmViewMyJobs.Size = new System.Drawing.Size(186, 59);
            this.tsmViewMyJobs.Text = "VIRE MY JOBS";
            this.tsmViewMyJobs.Click += new System.EventHandler(this.tsmViewMyJobs_Click);
            // 
            // tsmRequestNewTransport
            // 
            this.tsmRequestNewTransport.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmRequestNewTransport.ForeColor = System.Drawing.Color.White;
            this.tsmRequestNewTransport.Name = "tsmRequestNewTransport";
            this.tsmRequestNewTransport.Size = new System.Drawing.Size(335, 59);
            this.tsmRequestNewTransport.Text = "REQUEST NEW TRANSPORT";
            this.tsmRequestNewTransport.Click += new System.EventHandler(this.tsmRequestNewTransport_Click);
            // 
            // tsmMyProfile
            // 
            this.tsmMyProfile.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmMyProfile.ForeColor = System.Drawing.Color.White;
            this.tsmMyProfile.Name = "tsmMyProfile";
            this.tsmMyProfile.Size = new System.Drawing.Size(169, 59);
            this.tsmMyProfile.Text = "MY PROFILE";
            this.tsmMyProfile.Click += new System.EventHandler(this.tsmMyProfile_Click);
            // 
            // tsmMain
            // 
            this.tsmMain.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmMain.ForeColor = System.Drawing.Color.White;
            this.tsmMain.Name = "tsmMain";
            this.tsmMain.Size = new System.Drawing.Size(99, 59);
            this.tsmMain.Text = "MAIN";
            this.tsmMain.Click += new System.EventHandler(this.tsmMain_Click);
            // 
            // tsmHome
            // 
            this.tsmHome.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmHome.ForeColor = System.Drawing.Color.White;
            this.tsmHome.Name = "tsmHome";
            this.tsmHome.Size = new System.Drawing.Size(107, 59);
            this.tsmHome.Text = "HOME";
            this.tsmHome.Click += new System.EventHandler(this.tsmHome_Click);
            // 
            // lblMyProfile
            // 
            this.lblMyProfile.AutoSize = true;
            this.lblMyProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblMyProfile.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.8F);
            this.lblMyProfile.ForeColor = System.Drawing.Color.White;
            this.lblMyProfile.Location = new System.Drawing.Point(854, 10);
            this.lblMyProfile.Name = "lblMyProfile";
            this.lblMyProfile.Size = new System.Drawing.Size(230, 50);
            this.lblMyProfile.TabIndex = 205;
            this.lblMyProfile.Text = "My Profile";
            this.lblMyProfile.Click += new System.EventHandler(this.lblMyProfile_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(755, 259);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(615, 34);
            this.txtUsername.TabIndex = 203;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblUsername.Location = new System.Drawing.Point(490, 259);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(133, 27);
            this.lblUsername.TabIndex = 202;
            this.lblUsername.Text = "Username";
            this.lblUsername.Click += new System.EventHandler(this.lblUsername_Click);
            // 
            // btnUploadPhoto
            // 
            this.btnUploadPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.btnUploadPhoto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadPhoto.Location = new System.Drawing.Point(755, 625);
            this.btnUploadPhoto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUploadPhoto.Name = "btnUploadPhoto";
            this.btnUploadPhoto.Size = new System.Drawing.Size(615, 34);
            this.btnUploadPhoto.TabIndex = 201;
            this.btnUploadPhoto.Text = "Upload photo";
            this.btnUploadPhoto.UseVisualStyleBackColor = false;
            this.btnUploadPhoto.Click += new System.EventHandler(this.btnUploadPhoto_Click);
            // 
            // lblPhoto
            // 
            this.lblPhoto.AutoSize = true;
            this.lblPhoto.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblPhoto.Location = new System.Drawing.Point(490, 625);
            this.lblPhoto.Name = "lblPhoto";
            this.lblPhoto.Size = new System.Drawing.Size(85, 35);
            this.lblPhoto.TabIndex = 200;
            this.lblPhoto.Text = "Photo";
            this.lblPhoto.Click += new System.EventHandler(this.lblPhoto_Click);
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerId.Location = new System.Drawing.Point(755, 322);
            this.txtCustomerId.Multiline = true;
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(615, 34);
            this.txtCustomerId.TabIndex = 199;
            this.txtCustomerId.TextChanged += new System.EventHandler(this.txtCustomerId_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(755, 559);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(615, 42);
            this.txtAddress.TabIndex = 198;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblAddress.Location = new System.Drawing.Point(490, 559);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(108, 27);
            this.lblAddress.TabIndex = 197;
            this.lblAddress.Text = "Address";
            this.lblAddress.Click += new System.EventHandler(this.lblAddress_Click);
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNumber.Location = new System.Drawing.Point(755, 505);
            this.txtContactNumber.Multiline = true;
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(615, 34);
            this.txtContactNumber.TabIndex = 196;
            this.txtContactNumber.TextChanged += new System.EventHandler(this.txtContactNumber_TextChanged);
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblContactNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblContactNumber.Location = new System.Drawing.Point(490, 505);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(211, 27);
            this.lblContactNumber.TabIndex = 195;
            this.lblContactNumber.Text = "Contact Number";
            this.lblContactNumber.Click += new System.EventHandler(this.lblContactNumber_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(755, 439);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(615, 34);
            this.txtEmail.TabIndex = 194;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblEmail.Location = new System.Drawing.Point(490, 439);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(82, 27);
            this.lblEmail.TabIndex = 193;
            this.lblEmail.Text = "Email";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(755, 380);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(615, 34);
            this.txtName.TabIndex = 192;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblName.Location = new System.Drawing.Point(490, 380);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(80, 27);
            this.lblName.TabIndex = 191;
            this.lblName.Text = "Name";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblCustomerId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblCustomerId.Location = new System.Drawing.Point(490, 322);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(160, 27);
            this.lblCustomerId.TabIndex = 190;
            this.lblCustomerId.Text = "Customer id";
            this.lblCustomerId.Click += new System.EventHandler(this.lblCustomerId_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSaveChanges.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.ForeColor = System.Drawing.Color.White;
            this.btnSaveChanges.Location = new System.Drawing.Point(803, 851);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(251, 73);
            this.btnSaveChanges.TabIndex = 188;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // picUploadedPhoto
            // 
            this.picUploadedPhoto.BackColor = System.Drawing.Color.White;
            this.picUploadedPhoto.Location = new System.Drawing.Point(1431, 259);
            this.picUploadedPhoto.Name = "picUploadedPhoto";
            this.picUploadedPhoto.Size = new System.Drawing.Size(400, 400);
            this.picUploadedPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUploadedPhoto.TabIndex = 207;
            this.picUploadedPhoto.TabStop = false;
            this.picUploadedPhoto.Click += new System.EventHandler(this.picUploadedPhoto_Click);
            // 
            // chkShowConfirmPassword
            // 
            this.chkShowConfirmPassword.AutoSize = true;
            this.chkShowConfirmPassword.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.chkShowConfirmPassword.Location = new System.Drawing.Point(1431, 746);
            this.chkShowConfirmPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkShowConfirmPassword.Name = "chkShowConfirmPassword";
            this.chkShowConfirmPassword.Size = new System.Drawing.Size(318, 39);
            this.chkShowConfirmPassword.TabIndex = 214;
            this.chkShowConfirmPassword.Text = "Show Confirm Password";
            this.chkShowConfirmPassword.UseVisualStyleBackColor = true;
            this.chkShowConfirmPassword.CheckedChanged += new System.EventHandler(this.chkShowConfirmPassword_CheckedChanged);
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.chkShowPassword.Location = new System.Drawing.Point(1431, 680);
            this.chkShowPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(218, 39);
            this.chkShowPassword.TabIndex = 213;
            this.chkShowPassword.Text = "Show Password";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblConfirmPassword.Location = new System.Drawing.Point(490, 742);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(226, 35);
            this.lblConfirmPassword.TabIndex = 212;
            this.lblConfirmPassword.Text = "Confirm Password";
            this.lblConfirmPassword.Click += new System.EventHandler(this.lblConfirmPassword_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblPassword.Location = new System.Drawing.Point(490, 676);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(126, 35);
            this.lblPassword.TabIndex = 211;
            this.lblPassword.Text = "Password";
            this.lblPassword.Click += new System.EventHandler(this.lblPassword_Click);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Baskerville Old Face", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(755, 742);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConfirmPassword.Multiline = true;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '.';
            this.txtConfirmPassword.Size = new System.Drawing.Size(615, 43);
            this.txtConfirmPassword.TabIndex = 210;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtConfirmPassword_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Baskerville Old Face", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(755, 676);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '.';
            this.txtPassword.Size = new System.Drawing.Size(615, 43);
            this.txtPassword.TabIndex = 209;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.label1.Location = new System.Drawing.Point(490, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 35);
            this.label1.TabIndex = 190;
            this.label1.Text = "Customer id";
            this.label1.Click += new System.EventHandler(this.lblCustomerId_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.label2.Location = new System.Drawing.Point(490, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 35);
            this.label2.TabIndex = 191;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.lblName_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.label3.Location = new System.Drawing.Point(490, 442);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 35);
            this.label3.TabIndex = 193;
            this.label3.Text = "Email";
            this.label3.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.label4.Location = new System.Drawing.Point(490, 508);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 35);
            this.label4.TabIndex = 195;
            this.label4.Text = "Contact Number";
            this.label4.Click += new System.EventHandler(this.lblContactNumber_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.label5.Location = new System.Drawing.Point(490, 562);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 35);
            this.label5.TabIndex = 197;
            this.label5.Text = "Address";
            this.label5.Click += new System.EventHandler(this.lblAddress_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.label6.Location = new System.Drawing.Point(490, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 35);
            this.label6.TabIndex = 202;
            this.label6.Text = "Username";
            this.label6.Click += new System.EventHandler(this.lblUsername_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.panel6.Controls.Add(this.lblMyProfile);
            this.panel6.Location = new System.Drawing.Point(0, 80);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(2064, 70);
            this.panel6.TabIndex = 312;
            // 
            // frmMyProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 994);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.chkShowConfirmPassword);
            this.Controls.Add(this.chkShowPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.picUploadedPhoto);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnUploadPhoto);
            this.Controls.Add(this.lblPhoto);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtContactNumber);
            this.Controls.Add(this.lblContactNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCustomerId);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmMyProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyProfile";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMyProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUploadedPhoto)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmCustomerDashboard;
        private System.Windows.Forms.ToolStripMenuItem tsmViewInvoice;
        private System.Windows.Forms.ToolStripMenuItem tsmTrackingStatus;
        private System.Windows.Forms.ToolStripMenuItem tsmViewMyJobs;
        private System.Windows.Forms.ToolStripMenuItem tsmRequestNewTransport;
        private System.Windows.Forms.ToolStripMenuItem tsmMyProfile;
        private System.Windows.Forms.ToolStripMenuItem tsmMain;
        private System.Windows.Forms.ToolStripMenuItem tsmHome;
        private System.Windows.Forms.Label lblMyProfile;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnUploadPhoto;
        private System.Windows.Forms.Label lblPhoto;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.PictureBox picUploadedPhoto;
        private System.Windows.Forms.CheckBox chkShowConfirmPassword;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
    }
}