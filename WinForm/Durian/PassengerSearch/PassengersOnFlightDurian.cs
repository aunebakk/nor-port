using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class PassengersOnFlightDurian : UserControl {
        
        public PassengersOnFlightDurian() {
           InitializeComponent();
           InitializeGridPassengersOnFlight();
        }
        
        public virtual string RecordLocator {
            get {
                if (!DesignMode) return (System.String) dataGridViewPassengersOnFlight.CurrentRow.Cells["RecordLocator"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ReceivedFrom {
            get {
                if (!DesignMode) return (System.String) dataGridViewPassengersOnFlight.CurrentRow.Cells["ReceivedFrom"].Value; else return String.Empty;;
            }
        }
        
        public virtual string PassengerName {
            get {
                if (!DesignMode) return (System.String) dataGridViewPassengersOnFlight.CurrentRow.Cells["PassengerName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string PassengerTypeName {
            get {
                if (!DesignMode) return (System.String) dataGridViewPassengersOnFlight.CurrentRow.Cells["PassengerTypeName"].Value; else return String.Empty;;
            }
        }
        
        public virtual bool CheckedinFlag {
            get {
                if (!DesignMode) return (System.Boolean) dataGridViewPassengersOnFlight.CurrentRow.Cells["CheckedinFlag"].Value; else return false;;
            }
        }
        
        public virtual System.Guid PassengerId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewPassengersOnFlight.CurrentRow.Cells["PassengerId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual System.Guid BookingId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewPassengersOnFlight.CurrentRow.Cells["BookingId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual System.Guid BookingPassengerId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewPassengersOnFlight.CurrentRow.Cells["BookingPassengerId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual System.Guid BookingFlightSegmentId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewPassengersOnFlight.CurrentRow.Cells["BookingFlightSegmentId"].Value; else return Guid.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewPassengersOnFlight.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewPassengersOnFlight_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshPassengersOnFlight(System.Guid flightId) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewPassengersOnFlight.CurrentRow != null)
                    position = dataGridViewPassengersOnFlight.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new PassengerSearchService().PassengersOnFlight(flightId);
                dataGridViewPassengersOnFlight.AutoGenerateColumns = true;
                dataGridViewPassengersOnFlight.DataSource = bindingSource;
                dataGridViewPassengersOnFlight.AutoResizeColumns();

                // position to previous row
                if (dataGridViewPassengersOnFlight.Rows.Count > 0) { 
                    dataGridViewPassengersOnFlight.CurrentCell = 
                        dataGridViewPassengersOnFlight.Rows[position].Cells[1];
                    dataGridViewPassengersOnFlight.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridPassengersOnFlight() {
            dataGridViewPassengersOnFlight.Columns.Clear();
            dataGridViewPassengersOnFlight.AutoGenerateColumns = false;
            dataGridViewPassengersOnFlight.Columns.Add("RecordLocator","Record Locator");
            dataGridViewPassengersOnFlight.Columns.Add("ReceivedFrom","Received From");
            dataGridViewPassengersOnFlight.Columns.Add("PassengerName","Passenger Name");
            dataGridViewPassengersOnFlight.Columns.Add("PassengerTypeName","Passenger Type Name");
            dataGridViewPassengersOnFlight.Columns.Add("CheckedinFlag","Checkedin Flag");
            dataGridViewPassengersOnFlight.Columns.Add("PassengerId","Passenger Id");
            dataGridViewPassengersOnFlight.Columns.Add("BookingId","Booking Id");
            dataGridViewPassengersOnFlight.Columns.Add("BookingPassengerId","Booking Passenger Id");
            dataGridViewPassengersOnFlight.Columns.Add("BookingFlightSegmentId","Booking Flight Segment Id");
            dataGridViewPassengersOnFlight.Columns.Add("ExtensionData", "");
            dataGridViewPassengersOnFlight.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewPassengersOnFlight.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewPassengersOnFlight.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewPassengersOnFlight.AutoResizeColumns();
        }
    }
}
