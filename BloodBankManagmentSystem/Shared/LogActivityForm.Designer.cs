namespace BloodBankManagmentSystem.Shared
{
    partial class LogActivityForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnEmpLogSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboSearchOptions = new System.Windows.Forms.ComboBox();
            this.txtSearchKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LoginDate = new System.Windows.Forms.DateTimePicker();
            this.EmpLogActivityGrid = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboDSearchOptions = new System.Windows.Forms.ComboBox();
            this.txtDSearchKey = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DLoginDate = new System.Windows.Forms.DateTimePicker();
            this.DonorLoginActivityGrid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpLogActivityGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DonorLoginActivityGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 486);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login Activities Information";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Location = new System.Drawing.Point(3, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(730, 428);
            this.panel2.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(730, 428);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnEmpLogSearch);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.comboSearchOptions);
            this.tabPage1.Controls.Add(this.txtSearchKey);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.LoginDate);
            this.tabPage1.Controls.Add(this.EmpLogActivityGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(722, 395);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Employees Login Activities";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnEmpLogSearch
            // 
            this.btnEmpLogSearch.Location = new System.Drawing.Point(386, 52);
            this.btnEmpLogSearch.Name = "btnEmpLogSearch";
            this.btnEmpLogSearch.Size = new System.Drawing.Size(107, 27);
            this.btnEmpLogSearch.TabIndex = 7;
            this.btnEmpLogSearch.Text = "Search";
            this.btnEmpLogSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEmpLogSearch.UseVisualStyleBackColor = true;
            this.btnEmpLogSearch.Click += new System.EventHandler(this.btnEmpLogSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Search Here";
            // 
            // comboSearchOptions
            // 
            this.comboSearchOptions.FormattingEnabled = true;
            this.comboSearchOptions.Items.AddRange(new object[] {
            "Date",
            "Username",
            "User ID"});
            this.comboSearchOptions.Location = new System.Drawing.Point(118, 18);
            this.comboSearchOptions.Name = "comboSearchOptions";
            this.comboSearchOptions.Size = new System.Drawing.Size(121, 28);
            this.comboSearchOptions.TabIndex = 5;
            this.comboSearchOptions.SelectedIndexChanged += new System.EventHandler(this.comboSearchOptions_SelectedIndexChanged);
            // 
            // txtSearchKey
            // 
            this.txtSearchKey.Location = new System.Drawing.Point(118, 52);
            this.txtSearchKey.Name = "txtSearchKey";
            this.txtSearchKey.Size = new System.Drawing.Size(262, 27);
            this.txtSearchKey.TabIndex = 4;
            this.txtSearchKey.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Search Options";
            // 
            // LoginDate
            // 
            this.LoginDate.CustomFormat = "dd-MM-yyyy";
            this.LoginDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.LoginDate.Location = new System.Drawing.Point(118, 52);
            this.LoginDate.Name = "LoginDate";
            this.LoginDate.Size = new System.Drawing.Size(262, 27);
            this.LoginDate.TabIndex = 2;
            // 
            // EmpLogActivityGrid
            // 
            this.EmpLogActivityGrid.AllowUserToAddRows = false;
            this.EmpLogActivityGrid.AllowUserToDeleteRows = false;
            this.EmpLogActivityGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.EmpLogActivityGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpLogActivityGrid.Location = new System.Drawing.Point(6, 86);
            this.EmpLogActivityGrid.Name = "EmpLogActivityGrid";
            this.EmpLogActivityGrid.ReadOnly = true;
            this.EmpLogActivityGrid.RowHeadersVisible = false;
            this.EmpLogActivityGrid.Size = new System.Drawing.Size(710, 303);
            this.EmpLogActivityGrid.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DonorLoginActivityGrid);
            this.tabPage2.Controls.Add(this.btnDSearch);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.comboDSearchOptions);
            this.tabPage2.Controls.Add(this.txtDSearchKey);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.DLoginDate);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(722, 395);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Donors Login Activities";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDSearch
            // 
            this.btnDSearch.Location = new System.Drawing.Point(385, 45);
            this.btnDSearch.Name = "btnDSearch";
            this.btnDSearch.Size = new System.Drawing.Size(106, 28);
            this.btnDSearch.TabIndex = 14;
            this.btnDSearch.Text = "Search";
            this.btnDSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDSearch.UseVisualStyleBackColor = true;
            this.btnDSearch.Click += new System.EventHandler(this.btnDSearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Search Here";
            // 
            // comboDSearchOptions
            // 
            this.comboDSearchOptions.FormattingEnabled = true;
            this.comboDSearchOptions.Items.AddRange(new object[] {
            "Date",
            "Username",
            "User ID"});
            this.comboDSearchOptions.Location = new System.Drawing.Point(117, 12);
            this.comboDSearchOptions.Name = "comboDSearchOptions";
            this.comboDSearchOptions.Size = new System.Drawing.Size(121, 28);
            this.comboDSearchOptions.TabIndex = 12;
            this.comboDSearchOptions.SelectedIndexChanged += new System.EventHandler(this.comboDSearchOptions_SelectedIndexChanged);
            // 
            // txtDSearchKey
            // 
            this.txtDSearchKey.Location = new System.Drawing.Point(117, 46);
            this.txtDSearchKey.Name = "txtDSearchKey";
            this.txtDSearchKey.Size = new System.Drawing.Size(262, 27);
            this.txtDSearchKey.TabIndex = 11;
            this.txtDSearchKey.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Search Options";
            // 
            // DLoginDate
            // 
            this.DLoginDate.CustomFormat = "dd/MMM/yyyy";
            this.DLoginDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DLoginDate.Location = new System.Drawing.Point(117, 46);
            this.DLoginDate.Name = "DLoginDate";
            this.DLoginDate.Size = new System.Drawing.Size(262, 27);
            this.DLoginDate.TabIndex = 9;
            // 
            // DonorLoginActivityGrid
            // 
            this.DonorLoginActivityGrid.AllowUserToAddRows = false;
            this.DonorLoginActivityGrid.AllowUserToDeleteRows = false;
            this.DonorLoginActivityGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DonorLoginActivityGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DonorLoginActivityGrid.Location = new System.Drawing.Point(5, 79);
            this.DonorLoginActivityGrid.Name = "DonorLoginActivityGrid";
            this.DonorLoginActivityGrid.ReadOnly = true;
            this.DonorLoginActivityGrid.RowHeadersVisible = false;
            this.DonorLoginActivityGrid.Size = new System.Drawing.Size(710, 310);
            this.DonorLoginActivityGrid.TabIndex = 15;
            // 
            // LogActivityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 486);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LogActivityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log Activities Info";
            this.Load += new System.EventHandler(this.LogActivityForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpLogActivityGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DonorLoginActivityGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView EmpLogActivityGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker LoginDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboSearchOptions;
        private System.Windows.Forms.TextBox txtSearchKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboDSearchOptions;
        private System.Windows.Forms.TextBox txtDSearchKey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DLoginDate;
        private System.Windows.Forms.Button btnEmpLogSearch;
        private System.Windows.Forms.Button btnDSearch;
        private System.Windows.Forms.DataGridView DonorLoginActivityGrid;

    }
}