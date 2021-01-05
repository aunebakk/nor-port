/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/5/2021 6:03:33 AM
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
    // links:
    //  docLink: http://sql2x.org/documentationLink/3d7a6660-be53-41aa-8f9d-7504e6026105
    public partial class AirlineEdit : Form {
        
        // holds the contract, with default values if in New modus, and fetched values in Edit modus
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a5a
        private CrudeAirlineContract _contract;
        
        // true if form is in New modus, else Edit modus
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a5b
        private Boolean _isNew;
        
        // Constructs the form with a Save button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/e6bf67b2-7eb4-4882-bf12-aa5ae6eec6bf
        public AirlineEdit() {
            InitializeComponent();
            InitializeGridAirline();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        // bring up add form for Airline
        // links:
        //  docLink: http://sql2x.org/documentationLink/c0944961-8179-40a2-a561-c8873b691f2c
        public void ShowAsAdd() {
            _contract = new CrudeAirlineContract();
            _isNew = true;
            RefreshAirline();
            Show();
        }
        
        // bring up add form for Airline with rules
        // links:
        //  docLink: http://sql2x.org/documentationLink/6018e96e-28a1-4df4-879b-01a6bda81cc7
        public void ShowAsAddByRules(System.Guid userId) {
            _contract = new CrudeAirlineContract();
            _isNew = true;
            _contract.UserId = userId;
            userPicker.SelectedValue = _contract.UserId;
            _contract.DateTime = DateTime.UtcNow;
            dateTimePickerDateTime.Text = _contract.DateTime.ToString();

            RefreshAirline();
            Show();
        }
        
        // bring up add form for Airline by foreign key AirlineType
        // links:
        //  docLink: http://sql2x.org/documentationLink/2461e69c-dd05-47db-8f32-27ac1641a8d9
        public void ShowAsAddByAirlineType(string airlineTypeRcd) {
            _contract = new CrudeAirlineContract();
            _isNew = true;
            _contract.DateTime = DateTime.UtcNow;
            dateTimePickerDateTime.Text = _contract.DateTime.ToString();
            _contract.AirlineTypeRcd = airlineTypeRcd;
            airlineTypeRefCombo.Text = _contract.AirlineTypeRcd != null ? _contract.AirlineTypeRcd : String.Empty;

            RefreshAirline();
            Show();
        }
        
        // bring up add form for Airline by foreign key Address
        // links:
        //  docLink: http://sql2x.org/documentationLink/2461e69c-dd05-47db-8f32-27ac1641a8d9
        public void ShowAsAddByAddress(System.Guid addressId) {
            _contract = new CrudeAirlineContract();
            _isNew = true;
            _contract.DateTime = DateTime.UtcNow;
            dateTimePickerDateTime.Text = _contract.DateTime.ToString();
            _contract.AddressId = addressId;

            RefreshAirline();
            Show();
        }
        
        // bring up add form for Airline
        // links:
        //  docLink: http://sql2x.org/documentationLink/8568fd9a-b807-4aad-ac74-7826975e3241
        public void ShowAsAdd(string airlineName, string airlineTypeRcd, string legalName, System.Guid addressId, System.Guid productId, string stockMarketSymbol, int aircraftCount, System.Guid userId) {
            _contract = new CrudeAirlineContract();
            _isNew = true;
            _contract.AirlineName = airlineName;
            textBoxAirlineName.Text = _contract.AirlineName;
            _contract.AirlineTypeRcd = airlineTypeRcd;
            airlineTypeRefCombo.Text = _contract.AirlineTypeRcd != null ? _contract.AirlineTypeRcd : String.Empty;
            _contract.LegalName = legalName;
            textBoxLegalName.Text = _contract.LegalName;
            _contract.AddressId = addressId;
            _contract.ProductId = productId;
            _contract.StockMarketSymbol = stockMarketSymbol;
            textBoxStockMarketSymbol.Text = _contract.StockMarketSymbol;
            _contract.AircraftCount = aircraftCount;
            maskedTextBoxAircraftCount.Text = _contract.AircraftCount.ToString();
            _contract.UserId = userId;
            userPicker.SelectedValue = userId;
            _contract.DateTime = DateTime.UtcNow;
            dateTimePickerDateTime.Text = _contract.DateTime.ToString();

            RefreshAirline();
            Show();
        }
        
        // bring up edit form for Airline
        // links:
        //  docLink: http://sql2x.org/documentationLink/d7ff032d-3bcf-438f-9850-900ca0ebca98
        public void ShowAsEdit(System.Guid airlineId) {
            var service = new CrudeAirlineServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByAirlineId(airlineId);
                textBoxAirlineName.Text = _contract.AirlineName;
                airlineTypeRefCombo.Text = _contract.AirlineTypeRcd != null ? _contract.AirlineTypeRcd : String.Empty;
                textBoxLegalName.Text = _contract.LegalName;
                textBoxStockMarketSymbol.Text = _contract.StockMarketSymbol;
                maskedTextBoxAircraftCount.Text = _contract.AircraftCount.ToString();
                userPicker.SelectedValue = _contract.UserId;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();

                RefreshAirline();
                Show();
            } catch (Exception ex) {
                MessageBox.Show (ex.Message);
            } finally {
                service.Close();
            }
        }
        
        // save and close Airline
        // links:
        //  docLink: http://sql2x.org/documentationLink/d71519ff-fa27-4f64-9194-56886e4070ba
        private void buttonSave_Click(object sender, EventArgs e) {
            var service = new CrudeAirlineServiceClient();
            try {
                _contract.AirlineName = textBoxAirlineName.Text;
                _contract.AirlineTypeRcd = airlineTypeRefCombo.Text;
                _contract.LegalName = textBoxLegalName.Text;
                _contract.StockMarketSymbol = textBoxStockMarketSymbol.Text;
                _contract.AircraftCount = maskedTextBoxAircraftCount.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxAircraftCount.Text);
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
        
        // search Airline
        // links:
        //  docLink: http://sql2x.org/documentationLink/80a1bfbb-de84-4829-b248-3618a1657aae
        private void buttonAirlineSearch_Click(object sender, EventArgs e) {
            RefreshAirline();
        }
        
        // bring up edit form for Airline
        // links:
        //  docLink: http://sql2x.org/documentationLink/634a3333-2588-4ce9-a69e-146e6db06604
        private void buttonAirlineEdit_Click(object sender, EventArgs e) {
            var editForm = new AirlineContactMethodEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewAirline.CurrentRow.Cells["AirlineContactMethodId"].Value);
        }
        
        // bring up add form for Airline
        // links:
        //  docLink: http://sql2x.org/documentationLink/8a47adae-c002-48ab-8926-9daa6f237b92
        private void buttonAirlineAdd_Click(object sender, EventArgs e) {
            var editForm = new AirlineContactMethodEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAddByParent(_contract.AirlineId,_contract.UserId);
        }
        
        // bring up edit form for Airline
        // links:
        //  docLink: http://sql2x.org/documentationLink/a0d70634-76b1-43a0-bf41-c77b3ab4107f
        private void dataGridViewAirline_DoubleClick(object sender, EventArgs e) {
            var editForm = new AirlineEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewAirline.CurrentRow.Cells["AirlineContactMethodId"].Value);
        }
        
        // close form for Airline
        // links:
        //  docLink: http://sql2x.org/documentationLink/6cba4762-d598-4fc1-a165-225b3b86183f
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        // refresh Airline's
        // links:
        //  docLink: http://sql2x.org/documentationLink/40b9491c-7991-43e7-9e8d-06181fd0a7c6
        public void RefreshAirline() {
            var airlineContactMethod = new CrudeAirlineContactMethodServiceClient();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = airlineContactMethod.FetchByAirlineId(_contract.AirlineId);
                dataGridViewAirline.AutoGenerateColumns = false;
                dataGridViewAirline.DataSource = bindingSource;
                dataGridViewAirline.AutoResizeColumns();
                dataGridViewAirline.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                airlineContactMethod.Close();
            }
        }
        
        // initialize grid for Airline
        // links:
        //  docLink: http://sql2x.org/documentationLink/680c9cdb-dd8c-46bb-bb39-82bc124ebf5b
        private void InitializeGridAirline() {
            dataGridViewAirline.Columns.Clear();
            dataGridViewAirline.AutoGenerateColumns = false;
            dataGridViewAirline.Columns.Add("AirlineContactMethodId","Airline Contact Method");
            dataGridViewAirline.Columns["AirlineContactMethodId"].DataPropertyName = "AirlineContactMethodId";
            dataGridViewAirline.Columns["AirlineContactMethodId"].Visible = false;
            dataGridViewAirline.Columns.Add("AirlineId","Airline");
            dataGridViewAirline.Columns["AirlineId"].DataPropertyName = "AirlineId";
            dataGridViewAirline.Columns["AirlineId"].Visible = false;
            dataGridViewAirline.Columns.Add("ContactMethodRcd","Contact Method");
            dataGridViewAirline.Columns["ContactMethodRcd"].DataPropertyName = "ContactMethodRcd";
            dataGridViewAirline.Columns.Add("ContactMethodWay","Contact Method Way");
            dataGridViewAirline.Columns["ContactMethodWay"].DataPropertyName = "ContactMethodWay";
            dataGridViewAirline.Columns.Add("Comment","Comment");
            dataGridViewAirline.Columns["Comment"].DataPropertyName = "Comment";
            dataGridViewAirline.Columns.Add("DateTime","Date Time");
            dataGridViewAirline.Columns["DateTime"].DataPropertyName = "DateTime";
            dataGridViewAirline.Columns.Add("ExtensionData", "");
            dataGridViewAirline.Columns["ExtensionData"].Visible = false;

            dataGridViewAirline.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewAirline.AutoResizeColumns();
        }
    }
}
