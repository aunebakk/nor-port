namespace SolutionNorSolutionPort.UserInterface
{


    public partial class GetAvailableCurrenciesLiveSearch
    {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClose;

        private System.Windows.Forms.DataGridView dataGridViewGetAvailableCurrencies;

        protected override void Dispose(bool disposing) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonClose = new System.Windows.Forms.Button();
            this.dataGridViewGetAvailableCurrencies = new System.Windows.Forms.DataGridView();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.dataGridViewGetAvailableCurrencies ) ).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonClose.Location = new System.Drawing.Point(433, 277);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // dataGridViewGetAvailableCurrencies
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(( ( int ) ( ( ( byte ) ( 192 ) ) ) ), ( ( int ) ( ( ( byte ) ( 192 ) ) ) ), ( ( int ) ( ( ( byte ) ( 255 ) ) ) ));
            this.dataGridViewGetAvailableCurrencies.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewGetAvailableCurrencies.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
            | System.Windows.Forms.AnchorStyles.Left )
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.dataGridViewGetAvailableCurrencies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGetAvailableCurrencies.Location = new System.Drawing.Point(2, 3);
            this.dataGridViewGetAvailableCurrencies.Name = "dataGridViewGetAvailableCurrencies";
            this.dataGridViewGetAvailableCurrencies.Size = new System.Drawing.Size(523, 268);
            this.dataGridViewGetAvailableCurrencies.TabIndex = 0;
            // 
            // GetAvailableCurrenciesLiveSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.dataGridViewGetAvailableCurrencies);
            this.Name = "GetAvailableCurrenciesLiveSearch";
            this.Text = "Get Available Currencies";
            ( ( System.ComponentModel.ISupportInitialize ) ( this.dataGridViewGetAvailableCurrencies ) ).EndInit();
            this.ResumeLayout(false);

        }
    }
}
