namespace SolutionNorSolutionPort.UserInterface {

    public partial class FlightEventsDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewFlightEvents;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewFlightEvents = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlightEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFlightEvents
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewFlightEvents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFlightEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFlightEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFlightEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFlightEvents.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewFlightEvents.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewFlightEvents.Name = "dataGridViewFlightEvents";
            this.dataGridViewFlightEvents.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewFlightEvents.Click += new System.EventHandler(this.dataGridViewFlightEvents_Click);
            this.dataGridViewFlightEvents.TabIndex = 1;
            // 
            // FlightEventsDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewFlightEvents);
            this.Name = "FlightEventsDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlightEvents)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
