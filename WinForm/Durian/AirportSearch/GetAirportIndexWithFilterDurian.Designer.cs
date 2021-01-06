namespace SolutionNorSolutionPort.UserInterface {

    public partial class GetAirportIndexWithFilterDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewGetAirportIndexWithFilter;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewGetAirportIndexWithFilter = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGetAirportIndexWithFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGetAirportIndexWithFilter
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewGetAirportIndexWithFilter.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewGetAirportIndexWithFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewGetAirportIndexWithFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGetAirportIndexWithFilter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGetAirportIndexWithFilter.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewGetAirportIndexWithFilter.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewGetAirportIndexWithFilter.Name = "dataGridViewGetAirportIndexWithFilter";
            this.dataGridViewGetAirportIndexWithFilter.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewGetAirportIndexWithFilter.Click += new System.EventHandler(this.dataGridViewGetAirportIndexWithFilter_Click);
            this.dataGridViewGetAirportIndexWithFilter.TabIndex = 1;
            // 
            // GetAirportIndexWithFilterDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewGetAirportIndexWithFilter);
            this.Name = "GetAirportIndexWithFilterDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGetAirportIndexWithFilter)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
