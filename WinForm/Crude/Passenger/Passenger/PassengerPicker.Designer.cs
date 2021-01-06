namespace SolutionNorSolutionPort.UserInterface {

    public partial class PassengerPicker {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.TextBox txtPassengerCode;
        
        private System.Windows.Forms.Label lblColon;
        
        private System.Windows.Forms.TextBox txtPassengerName;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);

        }
        
        private void InitializeComponent() {
            this.txtPassengerCode = new System.Windows.Forms.TextBox();
            this.lblColon = new System.Windows.Forms.Label();
            this.txtPassengerName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // txtPassengerCode
            //
            this.txtPassengerCode.Location = new System.Drawing.Point(0, 0);
            this.txtPassengerCode.Name = "txtPassengerCode";
            this.txtPassengerCode.Size = new System.Drawing.Size(100, 20);
            this.txtPassengerCode.TabIndex = 1;
            this.txtPassengerCode.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassengerCode_Validating);
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
            // txtPassengerName
            //
            this.txtPassengerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassengerName.Location = new System.Drawing.Point(111, 0);
            this.txtPassengerName.Name = "txtPassengerName";
            this.txtPassengerName.Size = new System.Drawing.Size(199, 20);
            this.txtPassengerName.TabIndex = 3;
            // 
            // TestPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtPassengerName);
            this.Controls.Add(this.lblColon);
            this.Controls.Add(this.txtPassengerCode);
            this.Name = "TestPicker";
            this.Size = new System.Drawing.Size(310, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
