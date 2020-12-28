namespace SolutionNorSolutionPort.UserInterface {

    public partial class ServicePackagePicker {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.TextBox txtServicePackageCode;
        
        private System.Windows.Forms.Label lblColon;
        
        private System.Windows.Forms.TextBox txtServicePackageName;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);

        }
        
        private void InitializeComponent() {
            this.txtServicePackageCode = new System.Windows.Forms.TextBox();
            this.lblColon = new System.Windows.Forms.Label();
            this.txtServicePackageName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // txtServicePackageCode
            //
            this.txtServicePackageCode.Location = new System.Drawing.Point(0, 0);
            this.txtServicePackageCode.Name = "txtServicePackageCode";
            this.txtServicePackageCode.Size = new System.Drawing.Size(100, 20);
            this.txtServicePackageCode.TabIndex = 1;
            this.txtServicePackageCode.Validating += new System.ComponentModel.CancelEventHandler(this.txtServicePackageCode_Validating);
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
            // txtServicePackageName
            //
            this.txtServicePackageName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServicePackageName.Location = new System.Drawing.Point(111, 0);
            this.txtServicePackageName.Name = "txtServicePackageName";
            this.txtServicePackageName.Size = new System.Drawing.Size(199, 20);
            this.txtServicePackageName.TabIndex = 3;
            // 
            // TestPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtServicePackageName);
            this.Controls.Add(this.lblColon);
            this.Controls.Add(this.txtServicePackageCode);
            this.Name = "TestPicker";
            this.Size = new System.Drawing.Size(310, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
