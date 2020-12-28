namespace SolutionNorSolutionPort.UserInterface {

    public partial class PassengersOnFlightCheckedInSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonPassengersOnFlightCheckedInSearch;
        
        private PassengersOnFlightCheckedInDurian durianPassengersOnFlightCheckedIn;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonPassengersOnFlightCheckedInSearch = new System.Windows.Forms.Button();
            this.durianPassengersOnFlightCheckedIn = new PassengersOnFlightCheckedInDurian();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(422, 277);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonPassengersOnFlightCheckedInSearch
            // 
            this.buttonPassengersOnFlightCheckedInSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPassengersOnFlightCheckedInSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonPassengersOnFlightCheckedInSearch.Name = "buttonPassengersOnFlightCheckedInSearch";
            this.buttonPassengersOnFlightCheckedInSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonPassengersOnFlightCheckedInSearch.TabIndex = 2;
            this.buttonPassengersOnFlightCheckedInSearch.Text = "&Search";
            this.buttonPassengersOnFlightCheckedInSearch.UseVisualStyleBackColor = true;
            this.buttonPassengersOnFlightCheckedInSearch.Click += new System.EventHandler(this.buttonPassengersOnFlightCheckedInSearch_Click);
            // 
            // durianPassengersOnFlightCheckedIn
            // 
            this.durianPassengersOnFlightCheckedIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianPassengersOnFlightCheckedIn.Location = new System.Drawing.Point(12, 12);
            this.durianPassengersOnFlightCheckedIn.Name = "durianPassengersOnFlightCheckedIn";
            this.durianPassengersOnFlightCheckedIn.Size = new System.Drawing.Size(502, 259);
            this.durianPassengersOnFlightCheckedIn.TabIndex = 1;
            // 
            // InitPassengersOnFlightCheckedInSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonPassengersOnFlightCheckedInSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianPassengersOnFlightCheckedIn);
            this.Name = "PassengersOnFlightCheckedInSearch";
            this.Text = "Passengers On Flight Checked In";
            this.ResumeLayout(false);

        }
    }
}
