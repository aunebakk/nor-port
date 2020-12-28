namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeBookingFlightSegmentSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeBookingFlightSegmentSearch;
        
        private System.Windows.Forms.Button buttonCrudeBookingFlightSegmentAdd;
        
        private System.Windows.Forms.Button buttonCrudeBookingFlightSegmentEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeBookingFlightSegment;
        
        private DefaultStateRefCombo defaultStateRefCombo;
        
        private System.Windows.Forms.Label labelDefaultStateRefCombo;
        
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
            this.buttonCrudeBookingFlightSegmentAdd = new System.Windows.Forms.Button();
            this.buttonCrudeBookingFlightSegmentEdit = new System.Windows.Forms.Button();
            this.buttonCrudeBookingFlightSegmentSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeBookingFlightSegment = new System.Windows.Forms.DataGridView();
            this.labelDefaultStateRefCombo = new System.Windows.Forms.Label();
            this.defaultStateRefCombo = new DefaultStateRefCombo();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeBookingFlightSegment)).BeginInit();
            this.SuspendLayout();
            //
            // labelDefaultStateRefCombo
            //
            this.labelDefaultStateRefCombo.AutoSize = true;
            this.labelDefaultStateRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelDefaultStateRefCombo.Name = "labelDefaultStateRefCombo";
            this.labelDefaultStateRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelDefaultStateRefCombo.TabIndex = 2;
            this.labelDefaultStateRefCombo.Text = "Default State:";
            //
            //defaultStateRefCombo
            //
            this.defaultStateRefCombo.Location = new System.Drawing.Point(210, 13);
            this.defaultStateRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.defaultStateRefCombo.Name = "defaultStateRefCombo";
            this.defaultStateRefCombo.Size = new System.Drawing.Size(250, 20);
            this.defaultStateRefCombo.TabIndex = 3;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 36);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 4;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(210, 36);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 5;
            //
            // labelUserPicker
            //
            this.labelUserPicker.AutoSize = true;
            this.labelUserPicker.Location = new System.Drawing.Point(11, 59);
            this.labelUserPicker.Name = "labelUserPicker";
            this.labelUserPicker.Size = new System.Drawing.Size(71, 13);
            this.labelUserPicker.TabIndex = 6;
            this.labelUserPicker.Text = "User:";
            //
            //userPicker
            //
            this.userPicker.Location = new System.Drawing.Point(210, 59);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 7;
            // 
            // dataGridViewCrudeBookingFlightSegment
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeBookingFlightSegment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeBookingFlightSegment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeBookingFlightSegment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeBookingFlightSegment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeBookingFlightSegment.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeBookingFlightSegment.Name = "dataGridViewCrudeBookingFlightSegment";
            this.dataGridViewCrudeBookingFlightSegment.Size = new System.Drawing.Size(448, 96);
            this.dataGridViewCrudeBookingFlightSegment.TabIndex = 0;
            this.dataGridViewCrudeBookingFlightSegment.ReadOnly = true;
            this.dataGridViewCrudeBookingFlightSegment.DoubleClick += new System.EventHandler(this.dataGridViewCrudeBookingFlightSegment_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(368, 195);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeBookingFlightSegmentSearch
            // 
            this.buttonCrudeBookingFlightSegmentSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeBookingFlightSegmentSearch.Location = new System.Drawing.Point(268, 195);
            this.buttonCrudeBookingFlightSegmentSearch.Name = "buttonCrudeBookingFlightSegmentSearch";
            this.buttonCrudeBookingFlightSegmentSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeBookingFlightSegmentSearch.TabIndex = 2;
            this.buttonCrudeBookingFlightSegmentSearch.Text = "&Search";
            this.buttonCrudeBookingFlightSegmentSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeBookingFlightSegmentSearch.Click += new System.EventHandler(this.buttonCrudeBookingFlightSegmentSearch_Click);
            // 
            // buttonCrudeBookingFlightSegmentAdd
            // 
            this.buttonCrudeBookingFlightSegmentAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeBookingFlightSegmentAdd.Location = new System.Drawing.Point(168, 195);
            this.buttonCrudeBookingFlightSegmentAdd.Name = "buttonCrudeBookingFlightSegmentAdd";
            this.buttonCrudeBookingFlightSegmentAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeBookingFlightSegmentAdd.TabIndex = 3;
            this.buttonCrudeBookingFlightSegmentAdd.Text = "&Add";
            this.buttonCrudeBookingFlightSegmentAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeBookingFlightSegmentAdd.Click += new System.EventHandler(this.buttonCrudeBookingFlightSegmentAdd_Click);
            // 
            // buttonCrudeBookingFlightSegmentEdit
            // 
            this.buttonCrudeBookingFlightSegmentEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeBookingFlightSegmentEdit.Location = new System.Drawing.Point(68, 195);
            this.buttonCrudeBookingFlightSegmentEdit.Name = "buttonCrudeBookingFlightSegmentEdit";
            this.buttonCrudeBookingFlightSegmentEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeBookingFlightSegmentEdit.TabIndex = 4;
            this.buttonCrudeBookingFlightSegmentEdit.Text = "&Edit";
            this.buttonCrudeBookingFlightSegmentEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeBookingFlightSegmentEdit.Click += new System.EventHandler(this.buttonCrudeBookingFlightSegmentEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 223);
            this.Controls.Add(this.buttonCrudeBookingFlightSegmentSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeBookingFlightSegmentAdd);
            this.Controls.Add(this.buttonCrudeBookingFlightSegmentEdit);
            this.Controls.Add(this.dataGridViewCrudeBookingFlightSegment);
            this.Name = "CrudeBookingFlightSegmentSearch";
            this.Text = "Booking Flight Segment Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeBookingFlightSegment)).EndInit();
            this.Controls.Add(this.labelDefaultStateRefCombo);
            this.Controls.Add(this.defaultStateRefCombo);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
