/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/2/2021 4:19:08 PM
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
    public partial class CrudeClientEdit : Form {
        
        // holds the contract, with default values if in New modus, and fetched values in Edit modus
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a56
        private CrudeClientContract _contract;
        
        private Boolean _isNew;
        
        // Constructs the form with a Save button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/60285c68-1faa-4eb4-bf34-b8c9086c7291
        public CrudeClientEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with default values for comboboxes and pickers
        // links:
        //  docLink: http://sql2x.org/documentationLink/e04d0806-55ef-41cc-8669-acf0ddd850c7
        public void ShowAsAdd() {
            try {
                _contract = new CrudeClientContract();
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
                _contract = new CrudeClientContract();
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
        public void ShowAsAddByAddress(System.Guid addressId) {
            try {
                _contract = new CrudeClientContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.AddressId = addressId;

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
        public void ShowAsAddByNationality(string nationalityRcd) {
            try {
                _contract = new CrudeClientContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.NationalityRcd = nationalityRcd;
                nationalityRefCombo.Text = _contract.NationalityRcd != null ? _contract.NationalityRcd : String.Empty;

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
        public void ShowAsAddByGender(string genderRcd) {
            try {
                _contract = new CrudeClientContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.GenderRcd = genderRcd;
                genderRefCombo.Text = _contract.GenderRcd != null ? _contract.GenderRcd : String.Empty;

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
        public void ShowAsAddByTitle(string titleRcd) {
            try {
                _contract = new CrudeClientContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.TitleRcd = titleRcd;
                titleRefCombo.Text = _contract.TitleRcd != null ? _contract.TitleRcd : String.Empty;

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
        public void ShowAsAddByClientType(string clientTypeRcd) {
            try {
                _contract = new CrudeClientContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.ClientTypeRcd = clientTypeRcd;
                clientTypeRefCombo.Text = _contract.ClientTypeRcd != null ? _contract.ClientTypeRcd : String.Empty;

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
        public void ShowAsAddByPassengerType(string passengerTypeRcd) {
            try {
                _contract = new CrudeClientContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.PassengerTypeRcd = passengerTypeRcd;
                passengerTypeRefCombo.Text = _contract.PassengerTypeRcd != null ? _contract.PassengerTypeRcd : String.Empty;

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
        public void ShowAsAdd(string firstName, string middleName, string lastName, System.Guid addressId, System.Guid defaultUserId, string passengerTypeRcd, string nationalityRcd, string genderRcd, string titleRcd, string clientTypeRcd, System.Guid userId) {
            try {
                _contract = new CrudeClientContract();
                _isNew = true;
                _contract.FirstName = firstName;
                textBoxFirstName.Text = _contract.FirstName;
                _contract.MiddleName = middleName;
                textBoxMiddleName.Text = _contract.MiddleName;
                _contract.LastName = lastName;
                textBoxLastName.Text = _contract.LastName;
                _contract.AddressId = addressId;
                _contract.DefaultUserId = defaultUserId;
                _contract.PassengerTypeRcd = passengerTypeRcd;
                passengerTypeRefCombo.Text = _contract.PassengerTypeRcd != null ? _contract.PassengerTypeRcd : String.Empty;
                _contract.NationalityRcd = nationalityRcd;
                nationalityRefCombo.Text = _contract.NationalityRcd != null ? _contract.NationalityRcd : String.Empty;
                _contract.GenderRcd = genderRcd;
                genderRefCombo.Text = _contract.GenderRcd != null ? _contract.GenderRcd : String.Empty;
                _contract.TitleRcd = titleRcd;
                titleRefCombo.Text = _contract.TitleRcd != null ? _contract.TitleRcd : String.Empty;
                _contract.ClientTypeRcd = clientTypeRcd;
                clientTypeRefCombo.Text = _contract.ClientTypeRcd != null ? _contract.ClientTypeRcd : String.Empty;
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
        public void ShowAsEdit(System.Guid clientId) {
            var service = new CrudeClientServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByClientId(clientId);
                textBoxFirstName.Text = _contract.FirstName;
                textBoxMiddleName.Text = _contract.MiddleName;
                textBoxLastName.Text = _contract.LastName;
                passengerTypeRefCombo.Text = _contract.PassengerTypeRcd != null ? _contract.PassengerTypeRcd : String.Empty;
                nationalityRefCombo.Text = _contract.NationalityRcd != null ? _contract.NationalityRcd : String.Empty;
                genderRefCombo.Text = _contract.GenderRcd != null ? _contract.GenderRcd : String.Empty;
                titleRefCombo.Text = _contract.TitleRcd != null ? _contract.TitleRcd : String.Empty;
                clientTypeRefCombo.Text = _contract.ClientTypeRcd != null ? _contract.ClientTypeRcd : String.Empty;
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
            var service = new CrudeClientServiceClient();
            try {
                _contract.FirstName = textBoxFirstName.Text;
                _contract.MiddleName = textBoxMiddleName.Text;
                _contract.LastName = textBoxLastName.Text;
                _contract.PassengerTypeRcd = passengerTypeRefCombo.Text;
                _contract.NationalityRcd = nationalityRefCombo.Text;
                _contract.GenderRcd = genderRefCombo.Text;
                _contract.TitleRcd = titleRefCombo.Text;
                _contract.ClientTypeRcd = clientTypeRefCombo.Text;
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
