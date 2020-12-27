namespace SolutionNorSolutionPort.UserInterface {

    public partial class FlightEventsSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonFlightEventsSearch;
        
        private FlightEventsDurian durianFlightEvents;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonFlightEventsSearch = new System.Windows.Forms.Button();
            this.durianFlightEvents = new FlightEventsDurian();
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
            // buttonFlightEventsSearch
            // 
            this.buttonFlightEventsSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFlightEventsSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonFlightEventsSearch.Name = "buttonFlightEventsSearch";
            this.buttonFlightEventsSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonFlightEventsSearch.TabIndex = 2;
            this.buttonFlightEventsSearch.Text = "&Search";
            this.buttonFlightEventsSearch.UseVisualStyleBackColor = true;
            this.buttonFlightEventsSearch.Click += new System.EventHandler(this.buttonFlightEventsSearch_Click);
            // 
            // durianFlightEvents
            // 
            this.durianFlightEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianFlightEvents.Location = new System.Drawing.Point(12, 12);
            this.durianFlightEvents.Name = "durianFlightEvents";
            this.durianFlightEvents.Size = new System.Drawing.Size(502, 259);
            this.durianFlightEvents.TabIndex = 1;
            // 
            // InitFlightEventsSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonFlightEventsSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianFlightEvents);
            this.Name = "FlightEventsSearch";
            this.Text = "Flight Events";
            this.ResumeLayout(false);

        }
    }
}
