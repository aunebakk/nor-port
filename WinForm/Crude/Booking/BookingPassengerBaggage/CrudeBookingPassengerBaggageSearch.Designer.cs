namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeBookingPassengerBaggageSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeBookingPassengerBaggageSearch;
        
        private System.Windows.Forms.Button buttonCrudeBookingPassengerBaggageAdd;
        
        private System.Windows.Forms.Button buttonCrudeBookingPassengerBaggageEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeBookingPassengerBaggage;
        
        private System.Windows.Forms.TextBox textBoxRemarks;
        
        private System.Windows.Forms.Label labelRemarks;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxItemCount;
        
        private System.Windows.Forms.Label labelItemCount;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxWeight;
        
        private System.Windows.Forms.Label labelWeight;
        
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
            this.buttonCrudeBookingPassengerBaggageAdd = new System.Windows.Forms.Button();
            this.buttonCrudeBookingPassengerBaggageEdit = new System.Windows.Forms.Button();
            this.buttonCrudeBookingPassengerBaggageSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeBookingPassengerBaggage = new System.Windows.Forms.DataGridView();
            this.labelRemarks = new System.Windows.Forms.Label();
            this.textBoxRemarks = new System.Windows.Forms.TextBox();
            this.labelItemCount = new System.Windows.Forms.Label();
            this.maskedTextBoxItemCount = new System.Windows.Forms.MaskedTextBox();
            this.labelWeight = new System.Windows.Forms.Label();
            this.maskedTextBoxWeight = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeBookingPassengerBaggage)).BeginInit();
            this.SuspendLayout();
            //
            // labelRemarks
            //
            this.labelRemarks.AutoSize = true;
            this.labelRemarks.Location = new System.Drawing.Point(11, 13);
            this.labelRemarks.Name = "labelRemarks";
            this.labelRemarks.Size = new System.Drawing.Size(71, 13);
            this.labelRemarks.TabIndex = 2;
            this.labelRemarks.Text = "Remarks:";
            //
            //textBoxRemarks
            //
            this.textBoxRemarks.Location = new System.Drawing.Point(140, 13);
            this.textBoxRemarks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRemarks.Name = "textBoxRemarks";
            this.textBoxRemarks.Size = new System.Drawing.Size(250, 20);
            this.textBoxRemarks.TabIndex = 3;
            //
            // labelItemCount
            //
            this.labelItemCount.AutoSize = true;
            this.labelItemCount.Location = new System.Drawing.Point(11, 36);
            this.labelItemCount.Name = "labelItemCount";
            this.labelItemCount.Size = new System.Drawing.Size(71, 13);
            this.labelItemCount.TabIndex = 4;
            this.labelItemCount.Text = "Item Count:";
            //
            //maskedTextBoxItemCount
            //
            this.maskedTextBoxItemCount.Location = new System.Drawing.Point(140, 36);
            this.maskedTextBoxItemCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxItemCount.Name = "maskedTextBoxItemCount";
            this.maskedTextBoxItemCount.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxItemCount.TabIndex = 5;
            //
            // labelWeight
            //
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(11, 59);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(71, 13);
            this.labelWeight.TabIndex = 6;
            this.labelWeight.Text = "Weight:";
            //
            //maskedTextBoxWeight
            //
            this.maskedTextBoxWeight.Location = new System.Drawing.Point(140, 59);
            this.maskedTextBoxWeight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxWeight.Name = "maskedTextBoxWeight";
            this.maskedTextBoxWeight.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxWeight.TabIndex = 7;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(140, 82);
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
            this.userPicker.Location = new System.Drawing.Point(140, 105);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 11;
            // 
            // dataGridViewCrudeBookingPassengerBaggage
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeBookingPassengerBaggage.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeBookingPassengerBaggage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeBookingPassengerBaggage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeBookingPassengerBaggage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeBookingPassengerBaggage.Location = new System.Drawing.Point(12, 138);
            this.dataGridViewCrudeBookingPassengerBaggage.Name = "dataGridViewCrudeBookingPassengerBaggage";
            this.dataGridViewCrudeBookingPassengerBaggage.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeBookingPassengerBaggage.TabIndex = 0;
            this.dataGridViewCrudeBookingPassengerBaggage.ReadOnly = true;
            this.dataGridViewCrudeBookingPassengerBaggage.DoubleClick += new System.EventHandler(this.dataGridViewCrudeBookingPassengerBaggage_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 241);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeBookingPassengerBaggageSearch
            // 
            this.buttonCrudeBookingPassengerBaggageSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeBookingPassengerBaggageSearch.Location = new System.Drawing.Point(198, 241);
            this.buttonCrudeBookingPassengerBaggageSearch.Name = "buttonCrudeBookingPassengerBaggageSearch";
            this.buttonCrudeBookingPassengerBaggageSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeBookingPassengerBaggageSearch.TabIndex = 2;
            this.buttonCrudeBookingPassengerBaggageSearch.Text = "&Search";
            this.buttonCrudeBookingPassengerBaggageSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeBookingPassengerBaggageSearch.Click += new System.EventHandler(this.buttonCrudeBookingPassengerBaggageSearch_Click);
            // 
            // buttonCrudeBookingPassengerBaggageAdd
            // 
            this.buttonCrudeBookingPassengerBaggageAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeBookingPassengerBaggageAdd.Location = new System.Drawing.Point(98, 241);
            this.buttonCrudeBookingPassengerBaggageAdd.Name = "buttonCrudeBookingPassengerBaggageAdd";
            this.buttonCrudeBookingPassengerBaggageAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeBookingPassengerBaggageAdd.TabIndex = 3;
            this.buttonCrudeBookingPassengerBaggageAdd.Text = "&Add";
            this.buttonCrudeBookingPassengerBaggageAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeBookingPassengerBaggageAdd.Click += new System.EventHandler(this.buttonCrudeBookingPassengerBaggageAdd_Click);
            // 
            // buttonCrudeBookingPassengerBaggageEdit
            // 
            this.buttonCrudeBookingPassengerBaggageEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeBookingPassengerBaggageEdit.Location = new System.Drawing.Point(-2, 241);
            this.buttonCrudeBookingPassengerBaggageEdit.Name = "buttonCrudeBookingPassengerBaggageEdit";
            this.buttonCrudeBookingPassengerBaggageEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeBookingPassengerBaggageEdit.TabIndex = 4;
            this.buttonCrudeBookingPassengerBaggageEdit.Text = "&Edit";
            this.buttonCrudeBookingPassengerBaggageEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeBookingPassengerBaggageEdit.Click += new System.EventHandler(this.buttonCrudeBookingPassengerBaggageEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 269);
            this.Controls.Add(this.buttonCrudeBookingPassengerBaggageSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeBookingPassengerBaggageAdd);
            this.Controls.Add(this.buttonCrudeBookingPassengerBaggageEdit);
            this.Controls.Add(this.dataGridViewCrudeBookingPassengerBaggage);
            this.Name = "CrudeBookingPassengerBaggageSearch";
            this.Text = "Booking Passenger Baggage Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeBookingPassengerBaggage)).EndInit();
            this.Controls.Add(this.labelRemarks);
            this.Controls.Add(this.textBoxRemarks);
            this.Controls.Add(this.labelItemCount);
            this.Controls.Add(this.maskedTextBoxItemCount);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.maskedTextBoxWeight);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
