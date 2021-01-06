namespace SolutionNorSolutionPort.UserInterface {

    public partial class FlightsWithCheckinInformationSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonFlightsWithCheckinInformationSearch;
        
        private FlightsWithCheckinInformationDurian durianFlightsWithCheckinInformation;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonFlightsWithCheckinInformationSearch = new System.Windows.Forms.Button();
            this.durianFlightsWithCheckinInformation = new FlightsWithCheckinInformationDurian();
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
            // buttonFlightsWithCheckinInformationSearch
            // 
            this.buttonFlightsWithCheckinInformationSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFlightsWithCheckinInformationSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonFlightsWithCheckinInformationSearch.Name = "buttonFlightsWithCheckinInformationSearch";
            this.buttonFlightsWithCheckinInformationSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonFlightsWithCheckinInformationSearch.TabIndex = 2;
            this.buttonFlightsWithCheckinInformationSearch.Text = "&Search";
            this.buttonFlightsWithCheckinInformationSearch.UseVisualStyleBackColor = true;
            this.buttonFlightsWithCheckinInformationSearch.Click += new System.EventHandler(this.buttonFlightsWithCheckinInformationSearch_Click);
            // 
            // durianFlightsWithCheckinInformation
            // 
            this.durianFlightsWithCheckinInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianFlightsWithCheckinInformation.Location = new System.Drawing.Point(12, 12);
            this.durianFlightsWithCheckinInformation.Name = "durianFlightsWithCheckinInformation";
            this.durianFlightsWithCheckinInformation.Size = new System.Drawing.Size(502, 259);
            this.durianFlightsWithCheckinInformation.TabIndex = 1;
            // 
            // InitFlightsWithCheckinInformationSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonFlightsWithCheckinInformationSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianFlightsWithCheckinInformation);
            this.Name = "FlightsWithCheckinInformationSearch";
            this.Text = "Flights With Checkin Information";
            this.ResumeLayout(false);

        }
    }
}
