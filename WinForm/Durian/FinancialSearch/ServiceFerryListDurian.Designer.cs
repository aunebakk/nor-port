namespace SolutionNorSolutionPort.UserInterface {

    public partial class ServiceFerryListDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewServiceFerryList;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewServiceFerryList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServiceFerryList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewServiceFerryList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewServiceFerryList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewServiceFerryList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewServiceFerryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewServiceFerryList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewServiceFerryList.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewServiceFerryList.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewServiceFerryList.Name = "dataGridViewServiceFerryList";
            this.dataGridViewServiceFerryList.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewServiceFerryList.Click += new System.EventHandler(this.dataGridViewServiceFerryList_Click);
            this.dataGridViewServiceFerryList.TabIndex = 1;
            // 
            // ServiceFerryListDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewServiceFerryList);
            this.Name = "ServiceFerryListDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServiceFerryList)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
