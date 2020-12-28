namespace SolutionNorSolutionPort.UserInterface {

    public partial class GetCarRentalIndexWithFilterDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewGetCarRentalIndexWithFilter;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewGetCarRentalIndexWithFilter = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGetCarRentalIndexWithFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGetCarRentalIndexWithFilter
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewGetCarRentalIndexWithFilter.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewGetCarRentalIndexWithFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewGetCarRentalIndexWithFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGetCarRentalIndexWithFilter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGetCarRentalIndexWithFilter.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewGetCarRentalIndexWithFilter.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewGetCarRentalIndexWithFilter.Name = "dataGridViewGetCarRentalIndexWithFilter";
            this.dataGridViewGetCarRentalIndexWithFilter.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewGetCarRentalIndexWithFilter.Click += new System.EventHandler(this.dataGridViewGetCarRentalIndexWithFilter_Click);
            this.dataGridViewGetCarRentalIndexWithFilter.TabIndex = 1;
            // 
            // GetCarRentalIndexWithFilterDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewGetCarRentalIndexWithFilter);
            this.Name = "GetCarRentalIndexWithFilterDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGetCarRentalIndexWithFilter)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
