namespace SolutionNorSolutionPort.UserInterface {

    public partial class ServicePackagePromotionWithFilterDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewServicePackagePromotionWithFilter;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewServicePackagePromotionWithFilter = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServicePackagePromotionWithFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewServicePackagePromotionWithFilter
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewServicePackagePromotionWithFilter.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewServicePackagePromotionWithFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewServicePackagePromotionWithFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewServicePackagePromotionWithFilter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewServicePackagePromotionWithFilter.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewServicePackagePromotionWithFilter.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewServicePackagePromotionWithFilter.Name = "dataGridViewServicePackagePromotionWithFilter";
            this.dataGridViewServicePackagePromotionWithFilter.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewServicePackagePromotionWithFilter.Click += new System.EventHandler(this.dataGridViewServicePackagePromotionWithFilter_Click);
            this.dataGridViewServicePackagePromotionWithFilter.TabIndex = 1;
            // 
            // ServicePackagePromotionWithFilterDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewServicePackagePromotionWithFilter);
            this.Name = "ServicePackagePromotionWithFilterDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServicePackagePromotionWithFilter)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
