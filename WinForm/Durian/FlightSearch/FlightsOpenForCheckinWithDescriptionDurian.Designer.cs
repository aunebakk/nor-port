namespace SolutionNorSolutionPort.UserInterface {

    public partial class FlightsOpenForCheckinWithDescriptionDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewFlightsOpenForCheckinWithDescription;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewFlightsOpenForCheckinWithDescription = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlightsOpenForCheckinWithDescription)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFlightsOpenForCheckinWithDescription
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewFlightsOpenForCheckinWithDescription.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFlightsOpenForCheckinWithDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFlightsOpenForCheckinWithDescription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFlightsOpenForCheckinWithDescription.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFlightsOpenForCheckinWithDescription.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewFlightsOpenForCheckinWithDescription.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewFlightsOpenForCheckinWithDescription.Name = "dataGridViewFlightsOpenForCheckinWithDescription";
            this.dataGridViewFlightsOpenForCheckinWithDescription.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewFlightsOpenForCheckinWithDescription.Click += new System.EventHandler(this.dataGridViewFlightsOpenForCheckinWithDescription_Click);
            this.dataGridViewFlightsOpenForCheckinWithDescription.TabIndex = 1;
            // 
            // FlightsOpenForCheckinWithDescriptionDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewFlightsOpenForCheckinWithDescription);
            this.Name = "FlightsOpenForCheckinWithDescriptionDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlightsOpenForCheckinWithDescription)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
