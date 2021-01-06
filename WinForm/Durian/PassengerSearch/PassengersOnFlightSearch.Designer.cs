namespace SolutionNorSolutionPort.UserInterface {

    public partial class PassengersOnFlightSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonPassengersOnFlightSearch;
        
        private PassengersOnFlightDurian durianPassengersOnFlight;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonPassengersOnFlightSearch = new System.Windows.Forms.Button();
            this.durianPassengersOnFlight = new PassengersOnFlightDurian();
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
            // buttonPassengersOnFlightSearch
            // 
            this.buttonPassengersOnFlightSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPassengersOnFlightSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonPassengersOnFlightSearch.Name = "buttonPassengersOnFlightSearch";
            this.buttonPassengersOnFlightSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonPassengersOnFlightSearch.TabIndex = 2;
            this.buttonPassengersOnFlightSearch.Text = "&Search";
            this.buttonPassengersOnFlightSearch.UseVisualStyleBackColor = true;
            this.buttonPassengersOnFlightSearch.Click += new System.EventHandler(this.buttonPassengersOnFlightSearch_Click);
            // 
            // durianPassengersOnFlight
            // 
            this.durianPassengersOnFlight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianPassengersOnFlight.Location = new System.Drawing.Point(12, 12);
            this.durianPassengersOnFlight.Name = "durianPassengersOnFlight";
            this.durianPassengersOnFlight.Size = new System.Drawing.Size(502, 259);
            this.durianPassengersOnFlight.TabIndex = 1;
            // 
            // InitPassengersOnFlightSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonPassengersOnFlightSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianPassengersOnFlight);
            this.Name = "PassengersOnFlightSearch";
            this.Text = "Passengers On Flight";
            this.ResumeLayout(false);

        }
    }
}
