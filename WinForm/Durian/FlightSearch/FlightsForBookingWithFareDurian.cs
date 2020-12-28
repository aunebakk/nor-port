using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class FlightsForBookingWithFareDurian : UserControl {
        
        public FlightsForBookingWithFareDurian() {
           InitializeComponent();
           InitializeGridFlightsForBookingWithFare();
        }
        
        public virtual System.Guid FlightId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewFlightsForBookingWithFare.CurrentRow.Cells["FlightId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual string AirlineIdentifierCode {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightsForBookingWithFare.CurrentRow.Cells["AirlineIdentifierCode"].Value; else return String.Empty;;
            }
        }
        
        public virtual string FlightNumber {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightsForBookingWithFare.CurrentRow.Cells["FlightNumber"].Value; else return String.Empty;;
            }
        }
        
        public virtual string DepartureAirportIdentifierCode {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightsForBookingWithFare.CurrentRow.Cells["DepartureAirportIdentifierCode"].Value; else return String.Empty;;
            }
        }
        
        public virtual string DepartureAirportName {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightsForBookingWithFare.CurrentRow.Cells["DepartureAirportName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ArrivalAirportIdentifierCode {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightsForBookingWithFare.CurrentRow.Cells["ArrivalAirportIdentifierCode"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ArrivalAirportName {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightsForBookingWithFare.CurrentRow.Cells["ArrivalAirportName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.DateTime FromDateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewFlightsForBookingWithFare.CurrentRow.Cells["FromDateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual System.DateTime UntilDateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewFlightsForBookingWithFare.CurrentRow.Cells["UntilDateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual bool BookingOpenFlag {
            get {
                if (!DesignMode) return (System.Boolean) dataGridViewFlightsForBookingWithFare.CurrentRow.Cells["BookingOpenFlag"].Value; else return false;;
            }
        }
        
        public virtual decimal Amount {
            get {
                if (!DesignMode) return (System.Decimal) dataGridViewFlightsForBookingWithFare.CurrentRow.Cells["Amount"].Value; else return 0;;
            }
        }
        
        public virtual string FinancialCurrencyTypeCode {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightsForBookingWithFare.CurrentRow.Cells["FinancialCurrencyTypeCode"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid FinancialCurrencyId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewFlightsForBookingWithFare.CurrentRow.Cells["FinancialCurrencyId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual System.Guid FinancialFareId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewFlightsForBookingWithFare.CurrentRow.Cells["FinancialFareId"].Value; else return Guid.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewFlightsForBookingWithFare.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewFlightsForBookingWithFare_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshFlightsForBookingWithFare(System.Guid departureAirportId, System.Guid arrivalAirportId, System.DateTime fromDateTime, System.DateTime untilDateTime) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewFlightsForBookingWithFare.CurrentRow != null)
                    position = dataGridViewFlightsForBookingWithFare.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new FlightSearchService().FlightsForBookingWithFare(departureAirportId,arrivalAirportId,fromDateTime,untilDateTime);
                dataGridViewFlightsForBookingWithFare.AutoGenerateColumns = true;
                dataGridViewFlightsForBookingWithFare.DataSource = bindingSource;
                dataGridViewFlightsForBookingWithFare.AutoResizeColumns();

                // position to previous row
                if (dataGridViewFlightsForBookingWithFare.Rows.Count > 0) { 
                    dataGridViewFlightsForBookingWithFare.CurrentCell = 
                        dataGridViewFlightsForBookingWithFare.Rows[position].Cells[1];
                    dataGridViewFlightsForBookingWithFare.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridFlightsForBookingWithFare() {
            dataGridViewFlightsForBookingWithFare.Columns.Clear();
            dataGridViewFlightsForBookingWithFare.AutoGenerateColumns = false;
            dataGridViewFlightsForBookingWithFare.Columns.Add("FlightId","Flight Id");
            dataGridViewFlightsForBookingWithFare.Columns.Add("AirlineIdentifierCode","Airline Identifier Code");
            dataGridViewFlightsForBookingWithFare.Columns.Add("FlightNumber","Flight Number");
            dataGridViewFlightsForBookingWithFare.Columns.Add("DepartureAirportIdentifierCode","Departure Airport Identifier Code");
            dataGridViewFlightsForBookingWithFare.Columns.Add("DepartureAirportName","Departure Airport Name");
            dataGridViewFlightsForBookingWithFare.Columns.Add("ArrivalAirportIdentifierCode","Arrival Airport Identifier Code");
            dataGridViewFlightsForBookingWithFare.Columns.Add("ArrivalAirportName","Arrival Airport Name");
            dataGridViewFlightsForBookingWithFare.Columns.Add("FromDateTime","From Date Time");
            dataGridViewFlightsForBookingWithFare.Columns.Add("UntilDateTime","Until Date Time");
            dataGridViewFlightsForBookingWithFare.Columns.Add("BookingOpenFlag","Booking Open Flag");
            dataGridViewFlightsForBookingWithFare.Columns.Add("Amount","Amount");
            dataGridViewFlightsForBookingWithFare.Columns.Add("FinancialCurrencyTypeCode","Financial Currency Type Code");
            dataGridViewFlightsForBookingWithFare.Columns.Add("FinancialCurrencyId","Financial Currency Id");
            dataGridViewFlightsForBookingWithFare.Columns.Add("FinancialFareId","Financial Fare Id");
            dataGridViewFlightsForBookingWithFare.Columns.Add("ExtensionData", "");
            dataGridViewFlightsForBookingWithFare.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewFlightsForBookingWithFare.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewFlightsForBookingWithFare.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewFlightsForBookingWithFare.AutoResizeColumns();
        }
    }
}
