namespace E_Shift
{
    partial class frmViewInvoice
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtInvoiceId = new System.Windows.Forms.TextBox();
            this.lblInvoiceId = new System.Windows.Forms.Label();
            this.txtJobId = new System.Windows.Forms.TextBox();
            this.lblJobId = new System.Windows.Forms.Label();
            this.lblViewInvoice = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtInvoiceStatus = new System.Windows.Forms.TextBox();
            this.lblDateDue = new System.Windows.Forms.Label();
            this.lblDateIssued = new System.Windows.Forms.Label();
            this.txtDateIssued = new System.Windows.Forms.TextBox();
            this.txtDateDue = new System.Windows.Forms.TextBox();
            this.cmbInvoiceSelection = new System.Windows.Forms.ComboBox();
            this.lblSelectInvoice = new System.Windows.Forms.Label();
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
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblStatus.Location = new System.Drawing.Point(526, 592);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(88, 35);
            this.lblStatus.TabIndex = 197;
            this.lblStatus.Text = "Status";
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.txtAmount.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(739, 518);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(607, 40);
            this.txtAmount.TabIndex = 196;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblAmount.Location = new System.Drawing.Point(526, 518);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(110, 35);
            this.lblAmount.TabIndex = 195;
            this.lblAmount.Text = "Amount";
            this.lblAmount.Click += new System.EventHandler(this.lblAmount_Click);
            // 
            // txtInvoiceId
            // 
            this.txtInvoiceId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.txtInvoiceId.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceId.Location = new System.Drawing.Point(739, 448);
            this.txtInvoiceId.Multiline = true;
            this.txtInvoiceId.Name = "txtInvoiceId";
            this.txtInvoiceId.ReadOnly = true;
            this.txtInvoiceId.Size = new System.Drawing.Size(607, 40);
            this.txtInvoiceId.TabIndex = 194;
            this.txtInvoiceId.TextChanged += new System.EventHandler(this.txtInvoiceId_TextChanged);
            // 
            // lblInvoiceId
            // 
            this.lblInvoiceId.AutoSize = true;
            this.lblInvoiceId.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblInvoiceId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblInvoiceId.Location = new System.Drawing.Point(526, 448);
            this.lblInvoiceId.Name = "lblInvoiceId";
            this.lblInvoiceId.Size = new System.Drawing.Size(126, 35);
            this.lblInvoiceId.TabIndex = 193;
            this.lblInvoiceId.Text = "Invoice id";
            this.lblInvoiceId.Click += new System.EventHandler(this.lblInvoiceId_Click);
            // 
            // txtJobId
            // 
            this.txtJobId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.txtJobId.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJobId.Location = new System.Drawing.Point(739, 376);
            this.txtJobId.Multiline = true;
            this.txtJobId.Name = "txtJobId";
            this.txtJobId.ReadOnly = true;
            this.txtJobId.Size = new System.Drawing.Size(607, 40);
            this.txtJobId.TabIndex = 192;
            this.txtJobId.TextChanged += new System.EventHandler(this.txtJobId_TextChanged);
            // 
            // lblJobId
            // 
            this.lblJobId.AutoSize = true;
            this.lblJobId.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblJobId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblJobId.Location = new System.Drawing.Point(526, 378);
            this.lblJobId.Name = "lblJobId";
            this.lblJobId.Size = new System.Drawing.Size(82, 35);
            this.lblJobId.TabIndex = 191;
            this.lblJobId.Text = "Job id";
            this.lblJobId.Click += new System.EventHandler(this.lblJobId_Click);
            // 
            // lblViewInvoice
            // 
            this.lblViewInvoice.AutoSize = true;
            this.lblViewInvoice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.8F);
            this.lblViewInvoice.ForeColor = System.Drawing.Color.White;
            this.lblViewInvoice.Location = new System.Drawing.Point(834, 10);
            this.lblViewInvoice.Name = "lblViewInvoice";
            this.lblViewInvoice.Size = new System.Drawing.Size(288, 50);
            this.lblViewInvoice.TabIndex = 190;
            this.lblViewInvoice.Text = "View Invoice";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.panel6.Controls.Add(this.lblViewInvoice);
            this.panel6.Location = new System.Drawing.Point(0, 78);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(2064, 70);
            this.panel6.TabIndex = 312;
            // 
            // txtInvoiceStatus
            // 
            this.txtInvoiceStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.txtInvoiceStatus.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceStatus.Location = new System.Drawing.Point(739, 592);
            this.txtInvoiceStatus.Multiline = true;
            this.txtInvoiceStatus.Name = "txtInvoiceStatus";
            this.txtInvoiceStatus.ReadOnly = true;
            this.txtInvoiceStatus.Size = new System.Drawing.Size(607, 40);
            this.txtInvoiceStatus.TabIndex = 313;
            this.txtInvoiceStatus.TextChanged += new System.EventHandler(this.txtInvoiceStatus_TextChanged);
            // 
            // lblDateDue
            // 
            this.lblDateDue.AutoSize = true;
            this.lblDateDue.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblDateDue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblDateDue.Location = new System.Drawing.Point(526, 743);
            this.lblDateDue.Name = "lblDateDue";
            this.lblDateDue.Size = new System.Drawing.Size(113, 31);
            this.lblDateDue.TabIndex = 315;
            this.lblDateDue.Text = "Date Due";
            this.lblDateDue.Click += new System.EventHandler(this.lblDateDue_Click);
            // 
            // lblDateIssued
            // 
            this.lblDateIssued.AutoSize = true;
            this.lblDateIssued.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblDateIssued.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblDateIssued.Location = new System.Drawing.Point(526, 668);
            this.lblDateIssued.Name = "lblDateIssued";
            this.lblDateIssued.Size = new System.Drawing.Size(137, 31);
            this.lblDateIssued.TabIndex = 314;
            this.lblDateIssued.Text = "Date Issued";
            this.lblDateIssued.Click += new System.EventHandler(this.lblDateIssued_Click);
            // 
            // txtDateIssued
            // 
            this.txtDateIssued.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.txtDateIssued.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateIssued.Location = new System.Drawing.Point(739, 665);
            this.txtDateIssued.Multiline = true;
            this.txtDateIssued.Name = "txtDateIssued";
            this.txtDateIssued.ReadOnly = true;
            this.txtDateIssued.Size = new System.Drawing.Size(607, 40);
            this.txtDateIssued.TabIndex = 316;
            this.txtDateIssued.TextChanged += new System.EventHandler(this.txtDateIssued_TextChanged);
            // 
            // txtDateDue
            // 
            this.txtDateDue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.txtDateDue.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateDue.Location = new System.Drawing.Point(739, 740);
            this.txtDateDue.Multiline = true;
            this.txtDateDue.Name = "txtDateDue";
            this.txtDateDue.ReadOnly = true;
            this.txtDateDue.Size = new System.Drawing.Size(607, 40);
            this.txtDateDue.TabIndex = 317;
            this.txtDateDue.TextChanged += new System.EventHandler(this.txtDateDue_TextChanged);
            // 
            // cmbInvoiceSelection
            // 
            this.cmbInvoiceSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.cmbInvoiceSelection.Font = new System.Drawing.Font("Gadugi", 16.2F);
            this.cmbInvoiceSelection.FormattingEnabled = true;
            this.cmbInvoiceSelection.Location = new System.Drawing.Point(739, 248);
            this.cmbInvoiceSelection.Name = "cmbInvoiceSelection";
            this.cmbInvoiceSelection.Size = new System.Drawing.Size(607, 39);
            this.cmbInvoiceSelection.TabIndex = 319;
            this.cmbInvoiceSelection.SelectedIndexChanged += new System.EventHandler(this.cmbInvoiceSelection_SelectedIndexChanged);
            // 
            // lblSelectInvoice
            // 
            this.lblSelectInvoice.AutoSize = true;
            this.lblSelectInvoice.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblSelectInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblSelectInvoice.Location = new System.Drawing.Point(526, 250);
            this.lblSelectInvoice.Name = "lblSelectInvoice";
            this.lblSelectInvoice.Size = new System.Drawing.Size(174, 35);
            this.lblSelectInvoice.TabIndex = 320;
            this.lblSelectInvoice.Text = "Select Invoice";
            // 
            // frmViewInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 994);
            this.Controls.Add(this.lblSelectInvoice);
            this.Controls.Add(this.cmbInvoiceSelection);
            this.Controls.Add(this.txtDateDue);
            this.Controls.Add(this.txtDateIssued);
            this.Controls.Add(this.lblDateDue);
            this.Controls.Add(this.lblDateIssued);
            this.Controls.Add(this.txtInvoiceStatus);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtInvoiceId);
            this.Controls.Add(this.lblInvoiceId);
            this.Controls.Add(this.txtJobId);
            this.Controls.Add(this.lblJobId);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmViewInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewInvoice";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmViewInvoice_Load);
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
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtInvoiceId;
        private System.Windows.Forms.Label lblInvoiceId;
        private System.Windows.Forms.TextBox txtJobId;
        private System.Windows.Forms.Label lblJobId;
        private System.Windows.Forms.Label lblViewInvoice;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtInvoiceStatus;
        private System.Windows.Forms.Label lblDateDue;
        private System.Windows.Forms.Label lblDateIssued;
        private System.Windows.Forms.TextBox txtDateIssued;
        private System.Windows.Forms.TextBox txtDateDue;
        private System.Windows.Forms.ComboBox cmbInvoiceSelection;
        private System.Windows.Forms.Label lblSelectInvoice;
    }
}