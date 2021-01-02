using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class FlightsOnBookingDurian : UserControl {
        
        public FlightsOnBookingDurian() {
           InitializeComponent();
           InitializeGridFlightsOnBooking();
        }
        
        public virtual string FlightNumber {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightsOnBooking.CurrentRow.Cells["FlightNumber"].Value; else return String.Empty;;
            }
        }
        
        public virtual string OriginAirportCode {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightsOnBooking.CurrentRow.Cells["OriginAirportCode"].Value; else return String.Empty;;
            }
        }
        
        public virtual string OriginAirportName {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightsOnBooking.CurrentRow.Cells["OriginAirportName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string DestinationAirportCode {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightsOnBooking.CurrentRow.Cells["DestinationAirportCode"].Value; else return String.Empty;;
            }
        }
        
        public virtual string DestinationAirportName {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightsOnBooking.CurrentRow.Cells["DestinationAirportName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.DateTime FromDateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewFlightsOnBooking.CurrentRow.Cells["FromDateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual System.DateTime UntilDateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewFlightsOnBooking.CurrentRow.Cells["UntilDateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual string Comment {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightsOnBooking.CurrentRow.Cells["Comment"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid FlightId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewFlightsOnBooking.CurrentRow.Cells["FlightId"].Value; else return Guid.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewFlightsOnBooking.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewFlightsOnBooking_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshFlightsOnBooking(System.Guid bookingId) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewFlightsOnBooking.CurrentRow != null)
                    position = dataGridViewFlightsOnBooking.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new FlightSearchServiceClient().FlightsOnBooking(bookingId);
                dataGridViewFlightsOnBooking.AutoGenerateColumns = true;
                dataGridViewFlightsOnBooking.DataSource = bindingSource;
                dataGridViewFlightsOnBooking.AutoResizeColumns();

                // position to previous row
                if (dataGridViewFlightsOnBooking.Rows.Count > 0) { 
                    dataGridViewFlightsOnBooking.CurrentCell = 
                        dataGridViewFlightsOnBooking.Rows[position].Cells[1];
                    dataGridViewFlightsOnBooking.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridFlightsOnBooking() {
            dataGridViewFlightsOnBooking.Columns.Clear();
            dataGridViewFlightsOnBooking.AutoGenerateColumns = false;
            dataGridViewFlightsOnBooking.Columns.Add("FlightNumber","Flight Number");
            dataGridViewFlightsOnBooking.Columns.Add("OriginAirportCode","Origin Airport Code");
            dataGridViewFlightsOnBooking.Columns.Add("OriginAirportName","Origin Airport Name");
            dataGridViewFlightsOnBooking.Columns.Add("DestinationAirportCode","Destination Airport Code");
            dataGridViewFlightsOnBooking.Columns.Add("DestinationAirportName","Destination Airport Name");
            dataGridViewFlightsOnBooking.Columns.Add("FromDateTime","From Date Time");
            dataGridViewFlightsOnBooking.Columns.Add("UntilDateTime","Until Date Time");
            dataGridViewFlightsOnBooking.Columns.Add("Comment","Comment");
            dataGridViewFlightsOnBooking.Columns.Add("FlightId","Flight Id");
            dataGridViewFlightsOnBooking.Columns.Add("ExtensionData", "");
            dataGridViewFlightsOnBooking.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewFlightsOnBooking.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewFlightsOnBooking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewFlightsOnBooking.AutoResizeColumns();
        }
    }
}
