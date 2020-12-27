namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeFerryTypeRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxFerryType;
        
        private System.Windows.Forms.Label labelFerryType;
        
        private System.Windows.Forms.TextBox textBoxFerryTypeName;
        
        private System.Windows.Forms.Label labelFerryTypeName;
        
        private System.Windows.Forms.TextBox textBoxState;
        
        private System.Windows.Forms.Label labelState;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelFerryType = new System.Windows.Forms.Label();
            this.textBoxFerryType = new System.Windows.Forms.TextBox();
            this.labelFerryTypeName = new System.Windows.Forms.Label();
            this.textBoxFerryTypeName = new System.Windows.Forms.TextBox();
            this.labelState = new System.Windows.Forms.Label();
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelFerryType
            //
            this.labelFerryType.AutoSize = true;
            this.labelFerryType.Location = new System.Drawing.Point(11, 13);
            this.labelFerryType.Name = "labelFerryType";
            this.labelFerryType.Size = new System.Drawing.Size(71, 13);
            this.labelFerryType.TabIndex = 2;
            this.labelFerryType.Text = "Ferry Type:";
            //
            //textBoxFerryType
            //
            this.textBoxFerryType.Location = new System.Drawing.Point(140, 13);
            this.textBoxFerryType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFerryType.Name = "textBoxFerryType";
            this.textBoxFerryType.Size = new System.Drawing.Size(250, 20);
            this.textBoxFerryType.TabIndex = 3;
            //
            // labelFerryTypeName
            //
            this.labelFerryTypeName.AutoSize = true;
            this.labelFerryTypeName.Location = new System.Drawing.Point(11, 36);
            this.labelFerryTypeName.Name = "labelFerryTypeName";
            this.labelFerryTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelFerryTypeName.TabIndex = 4;
            this.labelFerryTypeName.Text = "Ferry Type Name:";
            //
            //textBoxFerryTypeName
            //
            this.textBoxFerryTypeName.Location = new System.Drawing.Point(140, 36);
            this.textBoxFerryTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFerryTypeName.Name = "textBoxFerryTypeName";
            this.textBoxFerryTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxFerryTypeName.TabIndex = 5;
            //
            // labelState
            //
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(11, 59);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(71, 13);
            this.labelState.TabIndex = 6;
            this.labelState.Text = "State:";
            //
            //textBoxState
            //
            this.textBoxState.Location = new System.Drawing.Point(140, 59);
            this.textBoxState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.Size = new System.Drawing.Size(250, 20);
            this.textBoxState.TabIndex = 7;
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
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 105);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(198, 105);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(92, 22);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "&Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // EditForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 133);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeFerryTypeRefEdit";
            this.Text = "Ferry Type Ref Edit";
            this.Controls.Add(this.labelFerryType);
            this.Controls.Add(this.textBoxFerryType);
            this.Controls.Add(this.labelFerryTypeName);
            this.Controls.Add(this.textBoxFerryTypeName);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.textBoxState);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
