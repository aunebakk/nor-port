namespace SolutionNorSolutionPort.UserInterface {

    public partial class AirlinePicker {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.TextBox txtAirlineCode;
        
        private System.Windows.Forms.Label lblColon;
        
        private System.Windows.Forms.TextBox txtAirlineName;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);

        }
        
        private void InitializeComponent() {
            this.txtAirlineCode = new System.Windows.Forms.TextBox();
            this.lblColon = new System.Windows.Forms.Label();
            this.txtAirlineName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // txtAirlineCode
            //
            this.txtAirlineCode.Location = new System.Drawing.Point(0, 0);
            this.txtAirlineCode.Name = "txtAirlineCode";
            this.txtAirlineCode.Size = new System.Drawing.Size(100, 20);
            this.txtAirlineCode.TabIndex = 1;
            this.txtAirlineCode.Validating += new System.ComponentModel.CancelEventHandler(this.txtAirlineCode_Validating);
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
            // txtAirlineName
            //
            this.txtAirlineName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAirlineName.Location = new System.Drawing.Point(111, 0);
            this.txtAirlineName.Name = "txtAirlineName";
            this.txtAirlineName.Size = new System.Drawing.Size(199, 20);
            this.txtAirlineName.TabIndex = 3;
            // 
            // TestPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtAirlineName);
            this.Controls.Add(this.lblColon);
            this.Controls.Add(this.txtAirlineCode);
            this.Name = "TestPicker";
            this.Size = new System.Drawing.Size(310, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
