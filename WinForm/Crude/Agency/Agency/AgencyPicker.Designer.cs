namespace SolutionNorSolutionPort.UserInterface {

    public partial class AgencyPicker {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.TextBox txtAgencyCode;
        
        private System.Windows.Forms.Label lblColon;
        
        private System.Windows.Forms.TextBox txtAgencyName;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);

        }
        
        private void InitializeComponent() {
            this.txtAgencyCode = new System.Windows.Forms.TextBox();
            this.lblColon = new System.Windows.Forms.Label();
            this.txtAgencyName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // txtAgencyCode
            //
            this.txtAgencyCode.Location = new System.Drawing.Point(0, 0);
            this.txtAgencyCode.Name = "txtAgencyCode";
            this.txtAgencyCode.Size = new System.Drawing.Size(100, 20);
            this.txtAgencyCode.TabIndex = 1;
            this.txtAgencyCode.Validating += new System.ComponentModel.CancelEventHandler(this.txtAgencyCode_Validating);
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
            // txtAgencyName
            //
            this.txtAgencyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAgencyName.Location = new System.Drawing.Point(111, 0);
            this.txtAgencyName.Name = "txtAgencyName";
            this.txtAgencyName.Size = new System.Drawing.Size(199, 20);
            this.txtAgencyName.TabIndex = 3;
            // 
            // TestPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtAgencyName);
            this.Controls.Add(this.lblColon);
            this.Controls.Add(this.txtAgencyCode);
            this.Name = "TestPicker";
            this.Size = new System.Drawing.Size(310, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
