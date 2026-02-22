namespace E_Shift
{
    partial class frmJobsByDateRangeReport
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
            this.picLogo = new System.Windows.Forms.PictureBox();
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
            this.lblJobsByDateRangeReport = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.rvwJobsByDateRangeReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Image = global::E_Shift.Properties.Resources.Delivery_Express_Logo__3_;
            this.picLogo.Location = new System.Drawing.Point(104, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(98, 68);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 144;
            this.picLogo.TabStop = false;
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
            this.menuStrip2.TabIndex = 143;
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
            // lblJobsByDateRangeReport
            // 
            this.lblJobsByDateRangeReport.AutoSize = true;
            this.lblJobsByDateRangeReport.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.8F);
            this.lblJobsByDateRangeReport.ForeColor = System.Drawing.Color.White;
            this.lblJobsByDateRangeReport.Location = new System.Drawing.Point(676, 11);
            this.lblJobsByDateRangeReport.Name = "lblJobsByDateRangeReport";
            this.lblJobsByDateRangeReport.Size = new System.Drawing.Size(600, 50);
            this.lblJobsByDateRangeReport.TabIndex = 146;
            this.lblJobsByDateRangeReport.Text = "Jobs By Date Range Report";
            this.lblJobsByDateRangeReport.Click += new System.EventHandler(this.lblJobsByDateRangeReport_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.panel6.Controls.Add(this.lblJobsByDateRangeReport);
            this.panel6.Location = new System.Drawing.Point(0, 84);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(2064, 70);
            this.panel6.TabIndex = 311;
            // 
            // rvwJobsByDateRangeReport
            // 
            this.rvwJobsByDateRangeReport.Location = new System.Drawing.Point(0, 250);
            this.rvwJobsByDateRangeReport.Name = "rvwJobsByDateRangeReport";
            this.rvwJobsByDateRangeReport.ServerReport.BearerToken = null;
            this.rvwJobsByDateRangeReport.Size = new System.Drawing.Size(2064, 753);
            this.rvwJobsByDateRangeReport.TabIndex = 314;
            this.rvwJobsByDateRangeReport.Load += new System.EventHandler(this.rvwJobsByDateRangeReport_Load);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Location = new System.Drawing.Point(301, 178);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(437, 35);
            this.dtpStartDate.TabIndex = 315;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Location = new System.Drawing.Point(1035, 178);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(437, 35);
            this.dtpEndDate.TabIndex = 316;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateReport.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateReport.ForeColor = System.Drawing.Color.White;
            this.btnGenerateReport.Location = new System.Drawing.Point(1576, 172);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(266, 47);
            this.btnGenerateReport.TabIndex = 317;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = false;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // frmJobsByDateRangeReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 994);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.rvwJobsByDateRangeReport);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmJobsByDateRangeReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JobsByDateRangeReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmJobsByDateRangeReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Label lblJobsByDateRangeReport;
        private System.Windows.Forms.Panel panel6;
        private Microsoft.Reporting.WinForms.ReportViewer rvwJobsByDateRangeReport;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnGenerateReport;
    }
}