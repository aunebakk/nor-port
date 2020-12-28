namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeAircraftCompartmentMeasurementEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxLength;
        
        private System.Windows.Forms.Label labelLength;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxHeight;
        
        private System.Windows.Forms.Label labelHeight;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxWidth;
        
        private System.Windows.Forms.Label labelWidth;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPayloadInKilo;
        
        private System.Windows.Forms.Label labelPayloadInKilo;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxUnitLoadDevicePositions;
        
        private System.Windows.Forms.Label labelUnitLoadDevicePositions;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCarryOnBinCount;
        
        private System.Windows.Forms.Label labelCarryOnBinCount;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCarryOnPiecesAllowedCount;
        
        private System.Windows.Forms.Label labelCarryOnPiecesAllowedCount;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCarryOnPieceMaxWeightInKilo;
        
        private System.Windows.Forms.Label labelCarryOnPieceMaxWeightInKilo;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxInfantLimit;
        
        private System.Windows.Forms.Label labelInfantLimit;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxBookableLimit;
        
        private System.Windows.Forms.Label labelBookableLimit;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPassengerLimit;
        
        private System.Windows.Forms.Label labelPassengerLimit;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRowCount;
        
        private System.Windows.Forms.Label labelRowCount;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxColumnCount;
        
        private System.Windows.Forms.Label labelColumnCount;
        
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
            this.labelLength = new System.Windows.Forms.Label();
            this.maskedTextBoxLength = new System.Windows.Forms.MaskedTextBox();
            this.labelHeight = new System.Windows.Forms.Label();
            this.maskedTextBoxHeight = new System.Windows.Forms.MaskedTextBox();
            this.labelWidth = new System.Windows.Forms.Label();
            this.maskedTextBoxWidth = new System.Windows.Forms.MaskedTextBox();
            this.labelPayloadInKilo = new System.Windows.Forms.Label();
            this.maskedTextBoxPayloadInKilo = new System.Windows.Forms.MaskedTextBox();
            this.labelUnitLoadDevicePositions = new System.Windows.Forms.Label();
            this.maskedTextBoxUnitLoadDevicePositions = new System.Windows.Forms.MaskedTextBox();
            this.labelCarryOnBinCount = new System.Windows.Forms.Label();
            this.maskedTextBoxCarryOnBinCount = new System.Windows.Forms.MaskedTextBox();
            this.labelCarryOnPiecesAllowedCount = new System.Windows.Forms.Label();
            this.maskedTextBoxCarryOnPiecesAllowedCount = new System.Windows.Forms.MaskedTextBox();
            this.labelCarryOnPieceMaxWeightInKilo = new System.Windows.Forms.Label();
            this.maskedTextBoxCarryOnPieceMaxWeightInKilo = new System.Windows.Forms.MaskedTextBox();
            this.labelInfantLimit = new System.Windows.Forms.Label();
            this.maskedTextBoxInfantLimit = new System.Windows.Forms.MaskedTextBox();
            this.labelBookableLimit = new System.Windows.Forms.Label();
            this.maskedTextBoxBookableLimit = new System.Windows.Forms.MaskedTextBox();
            this.labelPassengerLimit = new System.Windows.Forms.Label();
            this.maskedTextBoxPassengerLimit = new System.Windows.Forms.MaskedTextBox();
            this.labelRowCount = new System.Windows.Forms.Label();
            this.maskedTextBoxRowCount = new System.Windows.Forms.MaskedTextBox();
            this.labelColumnCount = new System.Windows.Forms.Label();
            this.maskedTextBoxColumnCount = new System.Windows.Forms.MaskedTextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelLength
            //
            this.labelLength.AutoSize = true;
            this.labelLength.Location = new System.Drawing.Point(11, 13);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(71, 13);
            this.labelLength.TabIndex = 2;
            this.labelLength.Text = "Length:";
            //
            //maskedTextBoxLength
            //
            this.maskedTextBoxLength.Location = new System.Drawing.Point(231, 13);
            this.maskedTextBoxLength.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxLength.Name = "maskedTextBoxLength";
            this.maskedTextBoxLength.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxLength.TabIndex = 3;
            //
            // labelHeight
            //
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(11, 36);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(71, 13);
            this.labelHeight.TabIndex = 4;
            this.labelHeight.Text = "Height:";
            //
            //maskedTextBoxHeight
            //
            this.maskedTextBoxHeight.Location = new System.Drawing.Point(231, 36);
            this.maskedTextBoxHeight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxHeight.Name = "maskedTextBoxHeight";
            this.maskedTextBoxHeight.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxHeight.TabIndex = 5;
            //
            // labelWidth
            //
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(11, 59);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(71, 13);
            this.labelWidth.TabIndex = 6;
            this.labelWidth.Text = "Width:";
            //
            //maskedTextBoxWidth
            //
            this.maskedTextBoxWidth.Location = new System.Drawing.Point(231, 59);
            this.maskedTextBoxWidth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxWidth.Name = "maskedTextBoxWidth";
            this.maskedTextBoxWidth.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxWidth.TabIndex = 7;
            //
            // labelPayloadInKilo
            //
            this.labelPayloadInKilo.AutoSize = true;
            this.labelPayloadInKilo.Location = new System.Drawing.Point(11, 82);
            this.labelPayloadInKilo.Name = "labelPayloadInKilo";
            this.labelPayloadInKilo.Size = new System.Drawing.Size(71, 13);
            this.labelPayloadInKilo.TabIndex = 8;
            this.labelPayloadInKilo.Text = "Payload In Kilo:";
            //
            //maskedTextBoxPayloadInKilo
            //
            this.maskedTextBoxPayloadInKilo.Location = new System.Drawing.Point(231, 82);
            this.maskedTextBoxPayloadInKilo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxPayloadInKilo.Name = "maskedTextBoxPayloadInKilo";
            this.maskedTextBoxPayloadInKilo.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxPayloadInKilo.TabIndex = 9;
            //
            // labelUnitLoadDevicePositions
            //
            this.labelUnitLoadDevicePositions.AutoSize = true;
            this.labelUnitLoadDevicePositions.Location = new System.Drawing.Point(11, 105);
            this.labelUnitLoadDevicePositions.Name = "labelUnitLoadDevicePositions";
            this.labelUnitLoadDevicePositions.Size = new System.Drawing.Size(71, 13);
            this.labelUnitLoadDevicePositions.TabIndex = 10;
            this.labelUnitLoadDevicePositions.Text = "Unit Load Device Positions:";
            //
            //maskedTextBoxUnitLoadDevicePositions
            //
            this.maskedTextBoxUnitLoadDevicePositions.Location = new System.Drawing.Point(231, 105);
            this.maskedTextBoxUnitLoadDevicePositions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxUnitLoadDevicePositions.Name = "maskedTextBoxUnitLoadDevicePositions";
            this.maskedTextBoxUnitLoadDevicePositions.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxUnitLoadDevicePositions.TabIndex = 11;
            //
            // labelCarryOnBinCount
            //
            this.labelCarryOnBinCount.AutoSize = true;
            this.labelCarryOnBinCount.Location = new System.Drawing.Point(11, 128);
            this.labelCarryOnBinCount.Name = "labelCarryOnBinCount";
            this.labelCarryOnBinCount.Size = new System.Drawing.Size(71, 13);
            this.labelCarryOnBinCount.TabIndex = 12;
            this.labelCarryOnBinCount.Text = "Carry On Bin Count:";
            //
            //maskedTextBoxCarryOnBinCount
            //
            this.maskedTextBoxCarryOnBinCount.Location = new System.Drawing.Point(231, 128);
            this.maskedTextBoxCarryOnBinCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxCarryOnBinCount.Name = "maskedTextBoxCarryOnBinCount";
            this.maskedTextBoxCarryOnBinCount.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxCarryOnBinCount.TabIndex = 13;
            //
            // labelCarryOnPiecesAllowedCount
            //
            this.labelCarryOnPiecesAllowedCount.AutoSize = true;
            this.labelCarryOnPiecesAllowedCount.Location = new System.Drawing.Point(11, 151);
            this.labelCarryOnPiecesAllowedCount.Name = "labelCarryOnPiecesAllowedCount";
            this.labelCarryOnPiecesAllowedCount.Size = new System.Drawing.Size(71, 13);
            this.labelCarryOnPiecesAllowedCount.TabIndex = 14;
            this.labelCarryOnPiecesAllowedCount.Text = "Carry On Pieces Allowed Count:";
            //
            //maskedTextBoxCarryOnPiecesAllowedCount
            //
            this.maskedTextBoxCarryOnPiecesAllowedCount.Location = new System.Drawing.Point(231, 151);
            this.maskedTextBoxCarryOnPiecesAllowedCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxCarryOnPiecesAllowedCount.Name = "maskedTextBoxCarryOnPiecesAllowedCount";
            this.maskedTextBoxCarryOnPiecesAllowedCount.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxCarryOnPiecesAllowedCount.TabIndex = 15;
            //
            // labelCarryOnPieceMaxWeightInKilo
            //
            this.labelCarryOnPieceMaxWeightInKilo.AutoSize = true;
            this.labelCarryOnPieceMaxWeightInKilo.Location = new System.Drawing.Point(11, 174);
            this.labelCarryOnPieceMaxWeightInKilo.Name = "labelCarryOnPieceMaxWeightInKilo";
            this.labelCarryOnPieceMaxWeightInKilo.Size = new System.Drawing.Size(71, 13);
            this.labelCarryOnPieceMaxWeightInKilo.TabIndex = 16;
            this.labelCarryOnPieceMaxWeightInKilo.Text = "Carry On Piece Max Weight In Kilo:";
            //
            //maskedTextBoxCarryOnPieceMaxWeightInKilo
            //
            this.maskedTextBoxCarryOnPieceMaxWeightInKilo.Location = new System.Drawing.Point(231, 174);
            this.maskedTextBoxCarryOnPieceMaxWeightInKilo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxCarryOnPieceMaxWeightInKilo.Name = "maskedTextBoxCarryOnPieceMaxWeightInKilo";
            this.maskedTextBoxCarryOnPieceMaxWeightInKilo.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxCarryOnPieceMaxWeightInKilo.TabIndex = 17;
            //
            // labelInfantLimit
            //
            this.labelInfantLimit.AutoSize = true;
            this.labelInfantLimit.Location = new System.Drawing.Point(11, 197);
            this.labelInfantLimit.Name = "labelInfantLimit";
            this.labelInfantLimit.Size = new System.Drawing.Size(71, 13);
            this.labelInfantLimit.TabIndex = 18;
            this.labelInfantLimit.Text = "Infant Limit:";
            //
            //maskedTextBoxInfantLimit
            //
            this.maskedTextBoxInfantLimit.Location = new System.Drawing.Point(231, 197);
            this.maskedTextBoxInfantLimit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxInfantLimit.Name = "maskedTextBoxInfantLimit";
            this.maskedTextBoxInfantLimit.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxInfantLimit.TabIndex = 19;
            //
            // labelBookableLimit
            //
            this.labelBookableLimit.AutoSize = true;
            this.labelBookableLimit.Location = new System.Drawing.Point(11, 220);
            this.labelBookableLimit.Name = "labelBookableLimit";
            this.labelBookableLimit.Size = new System.Drawing.Size(71, 13);
            this.labelBookableLimit.TabIndex = 20;
            this.labelBookableLimit.Text = "Bookable Limit:";
            //
            //maskedTextBoxBookableLimit
            //
            this.maskedTextBoxBookableLimit.Location = new System.Drawing.Point(231, 220);
            this.maskedTextBoxBookableLimit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxBookableLimit.Name = "maskedTextBoxBookableLimit";
            this.maskedTextBoxBookableLimit.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxBookableLimit.TabIndex = 21;
            //
            // labelPassengerLimit
            //
            this.labelPassengerLimit.AutoSize = true;
            this.labelPassengerLimit.Location = new System.Drawing.Point(11, 243);
            this.labelPassengerLimit.Name = "labelPassengerLimit";
            this.labelPassengerLimit.Size = new System.Drawing.Size(71, 13);
            this.labelPassengerLimit.TabIndex = 22;
            this.labelPassengerLimit.Text = "Passenger Limit:";
            //
            //maskedTextBoxPassengerLimit
            //
            this.maskedTextBoxPassengerLimit.Location = new System.Drawing.Point(231, 243);
            this.maskedTextBoxPassengerLimit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxPassengerLimit.Name = "maskedTextBoxPassengerLimit";
            this.maskedTextBoxPassengerLimit.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxPassengerLimit.TabIndex = 23;
            //
            // labelRowCount
            //
            this.labelRowCount.AutoSize = true;
            this.labelRowCount.Location = new System.Drawing.Point(11, 266);
            this.labelRowCount.Name = "labelRowCount";
            this.labelRowCount.Size = new System.Drawing.Size(71, 13);
            this.labelRowCount.TabIndex = 24;
            this.labelRowCount.Text = "Row Count:";
            //
            //maskedTextBoxRowCount
            //
            this.maskedTextBoxRowCount.Location = new System.Drawing.Point(231, 266);
            this.maskedTextBoxRowCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxRowCount.Name = "maskedTextBoxRowCount";
            this.maskedTextBoxRowCount.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxRowCount.TabIndex = 25;
            //
            // labelColumnCount
            //
            this.labelColumnCount.AutoSize = true;
            this.labelColumnCount.Location = new System.Drawing.Point(11, 289);
            this.labelColumnCount.Name = "labelColumnCount";
            this.labelColumnCount.Size = new System.Drawing.Size(71, 13);
            this.labelColumnCount.TabIndex = 26;
            this.labelColumnCount.Text = "Column Count:";
            //
            //maskedTextBoxColumnCount
            //
            this.maskedTextBoxColumnCount.Location = new System.Drawing.Point(231, 289);
            this.maskedTextBoxColumnCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxColumnCount.Name = "maskedTextBoxColumnCount";
            this.maskedTextBoxColumnCount.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxColumnCount.TabIndex = 27;
            //
            // labelUserPicker
            //
            this.labelUserPicker.AutoSize = true;
            this.labelUserPicker.Location = new System.Drawing.Point(11, 312);
            this.labelUserPicker.Name = "labelUserPicker";
            this.labelUserPicker.Size = new System.Drawing.Size(71, 13);
            this.labelUserPicker.TabIndex = 28;
            this.labelUserPicker.Text = "User:";
            //
            //userPicker
            //
            this.userPicker.Location = new System.Drawing.Point(231, 312);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 29;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 335);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 30;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(231, 335);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 31;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(389, 358);
            
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
            this.buttonSave.Location = new System.Drawing.Point(289, 358);
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
            this.ClientSize = new System.Drawing.Size(493, 386);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeAircraftCompartmentMeasurementEdit";
            this.Text = "Aircraft Compartment Measurement Edit";
            this.Controls.Add(this.labelLength);
            this.Controls.Add(this.maskedTextBoxLength);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.maskedTextBoxHeight);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.maskedTextBoxWidth);
            this.Controls.Add(this.labelPayloadInKilo);
            this.Controls.Add(this.maskedTextBoxPayloadInKilo);
            this.Controls.Add(this.labelUnitLoadDevicePositions);
            this.Controls.Add(this.maskedTextBoxUnitLoadDevicePositions);
            this.Controls.Add(this.labelCarryOnBinCount);
            this.Controls.Add(this.maskedTextBoxCarryOnBinCount);
            this.Controls.Add(this.labelCarryOnPiecesAllowedCount);
            this.Controls.Add(this.maskedTextBoxCarryOnPiecesAllowedCount);
            this.Controls.Add(this.labelCarryOnPieceMaxWeightInKilo);
            this.Controls.Add(this.maskedTextBoxCarryOnPieceMaxWeightInKilo);
            this.Controls.Add(this.labelInfantLimit);
            this.Controls.Add(this.maskedTextBoxInfantLimit);
            this.Controls.Add(this.labelBookableLimit);
            this.Controls.Add(this.maskedTextBoxBookableLimit);
            this.Controls.Add(this.labelPassengerLimit);
            this.Controls.Add(this.maskedTextBoxPassengerLimit);
            this.Controls.Add(this.labelRowCount);
            this.Controls.Add(this.maskedTextBoxRowCount);
            this.Controls.Add(this.labelColumnCount);
            this.Controls.Add(this.maskedTextBoxColumnCount);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
