/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/27/2020 11:15:07 PM
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
//  client winform layer: https://docs.microsoft.com/en-us/dotnet/framework/winforms/
//  docLink: http://sql2x.org/documentationLink/cd82fac1-15df-4881-b376-80b77ab185d0
namespace SolutionNorSolutionPort.UserInterface {

    // this form class is used to consume Crude SOAP Services through a WCF Proxy Client
    // links:
    //  docLink: http://sql2x.org/documentationLink/43b6be6f-d1b6-4470-937c-dbf4588a80ee
    public partial class CrudeAircraftCompartmentMeasurementEdit : Form {
        
        // holds the contract, with default values if in New modus, and fetched values in Edit modus
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a56
        private CrudeAircraftCompartmentMeasurementContract _contract;
        
        private Boolean _isNew;
        
        // Constructs the form with a Save button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/60285c68-1faa-4eb4-bf34-b8c9086c7291
        public CrudeAircraftCompartmentMeasurementEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with default values for comboboxes and pickers
        // links:
        //  docLink: http://sql2x.org/documentationLink/e04d0806-55ef-41cc-8669-acf0ddd850c7
        public void ShowAsAdd() {
            try {
                _contract = new CrudeAircraftCompartmentMeasurementContract();
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
                _contract = new CrudeAircraftCompartmentMeasurementContract();
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
        public void ShowAsAdd(decimal length, decimal height, decimal width, decimal payloadInKilo, int unitLoadDevicePositions, int carryOnBinCount, int carryOnPiecesAllowedCount, int carryOnPieceMaxWeightInKilo, int infantLimit, int bookableLimit, int passengerLimit, int rowCount, int columnCount, System.Guid userId) {
            try {
                _contract = new CrudeAircraftCompartmentMeasurementContract();
                _isNew = true;
                _contract.Length = length;
                maskedTextBoxLength.Text = _contract.Length.ToString();
                _contract.Height = height;
                maskedTextBoxHeight.Text = _contract.Height.ToString();
                _contract.Width = width;
                maskedTextBoxWidth.Text = _contract.Width.ToString();
                _contract.PayloadInKilo = payloadInKilo;
                maskedTextBoxPayloadInKilo.Text = _contract.PayloadInKilo.ToString();
                _contract.UnitLoadDevicePositions = unitLoadDevicePositions;
                maskedTextBoxUnitLoadDevicePositions.Text = _contract.UnitLoadDevicePositions.ToString();
                _contract.CarryOnBinCount = carryOnBinCount;
                maskedTextBoxCarryOnBinCount.Text = _contract.CarryOnBinCount.ToString();
                _contract.CarryOnPiecesAllowedCount = carryOnPiecesAllowedCount;
                maskedTextBoxCarryOnPiecesAllowedCount.Text = _contract.CarryOnPiecesAllowedCount.ToString();
                _contract.CarryOnPieceMaxWeightInKilo = carryOnPieceMaxWeightInKilo;
                maskedTextBoxCarryOnPieceMaxWeightInKilo.Text = _contract.CarryOnPieceMaxWeightInKilo.ToString();
                _contract.InfantLimit = infantLimit;
                maskedTextBoxInfantLimit.Text = _contract.InfantLimit.ToString();
                _contract.BookableLimit = bookableLimit;
                maskedTextBoxBookableLimit.Text = _contract.BookableLimit.ToString();
                _contract.PassengerLimit = passengerLimit;
                maskedTextBoxPassengerLimit.Text = _contract.PassengerLimit.ToString();
                _contract.RowCount = rowCount;
                maskedTextBoxRowCount.Text = _contract.RowCount.ToString();
                _contract.ColumnCount = columnCount;
                maskedTextBoxColumnCount.Text = _contract.ColumnCount.ToString();
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
        public void ShowAsEdit(System.Guid aircraftCompartmentMeasurementId) {
            var service = new CrudeAircraftCompartmentMeasurementServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByAircraftCompartmentMeasurementId(aircraftCompartmentMeasurementId);
                maskedTextBoxLength.Text = _contract.Length.ToString();
                maskedTextBoxHeight.Text = _contract.Height.ToString();
                maskedTextBoxWidth.Text = _contract.Width.ToString();
                maskedTextBoxPayloadInKilo.Text = _contract.PayloadInKilo.ToString();
                maskedTextBoxUnitLoadDevicePositions.Text = _contract.UnitLoadDevicePositions.ToString();
                maskedTextBoxCarryOnBinCount.Text = _contract.CarryOnBinCount.ToString();
                maskedTextBoxCarryOnPiecesAllowedCount.Text = _contract.CarryOnPiecesAllowedCount.ToString();
                maskedTextBoxCarryOnPieceMaxWeightInKilo.Text = _contract.CarryOnPieceMaxWeightInKilo.ToString();
                maskedTextBoxInfantLimit.Text = _contract.InfantLimit.ToString();
                maskedTextBoxBookableLimit.Text = _contract.BookableLimit.ToString();
                maskedTextBoxPassengerLimit.Text = _contract.PassengerLimit.ToString();
                maskedTextBoxRowCount.Text = _contract.RowCount.ToString();
                maskedTextBoxColumnCount.Text = _contract.ColumnCount.ToString();
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
            var service = new CrudeAircraftCompartmentMeasurementServiceClient();
            try {
                _contract.Length = maskedTextBoxLength.Text == String.Empty ? 0 : Convert.ToDecimal(maskedTextBoxLength.Text);
                _contract.Height = maskedTextBoxHeight.Text == String.Empty ? 0 : Convert.ToDecimal(maskedTextBoxHeight.Text);
                _contract.Width = maskedTextBoxWidth.Text == String.Empty ? 0 : Convert.ToDecimal(maskedTextBoxWidth.Text);
                _contract.PayloadInKilo = maskedTextBoxPayloadInKilo.Text == String.Empty ? 0 : Convert.ToDecimal(maskedTextBoxPayloadInKilo.Text);
                _contract.UnitLoadDevicePositions = maskedTextBoxUnitLoadDevicePositions.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxUnitLoadDevicePositions.Text);
                _contract.CarryOnBinCount = maskedTextBoxCarryOnBinCount.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxCarryOnBinCount.Text);
                _contract.CarryOnPiecesAllowedCount = maskedTextBoxCarryOnPiecesAllowedCount.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxCarryOnPiecesAllowedCount.Text);
                _contract.CarryOnPieceMaxWeightInKilo = maskedTextBoxCarryOnPieceMaxWeightInKilo.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxCarryOnPieceMaxWeightInKilo.Text);
                _contract.InfantLimit = maskedTextBoxInfantLimit.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxInfantLimit.Text);
                _contract.BookableLimit = maskedTextBoxBookableLimit.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxBookableLimit.Text);
                _contract.PassengerLimit = maskedTextBoxPassengerLimit.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxPassengerLimit.Text);
                _contract.RowCount = maskedTextBoxRowCount.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxRowCount.Text);
                _contract.ColumnCount = maskedTextBoxColumnCount.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxColumnCount.Text);
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
