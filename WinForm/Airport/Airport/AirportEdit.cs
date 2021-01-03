/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/3/2021 2:30:14 PM
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
    public partial class AirportEdit : Form {
        
        // holds the contract, with default values if in New modus, and fetched values in Edit modus
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a5a
        private CrudeAirportContract _contract;
        
        // true if form is in New modus, else Edit modus
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a5b
        private Boolean _isNew;
        
        // Constructs the form with a Save button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/e6bf67b2-7eb4-4882-bf12-aa5ae6eec6bf
        public AirportEdit() {
            InitializeComponent();
            InitializeGridAirport();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        // bring up add form for Airport
        // links:
        //  docLink: http://sql2x.org/documentationLink/c0944961-8179-40a2-a561-c8873b691f2c
        public void ShowAsAdd() {
            _contract = new CrudeAirportContract();
            _isNew = true;
            RefreshAirport();
            Show();
        }
        
        // bring up add form for Airport with rules
        // links:
        //  docLink: http://sql2x.org/documentationLink/6018e96e-28a1-4df4-879b-01a6bda81cc7
        public void ShowAsAddByRules(System.Guid userId) {
            _contract = new CrudeAirportContract();
            _isNew = true;
            _contract.UserId = userId;
            userPicker.SelectedValue = _contract.UserId;
            _contract.DateTime = DateTime.UtcNow;
            dateTimePickerDateTime.Text = _contract.DateTime.ToString();

            RefreshAirport();
            Show();
        }
        
        // bring up add form for Airport by foreign key City
        // links:
        //  docLink: http://sql2x.org/documentationLink/2461e69c-dd05-47db-8f32-27ac1641a8d9
        public void ShowAsAddByCity(System.Guid cityId) {
            _contract = new CrudeAirportContract();
            _isNew = true;
            _contract.DateTime = DateTime.UtcNow;
            dateTimePickerDateTime.Text = _contract.DateTime.ToString();
            _contract.CityId = cityId;
            cityPicker.SelectedValue = _contract.CityId;

            RefreshAirport();
            Show();
        }
        
        // bring up add form for Airport by foreign key AirportType
        // links:
        //  docLink: http://sql2x.org/documentationLink/2461e69c-dd05-47db-8f32-27ac1641a8d9
        public void ShowAsAddByAirportType(string airportTypeRcd) {
            _contract = new CrudeAirportContract();
            _isNew = true;
            _contract.DateTime = DateTime.UtcNow;
            dateTimePickerDateTime.Text = _contract.DateTime.ToString();
            _contract.AirportTypeRcd = airportTypeRcd;
            airportTypeRefCombo.Text = _contract.AirportTypeRcd != null ? _contract.AirportTypeRcd : String.Empty;

            RefreshAirport();
            Show();
        }
        
        // bring up add form for Airport by foreign key Timezone
        // links:
        //  docLink: http://sql2x.org/documentationLink/2461e69c-dd05-47db-8f32-27ac1641a8d9
        public void ShowAsAddByTimezone(System.Guid timezoneId) {
            _contract = new CrudeAirportContract();
            _isNew = true;
            _contract.DateTime = DateTime.UtcNow;
            dateTimePickerDateTime.Text = _contract.DateTime.ToString();
            _contract.TimezoneId = timezoneId;

            RefreshAirport();
            Show();
        }
        
        // bring up add form for Airport
        // links:
        //  docLink: http://sql2x.org/documentationLink/8568fd9a-b807-4aad-ac74-7826975e3241
        public void ShowAsAdd(string airportName, string airportTypeRcd, System.Guid cityId, System.Guid productId, decimal utcOffset, decimal elevationInMeters, decimal runwayInMeters, string latitude, string longitude, System.Guid timezoneId, string variation, string attendance, bool controlTowerFlag, System.DateTime activationDateTime, System.Guid userId) {
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

            RefreshAirport();
            Show();
        }
        
        // bring up edit form for Airport
        // links:
        //  docLink: http://sql2x.org/documentationLink/d7ff032d-3bcf-438f-9850-900ca0ebca98
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

                RefreshAirport();
                Show();
            } catch (Exception ex) {
                MessageBox.Show (ex.Message);
            } finally {
                service.Close();
            }
        }
        
        // save and close Airport
        // links:
        //  docLink: http://sql2x.org/documentationLink/d71519ff-fa27-4f64-9194-56886e4070ba
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
            } catch (Exception ex) {
                MessageBox.Show (ex.Message);
            } finally {
                service.Close();
            }

            Close();
        }
        
        // search Airport
        // links:
        //  docLink: http://sql2x.org/documentationLink/80a1bfbb-de84-4829-b248-3618a1657aae
        private void buttonAirportSearch_Click(object sender, EventArgs e) {
            RefreshAirport();
        }
        
        // bring up edit form for Airport
        // links:
        //  docLink: http://sql2x.org/documentationLink/634a3333-2588-4ce9-a69e-146e6db06604
        private void buttonAirportEdit_Click(object sender, EventArgs e) {
            // no code because ChildDefinition is missing
        }
        
        // bring up add form for Airport
        // links:
        //  docLink: http://sql2x.org/documentationLink/8a47adae-c002-48ab-8926-9daa6f237b92
        private void buttonAirportAdd_Click(object sender, EventArgs e) {
            // no code because ChildDefinition is missing
        }
        
        // bring up edit form for Airport
        // links:
        //  docLink: http://sql2x.org/documentationLink/a0d70634-76b1-43a0-bf41-c77b3ab4107f
        private void dataGridViewAirport_DoubleClick(object sender, EventArgs e) {
            var editForm = new AirportEdit();
            editForm.MdiParent = this.MdiParent;
            // no code because ChildDefinition is missing
        }
        
        // close form for Airport
        // links:
        //  docLink: http://sql2x.org/documentationLink/6cba4762-d598-4fc1-a165-225b3b86183f
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        // refresh Airport's
        // links:
        //  docLink: http://sql2x.org/documentationLink/40b9491c-7991-43e7-9e8d-06181fd0a7c6
        public void RefreshAirport() {
            // no code because ChildDefinition is missing}
        }
        
        // initialize grid for Airport
        // links:
        //  docLink: http://sql2x.org/documentationLink/680c9cdb-dd8c-46bb-bb39-82bc124ebf5b
        private void InitializeGridAirport() {
            dataGridViewAirport.Columns.Clear();
            dataGridViewAirport.AutoGenerateColumns = false;
            dataGridViewAirport.Columns.Add("ExtensionData", "");
            dataGridViewAirport.Columns["ExtensionData"].Visible = false;

            dataGridViewAirport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewAirport.AutoResizeColumns();
        }
    }
}
