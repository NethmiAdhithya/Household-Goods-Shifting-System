namespace E_Shift
{
    partial class frmAdminDashboard
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblDashboard = new System.Windows.Forms.Label();
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
            this.chtCustomerLoadDistribution = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.jobsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eShiftDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.e_ShiftDBDataSet = new E_Shift.E_ShiftDBDataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chtJobsByDateRange = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chtLoadsbyTransportUnit = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.loadsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chart5 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.transportUnitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.customersTableAdapter = new E_Shift.E_ShiftDBDataSetTableAdapters.CustomersTableAdapter();
            this.jobsTableAdapter = new E_Shift.E_ShiftDBDataSetTableAdapters.JobsTableAdapter();
            this.loadsTableAdapter = new E_Shift.E_ShiftDBDataSetTableAdapters.LoadsTableAdapter();
            this.adminsTableAdapter = new E_Shift.E_ShiftDBDataSetTableAdapters.AdminsTableAdapter();
            this.transportUnitsTableAdapter = new E_Shift.E_ShiftDBDataSetTableAdapters.TransportUnitsTableAdapter();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.customertheirJobsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customer_theirJobsTableAdapter = new E_Shift.E_ShiftDBDataSetTableAdapters.Customer_theirJobsTableAdapter();
            this.jobsByDateRangeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobsByDateRangeTableAdapter = new E_Shift.E_ShiftDBDataSetTableAdapters.JobsByDateRangeTableAdapter();
            this.lblCustomerLoadDistribution = new System.Windows.Forms.Label();
            this.lblJobsByDateRange = new System.Windows.Forms.Label();
            this.loadsByTransportUnitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loadsByTransportUnitTableAdapter = new E_Shift.E_ShiftDBDataSetTableAdapters.LoadsByTransportUnitTableAdapter();
            this.lblLoadsbyTransportUnit = new System.Windows.Forms.Label();
            this.chtTotalWeightbyLoadStatus = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.loadsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblTotalWeightbyLoadStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.chtCustomers = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.jobsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtCustomerLoadDistribution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eShiftDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_ShiftDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtJobsByDateRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtLoadsbyTransportUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportUnitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customertheirJobsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobsByDateRangeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadsByTransportUnitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtTotalWeightbyLoadStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadsBindingSource1)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.8F);
            this.lblDashboard.ForeColor = System.Drawing.Color.White;
            this.lblDashboard.Location = new System.Drawing.Point(789, 11);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(254, 50);
            this.lblDashboard.TabIndex = 129;
            this.lblDashboard.Text = "Dashboard";
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
            this.menuStrip2.TabIndex = 127;
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
            // chtCustomerLoadDistribution
            // 
            chartArea1.Name = "ChartArea1";
            this.chtCustomerLoadDistribution.ChartAreas.Add(chartArea1);
            this.chtCustomerLoadDistribution.DataSource = this.customertheirJobsBindingSource;
            legend1.Name = "Legend1";
            this.chtCustomerLoadDistribution.Legends.Add(legend1);
            this.chtCustomerLoadDistribution.Location = new System.Drawing.Point(44, 50);
            this.chtCustomerLoadDistribution.Name = "chtCustomerLoadDistribution";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "CustomerLoadDistribution";
            series1.XValueMember = "CustomerID";
            series1.YValueMembers = "JobID";
            this.chtCustomerLoadDistribution.Series.Add(series1);
            this.chtCustomerLoadDistribution.Size = new System.Drawing.Size(375, 300);
            this.chtCustomerLoadDistribution.TabIndex = 130;
            this.chtCustomerLoadDistribution.Text = "Customer Load Distribution";
            // 
            // jobsBindingSource
            // 
            this.jobsBindingSource.DataMember = "Jobs";
            this.jobsBindingSource.DataSource = this.eShiftDBDataSetBindingSource;
            // 
            // eShiftDBDataSetBindingSource
            // 
            this.eShiftDBDataSetBindingSource.DataSource = this.e_ShiftDBDataSet;
            this.eShiftDBDataSetBindingSource.Position = 0;
            // 
            // e_ShiftDBDataSet
            // 
            this.e_ShiftDBDataSet.DataSetName = "E_ShiftDBDataSet";
            this.e_ShiftDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.eShiftDBDataSetBindingSource;
            // 
            // chtJobsByDateRange
            // 
            chartArea2.Name = "ChartArea1";
            this.chtJobsByDateRange.ChartAreas.Add(chartArea2);
            this.chtJobsByDateRange.DataSource = this.jobsByDateRangeBindingSource;
            legend2.Name = "Legend1";
            this.chtJobsByDateRange.Legends.Add(legend2);
            this.chtJobsByDateRange.Location = new System.Drawing.Point(44, 50);
            this.chtJobsByDateRange.Name = "chtJobsByDateRange";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Jobs By Date Range";
            series2.XValueMember = "JobID";
            series2.YValueMembers = "JobDate";
            this.chtJobsByDateRange.Series.Add(series2);
            this.chtJobsByDateRange.Size = new System.Drawing.Size(375, 300);
            this.chtJobsByDateRange.TabIndex = 131;
            this.chtJobsByDateRange.Text = "Jobs By Date Range";
            // 
            // chtLoadsbyTransportUnit
            // 
            chartArea3.Name = "ChartArea1";
            this.chtLoadsbyTransportUnit.ChartAreas.Add(chartArea3);
            this.chtLoadsbyTransportUnit.DataSource = this.loadsByTransportUnitBindingSource;
            legend3.Name = "Legend1";
            this.chtLoadsbyTransportUnit.Legends.Add(legend3);
            this.chtLoadsbyTransportUnit.Location = new System.Drawing.Point(44, 50);
            this.chtLoadsbyTransportUnit.Name = "chtLoadsbyTransportUnit";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pyramid;
            series3.Legend = "Legend1";
            series3.Name = "Loads by Transport Unit";
            series3.XValueMember = "TransportUnitID";
            series3.YValueMembers = "LoadID";
            this.chtLoadsbyTransportUnit.Series.Add(series3);
            this.chtLoadsbyTransportUnit.Size = new System.Drawing.Size(375, 300);
            this.chtLoadsbyTransportUnit.TabIndex = 132;
            this.chtLoadsbyTransportUnit.Text = "Loads by Transport Unit";
            // 
            // loadsBindingSource
            // 
            this.loadsBindingSource.DataMember = "Loads";
            this.loadsBindingSource.DataSource = this.eShiftDBDataSetBindingSource;
            // 
            // adminsBindingSource
            // 
            this.adminsBindingSource.DataMember = "Admins";
            this.adminsBindingSource.DataSource = this.eShiftDBDataSetBindingSource;
            // 
            // chart5
            // 
            chartArea4.Name = "ChartArea1";
            this.chart5.ChartAreas.Add(chartArea4);
            this.chart5.DataSource = this.transportUnitsBindingSource;
            legend4.Name = "Legend1";
            this.chart5.Legends.Add(legend4);
            this.chart5.Location = new System.Drawing.Point(79, 44);
            this.chart5.Name = "chart5";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "TransportUnit";
            series4.XValueMember = "TransportUnitID";
            series4.YValueMembers = "IsAvailable";
            this.chart5.Series.Add(series4);
            this.chart5.Size = new System.Drawing.Size(810, 302);
            this.chart5.TabIndex = 134;
            this.chart5.Text = "chart5";
            // 
            // transportUnitsBindingSource
            // 
            this.transportUnitsBindingSource.DataMember = "TransportUnits";
            this.transportUnitsBindingSource.DataSource = this.eShiftDBDataSetBindingSource;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::E_Shift.Properties.Resources.Delivery_Express_Logo__3_;
            this.picLogo.Location = new System.Drawing.Point(101, -1);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(98, 68);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 128;
            this.picLogo.TabStop = false;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // jobsTableAdapter
            // 
            this.jobsTableAdapter.ClearBeforeFill = true;
            // 
            // loadsTableAdapter
            // 
            this.loadsTableAdapter.ClearBeforeFill = true;
            // 
            // adminsTableAdapter
            // 
            this.adminsTableAdapter.ClearBeforeFill = true;
            // 
            // transportUnitsTableAdapter
            // 
            this.transportUnitsTableAdapter.ClearBeforeFill = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.panel6.Controls.Add(this.lblDashboard);
            this.panel6.Location = new System.Drawing.Point(0, 84);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(2064, 70);
            this.panel6.TabIndex = 309;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblCustomerLoadDistribution);
            this.panel1.Controls.Add(this.chtCustomerLoadDistribution);
            this.panel1.Location = new System.Drawing.Point(46, 187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 357);
            this.panel1.TabIndex = 310;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblJobsByDateRange);
            this.panel2.Controls.Add(this.chtJobsByDateRange);
            this.panel2.Location = new System.Drawing.Point(521, 187);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(426, 357);
            this.panel2.TabIndex = 311;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblLoadsbyTransportUnit);
            this.panel3.Controls.Add(this.chtLoadsbyTransportUnit);
            this.panel3.Location = new System.Drawing.Point(989, 187);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(426, 357);
            this.panel3.TabIndex = 312;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.lblTotalWeightbyLoadStatus);
            this.panel4.Controls.Add(this.chtTotalWeightbyLoadStatus);
            this.panel4.Location = new System.Drawing.Point(1454, 187);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(426, 357);
            this.panel4.TabIndex = 313;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.chart5);
            this.panel5.Location = new System.Drawing.Point(46, 613);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(896, 353);
            this.panel5.TabIndex = 314;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // customertheirJobsBindingSource
            // 
            this.customertheirJobsBindingSource.DataMember = "Customer&theirJobs";
            this.customertheirJobsBindingSource.DataSource = this.eShiftDBDataSetBindingSource;
            // 
            // customer_theirJobsTableAdapter
            // 
            this.customer_theirJobsTableAdapter.ClearBeforeFill = true;
            // 
            // jobsByDateRangeBindingSource
            // 
            this.jobsByDateRangeBindingSource.DataMember = "JobsByDateRange";
            this.jobsByDateRangeBindingSource.DataSource = this.eShiftDBDataSetBindingSource;
            // 
            // jobsByDateRangeTableAdapter
            // 
            this.jobsByDateRangeTableAdapter.ClearBeforeFill = true;
            // 
            // lblCustomerLoadDistribution
            // 
            this.lblCustomerLoadDistribution.AutoSize = true;
            this.lblCustomerLoadDistribution.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerLoadDistribution.ForeColor = System.Drawing.Color.White;
            this.lblCustomerLoadDistribution.Location = new System.Drawing.Point(3, -2);
            this.lblCustomerLoadDistribution.Name = "lblCustomerLoadDistribution";
            this.lblCustomerLoadDistribution.Size = new System.Drawing.Size(278, 29);
            this.lblCustomerLoadDistribution.TabIndex = 131;
            this.lblCustomerLoadDistribution.Text = "Customer Load Distribution";
            // 
            // lblJobsByDateRange
            // 
            this.lblJobsByDateRange.AutoSize = true;
            this.lblJobsByDateRange.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobsByDateRange.ForeColor = System.Drawing.Color.White;
            this.lblJobsByDateRange.Location = new System.Drawing.Point(3, 0);
            this.lblJobsByDateRange.Name = "lblJobsByDateRange";
            this.lblJobsByDateRange.Size = new System.Drawing.Size(211, 29);
            this.lblJobsByDateRange.TabIndex = 132;
            this.lblJobsByDateRange.Text = "Jobs By Date Range";
            // 
            // loadsByTransportUnitBindingSource
            // 
            this.loadsByTransportUnitBindingSource.DataMember = "LoadsByTransportUnit";
            this.loadsByTransportUnitBindingSource.DataSource = this.eShiftDBDataSetBindingSource;
            // 
            // loadsByTransportUnitTableAdapter
            // 
            this.loadsByTransportUnitTableAdapter.ClearBeforeFill = true;
            // 
            // lblLoadsbyTransportUnit
            // 
            this.lblLoadsbyTransportUnit.AutoSize = true;
            this.lblLoadsbyTransportUnit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadsbyTransportUnit.ForeColor = System.Drawing.Color.White;
            this.lblLoadsbyTransportUnit.Location = new System.Drawing.Point(3, 0);
            this.lblLoadsbyTransportUnit.Name = "lblLoadsbyTransportUnit";
            this.lblLoadsbyTransportUnit.Size = new System.Drawing.Size(254, 29);
            this.lblLoadsbyTransportUnit.TabIndex = 133;
            this.lblLoadsbyTransportUnit.Text = "Loads by Transport Unit";
            // 
            // chtTotalWeightbyLoadStatus
            // 
            chartArea5.Name = "ChartArea1";
            this.chtTotalWeightbyLoadStatus.ChartAreas.Add(chartArea5);
            this.chtTotalWeightbyLoadStatus.DataSource = this.loadsBindingSource1;
            legend5.Name = "Legend1";
            this.chtTotalWeightbyLoadStatus.Legends.Add(legend5);
            this.chtTotalWeightbyLoadStatus.Location = new System.Drawing.Point(44, 50);
            this.chtTotalWeightbyLoadStatus.Name = "chtTotalWeightbyLoadStatus";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
            series5.Legend = "Legend1";
            series5.Name = "Total Weight by Load Status";
            series5.XValueMember = "LoadID";
            series5.YValueMembers = "Weight";
            series5.YValuesPerPoint = 2;
            this.chtTotalWeightbyLoadStatus.Series.Add(series5);
            this.chtTotalWeightbyLoadStatus.Size = new System.Drawing.Size(375, 300);
            this.chtTotalWeightbyLoadStatus.TabIndex = 0;
            this.chtTotalWeightbyLoadStatus.Text = "Total Weight by Load Status";
            // 
            // loadsBindingSource1
            // 
            this.loadsBindingSource1.DataMember = "Loads";
            this.loadsBindingSource1.DataSource = this.eShiftDBDataSetBindingSource;
            // 
            // lblTotalWeightbyLoadStatus
            // 
            this.lblTotalWeightbyLoadStatus.AutoSize = true;
            this.lblTotalWeightbyLoadStatus.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalWeightbyLoadStatus.ForeColor = System.Drawing.Color.White;
            this.lblTotalWeightbyLoadStatus.Location = new System.Drawing.Point(3, 0);
            this.lblTotalWeightbyLoadStatus.Name = "lblTotalWeightbyLoadStatus";
            this.lblTotalWeightbyLoadStatus.Size = new System.Drawing.Size(300, 29);
            this.lblTotalWeightbyLoadStatus.TabIndex = 134;
            this.lblTotalWeightbyLoadStatus.Text = "Total Weight by Load Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 29);
            this.label2.TabIndex = 135;
            this.label2.Text = "Loads by Transport Unit";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.lblCustomers);
            this.panel7.Controls.Add(this.chtCustomers);
            this.panel7.Location = new System.Drawing.Point(989, 613);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(891, 353);
            this.panel7.TabIndex = 315;
            // 
            // lblCustomers
            // 
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomers.ForeColor = System.Drawing.Color.White;
            this.lblCustomers.Location = new System.Drawing.Point(3, 0);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(112, 29);
            this.lblCustomers.TabIndex = 135;
            this.lblCustomers.Text = "Customers";
            // 
            // chtCustomers
            // 
            chartArea6.Name = "ChartArea1";
            this.chtCustomers.ChartAreas.Add(chartArea6);
            this.chtCustomers.DataSource = this.customersBindingSource1;
            legend6.Name = "Legend1";
            this.chtCustomers.Legends.Add(legend6);
            this.chtCustomers.Location = new System.Drawing.Point(74, 44);
            this.chtCustomers.Name = "chtCustomers";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Customers";
            series6.XValueMember = "Name";
            series6.YValueMembers = "CustomerID";
            this.chtCustomers.Series.Add(series6);
            this.chtCustomers.Size = new System.Drawing.Size(810, 302);
            this.chtCustomers.TabIndex = 134;
            this.chtCustomers.Text = "Customers";
            // 
            // jobsBindingSource1
            // 
            this.jobsBindingSource1.DataMember = "Jobs";
            this.jobsBindingSource1.DataSource = this.eShiftDBDataSetBindingSource;
            // 
            // customersBindingSource1
            // 
            this.customersBindingSource1.DataMember = "Customers";
            this.customersBindingSource1.DataSource = this.eShiftDBDataSetBindingSource;
            // 
            // frmAdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 994);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmAdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAdminDashboard_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtCustomerLoadDistribution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eShiftDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_ShiftDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtJobsByDateRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtLoadsbyTransportUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportUnitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customertheirJobsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobsByDateRangeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadsByTransportUnitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtTotalWeightbyLoadStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadsBindingSource1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDashboard;
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chtCustomerLoadDistribution;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtJobsByDateRange;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtLoadsbyTransportUnit;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart5;
        private System.Windows.Forms.BindingSource eShiftDBDataSetBindingSource;
        private E_ShiftDBDataSet e_ShiftDBDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private E_ShiftDBDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.BindingSource jobsBindingSource;
        private E_ShiftDBDataSetTableAdapters.JobsTableAdapter jobsTableAdapter;
        private System.Windows.Forms.BindingSource loadsBindingSource;
        private E_ShiftDBDataSetTableAdapters.LoadsTableAdapter loadsTableAdapter;
        private System.Windows.Forms.BindingSource adminsBindingSource;
        private E_ShiftDBDataSetTableAdapters.AdminsTableAdapter adminsTableAdapter;
        private System.Windows.Forms.BindingSource transportUnitsBindingSource;
        private E_ShiftDBDataSetTableAdapters.TransportUnitsTableAdapter transportUnitsTableAdapter;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.BindingSource customertheirJobsBindingSource;
        private E_ShiftDBDataSetTableAdapters.Customer_theirJobsTableAdapter customer_theirJobsTableAdapter;
        private System.Windows.Forms.BindingSource jobsByDateRangeBindingSource;
        private E_ShiftDBDataSetTableAdapters.JobsByDateRangeTableAdapter jobsByDateRangeTableAdapter;
        private System.Windows.Forms.Label lblCustomerLoadDistribution;
        private System.Windows.Forms.Label lblJobsByDateRange;
        private System.Windows.Forms.BindingSource loadsByTransportUnitBindingSource;
        private E_ShiftDBDataSetTableAdapters.LoadsByTransportUnitTableAdapter loadsByTransportUnitTableAdapter;
        private System.Windows.Forms.Label lblLoadsbyTransportUnit;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtTotalWeightbyLoadStatus;
        private System.Windows.Forms.BindingSource loadsBindingSource1;
        private System.Windows.Forms.Label lblTotalWeightbyLoadStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtCustomers;
        private System.Windows.Forms.BindingSource jobsBindingSource1;
        private System.Windows.Forms.BindingSource customersBindingSource1;
    }
}