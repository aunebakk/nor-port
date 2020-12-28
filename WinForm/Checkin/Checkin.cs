using SolutionNorSolutionPort.BusinessLogicLayer;
using System;
using System.Windows.Forms;

namespace SolutionNorSolutionPort.UserInterface
{

    public partial class Checkin : Form
    {

        Guid _userId = Guid.Empty;

        public Checkin() {
            InitializeComponent();

            this.AcceptButton = buttonFlightsWithCheckinInformationSearch;
            this.CancelButton = buttonClose;
        }

        public void Show(Guid userId
            ) {

            _userId = userId;

            dateTimePickerFromDateTime.Value = DateTime.UtcNow.Date;
            dateTimePickerFromDateTime.Checked = true;
            dateTimePickerUntilDateTime.Value = DateTime.UtcNow.Date.AddDays(1);
            dateTimePickerUntilDateTime.Checked = true;

            base.Show();

            checkinCombo.PopulateCombo();
            passengersOnFlightDurian.RefreshPassengersOnFlight(checkinCombo.FlightId);
        }

        private void buttonFlightsWithCheckinInformationSearch_Click(object sender, EventArgs e) {
            tabControl_SelectedIndexChanged(new object(), new EventArgs());
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void buttonCheckin_Click(object sender, EventArgs e) {
            try {
                new BookingServiceClient()
                    .PassengerCheckIn(
                        passengersOnFlightDurian.BookingPassengerId,
                        passengersOnFlightDurian.BookingFlightSegmentId,
                        _userId
                        );
            } catch {
                MessageBox.Show("Failed to checkin passenger");
            };

            passengersOnFlightDurian.RefreshPassengersOnFlight(checkinCombo.FlightId);
        }

        private void buttonCheckOut_Click(object sender, EventArgs e) {
            try {
                new BookingServiceClient()
                    .PassengerCheckOut(
                        passengersOnFlightDurian.BookingPassengerId,
                        passengersOnFlightDurian.BookingFlightSegmentId,
                        _userId
                        );
            } catch {
                MessageBox.Show("Failed to checkout passenger");
            };

            passengersOnFlightDurian.RefreshPassengersOnFlight(checkinCombo.FlightId);
        }

        private void checkinCombo_Picked(object sender, EventArgs e) {
            tabControl_SelectedIndexChanged(new object(), new EventArgs());
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e) {
            labelCountRows.Text = "0";

            if ( tabControl.SelectedTab == tabPageAll ) {
                passengersOnFlightDurian.RefreshPassengersOnFlight(checkinCombo.FlightId);
                labelCountRows.Text = passengersOnFlightDurian.Count.ToString();
            } else if ( tabControl.SelectedTab == tabPageCheckedIn ) {
                passengersOnFlightCheckedInDurian.RefreshPassengersOnFlightCheckedIn(checkinCombo.FlightId);
                labelCountRows.Text = passengersOnFlightCheckedInDurian.Count.ToString();
            } else if ( tabControl.SelectedTab == tabPageNoEvents ) {
                passengersOnFlightWithoutEventsDurian.RefreshPassengersOnFlightWithoutEvents(checkinCombo.FlightId);
                labelCountRows.Text = passengersOnFlightWithoutEventsDurian.Count.ToString();
            }
        }

        private void buttonNoEventsCheckin_Click(object sender, EventArgs e) {

            try {
                new BookingServiceClient()
                    .PassengerCheckIn(
                        passengersOnFlightWithoutEventsDurian.BookingPassengerId,
                        passengersOnFlightWithoutEventsDurian.BookingFlightSegmentId,
                        _userId
                        );
            } catch {
                MessageBox.Show("Failed to checkout passenger");
            };

            passengersOnFlightWithoutEventsDurian.RefreshPassengersOnFlightWithoutEvents(checkinCombo.FlightId);
        }

        private void buttonCheckedInCheckOut_Click(object sender, EventArgs e) {
            try {
                new BookingServiceClient()
                    .PassengerCheckOut(
                        passengersOnFlightCheckedInDurian.BookingPassengerId,
                        passengersOnFlightCheckedInDurian.BookingFlightSegmentId,
                        _userId
                        );
            } catch {
                MessageBox.Show("Failed to checkout passenger");
            };

            passengersOnFlightCheckedInDurian.RefreshPassengersOnFlightCheckedIn(checkinCombo.FlightId);
        }
    }
}
