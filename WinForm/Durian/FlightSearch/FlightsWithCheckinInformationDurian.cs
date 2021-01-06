using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class FlightsWithCheckinInformationDurian : UserControl {
        
        public FlightsWithCheckinInformationDurian() {
           InitializeComponent();
           InitializeGridFlightsWithCheckinInformation();
        }
        
        public virtual System.Guid FlightId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewFlightsWithCheckinInformation.CurrentRow.Cells["FlightId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual string AirlineIdentifierCode {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightsWithCheckinInformation.CurrentRow.Cells["AirlineIdentifierCode"].Value; else return String.Empty;;
            }
        }
        
        public virtual string FlightNumber {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightsWithCheckinInformation.CurrentRow.Cells["FlightNumber"].Value; else return String.Empty;;
            }
        }
        
        public virtual string DepartureAirportIdentifierCode {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightsWithCheckinInformation.CurrentRow.Cells["DepartureAirportIdentifierCode"].Value; else return String.Empty;;
            }
        }
        
        public virtual string DepartureAirportName {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightsWithCheckinInformation.CurrentRow.Cells["DepartureAirportName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ArrivalAirportIdentifierCode {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightsWithCheckinInformation.CurrentRow.Cells["ArrivalAirportIdentifierCode"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ArrivalAirportName {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightsWithCheckinInformation.CurrentRow.Cells["ArrivalAirportName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.DateTime FromDateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewFlightsWithCheckinInformation.CurrentRow.Cells["FromDateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual System.DateTime UntilDateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewFlightsWithCheckinInformation.CurrentRow.Cells["UntilDateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual int PassengersBookedCount {
            get {
                if (!DesignMode) return (System.Int32) dataGridViewFlightsWithCheckinInformation.CurrentRow.Cells["PassengersBookedCount"].Value; else return 0;;
            }
        }
        
        public virtual int AdultBookedCount {
            get {
                if (!DesignMode) return (System.Int32) dataGridViewFlightsWithCheckinInformation.CurrentRow.Cells["AdultBookedCount"].Value; else return 0;;
            }
        }
        
        public virtual int ChildBookedCount {
            get {
                if (!DesignMode) return (System.Int32) dataGridViewFlightsWithCheckinInformation.CurrentRow.Cells["ChildBookedCount"].Value; else return 0;;
            }
        }
        
        public virtual int InfantBookedCount {
            get {
                if (!DesignMode) return (System.Int32) dataGridViewFlightsWithCheckinInformation.CurrentRow.Cells["InfantBookedCount"].Value; else return 0;;
            }
        }
        
        public virtual string LastDateTimeTypeName {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightsWithCheckinInformation.CurrentRow.Cells["LastDateTimeTypeName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.DateTime PlannedDepartureDateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewFlightsWithCheckinInformation.CurrentRow.Cells["PlannedDepartureDateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual System.DateTime EstimatedDepartureDateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewFlightsWithCheckinInformation.CurrentRow.Cells["EstimatedDepartureDateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewFlightsWithCheckinInformation.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewFlightsWithCheckinInformation_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshFlightsWithCheckinInformation(System.Guid departureAirportId, System.Guid arrivalAirportId, System.DateTime fromDateTime, System.DateTime untilDateTime) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewFlightsWithCheckinInformation.CurrentRow != null)
                    position = dataGridViewFlightsWithCheckinInformation.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new FlightSearchServiceClient().FlightsWithCheckinInformation(departureAirportId,arrivalAirportId,fromDateTime,untilDateTime);
                dataGridViewFlightsWithCheckinInformation.AutoGenerateColumns = true;
                dataGridViewFlightsWithCheckinInformation.DataSource = bindingSource;
                dataGridViewFlightsWithCheckinInformation.AutoResizeColumns();

                // position to previous row
                if (dataGridViewFlightsWithCheckinInformation.Rows.Count > 0) { 
                    dataGridViewFlightsWithCheckinInformation.CurrentCell = 
                        dataGridViewFlightsWithCheckinInformation.Rows[position].Cells[1];
                    dataGridViewFlightsWithCheckinInformation.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridFlightsWithCheckinInformation() {
            dataGridViewFlightsWithCheckinInformation.Columns.Clear();
            dataGridViewFlightsWithCheckinInformation.AutoGenerateColumns = false;
            dataGridViewFlightsWithCheckinInformation.Columns.Add("FlightId","Flight Id");
            dataGridViewFlightsWithCheckinInformation.Columns.Add("AirlineIdentifierCode","Airline Identifier Code");
            dataGridViewFlightsWithCheckinInformation.Columns.Add("FlightNumber","Flight Number");
            dataGridViewFlightsWithCheckinInformation.Columns.Add("DepartureAirportIdentifierCode","Departure Airport Identifier Code");
            dataGridViewFlightsWithCheckinInformation.Columns.Add("DepartureAirportName","Departure Airport Name");
            dataGridViewFlightsWithCheckinInformation.Columns.Add("ArrivalAirportIdentifierCode","Arrival Airport Identifier Code");
            dataGridViewFlightsWithCheckinInformation.Columns.Add("ArrivalAirportName","Arrival Airport Name");
            dataGridViewFlightsWithCheckinInformation.Columns.Add("FromDateTime","From Date Time");
            dataGridViewFlightsWithCheckinInformation.Columns.Add("UntilDateTime","Until Date Time");
            dataGridViewFlightsWithCheckinInformation.Columns.Add("PassengersBookedCount","Passengers Booked Count");
            dataGridViewFlightsWithCheckinInformation.Columns.Add("AdultBookedCount","Adult Booked Count");
            dataGridViewFlightsWithCheckinInformation.Columns.Add("ChildBookedCount","Child Booked Count");
            dataGridViewFlightsWithCheckinInformation.Columns.Add("InfantBookedCount","Infant Booked Count");
            dataGridViewFlightsWithCheckinInformation.Columns.Add("LastDateTimeTypeName","Last Date Time Type Name");
            dataGridViewFlightsWithCheckinInformation.Columns.Add("PlannedDepartureDateTime","Planned Departure Date Time");
            dataGridViewFlightsWithCheckinInformation.Columns.Add("EstimatedDepartureDateTime","Estimated Departure Date Time");
            dataGridViewFlightsWithCheckinInformation.Columns.Add("ExtensionData", "");
            dataGridViewFlightsWithCheckinInformation.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewFlightsWithCheckinInformation.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewFlightsWithCheckinInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewFlightsWithCheckinInformation.AutoResizeColumns();
        }
    }
}
