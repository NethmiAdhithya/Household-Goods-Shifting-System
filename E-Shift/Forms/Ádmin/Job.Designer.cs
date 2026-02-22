namespace E_Shift
{
    partial class frmJob
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
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAddLoadToJob = new System.Windows.Forms.Button();
            this.btnViewJob = new System.Windows.Forms.Button();
            this.dgvJob = new System.Windows.Forms.DataGridView();
            this.dtpJobDate = new System.Windows.Forms.DateTimePicker();
            this.cmbJobStatus = new System.Windows.Forms.ComboBox();
            this.dtpCompletionDate = new System.Windows.Forms.DateTimePicker();
            this.txtJobId = new System.Windows.Forms.TextBox();
            this.lblJobStatus = new System.Windows.Forms.Label();
            this.lblCompletionDate = new System.Windows.Forms.Label();
            this.lblJobDate = new System.Windows.Forms.Label();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.lblDestination = new System.Windows.Forms.Label();
            this.txtStartLocation = new System.Windows.Forms.TextBox();
            this.lblStartLocation = new System.Windows.Forms.Label();
            this.lblJobId = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.lblJobManagement = new System.Windows.Forms.Label();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.btnApplyStatusFilter = new System.Windows.Forms.Button();
            this.btnApplyDateFilter = new System.Windows.Forms.Button();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.lblFilterByJobStatus = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.cmbFilterByJobStatus = new System.Windows.Forms.ComboBox();
            this.lblFilterByJobDate = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.tsmReports = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCustomerTheirJobs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmJobsByDateRange = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLoadsByTransportUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDeliveryPerformance = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDailyEndOfTheLoads = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAdminManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDashboard = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTransportUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmJob = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMain = new System.Windows.Forms.ToolStripMenuItem();
            this.Home = new System.Windows.Forms.ToolStripMenuItem();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddJob = new System.Windows.Forms.Button();
            this.btnUpdateJobDetails = new System.Windows.Forms.Button();
            this.btnDeleteJob = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearchJob = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJob)).BeginInit();
            this.pnlFilter.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblDescription.Location = new System.Drawing.Point(1023, 730);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(138, 31);
            this.lblDescription.TabIndex = 206;
            this.lblDescription.Text = "Description";
            this.lblDescription.Click += new System.EventHandler(this.lblDescription_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.txtDescription.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtDescription.Location = new System.Drawing.Point(1245, 727);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(490, 39);
            this.txtDescription.TabIndex = 205;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // btnAddLoadToJob
            // 
            this.btnAddLoadToJob.BackColor = System.Drawing.Color.Black;
            this.btnAddLoadToJob.Font = new System.Drawing.Font("Baskerville Old Face", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLoadToJob.ForeColor = System.Drawing.Color.White;
            this.btnAddLoadToJob.Location = new System.Drawing.Point(183, 904);
            this.btnAddLoadToJob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddLoadToJob.Name = "btnAddLoadToJob";
            this.btnAddLoadToJob.Size = new System.Drawing.Size(1554, 69);
            this.btnAddLoadToJob.TabIndex = 201;
            this.btnAddLoadToJob.Text = "Add Load to Job";
            this.btnAddLoadToJob.UseVisualStyleBackColor = false;
            this.btnAddLoadToJob.Click += new System.EventHandler(this.btnAddLoadToJob_Click);
            // 
            // btnViewJob
            // 
            this.btnViewJob.BackColor = System.Drawing.Color.White;
            this.btnViewJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewJob.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnViewJob.ForeColor = System.Drawing.Color.White;
            this.btnViewJob.Location = new System.Drawing.Point(12, 916);
            this.btnViewJob.Name = "btnViewJob";
            this.btnViewJob.Size = new System.Drawing.Size(69, 66);
            this.btnViewJob.TabIndex = 195;
            this.btnViewJob.Text = "View Job";
            this.btnViewJob.UseVisualStyleBackColor = false;
            this.btnViewJob.Click += new System.EventHandler(this.btnViewJob_Click);
            // 
            // dgvJob
            // 
            this.dgvJob.BackgroundColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJob.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvJob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvJob.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvJob.GridColor = System.Drawing.Color.DeepSkyBlue;
            this.dgvJob.Location = new System.Drawing.Point(0, 247);
            this.dgvJob.Name = "dgvJob";
            this.dgvJob.RowHeadersWidth = 51;
            this.dgvJob.RowTemplate.Height = 24;
            this.dgvJob.Size = new System.Drawing.Size(2064, 245);
            this.dgvJob.TabIndex = 194;
            this.dgvJob.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJob_CellContentClick);
            // 
            // dtpJobDate
            // 
            this.dtpJobDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.dtpJobDate.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.dtpJobDate.Location = new System.Drawing.Point(1245, 543);
            this.dtpJobDate.Name = "dtpJobDate";
            this.dtpJobDate.Size = new System.Drawing.Size(490, 38);
            this.dtpJobDate.TabIndex = 193;
            this.dtpJobDate.ValueChanged += new System.EventHandler(this.dtpJobDate_ValueChanged);
            // 
            // cmbJobStatus
            // 
            this.cmbJobStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.cmbJobStatus.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.cmbJobStatus.FormattingEnabled = true;
            this.cmbJobStatus.Location = new System.Drawing.Point(1245, 666);
            this.cmbJobStatus.Name = "cmbJobStatus";
            this.cmbJobStatus.Size = new System.Drawing.Size(490, 39);
            this.cmbJobStatus.TabIndex = 192;
            this.cmbJobStatus.SelectedIndexChanged += new System.EventHandler(this.cmbJobStatus_SelectedIndexChanged);
            // 
            // dtpCompletionDate
            // 
            this.dtpCompletionDate.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.dtpCompletionDate.Location = new System.Drawing.Point(1245, 602);
            this.dtpCompletionDate.Name = "dtpCompletionDate";
            this.dtpCompletionDate.Size = new System.Drawing.Size(490, 38);
            this.dtpCompletionDate.TabIndex = 191;
            this.dtpCompletionDate.ValueChanged += new System.EventHandler(this.dtpCompletionDate_ValueChanged);
            // 
            // txtJobId
            // 
            this.txtJobId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.txtJobId.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtJobId.Location = new System.Drawing.Point(401, 607);
            this.txtJobId.Multiline = true;
            this.txtJobId.Name = "txtJobId";
            this.txtJobId.ReadOnly = true;
            this.txtJobId.Size = new System.Drawing.Size(490, 34);
            this.txtJobId.TabIndex = 190;
            this.txtJobId.TextChanged += new System.EventHandler(this.txtJobId_TextChanged);
            // 
            // lblJobStatus
            // 
            this.lblJobStatus.AutoSize = true;
            this.lblJobStatus.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblJobStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblJobStatus.Location = new System.Drawing.Point(1023, 669);
            this.lblJobStatus.Name = "lblJobStatus";
            this.lblJobStatus.Size = new System.Drawing.Size(119, 31);
            this.lblJobStatus.TabIndex = 189;
            this.lblJobStatus.Text = "JobStatus";
            this.lblJobStatus.Click += new System.EventHandler(this.lblJobStatus_Click);
            // 
            // lblCompletionDate
            // 
            this.lblCompletionDate.AutoSize = true;
            this.lblCompletionDate.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblCompletionDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblCompletionDate.Location = new System.Drawing.Point(1023, 608);
            this.lblCompletionDate.Name = "lblCompletionDate";
            this.lblCompletionDate.Size = new System.Drawing.Size(196, 31);
            this.lblCompletionDate.TabIndex = 188;
            this.lblCompletionDate.Text = "Completion Date";
            this.lblCompletionDate.Click += new System.EventHandler(this.lblCompletionDate_Click);
            // 
            // lblJobDate
            // 
            this.lblJobDate.AutoSize = true;
            this.lblJobDate.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblJobDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblJobDate.Location = new System.Drawing.Point(1023, 549);
            this.lblJobDate.Name = "lblJobDate";
            this.lblJobDate.Size = new System.Drawing.Size(108, 31);
            this.lblJobDate.TabIndex = 187;
            this.lblJobDate.Text = "Job Date";
            this.lblJobDate.Click += new System.EventHandler(this.lblJobDate_Click);
            // 
            // txtDestination
            // 
            this.txtDestination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.txtDestination.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtDestination.Location = new System.Drawing.Point(401, 727);
            this.txtDestination.Multiline = true;
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(490, 34);
            this.txtDestination.TabIndex = 186;
            this.txtDestination.TextChanged += new System.EventHandler(this.txtDestination_TextChanged);
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblDestination.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblDestination.Location = new System.Drawing.Point(178, 730);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(139, 31);
            this.lblDestination.TabIndex = 185;
            this.lblDestination.Text = "Destination";
            this.lblDestination.Click += new System.EventHandler(this.lblDestination_Click);
            // 
            // txtStartLocation
            // 
            this.txtStartLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.txtStartLocation.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtStartLocation.Location = new System.Drawing.Point(401, 667);
            this.txtStartLocation.Multiline = true;
            this.txtStartLocation.Name = "txtStartLocation";
            this.txtStartLocation.Size = new System.Drawing.Size(490, 34);
            this.txtStartLocation.TabIndex = 184;
            this.txtStartLocation.TextChanged += new System.EventHandler(this.txtStartLocation_TextChanged);
            // 
            // lblStartLocation
            // 
            this.lblStartLocation.AutoSize = true;
            this.lblStartLocation.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblStartLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblStartLocation.Location = new System.Drawing.Point(178, 674);
            this.lblStartLocation.Name = "lblStartLocation";
            this.lblStartLocation.Size = new System.Drawing.Size(174, 31);
            this.lblStartLocation.TabIndex = 183;
            this.lblStartLocation.Text = "Statrt Location";
            this.lblStartLocation.Click += new System.EventHandler(this.lblStartLocation_Click);
            // 
            // lblJobId
            // 
            this.lblJobId.AutoSize = true;
            this.lblJobId.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblJobId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblJobId.Location = new System.Drawing.Point(178, 608);
            this.lblJobId.Name = "lblJobId";
            this.lblJobId.Size = new System.Drawing.Size(79, 31);
            this.lblJobId.TabIndex = 182;
            this.lblJobId.Text = "Job id";
            this.lblJobId.Click += new System.EventHandler(this.lblJobId_Click);
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.txtCustomerId.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtCustomerId.Location = new System.Drawing.Point(401, 549);
            this.txtCustomerId.Multiline = true;
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(490, 34);
            this.txtCustomerId.TabIndex = 181;
            this.txtCustomerId.TextChanged += new System.EventHandler(this.txtCustomerId_TextChanged);
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblCustomerId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblCustomerId.Location = new System.Drawing.Point(178, 549);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(144, 31);
            this.lblCustomerId.TabIndex = 180;
            this.lblCustomerId.Text = "Customer id";
            this.lblCustomerId.Click += new System.EventHandler(this.lblCustomerId_Click);
            // 
            // lblJobManagement
            // 
            this.lblJobManagement.AutoSize = true;
            this.lblJobManagement.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.8F);
            this.lblJobManagement.ForeColor = System.Drawing.Color.White;
            this.lblJobManagement.Location = new System.Drawing.Point(779, 9);
            this.lblJobManagement.Name = "lblJobManagement";
            this.lblJobManagement.Size = new System.Drawing.Size(383, 50);
            this.lblJobManagement.TabIndex = 179;
            this.lblJobManagement.Text = "Job Management";
            this.lblJobManagement.Click += new System.EventHandler(this.lblJobManagement_Click);
            // 
            // pnlFilter
            // 
            this.pnlFilter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFilter.Controls.Add(this.btnApplyStatusFilter);
            this.pnlFilter.Controls.Add(this.btnApplyDateFilter);
            this.pnlFilter.Controls.Add(this.dtpToDate);
            this.pnlFilter.Controls.Add(this.lblFilterByJobStatus);
            this.pnlFilter.Controls.Add(this.dtpFromDate);
            this.pnlFilter.Controls.Add(this.cmbFilterByJobStatus);
            this.pnlFilter.Controls.Add(this.lblFilterByJobDate);
            this.pnlFilter.Location = new System.Drawing.Point(12, 164);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(1908, 77);
            this.pnlFilter.TabIndex = 202;
            this.pnlFilter.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFilter_Paint);
            // 
            // btnApplyStatusFilter
            // 
            this.btnApplyStatusFilter.BackColor = System.Drawing.Color.Black;
            this.btnApplyStatusFilter.Font = new System.Drawing.Font("Gadugi", 10.2F);
            this.btnApplyStatusFilter.ForeColor = System.Drawing.Color.White;
            this.btnApplyStatusFilter.Location = new System.Drawing.Point(389, 11);
            this.btnApplyStatusFilter.Name = "btnApplyStatusFilter";
            this.btnApplyStatusFilter.Size = new System.Drawing.Size(178, 48);
            this.btnApplyStatusFilter.TabIndex = 149;
            this.btnApplyStatusFilter.Text = "Apply Status Filter";
            this.btnApplyStatusFilter.UseVisualStyleBackColor = false;
            this.btnApplyStatusFilter.Click += new System.EventHandler(this.btnApplyStatusFilter_Click);
            // 
            // btnApplyDateFilter
            // 
            this.btnApplyDateFilter.BackColor = System.Drawing.Color.Black;
            this.btnApplyDateFilter.Font = new System.Drawing.Font("Gadugi", 10.2F);
            this.btnApplyDateFilter.ForeColor = System.Drawing.Color.White;
            this.btnApplyDateFilter.Location = new System.Drawing.Point(1352, 13);
            this.btnApplyDateFilter.Name = "btnApplyDateFilter";
            this.btnApplyDateFilter.Size = new System.Drawing.Size(178, 48);
            this.btnApplyDateFilter.TabIndex = 148;
            this.btnApplyDateFilter.Text = "ApplyDateFilter";
            this.btnApplyDateFilter.UseVisualStyleBackColor = false;
            this.btnApplyDateFilter.Click += new System.EventHandler(this.btnApplyDateFilter_Click);
            // 
            // dtpToDate
            // 
            this.dtpToDate.CalendarFont = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.dtpToDate.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToDate.Location = new System.Drawing.Point(1072, 22);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(263, 27);
            this.dtpToDate.TabIndex = 147;
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpToDate_ValueChanged);
            // 
            // lblFilterByJobStatus
            // 
            this.lblFilterByJobStatus.AutoSize = true;
            this.lblFilterByJobStatus.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterByJobStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblFilterByJobStatus.Location = new System.Drawing.Point(15, 25);
            this.lblFilterByJobStatus.Name = "lblFilterByJobStatus";
            this.lblFilterByJobStatus.Size = new System.Drawing.Size(150, 20);
            this.lblFilterByJobStatus.TabIndex = 143;
            this.lblFilterByJobStatus.Text = "Filter by Job status";
            this.lblFilterByJobStatus.Click += new System.EventHandler(this.lblFilterByJobStatus_Click);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CalendarFont = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFromDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.dtpFromDate.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFromDate.Location = new System.Drawing.Point(787, 20);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(263, 27);
            this.dtpFromDate.TabIndex = 146;
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
            // 
            // cmbFilterByJobStatus
            // 
            this.cmbFilterByJobStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.cmbFilterByJobStatus.Font = new System.Drawing.Font("Gadugi", 10.2F);
            this.cmbFilterByJobStatus.FormattingEnabled = true;
            this.cmbFilterByJobStatus.Location = new System.Drawing.Point(183, 19);
            this.cmbFilterByJobStatus.Name = "cmbFilterByJobStatus";
            this.cmbFilterByJobStatus.Size = new System.Drawing.Size(200, 28);
            this.cmbFilterByJobStatus.TabIndex = 144;
            this.cmbFilterByJobStatus.SelectedIndexChanged += new System.EventHandler(this.cmbFilterByJobStatus_SelectedIndexChanged);
            // 
            // lblFilterByJobDate
            // 
            this.lblFilterByJobDate.AutoSize = true;
            this.lblFilterByJobDate.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterByJobDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblFilterByJobDate.Location = new System.Drawing.Point(640, 22);
            this.lblFilterByJobDate.Name = "lblFilterByJobDate";
            this.lblFilterByJobDate.Size = new System.Drawing.Size(141, 20);
            this.lblFilterByJobDate.TabIndex = 145;
            this.lblFilterByJobDate.Text = "Filter by Job Date";
            this.lblFilterByJobDate.Click += new System.EventHandler(this.lblFilterByJobDate_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(61)))), ((int)(((byte)(113)))));
            this.menuStrip2.Font = new System.Drawing.Font("Gabriola", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmReports,
            this.tsmAdminManagement,
            this.tsmDashboard,
            this.tsmInvoice,
            this.tsmTransportUnit,
            this.tsmLoad,
            this.tsmJob,
            this.tsmCustomer,
            this.tsmMain,
            this.Home});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1920, 68);
            this.menuStrip2.TabIndex = 177;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // tsmReports
            // 
            this.tsmReports.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCustomerTheirJobs,
            this.tsmJobsByDateRange,
            this.tsmLoadsByTransportUnit,
            this.tsmDeliveryPerformance,
            this.tsmDailyEndOfTheLoads});
            this.tsmReports.ForeColor = System.Drawing.Color.White;
            this.tsmReports.Name = "tsmReports";
            this.tsmReports.Size = new System.Drawing.Size(149, 64);
            this.tsmReports.Text = "REPORTS";
            this.tsmReports.Click += new System.EventHandler(this.tsmReports_Click);
            // 
            // tsmCustomerTheirJobs
            // 
            this.tsmCustomerTheirJobs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(61)))), ((int)(((byte)(113)))));
            this.tsmCustomerTheirJobs.ForeColor = System.Drawing.Color.White;
            this.tsmCustomerTheirJobs.Name = "tsmCustomerTheirJobs";
            this.tsmCustomerTheirJobs.Size = new System.Drawing.Size(389, 64);
            this.tsmCustomerTheirJobs.Text = "Customer & their jobs";
            this.tsmCustomerTheirJobs.Click += new System.EventHandler(this.tsmCustomerTheirJobs_Click);
            // 
            // tsmJobsByDateRange
            // 
            this.tsmJobsByDateRange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(61)))), ((int)(((byte)(113)))));
            this.tsmJobsByDateRange.ForeColor = System.Drawing.Color.White;
            this.tsmJobsByDateRange.Name = "tsmJobsByDateRange";
            this.tsmJobsByDateRange.Size = new System.Drawing.Size(389, 64);
            this.tsmJobsByDateRange.Text = "Jobs by date range";
            this.tsmJobsByDateRange.Click += new System.EventHandler(this.tsmJobsByDateRange_Click);
            // 
            // tsmLoadsByTransportUnit
            // 
            this.tsmLoadsByTransportUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(61)))), ((int)(((byte)(113)))));
            this.tsmLoadsByTransportUnit.ForeColor = System.Drawing.Color.White;
            this.tsmLoadsByTransportUnit.Name = "tsmLoadsByTransportUnit";
            this.tsmLoadsByTransportUnit.Size = new System.Drawing.Size(389, 64);
            this.tsmLoadsByTransportUnit.Text = "Loads by transport unit";
            this.tsmLoadsByTransportUnit.Click += new System.EventHandler(this.tsmLoadsByTransportUnit_Click);
            // 
            // tsmDeliveryPerformance
            // 
            this.tsmDeliveryPerformance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(61)))), ((int)(((byte)(113)))));
            this.tsmDeliveryPerformance.ForeColor = System.Drawing.Color.White;
            this.tsmDeliveryPerformance.Name = "tsmDeliveryPerformance";
            this.tsmDeliveryPerformance.Size = new System.Drawing.Size(389, 64);
            this.tsmDeliveryPerformance.Text = "Delivery performance";
            this.tsmDeliveryPerformance.Click += new System.EventHandler(this.tsmDeliveryPerformance_Click);
            // 
            // tsmDailyEndOfTheLoads
            // 
            this.tsmDailyEndOfTheLoads.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(61)))), ((int)(((byte)(113)))));
            this.tsmDailyEndOfTheLoads.ForeColor = System.Drawing.Color.White;
            this.tsmDailyEndOfTheLoads.Name = "tsmDailyEndOfTheLoads";
            this.tsmDailyEndOfTheLoads.Size = new System.Drawing.Size(389, 64);
            this.tsmDailyEndOfTheLoads.Text = "Daily end of the loads";
            this.tsmDailyEndOfTheLoads.Click += new System.EventHandler(this.tsmDailyEndOfTheLoads_Click);
            // 
            // tsmAdminManagement
            // 
            this.tsmAdminManagement.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmAdminManagement.ForeColor = System.Drawing.Color.White;
            this.tsmAdminManagement.Name = "tsmAdminManagement";
            this.tsmAdminManagement.Size = new System.Drawing.Size(306, 64);
            this.tsmAdminManagement.Text = "ADMIN MANAGEMENT";
            this.tsmAdminManagement.Click += new System.EventHandler(this.tsmAdminManagement_Click);
            // 
            // tsmDashboard
            // 
            this.tsmDashboard.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmDashboard.ForeColor = System.Drawing.Color.White;
            this.tsmDashboard.Name = "tsmDashboard";
            this.tsmDashboard.Size = new System.Drawing.Size(195, 64);
            this.tsmDashboard.Text = "DASHBOARD";
            this.tsmDashboard.Click += new System.EventHandler(this.tsmDashboard_Click);
            // 
            // tsmInvoice
            // 
            this.tsmInvoice.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmInvoice.ForeColor = System.Drawing.Color.White;
            this.tsmInvoice.Name = "tsmInvoice";
            this.tsmInvoice.Size = new System.Drawing.Size(140, 64);
            this.tsmInvoice.Text = "INVOICE";
            this.tsmInvoice.Click += new System.EventHandler(this.tsmInvoice_Click);
            // 
            // tsmTransportUnit
            // 
            this.tsmTransportUnit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmTransportUnit.ForeColor = System.Drawing.Color.White;
            this.tsmTransportUnit.Name = "tsmTransportUnit";
            this.tsmTransportUnit.Size = new System.Drawing.Size(251, 64);
            this.tsmTransportUnit.Text = "TRANSPORT UNIT";
            this.tsmTransportUnit.Click += new System.EventHandler(this.tsmTransportUnit_Click);
            // 
            // tsmLoad
            // 
            this.tsmLoad.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmLoad.ForeColor = System.Drawing.Color.White;
            this.tsmLoad.Name = "tsmLoad";
            this.tsmLoad.Size = new System.Drawing.Size(108, 64);
            this.tsmLoad.Text = "LOAD";
            this.tsmLoad.Click += new System.EventHandler(this.tsmLoad_Click);
            // 
            // tsmJob
            // 
            this.tsmJob.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmJob.ForeColor = System.Drawing.Color.White;
            this.tsmJob.Name = "tsmJob";
            this.tsmJob.Size = new System.Drawing.Size(82, 64);
            this.tsmJob.Text = "JOB";
            this.tsmJob.Click += new System.EventHandler(this.tsmJob_Click);
            // 
            // tsmCustomer
            // 
            this.tsmCustomer.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmCustomer.ForeColor = System.Drawing.Color.White;
            this.tsmCustomer.Name = "tsmCustomer";
            this.tsmCustomer.Size = new System.Drawing.Size(176, 64);
            this.tsmCustomer.Text = "CUSTOMER";
            this.tsmCustomer.Click += new System.EventHandler(this.tsmCustomer_Click);
            // 
            // tsmMain
            // 
            this.tsmMain.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmMain.ForeColor = System.Drawing.Color.White;
            this.tsmMain.Name = "tsmMain";
            this.tsmMain.Size = new System.Drawing.Size(104, 64);
            this.tsmMain.Text = "MAIN";
            this.tsmMain.Click += new System.EventHandler(this.tsmMain_Click);
            // 
            // Home
            // 
            this.Home.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Home.ForeColor = System.Drawing.Color.White;
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(114, 64);
            this.Home.Text = "HOME";
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = global::E_Shift.Properties.Resources.Delivery_Express_Logo__3_;
            this.picLogo.Location = new System.Drawing.Point(104, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(98, 68);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 178;
            this.picLogo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.panel1.Controls.Add(this.lblJobManagement);
            this.panel1.Location = new System.Drawing.Point(0, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2064, 70);
            this.panel1.TabIndex = 207;
            // 
            // btnAddJob
            // 
            this.btnAddJob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(149)))), ((int)(((byte)(89)))));
            this.btnAddJob.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddJob.ForeColor = System.Drawing.Color.White;
            this.btnAddJob.Location = new System.Drawing.Point(830, 809);
            this.btnAddJob.Name = "btnAddJob";
            this.btnAddJob.Size = new System.Drawing.Size(250, 66);
            this.btnAddJob.TabIndex = 196;
            this.btnAddJob.Text = "Add Job";
            this.btnAddJob.UseVisualStyleBackColor = false;
            this.btnAddJob.Click += new System.EventHandler(this.btnAddJob_Click);
            // 
            // btnUpdateJobDetails
            // 
            this.btnUpdateJobDetails.BackColor = System.Drawing.Color.DarkOrange;
            this.btnUpdateJobDetails.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdateJobDetails.ForeColor = System.Drawing.Color.White;
            this.btnUpdateJobDetails.Location = new System.Drawing.Point(508, 809);
            this.btnUpdateJobDetails.Name = "btnUpdateJobDetails";
            this.btnUpdateJobDetails.Size = new System.Drawing.Size(250, 66);
            this.btnUpdateJobDetails.TabIndex = 197;
            this.btnUpdateJobDetails.Text = "Update Job Details";
            this.btnUpdateJobDetails.UseVisualStyleBackColor = false;
            this.btnUpdateJobDetails.Click += new System.EventHandler(this.btnUpdateJobDetails_Click);
            // 
            // btnDeleteJob
            // 
            this.btnDeleteJob.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteJob.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDeleteJob.ForeColor = System.Drawing.Color.White;
            this.btnDeleteJob.Location = new System.Drawing.Point(1159, 809);
            this.btnDeleteJob.Name = "btnDeleteJob";
            this.btnDeleteJob.Size = new System.Drawing.Size(250, 66);
            this.btnDeleteJob.TabIndex = 198;
            this.btnDeleteJob.Text = "Delete Job";
            this.btnDeleteJob.UseVisualStyleBackColor = false;
            this.btnDeleteJob.Click += new System.EventHandler(this.btnDeleteJob_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnClear.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(1485, 809);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(250, 66);
            this.btnClear.TabIndex = 199;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearchJob
            // 
            this.btnSearchJob.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSearchJob.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearchJob.ForeColor = System.Drawing.Color.White;
            this.btnSearchJob.Location = new System.Drawing.Point(183, 809);
            this.btnSearchJob.Name = "btnSearchJob";
            this.btnSearchJob.Size = new System.Drawing.Size(250, 66);
            this.btnSearchJob.TabIndex = 200;
            this.btnSearchJob.Text = "Search Job";
            this.btnSearchJob.UseVisualStyleBackColor = false;
            this.btnSearchJob.Click += new System.EventHandler(this.btnSearchJob_Click);
            // 
            // frmJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 994);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnAddLoadToJob);
            this.Controls.Add(this.btnSearchJob);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDeleteJob);
            this.Controls.Add(this.btnUpdateJobDetails);
            this.Controls.Add(this.btnAddJob);
            this.Controls.Add(this.btnViewJob);
            this.Controls.Add(this.dgvJob);
            this.Controls.Add(this.lblCustomerId);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.dtpJobDate);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblJobId);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.cmbJobStatus);
            this.Controls.Add(this.lblJobDate);
            this.Controls.Add(this.lblStartLocation);
            this.Controls.Add(this.lblCompletionDate);
            this.Controls.Add(this.dtpCompletionDate);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.txtStartLocation);
            this.Controls.Add(this.lblJobStatus);
            this.Controls.Add(this.txtJobId);
            this.Controls.Add(this.lblDestination);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmJob";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Job";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmJob_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJob)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAddLoadToJob;
        private System.Windows.Forms.Button btnViewJob;
        private System.Windows.Forms.DataGridView dgvJob;
        private System.Windows.Forms.DateTimePicker dtpJobDate;
        private System.Windows.Forms.ComboBox cmbJobStatus;
        private System.Windows.Forms.DateTimePicker dtpCompletionDate;
        private System.Windows.Forms.TextBox txtJobId;
        private System.Windows.Forms.Label lblJobStatus;
        private System.Windows.Forms.Label lblCompletionDate;
        private System.Windows.Forms.Label lblJobDate;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.TextBox txtStartLocation;
        private System.Windows.Forms.Label lblStartLocation;
        private System.Windows.Forms.Label lblJobId;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.Label lblJobManagement;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Button btnApplyStatusFilter;
        private System.Windows.Forms.Button btnApplyDateFilter;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label lblFilterByJobStatus;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.ComboBox cmbFilterByJobStatus;
        private System.Windows.Forms.Label lblFilterByJobDate;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem tsmReports;
        private System.Windows.Forms.ToolStripMenuItem tsmCustomerTheirJobs;
        private System.Windows.Forms.ToolStripMenuItem tsmJobsByDateRange;
        private System.Windows.Forms.ToolStripMenuItem tsmLoadsByTransportUnit;
        private System.Windows.Forms.ToolStripMenuItem tsmDeliveryPerformance;
        private System.Windows.Forms.ToolStripMenuItem tsmDailyEndOfTheLoads;
        private System.Windows.Forms.ToolStripMenuItem tsmAdminManagement;
        private System.Windows.Forms.ToolStripMenuItem tsmDashboard;
        private System.Windows.Forms.ToolStripMenuItem tsmInvoice;
        private System.Windows.Forms.ToolStripMenuItem tsmTransportUnit;
        private System.Windows.Forms.ToolStripMenuItem tsmLoad;
        private System.Windows.Forms.ToolStripMenuItem tsmJob;
        private System.Windows.Forms.ToolStripMenuItem tsmCustomer;
        private System.Windows.Forms.ToolStripMenuItem tsmMain;
        private System.Windows.Forms.ToolStripMenuItem Home;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddJob;
        private System.Windows.Forms.Button btnUpdateJobDetails;
        private System.Windows.Forms.Button btnDeleteJob;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearchJob;
    }
}