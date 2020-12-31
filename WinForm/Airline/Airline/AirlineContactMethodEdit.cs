/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/31/2020 11:05:52 AM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.TemplateWithDurianGenerator.UsingWinForm
*/
using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class AirlineContactMethodEdit : Form {
        
        private CrudeAirlineContactMethodContract _contract;
        
        private Boolean _isNew;
        
        public AirlineContactMethodEdit() {
            InitializeComponent();
            this.AcceptButton = buttonSave;
            this.CancelButton = buttonClose;
        }
        
        public void ShowAsAdd() {
            _contract = new CrudeAirlineContactMethodContract();
            _isNew = true;
            Show();
        }
        
        public void ShowAsAddByParent(System.Guid airlineId, System.Guid userId) {
            _contract = new CrudeAirlineContactMethodContract();
            _isNew = true;
            _contract.AirlineId = airlineId;
            _contract.DateTime = DateTime.UtcNow;
            dateTimePickerDateTime.Text = _contract.DateTime.ToString();
            airlinePicker.SelectedValue = _contract.AirlineId;
            _contract.UserId = userId;
            userPicker.SelectedValue = userId;

            Show();
        }
        
        public void ShowAsAddByContactMethod(string contactMethodRcd) {
            _contract = new CrudeAirlineContactMethodContract();
            _isNew = true;
            _contract.DateTime = DateTime.UtcNow;
            dateTimePickerDateTime.Text = _contract.DateTime.ToString();
            _contract.ContactMethodRcd = contactMethodRcd;
            contactMethodRefCombo.Text = _contract.ContactMethodRcd != null ? _contract.ContactMethodRcd : String.Empty;

            Show();
        }
        
        public void ShowAsAddByAirline(System.Guid airlineId) {
            _contract = new CrudeAirlineContactMethodContract();
            _isNew = true;
            _contract.DateTime = DateTime.UtcNow;
            dateTimePickerDateTime.Text = _contract.DateTime.ToString();
            _contract.AirlineId = airlineId;
            airlinePicker.SelectedValue = _contract.AirlineId;

            Show();
        }
        
        public void ShowAsAdd(System.Guid airlineId, string contactMethodRcd, string contactMethodWay, string comment, System.Guid userId) {
            _contract = new CrudeAirlineContactMethodContract();
            _isNew = true;
            _contract.AirlineId = airlineId;
            airlinePicker.SelectedValue = _contract.AirlineId;
            _contract.ContactMethodRcd = contactMethodRcd;
            contactMethodRefCombo.Text = _contract.ContactMethodRcd != null ? _contract.ContactMethodRcd : String.Empty;
            _contract.ContactMethodWay = contactMethodWay;
            textBoxContactMethodWay.Text = _contract.ContactMethodWay;
            _contract.Comment = comment;
            textBoxComment.Text = _contract.Comment;
            _contract.UserId = userId;
            userPicker.SelectedValue = userId;
            _contract.DateTime = DateTime.UtcNow;
            dateTimePickerDateTime.Text = _contract.DateTime.ToString();

            Show();
        }
        
        public void ShowAsEdit(System.Guid airlineContactMethodId) {
            var service = new CrudeAirlineContactMethodServiceClient();
            _isNew = false;
            try {
                _contract = service.FetchByAirlineContactMethodId(airlineContactMethodId);
                airlinePicker.SelectedValue = _contract.AirlineId;
                contactMethodRefCombo.Text = _contract.ContactMethodRcd != null ? _contract.ContactMethodRcd : String.Empty;
                textBoxContactMethodWay.Text = _contract.ContactMethodWay;
                textBoxComment.Text = _contract.Comment;
                userPicker.SelectedValue = _contract.UserId;
                _contract.DateTime = DateTime.UtcNow;
                dateTimePickerDateTime.Text = _contract.DateTime.ToString();

                Show();
            } catch (Exception ex) {
                MessageBox.Show (ex.Message);
            } finally {
                service.Close();
            }
        }
        
        private void buttonSave_Click(object sender, EventArgs e) {
            var service = new CrudeAirlineContactMethodServiceClient();
            try {
                _contract.AirlineId = (Guid)airlinePicker.SelectedValue;
                _contract.ContactMethodRcd = contactMethodRefCombo.Text;
                _contract.ContactMethodWay = textBoxContactMethodWay.Text;
                _contract.Comment = textBoxComment.Text;
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
        
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
