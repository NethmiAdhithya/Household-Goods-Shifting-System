namespace E_Shift
{
    partial class frmTrackStatus
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.lblTrackStatus = new System.Windows.Forms.Label();
            this.lblWelcomeMessage = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgvLoadsTracking = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoadsTracking)).BeginInit();
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
            // lblTrackStatus
            // 
            this.lblTrackStatus.AutoSize = true;
            this.lblTrackStatus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.8F);
            this.lblTrackStatus.ForeColor = System.Drawing.Color.White;
            this.lblTrackStatus.Location = new System.Drawing.Point(833, 10);
            this.lblTrackStatus.Name = "lblTrackStatus";
            this.lblTrackStatus.Size = new System.Drawing.Size(290, 50);
            this.lblTrackStatus.TabIndex = 202;
            this.lblTrackStatus.Text = "Track Status";
            // 
            // lblWelcomeMessage
            // 
            this.lblWelcomeMessage.AutoSize = true;
            this.lblWelcomeMessage.Font = new System.Drawing.Font("Cambria", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblWelcomeMessage.Location = new System.Drawing.Point(427, 227);
            this.lblWelcomeMessage.Name = "lblWelcomeMessage";
            this.lblWelcomeMessage.Size = new System.Drawing.Size(221, 55);
            this.lblWelcomeMessage.TabIndex = 175;
            this.lblWelcomeMessage.Text = "Welcome";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.panel6.Controls.Add(this.lblTrackStatus);
            this.panel6.Location = new System.Drawing.Point(0, 78);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(2064, 70);
            this.panel6.TabIndex = 312;
            // 
            // dgvLoadsTracking
            // 
            this.dgvLoadsTracking.AllowUserToAddRows = false;
            this.dgvLoadsTracking.AllowUserToDeleteRows = false;
            this.dgvLoadsTracking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoadsTracking.BackgroundColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoadsTracking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvLoadsTracking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLoadsTracking.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvLoadsTracking.GridColor = System.Drawing.Color.DeepSkyBlue;
            this.dgvLoadsTracking.Location = new System.Drawing.Point(-72, 371);
            this.dgvLoadsTracking.Name = "dgvLoadsTracking";
            this.dgvLoadsTracking.RowHeadersWidth = 51;
            this.dgvLoadsTracking.RowTemplate.Height = 24;
            this.dgvLoadsTracking.Size = new System.Drawing.Size(2064, 253);
            this.dgvLoadsTracking.TabIndex = 313;
            this.dgvLoadsTracking.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoadsTracking_CellContentClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRefresh.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(704, 683);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(250, 66);
            this.btnRefresh.TabIndex = 314;
            this.btnRefresh.Text = "Refresh Status";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmTrackStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 994);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvLoadsTracking);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.lblWelcomeMessage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmTrackStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrackStatus";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTrackStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoadsTracking)).EndInit();
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
        private System.Windows.Forms.Label lblTrackStatus;
        private System.Windows.Forms.Label lblWelcomeMessage;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgvLoadsTracking;
        private System.Windows.Forms.Button btnRefresh;
    }
}