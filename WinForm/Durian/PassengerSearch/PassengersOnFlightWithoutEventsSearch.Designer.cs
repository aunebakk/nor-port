namespace SolutionNorSolutionPort.UserInterface {

    public partial class PassengersOnFlightWithoutEventsSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonPassengersOnFlightWithoutEventsSearch;
        
        private PassengersOnFlightWithoutEventsDurian durianPassengersOnFlightWithoutEvents;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonPassengersOnFlightWithoutEventsSearch = new System.Windows.Forms.Button();
            this.durianPassengersOnFlightWithoutEvents = new PassengersOnFlightWithoutEventsDurian();
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
            // buttonPassengersOnFlightWithoutEventsSearch
            // 
            this.buttonPassengersOnFlightWithoutEventsSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPassengersOnFlightWithoutEventsSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonPassengersOnFlightWithoutEventsSearch.Name = "buttonPassengersOnFlightWithoutEventsSearch";
            this.buttonPassengersOnFlightWithoutEventsSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonPassengersOnFlightWithoutEventsSearch.TabIndex = 2;
            this.buttonPassengersOnFlightWithoutEventsSearch.Text = "&Search";
            this.buttonPassengersOnFlightWithoutEventsSearch.UseVisualStyleBackColor = true;
            this.buttonPassengersOnFlightWithoutEventsSearch.Click += new System.EventHandler(this.buttonPassengersOnFlightWithoutEventsSearch_Click);
            // 
            // durianPassengersOnFlightWithoutEvents
            // 
            this.durianPassengersOnFlightWithoutEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianPassengersOnFlightWithoutEvents.Location = new System.Drawing.Point(12, 12);
            this.durianPassengersOnFlightWithoutEvents.Name = "durianPassengersOnFlightWithoutEvents";
            this.durianPassengersOnFlightWithoutEvents.Size = new System.Drawing.Size(502, 259);
            this.durianPassengersOnFlightWithoutEvents.TabIndex = 1;
            // 
            // InitPassengersOnFlightWithoutEventsSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonPassengersOnFlightWithoutEventsSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianPassengersOnFlightWithoutEvents);
            this.Name = "PassengersOnFlightWithoutEventsSearch";
            this.Text = "Passengers On Flight Without Events";
            this.ResumeLayout(false);

        }
    }
}
