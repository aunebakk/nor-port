namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeBookingDocumentEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private BookingDocumentTypeRefCombo bookingDocumentTypeRefCombo;
        
        private System.Windows.Forms.Label labelBookingDocumentTypeRefCombo;
        
        private System.Windows.Forms.TextBox textBoxBookingDocumentName;
        
        private System.Windows.Forms.Label labelBookingDocumentName;
        
        private System.Windows.Forms.TextBox textBoxBookingDocumentFilename;
        
        private System.Windows.Forms.Label labelBookingDocumentFilename;
        
        private System.Windows.Forms.TextBox textBoxBookingDocument;
        
        private System.Windows.Forms.Label labelBookingDocument;
        
        private System.Windows.Forms.TextBox textBoxComment;
        
        private System.Windows.Forms.Label labelComment;
        
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
            this.labelBookingDocumentTypeRefCombo = new System.Windows.Forms.Label();
            this.bookingDocumentTypeRefCombo = new BookingDocumentTypeRefCombo();
            this.labelBookingDocumentName = new System.Windows.Forms.Label();
            this.textBoxBookingDocumentName = new System.Windows.Forms.TextBox();
            this.labelBookingDocumentFilename = new System.Windows.Forms.Label();
            this.textBoxBookingDocumentFilename = new System.Windows.Forms.TextBox();
            this.labelBookingDocument = new System.Windows.Forms.Label();
            this.textBoxBookingDocument = new System.Windows.Forms.TextBox();
            this.labelComment = new System.Windows.Forms.Label();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelBookingDocumentTypeRefCombo
            //
            this.labelBookingDocumentTypeRefCombo.AutoSize = true;
            this.labelBookingDocumentTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelBookingDocumentTypeRefCombo.Name = "labelBookingDocumentTypeRefCombo";
            this.labelBookingDocumentTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelBookingDocumentTypeRefCombo.TabIndex = 2;
            this.labelBookingDocumentTypeRefCombo.Text = "Booking Document Type:";
            //
            //bookingDocumentTypeRefCombo
            //
            this.bookingDocumentTypeRefCombo.Location = new System.Drawing.Point(175, 13);
            this.bookingDocumentTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.bookingDocumentTypeRefCombo.Name = "bookingDocumentTypeRefCombo";
            this.bookingDocumentTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.bookingDocumentTypeRefCombo.TabIndex = 3;
            //
            // labelBookingDocumentName
            //
            this.labelBookingDocumentName.AutoSize = true;
            this.labelBookingDocumentName.Location = new System.Drawing.Point(11, 36);
            this.labelBookingDocumentName.Name = "labelBookingDocumentName";
            this.labelBookingDocumentName.Size = new System.Drawing.Size(71, 13);
            this.labelBookingDocumentName.TabIndex = 4;
            this.labelBookingDocumentName.Text = "Booking Document Name:";
            //
            //textBoxBookingDocumentName
            //
            this.textBoxBookingDocumentName.Location = new System.Drawing.Point(175, 36);
            this.textBoxBookingDocumentName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBookingDocumentName.Name = "textBoxBookingDocumentName";
            this.textBoxBookingDocumentName.Size = new System.Drawing.Size(250, 20);
            this.textBoxBookingDocumentName.TabIndex = 5;
            //
            // labelBookingDocumentFilename
            //
            this.labelBookingDocumentFilename.AutoSize = true;
            this.labelBookingDocumentFilename.Location = new System.Drawing.Point(11, 59);
            this.labelBookingDocumentFilename.Name = "labelBookingDocumentFilename";
            this.labelBookingDocumentFilename.Size = new System.Drawing.Size(71, 13);
            this.labelBookingDocumentFilename.TabIndex = 6;
            this.labelBookingDocumentFilename.Text = "Booking Document Filename:";
            //
            //textBoxBookingDocumentFilename
            //
            this.textBoxBookingDocumentFilename.Location = new System.Drawing.Point(175, 59);
            this.textBoxBookingDocumentFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBookingDocumentFilename.Name = "textBoxBookingDocumentFilename";
            this.textBoxBookingDocumentFilename.Size = new System.Drawing.Size(250, 20);
            this.textBoxBookingDocumentFilename.TabIndex = 7;
            //
            // labelBookingDocument
            //
            this.labelBookingDocument.AutoSize = true;
            this.labelBookingDocument.Location = new System.Drawing.Point(11, 82);
            this.labelBookingDocument.Name = "labelBookingDocument";
            this.labelBookingDocument.Size = new System.Drawing.Size(71, 13);
            this.labelBookingDocument.TabIndex = 8;
            this.labelBookingDocument.Text = "Booking Document:";
            //
            //textBoxBookingDocument
            //
            this.textBoxBookingDocument.Location = new System.Drawing.Point(175, 82);
            this.textBoxBookingDocument.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBookingDocument.Name = "textBoxBookingDocument";
            this.textBoxBookingDocument.Size = new System.Drawing.Size(250, 20);
            this.textBoxBookingDocument.TabIndex = 9;
            //
            // labelComment
            //
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(11, 105);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(71, 13);
            this.labelComment.TabIndex = 10;
            this.labelComment.Text = "Comment:";
            //
            //textBoxComment
            //
            this.textBoxComment.Location = new System.Drawing.Point(175, 105);
            this.textBoxComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(250, 20);
            this.textBoxComment.TabIndex = 11;
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
            this.userPicker.Location = new System.Drawing.Point(175, 128);
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(175, 151);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 15;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(333, 174);
            
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
            this.buttonSave.Location = new System.Drawing.Point(233, 174);
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
            this.ClientSize = new System.Drawing.Size(437, 202);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeBookingDocumentEdit";
            this.Text = "Booking Document Edit";
            this.Controls.Add(this.labelBookingDocumentTypeRefCombo);
            this.Controls.Add(this.bookingDocumentTypeRefCombo);
            this.Controls.Add(this.labelBookingDocumentName);
            this.Controls.Add(this.textBoxBookingDocumentName);
            this.Controls.Add(this.labelBookingDocumentFilename);
            this.Controls.Add(this.textBoxBookingDocumentFilename);
            this.Controls.Add(this.labelBookingDocument);
            this.Controls.Add(this.textBoxBookingDocument);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
