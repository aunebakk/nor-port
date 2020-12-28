namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeAirportRunwaySearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeAirportRunwaySearch;
        
        private System.Windows.Forms.Button buttonCrudeAirportRunwayAdd;
        
        private System.Windows.Forms.Button buttonCrudeAirportRunwayEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeAirportRunway;
        
        private System.Windows.Forms.TextBox textBoxDirection;
        
        private System.Windows.Forms.Label labelDirection;
        
        private System.Windows.Forms.TextBox textBoxDimensions;
        
        private System.Windows.Forms.Label labelDimensions;
        
        private System.Windows.Forms.TextBox textBoxSurface;
        
        private System.Windows.Forms.Label labelSurface;
        
        private System.Windows.Forms.TextBox textBoxInstrumentLandingSystemType;
        
        private System.Windows.Forms.Label labelInstrumentLandingSystemType;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        private AirportPicker airportPicker;
        
        private System.Windows.Forms.Label labelAirportPicker;
        
        private DefaultUserPicker userPicker;
        
        private System.Windows.Forms.Label labelUserPicker;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonCrudeAirportRunwayAdd = new System.Windows.Forms.Button();
            this.buttonCrudeAirportRunwayEdit = new System.Windows.Forms.Button();
            this.buttonCrudeAirportRunwaySearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeAirportRunway = new System.Windows.Forms.DataGridView();
            this.labelDirection = new System.Windows.Forms.Label();
            this.textBoxDirection = new System.Windows.Forms.TextBox();
            this.labelDimensions = new System.Windows.Forms.Label();
            this.textBoxDimensions = new System.Windows.Forms.TextBox();
            this.labelSurface = new System.Windows.Forms.Label();
            this.textBoxSurface = new System.Windows.Forms.TextBox();
            this.labelInstrumentLandingSystemType = new System.Windows.Forms.Label();
            this.textBoxInstrumentLandingSystemType = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelAirportPicker = new System.Windows.Forms.Label();
            this.airportPicker = new AirportPicker();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAirportRunway)).BeginInit();
            this.SuspendLayout();
            //
            // labelDirection
            //
            this.labelDirection.AutoSize = true;
            this.labelDirection.Location = new System.Drawing.Point(11, 13);
            this.labelDirection.Name = "labelDirection";
            this.labelDirection.Size = new System.Drawing.Size(71, 13);
            this.labelDirection.TabIndex = 2;
            this.labelDirection.Text = "Direction:";
            //
            //textBoxDirection
            //
            this.textBoxDirection.Location = new System.Drawing.Point(210, 13);
            this.textBoxDirection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDirection.Name = "textBoxDirection";
            this.textBoxDirection.Size = new System.Drawing.Size(250, 20);
            this.textBoxDirection.TabIndex = 3;
            //
            // labelDimensions
            //
            this.labelDimensions.AutoSize = true;
            this.labelDimensions.Location = new System.Drawing.Point(11, 36);
            this.labelDimensions.Name = "labelDimensions";
            this.labelDimensions.Size = new System.Drawing.Size(71, 13);
            this.labelDimensions.TabIndex = 4;
            this.labelDimensions.Text = "Dimensions:";
            //
            //textBoxDimensions
            //
            this.textBoxDimensions.Location = new System.Drawing.Point(210, 36);
            this.textBoxDimensions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDimensions.Name = "textBoxDimensions";
            this.textBoxDimensions.Size = new System.Drawing.Size(250, 20);
            this.textBoxDimensions.TabIndex = 5;
            //
            // labelSurface
            //
            this.labelSurface.AutoSize = true;
            this.labelSurface.Location = new System.Drawing.Point(11, 59);
            this.labelSurface.Name = "labelSurface";
            this.labelSurface.Size = new System.Drawing.Size(71, 13);
            this.labelSurface.TabIndex = 6;
            this.labelSurface.Text = "Surface:";
            //
            //textBoxSurface
            //
            this.textBoxSurface.Location = new System.Drawing.Point(210, 59);
            this.textBoxSurface.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSurface.Name = "textBoxSurface";
            this.textBoxSurface.Size = new System.Drawing.Size(250, 20);
            this.textBoxSurface.TabIndex = 7;
            //
            // labelInstrumentLandingSystemType
            //
            this.labelInstrumentLandingSystemType.AutoSize = true;
            this.labelInstrumentLandingSystemType.Location = new System.Drawing.Point(11, 82);
            this.labelInstrumentLandingSystemType.Name = "labelInstrumentLandingSystemType";
            this.labelInstrumentLandingSystemType.Size = new System.Drawing.Size(71, 13);
            this.labelInstrumentLandingSystemType.TabIndex = 8;
            this.labelInstrumentLandingSystemType.Text = "Instrument Landing System Type:";
            //
            //textBoxInstrumentLandingSystemType
            //
            this.textBoxInstrumentLandingSystemType.Location = new System.Drawing.Point(210, 82);
            this.textBoxInstrumentLandingSystemType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInstrumentLandingSystemType.Name = "textBoxInstrumentLandingSystemType";
            this.textBoxInstrumentLandingSystemType.Size = new System.Drawing.Size(250, 20);
            this.textBoxInstrumentLandingSystemType.TabIndex = 9;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 105);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 10;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(210, 105);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 11;
            //
            // labelAirportPicker
            //
            this.labelAirportPicker.AutoSize = true;
            this.labelAirportPicker.Location = new System.Drawing.Point(11, 128);
            this.labelAirportPicker.Name = "labelAirportPicker";
            this.labelAirportPicker.Size = new System.Drawing.Size(71, 13);
            this.labelAirportPicker.TabIndex = 12;
            this.labelAirportPicker.Text = "Airport:";
            //
            //airportPicker
            //
            this.airportPicker.Location = new System.Drawing.Point(210, 128);
            this.airportPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.airportPicker.Name = "airportPicker";
            this.airportPicker.Size = new System.Drawing.Size(250, 20);
            this.airportPicker.TabIndex = 13;
            //
            // labelUserPicker
            //
            this.labelUserPicker.AutoSize = true;
            this.labelUserPicker.Location = new System.Drawing.Point(11, 151);
            this.labelUserPicker.Name = "labelUserPicker";
            this.labelUserPicker.Size = new System.Drawing.Size(71, 13);
            this.labelUserPicker.TabIndex = 14;
            this.labelUserPicker.Text = "User:";
            //
            //userPicker
            //
            this.userPicker.Location = new System.Drawing.Point(210, 151);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 15;
            // 
            // dataGridViewCrudeAirportRunway
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeAirportRunway.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeAirportRunway.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeAirportRunway.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeAirportRunway.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeAirportRunway.Location = new System.Drawing.Point(12, 184);
            this.dataGridViewCrudeAirportRunway.Name = "dataGridViewCrudeAirportRunway";
            this.dataGridViewCrudeAirportRunway.Size = new System.Drawing.Size(448, 96);
            this.dataGridViewCrudeAirportRunway.TabIndex = 0;
            this.dataGridViewCrudeAirportRunway.ReadOnly = true;
            this.dataGridViewCrudeAirportRunway.DoubleClick += new System.EventHandler(this.dataGridViewCrudeAirportRunway_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(368, 287);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeAirportRunwaySearch
            // 
            this.buttonCrudeAirportRunwaySearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirportRunwaySearch.Location = new System.Drawing.Point(268, 287);
            this.buttonCrudeAirportRunwaySearch.Name = "buttonCrudeAirportRunwaySearch";
            this.buttonCrudeAirportRunwaySearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirportRunwaySearch.TabIndex = 2;
            this.buttonCrudeAirportRunwaySearch.Text = "&Search";
            this.buttonCrudeAirportRunwaySearch.UseVisualStyleBackColor = true;
            this.buttonCrudeAirportRunwaySearch.Click += new System.EventHandler(this.buttonCrudeAirportRunwaySearch_Click);
            // 
            // buttonCrudeAirportRunwayAdd
            // 
            this.buttonCrudeAirportRunwayAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirportRunwayAdd.Location = new System.Drawing.Point(168, 287);
            this.buttonCrudeAirportRunwayAdd.Name = "buttonCrudeAirportRunwayAdd";
            this.buttonCrudeAirportRunwayAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirportRunwayAdd.TabIndex = 3;
            this.buttonCrudeAirportRunwayAdd.Text = "&Add";
            this.buttonCrudeAirportRunwayAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeAirportRunwayAdd.Click += new System.EventHandler(this.buttonCrudeAirportRunwayAdd_Click);
            // 
            // buttonCrudeAirportRunwayEdit
            // 
            this.buttonCrudeAirportRunwayEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirportRunwayEdit.Location = new System.Drawing.Point(68, 287);
            this.buttonCrudeAirportRunwayEdit.Name = "buttonCrudeAirportRunwayEdit";
            this.buttonCrudeAirportRunwayEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirportRunwayEdit.TabIndex = 4;
            this.buttonCrudeAirportRunwayEdit.Text = "&Edit";
            this.buttonCrudeAirportRunwayEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeAirportRunwayEdit.Click += new System.EventHandler(this.buttonCrudeAirportRunwayEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 315);
            this.Controls.Add(this.buttonCrudeAirportRunwaySearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeAirportRunwayAdd);
            this.Controls.Add(this.buttonCrudeAirportRunwayEdit);
            this.Controls.Add(this.dataGridViewCrudeAirportRunway);
            this.Name = "CrudeAirportRunwaySearch";
            this.Text = "Airport Runway Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAirportRunway)).EndInit();
            this.Controls.Add(this.labelDirection);
            this.Controls.Add(this.textBoxDirection);
            this.Controls.Add(this.labelDimensions);
            this.Controls.Add(this.textBoxDimensions);
            this.Controls.Add(this.labelSurface);
            this.Controls.Add(this.textBoxSurface);
            this.Controls.Add(this.labelInstrumentLandingSystemType);
            this.Controls.Add(this.textBoxInstrumentLandingSystemType);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelAirportPicker);
            this.Controls.Add(this.airportPicker);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
