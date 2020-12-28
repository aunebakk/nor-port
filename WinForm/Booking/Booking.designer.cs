namespace SolutionNorSolutionPort.UserInterface
{
    partial class Booking
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonBook = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageBasics = new System.Windows.Forms.TabPage();
            this.labelFinancialCurrencyPicker = new System.Windows.Forms.Label();
            this.financialCurrencyPicker = new SolutionNorSolutionPort.UserInterface.FinancialCurrencyLivePicker();
            this.labelFinancialCostcentrePicker = new System.Windows.Forms.Label();
            this.financialCostcentrePicker = new SolutionNorSolutionPort.UserInterface.FinancialCostcentrePicker();
            this.labelLocator = new System.Windows.Forms.Label();
            this.textBoxLocator = new System.Windows.Forms.TextBox();
            this.labelReceivedFrom = new System.Windows.Forms.Label();
            this.textBoxReceivedFrom = new System.Windows.Forms.TextBox();
            this.labelBookingSourceRefCombo = new System.Windows.Forms.Label();
            this.bookingSourceRefCombo = new SolutionNorSolutionPort.UserInterface.BookingSourceRefCombo();
            this.labelExternalSystemPicker = new System.Windows.Forms.Label();
            this.externalSystemPicker = new SolutionNorSolutionPort.UserInterface.ExternalSystemPicker();
            this.labelAgencyPicker = new System.Windows.Forms.Label();
            this.agencyPicker = new SolutionNorSolutionPort.UserInterface.AgencyPicker();
            this.labelComment = new System.Windows.Forms.Label();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new SolutionNorSolutionPort.UserInterface.DefaultUserPicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.tabPageContact = new System.Windows.Forms.TabPage();
            this.buttonCrudeBookingContactMethodSearch = new System.Windows.Forms.Button();
            this.buttonCrudeBookingContactMethodAdd = new System.Windows.Forms.Button();
            this.buttonCrudeBookingContactMethodEdit = new System.Windows.Forms.Button();
            this.dataGridViewCrudeBookingContactMethod = new System.Windows.Forms.DataGridView();
            this.tabPageAddress = new System.Windows.Forms.TabPage();
            this.buttonAddressSave = new System.Windows.Forms.Button();
            this.labelState = new System.Windows.Forms.Label();
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.labelDistrict = new System.Windows.Forms.Label();
            this.textBoxDistrict = new System.Windows.Forms.TextBox();
            this.labelProvince = new System.Windows.Forms.Label();
            this.textBoxProvince = new System.Windows.Forms.TextBox();
            this.labelZipCode = new System.Windows.Forms.Label();
            this.textBoxZipCode = new System.Windows.Forms.TextBox();
            this.labelPoBox = new System.Windows.Forms.Label();
            this.textBoxPoBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelAddressTypeRefCombo = new System.Windows.Forms.Label();
            this.labelAddressOne = new System.Windows.Forms.Label();
            this.textBoxAddressOne = new System.Windows.Forms.TextBox();
            this.labelAddressTwo = new System.Windows.Forms.Label();
            this.textBoxAddressTwo = new System.Windows.Forms.TextBox();
            this.labelAddressThree = new System.Windows.Forms.Label();
            this.textBoxAddressThree = new System.Windows.Forms.TextBox();
            this.addressTypeRefCombo = new SolutionNorSolutionPort.UserInterface.AddressTypeRefCombo();
            this.tabPagePassengers = new System.Windows.Forms.TabPage();
            this.dataGridViewBookingPassengers = new System.Windows.Forms.DataGridView();
            this.buttonCrudeBookingPassengerSearch = new System.Windows.Forms.Button();
            this.buttonCrudeBookingPassengerAdd = new System.Windows.Forms.Button();
            this.buttonCrudeBookingPassengerEdit = new System.Windows.Forms.Button();
            this.tabPageItinerary = new System.Windows.Forms.TabPage();
            this.buttonCrudeBookingFlightSegmentSearch = new System.Windows.Forms.Button();
            this.buttonCrudeBookingFlightSegmentAdd = new System.Windows.Forms.Button();
            this.buttonCrudeBookingFlightSegmentRemove = new System.Windows.Forms.Button();
            this.dataGridViewBookingFlights = new System.Windows.Forms.DataGridView();
            this.tabPageServiceRequest = new System.Windows.Forms.TabPage();
            this.buttonServiceCarAdd = new System.Windows.Forms.Button();
            this.buttonServiceAddHotel = new System.Windows.Forms.Button();
            this.durianFinancialServiceDetailsForBooking = new SolutionNorSolutionPort.UserInterface.FinancialServiceDetailsForBookingDurian();
            this.buttonCrudeServiceSpecialServiceRequestSearch = new System.Windows.Forms.Button();
            this.buttonCrudeServiceSpecialServiceRequestAdd = new System.Windows.Forms.Button();
            this.buttonCrudeServiceSpecialServiceRequestRemove = new System.Windows.Forms.Button();
            this.tabPagePayments = new System.Windows.Forms.TabPage();
            this.dataGridViewBookingFinancialPayments = new System.Windows.Forms.DataGridView();
            this.buttonCrudeFinancialPaymentSearch = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialPaymentAdd = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialPaymentEdit = new System.Windows.Forms.Button();
            this.tabPageTransactions = new System.Windows.Forms.TabPage();
            this.dataGridViewBookingFinancialTransactions = new System.Windows.Forms.DataGridView();
            this.tabPageHistory = new System.Windows.Forms.TabPage();
            this.dataGridViewBookingEventHistory = new System.Windows.Forms.DataGridView();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPageBasics.SuspendLayout();
            this.tabPageContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeBookingContactMethod)).BeginInit();
            this.tabPageAddress.SuspendLayout();
            this.tabPagePassengers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookingPassengers)).BeginInit();
            this.tabPageItinerary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookingFlights)).BeginInit();
            this.tabPageServiceRequest.SuspendLayout();
            this.tabPagePayments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookingFinancialPayments)).BeginInit();
            this.tabPageTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookingFinancialTransactions)).BeginInit();
            this.tabPageHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookingEventHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBook
            // 
            this.buttonBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBook.Location = new System.Drawing.Point(570, 344);
            this.buttonBook.Name = "buttonBook";
            this.buttonBook.Size = new System.Drawing.Size(75, 23);
            this.buttonBook.TabIndex = 0;
            this.buttonBook.Text = "&Save";
            this.buttonBook.UseVisualStyleBackColor = true;
            this.buttonBook.Click += new System.EventHandler(this.buttonBook_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(651, 344);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageBasics);
            this.tabControl.Controls.Add(this.tabPageContact);
            this.tabControl.Controls.Add(this.tabPageAddress);
            this.tabControl.Controls.Add(this.tabPagePassengers);
            this.tabControl.Controls.Add(this.tabPageItinerary);
            this.tabControl.Controls.Add(this.tabPageServiceRequest);
            this.tabControl.Controls.Add(this.tabPagePayments);
            this.tabControl.Controls.Add(this.tabPageTransactions);
            this.tabControl.Controls.Add(this.tabPageHistory);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(714, 326);
            this.tabControl.TabIndex = 5;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            this.tabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl_Selecting);
            // 
            // tabPageBasics
            // 
            this.tabPageBasics.Controls.Add(this.labelFinancialCurrencyPicker);
            this.tabPageBasics.Controls.Add(this.financialCurrencyPicker);
            this.tabPageBasics.Controls.Add(this.labelFinancialCostcentrePicker);
            this.tabPageBasics.Controls.Add(this.financialCostcentrePicker);
            this.tabPageBasics.Controls.Add(this.labelLocator);
            this.tabPageBasics.Controls.Add(this.textBoxLocator);
            this.tabPageBasics.Controls.Add(this.labelReceivedFrom);
            this.tabPageBasics.Controls.Add(this.textBoxReceivedFrom);
            this.tabPageBasics.Controls.Add(this.labelBookingSourceRefCombo);
            this.tabPageBasics.Controls.Add(this.bookingSourceRefCombo);
            this.tabPageBasics.Controls.Add(this.labelExternalSystemPicker);
            this.tabPageBasics.Controls.Add(this.externalSystemPicker);
            this.tabPageBasics.Controls.Add(this.labelAgencyPicker);
            this.tabPageBasics.Controls.Add(this.agencyPicker);
            this.tabPageBasics.Controls.Add(this.labelComment);
            this.tabPageBasics.Controls.Add(this.textBoxComment);
            this.tabPageBasics.Controls.Add(this.labelUserPicker);
            this.tabPageBasics.Controls.Add(this.userPicker);
            this.tabPageBasics.Controls.Add(this.labelDateTime);
            this.tabPageBasics.Controls.Add(this.dateTimePickerDateTime);
            this.tabPageBasics.Location = new System.Drawing.Point(4, 22);
            this.tabPageBasics.Name = "tabPageBasics";
            this.tabPageBasics.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBasics.Size = new System.Drawing.Size(706, 300);
            this.tabPageBasics.TabIndex = 0;
            this.tabPageBasics.Text = "Basics";
            this.tabPageBasics.UseVisualStyleBackColor = true;
            this.tabPageBasics.Leave += new System.EventHandler(this.tabPageBasics_Leave);
            // 
            // labelFinancialCurrencyPicker
            // 
            this.labelFinancialCurrencyPicker.AutoSize = true;
            this.labelFinancialCurrencyPicker.Location = new System.Drawing.Point(5, 58);
            this.labelFinancialCurrencyPicker.Name = "labelFinancialCurrencyPicker";
            this.labelFinancialCurrencyPicker.Size = new System.Drawing.Size(97, 13);
            this.labelFinancialCurrencyPicker.TabIndex = 32;
            this.labelFinancialCurrencyPicker.Text = "Financial Currency:";
            // 
            // financialCurrencyPicker
            // 
            this.financialCurrencyPicker.Location = new System.Drawing.Point(134, 56);
            this.financialCurrencyPicker.Name = "financialCurrencyPicker";
            this.financialCurrencyPicker.SelectedValue = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.financialCurrencyPicker.Size = new System.Drawing.Size(255, 21);
            this.financialCurrencyPicker.TabIndex = 33;
            // 
            // labelFinancialCostcentrePicker
            // 
            this.labelFinancialCostcentrePicker.AutoSize = true;
            this.labelFinancialCostcentrePicker.Location = new System.Drawing.Point(394, 58);
            this.labelFinancialCostcentrePicker.Name = "labelFinancialCostcentrePicker";
            this.labelFinancialCostcentrePicker.Size = new System.Drawing.Size(106, 13);
            this.labelFinancialCostcentrePicker.TabIndex = 34;
            this.labelFinancialCostcentrePicker.Text = "Financial Costcentre:";
            // 
            // financialCostcentrePicker
            // 
            this.financialCostcentrePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.financialCostcentrePicker.Location = new System.Drawing.Point(511, 56);
            this.financialCostcentrePicker.Name = "financialCostcentrePicker";
            this.financialCostcentrePicker.SelectedValue = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.financialCostcentrePicker.Size = new System.Drawing.Size(189, 20);
            this.financialCostcentrePicker.TabIndex = 35;
            // 
            // labelLocator
            // 
            this.labelLocator.AutoSize = true;
            this.labelLocator.Location = new System.Drawing.Point(5, 6);
            this.labelLocator.Name = "labelLocator";
            this.labelLocator.Size = new System.Drawing.Size(46, 13);
            this.labelLocator.TabIndex = 30;
            this.labelLocator.Text = "Locator:";
            // 
            // textBoxLocator
            // 
            this.textBoxLocator.Location = new System.Drawing.Point(134, 6);
            this.textBoxLocator.Name = "textBoxLocator";
            this.textBoxLocator.Size = new System.Drawing.Size(255, 20);
            this.textBoxLocator.TabIndex = 31;
            // 
            // labelReceivedFrom
            // 
            this.labelReceivedFrom.AutoSize = true;
            this.labelReceivedFrom.Location = new System.Drawing.Point(394, 32);
            this.labelReceivedFrom.Name = "labelReceivedFrom";
            this.labelReceivedFrom.Size = new System.Drawing.Size(82, 13);
            this.labelReceivedFrom.TabIndex = 16;
            this.labelReceivedFrom.Text = "Received From:";
            // 
            // textBoxReceivedFrom
            // 
            this.textBoxReceivedFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxReceivedFrom.Location = new System.Drawing.Point(511, 32);
            this.textBoxReceivedFrom.Name = "textBoxReceivedFrom";
            this.textBoxReceivedFrom.Size = new System.Drawing.Size(189, 20);
            this.textBoxReceivedFrom.TabIndex = 17;
            // 
            // labelBookingSourceRefCombo
            // 
            this.labelBookingSourceRefCombo.AutoSize = true;
            this.labelBookingSourceRefCombo.Location = new System.Drawing.Point(394, 6);
            this.labelBookingSourceRefCombo.Name = "labelBookingSourceRefCombo";
            this.labelBookingSourceRefCombo.Size = new System.Drawing.Size(86, 13);
            this.labelBookingSourceRefCombo.TabIndex = 18;
            this.labelBookingSourceRefCombo.Text = "Booking Source:";
            // 
            // bookingSourceRefCombo
            // 
            this.bookingSourceRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookingSourceRefCombo.Location = new System.Drawing.Point(511, 6);
            this.bookingSourceRefCombo.Name = "bookingSourceRefCombo";
            this.bookingSourceRefCombo.Size = new System.Drawing.Size(189, 21);
            this.bookingSourceRefCombo.TabIndex = 19;
            // 
            // labelExternalSystemPicker
            // 
            this.labelExternalSystemPicker.AutoSize = true;
            this.labelExternalSystemPicker.Location = new System.Drawing.Point(5, 32);
            this.labelExternalSystemPicker.Name = "labelExternalSystemPicker";
            this.labelExternalSystemPicker.Size = new System.Drawing.Size(85, 13);
            this.labelExternalSystemPicker.TabIndex = 20;
            this.labelExternalSystemPicker.Text = "External System:";
            // 
            // externalSystemPicker
            // 
            this.externalSystemPicker.Location = new System.Drawing.Point(134, 32);
            this.externalSystemPicker.Name = "externalSystemPicker";
            this.externalSystemPicker.SelectedValue = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.externalSystemPicker.Size = new System.Drawing.Size(255, 20);
            this.externalSystemPicker.TabIndex = 21;
            // 
            // labelAgencyPicker
            // 
            this.labelAgencyPicker.AutoSize = true;
            this.labelAgencyPicker.Location = new System.Drawing.Point(5, 82);
            this.labelAgencyPicker.Name = "labelAgencyPicker";
            this.labelAgencyPicker.Size = new System.Drawing.Size(46, 13);
            this.labelAgencyPicker.TabIndex = 22;
            this.labelAgencyPicker.Text = "Agency:";
            // 
            // agencyPicker
            // 
            this.agencyPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.agencyPicker.Location = new System.Drawing.Point(134, 82);
            this.agencyPicker.Name = "agencyPicker";
            this.agencyPicker.SelectedValue = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.agencyPicker.Size = new System.Drawing.Size(566, 20);
            this.agencyPicker.TabIndex = 23;
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(5, 107);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(54, 13);
            this.labelComment.TabIndex = 24;
            this.labelComment.Text = "Comment:";
            // 
            // textBoxComment
            // 
            this.textBoxComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxComment.Location = new System.Drawing.Point(134, 108);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(566, 97);
            this.textBoxComment.TabIndex = 25;
            // 
            // labelUserPicker
            // 
            this.labelUserPicker.AutoSize = true;
            this.labelUserPicker.Location = new System.Drawing.Point(5, 211);
            this.labelUserPicker.Name = "labelUserPicker";
            this.labelUserPicker.Size = new System.Drawing.Size(32, 13);
            this.labelUserPicker.TabIndex = 26;
            this.labelUserPicker.Text = "User:";
            // 
            // userPicker
            // 
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Location = new System.Drawing.Point(134, 211);
            this.userPicker.Name = "userPicker";
            this.userPicker.SelectedValue = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.userPicker.Size = new System.Drawing.Size(255, 20);
            this.userPicker.TabIndex = 27;
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(5, 236);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(59, 13);
            this.labelDateTime.TabIndex = 28;
            this.labelDateTime.Text = "Date Time:";
            // 
            // dateTimePickerDateTime
            // 
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(134, 236);
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(255, 20);
            this.dateTimePickerDateTime.TabIndex = 29;
            // 
            // tabPageContact
            // 
            this.tabPageContact.Controls.Add(this.buttonCrudeBookingContactMethodSearch);
            this.tabPageContact.Controls.Add(this.buttonCrudeBookingContactMethodAdd);
            this.tabPageContact.Controls.Add(this.buttonCrudeBookingContactMethodEdit);
            this.tabPageContact.Controls.Add(this.dataGridViewCrudeBookingContactMethod);
            this.tabPageContact.Location = new System.Drawing.Point(4, 22);
            this.tabPageContact.Name = "tabPageContact";
            this.tabPageContact.Size = new System.Drawing.Size(706, 300);
            this.tabPageContact.TabIndex = 4;
            this.tabPageContact.Text = "Contact";
            this.tabPageContact.UseVisualStyleBackColor = true;
            // 
            // buttonCrudeBookingContactMethodSearch
            // 
            this.buttonCrudeBookingContactMethodSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeBookingContactMethodSearch.Location = new System.Drawing.Point(611, 275);
            this.buttonCrudeBookingContactMethodSearch.Name = "buttonCrudeBookingContactMethodSearch";
            this.buttonCrudeBookingContactMethodSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeBookingContactMethodSearch.TabIndex = 6;
            this.buttonCrudeBookingContactMethodSearch.Text = "&Search";
            this.buttonCrudeBookingContactMethodSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeBookingContactMethodSearch.Click += new System.EventHandler(this.buttonCrudeBookingContactMethodSearch_Click);
            // 
            // buttonCrudeBookingContactMethodAdd
            // 
            this.buttonCrudeBookingContactMethodAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeBookingContactMethodAdd.Location = new System.Drawing.Point(415, 275);
            this.buttonCrudeBookingContactMethodAdd.Name = "buttonCrudeBookingContactMethodAdd";
            this.buttonCrudeBookingContactMethodAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeBookingContactMethodAdd.TabIndex = 7;
            this.buttonCrudeBookingContactMethodAdd.Text = "&Add";
            this.buttonCrudeBookingContactMethodAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeBookingContactMethodAdd.Click += new System.EventHandler(this.buttonCrudeBookingContactMethodAdd_Click);
            // 
            // buttonCrudeBookingContactMethodEdit
            // 
            this.buttonCrudeBookingContactMethodEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeBookingContactMethodEdit.Location = new System.Drawing.Point(513, 275);
            this.buttonCrudeBookingContactMethodEdit.Name = "buttonCrudeBookingContactMethodEdit";
            this.buttonCrudeBookingContactMethodEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeBookingContactMethodEdit.TabIndex = 8;
            this.buttonCrudeBookingContactMethodEdit.Text = "&Edit";
            this.buttonCrudeBookingContactMethodEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeBookingContactMethodEdit.Click += new System.EventHandler(this.buttonCrudeBookingContactMethodEdit_Click);
            // 
            // dataGridViewCrudeBookingContactMethod
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeBookingContactMethod.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeBookingContactMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeBookingContactMethod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeBookingContactMethod.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewCrudeBookingContactMethod.Name = "dataGridViewCrudeBookingContactMethod";
            this.dataGridViewCrudeBookingContactMethod.Size = new System.Drawing.Size(700, 266);
            this.dataGridViewCrudeBookingContactMethod.TabIndex = 5;
            this.dataGridViewCrudeBookingContactMethod.DoubleClick += new System.EventHandler(this.dataGridViewCrudeBookingContactMethod_DoubleClick);
            // 
            // tabPageAddress
            // 
            this.tabPageAddress.Controls.Add(this.buttonAddressSave);
            this.tabPageAddress.Controls.Add(this.labelState);
            this.tabPageAddress.Controls.Add(this.textBoxState);
            this.tabPageAddress.Controls.Add(this.labelDistrict);
            this.tabPageAddress.Controls.Add(this.textBoxDistrict);
            this.tabPageAddress.Controls.Add(this.labelProvince);
            this.tabPageAddress.Controls.Add(this.textBoxProvince);
            this.tabPageAddress.Controls.Add(this.labelZipCode);
            this.tabPageAddress.Controls.Add(this.textBoxZipCode);
            this.tabPageAddress.Controls.Add(this.labelPoBox);
            this.tabPageAddress.Controls.Add(this.textBoxPoBox);
            this.tabPageAddress.Controls.Add(this.label1);
            this.tabPageAddress.Controls.Add(this.textBox1);
            this.tabPageAddress.Controls.Add(this.labelAddressTypeRefCombo);
            this.tabPageAddress.Controls.Add(this.labelAddressOne);
            this.tabPageAddress.Controls.Add(this.textBoxAddressOne);
            this.tabPageAddress.Controls.Add(this.labelAddressTwo);
            this.tabPageAddress.Controls.Add(this.textBoxAddressTwo);
            this.tabPageAddress.Controls.Add(this.labelAddressThree);
            this.tabPageAddress.Controls.Add(this.textBoxAddressThree);
            this.tabPageAddress.Controls.Add(this.addressTypeRefCombo);
            this.tabPageAddress.Location = new System.Drawing.Point(4, 22);
            this.tabPageAddress.Name = "tabPageAddress";
            this.tabPageAddress.Size = new System.Drawing.Size(706, 300);
            this.tabPageAddress.TabIndex = 5;
            this.tabPageAddress.Text = "Address";
            this.tabPageAddress.UseVisualStyleBackColor = true;
            this.tabPageAddress.Leave += new System.EventHandler(this.tabPageAddress_Leave);
            // 
            // buttonAddressSave
            // 
            this.buttonAddressSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddressSave.Location = new System.Drawing.Point(611, 275);
            this.buttonAddressSave.Name = "buttonAddressSave";
            this.buttonAddressSave.Size = new System.Drawing.Size(92, 22);
            this.buttonAddressSave.TabIndex = 38;
            this.buttonAddressSave.Text = "&Save";
            this.buttonAddressSave.UseVisualStyleBackColor = true;
            this.buttonAddressSave.Click += new System.EventHandler(this.buttonAddressSave_Click);
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(3, 104);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(35, 13);
            this.labelState.TabIndex = 26;
            this.labelState.Text = "State:";
            // 
            // textBoxState
            // 
            this.textBoxState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxState.Location = new System.Drawing.Point(141, 102);
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.Size = new System.Drawing.Size(250, 20);
            this.textBoxState.TabIndex = 27;
            // 
            // labelDistrict
            // 
            this.labelDistrict.AutoSize = true;
            this.labelDistrict.Location = new System.Drawing.Point(3, 127);
            this.labelDistrict.Name = "labelDistrict";
            this.labelDistrict.Size = new System.Drawing.Size(42, 13);
            this.labelDistrict.TabIndex = 28;
            this.labelDistrict.Text = "District:";
            // 
            // textBoxDistrict
            // 
            this.textBoxDistrict.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDistrict.Location = new System.Drawing.Point(141, 125);
            this.textBoxDistrict.Name = "textBoxDistrict";
            this.textBoxDistrict.Size = new System.Drawing.Size(250, 20);
            this.textBoxDistrict.TabIndex = 29;
            // 
            // labelProvince
            // 
            this.labelProvince.AutoSize = true;
            this.labelProvince.Location = new System.Drawing.Point(3, 150);
            this.labelProvince.Name = "labelProvince";
            this.labelProvince.Size = new System.Drawing.Size(52, 13);
            this.labelProvince.TabIndex = 30;
            this.labelProvince.Text = "Province:";
            // 
            // textBoxProvince
            // 
            this.textBoxProvince.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProvince.Location = new System.Drawing.Point(141, 148);
            this.textBoxProvince.Name = "textBoxProvince";
            this.textBoxProvince.Size = new System.Drawing.Size(250, 20);
            this.textBoxProvince.TabIndex = 31;
            // 
            // labelZipCode
            // 
            this.labelZipCode.AutoSize = true;
            this.labelZipCode.Location = new System.Drawing.Point(3, 173);
            this.labelZipCode.Name = "labelZipCode";
            this.labelZipCode.Size = new System.Drawing.Size(53, 13);
            this.labelZipCode.TabIndex = 32;
            this.labelZipCode.Text = "Zip Code:";
            // 
            // textBoxZipCode
            // 
            this.textBoxZipCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxZipCode.Location = new System.Drawing.Point(141, 171);
            this.textBoxZipCode.Name = "textBoxZipCode";
            this.textBoxZipCode.Size = new System.Drawing.Size(250, 20);
            this.textBoxZipCode.TabIndex = 33;
            // 
            // labelPoBox
            // 
            this.labelPoBox.AutoSize = true;
            this.labelPoBox.Location = new System.Drawing.Point(3, 196);
            this.labelPoBox.Name = "labelPoBox";
            this.labelPoBox.Size = new System.Drawing.Size(44, 13);
            this.labelPoBox.TabIndex = 34;
            this.labelPoBox.Text = "Po Box:";
            // 
            // textBoxPoBox
            // 
            this.textBoxPoBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPoBox.Location = new System.Drawing.Point(141, 194);
            this.textBoxPoBox.Name = "textBoxPoBox";
            this.textBoxPoBox.Size = new System.Drawing.Size(250, 20);
            this.textBoxPoBox.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Comment:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(141, 217);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 20);
            this.textBox1.TabIndex = 37;
            // 
            // labelAddressTypeRefCombo
            // 
            this.labelAddressTypeRefCombo.AutoSize = true;
            this.labelAddressTypeRefCombo.Location = new System.Drawing.Point(3, 9);
            this.labelAddressTypeRefCombo.Name = "labelAddressTypeRefCombo";
            this.labelAddressTypeRefCombo.Size = new System.Drawing.Size(75, 13);
            this.labelAddressTypeRefCombo.TabIndex = 10;
            this.labelAddressTypeRefCombo.Text = "Address Type:";
            // 
            // labelAddressOne
            // 
            this.labelAddressOne.AutoSize = true;
            this.labelAddressOne.Location = new System.Drawing.Point(3, 32);
            this.labelAddressOne.Name = "labelAddressOne";
            this.labelAddressOne.Size = new System.Drawing.Size(71, 13);
            this.labelAddressOne.TabIndex = 12;
            this.labelAddressOne.Text = "Address One:";
            // 
            // textBoxAddressOne
            // 
            this.textBoxAddressOne.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAddressOne.Location = new System.Drawing.Point(141, 33);
            this.textBoxAddressOne.Name = "textBoxAddressOne";
            this.textBoxAddressOne.Size = new System.Drawing.Size(250, 20);
            this.textBoxAddressOne.TabIndex = 13;
            // 
            // labelAddressTwo
            // 
            this.labelAddressTwo.AutoSize = true;
            this.labelAddressTwo.Location = new System.Drawing.Point(3, 55);
            this.labelAddressTwo.Name = "labelAddressTwo";
            this.labelAddressTwo.Size = new System.Drawing.Size(72, 13);
            this.labelAddressTwo.TabIndex = 14;
            this.labelAddressTwo.Text = "Address Two:";
            // 
            // textBoxAddressTwo
            // 
            this.textBoxAddressTwo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAddressTwo.Location = new System.Drawing.Point(141, 56);
            this.textBoxAddressTwo.Name = "textBoxAddressTwo";
            this.textBoxAddressTwo.Size = new System.Drawing.Size(250, 20);
            this.textBoxAddressTwo.TabIndex = 15;
            // 
            // labelAddressThree
            // 
            this.labelAddressThree.AutoSize = true;
            this.labelAddressThree.Location = new System.Drawing.Point(3, 78);
            this.labelAddressThree.Name = "labelAddressThree";
            this.labelAddressThree.Size = new System.Drawing.Size(79, 13);
            this.labelAddressThree.TabIndex = 16;
            this.labelAddressThree.Text = "Address Three:";
            // 
            // textBoxAddressThree
            // 
            this.textBoxAddressThree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAddressThree.Location = new System.Drawing.Point(141, 79);
            this.textBoxAddressThree.Name = "textBoxAddressThree";
            this.textBoxAddressThree.Size = new System.Drawing.Size(250, 20);
            this.textBoxAddressThree.TabIndex = 17;
            // 
            // addressTypeRefCombo
            // 
            this.addressTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressTypeRefCombo.Location = new System.Drawing.Point(141, 9);
            this.addressTypeRefCombo.Name = "addressTypeRefCombo";
            this.addressTypeRefCombo.Size = new System.Drawing.Size(250, 21);
            this.addressTypeRefCombo.TabIndex = 11;
            // 
            // tabPagePassengers
            // 
            this.tabPagePassengers.Controls.Add(this.dataGridViewBookingPassengers);
            this.tabPagePassengers.Controls.Add(this.buttonCrudeBookingPassengerSearch);
            this.tabPagePassengers.Controls.Add(this.buttonCrudeBookingPassengerAdd);
            this.tabPagePassengers.Controls.Add(this.buttonCrudeBookingPassengerEdit);
            this.tabPagePassengers.Location = new System.Drawing.Point(4, 22);
            this.tabPagePassengers.Name = "tabPagePassengers";
            this.tabPagePassengers.Size = new System.Drawing.Size(706, 300);
            this.tabPagePassengers.TabIndex = 2;
            this.tabPagePassengers.Text = "Passengers";
            this.tabPagePassengers.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBookingPassengers
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewBookingPassengers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewBookingPassengers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBookingPassengers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookingPassengers.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewBookingPassengers.Name = "dataGridViewBookingPassengers";
            this.dataGridViewBookingPassengers.Size = new System.Drawing.Size(700, 266);
            this.dataGridViewBookingPassengers.TabIndex = 9;
            // 
            // buttonCrudeBookingPassengerSearch
            // 
            this.buttonCrudeBookingPassengerSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeBookingPassengerSearch.Location = new System.Drawing.Point(611, 275);
            this.buttonCrudeBookingPassengerSearch.Name = "buttonCrudeBookingPassengerSearch";
            this.buttonCrudeBookingPassengerSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeBookingPassengerSearch.TabIndex = 6;
            this.buttonCrudeBookingPassengerSearch.Text = "&Search";
            this.buttonCrudeBookingPassengerSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeBookingPassengerSearch.Click += new System.EventHandler(this.buttonCrudeBookingPassengerSearch_Click);
            // 
            // buttonCrudeBookingPassengerAdd
            // 
            this.buttonCrudeBookingPassengerAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeBookingPassengerAdd.Location = new System.Drawing.Point(415, 275);
            this.buttonCrudeBookingPassengerAdd.Name = "buttonCrudeBookingPassengerAdd";
            this.buttonCrudeBookingPassengerAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeBookingPassengerAdd.TabIndex = 7;
            this.buttonCrudeBookingPassengerAdd.Text = "&Add";
            this.buttonCrudeBookingPassengerAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeBookingPassengerAdd.Click += new System.EventHandler(this.buttonCrudeBookingPassengerAdd_Click);
            // 
            // buttonCrudeBookingPassengerEdit
            // 
            this.buttonCrudeBookingPassengerEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeBookingPassengerEdit.Location = new System.Drawing.Point(513, 275);
            this.buttonCrudeBookingPassengerEdit.Name = "buttonCrudeBookingPassengerEdit";
            this.buttonCrudeBookingPassengerEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeBookingPassengerEdit.TabIndex = 8;
            this.buttonCrudeBookingPassengerEdit.Text = "&Edit";
            this.buttonCrudeBookingPassengerEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeBookingPassengerEdit.Click += new System.EventHandler(this.buttonCrudeBookingPassengerEdit_Click);
            // 
            // tabPageItinerary
            // 
            this.tabPageItinerary.Controls.Add(this.buttonCrudeBookingFlightSegmentSearch);
            this.tabPageItinerary.Controls.Add(this.buttonCrudeBookingFlightSegmentAdd);
            this.tabPageItinerary.Controls.Add(this.buttonCrudeBookingFlightSegmentRemove);
            this.tabPageItinerary.Controls.Add(this.dataGridViewBookingFlights);
            this.tabPageItinerary.Location = new System.Drawing.Point(4, 22);
            this.tabPageItinerary.Name = "tabPageItinerary";
            this.tabPageItinerary.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageItinerary.Size = new System.Drawing.Size(706, 300);
            this.tabPageItinerary.TabIndex = 1;
            this.tabPageItinerary.Text = "Itinerary";
            this.tabPageItinerary.UseVisualStyleBackColor = true;
            // 
            // buttonCrudeBookingFlightSegmentSearch
            // 
            this.buttonCrudeBookingFlightSegmentSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeBookingFlightSegmentSearch.Location = new System.Drawing.Point(611, 275);
            this.buttonCrudeBookingFlightSegmentSearch.Name = "buttonCrudeBookingFlightSegmentSearch";
            this.buttonCrudeBookingFlightSegmentSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeBookingFlightSegmentSearch.TabIndex = 6;
            this.buttonCrudeBookingFlightSegmentSearch.Text = "&Search";
            this.buttonCrudeBookingFlightSegmentSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeBookingFlightSegmentSearch.Click += new System.EventHandler(this.buttonCrudeBookingFlightSegmentSearch_Click);
            // 
            // buttonCrudeBookingFlightSegmentAdd
            // 
            this.buttonCrudeBookingFlightSegmentAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeBookingFlightSegmentAdd.Location = new System.Drawing.Point(415, 275);
            this.buttonCrudeBookingFlightSegmentAdd.Name = "buttonCrudeBookingFlightSegmentAdd";
            this.buttonCrudeBookingFlightSegmentAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeBookingFlightSegmentAdd.TabIndex = 7;
            this.buttonCrudeBookingFlightSegmentAdd.Text = "&Add";
            this.buttonCrudeBookingFlightSegmentAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeBookingFlightSegmentAdd.Click += new System.EventHandler(this.buttonCrudeBookingFlightSegmentAdd_Click);
            // 
            // buttonCrudeBookingFlightSegmentRemove
            // 
            this.buttonCrudeBookingFlightSegmentRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeBookingFlightSegmentRemove.Location = new System.Drawing.Point(513, 275);
            this.buttonCrudeBookingFlightSegmentRemove.Name = "buttonCrudeBookingFlightSegmentRemove";
            this.buttonCrudeBookingFlightSegmentRemove.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeBookingFlightSegmentRemove.TabIndex = 8;
            this.buttonCrudeBookingFlightSegmentRemove.Text = "&Remove";
            this.buttonCrudeBookingFlightSegmentRemove.UseVisualStyleBackColor = true;
            this.buttonCrudeBookingFlightSegmentRemove.Click += new System.EventHandler(this.buttonCrudeBookingFlightSegmentRemove_Click);
            // 
            // dataGridViewBookingFlights
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewBookingFlights.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewBookingFlights.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBookingFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookingFlights.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewBookingFlights.MultiSelect = false;
            this.dataGridViewBookingFlights.Name = "dataGridViewBookingFlights";
            this.dataGridViewBookingFlights.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBookingFlights.Size = new System.Drawing.Size(700, 266);
            this.dataGridViewBookingFlights.TabIndex = 5;
            this.dataGridViewBookingFlights.DoubleClick += new System.EventHandler(this.dataGridViewCrudeBookingFlightSegment_DoubleClick);
            // 
            // tabPageServiceRequest
            // 
            this.tabPageServiceRequest.Controls.Add(this.buttonServiceCarAdd);
            this.tabPageServiceRequest.Controls.Add(this.buttonServiceAddHotel);
            this.tabPageServiceRequest.Controls.Add(this.durianFinancialServiceDetailsForBooking);
            this.tabPageServiceRequest.Controls.Add(this.buttonCrudeServiceSpecialServiceRequestSearch);
            this.tabPageServiceRequest.Controls.Add(this.buttonCrudeServiceSpecialServiceRequestAdd);
            this.tabPageServiceRequest.Controls.Add(this.buttonCrudeServiceSpecialServiceRequestRemove);
            this.tabPageServiceRequest.Location = new System.Drawing.Point(4, 22);
            this.tabPageServiceRequest.Name = "tabPageServiceRequest";
            this.tabPageServiceRequest.Size = new System.Drawing.Size(706, 300);
            this.tabPageServiceRequest.TabIndex = 8;
            this.tabPageServiceRequest.Text = "Services";
            this.tabPageServiceRequest.UseVisualStyleBackColor = true;
            // 
            // buttonServiceCarAdd
            // 
            this.buttonServiceCarAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonServiceCarAdd.Location = new System.Drawing.Point(219, 275);
            this.buttonServiceCarAdd.Name = "buttonServiceCarAdd";
            this.buttonServiceCarAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonServiceCarAdd.TabIndex = 11;
            this.buttonServiceCarAdd.Text = "Add &Car";
            this.buttonServiceCarAdd.UseVisualStyleBackColor = true;
            this.buttonServiceCarAdd.Click += new System.EventHandler(this.buttonServiceCarAdd_Click);
            // 
            // buttonServiceAddHotel
            // 
            this.buttonServiceAddHotel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonServiceAddHotel.Location = new System.Drawing.Point(317, 275);
            this.buttonServiceAddHotel.Name = "buttonServiceAddHotel";
            this.buttonServiceAddHotel.Size = new System.Drawing.Size(92, 22);
            this.buttonServiceAddHotel.TabIndex = 10;
            this.buttonServiceAddHotel.Text = "Add &Hotel";
            this.buttonServiceAddHotel.UseVisualStyleBackColor = true;
            this.buttonServiceAddHotel.Click += new System.EventHandler(this.buttonServiceAddHotel_Click);
            // 
            // durianFinancialServiceDetailsForBooking
            // 
            this.durianFinancialServiceDetailsForBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.durianFinancialServiceDetailsForBooking.Location = new System.Drawing.Point(3, 3);
            this.durianFinancialServiceDetailsForBooking.Name = "durianFinancialServiceDetailsForBooking";
            this.durianFinancialServiceDetailsForBooking.Size = new System.Drawing.Size(700, 266);
            this.durianFinancialServiceDetailsForBooking.TabIndex = 9;
            // 
            // buttonCrudeServiceSpecialServiceRequestSearch
            // 
            this.buttonCrudeServiceSpecialServiceRequestSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeServiceSpecialServiceRequestSearch.Location = new System.Drawing.Point(611, 275);
            this.buttonCrudeServiceSpecialServiceRequestSearch.Name = "buttonCrudeServiceSpecialServiceRequestSearch";
            this.buttonCrudeServiceSpecialServiceRequestSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeServiceSpecialServiceRequestSearch.TabIndex = 6;
            this.buttonCrudeServiceSpecialServiceRequestSearch.Text = "&Search";
            this.buttonCrudeServiceSpecialServiceRequestSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeServiceSpecialServiceRequestSearch.Click += new System.EventHandler(this.buttonCrudeServiceSpecialServiceRequestSearch_Click);
            // 
            // buttonCrudeServiceSpecialServiceRequestAdd
            // 
            this.buttonCrudeServiceSpecialServiceRequestAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeServiceSpecialServiceRequestAdd.Location = new System.Drawing.Point(415, 275);
            this.buttonCrudeServiceSpecialServiceRequestAdd.Name = "buttonCrudeServiceSpecialServiceRequestAdd";
            this.buttonCrudeServiceSpecialServiceRequestAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeServiceSpecialServiceRequestAdd.TabIndex = 7;
            this.buttonCrudeServiceSpecialServiceRequestAdd.Text = "Add &SSR";
            this.buttonCrudeServiceSpecialServiceRequestAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeServiceSpecialServiceRequestAdd.Click += new System.EventHandler(this.buttonCrudeServiceSpecialServiceRequestAdd_Click);
            // 
            // buttonCrudeServiceSpecialServiceRequestRemove
            // 
            this.buttonCrudeServiceSpecialServiceRequestRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeServiceSpecialServiceRequestRemove.Location = new System.Drawing.Point(513, 275);
            this.buttonCrudeServiceSpecialServiceRequestRemove.Name = "buttonCrudeServiceSpecialServiceRequestRemove";
            this.buttonCrudeServiceSpecialServiceRequestRemove.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeServiceSpecialServiceRequestRemove.TabIndex = 8;
            this.buttonCrudeServiceSpecialServiceRequestRemove.Text = "&Remove";
            this.buttonCrudeServiceSpecialServiceRequestRemove.UseVisualStyleBackColor = true;
            this.buttonCrudeServiceSpecialServiceRequestRemove.Click += new System.EventHandler(this.buttonCrudeServiceSpecialServiceRequestRemove_Click);
            // 
            // tabPagePayments
            // 
            this.tabPagePayments.Controls.Add(this.dataGridViewBookingFinancialPayments);
            this.tabPagePayments.Controls.Add(this.buttonCrudeFinancialPaymentSearch);
            this.tabPagePayments.Controls.Add(this.buttonCrudeFinancialPaymentAdd);
            this.tabPagePayments.Controls.Add(this.buttonCrudeFinancialPaymentEdit);
            this.tabPagePayments.Location = new System.Drawing.Point(4, 22);
            this.tabPagePayments.Name = "tabPagePayments";
            this.tabPagePayments.Size = new System.Drawing.Size(706, 300);
            this.tabPagePayments.TabIndex = 7;
            this.tabPagePayments.Text = "Payments";
            this.tabPagePayments.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBookingFinancialPayments
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewBookingFinancialPayments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewBookingFinancialPayments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBookingFinancialPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookingFinancialPayments.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewBookingFinancialPayments.Name = "dataGridViewBookingFinancialPayments";
            this.dataGridViewBookingFinancialPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBookingFinancialPayments.Size = new System.Drawing.Size(700, 266);
            this.dataGridViewBookingFinancialPayments.TabIndex = 9;
            // 
            // buttonCrudeFinancialPaymentSearch
            // 
            this.buttonCrudeFinancialPaymentSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialPaymentSearch.Location = new System.Drawing.Point(611, 275);
            this.buttonCrudeFinancialPaymentSearch.Name = "buttonCrudeFinancialPaymentSearch";
            this.buttonCrudeFinancialPaymentSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialPaymentSearch.TabIndex = 6;
            this.buttonCrudeFinancialPaymentSearch.Text = "&Search";
            this.buttonCrudeFinancialPaymentSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialPaymentSearch.Click += new System.EventHandler(this.buttonCrudeFinancialPaymentSearch_Click);
            // 
            // buttonCrudeFinancialPaymentAdd
            // 
            this.buttonCrudeFinancialPaymentAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialPaymentAdd.Location = new System.Drawing.Point(415, 275);
            this.buttonCrudeFinancialPaymentAdd.Name = "buttonCrudeFinancialPaymentAdd";
            this.buttonCrudeFinancialPaymentAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialPaymentAdd.TabIndex = 7;
            this.buttonCrudeFinancialPaymentAdd.Text = "&Add";
            this.buttonCrudeFinancialPaymentAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialPaymentAdd.Click += new System.EventHandler(this.buttonCrudeFinancialPaymentAdd_Click);
            // 
            // buttonCrudeFinancialPaymentEdit
            // 
            this.buttonCrudeFinancialPaymentEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialPaymentEdit.Location = new System.Drawing.Point(513, 275);
            this.buttonCrudeFinancialPaymentEdit.Name = "buttonCrudeFinancialPaymentEdit";
            this.buttonCrudeFinancialPaymentEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialPaymentEdit.TabIndex = 8;
            this.buttonCrudeFinancialPaymentEdit.Text = "&Edit";
            this.buttonCrudeFinancialPaymentEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialPaymentEdit.Click += new System.EventHandler(this.buttonCrudeFinancialPaymentEdit_Click);
            // 
            // tabPageTransactions
            // 
            this.tabPageTransactions.Controls.Add(this.dataGridViewBookingFinancialTransactions);
            this.tabPageTransactions.Location = new System.Drawing.Point(4, 22);
            this.tabPageTransactions.Name = "tabPageTransactions";
            this.tabPageTransactions.Size = new System.Drawing.Size(706, 300);
            this.tabPageTransactions.TabIndex = 6;
            this.tabPageTransactions.Text = "Transactions";
            this.tabPageTransactions.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBookingFinancialTransactions
            // 
            this.dataGridViewBookingFinancialTransactions.AllowUserToAddRows = false;
            this.dataGridViewBookingFinancialTransactions.AllowUserToDeleteRows = false;
            this.dataGridViewBookingFinancialTransactions.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewBookingFinancialTransactions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewBookingFinancialTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBookingFinancialTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookingFinancialTransactions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewBookingFinancialTransactions.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewBookingFinancialTransactions.Name = "dataGridViewBookingFinancialTransactions";
            this.dataGridViewBookingFinancialTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBookingFinancialTransactions.Size = new System.Drawing.Size(700, 294);
            this.dataGridViewBookingFinancialTransactions.TabIndex = 1;
            this.dataGridViewBookingFinancialTransactions.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridViewBookingFinancialTransactions_CellPainting);
            // 
            // tabPageHistory
            // 
            this.tabPageHistory.Controls.Add(this.dataGridViewBookingEventHistory);
            this.tabPageHistory.Location = new System.Drawing.Point(4, 22);
            this.tabPageHistory.Name = "tabPageHistory";
            this.tabPageHistory.Size = new System.Drawing.Size(706, 300);
            this.tabPageHistory.TabIndex = 3;
            this.tabPageHistory.Text = "History";
            this.tabPageHistory.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBookingEventHistory
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewBookingEventHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewBookingEventHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBookingEventHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookingEventHistory.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewBookingEventHistory.Name = "dataGridViewBookingEventHistory";
            this.dataGridViewBookingEventHistory.Size = new System.Drawing.Size(700, 294);
            this.dataGridViewBookingEventHistory.TabIndex = 1;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConfirm.Location = new System.Drawing.Point(489, 344);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirm.TabIndex = 6;
            this.buttonConfirm.Text = "&Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 369);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonBook);
            this.Name = "Booking";
            this.Text = "Booking";
            this.tabControl.ResumeLayout(false);
            this.tabPageBasics.ResumeLayout(false);
            this.tabPageBasics.PerformLayout();
            this.tabPageContact.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeBookingContactMethod)).EndInit();
            this.tabPageAddress.ResumeLayout(false);
            this.tabPageAddress.PerformLayout();
            this.tabPagePassengers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookingPassengers)).EndInit();
            this.tabPageItinerary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookingFlights)).EndInit();
            this.tabPageServiceRequest.ResumeLayout(false);
            this.tabPagePayments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookingFinancialPayments)).EndInit();
            this.tabPageTransactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookingFinancialTransactions)).EndInit();
            this.tabPageHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookingEventHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBook;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageBasics;
        private System.Windows.Forms.TabPage tabPageItinerary;
        private System.Windows.Forms.TabPage tabPagePassengers;
        private System.Windows.Forms.TabPage tabPageHistory;
        private System.Windows.Forms.TabPage tabPageContact;
        private System.Windows.Forms.TabPage tabPageAddress;
        private System.Windows.Forms.TabPage tabPageTransactions;
        private System.Windows.Forms.Label labelReceivedFrom;
        private System.Windows.Forms.TextBox textBoxReceivedFrom;
        private System.Windows.Forms.Label labelBookingSourceRefCombo;
        private BookingSourceRefCombo bookingSourceRefCombo;
        private System.Windows.Forms.Label labelExternalSystemPicker;
        private ExternalSystemPicker externalSystemPicker;
        private System.Windows.Forms.Label labelAgencyPicker;
        private AgencyPicker agencyPicker;
        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Label labelUserPicker;
        private DefaultUserPicker userPicker;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        private System.Windows.Forms.Label labelLocator;
        private System.Windows.Forms.TextBox textBoxLocator;
        private System.Windows.Forms.DataGridView dataGridViewBookingFinancialTransactions;
        private System.Windows.Forms.Button buttonCrudeBookingContactMethodSearch;
        private System.Windows.Forms.Button buttonCrudeBookingContactMethodAdd;
        private System.Windows.Forms.Button buttonCrudeBookingContactMethodEdit;
        private System.Windows.Forms.DataGridView dataGridViewCrudeBookingContactMethod;
        private System.Windows.Forms.Label labelAddressTypeRefCombo;
        private AddressTypeRefCombo addressTypeRefCombo;
        private System.Windows.Forms.Label labelAddressOne;
        private System.Windows.Forms.TextBox textBoxAddressOne;
        private System.Windows.Forms.Label labelAddressTwo;
        private System.Windows.Forms.TextBox textBoxAddressTwo;
        private System.Windows.Forms.Label labelAddressThree;
        private System.Windows.Forms.TextBox textBoxAddressThree;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.TextBox textBoxState;
        private System.Windows.Forms.Label labelDistrict;
        private System.Windows.Forms.TextBox textBoxDistrict;
        private System.Windows.Forms.Label labelProvince;
        private System.Windows.Forms.TextBox textBoxProvince;
        private System.Windows.Forms.Label labelZipCode;
        private System.Windows.Forms.TextBox textBoxZipCode;
        private System.Windows.Forms.Label labelPoBox;
        private System.Windows.Forms.TextBox textBoxPoBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonAddressSave;
        private System.Windows.Forms.Button buttonCrudeBookingPassengerSearch;
        private System.Windows.Forms.Button buttonCrudeBookingPassengerAdd;
        private System.Windows.Forms.Button buttonCrudeBookingPassengerEdit;
        private System.Windows.Forms.Button buttonCrudeBookingFlightSegmentSearch;
        private System.Windows.Forms.Button buttonCrudeBookingFlightSegmentAdd;
        private System.Windows.Forms.Button buttonCrudeBookingFlightSegmentRemove;
        private System.Windows.Forms.DataGridView dataGridViewBookingFlights;
        private System.Windows.Forms.DataGridView dataGridViewBookingPassengers;
        private System.Windows.Forms.DataGridView dataGridViewBookingEventHistory;
        private System.Windows.Forms.Label labelFinancialCurrencyPicker;
        private FinancialCurrencyLivePicker financialCurrencyPicker;
        private System.Windows.Forms.Label labelFinancialCostcentrePicker;
        private FinancialCostcentrePicker financialCostcentrePicker;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.TabPage tabPagePayments;
        private System.Windows.Forms.Button buttonCrudeFinancialPaymentSearch;
        private System.Windows.Forms.Button buttonCrudeFinancialPaymentAdd;
        private System.Windows.Forms.Button buttonCrudeFinancialPaymentEdit;
        private System.Windows.Forms.DataGridView dataGridViewBookingFinancialPayments;
        private System.Windows.Forms.TabPage tabPageServiceRequest;
        private System.Windows.Forms.Button buttonCrudeServiceSpecialServiceRequestSearch;
        private System.Windows.Forms.Button buttonCrudeServiceSpecialServiceRequestAdd;
        private System.Windows.Forms.Button buttonCrudeServiceSpecialServiceRequestRemove;
        private FinancialServiceDetailsForBookingDurian durianFinancialServiceDetailsForBooking;
        private System.Windows.Forms.Button buttonServiceAddHotel;
        private System.Windows.Forms.Button buttonServiceCarAdd;
    }
}
