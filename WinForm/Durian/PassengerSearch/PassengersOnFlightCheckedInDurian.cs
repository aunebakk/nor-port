using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class PassengersOnFlightCheckedInDurian : UserControl {
        
        public PassengersOnFlightCheckedInDurian() {
           InitializeComponent();
           InitializeGridPassengersOnFlightCheckedIn();
        }
        
        public virtual string RecordLocator {
            get {
                if (!DesignMode) return (System.String) dataGridViewPassengersOnFlightCheckedIn.CurrentRow.Cells["RecordLocator"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ReceivedFrom {
            get {
                if (!DesignMode) return (System.String) dataGridViewPassengersOnFlightCheckedIn.CurrentRow.Cells["ReceivedFrom"].Value; else return String.Empty;;
            }
        }
        
        public virtual string PassengerName {
            get {
                if (!DesignMode) return (System.String) dataGridViewPassengersOnFlightCheckedIn.CurrentRow.Cells["PassengerName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string PassengerTypeName {
            get {
                if (!DesignMode) return (System.String) dataGridViewPassengersOnFlightCheckedIn.CurrentRow.Cells["PassengerTypeName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid PassengerId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewPassengersOnFlightCheckedIn.CurrentRow.Cells["PassengerId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual System.Guid BookingId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewPassengersOnFlightCheckedIn.CurrentRow.Cells["BookingId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual System.Guid BookingPassengerId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewPassengersOnFlightCheckedIn.CurrentRow.Cells["BookingPassengerId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual System.Guid BookingFlightSegmentId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewPassengersOnFlightCheckedIn.CurrentRow.Cells["BookingFlightSegmentId"].Value; else return Guid.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewPassengersOnFlightCheckedIn.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewPassengersOnFlightCheckedIn_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshPassengersOnFlightCheckedIn(System.Guid flightId) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewPassengersOnFlightCheckedIn.CurrentRow != null)
                    position = dataGridViewPassengersOnFlightCheckedIn.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new PassengerSearchServiceClient().PassengersOnFlightCheckedIn(flightId);
                dataGridViewPassengersOnFlightCheckedIn.AutoGenerateColumns = true;
                dataGridViewPassengersOnFlightCheckedIn.DataSource = bindingSource;
                dataGridViewPassengersOnFlightCheckedIn.AutoResizeColumns();

                // position to previous row
                if (dataGridViewPassengersOnFlightCheckedIn.Rows.Count > 0) { 
                    dataGridViewPassengersOnFlightCheckedIn.CurrentCell = 
                        dataGridViewPassengersOnFlightCheckedIn.Rows[position].Cells[1];
                    dataGridViewPassengersOnFlightCheckedIn.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridPassengersOnFlightCheckedIn() {
            dataGridViewPassengersOnFlightCheckedIn.Columns.Clear();
            dataGridViewPassengersOnFlightCheckedIn.AutoGenerateColumns = false;
            dataGridViewPassengersOnFlightCheckedIn.Columns.Add("RecordLocator","Record Locator");
            dataGridViewPassengersOnFlightCheckedIn.Columns.Add("ReceivedFrom","Received From");
            dataGridViewPassengersOnFlightCheckedIn.Columns.Add("PassengerName","Passenger Name");
            dataGridViewPassengersOnFlightCheckedIn.Columns.Add("PassengerTypeName","Passenger Type Name");
            dataGridViewPassengersOnFlightCheckedIn.Columns.Add("PassengerId","Passenger Id");
            dataGridViewPassengersOnFlightCheckedIn.Columns.Add("BookingId","Booking Id");
            dataGridViewPassengersOnFlightCheckedIn.Columns.Add("BookingPassengerId","Booking Passenger Id");
            dataGridViewPassengersOnFlightCheckedIn.Columns.Add("BookingFlightSegmentId","Booking Flight Segment Id");
            dataGridViewPassengersOnFlightCheckedIn.Columns.Add("ExtensionData", "");
            dataGridViewPassengersOnFlightCheckedIn.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewPassengersOnFlightCheckedIn.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewPassengersOnFlightCheckedIn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewPassengersOnFlightCheckedIn.AutoResizeColumns();
        }
    }
}
