namespace SolutionNorSolutionPort.UserInterface {

    public partial class SpecialServiceRequestListDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewSpecialServiceRequestList;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewSpecialServiceRequestList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpecialServiceRequestList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSpecialServiceRequestList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewSpecialServiceRequestList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSpecialServiceRequestList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSpecialServiceRequestList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSpecialServiceRequestList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSpecialServiceRequestList.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSpecialServiceRequestList.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewSpecialServiceRequestList.Name = "dataGridViewSpecialServiceRequestList";
            this.dataGridViewSpecialServiceRequestList.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewSpecialServiceRequestList.Click += new System.EventHandler(this.dataGridViewSpecialServiceRequestList_Click);
            this.dataGridViewSpecialServiceRequestList.TabIndex = 1;
            // 
            // SpecialServiceRequestListDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewSpecialServiceRequestList);
            this.Name = "SpecialServiceRequestListDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpecialServiceRequestList)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
