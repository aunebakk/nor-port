namespace SolutionNorSolutionPort.UserInterface {

    public partial class ServiceCarRentalPicker {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.TextBox txtServiceCarRentalCode;
        
        private System.Windows.Forms.Label lblColon;
        
        private System.Windows.Forms.TextBox txtServiceCarRentalName;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);

        }
        
        private void InitializeComponent() {
            this.txtServiceCarRentalCode = new System.Windows.Forms.TextBox();
            this.lblColon = new System.Windows.Forms.Label();
            this.txtServiceCarRentalName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // txtServiceCarRentalCode
            //
            this.txtServiceCarRentalCode.Location = new System.Drawing.Point(0, 0);
            this.txtServiceCarRentalCode.Name = "txtServiceCarRentalCode";
            this.txtServiceCarRentalCode.Size = new System.Drawing.Size(100, 20);
            this.txtServiceCarRentalCode.TabIndex = 1;
            this.txtServiceCarRentalCode.Validating += new System.ComponentModel.CancelEventHandler(this.txtServiceCarRentalCode_Validating);
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
            // txtServiceCarRentalName
            //
            this.txtServiceCarRentalName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServiceCarRentalName.Location = new System.Drawing.Point(111, 0);
            this.txtServiceCarRentalName.Name = "txtServiceCarRentalName";
            this.txtServiceCarRentalName.Size = new System.Drawing.Size(199, 20);
            this.txtServiceCarRentalName.TabIndex = 3;
            // 
            // TestPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtServiceCarRentalName);
            this.Controls.Add(this.lblColon);
            this.Controls.Add(this.txtServiceCarRentalCode);
            this.Name = "TestPicker";
            this.Size = new System.Drawing.Size(310, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
