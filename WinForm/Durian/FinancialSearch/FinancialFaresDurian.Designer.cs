namespace SolutionNorSolutionPort.UserInterface {

    public partial class FinancialFaresDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewFinancialFares;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewFinancialFares = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFinancialFares)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFinancialFares
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewFinancialFares.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFinancialFares.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFinancialFares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFinancialFares.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFinancialFares.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewFinancialFares.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewFinancialFares.Name = "dataGridViewFinancialFares";
            this.dataGridViewFinancialFares.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewFinancialFares.Click += new System.EventHandler(this.dataGridViewFinancialFares_Click);
            this.dataGridViewFinancialFares.TabIndex = 1;
            // 
            // FinancialFaresDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewFinancialFares);
            this.Name = "FinancialFaresDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFinancialFares)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
