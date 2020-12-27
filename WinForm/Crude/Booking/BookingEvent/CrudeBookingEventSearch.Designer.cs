namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeBookingEventSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeBookingEventSearch;
        
        private System.Windows.Forms.Button buttonCrudeBookingEventAdd;
        
        private System.Windows.Forms.Button buttonCrudeBookingEventEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeBookingEvent;
        
        private BookingEventTypeRefCombo bookingEventTypeRefCombo;
        
        private System.Windows.Forms.Label labelBookingEventTypeRefCombo;
        
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
            this.buttonCrudeBookingEventAdd = new System.Windows.Forms.Button();
            this.buttonCrudeBookingEventEdit = new System.Windows.Forms.Button();
            this.buttonCrudeBookingEventSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeBookingEvent = new System.Windows.Forms.DataGridView();
            this.labelBookingEventTypeRefCombo = new System.Windows.Forms.Label();
            this.bookingEventTypeRefCombo = new BookingEventTypeRefCombo();
            this.labelComment = new System.Windows.Forms.Label();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeBookingEvent)).BeginInit();
            this.SuspendLayout();
            //
            // labelBookingEventTypeRefCombo
            //
            this.labelBookingEventTypeRefCombo.AutoSize = true;
            this.labelBookingEventTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelBookingEventTypeRefCombo.Name = "labelBookingEventTypeRefCombo";
            this.labelBookingEventTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelBookingEventTypeRefCombo.TabIndex = 2;
            this.labelBookingEventTypeRefCombo.Text = "Booking Event Type:";
            //
            //bookingEventTypeRefCombo
            //
            this.bookingEventTypeRefCombo.Location = new System.Drawing.Point(140, 13);
            this.bookingEventTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.bookingEventTypeRefCombo.Name = "bookingEventTypeRefCombo";
            this.bookingEventTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.bookingEventTypeRefCombo.TabIndex = 3;
            //
            // labelComment
            //
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(11, 36);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(71, 13);
            this.labelComment.TabIndex = 4;
            this.labelComment.Text = "Comment:";
            //
            //textBoxComment
            //
            this.textBoxComment.Location = new System.Drawing.Point(140, 36);
            this.textBoxComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(250, 20);
            this.textBoxComment.TabIndex = 5;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 59);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 6;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(140, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
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
            this.userPicker.Location = new System.Drawing.Point(140, 82);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 9;
            // 
            // dataGridViewCrudeBookingEvent
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeBookingEvent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeBookingEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeBookingEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeBookingEvent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeBookingEvent.Location = new System.Drawing.Point(12, 115);
            this.dataGridViewCrudeBookingEvent.Name = "dataGridViewCrudeBookingEvent";
            this.dataGridViewCrudeBookingEvent.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeBookingEvent.TabIndex = 0;
            this.dataGridViewCrudeBookingEvent.ReadOnly = true;
            this.dataGridViewCrudeBookingEvent.DoubleClick += new System.EventHandler(this.dataGridViewCrudeBookingEvent_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 218);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeBookingEventSearch
            // 
            this.buttonCrudeBookingEventSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeBookingEventSearch.Location = new System.Drawing.Point(198, 218);
            this.buttonCrudeBookingEventSearch.Name = "buttonCrudeBookingEventSearch";
            this.buttonCrudeBookingEventSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeBookingEventSearch.TabIndex = 2;
            this.buttonCrudeBookingEventSearch.Text = "&Search";
            this.buttonCrudeBookingEventSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeBookingEventSearch.Click += new System.EventHandler(this.buttonCrudeBookingEventSearch_Click);
            // 
            // buttonCrudeBookingEventAdd
            // 
            this.buttonCrudeBookingEventAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeBookingEventAdd.Location = new System.Drawing.Point(98, 218);
            this.buttonCrudeBookingEventAdd.Name = "buttonCrudeBookingEventAdd";
            this.buttonCrudeBookingEventAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeBookingEventAdd.TabIndex = 3;
            this.buttonCrudeBookingEventAdd.Text = "&Add";
            this.buttonCrudeBookingEventAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeBookingEventAdd.Click += new System.EventHandler(this.buttonCrudeBookingEventAdd_Click);
            // 
            // buttonCrudeBookingEventEdit
            // 
            this.buttonCrudeBookingEventEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeBookingEventEdit.Location = new System.Drawing.Point(-2, 218);
            this.buttonCrudeBookingEventEdit.Name = "buttonCrudeBookingEventEdit";
            this.buttonCrudeBookingEventEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeBookingEventEdit.TabIndex = 4;
            this.buttonCrudeBookingEventEdit.Text = "&Edit";
            this.buttonCrudeBookingEventEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeBookingEventEdit.Click += new System.EventHandler(this.buttonCrudeBookingEventEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 246);
            this.Controls.Add(this.buttonCrudeBookingEventSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeBookingEventAdd);
            this.Controls.Add(this.buttonCrudeBookingEventEdit);
            this.Controls.Add(this.dataGridViewCrudeBookingEvent);
            this.Name = "CrudeBookingEventSearch";
            this.Text = "Booking Event Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeBookingEvent)).EndInit();
            this.Controls.Add(this.labelBookingEventTypeRefCombo);
            this.Controls.Add(this.bookingEventTypeRefCombo);
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
