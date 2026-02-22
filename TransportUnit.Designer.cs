namespace E_Shift
{
    partial class frmTransportUnit
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
            this.lblLorry = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtLorryCapacity = new System.Windows.Forms.TextBox();
            this.lblLorryCapacity = new System.Windows.Forms.Label();
            this.txtLorryModel = new System.Windows.Forms.TextBox();
            this.lblLorryModel = new System.Windows.Forms.Label();
            this.lblLorryNumberPlate = new System.Windows.Forms.Label();
            this.txtLorryNumberPlate = new System.Windows.Forms.TextBox();
            this.lblAssistant = new System.Windows.Forms.Label();
            this.btnSearchTransportunit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDeleteTransportunit = new System.Windows.Forms.Button();
            this.btnUpdateTransportunit = new System.Windows.Forms.Button();
            this.btnAddTransportunit = new System.Windows.Forms.Button();
            this.btnViewTransportunit = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblIsAvailable = new System.Windows.Forms.Label();
            this.cmbIsAvailable = new System.Windows.Forms.ComboBox();
            this.dgvTransportUnit = new System.Windows.Forms.DataGridView();
            this.lblContainer = new System.Windows.Forms.Label();
            this.lblDriver = new System.Windows.Forms.Label();
            this.txtTransportUnitId = new System.Windows.Forms.TextBox();
            this.lblTransportUnitId = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDriverName = new System.Windows.Forms.Label();
            this.lblDriverNIC = new System.Windows.Forms.Label();
            this.txtDriverContact = new System.Windows.Forms.TextBox();
            this.lblDriverContact = new System.Windows.Forms.Label();
            this.txtDriverName = new System.Windows.Forms.TextBox();
            this.txtDriverNIC = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblAssistantAddress = new System.Windows.Forms.Label();
            this.txtAssistantAddress = new System.Windows.Forms.TextBox();
            this.lblAssistantContact = new System.Windows.Forms.Label();
            this.txtAssistantContact = new System.Windows.Forms.TextBox();
            this.lblAssistantName = new System.Windows.Forms.Label();
            this.txtAssistantName = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbContainerCondition = new System.Windows.Forms.ComboBox();
            this.lblContainerNumber = new System.Windows.Forms.Label();
            this.lblContainerCondition = new System.Windows.Forms.Label();
            this.txtContainerNumber = new System.Windows.Forms.TextBox();
            this.txtContainerSize = new System.Windows.Forms.TextBox();
            this.lblContainerSize = new System.Windows.Forms.Label();
            this.lblTransportUnitManagement = new System.Windows.Forms.Label();
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
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransportUnit)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLorry
            // 
            this.lblLorry.AutoSize = true;
            this.lblLorry.Font = new System.Drawing.Font("Gabriola", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLorry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(123)))), ((int)(((byte)(209)))));
            this.lblLorry.Location = new System.Drawing.Point(159, 394);
            this.lblLorry.Name = "lblLorry";
            this.lblLorry.Size = new System.Drawing.Size(85, 60);
            this.lblLorry.TabIndex = 237;
            this.lblLorry.Text = "Lorry";
            this.lblLorry.Click += new System.EventHandler(this.lblLorry_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtLorryCapacity);
            this.panel1.Controls.Add(this.lblLorryCapacity);
            this.panel1.Controls.Add(this.txtLorryModel);
            this.panel1.Controls.Add(this.lblLorryModel);
            this.panel1.Controls.Add(this.lblLorryNumberPlate);
            this.panel1.Controls.Add(this.txtLorryNumberPlate);
            this.panel1.Location = new System.Drawing.Point(140, 425);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 168);
            this.panel1.TabIndex = 250;
            // 
            // txtLorryCapacity
            // 
            this.txtLorryCapacity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.txtLorryCapacity.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtLorryCapacity.Location = new System.Drawing.Point(232, 116);
            this.txtLorryCapacity.Multiline = true;
            this.txtLorryCapacity.Name = "txtLorryCapacity";
            this.txtLorryCapacity.Size = new System.Drawing.Size(517, 34);
            this.txtLorryCapacity.TabIndex = 175;
            this.txtLorryCapacity.TextChanged += new System.EventHandler(this.txtLorryCapacity_TextChanged);
            // 
            // lblLorryCapacity
            // 
            this.lblLorryCapacity.AutoSize = true;
            this.lblLorryCapacity.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblLorryCapacity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblLorryCapacity.Location = new System.Drawing.Point(7, 114);
            this.lblLorryCapacity.Name = "lblLorryCapacity";
            this.lblLorryCapacity.Size = new System.Drawing.Size(167, 31);
            this.lblLorryCapacity.TabIndex = 174;
            this.lblLorryCapacity.Text = "Lorry Capacity";
            this.lblLorryCapacity.Click += new System.EventHandler(this.lblLorryCapacity_Click);
            // 
            // txtLorryModel
            // 
            this.txtLorryModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.txtLorryModel.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtLorryModel.Location = new System.Drawing.Point(232, 69);
            this.txtLorryModel.Multiline = true;
            this.txtLorryModel.Name = "txtLorryModel";
            this.txtLorryModel.Size = new System.Drawing.Size(517, 34);
            this.txtLorryModel.TabIndex = 173;
            this.txtLorryModel.TextChanged += new System.EventHandler(this.txtLorryModel_TextChanged);
            // 
            // lblLorryModel
            // 
            this.lblLorryModel.AutoSize = true;
            this.lblLorryModel.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblLorryModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblLorryModel.Location = new System.Drawing.Point(7, 67);
            this.lblLorryModel.Name = "lblLorryModel";
            this.lblLorryModel.Size = new System.Drawing.Size(145, 31);
            this.lblLorryModel.TabIndex = 145;
            this.lblLorryModel.Text = "Lorry Model";
            this.lblLorryModel.Click += new System.EventHandler(this.lblLorryModel_Click);
            // 
            // lblLorryNumberPlate
            // 
            this.lblLorryNumberPlate.AutoSize = true;
            this.lblLorryNumberPlate.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblLorryNumberPlate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblLorryNumberPlate.Location = new System.Drawing.Point(7, 19);
            this.lblLorryNumberPlate.Name = "lblLorryNumberPlate";
            this.lblLorryNumberPlate.Size = new System.Drawing.Size(224, 31);
            this.lblLorryNumberPlate.TabIndex = 170;
            this.lblLorryNumberPlate.Text = "Lorry Number Plate";
            this.lblLorryNumberPlate.Click += new System.EventHandler(this.lblLorryNumberPlate_Click);
            // 
            // txtLorryNumberPlate
            // 
            this.txtLorryNumberPlate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.txtLorryNumberPlate.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtLorryNumberPlate.Location = new System.Drawing.Point(232, 21);
            this.txtLorryNumberPlate.Multiline = true;
            this.txtLorryNumberPlate.Name = "txtLorryNumberPlate";
            this.txtLorryNumberPlate.Size = new System.Drawing.Size(517, 34);
            this.txtLorryNumberPlate.TabIndex = 172;
            this.txtLorryNumberPlate.TextChanged += new System.EventHandler(this.txtLorryNumberPlate_TextChanged);
            // 
            // lblAssistant
            // 
            this.lblAssistant.AutoSize = true;
            this.lblAssistant.Font = new System.Drawing.Font("Gabriola", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssistant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(123)))), ((int)(((byte)(209)))));
            this.lblAssistant.Location = new System.Drawing.Point(1034, 394);
            this.lblAssistant.Name = "lblAssistant";
            this.lblAssistant.Size = new System.Drawing.Size(128, 60);
            this.lblAssistant.TabIndex = 249;
            this.lblAssistant.Text = "Assistant";
            this.lblAssistant.Click += new System.EventHandler(this.lblAssistant_Click);
            // 
            // btnSearchTransportunit
            // 
            this.btnSearchTransportunit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSearchTransportunit.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearchTransportunit.ForeColor = System.Drawing.Color.White;
            this.btnSearchTransportunit.Location = new System.Drawing.Point(140, 905);
            this.btnSearchTransportunit.Name = "btnSearchTransportunit";
            this.btnSearchTransportunit.Size = new System.Drawing.Size(250, 66);
            this.btnSearchTransportunit.TabIndex = 248;
            this.btnSearchTransportunit.Text = "Search Transportunit";
            this.btnSearchTransportunit.UseVisualStyleBackColor = false;
            this.btnSearchTransportunit.Click += new System.EventHandler(this.btnSearchTransportunit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnClear.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(1531, 905);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(250, 66);
            this.btnClear.TabIndex = 247;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDeleteTransportunit
            // 
            this.btnDeleteTransportunit.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteTransportunit.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDeleteTransportunit.ForeColor = System.Drawing.Color.White;
            this.btnDeleteTransportunit.Location = new System.Drawing.Point(1189, 905);
            this.btnDeleteTransportunit.Name = "btnDeleteTransportunit";
            this.btnDeleteTransportunit.Size = new System.Drawing.Size(250, 66);
            this.btnDeleteTransportunit.TabIndex = 246;
            this.btnDeleteTransportunit.Text = "Delete Transportunit";
            this.btnDeleteTransportunit.UseVisualStyleBackColor = false;
            this.btnDeleteTransportunit.Click += new System.EventHandler(this.btnDeleteTransportunit_Click);
            // 
            // btnUpdateTransportunit
            // 
            this.btnUpdateTransportunit.BackColor = System.Drawing.Color.DarkOrange;
            this.btnUpdateTransportunit.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdateTransportunit.ForeColor = System.Drawing.Color.White;
            this.btnUpdateTransportunit.Location = new System.Drawing.Point(487, 905);
            this.btnUpdateTransportunit.Name = "btnUpdateTransportunit";
            this.btnUpdateTransportunit.Size = new System.Drawing.Size(250, 66);
            this.btnUpdateTransportunit.TabIndex = 245;
            this.btnUpdateTransportunit.Text = "Update Transportunit";
            this.btnUpdateTransportunit.UseVisualStyleBackColor = false;
            this.btnUpdateTransportunit.Click += new System.EventHandler(this.btnUpdateTransportunit_Click);
            // 
            // btnAddTransportunit
            // 
            this.btnAddTransportunit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(149)))), ((int)(((byte)(89)))));
            this.btnAddTransportunit.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddTransportunit.ForeColor = System.Drawing.Color.White;
            this.btnAddTransportunit.Location = new System.Drawing.Point(844, 905);
            this.btnAddTransportunit.Name = "btnAddTransportunit";
            this.btnAddTransportunit.Size = new System.Drawing.Size(250, 66);
            this.btnAddTransportunit.TabIndex = 244;
            this.btnAddTransportunit.Text = "Add Transportunit";
            this.btnAddTransportunit.UseVisualStyleBackColor = false;
            this.btnAddTransportunit.Click += new System.EventHandler(this.btnAddTransportunit_Click);
            // 
            // btnViewTransportunit
            // 
            this.btnViewTransportunit.BackColor = System.Drawing.Color.White;
            this.btnViewTransportunit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewTransportunit.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnViewTransportunit.ForeColor = System.Drawing.Color.White;
            this.btnViewTransportunit.Location = new System.Drawing.Point(12, 903);
            this.btnViewTransportunit.Name = "btnViewTransportunit";
            this.btnViewTransportunit.Size = new System.Drawing.Size(70, 68);
            this.btnViewTransportunit.TabIndex = 243;
            this.btnViewTransportunit.Text = "View Transportunit";
            this.btnViewTransportunit.UseVisualStyleBackColor = false;
            this.btnViewTransportunit.Click += new System.EventHandler(this.btnViewTransportunit_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.lblIsAvailable);
            this.panel5.Controls.Add(this.cmbIsAvailable);
            this.panel5.Location = new System.Drawing.Point(605, 832);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(766, 54);
            this.panel5.TabIndex = 240;
            // 
            // lblIsAvailable
            // 
            this.lblIsAvailable.AutoSize = true;
            this.lblIsAvailable.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsAvailable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblIsAvailable.Location = new System.Drawing.Point(23, 6);
            this.lblIsAvailable.Name = "lblIsAvailable";
            this.lblIsAvailable.Size = new System.Drawing.Size(107, 42);
            this.lblIsAvailable.TabIndex = 209;
            this.lblIsAvailable.Text = "Is Available";
            this.lblIsAvailable.Click += new System.EventHandler(this.lblIsAvailable_Click);
            // 
            // cmbIsAvailable
            // 
            this.cmbIsAvailable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.cmbIsAvailable.Font = new System.Drawing.Font("Gadugi", 13.8F);
            this.cmbIsAvailable.FormattingEnabled = true;
            this.cmbIsAvailable.Location = new System.Drawing.Point(227, 8);
            this.cmbIsAvailable.Name = "cmbIsAvailable";
            this.cmbIsAvailable.Size = new System.Drawing.Size(517, 35);
            this.cmbIsAvailable.TabIndex = 179;
            this.cmbIsAvailable.SelectedIndexChanged += new System.EventHandler(this.cmbIsAvailable_SelectedIndexChanged);
            // 
            // dgvTransportUnit
            // 
            this.dgvTransportUnit.BackgroundColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransportUnit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTransportUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTransportUnit.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTransportUnit.GridColor = System.Drawing.Color.DeepSkyBlue;
            this.dgvTransportUnit.Location = new System.Drawing.Point(0, 161);
            this.dgvTransportUnit.Name = "dgvTransportUnit";
            this.dgvTransportUnit.RowHeadersWidth = 51;
            this.dgvTransportUnit.RowTemplate.Height = 24;
            this.dgvTransportUnit.Size = new System.Drawing.Size(2064, 175);
            this.dgvTransportUnit.TabIndex = 242;
            this.dgvTransportUnit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransportUnit_CellContentClick);
            this.dgvTransportUnit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransportUnit_CellContentClick);
            // 
            // lblContainer
            // 
            this.lblContainer.AutoSize = true;
            this.lblContainer.Font = new System.Drawing.Font("Gabriola", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContainer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(123)))), ((int)(((byte)(209)))));
            this.lblContainer.Location = new System.Drawing.Point(1026, 604);
            this.lblContainer.Name = "lblContainer";
            this.lblContainer.Size = new System.Drawing.Size(136, 60);
            this.lblContainer.TabIndex = 241;
            this.lblContainer.Text = "Container";
            this.lblContainer.Click += new System.EventHandler(this.lblContainer_Click);
            // 
            // lblDriver
            // 
            this.lblDriver.AutoSize = true;
            this.lblDriver.Font = new System.Drawing.Font("Gabriola", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(123)))), ((int)(((byte)(209)))));
            this.lblDriver.Location = new System.Drawing.Point(159, 604);
            this.lblDriver.Name = "lblDriver";
            this.lblDriver.Size = new System.Drawing.Size(96, 60);
            this.lblDriver.TabIndex = 238;
            this.lblDriver.Text = "Driver";
            this.lblDriver.Click += new System.EventHandler(this.lblDriver_Click);
            // 
            // txtTransportUnitId
            // 
            this.txtTransportUnitId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.txtTransportUnitId.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtTransportUnitId.Location = new System.Drawing.Point(374, 366);
            this.txtTransportUnitId.Multiline = true;
            this.txtTransportUnitId.Name = "txtTransportUnitId";
            this.txtTransportUnitId.ReadOnly = true;
            this.txtTransportUnitId.Size = new System.Drawing.Size(517, 34);
            this.txtTransportUnitId.TabIndex = 234;
            this.txtTransportUnitId.TextChanged += new System.EventHandler(this.txtTransportUnitId_TextChanged);
            // 
            // lblTransportUnitId
            // 
            this.lblTransportUnitId.AutoSize = true;
            this.lblTransportUnitId.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblTransportUnitId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblTransportUnitId.Location = new System.Drawing.Point(134, 366);
            this.lblTransportUnitId.Name = "lblTransportUnitId";
            this.lblTransportUnitId.Size = new System.Drawing.Size(201, 31);
            this.lblTransportUnitId.TabIndex = 233;
            this.lblTransportUnitId.Text = "Transport Unit ID";
            this.lblTransportUnitId.Click += new System.EventHandler(this.lblTransportUnitId_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblDriverName);
            this.panel2.Controls.Add(this.lblDriverNIC);
            this.panel2.Controls.Add(this.txtDriverContact);
            this.panel2.Controls.Add(this.lblDriverContact);
            this.panel2.Controls.Add(this.txtDriverName);
            this.panel2.Controls.Add(this.txtDriverNIC);
            this.panel2.Location = new System.Drawing.Point(140, 643);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(766, 172);
            this.panel2.TabIndex = 235;
            // 
            // lblDriverName
            // 
            this.lblDriverName.AutoSize = true;
            this.lblDriverName.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblDriverName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblDriverName.Location = new System.Drawing.Point(7, 11);
            this.lblDriverName.Name = "lblDriverName";
            this.lblDriverName.Size = new System.Drawing.Size(149, 31);
            this.lblDriverName.TabIndex = 147;
            this.lblDriverName.Text = "Driver Name";
            this.lblDriverName.Click += new System.EventHandler(this.lblDriverName_Click);
            // 
            // lblDriverNIC
            // 
            this.lblDriverNIC.AutoSize = true;
            this.lblDriverNIC.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblDriverNIC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblDriverNIC.Location = new System.Drawing.Point(7, 59);
            this.lblDriverNIC.Name = "lblDriverNIC";
            this.lblDriverNIC.Size = new System.Drawing.Size(125, 31);
            this.lblDriverNIC.TabIndex = 178;
            this.lblDriverNIC.Text = "Driver NIC";
            this.lblDriverNIC.Click += new System.EventHandler(this.lblDriverNIC_Click);
            // 
            // txtDriverContact
            // 
            this.txtDriverContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.txtDriverContact.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtDriverContact.Location = new System.Drawing.Point(232, 119);
            this.txtDriverContact.Multiline = true;
            this.txtDriverContact.Name = "txtDriverContact";
            this.txtDriverContact.Size = new System.Drawing.Size(517, 34);
            this.txtDriverContact.TabIndex = 177;
            this.txtDriverContact.TextChanged += new System.EventHandler(this.txtDriverContact_TextChanged);
            // 
            // lblDriverContact
            // 
            this.lblDriverContact.AutoSize = true;
            this.lblDriverContact.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblDriverContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblDriverContact.Location = new System.Drawing.Point(7, 111);
            this.lblDriverContact.Name = "lblDriverContact";
            this.lblDriverContact.Size = new System.Drawing.Size(169, 31);
            this.lblDriverContact.TabIndex = 176;
            this.lblDriverContact.Text = "Driver Contact";
            this.lblDriverContact.Click += new System.EventHandler(this.lblDriverContact_Click);
            // 
            // txtDriverName
            // 
            this.txtDriverName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.txtDriverName.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtDriverName.Location = new System.Drawing.Point(232, 13);
            this.txtDriverName.Multiline = true;
            this.txtDriverName.Name = "txtDriverName";
            this.txtDriverName.Size = new System.Drawing.Size(517, 34);
            this.txtDriverName.TabIndex = 174;
            this.txtDriverName.TextChanged += new System.EventHandler(this.txtDriverName_TextChanged);
            // 
            // txtDriverNIC
            // 
            this.txtDriverNIC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.txtDriverNIC.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtDriverNIC.Location = new System.Drawing.Point(232, 67);
            this.txtDriverNIC.Multiline = true;
            this.txtDriverNIC.Name = "txtDriverNIC";
            this.txtDriverNIC.Size = new System.Drawing.Size(517, 34);
            this.txtDriverNIC.TabIndex = 175;
            this.txtDriverNIC.TextChanged += new System.EventHandler(this.txtDriverNIC_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblAssistantAddress);
            this.panel3.Controls.Add(this.txtAssistantAddress);
            this.panel3.Controls.Add(this.lblAssistantContact);
            this.panel3.Controls.Add(this.txtAssistantContact);
            this.panel3.Controls.Add(this.lblAssistantName);
            this.panel3.Controls.Add(this.txtAssistantName);
            this.panel3.Location = new System.Drawing.Point(1015, 425);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(766, 168);
            this.panel3.TabIndex = 236;
            // 
            // lblAssistantAddress
            // 
            this.lblAssistantAddress.AutoSize = true;
            this.lblAssistantAddress.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblAssistantAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblAssistantAddress.Location = new System.Drawing.Point(12, 106);
            this.lblAssistantAddress.Name = "lblAssistantAddress";
            this.lblAssistantAddress.Size = new System.Drawing.Size(202, 31);
            this.lblAssistantAddress.TabIndex = 179;
            this.lblAssistantAddress.Text = "Assistant Address";
            this.lblAssistantAddress.Click += new System.EventHandler(this.lblAssistantAddress_Click);
            // 
            // txtAssistantAddress
            // 
            this.txtAssistantAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.txtAssistantAddress.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtAssistantAddress.Location = new System.Drawing.Point(227, 114);
            this.txtAssistantAddress.Multiline = true;
            this.txtAssistantAddress.Name = "txtAssistantAddress";
            this.txtAssistantAddress.Size = new System.Drawing.Size(517, 34);
            this.txtAssistantAddress.TabIndex = 180;
            this.txtAssistantAddress.TextChanged += new System.EventHandler(this.txtAssistantAddress_TextChanged);
            // 
            // lblAssistantContact
            // 
            this.lblAssistantContact.AutoSize = true;
            this.lblAssistantContact.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblAssistantContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblAssistantContact.Location = new System.Drawing.Point(12, 61);
            this.lblAssistantContact.Name = "lblAssistantContact";
            this.lblAssistantContact.Size = new System.Drawing.Size(200, 31);
            this.lblAssistantContact.TabIndex = 177;
            this.lblAssistantContact.Text = "Assistant Contact";
            this.lblAssistantContact.Click += new System.EventHandler(this.lblAssistantContact_Click);
            // 
            // txtAssistantContact
            // 
            this.txtAssistantContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.txtAssistantContact.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtAssistantContact.Location = new System.Drawing.Point(227, 67);
            this.txtAssistantContact.Multiline = true;
            this.txtAssistantContact.Name = "txtAssistantContact";
            this.txtAssistantContact.Size = new System.Drawing.Size(517, 34);
            this.txtAssistantContact.TabIndex = 178;
            this.txtAssistantContact.TextChanged += new System.EventHandler(this.txtAssistantContact_TextChanged);
            // 
            // lblAssistantName
            // 
            this.lblAssistantName.AutoSize = true;
            this.lblAssistantName.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblAssistantName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblAssistantName.Location = new System.Drawing.Point(12, 17);
            this.lblAssistantName.Name = "lblAssistantName";
            this.lblAssistantName.Size = new System.Drawing.Size(180, 31);
            this.lblAssistantName.TabIndex = 149;
            this.lblAssistantName.Text = "Assistant Name";
            this.lblAssistantName.Click += new System.EventHandler(this.lblAssistantName_Click);
            // 
            // txtAssistantName
            // 
            this.txtAssistantName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.txtAssistantName.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtAssistantName.Location = new System.Drawing.Point(227, 19);
            this.txtAssistantName.Multiline = true;
            this.txtAssistantName.Name = "txtAssistantName";
            this.txtAssistantName.Size = new System.Drawing.Size(517, 34);
            this.txtAssistantName.TabIndex = 176;
            this.txtAssistantName.TextChanged += new System.EventHandler(this.txtAssistantName_TextChanged);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.cmbContainerCondition);
            this.panel4.Controls.Add(this.lblContainerNumber);
            this.panel4.Controls.Add(this.lblContainerCondition);
            this.panel4.Controls.Add(this.txtContainerNumber);
            this.panel4.Controls.Add(this.txtContainerSize);
            this.panel4.Controls.Add(this.lblContainerSize);
            this.panel4.Location = new System.Drawing.Point(1015, 643);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(766, 172);
            this.panel4.TabIndex = 239;
            // 
            // cmbContainerCondition
            // 
            this.cmbContainerCondition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.cmbContainerCondition.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.cmbContainerCondition.FormattingEnabled = true;
            this.cmbContainerCondition.Location = new System.Drawing.Point(227, 115);
            this.cmbContainerCondition.Name = "cmbContainerCondition";
            this.cmbContainerCondition.Size = new System.Drawing.Size(517, 39);
            this.cmbContainerCondition.TabIndex = 181;
            this.cmbContainerCondition.SelectedIndexChanged += new System.EventHandler(this.cmbContainerCondition_SelectedIndexChanged);
            // 
            // lblContainerNumber
            // 
            this.lblContainerNumber.AutoSize = true;
            this.lblContainerNumber.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblContainerNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblContainerNumber.Location = new System.Drawing.Point(13, 13);
            this.lblContainerNumber.Name = "lblContainerNumber";
            this.lblContainerNumber.Size = new System.Drawing.Size(213, 31);
            this.lblContainerNumber.TabIndex = 151;
            this.lblContainerNumber.Text = "Container Number";
            this.lblContainerNumber.Click += new System.EventHandler(this.lblContainerNumber_Click);
            // 
            // lblContainerCondition
            // 
            this.lblContainerCondition.AutoSize = true;
            this.lblContainerCondition.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblContainerCondition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblContainerCondition.Location = new System.Drawing.Point(13, 113);
            this.lblContainerCondition.Name = "lblContainerCondition";
            this.lblContainerCondition.Size = new System.Drawing.Size(232, 31);
            this.lblContainerCondition.TabIndex = 180;
            this.lblContainerCondition.Text = "Container Condition";
            this.lblContainerCondition.Click += new System.EventHandler(this.lblContainerCondition_Click);
            // 
            // txtContainerNumber
            // 
            this.txtContainerNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.txtContainerNumber.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtContainerNumber.Location = new System.Drawing.Point(227, 19);
            this.txtContainerNumber.Multiline = true;
            this.txtContainerNumber.Name = "txtContainerNumber";
            this.txtContainerNumber.Size = new System.Drawing.Size(517, 34);
            this.txtContainerNumber.TabIndex = 178;
            this.txtContainerNumber.TextChanged += new System.EventHandler(this.txtContainerNumber_TextChanged);
            // 
            // txtContainerSize
            // 
            this.txtContainerSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.txtContainerSize.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtContainerSize.Location = new System.Drawing.Point(227, 69);
            this.txtContainerSize.Multiline = true;
            this.txtContainerSize.Name = "txtContainerSize";
            this.txtContainerSize.Size = new System.Drawing.Size(517, 34);
            this.txtContainerSize.TabIndex = 179;
            this.txtContainerSize.TextChanged += new System.EventHandler(this.txtContainerSize_TextChanged);
            // 
            // lblContainerSize
            // 
            this.lblContainerSize.AutoSize = true;
            this.lblContainerSize.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblContainerSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.lblContainerSize.Location = new System.Drawing.Point(13, 58);
            this.lblContainerSize.Name = "lblContainerSize";
            this.lblContainerSize.Size = new System.Drawing.Size(168, 31);
            this.lblContainerSize.TabIndex = 178;
            this.lblContainerSize.Text = "Container Size";
            this.lblContainerSize.Click += new System.EventHandler(this.lblContainerSize_Click);
            // 
            // lblTransportUnitManagement
            // 
            this.lblTransportUnitManagement.AutoSize = true;
            this.lblTransportUnitManagement.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.8F);
            this.lblTransportUnitManagement.ForeColor = System.Drawing.Color.White;
            this.lblTransportUnitManagement.Location = new System.Drawing.Point(655, 9);
            this.lblTransportUnitManagement.Name = "lblTransportUnitManagement";
            this.lblTransportUnitManagement.Size = new System.Drawing.Size(610, 50);
            this.lblTransportUnitManagement.TabIndex = 232;
            this.lblTransportUnitManagement.Text = "Transport Unit Management";
            this.lblTransportUnitManagement.Click += new System.EventHandler(this.lblTransportUnitManagement_Click);
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
            this.menuStrip2.TabIndex = 230;
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
            this.picLogo.TabIndex = 231;
            this.picLogo.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.panel6.Controls.Add(this.lblTransportUnitManagement);
            this.panel6.Location = new System.Drawing.Point(0, 85);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(2064, 70);
            this.panel6.TabIndex = 307;
            // 
            // frmTransportUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 994);
            this.Controls.Add(this.lblDriver);
            this.Controls.Add(this.lblLorry);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblAssistant);
            this.Controls.Add(this.btnSearchTransportunit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDeleteTransportunit);
            this.Controls.Add(this.btnUpdateTransportunit);
            this.Controls.Add(this.btnAddTransportunit);
            this.Controls.Add(this.btnViewTransportunit);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.lblContainer);
            this.Controls.Add(this.txtTransportUnitId);
            this.Controls.Add(this.lblTransportUnitId);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.dgvTransportUnit);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmTransportUnit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TransportUnit";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTransportUnit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransportUnit)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLorry;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtLorryCapacity;
        private System.Windows.Forms.Label lblLorryCapacity;
        private System.Windows.Forms.TextBox txtLorryModel;
        private System.Windows.Forms.Label lblLorryModel;
        private System.Windows.Forms.Label lblLorryNumberPlate;
        private System.Windows.Forms.TextBox txtLorryNumberPlate;
        private System.Windows.Forms.Label lblAssistant;
        private System.Windows.Forms.Button btnSearchTransportunit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDeleteTransportunit;
        private System.Windows.Forms.Button btnUpdateTransportunit;
        private System.Windows.Forms.Button btnAddTransportunit;
        private System.Windows.Forms.Button btnViewTransportunit;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblIsAvailable;
        private System.Windows.Forms.ComboBox cmbIsAvailable;
        private System.Windows.Forms.DataGridView dgvTransportUnit;
        private System.Windows.Forms.Label lblContainer;
        private System.Windows.Forms.Label lblDriver;
        private System.Windows.Forms.TextBox txtTransportUnitId;
        private System.Windows.Forms.Label lblTransportUnitId;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDriverNIC;
        private System.Windows.Forms.TextBox txtDriverContact;
        private System.Windows.Forms.Label lblDriverContact;
        private System.Windows.Forms.TextBox txtDriverName;
        private System.Windows.Forms.Label lblDriverName;
        private System.Windows.Forms.TextBox txtDriverNIC;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblAssistantAddress;
        private System.Windows.Forms.TextBox txtAssistantAddress;
        private System.Windows.Forms.Label lblAssistantContact;
        private System.Windows.Forms.TextBox txtAssistantContact;
        private System.Windows.Forms.Label lblAssistantName;
        private System.Windows.Forms.TextBox txtAssistantName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cmbContainerCondition;
        private System.Windows.Forms.Label lblContainerNumber;
        private System.Windows.Forms.Label lblContainerCondition;
        private System.Windows.Forms.TextBox txtContainerNumber;
        private System.Windows.Forms.TextBox txtContainerSize;
        private System.Windows.Forms.Label lblContainerSize;
        private System.Windows.Forms.Label lblTransportUnitManagement;
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