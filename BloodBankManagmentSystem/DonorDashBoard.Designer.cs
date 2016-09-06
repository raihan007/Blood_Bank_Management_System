namespace BloodBankManagmentSystem
{
    partial class DonorDashBoard
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
            this.btnOwnProfile = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDonateHistory = new System.Windows.Forms.Button();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.changeSettingsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3.SuspendLayout();
            this.changeSettingsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnUserProfile);
            this.panel3.Controls.Add(this.settingsLink);
            this.panel3.Controls.Add(this.lblTime);
            this.panel3.Controls.Add(this.lblDate);
            this.panel3.Controls.Add(this.btnOwnProfile);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.btnDonateHistory);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(456, 381);
            this.panel3.TabIndex = 15;
            // 
            // btnUserProfile
            // 
            this.btnUserProfile.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserProfile.Location = new System.Drawing.Point(120, 216);
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
            this.settingsLink.Location = new System.Drawing.Point(314, 37);
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
            this.lblTime.Location = new System.Drawing.Point(250, 81);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(112, 25);
            this.lblTime.TabIndex = 20;
            this.lblTime.Text = "59:59:00 PM";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(73, 81);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(171, 25);
            this.lblDate.TabIndex = 18;
            this.lblDate.Text = "Today : 31/12-2016";
            // 
            // btnOwnProfile
            // 
            this.btnOwnProfile.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOwnProfile.Location = new System.Drawing.Point(120, 297);
            this.btnOwnProfile.Name = "btnOwnProfile";
            this.btnOwnProfile.Size = new System.Drawing.Size(191, 58);
            this.btnOwnProfile.TabIndex = 10;
            this.btnOwnProfile.Text = "Current Branch Info";
            this.btnOwnProfile.UseVisualStyleBackColor = true;
            this.btnOwnProfile.Click += new System.EventHandler(this.btnOwnProfile_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(12, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(276, 32);
            this.label6.TabIndex = 1;
            this.label6.Text = "Welcome to Donor Panel";
            // 
            // btnDonateHistory
            // 
            this.btnDonateHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonateHistory.Location = new System.Drawing.Point(120, 132);
            this.btnDonateHistory.Name = "btnDonateHistory";
            this.btnDonateHistory.Size = new System.Drawing.Size(191, 58);
            this.btnDonateHistory.TabIndex = 5;
            this.btnDonateHistory.Text = "Blood Donates History";
            this.btnDonateHistory.UseVisualStyleBackColor = true;
            this.btnDonateHistory.Click += new System.EventHandler(this.btnBllodInfo_Click);
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
            // DonorDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 381);
            this.Controls.Add(this.panel3);
            this.Name = "DonorDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Donor Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BranchDashBoard_FormClosed);
            this.Load += new System.EventHandler(this.DonorDashBoard_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.changeSettingsMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDonateHistory;
        private System.Windows.Forms.Timer clock;
        private System.Windows.Forms.LinkLabel settingsLink;
        private System.Windows.Forms.ContextMenuStrip changeSettingsMenu;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutMenuItem;
        private System.Windows.Forms.Button btnOwnProfile;
        private System.Windows.Forms.Button btnUserProfile;
    }
}