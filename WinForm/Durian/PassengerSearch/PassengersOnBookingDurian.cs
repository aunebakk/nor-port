using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class PassengersOnBookingDurian : UserControl {
        
        public PassengersOnBookingDurian() {
           InitializeComponent();
           InitializeGridPassengersOnBooking();
        }
        
        public virtual System.Guid PassengerId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewPassengersOnBooking.CurrentRow.Cells["PassengerId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual string PassengerName {
            get {
                if (!DesignMode) return (System.String) dataGridViewPassengersOnBooking.CurrentRow.Cells["PassengerName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string PassengerTypeName {
            get {
                if (!DesignMode) return (System.String) dataGridViewPassengersOnBooking.CurrentRow.Cells["PassengerTypeName"].Value; else return String.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewPassengersOnBooking.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewPassengersOnBooking_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshPassengersOnBooking(System.Guid bookingId) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewPassengersOnBooking.CurrentRow != null)
                    position = dataGridViewPassengersOnBooking.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new PassengerSearchServiceClient().PassengersOnBooking(bookingId);
                dataGridViewPassengersOnBooking.AutoGenerateColumns = true;
                dataGridViewPassengersOnBooking.DataSource = bindingSource;
                dataGridViewPassengersOnBooking.AutoResizeColumns();

                // position to previous row
                if (dataGridViewPassengersOnBooking.Rows.Count > 0) { 
                    dataGridViewPassengersOnBooking.CurrentCell = 
                        dataGridViewPassengersOnBooking.Rows[position].Cells[1];
                    dataGridViewPassengersOnBooking.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridPassengersOnBooking() {
            dataGridViewPassengersOnBooking.Columns.Clear();
            dataGridViewPassengersOnBooking.AutoGenerateColumns = false;
            dataGridViewPassengersOnBooking.Columns.Add("PassengerId","Passenger Id");
            dataGridViewPassengersOnBooking.Columns.Add("PassengerName","Passenger Name");
            dataGridViewPassengersOnBooking.Columns.Add("PassengerTypeName","Passenger Type Name");
            dataGridViewPassengersOnBooking.Columns.Add("ExtensionData", "");
            dataGridViewPassengersOnBooking.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewPassengersOnBooking.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewPassengersOnBooking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewPassengersOnBooking.AutoResizeColumns();
        }
    }
}
