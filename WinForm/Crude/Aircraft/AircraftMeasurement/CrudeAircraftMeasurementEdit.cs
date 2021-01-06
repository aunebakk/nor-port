/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/6/2021 1:09:18 PM
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
    public partial class CrudeAircraftMeasurementEdit : Form {
        
        // holds the contract, with default values if in New modus, and fetched values in Edit modus
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a56
        private CrudeAircraftMeasurementContract _contract;
        
        private Boolean _isNew;
        
        // Constructs the form with a Save button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/60285c68-1faa-4eb4-bf34-b8c9086c7291
        public CrudeAircraftMeasurementEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with default values for comboboxes and pickers
        // links:
        //  docLink: http://sql2x.org/documentationLink/e04d0806-55ef-41cc-8669-acf0ddd850c7
        public void ShowAsAdd() {
            try {
                _contract = new CrudeAircraftMeasurementContract();
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
                _contract = new CrudeAircraftMeasurementContract();
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
        
        // shows the form with default values for comboboxes and pickers
        // links:
        //  docLink: http://sql2x.org/documentationLink/f5685d96-a0bb-4f7b-beaa-b3d578c7cf28
        public void ShowAsAdd(decimal length, decimal height, decimal weight, decimal wingspan, decimal width, decimal payload, decimal takeoffWeightInKilo, decimal speed, System.Guid userId) {
            try {
                _contract = new CrudeAircraftMeasurementContract();
                _isNew = true;
                _contract.Length = length;
                maskedTextBoxLength.Text = _contract.Length.ToString();
                _contract.Height = height;
                maskedTextBoxHeight.Text = _contract.Height.ToString();
                _contract.Weight = weight;
                maskedTextBoxWeight.Text = _contract.Weight.ToString();
                _contract.Wingspan = wingspan;
                maskedTextBoxWingspan.Text = _contract.Wingspan.ToString();
                _contract.Width = width;
                maskedTextBoxWidth.Text = _contract.Width.ToString();
                _contract.Payload = payload;
                maskedTextBoxPayload.Text = _contract.Payload.ToString();
                _contract.TakeoffWeightInKilo = takeoffWeightInKilo;
                maskedTextBoxTakeoffWeightInKilo.Text = _contract.TakeoffWeightInKilo.ToString();
                _contract.Speed = speed;
                maskedTextBoxSpeed.Text = _contract.Speed.ToString();
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
        public void ShowAsEdit(System.Guid aircraftMeasurementId) {
            var service = new CrudeAircraftMeasurementServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByAircraftMeasurementId(aircraftMeasurementId);
                maskedTextBoxLength.Text = _contract.Length.ToString();
                maskedTextBoxHeight.Text = _contract.Height.ToString();
                maskedTextBoxWeight.Text = _contract.Weight.ToString();
                maskedTextBoxWingspan.Text = _contract.Wingspan.ToString();
                maskedTextBoxWidth.Text = _contract.Width.ToString();
                maskedTextBoxPayload.Text = _contract.Payload.ToString();
                maskedTextBoxTakeoffWeightInKilo.Text = _contract.TakeoffWeightInKilo.ToString();
                maskedTextBoxSpeed.Text = _contract.Speed.ToString();
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
            var service = new CrudeAircraftMeasurementServiceClient();
            try {
                _contract.Length = maskedTextBoxLength.Text == String.Empty ? 0 : Convert.ToDecimal(maskedTextBoxLength.Text);
                _contract.Height = maskedTextBoxHeight.Text == String.Empty ? 0 : Convert.ToDecimal(maskedTextBoxHeight.Text);
                _contract.Weight = maskedTextBoxWeight.Text == String.Empty ? 0 : Convert.ToDecimal(maskedTextBoxWeight.Text);
                _contract.Wingspan = maskedTextBoxWingspan.Text == String.Empty ? 0 : Convert.ToDecimal(maskedTextBoxWingspan.Text);
                _contract.Width = maskedTextBoxWidth.Text == String.Empty ? 0 : Convert.ToDecimal(maskedTextBoxWidth.Text);
                _contract.Payload = maskedTextBoxPayload.Text == String.Empty ? 0 : Convert.ToDecimal(maskedTextBoxPayload.Text);
                _contract.TakeoffWeightInKilo = maskedTextBoxTakeoffWeightInKilo.Text == String.Empty ? 0 : Convert.ToDecimal(maskedTextBoxTakeoffWeightInKilo.Text);
                _contract.Speed = maskedTextBoxSpeed.Text == String.Empty ? 0 : Convert.ToDecimal(maskedTextBoxSpeed.Text);
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
