namespace SolutionNorSolutionPort.UserInterface {

    public partial class ServiceHotelListDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewServiceHotelList;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewServiceHotelList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServiceHotelList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewServiceHotelList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewServiceHotelList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewServiceHotelList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewServiceHotelList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewServiceHotelList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewServiceHotelList.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewServiceHotelList.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewServiceHotelList.Name = "dataGridViewServiceHotelList";
            this.dataGridViewServiceHotelList.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewServiceHotelList.Click += new System.EventHandler(this.dataGridViewServiceHotelList_Click);
            this.dataGridViewServiceHotelList.TabIndex = 1;
            // 
            // ServiceHotelListDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewServiceHotelList);
            this.Name = "ServiceHotelListDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServiceHotelList)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
