using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface
{
    public partial class Booking : Form
    {
        BookingContract _bookingContract = null;
        Guid _userId;

        public Booking() {
            InitializeComponent();
            InitializeGridCrudeBookingContactMethod();
            InitializeGridBookingPassengers();
            InitializeGridBookingFlights();
            InitializeGridBookingFinancialPayments();
            InitializeGridBookingFinancialTransactions();
            InitializeGridBookingEventHistory();

            this.CancelButton = buttonClose;
        }

        public void ShowAsAdd(
            Guid userId
            ) {
            _userId = userId;

            var bookingService = new BookingServiceClient();
            _bookingContract = bookingService.GetBookingEmpty(userId);
            _bookingContract.BookingIdentifier = new CrudeBookingIdentifierContract();
            _bookingContract.BookingIdentifier.BookingIdentifierValue = new BookingServiceClient().LocatorCreate();
            _bookingContract.Booking.BookingSourceRcd = BookingSourceRef.InternalSystem;
            _bookingContract.BookingPassengers = new List<BookingPassengersContract>();

            RefreshBooking();

            Show();
        }

        public void ShowAsEdit(
            Guid bookingId,
            Guid userId
            ) {
            _userId = userId;

            // get booking with new booking contract
            var bookingService = new BookingServiceClient();
            _bookingContract =
                bookingService.GetBooking(
                    bookingId,
                    _userId
                    );

            RefreshBooking();

            Show();
        }

        private void RefreshBooking() {
            bookingSourceRefCombo.Text = _bookingContract.Booking.BookingSourceRcd;
            textBoxLocator.Text = _bookingContract.BookingIdentifier.BookingIdentifierValue;
            textBoxReceivedFrom.Text = _bookingContract.Booking.ReceivedFrom;
            textBoxComment.Text = _bookingContract.Booking.Comment;

            financialCurrencyPicker.SelectedValue = _bookingContract.Booking.FinancialCurrencyId;
            financialCostcentrePicker.SelectedValue = _bookingContract.Booking.FinancialCostcentreId;

            userPicker.SelectedValue = _bookingContract.Booking.UserId;
            dateTimePickerDateTime.Text = _bookingContract.Booking.DateTime.ToString();
        }

        private void buttonBook_Click(object sender, EventArgs e) {
            // update / create booking
            try {
                var bookingService = new BookingServiceClient();

                Guid bookingId = bookingService.UpdateBooking(
                                        _bookingContract.Booking.BookingId,
                                        bookingSourceRcd: bookingSourceRefCombo.Text,
                                        locator: textBoxLocator.Text,
                                        email: string.Empty,
                                        receivedFrom: textBoxReceivedFrom.Text,
                                        comment: textBoxComment.Text,
                                        financialCurrencyId: _bookingContract.Booking.FinancialCurrencyId,
                                        financialCostcentreId: _bookingContract.Booking.FinancialCostcentreId,
                                        userId: Singleton.Instance.UserId
                                        );

                MessageBox.Show("Booking Saved");

                if ( _bookingContract.Booking.BookingId == Guid.Empty ) {
                    ShowAsEdit(bookingId, _userId);
                }
            } catch ( Exception ex ) {
                Singleton.Instance.Error(ex);
            }

        }

        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void RefreshBookingEventHistory() {
            BookingSearchService bookingEventHistory = new BookingSearchService();
            BindingSource bindingSource = new BindingSource();

            try {
                bindingSource.DataSource =
                    bookingEventHistory.BookingEventHistory(
                        _bookingContract.Booking.BookingId
                        );
                dataGridViewBookingEventHistory.AutoGenerateColumns = true;
                dataGridViewBookingEventHistory.DataSource = bindingSource;
                dataGridViewBookingEventHistory.AutoResizeColumns();
                dataGridViewBookingEventHistory.Refresh();
            } catch ( Exception ex ) {
                MessageBox.Show(ex.Message);
            } finally {
                bookingEventHistory.Close();
            }
        }

        private void InitializeGridBookingEventHistory() {
            dataGridViewBookingEventHistory.Columns.Clear();
            dataGridViewBookingEventHistory.AutoGenerateColumns = false;
            dataGridViewBookingEventHistory.Columns.Add("DateTime", "Date Time");
            dataGridViewBookingEventHistory.Columns.Add("HistoryEventGroupName", "History Event Group Name");
            dataGridViewBookingEventHistory.Columns.Add("HistoryEventTypeName", "History Event Type Name");
            dataGridViewBookingEventHistory.Columns.Add("HistoryEventDescription", "History Event Description");
            dataGridViewBookingEventHistory.Columns.Add("ExtensionData", "");
            dataGridViewBookingEventHistory.Columns["ExtensionData"].Visible = false;

            foreach ( DataGridViewColumn column in dataGridViewBookingEventHistory.Columns ) {
                column.DataPropertyName = column.Name;
                if ( column.Name.EndsWith("Id") )
                    column.Visible = false;
            }

            dataGridViewBookingEventHistory.AutoResizeColumns();
        }

        private void RefreshBookingFinancialTransactions() {
            BookingSearchService bookingFinancialTransactions = new BookingSearchService();
            BindingSource bindingSource = new BindingSource();

            try {
                bindingSource.DataSource =
                    bookingFinancialTransactions.BookingFinancialTransactions(
                        _bookingContract.Booking.BookingId
                        );

                dataGridViewBookingFinancialTransactions.AutoGenerateColumns = true;
                dataGridViewBookingFinancialTransactions.DataSource = bindingSource;
                dataGridViewBookingFinancialTransactions.AutoResizeColumns();
                // select last (totals) row
                dataGridViewBookingFinancialTransactions.Rows[0].Selected = false;
                dataGridViewBookingFinancialTransactions.Rows[dataGridViewBookingFinancialTransactions.Rows.Count - 1].Selected = true;

                dataGridViewBookingFinancialTransactions.Refresh();


            } catch ( Exception ex ) {
                MessageBox.Show(ex.Message);
            } finally {
                bookingFinancialTransactions.Close();
            }
        }

        private void dataGridViewBookingFinancialTransactions_CellPainting(object sender, DataGridViewCellPaintingEventArgs e) {
            if ( e.RowIndex >= dataGridViewBookingFinancialTransactions.Rows.Count - 2 ) {
                if ( e.ColumnIndex ==
                    dataGridViewBookingFinancialTransactions.Rows[
                        dataGridViewBookingFinancialTransactions.Rows.Count - 1
                        ].Cells["TransactionNumber"].ColumnIndex
                    || e.ColumnIndex ==
                            dataGridViewBookingFinancialTransactions.Rows[
                                dataGridViewBookingFinancialTransactions.Rows.Count - 1
                                ].Cells["DateTime"].ColumnIndex
                    ) {
                    e.CellStyle.ForeColor = e.CellStyle.BackColor;
                    e.CellStyle.SelectionForeColor = e.CellStyle.SelectionBackColor;
                }
            } else if ( e.Value == null
                    || String.IsNullOrEmpty(e.Value.ToString())
                    || e.Value.ToString() == "0"
                    || e.Value.ToString() == "0.0000"
                    ) {
                e.CellStyle.ForeColor = e.CellStyle.BackColor;
                e.CellStyle.SelectionForeColor = e.CellStyle.SelectionBackColor;
            }
        }

        private void InitializeGridBookingFinancialTransactions() {
            dataGridViewBookingFinancialTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBookingFinancialTransactions.Columns.Clear();
            dataGridViewBookingFinancialTransactions.AutoGenerateColumns = false;
            dataGridViewBookingFinancialTransactions.Columns.Add("TransactionNumber", "Nr");
            dataGridViewBookingFinancialTransactions.Columns.Add("DateTime", "Date Time");
            dataGridViewBookingFinancialTransactions.Columns.Add("TransactionType", "Transaction Type");
            dataGridViewBookingFinancialTransactions.Columns.Add("TypeName", "Type Name");
            dataGridViewBookingFinancialTransactions.Columns.Add("DebitAmount", "Debit Amount");
            dataGridViewBookingFinancialTransactions.Columns["DebitAmount"].DefaultCellStyle.Format = "n4";
            dataGridViewBookingFinancialTransactions.Columns["DebitAmount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewBookingFinancialTransactions.Columns.Add("CreditAmount", "Credit Amount");
            dataGridViewBookingFinancialTransactions.Columns["CreditAmount"].DefaultCellStyle.Format = "n4";
            dataGridViewBookingFinancialTransactions.Columns["CreditAmount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewBookingFinancialTransactions.Columns.Add("FinancialCurrencyTypeRcd", "Financial Currency Type");
            dataGridViewBookingFinancialTransactions.Columns.Add("FinancialCostcentreCode", "Financial Costcentre Code");
            dataGridViewBookingFinancialTransactions.Columns["FinancialCostcentreCode"].Visible = false;
            dataGridViewBookingFinancialTransactions.Columns.Add("FinancialCostcentreName", "Financial Costcentre Name");
            dataGridViewBookingFinancialTransactions.Columns.Add("DefaultUserCode", "Default User Code");
            dataGridViewBookingFinancialTransactions.Columns["DefaultUserCode"].Visible = false;
            dataGridViewBookingFinancialTransactions.Columns.Add("DefaultUserName", "Default User Name");
            dataGridViewBookingFinancialTransactions.Columns.Add("BookingId", "Booking Id");
            dataGridViewBookingFinancialTransactions.Columns.Add("ExtensionData", "");
            dataGridViewBookingFinancialTransactions.Columns["ExtensionData"].Visible = false;

            foreach ( DataGridViewColumn column in dataGridViewBookingFinancialTransactions.Columns ) {
                column.DataPropertyName = column.Name;
                if ( column.Name.EndsWith("Id") )
                    column.Visible = false;
            }

            dataGridViewBookingFinancialTransactions.AutoResizeColumns();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e) {
            if ( tabControl.SelectedTab == tabPageBasics ) {
                RefreshBooking();
            } else if ( tabControl.SelectedTab == tabPageContact ) {
                RefreshCrudeBookingContactMethod();
            } else if ( tabControl.SelectedTab == tabPageAddress ) {
                RefreshAddress();
            } else if ( tabControl.SelectedTab == tabPageItinerary ) {
                RefreshBookingFlights();
            } else if ( tabControl.SelectedTab == tabPageServiceRequest ) {
                durianFinancialServiceDetailsForBooking.RefreshFinancialServiceDetailsForBooking(_bookingContract.Booking.BookingId);
            } else if ( tabControl.SelectedTab == tabPagePayments ) {
                RefreshBookingFinancialPayments();
            } else if ( tabControl.SelectedTab == tabPageTransactions ) {
                RefreshBookingFinancialTransactions();
            } else if ( tabControl.SelectedTab == tabPagePassengers ) {
                RefreshBookingPassengers();
            } else if ( tabControl.SelectedTab == tabPageHistory ) {
                RefreshBookingEventHistory();
            }
        }

        private void tabControl_Selecting(object sender, TabControlCancelEventArgs e) {
            if ( _bookingContract.Booking.BookingId == Guid.Empty && tabControl.SelectedTab != tabPageBasics ) {
                e.Cancel = true;
                return;
            }
        }

        private void tabPageBasics_Leave(object sender, EventArgs e) {
            if ( _bookingContract.Booking.BookingId == Guid.Empty )
                return;

            if ( bookingSourceRefCombo.Text != _bookingContract.Booking.BookingSourceRcd
                || textBoxLocator.Text != _bookingContract.BookingIdentifier.BookingIdentifierValue
                || textBoxReceivedFrom.Text != _bookingContract.Booking.ReceivedFrom
                || textBoxComment.Text != _bookingContract.Booking.Comment
                ) {
                new BookingServiceClient().UpdateBookingPage1(
                    _bookingContract.Booking.BookingId,
                    bookingSourceRefCombo.Text,
                    textBoxLocator.Text,
                    textBoxReceivedFrom.Text,
                    textBoxComment.Text,
                    _userId
                    );
            }
        }

        private void tabPageAddress_Leave(object sender, EventArgs e) {
            if ( addressTypeRefCombo.Text != ( _bookingContract.BookingAddress.AddressTypeRcd != null ? _bookingContract.BookingAddress.AddressTypeRcd : String.Empty )
                || textBoxAddressOne.Text != _bookingContract.BookingAddress.AddressOne
                || textBoxAddressTwo.Text != _bookingContract.BookingAddress.AddressTwo
                || textBoxAddressThree.Text != _bookingContract.BookingAddress.AddressThree
                || textBoxState.Text != _bookingContract.BookingAddress.State
                || textBoxDistrict.Text != _bookingContract.BookingAddress.District
                || textBoxProvince.Text != _bookingContract.BookingAddress.Province
                || textBoxZipCode.Text != _bookingContract.BookingAddress.ZipCode
                || textBoxPoBox.Text != _bookingContract.BookingAddress.PoBox
                || textBoxComment.Text != _bookingContract.BookingAddress.Comment
                ) {

                new BookingServiceClient().UpdateBookingPage3(
                    _bookingContract.Booking.BookingId,
                    addressTypeRefCombo.Text,
                    textBoxAddressOne.Text,
                    textBoxAddressTwo.Text,
                    textBoxAddressThree.Text,
                    string.Empty,
                    string.Empty,
                    textBoxState.Text,
                    textBoxDistrict.Text,
                    textBoxProvince.Text,
                    textBoxZipCode.Text,
                    textBoxPoBox.Text,
                    textBoxComment.Text,
                    _userId
                    );
            }
        }

        private void buttonCrudeBookingContactMethodEdit_Click(object sender, EventArgs e) {
            var editForm = new CrudeBookingContactMethodEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit(( System.Guid ) dataGridViewCrudeBookingContactMethod.CurrentRow.Cells["BookingContactMethodId"].Value);
        }

        private void buttonCrudeBookingContactMethodAdd_Click(object sender, EventArgs e) {
            var editForm = new CrudeBookingContactMethodEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAddByBookingAndUser(
                _bookingContract.Booking.BookingId,
                _userId
                );
        }

        private void dataGridViewCrudeBookingContactMethod_DoubleClick(object sender, EventArgs e) {
            var editForm = new CrudeBookingContactMethodEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit(( System.Guid ) dataGridViewCrudeBookingContactMethod.CurrentRow.Cells["BookingContactMethodId"].Value);
        }

        private void buttonCrudeBookingContactMethodSearch_Click(object sender, EventArgs e) {
            RefreshCrudeBookingContactMethod();
        }

        public void RefreshCrudeBookingContactMethod() {
            var crudeBookingContactMethod = new CrudeBookingContactMethodServiceClient();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource =
                    crudeBookingContactMethod.FetchByBookingId(
                        _bookingContract.Booking.BookingId
                        );

                dataGridViewCrudeBookingContactMethod.AutoGenerateColumns = false;
                dataGridViewCrudeBookingContactMethod.DataSource = bindingSource;
                dataGridViewCrudeBookingContactMethod.AutoResizeColumns();
                dataGridViewCrudeBookingContactMethod.Refresh();
            } catch ( Exception ex ) {
                MessageBox.Show(ex.Message);
            } finally {
                crudeBookingContactMethod.Close();
            }
        }

        private void InitializeGridCrudeBookingContactMethod() {
            dataGridViewCrudeBookingContactMethod.Columns.Clear();
            dataGridViewCrudeBookingContactMethod.AutoGenerateColumns = false;
            dataGridViewCrudeBookingContactMethod.Columns.Add("BookingContactMethodId", "Booking Contact Method");
            dataGridViewCrudeBookingContactMethod.Columns["BookingContactMethodId"].DataPropertyName = "BookingContactMethodId";
            dataGridViewCrudeBookingContactMethod.Columns["BookingContactMethodId"].Visible = false;
            dataGridViewCrudeBookingContactMethod.Columns.Add("BookingId", "Booking");
            dataGridViewCrudeBookingContactMethod.Columns["BookingId"].DataPropertyName = "BookingId";
            dataGridViewCrudeBookingContactMethod.Columns["BookingId"].Visible = false;
            dataGridViewCrudeBookingContactMethod.Columns.Add("ContactMethodRcd", "Contact Method");
            dataGridViewCrudeBookingContactMethod.Columns["ContactMethodRcd"].DataPropertyName = "ContactMethodRcd";
            dataGridViewCrudeBookingContactMethod.Columns.Add("ContactMethodWay", "Contact Method Way");
            dataGridViewCrudeBookingContactMethod.Columns["ContactMethodWay"].DataPropertyName = "ContactMethodWay";
            dataGridViewCrudeBookingContactMethod.Columns.Add("Comment", "Comment");
            dataGridViewCrudeBookingContactMethod.Columns["Comment"].DataPropertyName = "Comment";
            dataGridViewCrudeBookingContactMethod.Columns.Add("DateTime", "Date Time");
            dataGridViewCrudeBookingContactMethod.Columns["DateTime"].DataPropertyName = "DateTime";
            dataGridViewCrudeBookingContactMethod.Columns.Add("ExtensionData", "");
            dataGridViewCrudeBookingContactMethod.Columns["ExtensionData"].Visible = false;

            dataGridViewCrudeBookingContactMethod.AutoResizeColumns();
        }

        public void RefreshAddress() {
            // fetch booking data
            var bookingService = new BookingServiceClient();
            _bookingContract =
                bookingService.GetBooking(
                    _bookingContract.Booking.BookingId,
                    _userId
                    );
            try {
                addressTypeRefCombo.Text = _bookingContract.BookingAddress.AddressTypeRcd != null ? _bookingContract.BookingAddress.AddressTypeRcd : String.Empty;
                textBoxAddressOne.Text = _bookingContract.BookingAddress.AddressOne;
                textBoxAddressTwo.Text = _bookingContract.BookingAddress.AddressTwo;
                textBoxAddressThree.Text = _bookingContract.BookingAddress.AddressThree;
                textBoxState.Text = _bookingContract.BookingAddress.State;
                textBoxDistrict.Text = _bookingContract.BookingAddress.District;
                textBoxProvince.Text = _bookingContract.BookingAddress.Province;
                textBoxZipCode.Text = _bookingContract.BookingAddress.ZipCode;
                textBoxPoBox.Text = _bookingContract.BookingAddress.PoBox;
                textBoxComment.Text = _bookingContract.BookingAddress.Comment;
                userPicker.SelectedValue = _bookingContract.BookingAddress.UserId;
                dateTimePickerDateTime.Text = _bookingContract.BookingAddress.DateTime.ToString();
            } catch ( Exception ex ) {
                MessageBox.Show(ex.Message);
            } finally {
                bookingService.Close();
            }
        }

        private void buttonAddressSave_Click(object sender, EventArgs e) {
            CrudeAddressServiceClient service = new CrudeAddressServiceClient();
            try {
                _bookingContract.BookingAddress.AddressTypeRcd = addressTypeRefCombo.Text;
                _bookingContract.BookingAddress.AddressOne = textBoxAddressOne.Text;
                _bookingContract.BookingAddress.AddressTwo = textBoxAddressTwo.Text;
                _bookingContract.BookingAddress.AddressThree = textBoxAddressThree.Text;
                _bookingContract.BookingAddress.State = textBoxState.Text;
                _bookingContract.BookingAddress.District = textBoxDistrict.Text;
                _bookingContract.BookingAddress.Province = textBoxProvince.Text;
                _bookingContract.BookingAddress.ZipCode = textBoxZipCode.Text;
                _bookingContract.BookingAddress.PoBox = textBoxPoBox.Text;
                _bookingContract.BookingAddress.Comment = textBoxComment.Text;
                _bookingContract.BookingAddress.DateTime = DateTime.UtcNow;
                _bookingContract.BookingAddress.UserId = _userId;

                if ( _bookingContract.BookingAddress.AddressId != Guid.Empty )
                    service.Update(_bookingContract.BookingAddress);
                else
                    service.Insert(_bookingContract.BookingAddress);

            } catch ( Exception ex ) {
                MessageBox.Show(ex.Message);
            } finally {
                service.Close();
            }
        }

        private void buttonCrudeBookingPassengerEdit_Click(object sender, EventArgs e) {
            var editForm = new BookingPassengerEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit(( System.Guid ) dataGridViewBookingPassengers.CurrentRow.Cells["BookingPassengerId"].Value);
        }

        private void buttonCrudeBookingPassengerAdd_Click(object sender, EventArgs e) {
            var editForm = new BookingPassengerEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAddByBookingAndUser(_bookingContract.Booking.BookingId, _userId);
        }

        private void dataGridViewBookingPassengers_DoubleClick(object sender, EventArgs e) {
            var editForm = new BookingPassengerEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit(( System.Guid ) dataGridViewBookingPassengers.CurrentRow.Cells["BookingPassengerId"].Value);
        }

        private void buttonCrudeBookingPassengerSearch_Click(object sender, EventArgs e) {
            RefreshBookingPassengers();
        }

        private void RefreshBookingPassengers() {
            BookingSearchService bookingPassengers = new BookingSearchService();
            BindingSource bindingSource = new BindingSource();

            try {
                bindingSource.DataSource =
                    bookingPassengers.BookingPassengers(
                        _bookingContract.Booking.BookingId
                        );

                dataGridViewBookingPassengers.AutoGenerateColumns = true;
                dataGridViewBookingPassengers.DataSource = bindingSource;
                dataGridViewBookingPassengers.AutoResizeColumns();
                dataGridViewBookingPassengers.Refresh();
            } catch ( Exception ex ) {
                MessageBox.Show(ex.Message);
            } finally {
                bookingPassengers.Close();
            }
        }

        private void InitializeGridBookingPassengers() {
            dataGridViewBookingPassengers.Columns.Clear();
            dataGridViewBookingPassengers.AutoGenerateColumns = false;
            dataGridViewBookingPassengers.Columns.Add("BookingPassengerId", "Booking Passenger Id");
            dataGridViewBookingPassengers.Columns.Add("PassengerId", "Passenger Id");
            dataGridViewBookingPassengers.Columns.Add("PassengerTypeRcd", "Passenger Type");
            dataGridViewBookingPassengers.Columns.Add("PassengerName", "Passenger Name");
            dataGridViewBookingPassengers.Columns.Add("UserId", "User Id");
            dataGridViewBookingPassengers.Columns.Add("DateTime", "Date Time");
            dataGridViewBookingPassengers.Columns.Add("ExtensionData", "");
            dataGridViewBookingPassengers.Columns["ExtensionData"].Visible = false;

            foreach ( DataGridViewColumn column in dataGridViewBookingPassengers.Columns ) {
                column.DataPropertyName = column.Name;
                if ( column.Name.EndsWith("Id") )
                    column.Visible = false;
            }

            dataGridViewBookingPassengers.AutoResizeColumns();
        }

        private void buttonCrudeBookingFlightSegmentRemove_Click(object sender, EventArgs e) {
            if ( dataGridViewBookingFlights.CurrentRow != null ) {
                new BookingServiceClient().FlightRemove(
                    _bookingContract.Booking.BookingId,
                    ( System.Guid ) dataGridViewBookingFlights.CurrentRow.Cells["BookingFlightSegmentId"].Value,
                    _userId
                    );

                RefreshBookingFlights();
            }
        }

        private void buttonCrudeBookingFlightSegmentAdd_Click(object sender, EventArgs e) {
            var editForm = new FlightsForPeriodLiveSearch();
            Guid flightId = editForm.ShowAsSelector();
            if ( flightId != Guid.Empty ) {
                new BookingServiceClient().FlightAdd(
                    _bookingContract.Booking.BookingId,
                    flightId,
                    _userId
                    );

                RefreshBookingFlights();
            }
        }

        private void dataGridViewCrudeBookingFlightSegment_DoubleClick(object sender, EventArgs e) {
            var editForm = new CrudeBookingFlightSegmentEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit(( System.Guid ) dataGridViewBookingFlights.CurrentRow.Cells["BookingFlightSegmentId"].Value);
        }

        private void buttonCrudeBookingFlightSegmentSearch_Click(object sender, EventArgs e) {
            RefreshBookingFlights();
        }

        private void RefreshBookingFlights() {
            BookingSearchService bookingFlights = new BookingSearchService();
            BindingSource bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = bookingFlights.BookingFlights(_bookingContract.Booking.BookingId);
                dataGridViewBookingFlights.AutoGenerateColumns = true;
                dataGridViewBookingFlights.DataSource = bindingSource;
                dataGridViewBookingFlights.AutoResizeColumns();
                dataGridViewBookingFlights.Refresh();
            } catch ( Exception ex ) {
                MessageBox.Show(ex.Message);
            } finally {
                bookingFlights.Close();
            }
        }

        private void InitializeGridBookingFlights() {
            dataGridViewBookingFlights.Columns.Clear();
            dataGridViewBookingFlights.AutoGenerateColumns = false;
            dataGridViewBookingFlights.Columns.Add("AirlineIdentifierCode", "Airline Identifier Code");
            dataGridViewBookingFlights.Columns.Add("FlightNumber", "Flight Number");
            dataGridViewBookingFlights.Columns.Add("DepartureAirportIdentifierCode", "Departure Airport Identifier Code");
            dataGridViewBookingFlights.Columns.Add("DepartureAirportName", "Departure Airport Name");
            dataGridViewBookingFlights.Columns.Add("ArrivalAirportIdentifierCode", "Arrival Airport Identifier Code");
            dataGridViewBookingFlights.Columns.Add("ArrivalAirportName", "Arrival Airport Name");
            dataGridViewBookingFlights.Columns.Add("FromDateTime", "From Date Time");
            dataGridViewBookingFlights.Columns.Add("UntilDateTime", "Until Date Time");
            dataGridViewBookingFlights.Columns.Add("Comment", "Comment");
            dataGridViewBookingFlights.Columns.Add("BookingFlightSegmentId", "Booking Flight Segment Id");
            dataGridViewBookingFlights.Columns.Add("ExtensionData", "");
            dataGridViewBookingFlights.Columns["ExtensionData"].Visible = false;

            foreach ( DataGridViewColumn column in dataGridViewBookingFlights.Columns ) {
                column.DataPropertyName = column.Name;
                if ( column.Name.EndsWith("Id") )
                    column.Visible = false;
            }

            dataGridViewBookingFlights.AutoResizeColumns();
        }

        private void buttonConfirm_Click(object sender, EventArgs e) {
            if ( MessageBox.Show("Do you really want to confirm this booking?", "Confirm", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes ) {
                try {
                    new BookingServiceClient().BookingConfirm(
                        _bookingContract.Booking.BookingId,
                        _userId
                        );

                    new BookingServiceClient().SendBookingConfirmationByEmail(
                        _bookingContract.Booking.BookingId,
                        _userId
                        );

                    tabControl.SelectedTab = tabPageTransactions;

                    tabControl_SelectedIndexChanged(sender, e);
                } catch ( Exception ex ) {
                    Singleton.Instance.Error(ex);
                }
            }
        }

        private void buttonCrudeFinancialPaymentEdit_Click(object sender, EventArgs e) {
            var editForm = new FinancialPaymentEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit(( System.Guid ) dataGridViewBookingFinancialPayments.CurrentRow.Cells["FinancialPaymentId"].Value);
        }

        private void buttonCrudeFinancialPaymentAdd_Click(object sender, EventArgs e) {
            var editForm = new FinancialPaymentEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAdd(
                _bookingContract.Booking.BookingId,
                _bookingContract.Booking.FinancialCurrencyId,
                _bookingContract.Booking.FinancialCostcentreId,
                _userId
                );
        }

        private void dataGridViewCrudeFinancialPayment_DoubleClick(object sender, EventArgs e) {
            var editForm = new FinancialPaymentEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit(( System.Guid ) dataGridViewBookingFinancialPayments.CurrentRow.Cells["FinancialPaymentId"].Value);
        }

        private void buttonCrudeFinancialPaymentSearch_Click(object sender, EventArgs e) {
            RefreshBookingFinancialPayments();
        }

        private void RefreshBookingFinancialPayments() {
            BookingSearchService bookingFinancialPayments = new BookingSearchService();
            BindingSource bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = bookingFinancialPayments.BookingFinancialPayments(_bookingContract.Booking.BookingId);
                dataGridViewBookingFinancialPayments.AutoGenerateColumns = true;
                dataGridViewBookingFinancialPayments.DataSource = bindingSource;
                dataGridViewBookingFinancialPayments.AutoResizeColumns();
                dataGridViewBookingFinancialPayments.Refresh();
            } catch ( Exception ex ) {
                MessageBox.Show(ex.Message);
            } finally {
                bookingFinancialPayments.Close();
            }
        }

        private void InitializeGridBookingFinancialPayments() {
            dataGridViewBookingFinancialPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBookingFinancialPayments.Columns.Clear();
            dataGridViewBookingFinancialPayments.AutoGenerateColumns = false;
            dataGridViewBookingFinancialPayments.Columns.Add("TransactionNumber", "Nr");
            dataGridViewBookingFinancialPayments.Columns.Add("DateTime", "Date Time");

            dataGridViewBookingFinancialPayments.Columns.Add("FinancialPaymentTypeRcd", "Financial Payment Type");
            dataGridViewBookingFinancialPayments.Columns["FinancialPaymentTypeRcd"].Visible = false;

            dataGridViewBookingFinancialPayments.Columns.Add("FinancialPaymentTypeName", "Financial Payment Type Name");

            dataGridViewBookingFinancialPayments.Columns.Add("PaidCurrencyAmount", "Paid Currency Amount");
            dataGridViewBookingFinancialPayments.Columns["PaidCurrencyAmount"].DefaultCellStyle.Format = "n4";
            dataGridViewBookingFinancialPayments.Columns["PaidCurrencyAmount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridViewBookingFinancialPayments.Columns.Add("PaidCurrencyType", "Paid Currency Type");

            dataGridViewBookingFinancialPayments.Columns.Add("ExchangeRate", "Exchange Rate");
            dataGridViewBookingFinancialPayments.Columns["ExchangeRate"].DefaultCellStyle.Format = "n4";
            dataGridViewBookingFinancialPayments.Columns["ExchangeRate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridViewBookingFinancialPayments.Columns.Add("BookingCurrencyAmount", "Booking Currency Amount");
            dataGridViewBookingFinancialPayments.Columns["BookingCurrencyAmount"].DefaultCellStyle.Format = "n4";
            dataGridViewBookingFinancialPayments.Columns["BookingCurrencyAmount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridViewBookingFinancialPayments.Columns.Add("BookingCurrencyType", "Booking Currency Type");
            dataGridViewBookingFinancialPayments.Columns.Add("PaymentDescription", "Description");

            dataGridViewBookingFinancialPayments.Columns.Add("FinancialCostcentreCode", "Financial Costcentre Code");
            dataGridViewBookingFinancialPayments.Columns["FinancialCostcentreCode"].Visible = false;

            dataGridViewBookingFinancialPayments.Columns.Add("FinancialCostcentreName", "Financial Costcentre Name");

            dataGridViewBookingFinancialPayments.Columns.Add("DefaultUserCode", "Default User Code");
            dataGridViewBookingFinancialPayments.Columns["DefaultUserCode"].Visible = false;

            dataGridViewBookingFinancialPayments.Columns.Add("DefaultUserName", "Default User Name");
            dataGridViewBookingFinancialPayments.Columns.Add("FinancialPaymentId", "Financial Payment Id");

            dataGridViewBookingFinancialPayments.Columns.Add("ExtensionData", "");
            dataGridViewBookingFinancialPayments.Columns["ExtensionData"].Visible = false;

            foreach ( DataGridViewColumn column in dataGridViewBookingFinancialPayments.Columns ) {
                column.DataPropertyName = column.Name;
                if ( column.Name.EndsWith("Id") )
                    column.Visible = false;
            }

            dataGridViewBookingFinancialPayments.AutoResizeColumns();
        }

        private void buttonCrudeServiceSpecialServiceRequestSearch_Click(object sender, EventArgs e) {
            durianFinancialServiceDetailsForBooking.RefreshFinancialServiceDetailsForBooking(_bookingContract.Booking.BookingId);
        }

        private void buttonCrudeServiceSpecialServiceRequestAdd_Click(object sender, EventArgs e) {
            var ssrList = new SpecialServiceRequestListLiveSearch();
            Guid ssrId = ssrList.GetSSR();
            new BookingServiceClient().BookingServiceSpecialServiceRequestAdd(
                _bookingContract.Booking.BookingId,
                ssrId,
                _userId
                );
            durianFinancialServiceDetailsForBooking.RefreshFinancialServiceDetailsForBooking(
                _bookingContract.Booking.BookingId);
        }

        private void buttonCrudeServiceSpecialServiceRequestRemove_Click(object sender, EventArgs e) {
            new BookingServiceClient().BookingServiceRequestRemove(
                durianFinancialServiceDetailsForBooking.BookingServiceRequestId,
                _userId
                );

            durianFinancialServiceDetailsForBooking.RefreshFinancialServiceDetailsForBooking(
                _bookingContract.Booking.BookingId);
        }

        private void buttonServiceAddHotel_Click(object sender, EventArgs e) {
            var hotelList = new ServiceHotelListLiveSearch();
            Guid hotelId = hotelList.GetHotel();
            new BookingServiceClient().BookingServiceHotelAdd(
                _bookingContract.Booking.BookingId,
                hotelId,
                _userId
                );

            durianFinancialServiceDetailsForBooking.RefreshFinancialServiceDetailsForBooking(
                _bookingContract.Booking.BookingId);
        }

        private void buttonServiceCarAdd_Click(object sender, EventArgs e) {
            var carRentalList = new ServiceCarRentalListLiveSearch();
            Guid carRentalId = carRentalList.GetCarRental();
            new BookingServiceClient().BookingServiceCarRentalAdd(
                _bookingContract.Booking.BookingId,
                carRentalId,
                _userId
                );

            durianFinancialServiceDetailsForBooking.RefreshFinancialServiceDetailsForBooking(
                _bookingContract.Booking.BookingId);
        }
    }
}
