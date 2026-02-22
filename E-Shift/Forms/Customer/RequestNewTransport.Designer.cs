namespace E_Shift
{
    partial class frmRequestNewTransport
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
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtStartLocation = new System.Windows.Forms.TextBox();
            this.dtpJobDate = new System.Windows.Forms.DateTimePicker();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.btnSubmitRequest = new System.Windows.Forms.Button();
            this.lblJobDate = new System.Windows.Forms.Label();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblStartLocation = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.lblRequestNewTransport = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblDescription.Location = new System.Drawing.Point(531, 654);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(148, 35);
            this.lblDescription.TabIndex = 191;
            this.lblDescription.Text = "Description";
            this.lblDescription.Click += new System.EventHandler(this.lblDescription_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(761, 651);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(719, 141);
            this.txtDescription.TabIndex = 190;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // txtStartLocation
            // 
            this.txtStartLocation.Font = new System.Drawing.Font("Baskerville Old Face", 22.2F);
            this.txtStartLocation.Location = new System.Drawing.Point(761, 383);
            this.txtStartLocation.Multiline = true;
            this.txtStartLocation.Name = "txtStartLocation";
            this.txtStartLocation.Size = new System.Drawing.Size(719, 57);
            this.txtStartLocation.TabIndex = 189;
            this.txtStartLocation.TextChanged += new System.EventHandler(this.txtStartLocation_TextChanged);
            // 
            // dtpJobDate
            // 
            this.dtpJobDate.Font = new System.Drawing.Font("Gadugi", 13.8F);
            this.dtpJobDate.Location = new System.Drawing.Point(761, 569);
            this.dtpJobDate.Name = "dtpJobDate";
            this.dtpJobDate.Size = new System.Drawing.Size(719, 38);
            this.dtpJobDate.TabIndex = 188;
            this.dtpJobDate.ValueChanged += new System.EventHandler(this.dtpJobDate_ValueChanged);
            // 
            // btnResetForm
            // 
            this.btnResetForm.BackColor = System.Drawing.Color.Goldenrod;
            this.btnResetForm.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetForm.ForeColor = System.Drawing.Color.White;
            this.btnResetForm.Location = new System.Drawing.Point(1041, 858);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(439, 61);
            this.btnResetForm.TabIndex = 187;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = false;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // btnSubmitRequest
            // 
            this.btnSubmitRequest.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSubmitRequest.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitRequest.ForeColor = System.Drawing.Color.White;
            this.btnSubmitRequest.Location = new System.Drawing.Point(536, 858);
            this.btnSubmitRequest.Name = "btnSubmitRequest";
            this.btnSubmitRequest.Size = new System.Drawing.Size(439, 61);
            this.btnSubmitRequest.TabIndex = 186;
            this.btnSubmitRequest.Text = "Submit Request";
            this.btnSubmitRequest.UseVisualStyleBackColor = false;
            this.btnSubmitRequest.Click += new System.EventHandler(this.btnSubmitRequest_Click);
            // 
            // lblJobDate
            // 
            this.lblJobDate.AutoSize = true;
            this.lblJobDate.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblJobDate.Location = new System.Drawing.Point(531, 569);
            this.lblJobDate.Name = "lblJobDate";
            this.lblJobDate.Size = new System.Drawing.Size(116, 35);
            this.lblJobDate.TabIndex = 185;
            this.lblJobDate.Text = "Job Date";
            this.lblJobDate.Click += new System.EventHandler(this.lblJobDate_Click);
            // 
            // txtDestination
            // 
            this.txtDestination.Font = new System.Drawing.Font("Baskerville Old Face", 22.2F);
            this.txtDestination.Location = new System.Drawing.Point(761, 470);
            this.txtDestination.Multiline = true;
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(719, 57);
            this.txtDestination.TabIndex = 184;
            this.txtDestination.TextChanged += new System.EventHandler(this.txtDestination_TextChanged);
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestination.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblDestination.Location = new System.Drawing.Point(531, 484);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(149, 35);
            this.lblDestination.TabIndex = 183;
            this.lblDestination.Text = "Destination";
            this.lblDestination.Click += new System.EventHandler(this.lblDestination_Click);
            // 
            // lblStartLocation
            // 
            this.lblStartLocation.AutoSize = true;
            this.lblStartLocation.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblStartLocation.Location = new System.Drawing.Point(531, 397);
            this.lblStartLocation.Name = "lblStartLocation";
            this.lblStartLocation.Size = new System.Drawing.Size(187, 35);
            this.lblStartLocation.TabIndex = 182;
            this.lblStartLocation.Text = "Statrt Location";
            this.lblStartLocation.Click += new System.EventHandler(this.lblStartLocation_Click);
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Font = new System.Drawing.Font("Baskerville Old Face", 22.2F);
            this.txtCustomerId.Location = new System.Drawing.Point(761, 288);
            this.txtCustomerId.Multiline = true;
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(719, 57);
            this.txtCustomerId.TabIndex = 181;
            this.txtCustomerId.TextChanged += new System.EventHandler(this.txtCustomerId_TextChanged);
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblCustomerId.Location = new System.Drawing.Point(531, 302);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(156, 35);
            this.lblCustomerId.TabIndex = 180;
            this.lblCustomerId.Text = "Customer id";
            this.lblCustomerId.Click += new System.EventHandler(this.lblCustomerId_Click);
            // 
            // lblRequestNewTransport
            // 
            this.lblRequestNewTransport.AutoSize = true;
            this.lblRequestNewTransport.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.8F);
            this.lblRequestNewTransport.ForeColor = System.Drawing.Color.White;
            this.lblRequestNewTransport.Location = new System.Drawing.Point(730, 9);
            this.lblRequestNewTransport.Name = "lblRequestNewTransport";
            this.lblRequestNewTransport.Size = new System.Drawing.Size(520, 50);
            this.lblRequestNewTransport.TabIndex = 179;
            this.lblRequestNewTransport.Text = "Request New Transport";
            this.lblRequestNewTransport.Click += new System.EventHandler(this.lblRequestNewTransport_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.panel6.Controls.Add(this.lblRequestNewTransport);
            this.panel6.Location = new System.Drawing.Point(0, 80);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(2064, 70);
            this.panel6.TabIndex = 312;
            // 
            // frmRequestNewTransport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 994);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtStartLocation);
            this.Controls.Add(this.dtpJobDate);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnSubmitRequest);
            this.Controls.Add(this.lblJobDate);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.lblStartLocation);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.lblCustomerId);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmRequestNewTransport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RequestNewTransport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRequestNewTransport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtStartLocation;
        private System.Windows.Forms.DateTimePicker dtpJobDate;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.Button btnSubmitRequest;
        private System.Windows.Forms.Label lblJobDate;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblStartLocation;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.Label lblRequestNewTransport;
        private System.Windows.Forms.Panel panel6;
    }
}