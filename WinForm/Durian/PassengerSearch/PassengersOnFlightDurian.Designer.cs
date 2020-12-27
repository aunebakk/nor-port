namespace SolutionNorSolutionPort.UserInterface {

    public partial class PassengersOnFlightDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewPassengersOnFlight;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewPassengersOnFlight = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPassengersOnFlight)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPassengersOnFlight
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewPassengersOnFlight.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPassengersOnFlight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPassengersOnFlight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPassengersOnFlight.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPassengersOnFlight.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPassengersOnFlight.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewPassengersOnFlight.Name = "dataGridViewPassengersOnFlight";
            this.dataGridViewPassengersOnFlight.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewPassengersOnFlight.Click += new System.EventHandler(this.dataGridViewPassengersOnFlight_Click);
            this.dataGridViewPassengersOnFlight.TabIndex = 1;
            // 
            // PassengersOnFlightDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewPassengersOnFlight);
            this.Name = "PassengersOnFlightDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPassengersOnFlight)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
