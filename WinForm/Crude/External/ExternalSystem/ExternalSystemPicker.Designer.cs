namespace SolutionNorSolutionPort.UserInterface {

    public partial class ExternalSystemPicker {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.TextBox txtExternalSystemCode;
        
        private System.Windows.Forms.Label lblColon;
        
        private System.Windows.Forms.TextBox txtExternalSystemName;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);

        }
        
        private void InitializeComponent() {
            this.txtExternalSystemCode = new System.Windows.Forms.TextBox();
            this.lblColon = new System.Windows.Forms.Label();
            this.txtExternalSystemName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // txtExternalSystemCode
            //
            this.txtExternalSystemCode.Location = new System.Drawing.Point(0, 0);
            this.txtExternalSystemCode.Name = "txtExternalSystemCode";
            this.txtExternalSystemCode.Size = new System.Drawing.Size(100, 20);
            this.txtExternalSystemCode.TabIndex = 1;
            this.txtExternalSystemCode.Validating += new System.ComponentModel.CancelEventHandler(this.txtExternalSystemCode_Validating);
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
            // txtExternalSystemName
            //
            this.txtExternalSystemName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExternalSystemName.Location = new System.Drawing.Point(111, 0);
            this.txtExternalSystemName.Name = "txtExternalSystemName";
            this.txtExternalSystemName.Size = new System.Drawing.Size(199, 20);
            this.txtExternalSystemName.TabIndex = 3;
            // 
            // TestPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtExternalSystemName);
            this.Controls.Add(this.lblColon);
            this.Controls.Add(this.txtExternalSystemCode);
            this.Name = "TestPicker";
            this.Size = new System.Drawing.Size(310, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
