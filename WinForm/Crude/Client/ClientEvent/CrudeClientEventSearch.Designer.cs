namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeClientEventSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeClientEventSearch;
        
        private System.Windows.Forms.Button buttonCrudeClientEventAdd;
        
        private System.Windows.Forms.Button buttonCrudeClientEventEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeClientEvent;
        
        private ClientEventTypeRefCombo clientEventTypeRefCombo;
        
        private System.Windows.Forms.Label labelClientEventTypeRefCombo;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        private ClientPicker clientPicker;
        
        private System.Windows.Forms.Label labelClientPicker;
        
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
            this.buttonCrudeClientEventAdd = new System.Windows.Forms.Button();
            this.buttonCrudeClientEventEdit = new System.Windows.Forms.Button();
            this.buttonCrudeClientEventSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeClientEvent = new System.Windows.Forms.DataGridView();
            this.labelClientEventTypeRefCombo = new System.Windows.Forms.Label();
            this.clientEventTypeRefCombo = new ClientEventTypeRefCombo();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelClientPicker = new System.Windows.Forms.Label();
            this.clientPicker = new ClientPicker();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeClientEvent)).BeginInit();
            this.SuspendLayout();
            //
            // labelClientEventTypeRefCombo
            //
            this.labelClientEventTypeRefCombo.AutoSize = true;
            this.labelClientEventTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelClientEventTypeRefCombo.Name = "labelClientEventTypeRefCombo";
            this.labelClientEventTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelClientEventTypeRefCombo.TabIndex = 2;
            this.labelClientEventTypeRefCombo.Text = "Client Event Type:";
            //
            //clientEventTypeRefCombo
            //
            this.clientEventTypeRefCombo.Location = new System.Drawing.Point(140, 13);
            this.clientEventTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.clientEventTypeRefCombo.Name = "clientEventTypeRefCombo";
            this.clientEventTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.clientEventTypeRefCombo.TabIndex = 3;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(140, 36);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 5;
            //
            // labelClientPicker
            //
            this.labelClientPicker.AutoSize = true;
            this.labelClientPicker.Location = new System.Drawing.Point(11, 59);
            this.labelClientPicker.Name = "labelClientPicker";
            this.labelClientPicker.Size = new System.Drawing.Size(71, 13);
            this.labelClientPicker.TabIndex = 6;
            this.labelClientPicker.Text = "Client:";
            //
            //clientPicker
            //
            this.clientPicker.Location = new System.Drawing.Point(140, 59);
            this.clientPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.clientPicker.Name = "clientPicker";
            this.clientPicker.Size = new System.Drawing.Size(250, 20);
            this.clientPicker.TabIndex = 7;
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
            // dataGridViewCrudeClientEvent
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeClientEvent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeClientEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeClientEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeClientEvent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeClientEvent.Location = new System.Drawing.Point(12, 115);
            this.dataGridViewCrudeClientEvent.Name = "dataGridViewCrudeClientEvent";
            this.dataGridViewCrudeClientEvent.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeClientEvent.TabIndex = 0;
            this.dataGridViewCrudeClientEvent.ReadOnly = true;
            this.dataGridViewCrudeClientEvent.DoubleClick += new System.EventHandler(this.dataGridViewCrudeClientEvent_DoubleClick);
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
            // buttonCrudeClientEventSearch
            // 
            this.buttonCrudeClientEventSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeClientEventSearch.Location = new System.Drawing.Point(198, 218);
            this.buttonCrudeClientEventSearch.Name = "buttonCrudeClientEventSearch";
            this.buttonCrudeClientEventSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeClientEventSearch.TabIndex = 2;
            this.buttonCrudeClientEventSearch.Text = "&Search";
            this.buttonCrudeClientEventSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeClientEventSearch.Click += new System.EventHandler(this.buttonCrudeClientEventSearch_Click);
            // 
            // buttonCrudeClientEventAdd
            // 
            this.buttonCrudeClientEventAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeClientEventAdd.Location = new System.Drawing.Point(98, 218);
            this.buttonCrudeClientEventAdd.Name = "buttonCrudeClientEventAdd";
            this.buttonCrudeClientEventAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeClientEventAdd.TabIndex = 3;
            this.buttonCrudeClientEventAdd.Text = "&Add";
            this.buttonCrudeClientEventAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeClientEventAdd.Click += new System.EventHandler(this.buttonCrudeClientEventAdd_Click);
            // 
            // buttonCrudeClientEventEdit
            // 
            this.buttonCrudeClientEventEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeClientEventEdit.Location = new System.Drawing.Point(-2, 218);
            this.buttonCrudeClientEventEdit.Name = "buttonCrudeClientEventEdit";
            this.buttonCrudeClientEventEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeClientEventEdit.TabIndex = 4;
            this.buttonCrudeClientEventEdit.Text = "&Edit";
            this.buttonCrudeClientEventEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeClientEventEdit.Click += new System.EventHandler(this.buttonCrudeClientEventEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 246);
            this.Controls.Add(this.buttonCrudeClientEventSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeClientEventAdd);
            this.Controls.Add(this.buttonCrudeClientEventEdit);
            this.Controls.Add(this.dataGridViewCrudeClientEvent);
            this.Name = "CrudeClientEventSearch";
            this.Text = "Client Event Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeClientEvent)).EndInit();
            this.Controls.Add(this.labelClientEventTypeRefCombo);
            this.Controls.Add(this.clientEventTypeRefCombo);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelClientPicker);
            this.Controls.Add(this.clientPicker);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
