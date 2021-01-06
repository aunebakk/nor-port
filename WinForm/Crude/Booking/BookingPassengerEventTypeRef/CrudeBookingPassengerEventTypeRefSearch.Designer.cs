namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeBookingPassengerEventTypeRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeBookingPassengerEventTypeRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeBookingPassengerEventTypeRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeBookingPassengerEventTypeRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeBookingPassengerEventTypeRef;
        
        private System.Windows.Forms.TextBox textBoxBookingPassengerEventTypeName;
        
        private System.Windows.Forms.Label labelBookingPassengerEventTypeName;
        
        private System.Windows.Forms.TextBox textBoxBookingPassengerEventType;
        
        private System.Windows.Forms.Label labelBookingPassengerEventType;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonCrudeBookingPassengerEventTypeRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeBookingPassengerEventTypeRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeBookingPassengerEventTypeRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeBookingPassengerEventTypeRef = new System.Windows.Forms.DataGridView();
            this.labelBookingPassengerEventTypeName = new System.Windows.Forms.Label();
            this.textBoxBookingPassengerEventTypeName = new System.Windows.Forms.TextBox();
            this.labelBookingPassengerEventType = new System.Windows.Forms.Label();
            this.textBoxBookingPassengerEventType = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeBookingPassengerEventTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelBookingPassengerEventTypeName
            //
            this.labelBookingPassengerEventTypeName.AutoSize = true;
            this.labelBookingPassengerEventTypeName.Location = new System.Drawing.Point(11, 13);
            this.labelBookingPassengerEventTypeName.Name = "labelBookingPassengerEventTypeName";
            this.labelBookingPassengerEventTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelBookingPassengerEventTypeName.TabIndex = 2;
            this.labelBookingPassengerEventTypeName.Text = "Booking Passenger Event Type Name:";
            //
            //textBoxBookingPassengerEventTypeName
            //
            this.textBoxBookingPassengerEventTypeName.Location = new System.Drawing.Point(231, 13);
            this.textBoxBookingPassengerEventTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBookingPassengerEventTypeName.Name = "textBoxBookingPassengerEventTypeName";
            this.textBoxBookingPassengerEventTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxBookingPassengerEventTypeName.TabIndex = 3;
            //
            // labelBookingPassengerEventType
            //
            this.labelBookingPassengerEventType.AutoSize = true;
            this.labelBookingPassengerEventType.Location = new System.Drawing.Point(11, 36);
            this.labelBookingPassengerEventType.Name = "labelBookingPassengerEventType";
            this.labelBookingPassengerEventType.Size = new System.Drawing.Size(71, 13);
            this.labelBookingPassengerEventType.TabIndex = 4;
            this.labelBookingPassengerEventType.Text = "Booking Passenger Event Type:";
            //
            //textBoxBookingPassengerEventType
            //
            this.textBoxBookingPassengerEventType.Location = new System.Drawing.Point(231, 36);
            this.textBoxBookingPassengerEventType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBookingPassengerEventType.Name = "textBoxBookingPassengerEventType";
            this.textBoxBookingPassengerEventType.Size = new System.Drawing.Size(250, 20);
            this.textBoxBookingPassengerEventType.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(231, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // dataGridViewCrudeBookingPassengerEventTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeBookingPassengerEventTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeBookingPassengerEventTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeBookingPassengerEventTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeBookingPassengerEventTypeRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeBookingPassengerEventTypeRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeBookingPassengerEventTypeRef.Name = "dataGridViewCrudeBookingPassengerEventTypeRef";
            this.dataGridViewCrudeBookingPassengerEventTypeRef.Size = new System.Drawing.Size(469, 96);
            this.dataGridViewCrudeBookingPassengerEventTypeRef.TabIndex = 0;
            this.dataGridViewCrudeBookingPassengerEventTypeRef.ReadOnly = true;
            this.dataGridViewCrudeBookingPassengerEventTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeBookingPassengerEventTypeRef_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(389, 195);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeBookingPassengerEventTypeRefSearch
            // 
            this.buttonCrudeBookingPassengerEventTypeRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeBookingPassengerEventTypeRefSearch.Location = new System.Drawing.Point(289, 195);
            this.buttonCrudeBookingPassengerEventTypeRefSearch.Name = "buttonCrudeBookingPassengerEventTypeRefSearch";
            this.buttonCrudeBookingPassengerEventTypeRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeBookingPassengerEventTypeRefSearch.TabIndex = 2;
            this.buttonCrudeBookingPassengerEventTypeRefSearch.Text = "&Search";
            this.buttonCrudeBookingPassengerEventTypeRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeBookingPassengerEventTypeRefSearch.Click += new System.EventHandler(this.buttonCrudeBookingPassengerEventTypeRefSearch_Click);
            // 
            // buttonCrudeBookingPassengerEventTypeRefAdd
            // 
            this.buttonCrudeBookingPassengerEventTypeRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeBookingPassengerEventTypeRefAdd.Location = new System.Drawing.Point(189, 195);
            this.buttonCrudeBookingPassengerEventTypeRefAdd.Name = "buttonCrudeBookingPassengerEventTypeRefAdd";
            this.buttonCrudeBookingPassengerEventTypeRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeBookingPassengerEventTypeRefAdd.TabIndex = 3;
            this.buttonCrudeBookingPassengerEventTypeRefAdd.Text = "&Add";
            this.buttonCrudeBookingPassengerEventTypeRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeBookingPassengerEventTypeRefAdd.Click += new System.EventHandler(this.buttonCrudeBookingPassengerEventTypeRefAdd_Click);
            // 
            // buttonCrudeBookingPassengerEventTypeRefEdit
            // 
            this.buttonCrudeBookingPassengerEventTypeRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeBookingPassengerEventTypeRefEdit.Location = new System.Drawing.Point(89, 195);
            this.buttonCrudeBookingPassengerEventTypeRefEdit.Name = "buttonCrudeBookingPassengerEventTypeRefEdit";
            this.buttonCrudeBookingPassengerEventTypeRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeBookingPassengerEventTypeRefEdit.TabIndex = 4;
            this.buttonCrudeBookingPassengerEventTypeRefEdit.Text = "&Edit";
            this.buttonCrudeBookingPassengerEventTypeRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeBookingPassengerEventTypeRefEdit.Click += new System.EventHandler(this.buttonCrudeBookingPassengerEventTypeRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 223);
            this.Controls.Add(this.buttonCrudeBookingPassengerEventTypeRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeBookingPassengerEventTypeRefAdd);
            this.Controls.Add(this.buttonCrudeBookingPassengerEventTypeRefEdit);
            this.Controls.Add(this.dataGridViewCrudeBookingPassengerEventTypeRef);
            this.Name = "CrudeBookingPassengerEventTypeRefSearch";
            this.Text = "Booking Passenger Event Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeBookingPassengerEventTypeRef)).EndInit();
            this.Controls.Add(this.labelBookingPassengerEventTypeName);
            this.Controls.Add(this.textBoxBookingPassengerEventTypeName);
            this.Controls.Add(this.labelBookingPassengerEventType);
            this.Controls.Add(this.textBoxBookingPassengerEventType);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
