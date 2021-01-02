/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/2/2021 4:19:13 PM
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
    public partial class CrudeFlightEdit : Form {
        
        // holds the contract, with default values if in New modus, and fetched values in Edit modus
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a56
        private CrudeFlightContract _contract;
        
        private Boolean _isNew;
        
        // Constructs the form with a Save button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/60285c68-1faa-4eb4-bf34-b8c9086c7291
        public CrudeFlightEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with default values for comboboxes and pickers
        // links:
        //  docLink: http://sql2x.org/documentationLink/e04d0806-55ef-41cc-8669-acf0ddd850c7
        public void ShowAsAdd() {
            try {
                _contract = new CrudeFlightContract();
                _isNew = true;
                this.Text += " - Not Savable (BindingFlight,Aircraft Missing)";
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
                _contract = new CrudeFlightContract();
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
        public void ShowAsAddByFlightAndBindingFlight(System.Guid bindingFlightId) {
            try {
                _contract = new CrudeFlightContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.BindingFlightId = bindingFlightId;

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
                _contract = new CrudeFlightContract();
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
        public void ShowAsAddByAirline(System.Guid airlineId) {
            try {
                _contract = new CrudeFlightContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.AirlineId = airlineId;
                airlinePicker.SelectedValue = _contract.AirlineId;

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
                _contract = new CrudeFlightContract();
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
        public void ShowAsAddByAircraftType(string aircraftTypeRcd) {
            try {
                _contract = new CrudeFlightContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.AircraftTypeRcd = aircraftTypeRcd;
                aircraftTypeRefCombo.Text = _contract.AircraftTypeRcd != null ? _contract.AircraftTypeRcd : String.Empty;

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
        public void ShowAsAddByAircraft(System.Guid aircraftId) {
            try {
                _contract = new CrudeFlightContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.AircraftId = aircraftId;

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
        public void ShowAsAdd(System.Guid becameFlightId, System.Guid bindingFlightId, System.Guid airlineId, System.Guid aircraftId, string aircraftTypeRcd, System.Guid departureAirportId, System.Guid arrivalAirportId, System.DateTime fromDateTime, System.DateTime untilDateTime, string comment, System.Guid userId) {
            try {
                _contract = new CrudeFlightContract();
                _isNew = true;
                _contract.BecameFlightId = becameFlightId;
                _contract.BindingFlightId = bindingFlightId;
                _contract.AirlineId = airlineId;
                airlinePicker.SelectedValue = _contract.AirlineId;
                _contract.AircraftId = aircraftId;
                _contract.AircraftTypeRcd = aircraftTypeRcd;
                aircraftTypeRefCombo.Text = _contract.AircraftTypeRcd != null ? _contract.AircraftTypeRcd : String.Empty;
                _contract.DepartureAirportId = departureAirportId;
                departureAirportPicker.SelectedValue = _contract.DepartureAirportId;
                _contract.ArrivalAirportId = arrivalAirportId;
                arrivalAirportPicker.SelectedValue = _contract.ArrivalAirportId;
                _contract.FromDateTime = fromDateTime;
                dateTimePickerFromDateTime.Value = _contract.FromDateTime != DateTime.MinValue ? _contract.FromDateTime : dateTimePickerFromDateTime.MinDate;
                dateTimePickerFromDateTime.Checked = _contract.FromDateTime != DateTime.MinValue;
                _contract.UntilDateTime = untilDateTime;
                dateTimePickerUntilDateTime.Value = _contract.UntilDateTime != DateTime.MinValue ? _contract.UntilDateTime : dateTimePickerUntilDateTime.MinDate;
                dateTimePickerUntilDateTime.Checked = _contract.UntilDateTime != DateTime.MinValue;
                _contract.Comment = comment;
                textBoxComment.Text = _contract.Comment;
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
        public void ShowAsEdit(System.Guid flightId) {
            var service = new CrudeFlightServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByFlightId(flightId);
                airlinePicker.SelectedValue = _contract.AirlineId;
                aircraftTypeRefCombo.Text = _contract.AircraftTypeRcd != null ? _contract.AircraftTypeRcd : String.Empty;
                departureAirportPicker.SelectedValue = _contract.DepartureAirportId;
                arrivalAirportPicker.SelectedValue = _contract.ArrivalAirportId;
                dateTimePickerFromDateTime.Value = _contract.FromDateTime != DateTime.MinValue ? _contract.FromDateTime : dateTimePickerFromDateTime.MinDate;
                dateTimePickerFromDateTime.Checked = _contract.FromDateTime != DateTime.MinValue;
                dateTimePickerUntilDateTime.Value = _contract.UntilDateTime != DateTime.MinValue ? _contract.UntilDateTime : dateTimePickerUntilDateTime.MinDate;
                dateTimePickerUntilDateTime.Checked = _contract.UntilDateTime != DateTime.MinValue;
                textBoxComment.Text = _contract.Comment;
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
            var service = new CrudeFlightServiceClient();
            try {
                _contract.AirlineId = (Guid)airlinePicker.SelectedValue;
                _contract.AircraftTypeRcd = aircraftTypeRefCombo.Text;
                _contract.DepartureAirportId = (Guid)departureAirportPicker.SelectedValue;
                _contract.ArrivalAirportId = (Guid)arrivalAirportPicker.SelectedValue;
                _contract.FromDateTime = dateTimePickerFromDateTime.Checked ? Convert.ToDateTime(dateTimePickerFromDateTime.Value): DateTime.MinValue;
                _contract.UntilDateTime = dateTimePickerUntilDateTime.Checked ? Convert.ToDateTime(dateTimePickerUntilDateTime.Value): DateTime.MinValue;
                _contract.Comment = textBoxComment.Text;
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
