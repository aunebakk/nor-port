namespace SolutionNorSolutionPort.UserInterface {

    public partial class ServiceCarRentalListDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewServiceCarRentalList;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewServiceCarRentalList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServiceCarRentalList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewServiceCarRentalList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewServiceCarRentalList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewServiceCarRentalList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewServiceCarRentalList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewServiceCarRentalList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewServiceCarRentalList.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewServiceCarRentalList.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewServiceCarRentalList.Name = "dataGridViewServiceCarRentalList";
            this.dataGridViewServiceCarRentalList.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewServiceCarRentalList.Click += new System.EventHandler(this.dataGridViewServiceCarRentalList_Click);
            this.dataGridViewServiceCarRentalList.TabIndex = 1;
            // 
            // ServiceCarRentalListDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewServiceCarRentalList);
            this.Name = "ServiceCarRentalListDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServiceCarRentalList)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
