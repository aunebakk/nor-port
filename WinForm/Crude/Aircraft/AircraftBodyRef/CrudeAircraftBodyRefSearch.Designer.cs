namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeAircraftBodyRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeAircraftBodyRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeAircraftBodyRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeAircraftBodyRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeAircraftBodyRef;
        
        private System.Windows.Forms.TextBox textBoxAircraftBodyName;
        
        private System.Windows.Forms.Label labelAircraftBodyName;
        
        private System.Windows.Forms.TextBox textBoxAircraftBody;
        
        private System.Windows.Forms.Label labelAircraftBody;
        
        private System.Windows.Forms.TextBox textBoxDescription;
        
        private System.Windows.Forms.Label labelDescription;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSortOrder;
        
        private System.Windows.Forms.Label labelSortOrder;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        private System.Windows.Forms.CheckBox checkBoxActiveFlag;
        
        private System.Windows.Forms.Label labelActiveFlag;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonCrudeAircraftBodyRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeAircraftBodyRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeAircraftBodyRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeAircraftBodyRef = new System.Windows.Forms.DataGridView();
            this.labelAircraftBodyName = new System.Windows.Forms.Label();
            this.textBoxAircraftBodyName = new System.Windows.Forms.TextBox();
            this.labelAircraftBody = new System.Windows.Forms.Label();
            this.textBoxAircraftBody = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelSortOrder = new System.Windows.Forms.Label();
            this.maskedTextBoxSortOrder = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelActiveFlag = new System.Windows.Forms.Label();
            this.checkBoxActiveFlag = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAircraftBodyRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelAircraftBodyName
            //
            this.labelAircraftBodyName.AutoSize = true;
            this.labelAircraftBodyName.Location = new System.Drawing.Point(11, 13);
            this.labelAircraftBodyName.Name = "labelAircraftBodyName";
            this.labelAircraftBodyName.Size = new System.Drawing.Size(71, 13);
            this.labelAircraftBodyName.TabIndex = 2;
            this.labelAircraftBodyName.Text = "Aircraft Body Name:";
            //
            //textBoxAircraftBodyName
            //
            this.textBoxAircraftBodyName.Location = new System.Drawing.Point(140, 13);
            this.textBoxAircraftBodyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAircraftBodyName.Name = "textBoxAircraftBodyName";
            this.textBoxAircraftBodyName.Size = new System.Drawing.Size(250, 20);
            this.textBoxAircraftBodyName.TabIndex = 3;
            //
            // labelAircraftBody
            //
            this.labelAircraftBody.AutoSize = true;
            this.labelAircraftBody.Location = new System.Drawing.Point(11, 36);
            this.labelAircraftBody.Name = "labelAircraftBody";
            this.labelAircraftBody.Size = new System.Drawing.Size(71, 13);
            this.labelAircraftBody.TabIndex = 4;
            this.labelAircraftBody.Text = "Aircraft Body:";
            //
            //textBoxAircraftBody
            //
            this.textBoxAircraftBody.Location = new System.Drawing.Point(140, 36);
            this.textBoxAircraftBody.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAircraftBody.Name = "textBoxAircraftBody";
            this.textBoxAircraftBody.Size = new System.Drawing.Size(250, 20);
            this.textBoxAircraftBody.TabIndex = 5;
            //
            // labelDescription
            //
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(11, 59);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(71, 13);
            this.labelDescription.TabIndex = 6;
            this.labelDescription.Text = "Description:";
            //
            //textBoxDescription
            //
            this.textBoxDescription.Location = new System.Drawing.Point(140, 59);
            this.textBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(250, 20);
            this.textBoxDescription.TabIndex = 7;
            //
            // labelSortOrder
            //
            this.labelSortOrder.AutoSize = true;
            this.labelSortOrder.Location = new System.Drawing.Point(11, 82);
            this.labelSortOrder.Name = "labelSortOrder";
            this.labelSortOrder.Size = new System.Drawing.Size(71, 13);
            this.labelSortOrder.TabIndex = 8;
            this.labelSortOrder.Text = "Sort Order:";
            //
            //maskedTextBoxSortOrder
            //
            this.maskedTextBoxSortOrder.Location = new System.Drawing.Point(140, 82);
            this.maskedTextBoxSortOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxSortOrder.Name = "maskedTextBoxSortOrder";
            this.maskedTextBoxSortOrder.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxSortOrder.TabIndex = 9;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(140, 105);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 11;
            //
            // labelActiveFlag
            //
            this.labelActiveFlag.AutoSize = true;
            this.labelActiveFlag.Location = new System.Drawing.Point(11, 128);
            this.labelActiveFlag.Name = "labelActiveFlag";
            this.labelActiveFlag.Size = new System.Drawing.Size(71, 13);
            this.labelActiveFlag.TabIndex = 12;
            this.labelActiveFlag.Text = "Active Flag:";
            //
            //checkBoxActiveFlag
            //
            this.checkBoxActiveFlag.Location = new System.Drawing.Point(140, 128);
            this.checkBoxActiveFlag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxActiveFlag.Name = "checkBoxActiveFlag";
            this.checkBoxActiveFlag.Size = new System.Drawing.Size(250, 20);
            this.checkBoxActiveFlag.TabIndex = 13;
            // 
            // dataGridViewCrudeAircraftBodyRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeAircraftBodyRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeAircraftBodyRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeAircraftBodyRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeAircraftBodyRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeAircraftBodyRef.Location = new System.Drawing.Point(12, 161);
            this.dataGridViewCrudeAircraftBodyRef.Name = "dataGridViewCrudeAircraftBodyRef";
            this.dataGridViewCrudeAircraftBodyRef.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeAircraftBodyRef.TabIndex = 0;
            this.dataGridViewCrudeAircraftBodyRef.ReadOnly = true;
            this.dataGridViewCrudeAircraftBodyRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeAircraftBodyRef_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 264);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeAircraftBodyRefSearch
            // 
            this.buttonCrudeAircraftBodyRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAircraftBodyRefSearch.Location = new System.Drawing.Point(198, 264);
            this.buttonCrudeAircraftBodyRefSearch.Name = "buttonCrudeAircraftBodyRefSearch";
            this.buttonCrudeAircraftBodyRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAircraftBodyRefSearch.TabIndex = 2;
            this.buttonCrudeAircraftBodyRefSearch.Text = "&Search";
            this.buttonCrudeAircraftBodyRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeAircraftBodyRefSearch.Click += new System.EventHandler(this.buttonCrudeAircraftBodyRefSearch_Click);
            // 
            // buttonCrudeAircraftBodyRefAdd
            // 
            this.buttonCrudeAircraftBodyRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAircraftBodyRefAdd.Location = new System.Drawing.Point(98, 264);
            this.buttonCrudeAircraftBodyRefAdd.Name = "buttonCrudeAircraftBodyRefAdd";
            this.buttonCrudeAircraftBodyRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAircraftBodyRefAdd.TabIndex = 3;
            this.buttonCrudeAircraftBodyRefAdd.Text = "&Add";
            this.buttonCrudeAircraftBodyRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeAircraftBodyRefAdd.Click += new System.EventHandler(this.buttonCrudeAircraftBodyRefAdd_Click);
            // 
            // buttonCrudeAircraftBodyRefEdit
            // 
            this.buttonCrudeAircraftBodyRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAircraftBodyRefEdit.Location = new System.Drawing.Point(-2, 264);
            this.buttonCrudeAircraftBodyRefEdit.Name = "buttonCrudeAircraftBodyRefEdit";
            this.buttonCrudeAircraftBodyRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAircraftBodyRefEdit.TabIndex = 4;
            this.buttonCrudeAircraftBodyRefEdit.Text = "&Edit";
            this.buttonCrudeAircraftBodyRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeAircraftBodyRefEdit.Click += new System.EventHandler(this.buttonCrudeAircraftBodyRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 292);
            this.Controls.Add(this.buttonCrudeAircraftBodyRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeAircraftBodyRefAdd);
            this.Controls.Add(this.buttonCrudeAircraftBodyRefEdit);
            this.Controls.Add(this.dataGridViewCrudeAircraftBodyRef);
            this.Name = "CrudeAircraftBodyRefSearch";
            this.Text = "Aircraft Body Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAircraftBodyRef)).EndInit();
            this.Controls.Add(this.labelAircraftBodyName);
            this.Controls.Add(this.textBoxAircraftBodyName);
            this.Controls.Add(this.labelAircraftBody);
            this.Controls.Add(this.textBoxAircraftBody);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelSortOrder);
            this.Controls.Add(this.maskedTextBoxSortOrder);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelActiveFlag);
            this.Controls.Add(this.checkBoxActiveFlag);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
