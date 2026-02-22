namespace E_Shift
{
    partial class frmContact
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmContactUs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHome = new System.Windows.Forms.ToolStripMenuItem();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblGet = new System.Windows.Forms.Label();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.pnlContact = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlContact.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(61)))), ((int)(((byte)(113)))));
            this.menuStrip1.Font = new System.Drawing.Font("Gabriola", 25.8F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmContactUs,
            this.tsmLogin,
            this.tsmRegister,
            this.tsmAbout,
            this.tsmHome});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1920, 87);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // tsmContactUs
            // 
            this.tsmContactUs.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmContactUs.ForeColor = System.Drawing.Color.White;
            this.tsmContactUs.Name = "tsmContactUs";
            this.tsmContactUs.Size = new System.Drawing.Size(245, 83);
            this.tsmContactUs.Text = "CONTACT US";
            this.tsmContactUs.Click += new System.EventHandler(this.tsmContactUs_Click);
            // 
            // tsmLogin
            // 
            this.tsmLogin.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmLogin.ForeColor = System.Drawing.Color.White;
            this.tsmLogin.Name = "tsmLogin";
            this.tsmLogin.Size = new System.Drawing.Size(147, 83);
            this.tsmLogin.Text = "LOGIN";
            this.tsmLogin.Click += new System.EventHandler(this.tsmLogin_Click);
            // 
            // tsmRegister
            // 
            this.tsmRegister.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmRegister.ForeColor = System.Drawing.Color.White;
            this.tsmRegister.Name = "tsmRegister";
            this.tsmRegister.Size = new System.Drawing.Size(195, 83);
            this.tsmRegister.Text = "REGISTER";
            this.tsmRegister.Click += new System.EventHandler(this.tsmRegister_Click);
            // 
            // tsmAbout
            // 
            this.tsmAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmAbout.ForeColor = System.Drawing.Color.White;
            this.tsmAbout.Name = "tsmAbout";
            this.tsmAbout.Size = new System.Drawing.Size(158, 83);
            this.tsmAbout.Text = "ABOUT";
            this.tsmAbout.Click += new System.EventHandler(this.tsmAbout_Click);
            // 
            // tsmHome
            // 
            this.tsmHome.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmHome.ForeColor = System.Drawing.Color.White;
            this.tsmHome.Name = "tsmHome";
            this.tsmHome.Size = new System.Drawing.Size(145, 83);
            this.tsmHome.Text = "HOME";
            this.tsmHome.Click += new System.EventHandler(this.tsmHome_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = global::E_Shift.Properties.Resources.Delivery_Express_Logo__3_;
            this.picLogo.Location = new System.Drawing.Point(104, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(98, 87);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 26;
            this.picLogo.TabStop = false;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(61)))), ((int)(((byte)(113)))));
            this.lblPhoneNumber.Location = new System.Drawing.Point(75, 134);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(175, 55);
            this.lblPhoneNumber.TabIndex = 29;
            this.lblPhoneNumber.Text = "Phone Number";
            this.lblPhoneNumber.Click += new System.EventHandler(this.lblPhoneNumber_Click);
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Arial Rounded MT Bold", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(61)))), ((int)(((byte)(113)))));
            this.lblContact.Location = new System.Drawing.Point(604, 133);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(866, 116);
            this.lblContact.TabIndex = 64;
            this.lblContact.Text = "Contact us today";
            this.lblContact.Click += new System.EventHandler(this.lblContact_Click);
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(609, 182);
            this.txtSubject.Multiline = true;
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(404, 50);
            this.txtSubject.TabIndex = 32;
            this.txtSubject.TextChanged += new System.EventHandler(this.txtSubject_TextChanged);
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(61)))), ((int)(((byte)(113)))));
            this.lblSubject.Location = new System.Drawing.Point(599, 134);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(96, 55);
            this.lblSubject.TabIndex = 30;
            this.lblSubject.Text = "Subject";
            this.lblSubject.Click += new System.EventHandler(this.lblSubject_Click);
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailAddress.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(61)))), ((int)(((byte)(113)))));
            this.lblEmailAddress.Location = new System.Drawing.Point(601, 26);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(174, 55);
            this.lblEmailAddress.TabIndex = 28;
            this.lblEmailAddress.Text = "Email Address";
            this.lblEmailAddress.Click += new System.EventHandler(this.lblEmailAddress_Click);
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(611, 75);
            this.txtEmailAddress.Multiline = true;
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(404, 50);
            this.txtEmailAddress.TabIndex = 27;
            this.txtEmailAddress.TextChanged += new System.EventHandler(this.txtEmailAddress_TextChanged);
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(87, 75);
            this.txtFullName.Multiline = true;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(404, 50);
            this.txtFullName.TabIndex = 26;
            this.txtFullName.TextChanged += new System.EventHandler(this.txtFullName_TextChanged);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(61)))), ((int)(((byte)(113)))));
            this.lblFullName.Location = new System.Drawing.Point(77, 26);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(126, 55);
            this.lblFullName.TabIndex = 25;
            this.lblFullName.Text = "Full name";
            this.lblFullName.Click += new System.EventHandler(this.lblFullName_Click);
            // 
            // lblGet
            // 
            this.lblGet.AutoSize = true;
            this.lblGet.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(123)))), ((int)(((byte)(209)))));
            this.lblGet.Location = new System.Drawing.Point(995, 110);
            this.lblGet.Name = "lblGet";
            this.lblGet.Size = new System.Drawing.Size(148, 27);
            this.lblGet.TabIndex = 65;
            this.lblGet.Text = "Get in touch";
            this.lblGet.Click += new System.EventHandler(this.lblGet_Click);
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(81)))));
            this.btnSendMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSendMessage.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendMessage.ForeColor = System.Drawing.Color.White;
            this.btnSendMessage.Location = new System.Drawing.Point(87, 511);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(280, 77);
            this.btnSendMessage.TabIndex = 48;
            this.btnSendMessage.Text = "Send Message";
            this.btnSendMessage.UseVisualStyleBackColor = false;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(87, 313);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(930, 167);
            this.txtMessage.TabIndex = 34;
            this.txtMessage.TextChanged += new System.EventHandler(this.txtMessage_TextChanged);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(61)))), ((int)(((byte)(113)))));
            this.lblMessage.Location = new System.Drawing.Point(77, 255);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(108, 55);
            this.lblMessage.TabIndex = 33;
            this.lblMessage.Text = "Message";
            this.lblMessage.Click += new System.EventHandler(this.lblMessage_Click);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(85, 182);
            this.txtPhoneNumber.Multiline = true;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(404, 50);
            this.txtPhoneNumber.TabIndex = 31;
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.txtPhoneNumber_TextChanged);
            // 
            // pnlContact
            // 
            this.pnlContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.pnlContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlContact.Controls.Add(this.btnSendMessage);
            this.pnlContact.Controls.Add(this.txtMessage);
            this.pnlContact.Controls.Add(this.lblMessage);
            this.pnlContact.Controls.Add(this.txtSubject);
            this.pnlContact.Controls.Add(this.txtPhoneNumber);
            this.pnlContact.Controls.Add(this.lblSubject);
            this.pnlContact.Controls.Add(this.lblPhoneNumber);
            this.pnlContact.Controls.Add(this.txtEmailAddress);
            this.pnlContact.Controls.Add(this.txtFullName);
            this.pnlContact.Controls.Add(this.lblFullName);
            this.pnlContact.Controls.Add(this.lblEmailAddress);
            this.pnlContact.Location = new System.Drawing.Point(490, 295);
            this.pnlContact.Name = "pnlContact";
            this.pnlContact.Size = new System.Drawing.Size(1123, 624);
            this.pnlContact.TabIndex = 66;
            this.pnlContact.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContact_Paint);
            // 
            // frmContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 994);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblGet);
            this.Controls.Add(this.pnlContact);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmContact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmContact_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlContact.ResumeLayout(false);
            this.pnlContact.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmContactUs;
        private System.Windows.Forms.ToolStripMenuItem tsmLogin;
        private System.Windows.Forms.ToolStripMenuItem tsmRegister;
        private System.Windows.Forms.ToolStripMenuItem tsmAbout;
        private System.Windows.Forms.ToolStripMenuItem tsmHome;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblGet;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Panel pnlContact;
    }
}