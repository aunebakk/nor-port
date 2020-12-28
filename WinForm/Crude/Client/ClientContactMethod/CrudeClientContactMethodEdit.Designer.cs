﻿namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeClientContactMethodEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private ClientPicker clientPicker;
        
        private System.Windows.Forms.Label labelClientPicker;
        
        private ContactMethodRefCombo contactMethodRefCombo;
        
        private System.Windows.Forms.Label labelContactMethodRefCombo;
        
        private System.Windows.Forms.TextBox textBoxContactMethodWay;
        
        private System.Windows.Forms.Label labelContactMethodWay;
        
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
            this.labelClientPicker = new System.Windows.Forms.Label();
            this.clientPicker = new ClientPicker();
            this.labelContactMethodRefCombo = new System.Windows.Forms.Label();
            this.contactMethodRefCombo = new ContactMethodRefCombo();
            this.labelContactMethodWay = new System.Windows.Forms.Label();
            this.textBoxContactMethodWay = new System.Windows.Forms.TextBox();
            this.labelComment = new System.Windows.Forms.Label();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelClientPicker
            //
            this.labelClientPicker.AutoSize = true;
            this.labelClientPicker.Location = new System.Drawing.Point(11, 13);
            this.labelClientPicker.Name = "labelClientPicker";
            this.labelClientPicker.Size = new System.Drawing.Size(71, 13);
            this.labelClientPicker.TabIndex = 2;
            this.labelClientPicker.Text = "Client:";
            //
            //clientPicker
            //
            this.clientPicker.Location = new System.Drawing.Point(140, 13);
            this.clientPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.clientPicker.Name = "clientPicker";
            this.clientPicker.Size = new System.Drawing.Size(250, 20);
            this.clientPicker.TabIndex = 3;
            //
            // labelContactMethodRefCombo
            //
            this.labelContactMethodRefCombo.AutoSize = true;
            this.labelContactMethodRefCombo.Location = new System.Drawing.Point(11, 36);
            this.labelContactMethodRefCombo.Name = "labelContactMethodRefCombo";
            this.labelContactMethodRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelContactMethodRefCombo.TabIndex = 4;
            this.labelContactMethodRefCombo.Text = "Contact Method:";
            //
            //contactMethodRefCombo
            //
            this.contactMethodRefCombo.Location = new System.Drawing.Point(140, 36);
            this.contactMethodRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.contactMethodRefCombo.Name = "contactMethodRefCombo";
            this.contactMethodRefCombo.Size = new System.Drawing.Size(250, 20);
            this.contactMethodRefCombo.TabIndex = 5;
            //
            // labelContactMethodWay
            //
            this.labelContactMethodWay.AutoSize = true;
            this.labelContactMethodWay.Location = new System.Drawing.Point(11, 59);
            this.labelContactMethodWay.Name = "labelContactMethodWay";
            this.labelContactMethodWay.Size = new System.Drawing.Size(71, 13);
            this.labelContactMethodWay.TabIndex = 6;
            this.labelContactMethodWay.Text = "Contact Method Way:";
            //
            //textBoxContactMethodWay
            //
            this.textBoxContactMethodWay.Location = new System.Drawing.Point(140, 59);
            this.textBoxContactMethodWay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxContactMethodWay.Name = "textBoxContactMethodWay";
            this.textBoxContactMethodWay.Size = new System.Drawing.Size(250, 20);
            this.textBoxContactMethodWay.TabIndex = 7;
            //
            // labelComment
            //
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(11, 82);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(71, 13);
            this.labelComment.TabIndex = 8;
            this.labelComment.Text = "Comment:";
            //
            //textBoxComment
            //
            this.textBoxComment.Location = new System.Drawing.Point(140, 82);
            this.textBoxComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(250, 20);
            this.textBoxComment.TabIndex = 9;
            //
            // labelUserPicker
            //
            this.labelUserPicker.AutoSize = true;
            this.labelUserPicker.Location = new System.Drawing.Point(11, 105);
            this.labelUserPicker.Name = "labelUserPicker";
            this.labelUserPicker.Size = new System.Drawing.Size(71, 13);
            this.labelUserPicker.TabIndex = 10;
            this.labelUserPicker.Text = "User:";
            //
            //userPicker
            //
            this.userPicker.Location = new System.Drawing.Point(140, 105);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 11;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 128);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 12;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(140, 128);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 13;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 151);
            
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
            this.buttonSave.Location = new System.Drawing.Point(198, 151);
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
            this.ClientSize = new System.Drawing.Size(402, 179);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeClientContactMethodEdit";
            this.Text = "Client Contact Method Edit";
            this.Controls.Add(this.labelClientPicker);
            this.Controls.Add(this.clientPicker);
            this.Controls.Add(this.labelContactMethodRefCombo);
            this.Controls.Add(this.contactMethodRefCombo);
            this.Controls.Add(this.labelContactMethodWay);
            this.Controls.Add(this.textBoxContactMethodWay);
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
