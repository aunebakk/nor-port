using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class FlightsWithBookingInformationDurian : UserControl {
        
        public FlightsWithBookingInformationDurian() {
           InitializeComponent();
           InitializeGridFlightsWithBookingInformation();
        }
        
        public virtual System.Guid FlightId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewFlightsWithBookingInformation.CurrentRow.Cells["FlightId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual string AirlineIdentifierCode {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightsWithBookingInformation.CurrentRow.Cells["AirlineIdentifierCode"].Value; else return String.Empty;;
            }
        }
        
        public virtual string FlightNumber {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightsWithBookingInformation.CurrentRow.Cells["FlightNumber"].Value; else return String.Empty;;
            }
        }
        
        public virtual string DepartureAirportIdentifierCode {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightsWithBookingInformation.CurrentRow.Cells["DepartureAirportIdentifierCode"].Value; else return String.Empty;;
            }
        }
        
        public virtual string DepartureAirportName {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightsWithBookingInformation.CurrentRow.Cells["DepartureAirportName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ArrivalAirportIdentifierCode {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightsWithBookingInformation.CurrentRow.Cells["ArrivalAirportIdentifierCode"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ArrivalAirportName {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightsWithBookingInformation.CurrentRow.Cells["ArrivalAirportName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.DateTime FromDateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewFlightsWithBookingInformation.CurrentRow.Cells["FromDateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual System.DateTime UntilDateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewFlightsWithBookingInformation.CurrentRow.Cells["UntilDateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual bool CanBookFlag {
            get {
                if (!DesignMode) return (System.Boolean) dataGridViewFlightsWithBookingInformation.CurrentRow.Cells["CanBookFlag"].Value; else return false;;
            }
        }
        
        public virtual bool CanCheckinFlag {
            get {
                if (!DesignMode) return (System.Boolean) dataGridViewFlightsWithBookingInformation.CurrentRow.Cells["CanCheckinFlag"].Value; else return false;;
            }
        }
        
        public virtual bool InFlightFlag {
            get {
                if (!DesignMode) return (System.Boolean) dataGridViewFlightsWithBookingInformation.CurrentRow.Cells["InFlightFlag"].Value; else return false;;
            }
        }
        
        public virtual int FlightsBookedCount {
            get {
                if (!DesignMode) return (System.Int32) dataGridViewFlightsWithBookingInformation.CurrentRow.Cells["FlightsBookedCount"].Value; else return 0;;
            }
        }
        
        public virtual string LastDateTimeTypeName {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightsWithBookingInformation.CurrentRow.Cells["LastDateTimeTypeName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.DateTime PlannedDepartureDateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewFlightsWithBookingInformation.CurrentRow.Cells["PlannedDepartureDateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual System.DateTime EstimatedDepartureDateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewFlightsWithBookingInformation.CurrentRow.Cells["EstimatedDepartureDateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewFlightsWithBookingInformation.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewFlightsWithBookingInformation_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshFlightsWithBookingInformation(System.Guid departureAirportId, System.Guid arrivalAirportId, System.DateTime fromDateTime, System.DateTime untilDateTime) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewFlightsWithBookingInformation.CurrentRow != null)
                    position = dataGridViewFlightsWithBookingInformation.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new FlightSearchServiceClient().FlightsWithBookingInformation(departureAirportId,arrivalAirportId,fromDateTime,untilDateTime);
                dataGridViewFlightsWithBookingInformation.AutoGenerateColumns = true;
                dataGridViewFlightsWithBookingInformation.DataSource = bindingSource;
                dataGridViewFlightsWithBookingInformation.AutoResizeColumns();

                // position to previous row
                if (dataGridViewFlightsWithBookingInformation.Rows.Count > 0) { 
                    dataGridViewFlightsWithBookingInformation.CurrentCell = 
                        dataGridViewFlightsWithBookingInformation.Rows[position].Cells[1];
                    dataGridViewFlightsWithBookingInformation.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridFlightsWithBookingInformation() {
            dataGridViewFlightsWithBookingInformation.Columns.Clear();
            dataGridViewFlightsWithBookingInformation.AutoGenerateColumns = false;
            dataGridViewFlightsWithBookingInformation.Columns.Add("FlightId","Flight Id");
            dataGridViewFlightsWithBookingInformation.Columns.Add("AirlineIdentifierCode","Airline Identifier Code");
            dataGridViewFlightsWithBookingInformation.Columns.Add("FlightNumber","Flight Number");
            dataGridViewFlightsWithBookingInformation.Columns.Add("DepartureAirportIdentifierCode","Departure Airport Identifier Code");
            dataGridViewFlightsWithBookingInformation.Columns.Add("DepartureAirportName","Departure Airport Name");
            dataGridViewFlightsWithBookingInformation.Columns.Add("ArrivalAirportIdentifierCode","Arrival Airport Identifier Code");
            dataGridViewFlightsWithBookingInformation.Columns.Add("ArrivalAirportName","Arrival Airport Name");
            dataGridViewFlightsWithBookingInformation.Columns.Add("FromDateTime","From Date Time");
            dataGridViewFlightsWithBookingInformation.Columns.Add("UntilDateTime","Until Date Time");
            dataGridViewFlightsWithBookingInformation.Columns.Add("CanBookFlag","Can Book Flag");
            dataGridViewFlightsWithBookingInformation.Columns.Add("CanCheckinFlag","Can Checkin Flag");
            dataGridViewFlightsWithBookingInformation.Columns.Add("InFlightFlag","In Flight Flag");
            dataGridViewFlightsWithBookingInformation.Columns.Add("FlightsBookedCount","Flights Booked Count");
            dataGridViewFlightsWithBookingInformation.Columns.Add("LastDateTimeTypeName","Last Date Time Type Name");
            dataGridViewFlightsWithBookingInformation.Columns.Add("PlannedDepartureDateTime","Planned Departure Date Time");
            dataGridViewFlightsWithBookingInformation.Columns.Add("EstimatedDepartureDateTime","Estimated Departure Date Time");
            dataGridViewFlightsWithBookingInformation.Columns.Add("ExtensionData", "");
            dataGridViewFlightsWithBookingInformation.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewFlightsWithBookingInformation.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewFlightsWithBookingInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewFlightsWithBookingInformation.AutoResizeColumns();
        }
    }
}
