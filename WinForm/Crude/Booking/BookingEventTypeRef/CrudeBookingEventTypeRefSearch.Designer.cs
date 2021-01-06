namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeBookingEventTypeRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeBookingEventTypeRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeBookingEventTypeRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeBookingEventTypeRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeBookingEventTypeRef;
        
        private System.Windows.Forms.TextBox textBoxBookingEventTypeName;
        
        private System.Windows.Forms.Label labelBookingEventTypeName;
        
        private System.Windows.Forms.TextBox textBoxBookingEventType;
        
        private System.Windows.Forms.Label labelBookingEventType;
        
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
            this.buttonCrudeBookingEventTypeRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeBookingEventTypeRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeBookingEventTypeRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeBookingEventTypeRef = new System.Windows.Forms.DataGridView();
            this.labelBookingEventTypeName = new System.Windows.Forms.Label();
            this.textBoxBookingEventTypeName = new System.Windows.Forms.TextBox();
            this.labelBookingEventType = new System.Windows.Forms.Label();
            this.textBoxBookingEventType = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeBookingEventTypeRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelBookingEventTypeName
            //
            this.labelBookingEventTypeName.AutoSize = true;
            this.labelBookingEventTypeName.Location = new System.Drawing.Point(11, 13);
            this.labelBookingEventTypeName.Name = "labelBookingEventTypeName";
            this.labelBookingEventTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelBookingEventTypeName.TabIndex = 2;
            this.labelBookingEventTypeName.Text = "Booking Event Type Name:";
            //
            //textBoxBookingEventTypeName
            //
            this.textBoxBookingEventTypeName.Location = new System.Drawing.Point(161, 13);
            this.textBoxBookingEventTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBookingEventTypeName.Name = "textBoxBookingEventTypeName";
            this.textBoxBookingEventTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxBookingEventTypeName.TabIndex = 3;
            //
            // labelBookingEventType
            //
            this.labelBookingEventType.AutoSize = true;
            this.labelBookingEventType.Location = new System.Drawing.Point(11, 36);
            this.labelBookingEventType.Name = "labelBookingEventType";
            this.labelBookingEventType.Size = new System.Drawing.Size(71, 13);
            this.labelBookingEventType.TabIndex = 4;
            this.labelBookingEventType.Text = "Booking Event Type:";
            //
            //textBoxBookingEventType
            //
            this.textBoxBookingEventType.Location = new System.Drawing.Point(161, 36);
            this.textBoxBookingEventType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBookingEventType.Name = "textBoxBookingEventType";
            this.textBoxBookingEventType.Size = new System.Drawing.Size(250, 20);
            this.textBoxBookingEventType.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(161, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            // 
            // dataGridViewCrudeBookingEventTypeRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeBookingEventTypeRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeBookingEventTypeRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeBookingEventTypeRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeBookingEventTypeRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeBookingEventTypeRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeBookingEventTypeRef.Name = "dataGridViewCrudeBookingEventTypeRef";
            this.dataGridViewCrudeBookingEventTypeRef.Size = new System.Drawing.Size(399, 96);
            this.dataGridViewCrudeBookingEventTypeRef.TabIndex = 0;
            this.dataGridViewCrudeBookingEventTypeRef.ReadOnly = true;
            this.dataGridViewCrudeBookingEventTypeRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeBookingEventTypeRef_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(319, 195);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeBookingEventTypeRefSearch
            // 
            this.buttonCrudeBookingEventTypeRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeBookingEventTypeRefSearch.Location = new System.Drawing.Point(219, 195);
            this.buttonCrudeBookingEventTypeRefSearch.Name = "buttonCrudeBookingEventTypeRefSearch";
            this.buttonCrudeBookingEventTypeRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeBookingEventTypeRefSearch.TabIndex = 2;
            this.buttonCrudeBookingEventTypeRefSearch.Text = "&Search";
            this.buttonCrudeBookingEventTypeRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeBookingEventTypeRefSearch.Click += new System.EventHandler(this.buttonCrudeBookingEventTypeRefSearch_Click);
            // 
            // buttonCrudeBookingEventTypeRefAdd
            // 
            this.buttonCrudeBookingEventTypeRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeBookingEventTypeRefAdd.Location = new System.Drawing.Point(119, 195);
            this.buttonCrudeBookingEventTypeRefAdd.Name = "buttonCrudeBookingEventTypeRefAdd";
            this.buttonCrudeBookingEventTypeRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeBookingEventTypeRefAdd.TabIndex = 3;
            this.buttonCrudeBookingEventTypeRefAdd.Text = "&Add";
            this.buttonCrudeBookingEventTypeRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeBookingEventTypeRefAdd.Click += new System.EventHandler(this.buttonCrudeBookingEventTypeRefAdd_Click);
            // 
            // buttonCrudeBookingEventTypeRefEdit
            // 
            this.buttonCrudeBookingEventTypeRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeBookingEventTypeRefEdit.Location = new System.Drawing.Point(19, 195);
            this.buttonCrudeBookingEventTypeRefEdit.Name = "buttonCrudeBookingEventTypeRefEdit";
            this.buttonCrudeBookingEventTypeRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeBookingEventTypeRefEdit.TabIndex = 4;
            this.buttonCrudeBookingEventTypeRefEdit.Text = "&Edit";
            this.buttonCrudeBookingEventTypeRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeBookingEventTypeRefEdit.Click += new System.EventHandler(this.buttonCrudeBookingEventTypeRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 223);
            this.Controls.Add(this.buttonCrudeBookingEventTypeRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeBookingEventTypeRefAdd);
            this.Controls.Add(this.buttonCrudeBookingEventTypeRefEdit);
            this.Controls.Add(this.dataGridViewCrudeBookingEventTypeRef);
            this.Name = "CrudeBookingEventTypeRefSearch";
            this.Text = "Booking Event Type Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeBookingEventTypeRef)).EndInit();
            this.Controls.Add(this.labelBookingEventTypeName);
            this.Controls.Add(this.textBoxBookingEventTypeName);
            this.Controls.Add(this.labelBookingEventType);
            this.Controls.Add(this.textBoxBookingEventType);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
