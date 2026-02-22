namespace E_Shift
{
    partial class frmLoad
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvLoad = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.btnUploadPhoto = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnDeleteLoad = new System.Windows.Forms.Button();
            this.cmbTransportUnitId = new System.Windows.Forms.ComboBox();
            this.txtProductItem = new System.Windows.Forms.TextBox();
            this.lblProductItem = new System.Windows.Forms.Label();
            this.txtJobId = new System.Windows.Forms.TextBox();
            this.lblItemphoto = new System.Windows.Forms.Label();
            this.btnAddInvoiceToJob = new System.Windows.Forms.Button();
            this.btnSearchLoad = new System.Windows.Forms.Button();
            this.btnUpdateLoadDetails = new System.Windows.Forms.Button();
            this.btnAddLoad = new System.Windows.Forms.Button();
            this.btnViewLoad = new System.Windows.Forms.Button();
            this.cmbLoadStatus = new System.Windows.Forms.ComboBox();
            this.txtLoadId = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblJobId = new System.Windows.Forms.Label();
            this.lblLoadId = new System.Windows.Forms.Label();
            this.lblLoadManagement = new System.Windows.Forms.Label();
            this.lblTransportUnitId = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.btnApplyStatusFilter = new System.Windows.Forms.Button();
            this.lblFilterByStatus = new System.Windows.Forms.Label();
            this.cmbFilterByLoadStatus = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
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
            this.picUploadedPhoto = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoad)).BeginInit();
            this.pnlFilter.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUploadedPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLoad
            // 
            this.dgvLoad.BackgroundColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoad.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLoad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLoad.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLoad.GridColor = System.Drawing.Color.DeepSkyBlue;
            this.dgvLoad.Location = new System.Drawing.Point(0, 251);
            this.dgvLoad.Name = "dgvLoad";
            this.dgvLoad.RowHeadersWidth = 51;
            this.dgvLoad.RowTemplate.Height = 24;
            this.dgvLoad.Size = new System.Drawing.Size(2064, 222);
            this.dgvLoad.TabIndex = 305;
            this.dgvLoad.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoad_CellContentClick);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnClear.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(1482, 806);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(250, 66);
            this.btnClear.TabIndex = 304;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtSize
            // 
            this.txtSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.txtSize.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtSize.Location = new System.Drawing.Point(1215, 566);
            this.txtSize.Multiline = true;
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(517, 34);
            this.txtSize.TabIndex = 295;
            this.txtSize.TextChanged += new System.EventHandler(this.txtSize_TextChanged);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblSize.Location = new System.Drawing.Point(998, 566);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(57, 31);
            this.lblSize.TabIndex = 294;
            this.lblSize.Text = "Size";
            this.lblSize.Click += new System.EventHandler(this.lblSize_Click);
            // 
            // btnUploadPhoto
            // 
            this.btnUploadPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.btnUploadPhoto.Font = new System.Drawing.Font("Baskerville Old Face", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadPhoto.Location = new System.Drawing.Point(346, 671);
            this.btnUploadPhoto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUploadPhoto.Name = "btnUploadPhoto";
            this.btnUploadPhoto.Size = new System.Drawing.Size(433, 34);
            this.btnUploadPhoto.TabIndex = 300;
            this.btnUploadPhoto.Text = "Upload photo";
            this.btnUploadPhoto.UseVisualStyleBackColor = false;
            this.btnUploadPhoto.Click += new System.EventHandler(this.btnUploadPhoto_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.txtQuantity.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtQuantity.Location = new System.Drawing.Point(346, 728);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(517, 34);
            this.txtQuantity.TabIndex = 298;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblQuantity.Location = new System.Drawing.Point(172, 727);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(108, 31);
            this.lblQuantity.TabIndex = 296;
            this.lblQuantity.Text = "Quantity";
            this.lblQuantity.Click += new System.EventHandler(this.lblQuantity_Click);
            // 
            // btnDeleteLoad
            // 
            this.btnDeleteLoad.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteLoad.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDeleteLoad.ForeColor = System.Drawing.Color.White;
            this.btnDeleteLoad.Location = new System.Drawing.Point(1157, 806);
            this.btnDeleteLoad.Name = "btnDeleteLoad";
            this.btnDeleteLoad.Size = new System.Drawing.Size(250, 66);
            this.btnDeleteLoad.TabIndex = 289;
            this.btnDeleteLoad.Text = "Delete Load";
            this.btnDeleteLoad.UseVisualStyleBackColor = false;
            this.btnDeleteLoad.Click += new System.EventHandler(this.btnDeleteLoad_Click);
            // 
            // cmbTransportUnitId
            // 
            this.cmbTransportUnitId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.cmbTransportUnitId.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.cmbTransportUnitId.FormattingEnabled = true;
            this.cmbTransportUnitId.Location = new System.Drawing.Point(1215, 725);
            this.cmbTransportUnitId.Name = "cmbTransportUnitId";
            this.cmbTransportUnitId.Size = new System.Drawing.Size(517, 39);
            this.cmbTransportUnitId.TabIndex = 303;
            this.cmbTransportUnitId.SelectedIndexChanged += new System.EventHandler(this.cmbTransportUnitId_SelectedIndexChanged);
            // 
            // txtProductItem
            // 
            this.txtProductItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.txtProductItem.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtProductItem.Location = new System.Drawing.Point(346, 621);
            this.txtProductItem.Multiline = true;
            this.txtProductItem.Name = "txtProductItem";
            this.txtProductItem.Size = new System.Drawing.Size(517, 34);
            this.txtProductItem.TabIndex = 299;
            this.txtProductItem.TextChanged += new System.EventHandler(this.txtProductItem_TextChanged);
            // 
            // lblProductItem
            // 
            this.lblProductItem.AutoSize = true;
            this.lblProductItem.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblProductItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblProductItem.Location = new System.Drawing.Point(172, 621);
            this.lblProductItem.Name = "lblProductItem";
            this.lblProductItem.Size = new System.Drawing.Size(154, 31);
            this.lblProductItem.TabIndex = 297;
            this.lblProductItem.Text = "Product Item";
            this.lblProductItem.Click += new System.EventHandler(this.lblProductItem_Click);
            // 
            // txtJobId
            // 
            this.txtJobId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.txtJobId.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtJobId.Location = new System.Drawing.Point(346, 507);
            this.txtJobId.Multiline = true;
            this.txtJobId.Name = "txtJobId";
            this.txtJobId.ReadOnly = true;
            this.txtJobId.Size = new System.Drawing.Size(517, 34);
            this.txtJobId.TabIndex = 293;
            this.txtJobId.TextChanged += new System.EventHandler(this.txtJobId_TextChanged);
            // 
            // lblItemphoto
            // 
            this.lblItemphoto.AutoSize = true;
            this.lblItemphoto.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblItemphoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblItemphoto.Location = new System.Drawing.Point(172, 673);
            this.lblItemphoto.Name = "lblItemphoto";
            this.lblItemphoto.Size = new System.Drawing.Size(134, 31);
            this.lblItemphoto.TabIndex = 302;
            this.lblItemphoto.Text = "Item photo";
            this.lblItemphoto.Click += new System.EventHandler(this.lblItemphoto_Click);
            // 
            // btnAddInvoiceToJob
            // 
            this.btnAddInvoiceToJob.BackColor = System.Drawing.Color.Black;
            this.btnAddInvoiceToJob.Font = new System.Drawing.Font("Baskerville Old Face", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddInvoiceToJob.ForeColor = System.Drawing.Color.White;
            this.btnAddInvoiceToJob.Location = new System.Drawing.Point(178, 903);
            this.btnAddInvoiceToJob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddInvoiceToJob.Name = "btnAddInvoiceToJob";
            this.btnAddInvoiceToJob.Size = new System.Drawing.Size(1554, 69);
            this.btnAddInvoiceToJob.TabIndex = 291;
            this.btnAddInvoiceToJob.Text = "Add Invoice to Job";
            this.btnAddInvoiceToJob.UseVisualStyleBackColor = false;
            this.btnAddInvoiceToJob.Click += new System.EventHandler(this.btnAddInvoiceToJob_Click);
            // 
            // btnSearchLoad
            // 
            this.btnSearchLoad.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSearchLoad.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearchLoad.ForeColor = System.Drawing.Color.White;
            this.btnSearchLoad.Location = new System.Drawing.Point(178, 807);
            this.btnSearchLoad.Name = "btnSearchLoad";
            this.btnSearchLoad.Size = new System.Drawing.Size(250, 66);
            this.btnSearchLoad.TabIndex = 290;
            this.btnSearchLoad.Text = "Search Load";
            this.btnSearchLoad.UseVisualStyleBackColor = false;
            this.btnSearchLoad.Click += new System.EventHandler(this.btnSearchLoad_Click);
            // 
            // btnUpdateLoadDetails
            // 
            this.btnUpdateLoadDetails.BackColor = System.Drawing.Color.DarkOrange;
            this.btnUpdateLoadDetails.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdateLoadDetails.ForeColor = System.Drawing.Color.White;
            this.btnUpdateLoadDetails.Location = new System.Drawing.Point(498, 806);
            this.btnUpdateLoadDetails.Name = "btnUpdateLoadDetails";
            this.btnUpdateLoadDetails.Size = new System.Drawing.Size(250, 66);
            this.btnUpdateLoadDetails.TabIndex = 288;
            this.btnUpdateLoadDetails.Text = "Update Load Details";
            this.btnUpdateLoadDetails.UseVisualStyleBackColor = false;
            this.btnUpdateLoadDetails.Click += new System.EventHandler(this.btnUpdateLoadDetails_Click);
            // 
            // btnAddLoad
            // 
            this.btnAddLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(149)))), ((int)(((byte)(89)))));
            this.btnAddLoad.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddLoad.ForeColor = System.Drawing.Color.White;
            this.btnAddLoad.Location = new System.Drawing.Point(829, 806);
            this.btnAddLoad.Name = "btnAddLoad";
            this.btnAddLoad.Size = new System.Drawing.Size(250, 66);
            this.btnAddLoad.TabIndex = 287;
            this.btnAddLoad.Text = "Add Load";
            this.btnAddLoad.UseVisualStyleBackColor = false;
            this.btnAddLoad.Click += new System.EventHandler(this.btnAddLoad_Click);
            // 
            // btnViewLoad
            // 
            this.btnViewLoad.BackColor = System.Drawing.Color.White;
            this.btnViewLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewLoad.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnViewLoad.ForeColor = System.Drawing.Color.White;
            this.btnViewLoad.Location = new System.Drawing.Point(12, 916);
            this.btnViewLoad.Name = "btnViewLoad";
            this.btnViewLoad.Size = new System.Drawing.Size(92, 66);
            this.btnViewLoad.TabIndex = 286;
            this.btnViewLoad.Text = "View Load";
            this.btnViewLoad.UseVisualStyleBackColor = false;
            this.btnViewLoad.Click += new System.EventHandler(this.btnViewLoad_Click);
            // 
            // cmbLoadStatus
            // 
            this.cmbLoadStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.cmbLoadStatus.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.cmbLoadStatus.FormattingEnabled = true;
            this.cmbLoadStatus.Location = new System.Drawing.Point(1215, 671);
            this.cmbLoadStatus.Name = "cmbLoadStatus";
            this.cmbLoadStatus.Size = new System.Drawing.Size(517, 39);
            this.cmbLoadStatus.TabIndex = 284;
            this.cmbLoadStatus.SelectedIndexChanged += new System.EventHandler(this.cmbLoadStatus_SelectedIndexChanged);
            // 
            // txtLoadId
            // 
            this.txtLoadId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.txtLoadId.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtLoadId.Location = new System.Drawing.Point(346, 566);
            this.txtLoadId.Multiline = true;
            this.txtLoadId.Name = "txtLoadId";
            this.txtLoadId.ReadOnly = true;
            this.txtLoadId.Size = new System.Drawing.Size(517, 34);
            this.txtLoadId.TabIndex = 283;
            this.txtLoadId.TextChanged += new System.EventHandler(this.txtLoadId_TextChanged);
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblWeight.Location = new System.Drawing.Point(998, 507);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(93, 31);
            this.lblWeight.TabIndex = 280;
            this.lblWeight.Text = "Weight";
            this.lblWeight.Click += new System.EventHandler(this.lblWeight_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.txtDescription.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtDescription.Location = new System.Drawing.Point(1215, 621);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(517, 34);
            this.txtDescription.TabIndex = 279;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // lblJobId
            // 
            this.lblJobId.AutoSize = true;
            this.lblJobId.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblJobId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblJobId.Location = new System.Drawing.Point(172, 507);
            this.lblJobId.Name = "lblJobId";
            this.lblJobId.Size = new System.Drawing.Size(79, 31);
            this.lblJobId.TabIndex = 277;
            this.lblJobId.Text = "Job id";
            this.lblJobId.Click += new System.EventHandler(this.lblJobId_Click);
            // 
            // lblLoadId
            // 
            this.lblLoadId.AutoSize = true;
            this.lblLoadId.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblLoadId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblLoadId.Location = new System.Drawing.Point(172, 566);
            this.lblLoadId.Name = "lblLoadId";
            this.lblLoadId.Size = new System.Drawing.Size(93, 31);
            this.lblLoadId.TabIndex = 276;
            this.lblLoadId.Text = "Load id";
            this.lblLoadId.Click += new System.EventHandler(this.lblLoadId_Click);
            // 
            // lblLoadManagement
            // 
            this.lblLoadManagement.AutoSize = true;
            this.lblLoadManagement.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.8F);
            this.lblLoadManagement.ForeColor = System.Drawing.Color.White;
            this.lblLoadManagement.Location = new System.Drawing.Point(757, 10);
            this.lblLoadManagement.Name = "lblLoadManagement";
            this.lblLoadManagement.Size = new System.Drawing.Size(410, 50);
            this.lblLoadManagement.TabIndex = 275;
            this.lblLoadManagement.Text = "Load Management";
            this.lblLoadManagement.Click += new System.EventHandler(this.lblLoadManagement_Click);
            // 
            // lblTransportUnitId
            // 
            this.lblTransportUnitId.AutoSize = true;
            this.lblTransportUnitId.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblTransportUnitId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblTransportUnitId.Location = new System.Drawing.Point(998, 727);
            this.lblTransportUnitId.Name = "lblTransportUnitId";
            this.lblTransportUnitId.Size = new System.Drawing.Size(198, 31);
            this.lblTransportUnitId.TabIndex = 285;
            this.lblTransportUnitId.Text = "Transport Unit Id";
            this.lblTransportUnitId.Click += new System.EventHandler(this.lblTransportUnitId_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblStatus.Location = new System.Drawing.Point(998, 673);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(81, 31);
            this.lblStatus.TabIndex = 282;
            this.lblStatus.Text = "Status";
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // txtWeight
            // 
            this.txtWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.txtWeight.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtWeight.Location = new System.Drawing.Point(1215, 507);
            this.txtWeight.Multiline = true;
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(517, 34);
            this.txtWeight.TabIndex = 281;
            this.txtWeight.TextChanged += new System.EventHandler(this.txtWeight_TextChanged);
            // 
            // pnlFilter
            // 
            this.pnlFilter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFilter.Controls.Add(this.btnApplyStatusFilter);
            this.pnlFilter.Controls.Add(this.lblFilterByStatus);
            this.pnlFilter.Controls.Add(this.cmbFilterByLoadStatus);
            this.pnlFilter.Location = new System.Drawing.Point(181, 168);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(622, 67);
            this.pnlFilter.TabIndex = 292;
            this.pnlFilter.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFilter_Paint);
            // 
            // btnApplyStatusFilter
            // 
            this.btnApplyStatusFilter.BackColor = System.Drawing.Color.Black;
            this.btnApplyStatusFilter.Font = new System.Drawing.Font("Gadugi", 10.2F);
            this.btnApplyStatusFilter.ForeColor = System.Drawing.Color.White;
            this.btnApplyStatusFilter.Location = new System.Drawing.Point(398, 8);
            this.btnApplyStatusFilter.Name = "btnApplyStatusFilter";
            this.btnApplyStatusFilter.Size = new System.Drawing.Size(178, 48);
            this.btnApplyStatusFilter.TabIndex = 149;
            this.btnApplyStatusFilter.Text = "Apply Status Filter";
            this.btnApplyStatusFilter.UseVisualStyleBackColor = false;
            this.btnApplyStatusFilter.Click += new System.EventHandler(this.btnApplyStatusFilter_Click);
            // 
            // lblFilterByStatus
            // 
            this.lblFilterByStatus.AutoSize = true;
            this.lblFilterByStatus.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterByStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblFilterByStatus.Location = new System.Drawing.Point(15, 25);
            this.lblFilterByStatus.Name = "lblFilterByStatus";
            this.lblFilterByStatus.Size = new System.Drawing.Size(119, 20);
            this.lblFilterByStatus.TabIndex = 143;
            this.lblFilterByStatus.Text = "Filter by status";
            this.lblFilterByStatus.Click += new System.EventHandler(this.lblFilterByStatus_Click);
            // 
            // cmbFilterByLoadStatus
            // 
            this.cmbFilterByLoadStatus.Font = new System.Drawing.Font("Gadugi", 10.2F);
            this.cmbFilterByLoadStatus.FormattingEnabled = true;
            this.cmbFilterByLoadStatus.Location = new System.Drawing.Point(183, 19);
            this.cmbFilterByLoadStatus.Name = "cmbFilterByLoadStatus";
            this.cmbFilterByLoadStatus.Size = new System.Drawing.Size(200, 28);
            this.cmbFilterByLoadStatus.TabIndex = 144;
            this.cmbFilterByLoadStatus.SelectedIndexChanged += new System.EventHandler(this.cmbFilterByLoadStatus_SelectedIndexChanged);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblDescription.Location = new System.Drawing.Point(998, 621);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(138, 31);
            this.lblDescription.TabIndex = 278;
            this.lblDescription.Text = "Description";
            this.lblDescription.Click += new System.EventHandler(this.lblDescription_Click);
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
            this.menuStrip2.TabIndex = 273;
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
            // picUploadedPhoto
            // 
            this.picUploadedPhoto.BackColor = System.Drawing.Color.White;
            this.picUploadedPhoto.Location = new System.Drawing.Point(813, 665);
            this.picUploadedPhoto.Name = "picUploadedPhoto";
            this.picUploadedPhoto.Size = new System.Drawing.Size(50, 50);
            this.picUploadedPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUploadedPhoto.TabIndex = 301;
            this.picUploadedPhoto.TabStop = false;
            this.picUploadedPhoto.Click += new System.EventHandler(this.picUploadedPhoto_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = global::E_Shift.Properties.Resources.Delivery_Express_Logo__3_;
            this.picLogo.Location = new System.Drawing.Point(103, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(98, 68);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 274;
            this.picLogo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.panel1.Controls.Add(this.lblLoadManagement);
            this.panel1.Location = new System.Drawing.Point(0, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2064, 70);
            this.panel1.TabIndex = 306;
            // 
            // frmLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 994);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.picUploadedPhoto);
            this.Controls.Add(this.btnUploadPhoto);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.btnDeleteLoad);
            this.Controls.Add(this.cmbTransportUnitId);
            this.Controls.Add(this.txtProductItem);
            this.Controls.Add(this.lblProductItem);
            this.Controls.Add(this.txtJobId);
            this.Controls.Add(this.lblItemphoto);
            this.Controls.Add(this.btnAddInvoiceToJob);
            this.Controls.Add(this.btnSearchLoad);
            this.Controls.Add(this.btnUpdateLoadDetails);
            this.Controls.Add(this.btnAddLoad);
            this.Controls.Add(this.btnViewLoad);
            this.Controls.Add(this.cmbLoadStatus);
            this.Controls.Add(this.txtLoadId);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblJobId);
            this.Controls.Add(this.lblLoadId);
            this.Controls.Add(this.lblTransportUnitId);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.dgvLoad);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmLoad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Load";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLoad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoad)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUploadedPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLoad;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.PictureBox picUploadedPhoto;
        private System.Windows.Forms.Button btnUploadPhoto;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnDeleteLoad;
        private System.Windows.Forms.ComboBox cmbTransportUnitId;
        private System.Windows.Forms.TextBox txtProductItem;
        private System.Windows.Forms.Label lblProductItem;
        private System.Windows.Forms.TextBox txtJobId;
        private System.Windows.Forms.Label lblItemphoto;
        private System.Windows.Forms.Button btnAddInvoiceToJob;
        private System.Windows.Forms.Button btnSearchLoad;
        private System.Windows.Forms.Button btnUpdateLoadDetails;
        private System.Windows.Forms.Button btnAddLoad;
        private System.Windows.Forms.Button btnViewLoad;
        private System.Windows.Forms.ComboBox cmbLoadStatus;
        private System.Windows.Forms.TextBox txtLoadId;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblJobId;
        private System.Windows.Forms.Label lblLoadId;
        private System.Windows.Forms.Label lblLoadManagement;
        private System.Windows.Forms.Label lblTransportUnitId;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Button btnApplyStatusFilter;
        private System.Windows.Forms.Label lblFilterByStatus;
        private System.Windows.Forms.ComboBox cmbFilterByLoadStatus;
        private System.Windows.Forms.Label lblDescription;
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
    }
}