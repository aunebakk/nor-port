namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeServiceRequestStatusRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeServiceRequestStatusRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeServiceRequestStatusRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeServiceRequestStatusRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeServiceRequestStatusRef;
        
        private System.Windows.Forms.TextBox textBoxServiceRequestStatusName;
        
        private System.Windows.Forms.Label labelServiceRequestStatusName;
        
        private System.Windows.Forms.TextBox textBoxServiceRequestStatus;
        
        private System.Windows.Forms.Label labelServiceRequestStatus;
        
        private System.Windows.Forms.TextBox textBoxDescription;
        
        private System.Windows.Forms.Label labelDescription;
        
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
            this.buttonCrudeServiceRequestStatusRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeServiceRequestStatusRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeServiceRequestStatusRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeServiceRequestStatusRef = new System.Windows.Forms.DataGridView();
            this.labelServiceRequestStatusName = new System.Windows.Forms.Label();
            this.textBoxServiceRequestStatusName = new System.Windows.Forms.TextBox();
            this.labelServiceRequestStatus = new System.Windows.Forms.Label();
            this.textBoxServiceRequestStatus = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeServiceRequestStatusRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelServiceRequestStatusName
            //
            this.labelServiceRequestStatusName.AutoSize = true;
            this.labelServiceRequestStatusName.Location = new System.Drawing.Point(11, 13);
            this.labelServiceRequestStatusName.Name = "labelServiceRequestStatusName";
            this.labelServiceRequestStatusName.Size = new System.Drawing.Size(71, 13);
            this.labelServiceRequestStatusName.TabIndex = 2;
            this.labelServiceRequestStatusName.Text = "Service Request Status Name:";
            //
            //textBoxServiceRequestStatusName
            //
            this.textBoxServiceRequestStatusName.Location = new System.Drawing.Point(189, 13);
            this.textBoxServiceRequestStatusName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxServiceRequestStatusName.Name = "textBoxServiceRequestStatusName";
            this.textBoxServiceRequestStatusName.Size = new System.Drawing.Size(250, 20);
            this.textBoxServiceRequestStatusName.TabIndex = 3;
            //
            // labelServiceRequestStatus
            //
            this.labelServiceRequestStatus.AutoSize = true;
            this.labelServiceRequestStatus.Location = new System.Drawing.Point(11, 36);
            this.labelServiceRequestStatus.Name = "labelServiceRequestStatus";
            this.labelServiceRequestStatus.Size = new System.Drawing.Size(71, 13);
            this.labelServiceRequestStatus.TabIndex = 4;
            this.labelServiceRequestStatus.Text = "Service Request Status:";
            //
            //textBoxServiceRequestStatus
            //
            this.textBoxServiceRequestStatus.Location = new System.Drawing.Point(189, 36);
            this.textBoxServiceRequestStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxServiceRequestStatus.Name = "textBoxServiceRequestStatus";
            this.textBoxServiceRequestStatus.Size = new System.Drawing.Size(250, 20);
            this.textBoxServiceRequestStatus.TabIndex = 5;
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
            this.textBoxDescription.Location = new System.Drawing.Point(189, 59);
            this.textBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(250, 20);
            this.textBoxDescription.TabIndex = 7;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(189, 82);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 9;
            // 
            // dataGridViewCrudeServiceRequestStatusRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeServiceRequestStatusRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeServiceRequestStatusRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeServiceRequestStatusRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeServiceRequestStatusRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeServiceRequestStatusRef.Location = new System.Drawing.Point(12, 115);
            this.dataGridViewCrudeServiceRequestStatusRef.Name = "dataGridViewCrudeServiceRequestStatusRef";
            this.dataGridViewCrudeServiceRequestStatusRef.Size = new System.Drawing.Size(427, 96);
            this.dataGridViewCrudeServiceRequestStatusRef.TabIndex = 0;
            this.dataGridViewCrudeServiceRequestStatusRef.ReadOnly = true;
            this.dataGridViewCrudeServiceRequestStatusRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeServiceRequestStatusRef_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(347, 218);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeServiceRequestStatusRefSearch
            // 
            this.buttonCrudeServiceRequestStatusRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeServiceRequestStatusRefSearch.Location = new System.Drawing.Point(247, 218);
            this.buttonCrudeServiceRequestStatusRefSearch.Name = "buttonCrudeServiceRequestStatusRefSearch";
            this.buttonCrudeServiceRequestStatusRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeServiceRequestStatusRefSearch.TabIndex = 2;
            this.buttonCrudeServiceRequestStatusRefSearch.Text = "&Search";
            this.buttonCrudeServiceRequestStatusRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeServiceRequestStatusRefSearch.Click += new System.EventHandler(this.buttonCrudeServiceRequestStatusRefSearch_Click);
            // 
            // buttonCrudeServiceRequestStatusRefAdd
            // 
            this.buttonCrudeServiceRequestStatusRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeServiceRequestStatusRefAdd.Location = new System.Drawing.Point(147, 218);
            this.buttonCrudeServiceRequestStatusRefAdd.Name = "buttonCrudeServiceRequestStatusRefAdd";
            this.buttonCrudeServiceRequestStatusRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeServiceRequestStatusRefAdd.TabIndex = 3;
            this.buttonCrudeServiceRequestStatusRefAdd.Text = "&Add";
            this.buttonCrudeServiceRequestStatusRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeServiceRequestStatusRefAdd.Click += new System.EventHandler(this.buttonCrudeServiceRequestStatusRefAdd_Click);
            // 
            // buttonCrudeServiceRequestStatusRefEdit
            // 
            this.buttonCrudeServiceRequestStatusRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeServiceRequestStatusRefEdit.Location = new System.Drawing.Point(47, 218);
            this.buttonCrudeServiceRequestStatusRefEdit.Name = "buttonCrudeServiceRequestStatusRefEdit";
            this.buttonCrudeServiceRequestStatusRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeServiceRequestStatusRefEdit.TabIndex = 4;
            this.buttonCrudeServiceRequestStatusRefEdit.Text = "&Edit";
            this.buttonCrudeServiceRequestStatusRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeServiceRequestStatusRefEdit.Click += new System.EventHandler(this.buttonCrudeServiceRequestStatusRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 246);
            this.Controls.Add(this.buttonCrudeServiceRequestStatusRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeServiceRequestStatusRefAdd);
            this.Controls.Add(this.buttonCrudeServiceRequestStatusRefEdit);
            this.Controls.Add(this.dataGridViewCrudeServiceRequestStatusRef);
            this.Name = "CrudeServiceRequestStatusRefSearch";
            this.Text = "Service Request Status Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeServiceRequestStatusRef)).EndInit();
            this.Controls.Add(this.labelServiceRequestStatusName);
            this.Controls.Add(this.textBoxServiceRequestStatusName);
            this.Controls.Add(this.labelServiceRequestStatus);
            this.Controls.Add(this.textBoxServiceRequestStatus);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
