namespace SolutionNorSolutionPort.UserInterface {

    public partial class ServiceSpecialServiceRequestPicker {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.TextBox txtServiceSpecialServiceRequestCode;
        
        private System.Windows.Forms.Label lblColon;
        
        private System.Windows.Forms.TextBox txtServiceSpecialServiceRequestName;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);

        }
        
        private void InitializeComponent() {
            this.txtServiceSpecialServiceRequestCode = new System.Windows.Forms.TextBox();
            this.lblColon = new System.Windows.Forms.Label();
            this.txtServiceSpecialServiceRequestName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // txtServiceSpecialServiceRequestCode
            //
            this.txtServiceSpecialServiceRequestCode.Location = new System.Drawing.Point(0, 0);
            this.txtServiceSpecialServiceRequestCode.Name = "txtServiceSpecialServiceRequestCode";
            this.txtServiceSpecialServiceRequestCode.Size = new System.Drawing.Size(100, 20);
            this.txtServiceSpecialServiceRequestCode.TabIndex = 1;
            this.txtServiceSpecialServiceRequestCode.Validating += new System.ComponentModel.CancelEventHandler(this.txtServiceSpecialServiceRequestCode_Validating);
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
            // txtServiceSpecialServiceRequestName
            //
            this.txtServiceSpecialServiceRequestName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServiceSpecialServiceRequestName.Location = new System.Drawing.Point(111, 0);
            this.txtServiceSpecialServiceRequestName.Name = "txtServiceSpecialServiceRequestName";
            this.txtServiceSpecialServiceRequestName.Size = new System.Drawing.Size(199, 20);
            this.txtServiceSpecialServiceRequestName.TabIndex = 3;
            // 
            // TestPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtServiceSpecialServiceRequestName);
            this.Controls.Add(this.lblColon);
            this.Controls.Add(this.txtServiceSpecialServiceRequestCode);
            this.Name = "TestPicker";
            this.Size = new System.Drawing.Size(310, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
