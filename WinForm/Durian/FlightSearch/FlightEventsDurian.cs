using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class FlightEventsDurian : UserControl {
        
        public FlightEventsDurian() {
           InitializeComponent();
           InitializeGridFlightEvents();
        }
        
        public virtual int FlightEventNumber {
            get {
                if (!DesignMode) return (System.Int32) dataGridViewFlightEvents.CurrentRow.Cells["FlightEventNumber"].Value; else return 0;;
            }
        }
        
        public virtual System.DateTime DateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewFlightEvents.CurrentRow.Cells["DateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual string DateTimeTypeRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightEvents.CurrentRow.Cells["DateTimeTypeRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual string DateTimeTypeName {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightEvents.CurrentRow.Cells["DateTimeTypeName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.DateTime NewDateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewFlightEvents.CurrentRow.Cells["NewDateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewFlightEvents.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewFlightEvents_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshFlightEvents(System.Guid flightId) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewFlightEvents.CurrentRow != null)
                    position = dataGridViewFlightEvents.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new FlightSearchService().FlightEvents(flightId);
                dataGridViewFlightEvents.AutoGenerateColumns = true;
                dataGridViewFlightEvents.DataSource = bindingSource;
                dataGridViewFlightEvents.AutoResizeColumns();

                // position to previous row
                if (dataGridViewFlightEvents.Rows.Count > 0) { 
                    dataGridViewFlightEvents.CurrentCell = 
                        dataGridViewFlightEvents.Rows[position].Cells[1];
                    dataGridViewFlightEvents.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridFlightEvents() {
            dataGridViewFlightEvents.Columns.Clear();
            dataGridViewFlightEvents.AutoGenerateColumns = false;
            dataGridViewFlightEvents.Columns.Add("FlightEventNumber","Flight Event Number");
            dataGridViewFlightEvents.Columns.Add("DateTime","Date Time");
            dataGridViewFlightEvents.Columns.Add("DateTimeTypeRcd","Date Time Type");
            dataGridViewFlightEvents.Columns.Add("DateTimeTypeName","Date Time Type Name");
            dataGridViewFlightEvents.Columns.Add("NewDateTime","New Date Time");
            dataGridViewFlightEvents.Columns.Add("ExtensionData", "");
            dataGridViewFlightEvents.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewFlightEvents.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewFlightEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewFlightEvents.AutoResizeColumns();
        }
    }
}
