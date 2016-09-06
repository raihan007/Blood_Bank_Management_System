namespace BloodBankManagmentSystem
{
    partial class AdminDashBoard
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnUserProfile = new System.Windows.Forms.Button();
            this.settingsLink = new System.Windows.Forms.LinkLabel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblTotalEmpNo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnOwnProfile = new System.Windows.Forms.Button();
            this.btnRefreash = new System.Windows.Forms.Button();
            this.btnLogInfo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBloodReqInfo = new System.Windows.Forms.Button();
            this.btnBllodInfo = new System.Windows.Forms.Button();
            this.btnBranchInfo = new System.Windows.Forms.Button();
            this.btnDonorInfo = new System.Windows.Forms.Button();
            this.btnEmpInfo = new System.Windows.Forms.Button();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.changeSettingsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.changeSettingsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnUserProfile);
            this.panel3.Controls.Add(this.settingsLink);
            this.panel3.Controls.Add(this.lblTime);
            this.panel3.Controls.Add(this.lblDate);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.btnOwnProfile);
            this.panel3.Controls.Add(this.btnRefreash);
            this.panel3.Controls.Add(this.btnLogInfo);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.btnBloodReqInfo);
            this.panel3.Controls.Add(this.btnBllodInfo);
            this.panel3.Controls.Add(this.btnBranchInfo);
            this.panel3.Controls.Add(this.btnDonorInfo);
            this.panel3.Controls.Add(this.btnEmpInfo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1022, 561);
            this.panel3.TabIndex = 15;
            // 
            // btnUserProfile
            // 
            this.btnUserProfile.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserProfile.Location = new System.Drawing.Point(12, 491);
            this.btnUserProfile.Name = "btnUserProfile";
            this.btnUserProfile.Size = new System.Drawing.Size(191, 58);
            this.btnUserProfile.TabIndex = 22;
            this.btnUserProfile.Text = "Current User Info";
            this.btnUserProfile.UseVisualStyleBackColor = true;
            this.btnUserProfile.Click += new System.EventHandler(this.btnUserProfile_Click);
            // 
            // settingsLink
            // 
            this.settingsLink.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsLink.Image = global::BloodBankManagmentSystem.Properties.Resources.settingIcon;
            this.settingsLink.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.settingsLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.settingsLink.Location = new System.Drawing.Point(828, 37);
            this.settingsLink.Name = "settingsLink";
            this.settingsLink.Size = new System.Drawing.Size(120, 26);
            this.settingsLink.TabIndex = 21;
            this.settingsLink.TabStop = true;
            this.settingsLink.Text = "User Settings";
            this.settingsLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.settingsLink_LinkClicked);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(626, 507);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(112, 25);
            this.lblTime.TabIndex = 20;
            this.lblTime.Text = "59:59:00 PM";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(449, 507);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(171, 25);
            this.lblDate.TabIndex = 18;
            this.lblDate.Text = "Today : 31/12-2016";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label16);
            this.panel8.Controls.Add(this.label9);
            this.panel8.Controls.Add(this.pictureBox7);
            this.panel8.Location = new System.Drawing.Point(832, 130);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(178, 153);
            this.panel8.TabIndex = 17;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label16.Location = new System.Drawing.Point(140, 100);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 21);
            this.label16.TabIndex = 23;
            this.label16.Text = "001";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 21);
            this.label9.TabIndex = 12;
            this.label9.Text = "Total Active Donors";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = global::BloodBankManagmentSystem.Properties.Resources.user;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(36, 0);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(104, 95);
            this.pictureBox7.TabIndex = 0;
            this.pictureBox7.TabStop = false;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label13);
            this.panel9.Controls.Add(this.label10);
            this.panel9.Controls.Add(this.pictureBox8);
            this.panel9.Location = new System.Drawing.Point(623, 306);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(178, 153);
            this.panel9.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label13.Location = new System.Drawing.Point(132, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 21);
            this.label13.TabIndex = 15;
            this.label13.Text = "001";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 21);
            this.label10.TabIndex = 12;
            this.label10.Text = "Total Blood Bags";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = global::BloodBankManagmentSystem.Properties.Resources.bag;
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Location = new System.Drawing.Point(37, 0);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(104, 95);
            this.pictureBox8.TabIndex = 0;
            this.pictureBox8.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.pictureBox5);
            this.panel6.Location = new System.Drawing.Point(416, 306);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(178, 153);
            this.panel6.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label15.Location = new System.Drawing.Point(143, 98);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 21);
            this.label15.TabIndex = 22;
            this.label15.Text = "001";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-1, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "Total Blood Request";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::BloodBankManagmentSystem.Properties.Resources.heart_beat;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(38, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(104, 95);
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Location = new System.Drawing.Point(623, 130);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(178, 153);
            this.panel4.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label14.Location = new System.Drawing.Point(118, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 21);
            this.label14.TabIndex = 21;
            this.label14.Text = "001";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Total Donors";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::BloodBankManagmentSystem.Properties.Resources.group;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(39, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(104, 95);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblTotalEmpNo);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Location = new System.Drawing.Point(419, 130);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(178, 153);
            this.panel5.TabIndex = 11;
            // 
            // lblTotalEmpNo
            // 
            this.lblTotalEmpNo.AutoSize = true;
            this.lblTotalEmpNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEmpNo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTotalEmpNo.Location = new System.Drawing.Point(129, 98);
            this.lblTotalEmpNo.Name = "lblTotalEmpNo";
            this.lblTotalEmpNo.Size = new System.Drawing.Size(37, 21);
            this.lblTotalEmpNo.TabIndex = 13;
            this.lblTotalEmpNo.Text = "001";
            this.lblTotalEmpNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Total Employyes";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::BloodBankManagmentSystem.Properties.Resources.user;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(39, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(104, 95);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // btnOwnProfile
            // 
            this.btnOwnProfile.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOwnProfile.Location = new System.Drawing.Point(213, 491);
            this.btnOwnProfile.Name = "btnOwnProfile";
            this.btnOwnProfile.Size = new System.Drawing.Size(191, 58);
            this.btnOwnProfile.TabIndex = 10;
            this.btnOwnProfile.Text = "Current Branch Info";
            this.btnOwnProfile.UseVisualStyleBackColor = true;
            this.btnOwnProfile.Click += new System.EventHandler(this.btnOwnProfile_Click);
            // 
            // btnRefreash
            // 
            this.btnRefreash.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreash.Location = new System.Drawing.Point(213, 218);
            this.btnRefreash.Name = "btnRefreash";
            this.btnRefreash.Size = new System.Drawing.Size(191, 58);
            this.btnRefreash.TabIndex = 9;
            this.btnRefreash.Text = "Refreash";
            this.btnRefreash.UseVisualStyleBackColor = true;
            this.btnRefreash.Click += new System.EventHandler(this.btnRefreash_Click);
            // 
            // btnLogInfo
            // 
            this.btnLogInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogInfo.Location = new System.Drawing.Point(213, 309);
            this.btnLogInfo.Name = "btnLogInfo";
            this.btnLogInfo.Size = new System.Drawing.Size(191, 58);
            this.btnLogInfo.TabIndex = 8;
            this.btnLogInfo.Text = "Log Activities Info";
            this.btnLogInfo.UseVisualStyleBackColor = true;
            this.btnLogInfo.Click += new System.EventHandler(this.btnLogInfo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(12, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(279, 32);
            this.label6.TabIndex = 1;
            this.label6.Text = "Welcome to Admin Panel";
            // 
            // btnBloodReqInfo
            // 
            this.btnBloodReqInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBloodReqInfo.Location = new System.Drawing.Point(12, 400);
            this.btnBloodReqInfo.Name = "btnBloodReqInfo";
            this.btnBloodReqInfo.Size = new System.Drawing.Size(191, 58);
            this.btnBloodReqInfo.TabIndex = 6;
            this.btnBloodReqInfo.Text = "Blood Requests Info";
            this.btnBloodReqInfo.UseVisualStyleBackColor = true;
            this.btnBloodReqInfo.Click += new System.EventHandler(this.btnBloodReqInfo_Click);
            // 
            // btnBllodInfo
            // 
            this.btnBllodInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBllodInfo.Location = new System.Drawing.Point(213, 400);
            this.btnBllodInfo.Name = "btnBllodInfo";
            this.btnBllodInfo.Size = new System.Drawing.Size(191, 58);
            this.btnBllodInfo.TabIndex = 5;
            this.btnBllodInfo.Text = "Blood Donates Info";
            this.btnBllodInfo.UseVisualStyleBackColor = true;
            this.btnBllodInfo.Click += new System.EventHandler(this.btnBllodInfo_Click);
            // 
            // btnBranchInfo
            // 
            this.btnBranchInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBranchInfo.Location = new System.Drawing.Point(12, 130);
            this.btnBranchInfo.Name = "btnBranchInfo";
            this.btnBranchInfo.Size = new System.Drawing.Size(191, 58);
            this.btnBranchInfo.TabIndex = 4;
            this.btnBranchInfo.Text = "Branches Info";
            this.btnBranchInfo.UseVisualStyleBackColor = true;
            this.btnBranchInfo.Click += new System.EventHandler(this.btnBranchInfo_Click);
            // 
            // btnDonorInfo
            // 
            this.btnDonorInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonorInfo.Location = new System.Drawing.Point(12, 218);
            this.btnDonorInfo.Name = "btnDonorInfo";
            this.btnDonorInfo.Size = new System.Drawing.Size(191, 58);
            this.btnDonorInfo.TabIndex = 3;
            this.btnDonorInfo.Text = "Donors Info";
            this.btnDonorInfo.UseVisualStyleBackColor = true;
            this.btnDonorInfo.Click += new System.EventHandler(this.btnDonorInfo_Click);
            // 
            // btnEmpInfo
            // 
            this.btnEmpInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpInfo.Location = new System.Drawing.Point(12, 309);
            this.btnEmpInfo.Name = "btnEmpInfo";
            this.btnEmpInfo.Size = new System.Drawing.Size(191, 58);
            this.btnEmpInfo.TabIndex = 2;
            this.btnEmpInfo.Text = "Employees Info";
            this.btnEmpInfo.UseVisualStyleBackColor = true;
            this.btnEmpInfo.Click += new System.EventHandler(this.btnEmpInfo_Click);
            // 
            // clock
            // 
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // changeSettingsMenu
            // 
            this.changeSettingsMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeSettingsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem,
            this.logoutMenuItem});
            this.changeSettingsMenu.Name = "changeSettingsMenu";
            this.changeSettingsMenu.Size = new System.Drawing.Size(184, 48);
            this.changeSettingsMenu.Text = "Change Password";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Access Info";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // logoutMenuItem
            // 
            this.logoutMenuItem.ForeColor = System.Drawing.Color.Red;
            this.logoutMenuItem.Image = global::BloodBankManagmentSystem.Properties.Resources.logout_24;
            this.logoutMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutMenuItem.Name = "logoutMenuItem";
            this.logoutMenuItem.Size = new System.Drawing.Size(183, 22);
            this.logoutMenuItem.Text = "Logout";
            this.logoutMenuItem.Click += new System.EventHandler(this.logoutMenuItem_Click);
            // 
            // BranchDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 561);
            this.Controls.Add(this.panel3);
            this.Name = "BranchDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BranchDashBoard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminDashBoard_FormClosed);
            this.Load += new System.EventHandler(this.AdminDashBoard_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.changeSettingsMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblTotalEmpNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnRefreash;
        private System.Windows.Forms.Button btnLogInfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBloodReqInfo;
        private System.Windows.Forms.Button btnBllodInfo;
        private System.Windows.Forms.Button btnBranchInfo;
        private System.Windows.Forms.Button btnDonorInfo;
        private System.Windows.Forms.Button btnEmpInfo;
        private System.Windows.Forms.Timer clock;
        private System.Windows.Forms.LinkLabel settingsLink;
        private System.Windows.Forms.ContextMenuStrip changeSettingsMenu;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutMenuItem;
        private System.Windows.Forms.Button btnOwnProfile;
        private System.Windows.Forms.Button btnUserProfile;
    }
}