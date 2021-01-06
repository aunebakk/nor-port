using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class FlightsOpenForCheckinWithDescriptionDurian : UserControl {
        
        public FlightsOpenForCheckinWithDescriptionDurian() {
           InitializeComponent();
           InitializeGridFlightsOpenForCheckinWithDescription();
        }
        
        public virtual string AirlineIdentifierCode {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightsOpenForCheckinWithDescription.CurrentRow.Cells["AirlineIdentifierCode"].Value; else return String.Empty;;
            }
        }
        
        public virtual string FlightNumber {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightsOpenForCheckinWithDescription.CurrentRow.Cells["FlightNumber"].Value; else return String.Empty;;
            }
        }
        
        public virtual string DepartureAirportIdentifierCode {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightsOpenForCheckinWithDescription.CurrentRow.Cells["DepartureAirportIdentifierCode"].Value; else return String.Empty;;
            }
        }
        
        public virtual string DepartureAirportName {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightsOpenForCheckinWithDescription.CurrentRow.Cells["DepartureAirportName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ArrivalAirportIdentifierCode {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightsOpenForCheckinWithDescription.CurrentRow.Cells["ArrivalAirportIdentifierCode"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ArrivalAirportName {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightsOpenForCheckinWithDescription.CurrentRow.Cells["ArrivalAirportName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.DateTime FromDateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewFlightsOpenForCheckinWithDescription.CurrentRow.Cells["FromDateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual System.DateTime UntilDateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewFlightsOpenForCheckinWithDescription.CurrentRow.Cells["UntilDateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual int PassengersBookedCount {
            get {
                if (!DesignMode) return (System.Int32) dataGridViewFlightsOpenForCheckinWithDescription.CurrentRow.Cells["PassengersBookedCount"].Value; else return 0;;
            }
        }
        
        public virtual string FlightDescription {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightsOpenForCheckinWithDescription.CurrentRow.Cells["FlightDescription"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid FlightId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewFlightsOpenForCheckinWithDescription.CurrentRow.Cells["FlightId"].Value; else return Guid.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewFlightsOpenForCheckinWithDescription.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewFlightsOpenForCheckinWithDescription_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshFlightsOpenForCheckinWithDescription(System.Guid departureAirportId, System.Guid arrivalAirportId, System.DateTime fromDateTime, System.DateTime untilDateTime) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewFlightsOpenForCheckinWithDescription.CurrentRow != null)
                    position = dataGridViewFlightsOpenForCheckinWithDescription.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new FlightSearchServiceClient().FlightsOpenForCheckinWithDescription(departureAirportId,arrivalAirportId,fromDateTime,untilDateTime);
                dataGridViewFlightsOpenForCheckinWithDescription.AutoGenerateColumns = true;
                dataGridViewFlightsOpenForCheckinWithDescription.DataSource = bindingSource;
                dataGridViewFlightsOpenForCheckinWithDescription.AutoResizeColumns();

                // position to previous row
                if (dataGridViewFlightsOpenForCheckinWithDescription.Rows.Count > 0) { 
                    dataGridViewFlightsOpenForCheckinWithDescription.CurrentCell = 
                        dataGridViewFlightsOpenForCheckinWithDescription.Rows[position].Cells[1];
                    dataGridViewFlightsOpenForCheckinWithDescription.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridFlightsOpenForCheckinWithDescription() {
            dataGridViewFlightsOpenForCheckinWithDescription.Columns.Clear();
            dataGridViewFlightsOpenForCheckinWithDescription.AutoGenerateColumns = false;
            dataGridViewFlightsOpenForCheckinWithDescription.Columns.Add("AirlineIdentifierCode","Airline Identifier Code");
            dataGridViewFlightsOpenForCheckinWithDescription.Columns.Add("FlightNumber","Flight Number");
            dataGridViewFlightsOpenForCheckinWithDescription.Columns.Add("DepartureAirportIdentifierCode","Departure Airport Identifier Code");
            dataGridViewFlightsOpenForCheckinWithDescription.Columns.Add("DepartureAirportName","Departure Airport Name");
            dataGridViewFlightsOpenForCheckinWithDescription.Columns.Add("ArrivalAirportIdentifierCode","Arrival Airport Identifier Code");
            dataGridViewFlightsOpenForCheckinWithDescription.Columns.Add("ArrivalAirportName","Arrival Airport Name");
            dataGridViewFlightsOpenForCheckinWithDescription.Columns.Add("FromDateTime","From Date Time");
            dataGridViewFlightsOpenForCheckinWithDescription.Columns.Add("UntilDateTime","Until Date Time");
            dataGridViewFlightsOpenForCheckinWithDescription.Columns.Add("PassengersBookedCount","Passengers Booked Count");
            dataGridViewFlightsOpenForCheckinWithDescription.Columns.Add("FlightDescription","Flight Description");
            dataGridViewFlightsOpenForCheckinWithDescription.Columns.Add("FlightId","Flight Id");
            dataGridViewFlightsOpenForCheckinWithDescription.Columns.Add("ExtensionData", "");
            dataGridViewFlightsOpenForCheckinWithDescription.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewFlightsOpenForCheckinWithDescription.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewFlightsOpenForCheckinWithDescription.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewFlightsOpenForCheckinWithDescription.AutoResizeColumns();
        }
    }
}
