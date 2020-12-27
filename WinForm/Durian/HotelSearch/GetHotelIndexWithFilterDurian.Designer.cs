namespace SolutionNorSolutionPort.UserInterface {

    public partial class GetHotelIndexWithFilterDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewGetHotelIndexWithFilter;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewGetHotelIndexWithFilter = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGetHotelIndexWithFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGetHotelIndexWithFilter
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewGetHotelIndexWithFilter.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewGetHotelIndexWithFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewGetHotelIndexWithFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGetHotelIndexWithFilter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGetHotelIndexWithFilter.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewGetHotelIndexWithFilter.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewGetHotelIndexWithFilter.Name = "dataGridViewGetHotelIndexWithFilter";
            this.dataGridViewGetHotelIndexWithFilter.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewGetHotelIndexWithFilter.Click += new System.EventHandler(this.dataGridViewGetHotelIndexWithFilter_Click);
            this.dataGridViewGetHotelIndexWithFilter.TabIndex = 1;
            // 
            // GetHotelIndexWithFilterDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewGetHotelIndexWithFilter);
            this.Name = "GetHotelIndexWithFilterDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGetHotelIndexWithFilter)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
