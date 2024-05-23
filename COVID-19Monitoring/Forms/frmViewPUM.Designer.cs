namespace COVID_19Monitoring.Forms
{
    partial class frmViewPUM
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPUM = new System.Windows.Forms.Label();
            this.dgvPUM = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPUM)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lblPUM, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dgvPUM, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.916182F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.08382F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1460, 859);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lblPUM
            // 
            this.lblPUM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPUM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPUM.Location = new System.Drawing.Point(3, 0);
            this.lblPUM.Name = "lblPUM";
            this.lblPUM.Size = new System.Drawing.Size(1454, 68);
            this.lblPUM.TabIndex = 0;
            this.lblPUM.Text = "PUM\'s";
            this.lblPUM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvPUM
            // 
            this.dgvPUM.AllowUserToAddRows = false;
            this.dgvPUM.AllowUserToDeleteRows = false;
            this.dgvPUM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPUM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3});
            this.dgvPUM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPUM.Location = new System.Drawing.Point(3, 71);
            this.dgvPUM.Name = "dgvPUM";
            this.dgvPUM.ReadOnly = true;
            this.dgvPUM.RowHeadersVisible = false;
            this.dgvPUM.Size = new System.Drawing.Size(1454, 785);
            this.dgvPUM.TabIndex = 1;
            this.dgvPUM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPUM_CellContentClick);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Update Status";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Delete";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // frmListPUM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 859);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListPUM";
            this.Text = "frmListPUM";
            this.Load += new System.EventHandler(this.frmListPUM_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPUM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblPUM;
        private System.Windows.Forms.DataGridView dgvPUM;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
    }
}