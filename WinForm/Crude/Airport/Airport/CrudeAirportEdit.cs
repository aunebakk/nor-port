/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/4/2021 2:44:59 AM
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
    public partial class CrudeAirportEdit : Form {
        
        // holds the contract, with default values if in New modus, and fetched values in Edit modus
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a56
        private CrudeAirportContract _contract;
        
        private Boolean _isNew;
        
        // Constructs the form with a Save button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/60285c68-1faa-4eb4-bf34-b8c9086c7291
        public CrudeAirportEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with default values for comboboxes and pickers
        // links:
        //  docLink: http://sql2x.org/documentationLink/e04d0806-55ef-41cc-8669-acf0ddd850c7
        public void ShowAsAdd() {
            try {
                _contract = new CrudeAirportContract();
                _isNew = true;
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
                _contract = new CrudeAirportContract();
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
        public void ShowAsAddByCity(System.Guid cityId) {
            try {
                _contract = new CrudeAirportContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.CityId = cityId;
                cityPicker.SelectedValue = _contract.CityId;

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
        public void ShowAsAddByAirportType(string airportTypeRcd) {
            try {
                _contract = new CrudeAirportContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.AirportTypeRcd = airportTypeRcd;
                airportTypeRefCombo.Text = _contract.AirportTypeRcd != null ? _contract.AirportTypeRcd : String.Empty;

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
        public void ShowAsAddByTimezone(System.Guid timezoneId) {
            try {
                _contract = new CrudeAirportContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.TimezoneId = timezoneId;

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
        public void ShowAsAdd(string airportName, string airportTypeRcd, System.Guid cityId, System.Guid productId, decimal utcOffset, decimal elevationInMeters, decimal runwayInMeters, string latitude, string longitude, System.Guid timezoneId, string variation, string attendance, bool controlTowerFlag, System.DateTime activationDateTime, System.Guid userId) {
            try {
                _contract = new CrudeAirportContract();
                _isNew = true;
                _contract.AirportName = airportName;
                textBoxAirportName.Text = _contract.AirportName;
                _contract.AirportTypeRcd = airportTypeRcd;
                airportTypeRefCombo.Text = _contract.AirportTypeRcd != null ? _contract.AirportTypeRcd : String.Empty;
                _contract.CityId = cityId;
                cityPicker.SelectedValue = _contract.CityId;
                _contract.ProductId = productId;
                _contract.UtcOffset = utcOffset;
                maskedTextBoxUtcOffset.Text = _contract.UtcOffset.ToString();
                _contract.ElevationInMeters = elevationInMeters;
                maskedTextBoxElevationInMeters.Text = _contract.ElevationInMeters.ToString();
                _contract.RunwayInMeters = runwayInMeters;
                maskedTextBoxRunwayInMeters.Text = _contract.RunwayInMeters.ToString();
                _contract.Latitude = latitude;
                textBoxLatitude.Text = _contract.Latitude;
                _contract.Longitude = longitude;
                textBoxLongitude.Text = _contract.Longitude;
                _contract.TimezoneId = timezoneId;
                _contract.Variation = variation;
                textBoxVariation.Text = _contract.Variation;
                _contract.Attendance = attendance;
                textBoxAttendance.Text = _contract.Attendance;
                _contract.ControlTowerFlag = controlTowerFlag;
                checkBoxControlTowerFlag.Checked = _contract.ControlTowerFlag;
                _contract.ActivationDateTime = activationDateTime;
                dateTimePickerActivationDateTime.Value = _contract.ActivationDateTime != DateTime.MinValue ? _contract.ActivationDateTime : dateTimePickerActivationDateTime.MinDate;
                dateTimePickerActivationDateTime.Checked = _contract.ActivationDateTime != DateTime.MinValue;
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
        public void ShowAsEdit(System.Guid airportId) {
            var service = new CrudeAirportServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByAirportId(airportId);
                textBoxAirportName.Text = _contract.AirportName;
                airportTypeRefCombo.Text = _contract.AirportTypeRcd != null ? _contract.AirportTypeRcd : String.Empty;
                cityPicker.SelectedValue = _contract.CityId;
                maskedTextBoxUtcOffset.Text = _contract.UtcOffset.ToString();
                maskedTextBoxElevationInMeters.Text = _contract.ElevationInMeters.ToString();
                maskedTextBoxRunwayInMeters.Text = _contract.RunwayInMeters.ToString();
                textBoxLatitude.Text = _contract.Latitude;
                textBoxLongitude.Text = _contract.Longitude;
                textBoxVariation.Text = _contract.Variation;
                textBoxAttendance.Text = _contract.Attendance;
                checkBoxControlTowerFlag.Checked = _contract.ControlTowerFlag;
                dateTimePickerActivationDateTime.Value = _contract.ActivationDateTime != DateTime.MinValue ? _contract.ActivationDateTime : dateTimePickerActivationDateTime.MinDate;
                dateTimePickerActivationDateTime.Checked = _contract.ActivationDateTime != DateTime.MinValue;
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
            var service = new CrudeAirportServiceClient();
            try {
                _contract.AirportName = textBoxAirportName.Text;
                _contract.AirportTypeRcd = airportTypeRefCombo.Text;
                _contract.CityId = (Guid)cityPicker.SelectedValue;
                _contract.UtcOffset = maskedTextBoxUtcOffset.Text == String.Empty ? 0 : Convert.ToDecimal(maskedTextBoxUtcOffset.Text);
                _contract.ElevationInMeters = maskedTextBoxElevationInMeters.Text == String.Empty ? 0 : Convert.ToDecimal(maskedTextBoxElevationInMeters.Text);
                _contract.RunwayInMeters = maskedTextBoxRunwayInMeters.Text == String.Empty ? 0 : Convert.ToDecimal(maskedTextBoxRunwayInMeters.Text);
                _contract.Latitude = textBoxLatitude.Text;
                _contract.Longitude = textBoxLongitude.Text;
                _contract.Variation = textBoxVariation.Text;
                _contract.Attendance = textBoxAttendance.Text;
                _contract.ControlTowerFlag = Convert.ToBoolean(checkBoxControlTowerFlag.Checked);
                _contract.ActivationDateTime = dateTimePickerActivationDateTime.Checked ? Convert.ToDateTime(dateTimePickerActivationDateTime.Value): DateTime.MinValue;
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
