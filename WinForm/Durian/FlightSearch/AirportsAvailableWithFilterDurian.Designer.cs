namespace SolutionNorSolutionPort.UserInterface {

    public partial class AirportsAvailableWithFilterDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewAirportsAvailableWithFilter;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewAirportsAvailableWithFilter = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAirportsAvailableWithFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAirportsAvailableWithFilter
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewAirportsAvailableWithFilter.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAirportsAvailableWithFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAirportsAvailableWithFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAirportsAvailableWithFilter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAirportsAvailableWithFilter.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAirportsAvailableWithFilter.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewAirportsAvailableWithFilter.Name = "dataGridViewAirportsAvailableWithFilter";
            this.dataGridViewAirportsAvailableWithFilter.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewAirportsAvailableWithFilter.Click += new System.EventHandler(this.dataGridViewAirportsAvailableWithFilter_Click);
            this.dataGridViewAirportsAvailableWithFilter.TabIndex = 1;
            // 
            // AirportsAvailableWithFilterDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewAirportsAvailableWithFilter);
            this.Name = "AirportsAvailableWithFilterDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAirportsAvailableWithFilter)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
