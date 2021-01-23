﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/23/2021 4:49:27 PM
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
    public partial class CrudeAddressEdit : Form {
        
        // holds the contract, with default values if in New modus, and fetched values in Edit modus
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a56
        private CrudeAddressContract _contract;
        
        private Boolean _isNew;
        
        // Constructs the form with a Save button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/60285c68-1faa-4eb4-bf34-b8c9086c7291
        public CrudeAddressEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with default values for comboboxes and pickers
        // links:
        //  docLink: http://sql2x.org/documentationLink/e04d0806-55ef-41cc-8669-acf0ddd850c7
        public void ShowAsAdd() {
            try {
                _contract = new CrudeAddressContract();
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
                _contract = new CrudeAddressContract();
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
        public void ShowAsAddByAddressType(string addressTypeRcd) {
            try {
                _contract = new CrudeAddressContract();
                _isNew = true;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();
                _contract.AddressTypeRcd = addressTypeRcd;
                addressTypeRefCombo.Text = _contract.AddressTypeRcd != null ? _contract.AddressTypeRcd : String.Empty;

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
        public void ShowAsAdd(string addressTypeRcd, string addressOne, string addressTwo, string addressThree, string city, string street, string state, string district, string province, string zipCode, string poBox, string comment, System.Guid userId) {
            try {
                _contract = new CrudeAddressContract();
                _isNew = true;
                _contract.AddressTypeRcd = addressTypeRcd;
                addressTypeRefCombo.Text = _contract.AddressTypeRcd != null ? _contract.AddressTypeRcd : String.Empty;
                _contract.AddressOne = addressOne;
                textBoxAddressOne.Text = _contract.AddressOne;
                _contract.AddressTwo = addressTwo;
                textBoxAddressTwo.Text = _contract.AddressTwo;
                _contract.AddressThree = addressThree;
                textBoxAddressThree.Text = _contract.AddressThree;
                _contract.City = city;
                textBoxCity.Text = _contract.City;
                _contract.Street = street;
                textBoxStreet.Text = _contract.Street;
                _contract.State = state;
                textBoxState.Text = _contract.State;
                _contract.District = district;
                textBoxDistrict.Text = _contract.District;
                _contract.Province = province;
                textBoxProvince.Text = _contract.Province;
                _contract.ZipCode = zipCode;
                textBoxZipCode.Text = _contract.ZipCode;
                _contract.PoBox = poBox;
                textBoxPoBox.Text = _contract.PoBox;
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
        public void ShowAsEdit(System.Guid addressId) {
            var service = new CrudeAddressServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByAddressId(addressId);
                addressTypeRefCombo.Text = _contract.AddressTypeRcd != null ? _contract.AddressTypeRcd : String.Empty;
                textBoxAddressOne.Text = _contract.AddressOne;
                textBoxAddressTwo.Text = _contract.AddressTwo;
                textBoxAddressThree.Text = _contract.AddressThree;
                textBoxCity.Text = _contract.City;
                textBoxStreet.Text = _contract.Street;
                textBoxState.Text = _contract.State;
                textBoxDistrict.Text = _contract.District;
                textBoxProvince.Text = _contract.Province;
                textBoxZipCode.Text = _contract.ZipCode;
                textBoxPoBox.Text = _contract.PoBox;
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
            var service = new CrudeAddressServiceClient();
            try {
                _contract.AddressTypeRcd = addressTypeRefCombo.Text;
                _contract.AddressOne = textBoxAddressOne.Text;
                _contract.AddressTwo = textBoxAddressTwo.Text;
                _contract.AddressThree = textBoxAddressThree.Text;
                _contract.City = textBoxCity.Text;
                _contract.Street = textBoxStreet.Text;
                _contract.State = textBoxState.Text;
                _contract.District = textBoxDistrict.Text;
                _contract.Province = textBoxProvince.Text;
                _contract.ZipCode = textBoxZipCode.Text;
                _contract.PoBox = textBoxPoBox.Text;
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
