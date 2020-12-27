namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeBookingIdentifierSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeBookingIdentifierSearch;
        
        private System.Windows.Forms.Button buttonCrudeBookingIdentifierAdd;
        
        private System.Windows.Forms.Button buttonCrudeBookingIdentifierEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeBookingIdentifier;
        
        private BookingIdentifierTypeRefCombo bookingIdentifierTypeRefCombo;
        
        private System.Windows.Forms.Label labelBookingIdentifierTypeRefCombo;
        
        private System.Windows.Forms.TextBox textBoxBookingIdentifierValue;
        
        private System.Windows.Forms.Label labelBookingIdentifierValue;
        
        private System.Windows.Forms.TextBox textBoxComment;
        
        private System.Windows.Forms.Label labelComment;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
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
            this.buttonCrudeBookingIdentifierAdd = new System.Windows.Forms.Button();
            this.buttonCrudeBookingIdentifierEdit = new System.Windows.Forms.Button();
            this.buttonCrudeBookingIdentifierSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeBookingIdentifier = new System.Windows.Forms.DataGridView();
            this.labelBookingIdentifierTypeRefCombo = new System.Windows.Forms.Label();
            this.bookingIdentifierTypeRefCombo = new BookingIdentifierTypeRefCombo();
            this.labelBookingIdentifierValue = new System.Windows.Forms.Label();
            this.textBoxBookingIdentifierValue = new System.Windows.Forms.TextBox();
            this.labelComment = new System.Windows.Forms.Label();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeBookingIdentifier)).BeginInit();
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
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 82);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 8;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(168, 82);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 9;
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
            this.userPicker.Location = new System.Drawing.Point(168, 105);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 11;
            // 
            // dataGridViewCrudeBookingIdentifier
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeBookingIdentifier.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeBookingIdentifier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeBookingIdentifier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeBookingIdentifier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeBookingIdentifier.Location = new System.Drawing.Point(12, 138);
            this.dataGridViewCrudeBookingIdentifier.Name = "dataGridViewCrudeBookingIdentifier";
            this.dataGridViewCrudeBookingIdentifier.Size = new System.Drawing.Size(406, 96);
            this.dataGridViewCrudeBookingIdentifier.TabIndex = 0;
            this.dataGridViewCrudeBookingIdentifier.ReadOnly = true;
            this.dataGridViewCrudeBookingIdentifier.DoubleClick += new System.EventHandler(this.dataGridViewCrudeBookingIdentifier_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(326, 241);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeBookingIdentifierSearch
            // 
            this.buttonCrudeBookingIdentifierSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeBookingIdentifierSearch.Location = new System.Drawing.Point(226, 241);
            this.buttonCrudeBookingIdentifierSearch.Name = "buttonCrudeBookingIdentifierSearch";
            this.buttonCrudeBookingIdentifierSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeBookingIdentifierSearch.TabIndex = 2;
            this.buttonCrudeBookingIdentifierSearch.Text = "&Search";
            this.buttonCrudeBookingIdentifierSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeBookingIdentifierSearch.Click += new System.EventHandler(this.buttonCrudeBookingIdentifierSearch_Click);
            // 
            // buttonCrudeBookingIdentifierAdd
            // 
            this.buttonCrudeBookingIdentifierAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeBookingIdentifierAdd.Location = new System.Drawing.Point(126, 241);
            this.buttonCrudeBookingIdentifierAdd.Name = "buttonCrudeBookingIdentifierAdd";
            this.buttonCrudeBookingIdentifierAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeBookingIdentifierAdd.TabIndex = 3;
            this.buttonCrudeBookingIdentifierAdd.Text = "&Add";
            this.buttonCrudeBookingIdentifierAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeBookingIdentifierAdd.Click += new System.EventHandler(this.buttonCrudeBookingIdentifierAdd_Click);
            // 
            // buttonCrudeBookingIdentifierEdit
            // 
            this.buttonCrudeBookingIdentifierEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeBookingIdentifierEdit.Location = new System.Drawing.Point(26, 241);
            this.buttonCrudeBookingIdentifierEdit.Name = "buttonCrudeBookingIdentifierEdit";
            this.buttonCrudeBookingIdentifierEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeBookingIdentifierEdit.TabIndex = 4;
            this.buttonCrudeBookingIdentifierEdit.Text = "&Edit";
            this.buttonCrudeBookingIdentifierEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeBookingIdentifierEdit.Click += new System.EventHandler(this.buttonCrudeBookingIdentifierEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 269);
            this.Controls.Add(this.buttonCrudeBookingIdentifierSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeBookingIdentifierAdd);
            this.Controls.Add(this.buttonCrudeBookingIdentifierEdit);
            this.Controls.Add(this.dataGridViewCrudeBookingIdentifier);
            this.Name = "CrudeBookingIdentifierSearch";
            this.Text = "Booking Identifier Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeBookingIdentifier)).EndInit();
            this.Controls.Add(this.labelBookingIdentifierTypeRefCombo);
            this.Controls.Add(this.bookingIdentifierTypeRefCombo);
            this.Controls.Add(this.labelBookingIdentifierValue);
            this.Controls.Add(this.textBoxBookingIdentifierValue);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
