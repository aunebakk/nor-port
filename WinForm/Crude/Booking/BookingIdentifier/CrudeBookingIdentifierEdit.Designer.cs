﻿namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeBookingIdentifierEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private BookingIdentifierTypeRefCombo bookingIdentifierTypeRefCombo;
        
        private System.Windows.Forms.Label labelBookingIdentifierTypeRefCombo;
        
        private System.Windows.Forms.TextBox textBoxBookingIdentifierValue;
        
        private System.Windows.Forms.Label labelBookingIdentifierValue;
        
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
            this.labelBookingIdentifierTypeRefCombo = new System.Windows.Forms.Label();
            this.bookingIdentifierTypeRefCombo = new BookingIdentifierTypeRefCombo();
            this.labelBookingIdentifierValue = new System.Windows.Forms.Label();
            this.textBoxBookingIdentifierValue = new System.Windows.Forms.TextBox();
            this.labelComment = new System.Windows.Forms.Label();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelBookingIdentifierTypeRefCombo
            //
            this.labelBookingIdentifierTypeRefCombo.AutoSize = true;
            this.labelBookingIdentifierTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelBookingIdentifierTypeRefCombo.Name = "labelBookingIdentifierTypeRefCombo";
            this.labelBookingIdentifierTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelBookingIdentifierTypeRefCombo.TabIndex = 2;
            this.labelBookingIdentifierTypeRefCombo.Text = "Booking Identifier Type:";
            //
            //bookingIdentifierTypeRefCombo
            //
            this.bookingIdentifierTypeRefCombo.Location = new System.Drawing.Point(168, 13);
            this.bookingIdentifierTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.bookingIdentifierTypeRefCombo.Name = "bookingIdentifierTypeRefCombo";
            this.bookingIdentifierTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.bookingIdentifierTypeRefCombo.TabIndex = 3;
            //
            // labelBookingIdentifierValue
            //
            this.labelBookingIdentifierValue.AutoSize = true;
            this.labelBookingIdentifierValue.Location = new System.Drawing.Point(11, 36);
            this.labelBookingIdentifierValue.Name = "labelBookingIdentifierValue";
            this.labelBookingIdentifierValue.Size = new System.Drawing.Size(71, 13);
            this.labelBookingIdentifierValue.TabIndex = 4;
            this.labelBookingIdentifierValue.Text = "Booking Identifier Value:";
            //
            //textBoxBookingIdentifierValue
            //
            this.textBoxBookingIdentifierValue.Location = new System.Drawing.Point(168, 36);
            this.textBoxBookingIdentifierValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBookingIdentifierValue.Name = "textBoxBookingIdentifierValue";
            this.textBoxBookingIdentifierValue.Size = new System.Drawing.Size(250, 20);
            this.textBoxBookingIdentifierValue.TabIndex = 5;
            //
            // labelComment
            //
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(11, 59);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(71, 13);
            this.labelComment.TabIndex = 6;
            this.labelComment.Text = "Comment:";
            //
            //textBoxComment
            //
            this.textBoxComment.Location = new System.Drawing.Point(168, 59);
            this.textBoxComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(250, 20);
            this.textBoxComment.TabIndex = 7;
            //
            // labelUserPicker
            //
            this.labelUserPicker.AutoSize = true;
            this.labelUserPicker.Location = new System.Drawing.Point(11, 82);
            this.labelUserPicker.Name = "labelUserPicker";
            this.labelUserPicker.Size = new System.Drawing.Size(71, 13);
            this.labelUserPicker.TabIndex = 8;
            this.labelUserPicker.Text = "User:";
            //
            //userPicker
            //
            this.userPicker.Location = new System.Drawing.Point(168, 82);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 9;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(168, 105);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 11;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(326, 128);
            
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
            this.buttonSave.Location = new System.Drawing.Point(226, 128);
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
            this.ClientSize = new System.Drawing.Size(430, 156);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeBookingIdentifierEdit";
            this.Text = "Booking Identifier Edit";
            this.Controls.Add(this.labelBookingIdentifierTypeRefCombo);
            this.Controls.Add(this.bookingIdentifierTypeRefCombo);
            this.Controls.Add(this.labelBookingIdentifierValue);
            this.Controls.Add(this.textBoxBookingIdentifierValue);
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