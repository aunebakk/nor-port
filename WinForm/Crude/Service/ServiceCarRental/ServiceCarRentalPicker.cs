﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/31/2020 7:19:56 AM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.TemplateCrudeWinForm.WinFormGeneratePickerStyle1
*/
using System;
using System.ComponentModel;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

// Client WinForm Layer
// the Client WinForm Layer uses the Proxy Layer to tie into SOAP services
// links:
//  docLink: http://sql2x.org/documentationLink/a7f33a80-d1cc-4b2a-98d8-1f53f22541ab
namespace SolutionNorSolutionPort.UserInterface {

    // this UserControl class is used to consume Crude SOAP Services through a WCF Proxy Client
    // links:
    //  docLink: http://sql2x.org/documentationLink/f2898ffd-89da-46d0-a1c3-209d0f8b69cc
    public partial class ServiceCarRentalPicker : UserControl {
        
        // the primary key for the table being picked
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a57
        private System.Guid _serviceCarRentalId;
        
        // Constructs the control in an empty state
        // links:
        //  docLink: http://sql2x.org/documentationLink/b8f303bc-1865-4cb8-8a10-dd95de243fb2
        public ServiceCarRentalPicker() {
           InitializeComponent();
        }
        
        // get or sets the current picked row
        // links:
        //  docLink: http://sql2x.org/documentationLink/0a80686f-79cb-476e-81d3-db5f54267a56
        public System.Guid SelectedValue {
            get {
                return _serviceCarRentalId;
            }
            set {
                if (!DesignMode) {
                    _serviceCarRentalId = value;
                    var serviceCarRental = new CrudeServiceCarRentalServiceClient();
                    try {
                        CrudeServiceCarRentalContract contract = serviceCarRental.FetchByServiceCarRentalId(_serviceCarRentalId);

                        if (contract != null) {
                            txtServiceCarRentalName.Text = contract.CarName;
                            txtServiceCarRentalCode.Text = contract.CarName;
                        }
                    } catch (Exception ex) {
                        MessageBox.Show(ex.Message);
                    } finally {
                        if (serviceCarRental != null) serviceCarRental.Close();
                    }
                };
            }
        }
        
        // event for when a new item is selected in the UserControl
        // links:
        //  docLink: http://sql2x.org/documentationLink/ba6e299b-c639-4ecb-8891-dc02b421418b
        public event EventHandler Picked;
        
        // populates the Picker with the first match from the SOAP service
        // links:
        //  docLink: http://sql2x.org/documentationLink/3e8b9e1a-39eb-444f-9632-ce3406db3534
        private void txtServiceCarRentalCode_Validating(object sender, CancelEventArgs e) {
            if (!DesignMode) {
                // empty picker on no code
                if (string.IsNullOrEmpty(txtServiceCarRentalCode.Text)) {
                    _serviceCarRentalId = Guid.Empty;
                    txtServiceCarRentalName.Text = string.Empty;
                    txtServiceCarRentalCode.Text = string.Empty;
                    return;
                }

                CrudeServiceCarRentalServiceClient serviceCarRental = null;

                try {
                    serviceCarRental = new CrudeServiceCarRentalServiceClient();
                    CrudeServiceCarRentalContract contract = serviceCarRental.FetchByCarName(txtServiceCarRentalCode.Text);

                    if (contract != null) {
                        txtServiceCarRentalCode.Text = contract.CarName;
                        txtServiceCarRentalName.Text = contract.CarName;
                        _serviceCarRentalId = contract.ServiceCarRentalId;
                    }
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                } finally {
                    if (serviceCarRental != null) serviceCarRental.Close();
                }
                
                if (this.Picked != null)
                    this.Picked(new object(), new EventArgs());
            }
        }
    }
}
