namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeTimezoneSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeTimezoneSearch;
        
        private System.Windows.Forms.Button buttonCrudeTimezoneAdd;
        
        private System.Windows.Forms.Button buttonCrudeTimezoneEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeTimezone;
        
        private System.Windows.Forms.TextBox textBoxTimezoneName;
        
        private System.Windows.Forms.Label labelTimezoneName;
        
        private System.Windows.Forms.TextBox textBoxUtcOffset;
        
        private System.Windows.Forms.Label labelUtcOffset;
        
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
            this.buttonCrudeTimezoneAdd = new System.Windows.Forms.Button();
            this.buttonCrudeTimezoneEdit = new System.Windows.Forms.Button();
            this.buttonCrudeTimezoneSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeTimezone = new System.Windows.Forms.DataGridView();
            this.labelTimezoneName = new System.Windows.Forms.Label();
            this.textBoxTimezoneName = new System.Windows.Forms.TextBox();
            this.labelUtcOffset = new System.Windows.Forms.Label();
            this.textBoxUtcOffset = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeTimezone)).BeginInit();
            this.SuspendLayout();
            //
            // labelTimezoneName
            //
            this.labelTimezoneName.AutoSize = true;
            this.labelTimezoneName.Location = new System.Drawing.Point(11, 13);
            this.labelTimezoneName.Name = "labelTimezoneName";
            this.labelTimezoneName.Size = new System.Drawing.Size(71, 13);
            this.labelTimezoneName.TabIndex = 2;
            this.labelTimezoneName.Text = "Timezone Name:";
            //
            //textBoxTimezoneName
            //
            this.textBoxTimezoneName.Location = new System.Drawing.Point(140, 13);
            this.textBoxTimezoneName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTimezoneName.Name = "textBoxTimezoneName";
            this.textBoxTimezoneName.Size = new System.Drawing.Size(250, 20);
            this.textBoxTimezoneName.TabIndex = 3;
            //
            // labelUtcOffset
            //
            this.labelUtcOffset.AutoSize = true;
            this.labelUtcOffset.Location = new System.Drawing.Point(11, 36);
            this.labelUtcOffset.Name = "labelUtcOffset";
            this.labelUtcOffset.Size = new System.Drawing.Size(71, 13);
            this.labelUtcOffset.TabIndex = 4;
            this.labelUtcOffset.Text = "Utc Offset:";
            //
            //textBoxUtcOffset
            //
            this.textBoxUtcOffset.Location = new System.Drawing.Point(140, 36);
            this.textBoxUtcOffset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUtcOffset.Name = "textBoxUtcOffset";
            this.textBoxUtcOffset.Size = new System.Drawing.Size(250, 20);
            this.textBoxUtcOffset.TabIndex = 5;
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
            // dataGridViewCrudeTimezone
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeTimezone.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeTimezone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeTimezone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeTimezone.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeTimezone.Location = new System.Drawing.Point(12, 115);
            this.dataGridViewCrudeTimezone.Name = "dataGridViewCrudeTimezone";
            this.dataGridViewCrudeTimezone.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeTimezone.TabIndex = 0;
            this.dataGridViewCrudeTimezone.ReadOnly = true;
            this.dataGridViewCrudeTimezone.DoubleClick += new System.EventHandler(this.dataGridViewCrudeTimezone_DoubleClick);
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
            // buttonCrudeTimezoneSearch
            // 
            this.buttonCrudeTimezoneSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeTimezoneSearch.Location = new System.Drawing.Point(198, 218);
            this.buttonCrudeTimezoneSearch.Name = "buttonCrudeTimezoneSearch";
            this.buttonCrudeTimezoneSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeTimezoneSearch.TabIndex = 2;
            this.buttonCrudeTimezoneSearch.Text = "&Search";
            this.buttonCrudeTimezoneSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeTimezoneSearch.Click += new System.EventHandler(this.buttonCrudeTimezoneSearch_Click);
            // 
            // buttonCrudeTimezoneAdd
            // 
            this.buttonCrudeTimezoneAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeTimezoneAdd.Location = new System.Drawing.Point(98, 218);
            this.buttonCrudeTimezoneAdd.Name = "buttonCrudeTimezoneAdd";
            this.buttonCrudeTimezoneAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeTimezoneAdd.TabIndex = 3;
            this.buttonCrudeTimezoneAdd.Text = "&Add";
            this.buttonCrudeTimezoneAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeTimezoneAdd.Click += new System.EventHandler(this.buttonCrudeTimezoneAdd_Click);
            // 
            // buttonCrudeTimezoneEdit
            // 
            this.buttonCrudeTimezoneEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeTimezoneEdit.Location = new System.Drawing.Point(-2, 218);
            this.buttonCrudeTimezoneEdit.Name = "buttonCrudeTimezoneEdit";
            this.buttonCrudeTimezoneEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeTimezoneEdit.TabIndex = 4;
            this.buttonCrudeTimezoneEdit.Text = "&Edit";
            this.buttonCrudeTimezoneEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeTimezoneEdit.Click += new System.EventHandler(this.buttonCrudeTimezoneEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 246);
            this.Controls.Add(this.buttonCrudeTimezoneSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeTimezoneAdd);
            this.Controls.Add(this.buttonCrudeTimezoneEdit);
            this.Controls.Add(this.dataGridViewCrudeTimezone);
            this.Name = "CrudeTimezoneSearch";
            this.Text = "Timezone Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeTimezone)).EndInit();
            this.Controls.Add(this.labelTimezoneName);
            this.Controls.Add(this.textBoxTimezoneName);
            this.Controls.Add(this.labelUtcOffset);
            this.Controls.Add(this.textBoxUtcOffset);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
