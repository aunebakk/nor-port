namespace SolutionNorSolutionPort.UserInterface {

    public partial class GetFerryIndexWithFilterDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewGetFerryIndexWithFilter;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewGetFerryIndexWithFilter = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGetFerryIndexWithFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGetFerryIndexWithFilter
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewGetFerryIndexWithFilter.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewGetFerryIndexWithFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewGetFerryIndexWithFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGetFerryIndexWithFilter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGetFerryIndexWithFilter.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewGetFerryIndexWithFilter.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewGetFerryIndexWithFilter.Name = "dataGridViewGetFerryIndexWithFilter";
            this.dataGridViewGetFerryIndexWithFilter.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewGetFerryIndexWithFilter.Click += new System.EventHandler(this.dataGridViewGetFerryIndexWithFilter_Click);
            this.dataGridViewGetFerryIndexWithFilter.TabIndex = 1;
            // 
            // GetFerryIndexWithFilterDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewGetFerryIndexWithFilter);
            this.Name = "GetFerryIndexWithFilterDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGetFerryIndexWithFilter)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
