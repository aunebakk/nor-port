/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/30/2020 9:30:21 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.TemplateWithDurianGenerator.UsingWinForm
*/
using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    // this form class is used to consume Crude SOAP Services through a WCF Proxy Client
    // this form class is used to consume Crude SOAP Services through a WCF Proxy Client
    // this form class is used to consume Crude SOAP Services through a WCF Proxy Client
    // links:
    //  docLink: http://sql2x.org/documentationLink/3d7a6660-be53-41aa-8f9d-7504e6026105
    public partial class AirportIdentifierEdit : Form {
        
        // holds the contract, with default values if in New modus, and fetched values in Edit modus
        // holds the contract, with default values if in New modus, and fetched values in Edit modus
        // holds the contract, with default values if in New modus, and fetched values in Edit modus
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a5a
        private CrudeAirportIdentifierContract _contract;
        
        // true if form is in New modus, else Edit modus
        // true if form is in New modus, else Edit modus
        // true if form is in New modus, else Edit modus
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a5b
        private Boolean _isNew;
        
        // Constructs the form with a Save button which is default on Enter
        //  and a Close button which works with the esc key
        // Constructs the form with a Save button which is default on Enter
        //  and a Close button which works with the esc key
        // Constructs the form with a Save button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/e6bf67b2-7eb4-4882-bf12-aa5ae6eec6bf
        public AirportIdentifierEdit() {
            InitializeComponent();
            InitializeGridAirportIdentifier();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        // bring up add form for AirportIdentifier
        // bring up add form for AirportIdentifier
        // bring up add form for AirportIdentifier
        // links:
        //  docLink: http://sql2x.org/documentationLink/c0944961-8179-40a2-a561-c8873b691f2c
        public void ShowAsAdd() {
            _contract = new CrudeAirportIdentifierContract();
            _isNew = true;
            RefreshAirportIdentifier();
            Show();
        }
        
        // bring up add form for AirportIdentifier with rules
        // bring up add form for AirportIdentifier with rules
        // bring up add form for AirportIdentifier with rules
        // links:
        //  docLink: http://sql2x.org/documentationLink/6018e96e-28a1-4df4-879b-01a6bda81cc7
        public void ShowAsAddByRules(System.Guid userId) {
            _contract = new CrudeAirportIdentifierContract();
            _isNew = true;
            _contract.UserId = userId;
            userPicker.SelectedValue = _contract.UserId;
            _contract.DateTime = DateTime.UtcNow;
            dateTimePickerDateTime.Text = _contract.DateTime.ToString();

            RefreshAirportIdentifier();
            Show();
        }
        
        // bring up add form for AirportIdentifier by foreign key AirportAndAirportIdentifierType
        // bring up add form for AirportIdentifier by foreign key AirportAndAirportIdentifierType
        // bring up add form for AirportIdentifier by foreign key AirportAndAirportIdentifierType
        // links:
        //  docLink: http://sql2x.org/documentationLink/2461e69c-dd05-47db-8f32-27ac1641a8d9
        public void ShowAsAddByAirportAndAirportIdentifierType(System.Guid airportId, string airportIdentifierTypeRcd) {
            _contract = new CrudeAirportIdentifierContract();
            _isNew = true;
            _contract.DateTime = DateTime.UtcNow;
            dateTimePickerDateTime.Text = _contract.DateTime.ToString();
            _contract.AirportId = airportId;
            airportPicker.SelectedValue = _contract.AirportId;
            _contract.AirportIdentifierTypeRcd = airportIdentifierTypeRcd;
            airportIdentifierTypeRefCombo.Text = _contract.AirportIdentifierTypeRcd != null ? _contract.AirportIdentifierTypeRcd : String.Empty;

            RefreshAirportIdentifier();
            Show();
        }
        
        // bring up add form for AirportIdentifier by foreign key Airport
        // bring up add form for AirportIdentifier by foreign key Airport
        // bring up add form for AirportIdentifier by foreign key Airport
        // links:
        //  docLink: http://sql2x.org/documentationLink/2461e69c-dd05-47db-8f32-27ac1641a8d9
        public void ShowAsAddByAirport(System.Guid airportId) {
            _contract = new CrudeAirportIdentifierContract();
            _isNew = true;
            _contract.DateTime = DateTime.UtcNow;
            dateTimePickerDateTime.Text = _contract.DateTime.ToString();
            _contract.AirportId = airportId;
            airportPicker.SelectedValue = _contract.AirportId;

            RefreshAirportIdentifier();
            Show();
        }
        
        // bring up add form for AirportIdentifier
        // bring up add form for AirportIdentifier
        // bring up add form for AirportIdentifier
        // links:
        //  docLink: http://sql2x.org/documentationLink/8568fd9a-b807-4aad-ac74-7826975e3241
        public void ShowAsAdd(System.Guid airportId, string airportIdentifierTypeRcd, string airportIdentifierCode, System.Guid userId) {
            _contract = new CrudeAirportIdentifierContract();
            _isNew = true;
            _contract.AirportId = airportId;
            airportPicker.SelectedValue = _contract.AirportId;
            _contract.AirportIdentifierTypeRcd = airportIdentifierTypeRcd;
            airportIdentifierTypeRefCombo.Text = _contract.AirportIdentifierTypeRcd != null ? _contract.AirportIdentifierTypeRcd : String.Empty;
            _contract.AirportIdentifierCode = airportIdentifierCode;
            textBoxAirportIdentifierCode.Text = _contract.AirportIdentifierCode;
            _contract.UserId = userId;
            userPicker.SelectedValue = userId;
            _contract.DateTime = DateTime.UtcNow;
            dateTimePickerDateTime.Text = _contract.DateTime.ToString();

            RefreshAirportIdentifier();
            Show();
        }
        
        // bring up edit form for AirportIdentifier
        // bring up edit form for AirportIdentifier
        // bring up edit form for AirportIdentifier
        // links:
        //  docLink: http://sql2x.org/documentationLink/d7ff032d-3bcf-438f-9850-900ca0ebca98
        public void ShowAsEdit(System.Guid airportIdentifierId) {
            var service = new CrudeAirportIdentifierServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByAirportIdentifierId(airportIdentifierId);
                airportPicker.SelectedValue = _contract.AirportId;
                airportIdentifierTypeRefCombo.Text = _contract.AirportIdentifierTypeRcd != null ? _contract.AirportIdentifierTypeRcd : String.Empty;
                textBoxAirportIdentifierCode.Text = _contract.AirportIdentifierCode;
                userPicker.SelectedValue = _contract.UserId;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();

                RefreshAirportIdentifier();
                Show();
            } catch (Exception ex) {
                MessageBox.Show (ex.Message);
            } finally {
                service.Close();
            }
        }
        
        // save and close AirportIdentifier
        // save and close AirportIdentifier
        // save and close AirportIdentifier
        // links:
        //  docLink: http://sql2x.org/documentationLink/d71519ff-fa27-4f64-9194-56886e4070ba
        private void buttonSave_Click(object sender, EventArgs e) {
            var service = new CrudeAirportIdentifierServiceClient();
            try {
                _contract.AirportId = (Guid)airportPicker.SelectedValue;
                _contract.AirportIdentifierTypeRcd = airportIdentifierTypeRefCombo.Text;
                _contract.AirportIdentifierCode = textBoxAirportIdentifierCode.Text;
                _contract.UserId = (Guid)userPicker.SelectedValue;

                if (_isNew)
                    service.Insert(_contract);
                else
                    service.Update(_contract);
            } catch (Exception ex) {
                MessageBox.Show (ex.Message);
            } finally {
                service.Close();
            }

            Close();
        }
        
        // search AirportIdentifier
        // search AirportIdentifier
        // search AirportIdentifier
        // links:
        //  docLink: http://sql2x.org/documentationLink/80a1bfbb-de84-4829-b248-3618a1657aae
        private void buttonAirportIdentifierSearch_Click(object sender, EventArgs e) {
            RefreshAirportIdentifier();
        }
        
        // bring up edit form for AirportIdentifier
        // bring up edit form for AirportIdentifier
        // bring up edit form for AirportIdentifier
        // links:
        //  docLink: http://sql2x.org/documentationLink/634a3333-2588-4ce9-a69e-146e6db06604
        private void buttonAirportIdentifierEdit_Click(object sender, EventArgs e) {
            // no code because ChildDefinition is missing
        }
        
        // bring up add form for AirportIdentifier
        // bring up add form for AirportIdentifier
        // bring up add form for AirportIdentifier
        // links:
        //  docLink: http://sql2x.org/documentationLink/8a47adae-c002-48ab-8926-9daa6f237b92
        private void buttonAirportIdentifierAdd_Click(object sender, EventArgs e) {
            // no code because ChildDefinition is missing
        }
        
        // bring up edit form for AirportIdentifier
        // bring up edit form for AirportIdentifier
        // bring up edit form for AirportIdentifier
        // links:
        //  docLink: http://sql2x.org/documentationLink/a0d70634-76b1-43a0-bf41-c77b3ab4107f
        private void dataGridViewAirportIdentifier_DoubleClick(object sender, EventArgs e) {
            var editForm = new AirportIdentifierEdit();
            editForm.MdiParent = this.MdiParent;
            // no code because ChildDefinition is missing
        }
        
        // close form for AirportIdentifier
        // close form for AirportIdentifier
        // close form for AirportIdentifier
        // links:
        //  docLink: http://sql2x.org/documentationLink/6cba4762-d598-4fc1-a165-225b3b86183f
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        // refresh AirportIdentifier's
        // refresh AirportIdentifier's
        // refresh AirportIdentifier's
        // links:
        //  docLink: http://sql2x.org/documentationLink/40b9491c-7991-43e7-9e8d-06181fd0a7c6
        public void RefreshAirportIdentifier() {
            // no code because ChildDefinition is missing}
        }
        
        // initialize grid for AirportIdentifier
        // initialize grid for AirportIdentifier
        // initialize grid for AirportIdentifier
        // links:
        //  docLink: http://sql2x.org/documentationLink/680c9cdb-dd8c-46bb-bb39-82bc124ebf5b
        private void InitializeGridAirportIdentifier() {
            dataGridViewAirportIdentifier.Columns.Clear();
            dataGridViewAirportIdentifier.AutoGenerateColumns = false;
            dataGridViewAirportIdentifier.Columns.Add("ExtensionData", "");
            dataGridViewAirportIdentifier.Columns["ExtensionData"].Visible = false;

            dataGridViewAirportIdentifier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewAirportIdentifier.AutoResizeColumns();
        }
    }
}
