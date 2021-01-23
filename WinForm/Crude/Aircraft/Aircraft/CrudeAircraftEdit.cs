﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/23/2021 4:49:29 PM
  From Machine: DESKTOP-9A2DH39
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
    public partial class CrudeAircraftEdit : Form {
        
        // holds the contract, with default values if in New modus, and fetched values in Edit modus
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a56
        private CrudeAircraftContract _contract;
        
        private Boolean _isNew;
        
        // Constructs the form with a Save button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/60285c68-1faa-4eb4-bf34-b8c9086c7291
        public CrudeAircraftEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with default values for comboboxes and pickers
        // links:
        //  docLink: http://sql2x.org/documentationLink/e04d0806-55ef-41cc-8669-acf0ddd850c7
        public void ShowAsAdd() {
            try {
                _contract = new CrudeAircraftContract();
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
                _contract = new CrudeAircraftContract();
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
        public void ShowAsAddByAircraftBody(string aircraftBodyRcd) {
            try {
                _contract = new CrudeAircraftContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.AircraftBodyRcd = aircraftBodyRcd;
                aircraftBodyRefCombo.Text = _contract.AircraftBodyRcd != null ? _contract.AircraftBodyRcd : String.Empty;

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
        public void ShowAsAddByAircraftConfiguration(string aircraftConfigurationRcd) {
            try {
                _contract = new CrudeAircraftContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.AircraftConfigurationRcd = aircraftConfigurationRcd;
                aircraftConfigurationRefCombo.Text = _contract.AircraftConfigurationRcd != null ? _contract.AircraftConfigurationRcd : String.Empty;

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
                _contract = new CrudeAircraftContract();
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
        public void ShowAsAddByAircraftMeasurement(System.Guid aircraftMeasurementId) {
            try {
                _contract = new CrudeAircraftContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.AircraftMeasurementId = aircraftMeasurementId;

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
        public void ShowAsAdd(string aircraftName, string aircraftTypeRcd, string aircraftConfigurationRcd, string aircraftBodyRcd, System.Guid aircraftMeasurementId, System.Guid productId, System.DateTime operationalDateTime, System.DateTime firstFlightDateTime, string engineType, int passengerCapacity, System.Guid userId) {
            try {
                _contract = new CrudeAircraftContract();
                _isNew = true;
                _contract.AircraftName = aircraftName;
                textBoxAircraftName.Text = _contract.AircraftName;
                _contract.AircraftTypeRcd = aircraftTypeRcd;
                aircraftTypeRefCombo.Text = _contract.AircraftTypeRcd != null ? _contract.AircraftTypeRcd : String.Empty;
                _contract.AircraftConfigurationRcd = aircraftConfigurationRcd;
                aircraftConfigurationRefCombo.Text = _contract.AircraftConfigurationRcd != null ? _contract.AircraftConfigurationRcd : String.Empty;
                _contract.AircraftBodyRcd = aircraftBodyRcd;
                aircraftBodyRefCombo.Text = _contract.AircraftBodyRcd != null ? _contract.AircraftBodyRcd : String.Empty;
                _contract.AircraftMeasurementId = aircraftMeasurementId;
                _contract.ProductId = productId;
                _contract.OperationalDateTime = operationalDateTime;
                dateTimePickerOperationalDateTime.Value = _contract.OperationalDateTime != DateTime.MinValue ? _contract.OperationalDateTime : dateTimePickerOperationalDateTime.MinDate;
                dateTimePickerOperationalDateTime.Checked = _contract.OperationalDateTime != DateTime.MinValue;
                _contract.FirstFlightDateTime = firstFlightDateTime;
                dateTimePickerFirstFlightDateTime.Value = _contract.FirstFlightDateTime != DateTime.MinValue ? _contract.FirstFlightDateTime : dateTimePickerFirstFlightDateTime.MinDate;
                dateTimePickerFirstFlightDateTime.Checked = _contract.FirstFlightDateTime != DateTime.MinValue;
                _contract.EngineType = engineType;
                textBoxEngineType.Text = _contract.EngineType;
                _contract.PassengerCapacity = passengerCapacity;
                maskedTextBoxPassengerCapacity.Text = _contract.PassengerCapacity.ToString();
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
        public void ShowAsEdit(System.Guid aircraftId) {
            var service = new CrudeAircraftServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByAircraftId(aircraftId);
                textBoxAircraftName.Text = _contract.AircraftName;
                aircraftTypeRefCombo.Text = _contract.AircraftTypeRcd != null ? _contract.AircraftTypeRcd : String.Empty;
                aircraftConfigurationRefCombo.Text = _contract.AircraftConfigurationRcd != null ? _contract.AircraftConfigurationRcd : String.Empty;
                aircraftBodyRefCombo.Text = _contract.AircraftBodyRcd != null ? _contract.AircraftBodyRcd : String.Empty;
                dateTimePickerOperationalDateTime.Value = _contract.OperationalDateTime != DateTime.MinValue ? _contract.OperationalDateTime : dateTimePickerOperationalDateTime.MinDate;
                dateTimePickerOperationalDateTime.Checked = _contract.OperationalDateTime != DateTime.MinValue;
                dateTimePickerFirstFlightDateTime.Value = _contract.FirstFlightDateTime != DateTime.MinValue ? _contract.FirstFlightDateTime : dateTimePickerFirstFlightDateTime.MinDate;
                dateTimePickerFirstFlightDateTime.Checked = _contract.FirstFlightDateTime != DateTime.MinValue;
                textBoxEngineType.Text = _contract.EngineType;
                maskedTextBoxPassengerCapacity.Text = _contract.PassengerCapacity.ToString();
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
            var service = new CrudeAircraftServiceClient();
            try {
                _contract.AircraftName = textBoxAircraftName.Text;
                _contract.AircraftTypeRcd = aircraftTypeRefCombo.Text;
                _contract.AircraftConfigurationRcd = aircraftConfigurationRefCombo.Text;
                _contract.AircraftBodyRcd = aircraftBodyRefCombo.Text;
                _contract.OperationalDateTime = dateTimePickerOperationalDateTime.Checked ? Convert.ToDateTime(dateTimePickerOperationalDateTime.Value): DateTime.MinValue;
                _contract.FirstFlightDateTime = dateTimePickerFirstFlightDateTime.Checked ? Convert.ToDateTime(dateTimePickerFirstFlightDateTime.Value): DateTime.MinValue;
                _contract.EngineType = textBoxEngineType.Text;
                _contract.PassengerCapacity = maskedTextBoxPassengerCapacity.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxPassengerCapacity.Text);
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
