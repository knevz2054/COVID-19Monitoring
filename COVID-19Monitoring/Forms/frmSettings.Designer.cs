namespace COVID_19Monitoring.Forms
{
    partial class frmSettings
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
            this.tabSettings = new System.Windows.Forms.TabControl();
            this.pageBarangay = new System.Windows.Forms.TabPage();
            this.dgvBarangay = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCreateBarangay = new System.Windows.Forms.Button();
            this.pagePlace = new System.Windows.Forms.TabPage();
            this.pageSymptoms = new System.Windows.Forms.TabPage();
            this.dgvPlace = new System.Windows.Forms.DataGridView();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPlace = new System.Windows.Forms.Button();
            this.dgvSymptom = new System.Windows.Forms.DataGridView();
            this.dataGridViewButtonColumn3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCreateSymptom = new System.Windows.Forms.Button();
            this.tabSettings.SuspendLayout();
            this.pageBarangay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarangay)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.pagePlace.SuspendLayout();
            this.pageSymptoms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlace)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSymptom)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.pageBarangay);
            this.tabSettings.Controls.Add(this.pagePlace);
            this.tabSettings.Controls.Add(this.pageSymptoms);
            this.tabSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSettings.Location = new System.Drawing.Point(0, 0);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.SelectedIndex = 0;
            this.tabSettings.Size = new System.Drawing.Size(1451, 864);
            this.tabSettings.TabIndex = 0;
            // 
            // pageBarangay
            // 
            this.pageBarangay.Controls.Add(this.dgvBarangay);
            this.pageBarangay.Controls.Add(this.tableLayoutPanel1);
            this.pageBarangay.Location = new System.Drawing.Point(4, 22);
            this.pageBarangay.Name = "pageBarangay";
            this.pageBarangay.Padding = new System.Windows.Forms.Padding(3);
            this.pageBarangay.Size = new System.Drawing.Size(1443, 838);
            this.pageBarangay.TabIndex = 0;
            this.pageBarangay.Text = "Barangay";
            this.pageBarangay.UseVisualStyleBackColor = true;
            // 
            // dgvBarangay
            // 
            this.dgvBarangay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBarangay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3});
            this.dgvBarangay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBarangay.Location = new System.Drawing.Point(3, 45);
            this.dgvBarangay.Name = "dgvBarangay";
            this.dgvBarangay.RowHeadersVisible = false;
            this.dgvBarangay.Size = new System.Drawing.Size(1437, 790);
            this.dgvBarangay.TabIndex = 3;
            this.dgvBarangay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBarangay_CellContentClick);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Edit";
            this.Column2.Name = "Column2";
            this.Column2.Width = 60;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Delete";
            this.Column3.Name = "Column3";
            this.Column3.Width = 60;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.btnCreateBarangay, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1437, 42);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnCreateBarangay
            // 
            this.btnCreateBarangay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCreateBarangay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateBarangay.Location = new System.Drawing.Point(3, 3);
            this.btnCreateBarangay.Name = "btnCreateBarangay";
            this.btnCreateBarangay.Size = new System.Drawing.Size(137, 36);
            this.btnCreateBarangay.TabIndex = 0;
            this.btnCreateBarangay.Text = "Create Barangay";
            this.btnCreateBarangay.UseVisualStyleBackColor = true;
            this.btnCreateBarangay.Click += new System.EventHandler(this.btnCreateBarangay_Click);
            // 
            // pagePlace
            // 
            this.pagePlace.Controls.Add(this.dgvPlace);
            this.pagePlace.Controls.Add(this.tableLayoutPanel2);
            this.pagePlace.Location = new System.Drawing.Point(4, 22);
            this.pagePlace.Name = "pagePlace";
            this.pagePlace.Padding = new System.Windows.Forms.Padding(3);
            this.pagePlace.Size = new System.Drawing.Size(1443, 838);
            this.pagePlace.TabIndex = 1;
            this.pagePlace.Text = "Place of Origin";
            this.pagePlace.UseVisualStyleBackColor = true;
            // 
            // pageSymptoms
            // 
            this.pageSymptoms.Controls.Add(this.dgvSymptom);
            this.pageSymptoms.Controls.Add(this.tableLayoutPanel3);
            this.pageSymptoms.Location = new System.Drawing.Point(4, 22);
            this.pageSymptoms.Name = "pageSymptoms";
            this.pageSymptoms.Padding = new System.Windows.Forms.Padding(3);
            this.pageSymptoms.Size = new System.Drawing.Size(1443, 838);
            this.pageSymptoms.TabIndex = 2;
            this.pageSymptoms.Text = "Symptoms";
            this.pageSymptoms.UseVisualStyleBackColor = true;
            // 
            // dgvPlace
            // 
            this.dgvPlace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlace.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewButtonColumn1,
            this.dataGridViewButtonColumn2});
            this.dgvPlace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPlace.Location = new System.Drawing.Point(3, 45);
            this.dgvPlace.Name = "dgvPlace";
            this.dgvPlace.RowHeadersVisible = false;
            this.dgvPlace.Size = new System.Drawing.Size(1437, 790);
            this.dgvPlace.TabIndex = 5;
            this.dgvPlace.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlace_CellContentClick);
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Edit";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Width = 60;
            // 
            // dataGridViewButtonColumn2
            // 
            this.dataGridViewButtonColumn2.HeaderText = "Delete";
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.Width = 60;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 10;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.btnPlace, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1437, 42);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // btnPlace
            // 
            this.btnPlace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlace.Location = new System.Drawing.Point(3, 3);
            this.btnPlace.Name = "btnPlace";
            this.btnPlace.Size = new System.Drawing.Size(137, 36);
            this.btnPlace.TabIndex = 0;
            this.btnPlace.Text = "Create Place of Origin";
            this.btnPlace.UseVisualStyleBackColor = true;
            this.btnPlace.Click += new System.EventHandler(this.btnPlace_Click);
            // 
            // dgvSymptom
            // 
            this.dgvSymptom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSymptom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewButtonColumn3,
            this.dataGridViewButtonColumn4});
            this.dgvSymptom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSymptom.Location = new System.Drawing.Point(3, 45);
            this.dgvSymptom.Name = "dgvSymptom";
            this.dgvSymptom.RowHeadersVisible = false;
            this.dgvSymptom.Size = new System.Drawing.Size(1437, 790);
            this.dgvSymptom.TabIndex = 5;
            this.dgvSymptom.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSymptom_CellContentClick);
            // 
            // dataGridViewButtonColumn3
            // 
            this.dataGridViewButtonColumn3.HeaderText = "Edit";
            this.dataGridViewButtonColumn3.Name = "dataGridViewButtonColumn3";
            this.dataGridViewButtonColumn3.Width = 60;
            // 
            // dataGridViewButtonColumn4
            // 
            this.dataGridViewButtonColumn4.HeaderText = "Delete";
            this.dataGridViewButtonColumn4.Name = "dataGridViewButtonColumn4";
            this.dataGridViewButtonColumn4.Width = 60;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 10;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Controls.Add(this.btnCreateSymptom, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1437, 42);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // btnCreateSymptom
            // 
            this.btnCreateSymptom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCreateSymptom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateSymptom.Location = new System.Drawing.Point(3, 3);
            this.btnCreateSymptom.Name = "btnCreateSymptom";
            this.btnCreateSymptom.Size = new System.Drawing.Size(137, 36);
            this.btnCreateSymptom.TabIndex = 0;
            this.btnCreateSymptom.Text = "Create Symptom";
            this.btnCreateSymptom.UseVisualStyleBackColor = true;
            this.btnCreateSymptom.Click += new System.EventHandler(this.btnCreateSymptom_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 864);
            this.Controls.Add(this.tabSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSettings";
            this.ShowInTaskbar = false;
            this.Text = "frmSettings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.tabSettings.ResumeLayout(false);
            this.pageBarangay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarangay)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pagePlace.ResumeLayout(false);
            this.pageSymptoms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlace)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSymptom)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabSettings;
        private System.Windows.Forms.TabPage pagePlace;
        private System.Windows.Forms.TabPage pageSymptoms;
        private System.Windows.Forms.TabPage pageBarangay;
        private System.Windows.Forms.DataGridView dgvBarangay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCreateBarangay;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
        private System.Windows.Forms.DataGridView dgvPlace;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnPlace;
        private System.Windows.Forms.DataGridView dgvSymptom;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn3;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnCreateSymptom;
    }
}