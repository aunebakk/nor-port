using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {
    
    
    public partial class PassengersOnFlightWithoutEventsDurian : UserControl {
        
        public PassengersOnFlightWithoutEventsDurian() {
           InitializeComponent();
           InitializeGridPassengersOnFlightWithoutEvents();
        }
        
        public virtual string RecordLocator {
            get {
                if (!DesignMode) return (System.String) dataGridViewPassengersOnFlightWithoutEvents.CurrentRow.Cells["RecordLocator"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ReceivedFrom {
            get {
                if (!DesignMode) return (System.String) dataGridViewPassengersOnFlightWithoutEvents.CurrentRow.Cells["ReceivedFrom"].Value; else return String.Empty;;
            }
        }
        
        public virtual string PassengerName {
            get {
                if (!DesignMode) return (System.String) dataGridViewPassengersOnFlightWithoutEvents.CurrentRow.Cells["PassengerName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string PassengerTypeName {
            get {
                if (!DesignMode) return (System.String) dataGridViewPassengersOnFlightWithoutEvents.CurrentRow.Cells["PassengerTypeName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid PassengerId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewPassengersOnFlightWithoutEvents.CurrentRow.Cells["PassengerId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual System.Guid BookingId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewPassengersOnFlightWithoutEvents.CurrentRow.Cells["BookingId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual System.Guid BookingPassengerId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewPassengersOnFlightWithoutEvents.CurrentRow.Cells["BookingPassengerId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual System.Guid BookingFlightSegmentId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewPassengersOnFlightWithoutEvents.CurrentRow.Cells["BookingFlightSegmentId"].Value; else return Guid.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewPassengersOnFlightWithoutEvents.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewPassengersOnFlightWithoutEvents_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshPassengersOnFlightWithoutEvents(System.Guid flightId) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewPassengersOnFlightWithoutEvents.CurrentRow != null)
                    position = dataGridViewPassengersOnFlightWithoutEvents.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new PassengerSearchService().PassengersOnFlightWithoutEvents(flightId);
                dataGridViewPassengersOnFlightWithoutEvents.AutoGenerateColumns = true;
                dataGridViewPassengersOnFlightWithoutEvents.DataSource = bindingSource;
                dataGridViewPassengersOnFlightWithoutEvents.AutoResizeColumns();

                // position to previous row
                if (dataGridViewPassengersOnFlightWithoutEvents.Rows.Count > 0) { 
                    dataGridViewPassengersOnFlightWithoutEvents.CurrentCell = 
                        dataGridViewPassengersOnFlightWithoutEvents.Rows[position].Cells[1];
                    dataGridViewPassengersOnFlightWithoutEvents.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridPassengersOnFlightWithoutEvents() {
            dataGridViewPassengersOnFlightWithoutEvents.Columns.Clear();
            dataGridViewPassengersOnFlightWithoutEvents.AutoGenerateColumns = false;
            dataGridViewPassengersOnFlightWithoutEvents.Columns.Add("RecordLocator","Record Locator");
            dataGridViewPassengersOnFlightWithoutEvents.Columns.Add("ReceivedFrom","Received From");
            dataGridViewPassengersOnFlightWithoutEvents.Columns.Add("PassengerName","Passenger Name");
            dataGridViewPassengersOnFlightWithoutEvents.Columns.Add("PassengerTypeName","Passenger Type Name");
            dataGridViewPassengersOnFlightWithoutEvents.Columns.Add("PassengerId","Passenger Id");
            dataGridViewPassengersOnFlightWithoutEvents.Columns.Add("BookingId","Booking Id");
            dataGridViewPassengersOnFlightWithoutEvents.Columns.Add("BookingPassengerId","Booking Passenger Id");
            dataGridViewPassengersOnFlightWithoutEvents.Columns.Add("BookingFlightSegmentId","Booking Flight Segment Id");
            dataGridViewPassengersOnFlightWithoutEvents.Columns.Add("ExtensionData", "");
            dataGridViewPassengersOnFlightWithoutEvents.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewPassengersOnFlightWithoutEvents.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewPassengersOnFlightWithoutEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewPassengersOnFlightWithoutEvents.AutoResizeColumns();
        }
    }
}
