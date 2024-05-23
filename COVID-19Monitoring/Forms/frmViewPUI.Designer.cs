namespace COVID_19Monitoring.Forms
{
    partial class frmViewPUI
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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvPUI = new System.Windows.Forms.DataGridView();
            this.lblPUI = new System.Windows.Forms.Label();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPUI)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.dgvPUI, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblPUI, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.916182F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.08382F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1460, 859);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // dgvPUI
            // 
            this.dgvPUI.AllowUserToAddRows = false;
            this.dgvPUI.AllowUserToDeleteRows = false;
            this.dgvPUI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPUI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewButtonColumn2,
            this.dataGridViewButtonColumn3});
            this.dgvPUI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPUI.Location = new System.Drawing.Point(3, 71);
            this.dgvPUI.Name = "dgvPUI";
            this.dgvPUI.ReadOnly = true;
            this.dgvPUI.RowHeadersVisible = false;
            this.dgvPUI.Size = new System.Drawing.Size(1454, 785);
            this.dgvPUI.TabIndex = 2;
            this.dgvPUI.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPUI_CellContentClick);
            // 
            // lblPUI
            // 
            this.lblPUI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPUI.Location = new System.Drawing.Point(3, 0);
            this.lblPUI.Name = "lblPUI";
            this.lblPUI.Size = new System.Drawing.Size(1454, 68);
            this.lblPUI.TabIndex = 1;
            this.lblPUI.Text = "PUI\'s";
            this.lblPUI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewButtonColumn2
            // 
            this.dataGridViewButtonColumn2.HeaderText = "Update Status";
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.ReadOnly = true;
            // 
            // dataGridViewButtonColumn3
            // 
            this.dataGridViewButtonColumn3.HeaderText = "Delete";
            this.dataGridViewButtonColumn3.Name = "dataGridViewButtonColumn3";
            this.dataGridViewButtonColumn3.ReadOnly = true;
            // 
            // frmListPUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 859);
            this.Controls.Add(this.tableLayoutPanel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListPUI";
            this.Text = "frmListPUI";
            this.Load += new System.EventHandler(this.frmListPUI_Load);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPUI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView dgvPUI;
        private System.Windows.Forms.Label lblPUI;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn3;
    }
}