namespace E_Shift
{
    partial class frmInvoice
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
            this.dtpDateDue = new System.Windows.Forms.DateTimePicker();
            this.lblDateDue = new System.Windows.Forms.Label();
            this.cmbInvoiceStatus = new System.Windows.Forms.ComboBox();
            this.dtpDateIssued = new System.Windows.Forms.DateTimePicker();
            this.btnSearchInvoice = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDeleteInvoice = new System.Windows.Forms.Button();
            this.btnUpdateInvoice = new System.Windows.Forms.Button();
            this.btnAddInvoice = new System.Windows.Forms.Button();
            this.dgvInvoice = new System.Windows.Forms.DataGridView();
            this.lblDateIssued = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtInvoiceId = new System.Windows.Forms.TextBox();
            this.lblInvoiceId = new System.Windows.Forms.Label();
            this.txtJobId = new System.Windows.Forms.TextBox();
            this.lblJobId = new System.Windows.Forms.Label();
            this.lblInvoiceManagement = new System.Windows.Forms.Label();
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
            this.panel6 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpDateDue
            // 
            this.dtpDateDue.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.dtpDateDue.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.dtpDateDue.Location = new System.Drawing.Point(851, 780);
            this.dtpDateDue.Name = "dtpDateDue";
            this.dtpDateDue.Size = new System.Drawing.Size(503, 38);
            this.dtpDateDue.TabIndex = 194;
            this.dtpDateDue.ValueChanged += new System.EventHandler(this.dtpDateDue_ValueChanged);
            // 
            // lblDateDue
            // 
            this.lblDateDue.AutoSize = true;
            this.lblDateDue.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblDateDue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblDateDue.Location = new System.Drawing.Point(616, 780);
            this.lblDateDue.Name = "lblDateDue";
            this.lblDateDue.Size = new System.Drawing.Size(113, 31);
            this.lblDateDue.TabIndex = 193;
            this.lblDateDue.Text = "Date Due";
            this.lblDateDue.Click += new System.EventHandler(this.lblDateDue_Click);
            // 
            // cmbInvoiceStatus
            // 
            this.cmbInvoiceStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.cmbInvoiceStatus.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.cmbInvoiceStatus.FormattingEnabled = true;
            this.cmbInvoiceStatus.Location = new System.Drawing.Point(851, 656);
            this.cmbInvoiceStatus.Name = "cmbInvoiceStatus";
            this.cmbInvoiceStatus.Size = new System.Drawing.Size(503, 39);
            this.cmbInvoiceStatus.TabIndex = 192;
            this.cmbInvoiceStatus.SelectedIndexChanged += new System.EventHandler(this.cmbInvoiceStatus_SelectedIndexChanged);
            // 
            // dtpDateIssued
            // 
            this.dtpDateIssued.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.dtpDateIssued.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.dtpDateIssued.Location = new System.Drawing.Point(851, 723);
            this.dtpDateIssued.Name = "dtpDateIssued";
            this.dtpDateIssued.Size = new System.Drawing.Size(503, 38);
            this.dtpDateIssued.TabIndex = 191;
            this.dtpDateIssued.ValueChanged += new System.EventHandler(this.dtpDateIssued_ValueChanged);
            // 
            // btnSearchInvoice
            // 
            this.btnSearchInvoice.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSearchInvoice.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnSearchInvoice.ForeColor = System.Drawing.Color.White;
            this.btnSearchInvoice.Location = new System.Drawing.Point(183, 864);
            this.btnSearchInvoice.Name = "btnSearchInvoice";
            this.btnSearchInvoice.Size = new System.Drawing.Size(250, 66);
            this.btnSearchInvoice.TabIndex = 190;
            this.btnSearchInvoice.Text = "Search Invoice";
            this.btnSearchInvoice.UseVisualStyleBackColor = false;
            this.btnSearchInvoice.Click += new System.EventHandler(this.btnSearchInvoice_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnClear.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(1526, 863);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(250, 66);
            this.btnClear.TabIndex = 189;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDeleteInvoice
            // 
            this.btnDeleteInvoice.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteInvoice.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnDeleteInvoice.ForeColor = System.Drawing.Color.White;
            this.btnDeleteInvoice.Location = new System.Drawing.Point(1190, 863);
            this.btnDeleteInvoice.Name = "btnDeleteInvoice";
            this.btnDeleteInvoice.Size = new System.Drawing.Size(250, 66);
            this.btnDeleteInvoice.TabIndex = 188;
            this.btnDeleteInvoice.Text = "Delete Invoice";
            this.btnDeleteInvoice.UseVisualStyleBackColor = false;
            this.btnDeleteInvoice.Click += new System.EventHandler(this.btnDeleteInvoice_Click);
            // 
            // btnUpdateInvoice
            // 
            this.btnUpdateInvoice.BackColor = System.Drawing.Color.DarkOrange;
            this.btnUpdateInvoice.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateInvoice.ForeColor = System.Drawing.Color.White;
            this.btnUpdateInvoice.Location = new System.Drawing.Point(513, 864);
            this.btnUpdateInvoice.Name = "btnUpdateInvoice";
            this.btnUpdateInvoice.Size = new System.Drawing.Size(250, 66);
            this.btnUpdateInvoice.TabIndex = 187;
            this.btnUpdateInvoice.Text = "Update Invoice Details";
            this.btnUpdateInvoice.UseVisualStyleBackColor = false;
            this.btnUpdateInvoice.Click += new System.EventHandler(this.btnUpdateInvoice_Click);
            // 
            // btnAddInvoice
            // 
            this.btnAddInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(149)))), ((int)(((byte)(89)))));
            this.btnAddInvoice.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnAddInvoice.ForeColor = System.Drawing.Color.White;
            this.btnAddInvoice.Location = new System.Drawing.Point(851, 863);
            this.btnAddInvoice.Name = "btnAddInvoice";
            this.btnAddInvoice.Size = new System.Drawing.Size(250, 66);
            this.btnAddInvoice.TabIndex = 186;
            this.btnAddInvoice.Text = "Add Invoice";
            this.btnAddInvoice.UseVisualStyleBackColor = false;
            this.btnAddInvoice.Click += new System.EventHandler(this.btnAddInvoice_Click);
            // 
            // dgvInvoice
            // 
            this.dgvInvoice.AllowUserToAddRows = false;
            this.dgvInvoice.AllowUserToDeleteRows = false;
            this.dgvInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoice.BackgroundColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInvoice.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInvoice.GridColor = System.Drawing.Color.DeepSkyBlue;
            this.dgvInvoice.Location = new System.Drawing.Point(0, 160);
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.RowHeadersWidth = 51;
            this.dgvInvoice.RowTemplate.Height = 24;
            this.dgvInvoice.Size = new System.Drawing.Size(2064, 253);
            this.dgvInvoice.TabIndex = 184;
            this.dgvInvoice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoice_CellContentClick);
            // 
            // lblDateIssued
            // 
            this.lblDateIssued.AutoSize = true;
            this.lblDateIssued.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblDateIssued.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblDateIssued.Location = new System.Drawing.Point(616, 723);
            this.lblDateIssued.Name = "lblDateIssued";
            this.lblDateIssued.Size = new System.Drawing.Size(137, 31);
            this.lblDateIssued.TabIndex = 183;
            this.lblDateIssued.Text = "Date Issued";
            this.lblDateIssued.Click += new System.EventHandler(this.lblDateIssued_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblStatus.Location = new System.Drawing.Point(618, 658);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(81, 31);
            this.lblStatus.TabIndex = 182;
            this.lblStatus.Text = "Status";
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.txtAmount.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtAmount.Location = new System.Drawing.Point(851, 594);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(503, 40);
            this.txtAmount.TabIndex = 181;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblAmount.Location = new System.Drawing.Point(618, 596);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(102, 31);
            this.lblAmount.TabIndex = 180;
            this.lblAmount.Text = "Amount";
            this.lblAmount.Click += new System.EventHandler(this.lblAmount_Click);
            // 
            // txtInvoiceId
            // 
            this.txtInvoiceId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.txtInvoiceId.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtInvoiceId.Location = new System.Drawing.Point(851, 532);
            this.txtInvoiceId.Multiline = true;
            this.txtInvoiceId.Name = "txtInvoiceId";
            this.txtInvoiceId.ReadOnly = true;
            this.txtInvoiceId.Size = new System.Drawing.Size(503, 40);
            this.txtInvoiceId.TabIndex = 179;
            this.txtInvoiceId.TextChanged += new System.EventHandler(this.txtInvoiceId_TextChanged);
            // 
            // lblInvoiceId
            // 
            this.lblInvoiceId.AutoSize = true;
            this.lblInvoiceId.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblInvoiceId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblInvoiceId.Location = new System.Drawing.Point(618, 534);
            this.lblInvoiceId.Name = "lblInvoiceId";
            this.lblInvoiceId.Size = new System.Drawing.Size(118, 31);
            this.lblInvoiceId.TabIndex = 178;
            this.lblInvoiceId.Text = "Invoice id";
            this.lblInvoiceId.Click += new System.EventHandler(this.lblInvoiceId_Click);
            // 
            // txtJobId
            // 
            this.txtJobId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.txtJobId.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtJobId.Location = new System.Drawing.Point(851, 467);
            this.txtJobId.Multiline = true;
            this.txtJobId.Name = "txtJobId";
            this.txtJobId.ReadOnly = true;
            this.txtJobId.Size = new System.Drawing.Size(503, 40);
            this.txtJobId.TabIndex = 177;
            this.txtJobId.TextChanged += new System.EventHandler(this.txtJobId_TextChanged);
            // 
            // lblJobId
            // 
            this.lblJobId.AutoSize = true;
            this.lblJobId.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblJobId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblJobId.Location = new System.Drawing.Point(618, 469);
            this.lblJobId.Name = "lblJobId";
            this.lblJobId.Size = new System.Drawing.Size(79, 31);
            this.lblJobId.TabIndex = 176;
            this.lblJobId.Text = "Job id";
            this.lblJobId.Click += new System.EventHandler(this.lblJobId_Click);
            // 
            // lblInvoiceManagement
            // 
            this.lblInvoiceManagement.AutoSize = true;
            this.lblInvoiceManagement.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.8F);
            this.lblInvoiceManagement.ForeColor = System.Drawing.Color.White;
            this.lblInvoiceManagement.Location = new System.Drawing.Point(708, 11);
            this.lblInvoiceManagement.Name = "lblInvoiceManagement";
            this.lblInvoiceManagement.Size = new System.Drawing.Size(457, 50);
            this.lblInvoiceManagement.TabIndex = 175;
            this.lblInvoiceManagement.Text = "Invoice Management";
            this.lblInvoiceManagement.Click += new System.EventHandler(this.lblInvoiceManagement_Click);
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
            this.menuStrip2.TabIndex = 173;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
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
            this.picLogo.Location = new System.Drawing.Point(105, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(98, 68);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 174;
            this.picLogo.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.panel6.Controls.Add(this.lblInvoiceManagement);
            this.panel6.Location = new System.Drawing.Point(0, 84);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(2064, 70);
            this.panel6.TabIndex = 308;
            // 
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 994);
            this.Controls.Add(this.dtpDateDue);
            this.Controls.Add(this.lblDateDue);
            this.Controls.Add(this.cmbInvoiceStatus);
            this.Controls.Add(this.dtpDateIssued);
            this.Controls.Add(this.btnSearchInvoice);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDeleteInvoice);
            this.Controls.Add(this.btnUpdateInvoice);
            this.Controls.Add(this.btnAddInvoice);
            this.Controls.Add(this.lblDateIssued);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtInvoiceId);
            this.Controls.Add(this.lblInvoiceId);
            this.Controls.Add(this.txtJobId);
            this.Controls.Add(this.lblJobId);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.dgvInvoice);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDateDue;
        private System.Windows.Forms.Label lblDateDue;
        private System.Windows.Forms.ComboBox cmbInvoiceStatus;
        private System.Windows.Forms.DateTimePicker dtpDateIssued;
        private System.Windows.Forms.Button btnSearchInvoice;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDeleteInvoice;
        private System.Windows.Forms.Button btnUpdateInvoice;
        private System.Windows.Forms.Button btnAddInvoice;
        private System.Windows.Forms.DataGridView dgvInvoice;
        private System.Windows.Forms.Label lblDateIssued;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtInvoiceId;
        private System.Windows.Forms.Label lblInvoiceId;
        private System.Windows.Forms.TextBox txtJobId;
        private System.Windows.Forms.Label lblJobId;
        private System.Windows.Forms.Label lblInvoiceManagement;
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
        private System.Windows.Forms.Panel panel6;
    }
}