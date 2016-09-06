namespace BloodBankManagmentSystem.Bloood_Request
{
    partial class BloodRequestForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBloodGroup = new System.Windows.Forms.ComboBox();
            this.DeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.ReceiveDate = new System.Windows.Forms.DateTimePicker();
            this.comboSearchOptions = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefreash = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.BloodRequestGrid = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BloodRequestGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ReceiveDate);
            this.panel1.Controls.Add(this.comboSearchOptions);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnRefreash);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.BloodRequestGrid);
            this.panel1.Controls.Add(this.comboBloodGroup);
            this.panel1.Controls.Add(this.DeliveryDate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 427);
            this.panel1.TabIndex = 0;
            // 
            // comboBloodGroup
            // 
            this.comboBloodGroup.FormattingEnabled = true;
            this.comboBloodGroup.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.comboBloodGroup.Location = new System.Drawing.Point(459, 100);
            this.comboBloodGroup.Name = "comboBloodGroup";
            this.comboBloodGroup.Size = new System.Drawing.Size(121, 28);
            this.comboBloodGroup.TabIndex = 11;
            this.comboBloodGroup.Visible = false;
            // 
            // DeliveryDate
            // 
            this.DeliveryDate.CustomFormat = "dd-MM-yyyy";
            this.DeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DeliveryDate.Location = new System.Drawing.Point(459, 101);
            this.DeliveryDate.Name = "DeliveryDate";
            this.DeliveryDate.Size = new System.Drawing.Size(121, 27);
            this.DeliveryDate.TabIndex = 10;
            this.DeliveryDate.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Search Key";
            // 
            // ReceiveDate
            // 
            this.ReceiveDate.CustomFormat = "dd-MM-yyyy";
            this.ReceiveDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ReceiveDate.Location = new System.Drawing.Point(459, 101);
            this.ReceiveDate.Name = "ReceiveDate";
            this.ReceiveDate.Size = new System.Drawing.Size(121, 27);
            this.ReceiveDate.TabIndex = 8;
            // 
            // comboSearchOptions
            // 
            this.comboSearchOptions.FormattingEnabled = true;
            this.comboSearchOptions.Items.AddRange(new object[] {
            "Received Date",
            "Deliveried Date",
            "Blood Group"});
            this.comboSearchOptions.Location = new System.Drawing.Point(248, 100);
            this.comboSearchOptions.Name = "comboSearchOptions";
            this.comboSearchOptions.Size = new System.Drawing.Size(121, 28);
            this.comboSearchOptions.TabIndex = 7;
            this.comboSearchOptions.SelectedIndexChanged += new System.EventHandler(this.comboSearchOptions_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search Options";
            // 
            // btnRefreash
            // 
            this.btnRefreash.Location = new System.Drawing.Point(13, 166);
            this.btnRefreash.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefreash.Name = "btnRefreash";
            this.btnRefreash.Size = new System.Drawing.Size(120, 30);
            this.btnRefreash.TabIndex = 5;
            this.btnRefreash.Text = "Refreash";
            this.btnRefreash.UseVisualStyleBackColor = true;
            this.btnRefreash.Click += new System.EventHandler(this.btnRefreash_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(13, 328);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 30);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete Request";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(13, 273);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 30);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update Request";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 218);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 30);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add Request";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // BloodRequestGrid
            // 
            this.BloodRequestGrid.AllowUserToAddRows = false;
            this.BloodRequestGrid.AllowUserToDeleteRows = false;
            this.BloodRequestGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.BloodRequestGrid.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BloodRequestGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.BloodRequestGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BloodRequestGrid.GridColor = System.Drawing.SystemColors.Control;
            this.BloodRequestGrid.Location = new System.Drawing.Point(141, 141);
            this.BloodRequestGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BloodRequestGrid.MultiSelect = false;
            this.BloodRequestGrid.Name = "BloodRequestGrid";
            this.BloodRequestGrid.ReadOnly = true;
            this.BloodRequestGrid.RowHeadersVisible = false;
            this.BloodRequestGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BloodRequestGrid.Size = new System.Drawing.Size(679, 281);
            this.BloodRequestGrid.TabIndex = 1;
            this.BloodRequestGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.BloodRequestGrid_CellMouseClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(587, 98);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 30);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(231, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(349, 40);
            this.label3.TabIndex = 13;
            this.label3.Text = "Blood Request Informations";
            // 
            // BloodRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 427);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BloodRequestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blood Request Informations";
            this.Load += new System.EventHandler(this.BloodRequestForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BloodRequestGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView BloodRequestGrid;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRefreash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboSearchOptions;
        private System.Windows.Forms.DateTimePicker ReceiveDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBloodGroup;
        private System.Windows.Forms.DateTimePicker DeliveryDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
    }
}