namespace E_Shift
{
    partial class frmViewMyJobs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.lblViewMyJobs = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.lblJobId = new System.Windows.Forms.Label();
            this.lblJobDate = new System.Windows.Forms.Label();
            this.lblStartLocation = new System.Windows.Forms.Label();
            this.lblCompletionDate = new System.Windows.Forms.Label();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.txtStartLocation = new System.Windows.Forms.TextBox();
            this.lblJobStatus = new System.Windows.Forms.Label();
            this.txtJobId = new System.Windows.Forms.TextBox();
            this.lblDestination = new System.Windows.Forms.Label();
            this.txtJobDate = new System.Windows.Forms.TextBox();
            this.txtJobStatus = new System.Windows.Forms.TextBox();
            this.txtCompletionDate = new System.Windows.Forms.TextBox();
            this.dgvMyJobs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyJobs)).BeginInit();
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
            // lblViewMyJobs
            // 
            this.lblViewMyJobs.AutoSize = true;
            this.lblViewMyJobs.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.8F);
            this.lblViewMyJobs.ForeColor = System.Drawing.Color.White;
            this.lblViewMyJobs.Location = new System.Drawing.Point(861, 11);
            this.lblViewMyJobs.Name = "lblViewMyJobs";
            this.lblViewMyJobs.Size = new System.Drawing.Size(307, 50);
            this.lblViewMyJobs.TabIndex = 190;
            this.lblViewMyJobs.Text = "View My Jobs";
            this.lblViewMyJobs.Click += new System.EventHandler(this.lblViewMyJobs_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.panel6.Controls.Add(this.lblViewMyJobs);
            this.panel6.Location = new System.Drawing.Point(0, 78);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(2064, 70);
            this.panel6.TabIndex = 312;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblDescription.Location = new System.Drawing.Point(549, 896);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(121, 28);
            this.lblDescription.TabIndex = 328;
            this.lblDescription.Text = "Description";
            this.lblDescription.Click += new System.EventHandler(this.lblDescription_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.txtDescription.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(813, 890);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(619, 33);
            this.txtDescription.TabIndex = 327;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblCustomerId.Location = new System.Drawing.Point(548, 506);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(125, 28);
            this.lblCustomerId.TabIndex = 313;
            this.lblCustomerId.Text = "Customer id";
            this.lblCustomerId.Click += new System.EventHandler(this.lblCustomerId_Click_1);
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.txtCustomerId.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerId.Location = new System.Drawing.Point(813, 503);
            this.txtCustomerId.Multiline = true;
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(619, 33);
            this.txtCustomerId.TabIndex = 314;
            this.txtCustomerId.TextChanged += new System.EventHandler(this.txtCustomerId_TextChanged_1);
            // 
            // lblJobId
            // 
            this.lblJobId.AutoSize = true;
            this.lblJobId.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblJobId.Location = new System.Drawing.Point(548, 559);
            this.lblJobId.Name = "lblJobId";
            this.lblJobId.Size = new System.Drawing.Size(68, 28);
            this.lblJobId.TabIndex = 315;
            this.lblJobId.Text = "Job id";
            this.lblJobId.Click += new System.EventHandler(this.lblJobId_Click);
            // 
            // lblJobDate
            // 
            this.lblJobDate.AutoSize = true;
            this.lblJobDate.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblJobDate.Location = new System.Drawing.Point(549, 724);
            this.lblJobDate.Name = "lblJobDate";
            this.lblJobDate.Size = new System.Drawing.Size(95, 28);
            this.lblJobDate.TabIndex = 320;
            this.lblJobDate.Text = "Job Date";
            this.lblJobDate.Click += new System.EventHandler(this.lblJobDate_Click);
            // 
            // lblStartLocation
            // 
            this.lblStartLocation.AutoSize = true;
            this.lblStartLocation.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblStartLocation.Location = new System.Drawing.Point(548, 620);
            this.lblStartLocation.Name = "lblStartLocation";
            this.lblStartLocation.Size = new System.Drawing.Size(152, 28);
            this.lblStartLocation.TabIndex = 316;
            this.lblStartLocation.Text = "Statrt Location";
            this.lblStartLocation.Click += new System.EventHandler(this.lblStartLocation_Click);
            // 
            // lblCompletionDate
            // 
            this.lblCompletionDate.AutoSize = true;
            this.lblCompletionDate.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompletionDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblCompletionDate.Location = new System.Drawing.Point(549, 781);
            this.lblCompletionDate.Name = "lblCompletionDate";
            this.lblCompletionDate.Size = new System.Drawing.Size(171, 28);
            this.lblCompletionDate.TabIndex = 321;
            this.lblCompletionDate.Text = "Completion Date";
            this.lblCompletionDate.Click += new System.EventHandler(this.lblCompletionDate_Click);
            // 
            // txtDestination
            // 
            this.txtDestination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.txtDestination.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestination.Location = new System.Drawing.Point(813, 666);
            this.txtDestination.Multiline = true;
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(619, 33);
            this.txtDestination.TabIndex = 319;
            this.txtDestination.TextChanged += new System.EventHandler(this.txtDestination_TextChanged);
            // 
            // txtStartLocation
            // 
            this.txtStartLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.txtStartLocation.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartLocation.Location = new System.Drawing.Point(813, 610);
            this.txtStartLocation.Multiline = true;
            this.txtStartLocation.Name = "txtStartLocation";
            this.txtStartLocation.Size = new System.Drawing.Size(619, 33);
            this.txtStartLocation.TabIndex = 317;
            this.txtStartLocation.TextChanged += new System.EventHandler(this.txtStartLocation_TextChanged);
            // 
            // lblJobStatus
            // 
            this.lblJobStatus.AutoSize = true;
            this.lblJobStatus.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblJobStatus.Location = new System.Drawing.Point(549, 837);
            this.lblJobStatus.Name = "lblJobStatus";
            this.lblJobStatus.Size = new System.Drawing.Size(104, 28);
            this.lblJobStatus.TabIndex = 322;
            this.lblJobStatus.Text = "JobStatus";
            this.lblJobStatus.Click += new System.EventHandler(this.lblJobStatus_Click);
            // 
            // txtJobId
            // 
            this.txtJobId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.txtJobId.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJobId.Location = new System.Drawing.Point(813, 555);
            this.txtJobId.Multiline = true;
            this.txtJobId.Name = "txtJobId";
            this.txtJobId.ReadOnly = true;
            this.txtJobId.Size = new System.Drawing.Size(619, 33);
            this.txtJobId.TabIndex = 323;
            this.txtJobId.TextChanged += new System.EventHandler(this.txtJobId_TextChanged);
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestination.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblDestination.Location = new System.Drawing.Point(548, 672);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(122, 28);
            this.lblDestination.TabIndex = 318;
            this.lblDestination.Text = "Destination";
            this.lblDestination.Click += new System.EventHandler(this.lblDestination_Click);
            // 
            // txtJobDate
            // 
            this.txtJobDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.txtJobDate.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJobDate.Location = new System.Drawing.Point(813, 721);
            this.txtJobDate.Multiline = true;
            this.txtJobDate.Name = "txtJobDate";
            this.txtJobDate.Size = new System.Drawing.Size(619, 33);
            this.txtJobDate.TabIndex = 329;
            this.txtJobDate.TextChanged += new System.EventHandler(this.txtJobDate_TextChanged);
            // 
            // txtJobStatus
            // 
            this.txtJobStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.txtJobStatus.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJobStatus.Location = new System.Drawing.Point(813, 834);
            this.txtJobStatus.Multiline = true;
            this.txtJobStatus.Name = "txtJobStatus";
            this.txtJobStatus.Size = new System.Drawing.Size(619, 33);
            this.txtJobStatus.TabIndex = 330;
            this.txtJobStatus.TextChanged += new System.EventHandler(this.txtJobStatus_TextChanged);
            // 
            // txtCompletionDate
            // 
            this.txtCompletionDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.txtCompletionDate.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompletionDate.Location = new System.Drawing.Point(813, 778);
            this.txtCompletionDate.Multiline = true;
            this.txtCompletionDate.Name = "txtCompletionDate";
            this.txtCompletionDate.Size = new System.Drawing.Size(619, 33);
            this.txtCompletionDate.TabIndex = 331;
            this.txtCompletionDate.TextChanged += new System.EventHandler(this.txtCompletionDate_TextChanged);
            // 
            // dgvMyJobs
            // 
            this.dgvMyJobs.AllowUserToAddRows = false;
            this.dgvMyJobs.AllowUserToDeleteRows = false;
            this.dgvMyJobs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMyJobs.BackgroundColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMyJobs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMyJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMyJobs.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMyJobs.GridColor = System.Drawing.Color.DeepSkyBlue;
            this.dgvMyJobs.Location = new System.Drawing.Point(0, 164);
            this.dgvMyJobs.Name = "dgvMyJobs";
            this.dgvMyJobs.RowHeadersWidth = 51;
            this.dgvMyJobs.RowTemplate.Height = 24;
            this.dgvMyJobs.Size = new System.Drawing.Size(2064, 245);
            this.dgvMyJobs.TabIndex = 332;
            this.dgvMyJobs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMyJobs_CellContentClick);
            // 
            // frmViewMyJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 994);
            this.Controls.Add(this.txtCompletionDate);
            this.Controls.Add(this.txtJobStatus);
            this.Controls.Add(this.txtJobDate);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblCustomerId);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.lblJobId);
            this.Controls.Add(this.lblJobDate);
            this.Controls.Add(this.lblStartLocation);
            this.Controls.Add(this.lblCompletionDate);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.txtStartLocation);
            this.Controls.Add(this.lblJobStatus);
            this.Controls.Add(this.txtJobId);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgvMyJobs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmViewMyJobs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewMyJobs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmViewMyJobs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyJobs)).EndInit();
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
        private System.Windows.Forms.Label lblViewMyJobs;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label lblJobId;
        private System.Windows.Forms.Label lblJobDate;
        private System.Windows.Forms.Label lblStartLocation;
        private System.Windows.Forms.Label lblCompletionDate;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.TextBox txtStartLocation;
        private System.Windows.Forms.Label lblJobStatus;
        private System.Windows.Forms.TextBox txtJobId;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.TextBox txtJobDate;
        private System.Windows.Forms.TextBox txtJobStatus;
        private System.Windows.Forms.TextBox txtCompletionDate;
        private System.Windows.Forms.DataGridView dgvMyJobs;
    }
}