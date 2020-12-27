namespace SolutionNorSolutionPort.UserInterface {

    public partial class BookingsOpenDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewBookingsOpen;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewBookingsOpen = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookingsOpen)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBookingsOpen
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewBookingsOpen.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBookingsOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBookingsOpen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookingsOpen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBookingsOpen.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewBookingsOpen.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewBookingsOpen.Name = "dataGridViewBookingsOpen";
            this.dataGridViewBookingsOpen.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewBookingsOpen.Click += new System.EventHandler(this.dataGridViewBookingsOpen_Click);
            this.dataGridViewBookingsOpen.TabIndex = 1;
            // 
            // BookingsOpenDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewBookingsOpen);
            this.Name = "BookingsOpenDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookingsOpen)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
