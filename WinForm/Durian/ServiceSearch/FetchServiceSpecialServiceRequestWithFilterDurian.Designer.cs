namespace SolutionNorSolutionPort.UserInterface {

    public partial class FetchServiceSpecialServiceRequestWithFilterDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewFetchServiceSpecialServiceRequestWithFilter;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewFetchServiceSpecialServiceRequestWithFilter = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFetchServiceSpecialServiceRequestWithFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFetchServiceSpecialServiceRequestWithFilter
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewFetchServiceSpecialServiceRequestWithFilter.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFetchServiceSpecialServiceRequestWithFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFetchServiceSpecialServiceRequestWithFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFetchServiceSpecialServiceRequestWithFilter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFetchServiceSpecialServiceRequestWithFilter.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewFetchServiceSpecialServiceRequestWithFilter.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewFetchServiceSpecialServiceRequestWithFilter.Name = "dataGridViewFetchServiceSpecialServiceRequestWithFilter";
            this.dataGridViewFetchServiceSpecialServiceRequestWithFilter.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewFetchServiceSpecialServiceRequestWithFilter.Click += new System.EventHandler(this.dataGridViewFetchServiceSpecialServiceRequestWithFilter_Click);
            this.dataGridViewFetchServiceSpecialServiceRequestWithFilter.TabIndex = 1;
            // 
            // FetchServiceSpecialServiceRequestWithFilterDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewFetchServiceSpecialServiceRequestWithFilter);
            this.Name = "FetchServiceSpecialServiceRequestWithFilterDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFetchServiceSpecialServiceRequestWithFilter)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
