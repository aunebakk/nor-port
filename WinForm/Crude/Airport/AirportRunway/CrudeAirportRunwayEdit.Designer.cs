namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeAirportRunwayEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private AirportPicker airportPicker;
        
        private System.Windows.Forms.Label labelAirportPicker;
        
        private System.Windows.Forms.TextBox textBoxDirection;
        
        private System.Windows.Forms.Label labelDirection;
        
        private System.Windows.Forms.TextBox textBoxDimensions;
        
        private System.Windows.Forms.Label labelDimensions;
        
        private System.Windows.Forms.TextBox textBoxSurface;
        
        private System.Windows.Forms.Label labelSurface;
        
        private System.Windows.Forms.TextBox textBoxInstrumentLandingSystemType;
        
        private System.Windows.Forms.Label labelInstrumentLandingSystemType;
        
        private DefaultUserPicker userPicker;
        
        private System.Windows.Forms.Label labelUserPicker;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelAirportPicker = new System.Windows.Forms.Label();
            this.airportPicker = new AirportPicker();
            this.labelDirection = new System.Windows.Forms.Label();
            this.textBoxDirection = new System.Windows.Forms.TextBox();
            this.labelDimensions = new System.Windows.Forms.Label();
            this.textBoxDimensions = new System.Windows.Forms.TextBox();
            this.labelSurface = new System.Windows.Forms.Label();
            this.textBoxSurface = new System.Windows.Forms.TextBox();
            this.labelInstrumentLandingSystemType = new System.Windows.Forms.Label();
            this.textBoxInstrumentLandingSystemType = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelAirportPicker
            //
            this.labelAirportPicker.AutoSize = true;
            this.labelAirportPicker.Location = new System.Drawing.Point(11, 13);
            this.labelAirportPicker.Name = "labelAirportPicker";
            this.labelAirportPicker.Size = new System.Drawing.Size(71, 13);
            this.labelAirportPicker.TabIndex = 2;
            this.labelAirportPicker.Text = "Airport:";
            //
            //airportPicker
            //
            this.airportPicker.Location = new System.Drawing.Point(210, 13);
            this.airportPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.airportPicker.Name = "airportPicker";
            this.airportPicker.Size = new System.Drawing.Size(250, 20);
            this.airportPicker.TabIndex = 3;
            //
            // labelDirection
            //
            this.labelDirection.AutoSize = true;
            this.labelDirection.Location = new System.Drawing.Point(11, 36);
            this.labelDirection.Name = "labelDirection";
            this.labelDirection.Size = new System.Drawing.Size(71, 13);
            this.labelDirection.TabIndex = 4;
            this.labelDirection.Text = "Direction:";
            //
            //textBoxDirection
            //
            this.textBoxDirection.Location = new System.Drawing.Point(210, 36);
            this.textBoxDirection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDirection.Name = "textBoxDirection";
            this.textBoxDirection.Size = new System.Drawing.Size(250, 20);
            this.textBoxDirection.TabIndex = 5;
            //
            // labelDimensions
            //
            this.labelDimensions.AutoSize = true;
            this.labelDimensions.Location = new System.Drawing.Point(11, 59);
            this.labelDimensions.Name = "labelDimensions";
            this.labelDimensions.Size = new System.Drawing.Size(71, 13);
            this.labelDimensions.TabIndex = 6;
            this.labelDimensions.Text = "Dimensions:";
            //
            //textBoxDimensions
            //
            this.textBoxDimensions.Location = new System.Drawing.Point(210, 59);
            this.textBoxDimensions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDimensions.Name = "textBoxDimensions";
            this.textBoxDimensions.Size = new System.Drawing.Size(250, 20);
            this.textBoxDimensions.TabIndex = 7;
            //
            // labelSurface
            //
            this.labelSurface.AutoSize = true;
            this.labelSurface.Location = new System.Drawing.Point(11, 82);
            this.labelSurface.Name = "labelSurface";
            this.labelSurface.Size = new System.Drawing.Size(71, 13);
            this.labelSurface.TabIndex = 8;
            this.labelSurface.Text = "Surface:";
            //
            //textBoxSurface
            //
            this.textBoxSurface.Location = new System.Drawing.Point(210, 82);
            this.textBoxSurface.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSurface.Name = "textBoxSurface";
            this.textBoxSurface.Size = new System.Drawing.Size(250, 20);
            this.textBoxSurface.TabIndex = 9;
            //
            // labelInstrumentLandingSystemType
            //
            this.labelInstrumentLandingSystemType.AutoSize = true;
            this.labelInstrumentLandingSystemType.Location = new System.Drawing.Point(11, 105);
            this.labelInstrumentLandingSystemType.Name = "labelInstrumentLandingSystemType";
            this.labelInstrumentLandingSystemType.Size = new System.Drawing.Size(71, 13);
            this.labelInstrumentLandingSystemType.TabIndex = 10;
            this.labelInstrumentLandingSystemType.Text = "Instrument Landing System Type:";
            //
            //textBoxInstrumentLandingSystemType
            //
            this.textBoxInstrumentLandingSystemType.Location = new System.Drawing.Point(210, 105);
            this.textBoxInstrumentLandingSystemType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInstrumentLandingSystemType.Name = "textBoxInstrumentLandingSystemType";
            this.textBoxInstrumentLandingSystemType.Size = new System.Drawing.Size(250, 20);
            this.textBoxInstrumentLandingSystemType.TabIndex = 11;
            //
            // labelUserPicker
            //
            this.labelUserPicker.AutoSize = true;
            this.labelUserPicker.Location = new System.Drawing.Point(11, 128);
            this.labelUserPicker.Name = "labelUserPicker";
            this.labelUserPicker.Size = new System.Drawing.Size(71, 13);
            this.labelUserPicker.TabIndex = 12;
            this.labelUserPicker.Text = "User:";
            //
            //userPicker
            //
            this.userPicker.Location = new System.Drawing.Point(210, 128);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 13;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 151);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 14;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(210, 151);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 15;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(368, 174);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(268, 174);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(92, 22);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "&Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // EditForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 202);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeAirportRunwayEdit";
            this.Text = "Airport Runway Edit";
            this.Controls.Add(this.labelAirportPicker);
            this.Controls.Add(this.airportPicker);
            this.Controls.Add(this.labelDirection);
            this.Controls.Add(this.textBoxDirection);
            this.Controls.Add(this.labelDimensions);
            this.Controls.Add(this.textBoxDimensions);
            this.Controls.Add(this.labelSurface);
            this.Controls.Add(this.textBoxSurface);
            this.Controls.Add(this.labelInstrumentLandingSystemType);
            this.Controls.Add(this.textBoxInstrumentLandingSystemType);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
