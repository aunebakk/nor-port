/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/4/2021 1:20:23 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateComboStyle1
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

// Client WinForm Layer
// the Client WinForm Layer uses the Proxy Layer to tie into SOAP services
// links:
//  docLink: http://sql2x.org/documentationLink/ac33e44f-c6b2-47e4-87bb-e9d860932135
namespace SolutionNorSolutionPort.UserInterface {

    // this ComboBox UserControl class is used to consume Crude SOAP Services through a WCF Proxy Client
    // links:
    //  docLink: http://sql2x.org/documentationLink/8b849122-8bc9-488b-a02d-552199fecf97
    public partial class FerryTypeRefCombo : UserControl {
        
        // Constructs the control with an empty ComboBox
        // links:
        //  docLink: http://sql2x.org/documentationLink/e32382ca-f57c-4018-b820-232f0f777f07
        public FerryTypeRefCombo() {
           InitializeComponent();
        }
        
        // get or sets the current combobox row
        // links:
        //  docLink: http://sql2x.org/documentationLink/31d80c19-b0f4-4dfa-95e1-89511bb1d396
        public override string Text {
            get {
                System.String selectedValue = String.Empty;
                try { 
                    selectedValue = cboRef.SelectedValue.ToString();
                } catch {}
                return selectedValue;
            }
            set {
                PopulateCombo();
                cboRef.SelectedValue = value;;
            }
        }
        
        // event for when a new item is selected in the ComboBox
        // links:
        //  docLink: http://sql2x.org/documentationLink/47d2488c-a52e-42c7-ace3-ee8aa0e558d1
        public event EventHandler Picked;
        
        // populates the ComboBox with all rows from the SOAP service
        // links:
        //  docLink: http://sql2x.org/documentationLink/e9ba8805-decd-4b61-84ee-539e166d5d4c
        private void cboRef_Click(object sender, EventArgs e) {
            PopulateCombo();
        }
        
        // trigger Picked event when selected row in the ComboBox changes
        // links:
        //  docLink: http://sql2x.org/documentationLink/a01e6973-8625-476c-89e1-a43aab4bce17
        private void cboRef_SelectedIndexChanged(object sender, EventArgs e) {
            if (cboRef.SelectedValue != null && this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        // fetch all rows from the SOAP layer and populate the ComboBox with it
        // links:
        //  docLink: http://sql2x.org/documentationLink/4ccfdfd8-9986-4cfe-8743-e0bcde887284
        public void PopulateCombo() {
            if (!DesignMode && cboRef.DataSource == null) {
                CrudeFerryTypeRefServiceClient ferryTypeRef = null;

                try {
                    ferryTypeRef = new CrudeFerryTypeRefServiceClient();
                    List<CrudeFerryTypeRefContract> contracts = ferryTypeRef.FetchAll();

                    cboRef.DataSource = contracts;
                    cboRef.DisplayMember = "FerryTypeName";
                    cboRef.ValueMember = "FerryTypeRcd";
                } catch (Exception ex) {
                    if (ex != null) { }
                } finally {
                    if (ferryTypeRef != null) ferryTypeRef.Close();
                }
            }
        }
    }
}
