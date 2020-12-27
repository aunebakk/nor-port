namespace SolutionNorSolutionPort.UserInterface
{
    partial class NorPortTesterMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NorPortTesterMain));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.buttonCall = new System.Windows.Forms.Button();
            this.buttonFlightAware = new System.Windows.Forms.Button();
            this.buttonExchange = new System.Windows.Forms.Button();
            this.buttonHide = new System.Windows.Forms.Button();
            this.buttonCheckStatus = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageScheduled = new System.Windows.Forms.TabPage();
            this.tabPageWeb = new System.Windows.Forms.TabPage();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.tabPageHistory = new System.Windows.Forms.TabPage();
            this.labelLog = new System.Windows.Forms.Label();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.timerScheduled = new System.Windows.Forms.Timer(this.components);
            this.buttonCallService = new System.Windows.Forms.Button();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.splitContainer ) ).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageWeb.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
            | System.Windows.Forms.AnchorStyles.Left )
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.CausesValidation = false;
            this.splitContainer.Panel1.Controls.Add(this.buttonCallService);
            this.splitContainer.Panel1.Controls.Add(this.buttonCall);
            this.splitContainer.Panel1.Controls.Add(this.buttonFlightAware);
            this.splitContainer.Panel1.Controls.Add(this.buttonExchange);
            this.splitContainer.Panel1.Controls.Add(this.buttonHide);
            this.splitContainer.Panel1.Controls.Add(this.buttonCheckStatus);
            this.splitContainer.Panel1.Controls.Add(this.buttonRefresh);
            this.splitContainer.Panel1.Controls.Add(this.tabControl);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.labelLog);
            this.splitContainer.Panel2.Controls.Add(this.textBoxLog);
            this.splitContainer.Size = new System.Drawing.Size(653, 408);
            this.splitContainer.SplitterDistance = 271;
            this.splitContainer.TabIndex = 0;
            // 
            // buttonCall
            // 
            this.buttonCall.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonCall.ForeColor = System.Drawing.Color.DimGray;
            this.buttonCall.Location = new System.Drawing.Point(41, 246);
            this.buttonCall.Name = "buttonCall";
            this.buttonCall.Size = new System.Drawing.Size(95, 22);
            this.buttonCall.TabIndex = 16;
            this.buttonCall.Text = "&Call";
            this.buttonCall.UseVisualStyleBackColor = true;
            this.buttonCall.Click += new System.EventHandler(this.buttonCall_Click);
            // 
            // buttonFlightAware
            // 
            this.buttonFlightAware.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonFlightAware.ForeColor = System.Drawing.Color.DimGray;
            this.buttonFlightAware.Location = new System.Drawing.Point(142, 246);
            this.buttonFlightAware.Name = "buttonFlightAware";
            this.buttonFlightAware.Size = new System.Drawing.Size(95, 22);
            this.buttonFlightAware.TabIndex = 15;
            this.buttonFlightAware.Text = "&Flight Aware";
            this.buttonFlightAware.UseVisualStyleBackColor = true;
            this.buttonFlightAware.Click += new System.EventHandler(this.buttonFlightAware_Click);
            // 
            // buttonExchange
            // 
            this.buttonExchange.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonExchange.ForeColor = System.Drawing.Color.DimGray;
            this.buttonExchange.Location = new System.Drawing.Point(243, 246);
            this.buttonExchange.Name = "buttonExchange";
            this.buttonExchange.Size = new System.Drawing.Size(95, 22);
            this.buttonExchange.TabIndex = 14;
            this.buttonExchange.Text = "&Exchange";
            this.buttonExchange.UseVisualStyleBackColor = true;
            this.buttonExchange.Click += new System.EventHandler(this.buttonExchange_Click);
            // 
            // buttonHide
            // 
            this.buttonHide.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonHide.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonHide.ForeColor = System.Drawing.Color.DimGray;
            this.buttonHide.Location = new System.Drawing.Point(546, 246);
            this.buttonHide.Name = "buttonHide";
            this.buttonHide.Size = new System.Drawing.Size(95, 22);
            this.buttonHide.TabIndex = 13;
            this.buttonHide.Text = "&Hide";
            this.buttonHide.UseVisualStyleBackColor = true;
            this.buttonHide.Click += new System.EventHandler(this.buttonHide_Click);
            // 
            // buttonCheckStatus
            // 
            this.buttonCheckStatus.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonCheckStatus.ForeColor = System.Drawing.Color.DimGray;
            this.buttonCheckStatus.Location = new System.Drawing.Point(445, 246);
            this.buttonCheckStatus.Name = "buttonCheckStatus";
            this.buttonCheckStatus.Size = new System.Drawing.Size(95, 22);
            this.buttonCheckStatus.TabIndex = 12;
            this.buttonCheckStatus.Text = "&Check Status";
            this.buttonCheckStatus.UseVisualStyleBackColor = true;
            this.buttonCheckStatus.Click += new System.EventHandler(this.buttonCheckStatus_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonRefresh.ForeColor = System.Drawing.Color.DimGray;
            this.buttonRefresh.Location = new System.Drawing.Point(344, 246);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(95, 22);
            this.buttonRefresh.TabIndex = 11;
            this.buttonRefresh.Text = "&Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
            | System.Windows.Forms.AnchorStyles.Left )
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.tabControl.Controls.Add(this.tabPageScheduled);
            this.tabControl.Controls.Add(this.tabPageWeb);
            this.tabControl.Controls.Add(this.tabPageHistory);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(629, 204);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageScheduled
            // 
            this.tabPageScheduled.Location = new System.Drawing.Point(4, 22);
            this.tabPageScheduled.Name = "tabPageScheduled";
            this.tabPageScheduled.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageScheduled.Size = new System.Drawing.Size(621, 178);
            this.tabPageScheduled.TabIndex = 0;
            this.tabPageScheduled.Text = "Scheduled";
            this.tabPageScheduled.UseVisualStyleBackColor = true;
            // 
            // tabPageWeb
            // 
            this.tabPageWeb.Controls.Add(this.webBrowser);
            this.tabPageWeb.Location = new System.Drawing.Point(4, 22);
            this.tabPageWeb.Name = "tabPageWeb";
            this.tabPageWeb.Size = new System.Drawing.Size(621, 202);
            this.tabPageWeb.TabIndex = 2;
            this.tabPageWeb.Text = "Web";
            this.tabPageWeb.UseVisualStyleBackColor = true;
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(621, 202);
            this.webBrowser.TabIndex = 0;
            // 
            // tabPageHistory
            // 
            this.tabPageHistory.Location = new System.Drawing.Point(4, 22);
            this.tabPageHistory.Name = "tabPageHistory";
            this.tabPageHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHistory.Size = new System.Drawing.Size(621, 202);
            this.tabPageHistory.TabIndex = 1;
            this.tabPageHistory.Text = "History";
            this.tabPageHistory.UseVisualStyleBackColor = true;
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Location = new System.Drawing.Point(12, 0);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(25, 13);
            this.labelLog.TabIndex = 25;
            this.labelLog.Text = "Log";
            // 
            // textBoxLog
            // 
            this.textBoxLog.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
            | System.Windows.Forms.AnchorStyles.Left )
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.textBoxLog.Location = new System.Drawing.Point(12, 16);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxLog.Size = new System.Drawing.Size(629, 105);
            this.textBoxLog.TabIndex = 24;
            // 
            // timerScheduled
            // 
            this.timerScheduled.Interval = 60000;
            this.timerScheduled.Tick += new System.EventHandler(this.timerScheduled_Tick);
            // 
            // buttonCallService
            // 
            this.buttonCallService.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonCallService.ForeColor = System.Drawing.Color.DimGray;
            this.buttonCallService.Location = new System.Drawing.Point(41, 222);
            this.buttonCallService.Name = "buttonCallService";
            this.buttonCallService.Size = new System.Drawing.Size(95, 22);
            this.buttonCallService.TabIndex = 17;
            this.buttonCallService.Text = "&Call Service";
            this.buttonCallService.UseVisualStyleBackColor = true;
            this.buttonCallService.Click += new System.EventHandler(this.buttonCallService_Click);
            // 
            // NorPortTesterMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonHide;
            this.ClientSize = new System.Drawing.Size(653, 408);
            this.Controls.Add(this.splitContainer);
            this.Icon = ( ( System.Drawing.Icon ) ( resources.GetObject("$this.Icon") ) );
            this.Name = "NorPortTesterMain";
            this.Text = "nor-port tester";
            this.Shown += new System.EventHandler(this.NorPortTester_Shown);
            this.Resize += new System.EventHandler(this.NorPortTesterMain_Resize);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.splitContainer ) ).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPageWeb.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageScheduled;
        private System.Windows.Forms.TabPage tabPageHistory;
        private System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonCheckStatus;
        private System.Windows.Forms.Button buttonHide;
        private System.Windows.Forms.Timer timerScheduled;
        private System.Windows.Forms.TabPage tabPageWeb;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button buttonExchange;
        private System.Windows.Forms.Button buttonFlightAware;
        private System.Windows.Forms.Button buttonCall;
        private System.Windows.Forms.Button buttonCallService;
    }
}

