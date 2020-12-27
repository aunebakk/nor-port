namespace SolutionNorSolutionPort.UserInterface {

    public partial class FinancialCostcentrePicker {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.TextBox txtFinancialCostcentreCode;
        
        private System.Windows.Forms.Label lblColon;
        
        private System.Windows.Forms.TextBox txtFinancialCostcentreName;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);

        }
        
        private void InitializeComponent() {
            this.txtFinancialCostcentreCode = new System.Windows.Forms.TextBox();
            this.lblColon = new System.Windows.Forms.Label();
            this.txtFinancialCostcentreName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // txtFinancialCostcentreCode
            //
            this.txtFinancialCostcentreCode.Location = new System.Drawing.Point(0, 0);
            this.txtFinancialCostcentreCode.Name = "txtFinancialCostcentreCode";
            this.txtFinancialCostcentreCode.Size = new System.Drawing.Size(100, 20);
            this.txtFinancialCostcentreCode.TabIndex = 1;
            this.txtFinancialCostcentreCode.Validating += new System.ComponentModel.CancelEventHandler(this.txtFinancialCostcentreCode_Validating);
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
            // txtFinancialCostcentreName
            //
            this.txtFinancialCostcentreName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFinancialCostcentreName.Location = new System.Drawing.Point(111, 0);
            this.txtFinancialCostcentreName.Name = "txtFinancialCostcentreName";
            this.txtFinancialCostcentreName.Size = new System.Drawing.Size(199, 20);
            this.txtFinancialCostcentreName.TabIndex = 3;
            // 
            // TestPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtFinancialCostcentreName);
            this.Controls.Add(this.lblColon);
            this.Controls.Add(this.txtFinancialCostcentreCode);
            this.Name = "TestPicker";
            this.Size = new System.Drawing.Size(310, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
