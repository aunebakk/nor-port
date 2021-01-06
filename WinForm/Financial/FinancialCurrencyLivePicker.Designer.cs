namespace SolutionNorSolutionPort.UserInterface
{


    public partial class FinancialCurrencyLivePicker
    {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtFinancialCurrencyCode;

        private System.Windows.Forms.Label lblColon;

        private System.Windows.Forms.TextBox txtFinancialCurrencyName;

        protected override void Dispose(bool disposing) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose(disposing);

        }

        private void InitializeComponent() {
            this.txtFinancialCurrencyCode = new System.Windows.Forms.TextBox();
            this.lblColon = new System.Windows.Forms.Label();
            this.txtFinancialCurrencyName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtFinancialCurrencyCode
            // 
            this.txtFinancialCurrencyCode.Location = new System.Drawing.Point(0, 1);
            this.txtFinancialCurrencyCode.Name = "txtFinancialCurrencyCode";
            this.txtFinancialCurrencyCode.Size = new System.Drawing.Size(100, 20);
            this.txtFinancialCurrencyCode.TabIndex = 1;
            this.txtFinancialCurrencyCode.Validating += new System.ComponentModel.CancelEventHandler(this.txtFinancialCurrencyCode_Validating);
            // 
            // lblColon
            // 
            this.lblColon.AutoSize = true;
            this.lblColon.Location = new System.Drawing.Point(101, 2);
            this.lblColon.Name = "lblColon";
            this.lblColon.Size = new System.Drawing.Size(10, 13);
            this.lblColon.TabIndex = 2;
            this.lblColon.Text = ":";
            // 
            // txtFinancialCurrencyName
            // 
            this.txtFinancialCurrencyName.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.txtFinancialCurrencyName.Location = new System.Drawing.Point(111, 1);
            this.txtFinancialCurrencyName.Name = "txtFinancialCurrencyName";
            this.txtFinancialCurrencyName.Size = new System.Drawing.Size(199, 20);
            this.txtFinancialCurrencyName.TabIndex = 3;
            // 
            // FinancialCurrencyLivePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtFinancialCurrencyName);
            this.Controls.Add(this.lblColon);
            this.Controls.Add(this.txtFinancialCurrencyCode);
            this.Name = "FinancialCurrencyLivePicker";
            this.Size = new System.Drawing.Size(310, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
