namespace SolutionNorSolutionPort.UserInterface {

    public partial class GetAvailableCurrenciesDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewGetAvailableCurrencies;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewGetAvailableCurrencies = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGetAvailableCurrencies)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGetAvailableCurrencies
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewGetAvailableCurrencies.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewGetAvailableCurrencies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewGetAvailableCurrencies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGetAvailableCurrencies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGetAvailableCurrencies.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewGetAvailableCurrencies.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewGetAvailableCurrencies.Name = "dataGridViewGetAvailableCurrencies";
            this.dataGridViewGetAvailableCurrencies.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewGetAvailableCurrencies.Click += new System.EventHandler(this.dataGridViewGetAvailableCurrencies_Click);
            this.dataGridViewGetAvailableCurrencies.TabIndex = 1;
            // 
            // GetAvailableCurrenciesDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewGetAvailableCurrencies);
            this.Name = "GetAvailableCurrenciesDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGetAvailableCurrencies)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
