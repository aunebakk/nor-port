/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/31/2020 7:19:56 AM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateEditStyle3
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using SolutionNorSolutionPort.BusinessLogicLayer;

// Client WinForm Layer
// the Client WinForm Layer uses the Proxy Layer to tie into SOAP services
// links:
//  docLink: http://sql2x.org/documentationLink/cd82fac1-15df-4881-b376-80b77ab185d0
namespace SolutionNorSolutionPort.UserInterface {

    // this form class is used to consume Crude SOAP Services through a WCF Proxy Client
    // links:
    //  docLink: http://sql2x.org/documentationLink/43b6be6f-d1b6-4470-937c-dbf4588a80ee
    public partial class CrudeFlightScheduleSegmentEdit : Form {
        
        // holds the contract, with default values if in New modus, and fetched values in Edit modus
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a56
        private CrudeFlightScheduleSegmentContract _contract;
        
        private Boolean _isNew;
        
        // Constructs the form with a Save button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/60285c68-1faa-4eb4-bf34-b8c9086c7291
        public CrudeFlightScheduleSegmentEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with default values for comboboxes and pickers
        // links:
        //  docLink: http://sql2x.org/documentationLink/e04d0806-55ef-41cc-8669-acf0ddd850c7
        public void ShowAsAdd() {
            try {
                _contract = new CrudeFlightScheduleSegmentContract();
                _isNew = true;
                this.Text += " - Not Savable (FlightSchedule Missing)";
                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the form with default values for comboboxes and pickers
        // links:
        //  docLink: http://sql2x.org/documentationLink/599dcb45-f71b-4672-bb18-46975a4fe9b3
        public void ShowAsAddByRules(System.Guid userId) {
            try {
                _contract = new CrudeFlightScheduleSegmentContract();
                _isNew = true;
                _contract.UserId = userId;
                userPicker.SelectedValue = _contract.UserId;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows by foreign keys
        // links:
        //  docLink: http://sql2x.org/documentationLink/f21e72c1-2d57-44c1-a9c1-1b80bad6a391
        public void ShowAsAddByDepartureAirport(System.Guid departureAirportId) {
            try {
                _contract = new CrudeFlightScheduleSegmentContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.DepartureAirportId = departureAirportId;
                departureAirportPicker.SelectedValue = _contract.DepartureAirportId;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows by foreign keys
        // links:
        //  docLink: http://sql2x.org/documentationLink/f21e72c1-2d57-44c1-a9c1-1b80bad6a391
        public void ShowAsAddByArrivalAirport(System.Guid arrivalAirportId) {
            try {
                _contract = new CrudeFlightScheduleSegmentContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.ArrivalAirportId = arrivalAirportId;
                arrivalAirportPicker.SelectedValue = _contract.ArrivalAirportId;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows by foreign keys
        // links:
        //  docLink: http://sql2x.org/documentationLink/f21e72c1-2d57-44c1-a9c1-1b80bad6a391
        public void ShowAsAddByFlightSchedule(System.Guid flightScheduleId) {
            try {
                _contract = new CrudeFlightScheduleSegmentContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.FlightScheduleId = flightScheduleId;

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the form with default values for comboboxes and pickers
        // links:
        //  docLink: http://sql2x.org/documentationLink/f5685d96-a0bb-4f7b-beaa-b3d578c7cf28
        public void ShowAsAdd(System.Guid flightScheduleId, System.Guid departureAirportId, System.Guid arrivalAirportId, int physicalSegmentNumber, int logicalSegmentNumber, System.TimeSpan departureTime, System.TimeSpan arrivalTime, string departureGate, string arrivalGate, System.Guid userId) {
            try {
                _contract = new CrudeFlightScheduleSegmentContract();
                _isNew = true;
                _contract.FlightScheduleId = flightScheduleId;
                _contract.DepartureAirportId = departureAirportId;
                departureAirportPicker.SelectedValue = _contract.DepartureAirportId;
                _contract.ArrivalAirportId = arrivalAirportId;
                arrivalAirportPicker.SelectedValue = _contract.ArrivalAirportId;
                _contract.PhysicalSegmentNumber = physicalSegmentNumber;
                maskedTextBoxPhysicalSegmentNumber.Text = _contract.PhysicalSegmentNumber.ToString();
                _contract.LogicalSegmentNumber = logicalSegmentNumber;
                maskedTextBoxLogicalSegmentNumber.Text = _contract.LogicalSegmentNumber.ToString();
                _contract.DepartureTime = departureTime;
                textBoxDepartureTime.Text = _contract.DepartureTime.ToString();
                _contract.ArrivalTime = arrivalTime;
                textBoxArrivalTime.Text = _contract.ArrivalTime.ToString();
                _contract.DepartureGate = departureGate;
                textBoxDepartureGate.Text = _contract.DepartureGate;
                _contract.ArrivalGate = arrivalGate;
                textBoxArrivalGate.Text = _contract.ArrivalGate;
                _contract.UserId = userId;
                userPicker.SelectedValue = userId;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the form in edit modus
        // links:
        //  docLink: http://sql2x.org/documentationLink/49afd26c-4f21-4992-967b-be190eacef77
        public void ShowAsEdit(System.Guid flightScheduleSegmentId) {
            var service = new CrudeFlightScheduleSegmentServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByFlightScheduleSegmentId(flightScheduleSegmentId);
                departureAirportPicker.SelectedValue = _contract.DepartureAirportId;
                arrivalAirportPicker.SelectedValue = _contract.ArrivalAirportId;
                maskedTextBoxPhysicalSegmentNumber.Text = _contract.PhysicalSegmentNumber.ToString();
                maskedTextBoxLogicalSegmentNumber.Text = _contract.LogicalSegmentNumber.ToString();
                textBoxDepartureTime.Text = _contract.DepartureTime.ToString();
                textBoxArrivalTime.Text = _contract.ArrivalTime.ToString();
                textBoxDepartureGate.Text = _contract.DepartureGate;
                textBoxArrivalGate.Text = _contract.ArrivalGate;
                userPicker.SelectedValue = _contract.UserId;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();

                Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                service.Close();
            }
        }
        
        // saves the form
        // links:
        //  docLink: http://sql2x.org/documentationLink/c9522930-91f8-4468-a936-8030bb2a6482
        private void buttonSave_Click(object sender, EventArgs e) {
            var service = new CrudeFlightScheduleSegmentServiceClient();
            try {
                _contract.DepartureAirportId = (Guid)departureAirportPicker.SelectedValue;
                _contract.ArrivalAirportId = (Guid)arrivalAirportPicker.SelectedValue;
                _contract.PhysicalSegmentNumber = maskedTextBoxPhysicalSegmentNumber.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxPhysicalSegmentNumber.Text);
                _contract.LogicalSegmentNumber = maskedTextBoxLogicalSegmentNumber.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxLogicalSegmentNumber.Text);
                _contract.DepartureTime = TimeSpan.Parse(textBoxDepartureTime.Text);
                _contract.ArrivalTime = TimeSpan.Parse(textBoxArrivalTime.Text);
                _contract.DepartureGate = textBoxDepartureGate.Text;
                _contract.ArrivalGate = textBoxArrivalGate.Text;
                _contract.UserId = (Guid)userPicker.SelectedValue;

                if (_isNew)
                    service.Insert(_contract);
                else
                    service.Update(_contract);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                service.Close();
            }

            Close();
        }
        
        // closes the form
        // links:
        //  docLink: http://sql2x.org/documentationLink/876f1492-f546-42ac-aae3-11837d1d842a
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
