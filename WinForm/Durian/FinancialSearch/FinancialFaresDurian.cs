using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class FinancialFaresDurian : UserControl {
        
        public FinancialFaresDurian() {
           InitializeComponent();
           InitializeGridFinancialFares();
        }
        
        public virtual string FinancialFareTypeRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewFinancialFares.CurrentRow.Cells["FinancialFareTypeRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual string DepartureAirportIdentifierCode {
            get {
                if (!DesignMode) return (System.String) dataGridViewFinancialFares.CurrentRow.Cells["DepartureAirportIdentifierCode"].Value; else return String.Empty;;
            }
        }
        
        public virtual string DepartureAirportName {
            get {
                if (!DesignMode) return (System.String) dataGridViewFinancialFares.CurrentRow.Cells["DepartureAirportName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ArrivalAirportIdentifierCode {
            get {
                if (!DesignMode) return (System.String) dataGridViewFinancialFares.CurrentRow.Cells["ArrivalAirportIdentifierCode"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ArrivalAirportName {
            get {
                if (!DesignMode) return (System.String) dataGridViewFinancialFares.CurrentRow.Cells["ArrivalAirportName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.DateTime ValidFromFlightDateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewFinancialFares.CurrentRow.Cells["ValidFromFlightDateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual System.DateTime ValidUntilFlightDateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewFinancialFares.CurrentRow.Cells["ValidUntilFlightDateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual decimal Amount {
            get {
                if (!DesignMode) return (System.Decimal) dataGridViewFinancialFares.CurrentRow.Cells["Amount"].Value; else return 0;;
            }
        }
        
        public virtual string FinancialCurrencyTypeRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewFinancialFares.CurrentRow.Cells["FinancialCurrencyTypeRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual string FinancialCurrencyTypeName {
            get {
                if (!DesignMode) return (System.String) dataGridViewFinancialFares.CurrentRow.Cells["FinancialCurrencyTypeName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.DateTime DateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewFinancialFares.CurrentRow.Cells["DateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual string DefaultUserCode {
            get {
                if (!DesignMode) return (System.String) dataGridViewFinancialFares.CurrentRow.Cells["DefaultUserCode"].Value; else return String.Empty;;
            }
        }
        
        public virtual string DefaultUserName {
            get {
                if (!DesignMode) return (System.String) dataGridViewFinancialFares.CurrentRow.Cells["DefaultUserName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid FinancialFareId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewFinancialFares.CurrentRow.Cells["FinancialFareId"].Value; else return Guid.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewFinancialFares.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewFinancialFares_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshFinancialFares() {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewFinancialFares.CurrentRow != null)
                    position = dataGridViewFinancialFares.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new FinancialSearchServiceClient().FinancialFares();
                dataGridViewFinancialFares.AutoGenerateColumns = true;
                dataGridViewFinancialFares.DataSource = bindingSource;
                dataGridViewFinancialFares.AutoResizeColumns();

                // position to previous row
                if (dataGridViewFinancialFares.Rows.Count > 0) { 
                    dataGridViewFinancialFares.CurrentCell = 
                        dataGridViewFinancialFares.Rows[position].Cells[1];
                    dataGridViewFinancialFares.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridFinancialFares() {
            dataGridViewFinancialFares.Columns.Clear();
            dataGridViewFinancialFares.AutoGenerateColumns = false;
            dataGridViewFinancialFares.Columns.Add("FinancialFareTypeRcd","Financial Fare Type");
            dataGridViewFinancialFares.Columns.Add("DepartureAirportIdentifierCode","Departure Airport Identifier Code");
            dataGridViewFinancialFares.Columns.Add("DepartureAirportName","Departure Airport Name");
            dataGridViewFinancialFares.Columns.Add("ArrivalAirportIdentifierCode","Arrival Airport Identifier Code");
            dataGridViewFinancialFares.Columns.Add("ArrivalAirportName","Arrival Airport Name");
            dataGridViewFinancialFares.Columns.Add("ValidFromFlightDateTime","Valid From Flight Date Time");
            dataGridViewFinancialFares.Columns.Add("ValidUntilFlightDateTime","Valid Until Flight Date Time");
            dataGridViewFinancialFares.Columns.Add("Amount","Amount");
            dataGridViewFinancialFares.Columns.Add("FinancialCurrencyTypeRcd","Financial Currency Type");
            dataGridViewFinancialFares.Columns.Add("FinancialCurrencyTypeName","Financial Currency Type Name");
            dataGridViewFinancialFares.Columns.Add("DateTime","Date Time");
            dataGridViewFinancialFares.Columns.Add("DefaultUserCode","Default User Code");
            dataGridViewFinancialFares.Columns.Add("DefaultUserName","Default User Name");
            dataGridViewFinancialFares.Columns.Add("FinancialFareId","Financial Fare Id");
            dataGridViewFinancialFares.Columns.Add("ExtensionData", "");
            dataGridViewFinancialFares.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewFinancialFares.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewFinancialFares.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewFinancialFares.AutoResizeColumns();
        }
    }
}
