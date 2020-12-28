namespace SolutionNorSolutionPort.UserInterface {

    public partial class GetServicePackageDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewGetServicePackage;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewGetServicePackage = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGetServicePackage)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGetServicePackage
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewGetServicePackage.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewGetServicePackage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewGetServicePackage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGetServicePackage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGetServicePackage.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewGetServicePackage.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewGetServicePackage.Name = "dataGridViewGetServicePackage";
            this.dataGridViewGetServicePackage.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewGetServicePackage.Click += new System.EventHandler(this.dataGridViewGetServicePackage_Click);
            this.dataGridViewGetServicePackage.TabIndex = 1;
            // 
            // GetServicePackageDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewGetServicePackage);
            this.Name = "GetServicePackageDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGetServicePackage)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
