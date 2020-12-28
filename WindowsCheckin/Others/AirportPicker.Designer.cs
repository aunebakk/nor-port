namespace SolutionNorSolutionPort.UserInterface {
    
    
    public partial class AirportPicker {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.TextBox txtAirportCode;
        
        private System.Windows.Forms.Label lblColon;
        
        private System.Windows.Forms.TextBox txtAirportName;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);

        }
        
        private void InitializeComponent() {
            this.txtAirportCode = new System.Windows.Forms.TextBox();
            this.lblColon = new System.Windows.Forms.Label();
            this.txtAirportName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // txtAirportCode
            //
            this.txtAirportCode.Location = new System.Drawing.Point(0, 0);
            this.txtAirportCode.Name = "txtAirportCode";
            this.txtAirportCode.Size = new System.Drawing.Size(100, 20);
            this.txtAirportCode.TabIndex = 1;
            this.txtAirportCode.Validating += new System.ComponentModel.CancelEventHandler(this.txtAirportCode_Validating);
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
            // txtAirportName
            //
            this.txtAirportName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAirportName.Location = new System.Drawing.Point(111, 0);
            this.txtAirportName.Name = "txtAirportName";
            this.txtAirportName.Size = new System.Drawing.Size(199, 20);
            this.txtAirportName.TabIndex = 3;
            // 
            // TestPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtAirportName);
            this.Controls.Add(this.lblColon);
            this.Controls.Add(this.txtAirportCode);
            this.Name = "TestPicker";
            this.Size = new System.Drawing.Size(310, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
