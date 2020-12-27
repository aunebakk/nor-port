/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 0.d
  http://sql2x.azurewebsites.net/
  Generated Date: 1/18/2019 3:01:00 PM
  Template: sql2x.TemplateCrudeWinForm.WinFormGeneratePickerStyle1
*/
using System;
using System.ComponentModel;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {
    
    
    public partial class AirportPicker : UserControl {
        
        private System.Guid _airportId;
        
        public AirportPicker() {
           InitializeComponent();
        }
        
        public System.Guid SelectedValue {
            get {
                return _airportId;
            }
            set {
                if (!DesignMode) {
                    _airportId = value;
                    var airport = new CrudeAirportServiceClient();
                    try {
                        CrudeAirportContract contract = airport.FetchByAirportId(_airportId);

                        if (contract != null) {
                            txtAirportName.Text = contract.AirportName;
                            txtAirportCode.Text = contract.AirportName;
                        }
                    } catch (Exception ex) {
                        MessageBox.Show(ex.Message);
                    } finally {
                        if (airport != null) airport.Close();
                    }
                };
            }
        }
        
        public event EventHandler Picked;
        
        private void txtAirportCode_Validating(object sender, CancelEventArgs e) {
            if (!DesignMode) {
                // empty picker on no code
                if (string.IsNullOrEmpty(txtAirportCode.Text)) {
                    _airportId = Guid.Empty;
                    txtAirportName.Text = string.Empty;
                    txtAirportCode.Text = string.Empty;
                    return;
                }

                CrudeAirportServiceClient airport = null;

                try {
                    airport = new CrudeAirportServiceClient();
                    CrudeAirportContract contract = airport.FetchByAirportName(txtAirportCode.Text);

                    if (contract != null) {
                        txtAirportCode.Text = contract.AirportName;
                        txtAirportName.Text = contract.AirportName;
                        _airportId = contract.AirportId;
                    }
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                } finally {
                    if (airport != null) airport.Close();
                }
                
                if (this.Picked != null)
                    this.Picked(new object(), new EventArgs());
            }
        }
    }
}
