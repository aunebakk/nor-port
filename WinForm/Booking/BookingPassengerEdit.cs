using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface
{

    public partial class BookingPassengerEdit : Form
    {

        private BookingPassengerWithExtraContract _contract;

        private Boolean _isNew;

        public BookingPassengerEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }

        public void ShowAsAdd() {
            _contract = new BookingPassengerWithExtraContract();
            _isNew = true;
            this.Text += " - Not Savable (Booking Missing)";
            Show();
        }

        public void ShowAsAddByBookingAndUser(System.Guid bookingId, System.Guid userId) {
            _contract = new BookingPassengerWithExtraContract();
            _isNew = true;
            _contract.BookingId = bookingId;
            _contract.PassengerTypeRcd = SolutionNorSolutionPort.BusinessLogicLayer.PassengerTypeRef.Adult;
            passengerTypeRefCombo.Text = _contract.PassengerTypeRcd;
            dateTimePickerDateTime.Text = _contract.DateTime.ToString();
            defaultStateRefCombo.Text = DefaultStateRef.Created;
            _contract.UserId = userId;
            _contract.DateTime = DateTime.UtcNow;
            userPicker.SelectedValue = userId;

            Show();
        }

        public void ShowAsEdit(System.Guid bookingPassengerId) {
            var service = new BookingSearchService();
            _isNew = false;
            try {
                _contract = service.BookingPassengerWithExtra(bookingPassengerId);
                passengerTypeRefCombo.Text = _contract.PassengerTypeRcd != null ? _contract.PassengerTypeRcd : String.Empty;
                textBoxPassengerName.Text = _contract.PassengerName;
                defaultStateRefCombo.Text = _contract.DefaultStateRcd;
                userPicker.SelectedValue = _contract.UserId;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();

                Show();
            } catch ( Exception ex ) {
                MessageBox.Show(ex.Message);
            } finally {
                service.Close();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e) {
            CrudeBookingPassengerServiceClient service = new CrudeBookingPassengerServiceClient();
            try {
                _contract.PassengerTypeRcd = passengerTypeRefCombo.Text;
                _contract.PassengerName = textBoxPassengerName.Text;
                _contract.UserId = ( Guid ) userPicker.SelectedValue;

                if ( _isNew )
                    new BookingServiceClient()
                        .PassengerAdd(_contract.BookingId,
                                        passengerTypeRefCombo.Text,
                                        textBoxPassengerName.Text,
                                        _contract.UserId
                                        );
                else
                    new BookingServiceClient()
                        .PassengerUpdate(_contract.BookingPassengerId,
                                            passengerTypeRefCombo.Text,
                                            textBoxPassengerName.Text,
                                            defaultStateRefCombo.Text,
                                            _contract.UserId
                                            );
            } catch ( Exception ex ) {
                MessageBox.Show(ex.Message);
            } finally {
                service.Close();
            }

            Close();
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void BookingPassengerEdit_Load(object sender, EventArgs e) {

        }
    }
}
