namespace SolutionNorSolutionPort.UserInterface {

    public partial class PassengersOnFlightCheckedInDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewPassengersOnFlightCheckedIn;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewPassengersOnFlightCheckedIn = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPassengersOnFlightCheckedIn)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPassengersOnFlightCheckedIn
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewPassengersOnFlightCheckedIn.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPassengersOnFlightCheckedIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPassengersOnFlightCheckedIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPassengersOnFlightCheckedIn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPassengersOnFlightCheckedIn.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPassengersOnFlightCheckedIn.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewPassengersOnFlightCheckedIn.Name = "dataGridViewPassengersOnFlightCheckedIn";
            this.dataGridViewPassengersOnFlightCheckedIn.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewPassengersOnFlightCheckedIn.Click += new System.EventHandler(this.dataGridViewPassengersOnFlightCheckedIn_Click);
            this.dataGridViewPassengersOnFlightCheckedIn.TabIndex = 1;
            // 
            // PassengersOnFlightCheckedInDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewPassengersOnFlightCheckedIn);
            this.Name = "PassengersOnFlightCheckedInDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPassengersOnFlightCheckedIn)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
