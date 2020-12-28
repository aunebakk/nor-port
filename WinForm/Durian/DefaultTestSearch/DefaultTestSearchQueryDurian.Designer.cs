namespace SolutionNorSolutionPort.UserInterface {

    public partial class DefaultTestSearchQueryDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewDefaultTestSearchQuery;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewDefaultTestSearchQuery = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDefaultTestSearchQuery)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDefaultTestSearchQuery
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewDefaultTestSearchQuery.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDefaultTestSearchQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDefaultTestSearchQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDefaultTestSearchQuery.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDefaultTestSearchQuery.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDefaultTestSearchQuery.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewDefaultTestSearchQuery.Name = "dataGridViewDefaultTestSearchQuery";
            this.dataGridViewDefaultTestSearchQuery.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewDefaultTestSearchQuery.Click += new System.EventHandler(this.dataGridViewDefaultTestSearchQuery_Click);
            this.dataGridViewDefaultTestSearchQuery.TabIndex = 1;
            // 
            // DefaultTestSearchQueryDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewDefaultTestSearchQuery);
            this.Name = "DefaultTestSearchQueryDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDefaultTestSearchQuery)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
