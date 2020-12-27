using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class AircraftMaintenanceCompartmentIndexWithFilterDurian : UserControl {
        
        public AircraftMaintenanceCompartmentIndexWithFilterDurian() {
           InitializeComponent();
           InitializeGridAircraftMaintenanceCompartmentIndexWithFilter();
        }
        
        public virtual System.Guid AircraftId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewAircraftMaintenanceCompartmentIndexWithFilter.CurrentRow.Cells["AircraftId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual string AircraftName {
            get {
                if (!DesignMode) return (System.String) dataGridViewAircraftMaintenanceCompartmentIndexWithFilter.CurrentRow.Cells["AircraftName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string AircraftCompartmentTypeRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewAircraftMaintenanceCompartmentIndexWithFilter.CurrentRow.Cells["AircraftCompartmentTypeRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual string AircraftCompartmentTypeName {
            get {
                if (!DesignMode) return (System.String) dataGridViewAircraftMaintenanceCompartmentIndexWithFilter.CurrentRow.Cells["AircraftCompartmentTypeName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string AircraftCompartmentName {
            get {
                if (!DesignMode) return (System.String) dataGridViewAircraftMaintenanceCompartmentIndexWithFilter.CurrentRow.Cells["AircraftCompartmentName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid UserId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewAircraftMaintenanceCompartmentIndexWithFilter.CurrentRow.Cells["UserId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual string DefaultUserName {
            get {
                if (!DesignMode) return (System.String) dataGridViewAircraftMaintenanceCompartmentIndexWithFilter.CurrentRow.Cells["DefaultUserName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.DateTime DateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewAircraftMaintenanceCompartmentIndexWithFilter.CurrentRow.Cells["DateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual System.Guid AircraftCompartmentId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewAircraftMaintenanceCompartmentIndexWithFilter.CurrentRow.Cells["AircraftCompartmentId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual System.Guid AircraftCompartmentMeasurementId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewAircraftMaintenanceCompartmentIndexWithFilter.CurrentRow.Cells["AircraftCompartmentMeasurementId"].Value; else return Guid.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewAircraftMaintenanceCompartmentIndexWithFilter.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewAircraftMaintenanceCompartmentIndexWithFilter_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshAircraftMaintenanceCompartmentIndexWithFilter(System.Guid aircraftId) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewAircraftMaintenanceCompartmentIndexWithFilter.CurrentRow != null)
                    position = dataGridViewAircraftMaintenanceCompartmentIndexWithFilter.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new AircraftMaintenanceSearchService().AircraftMaintenanceCompartmentIndexWithFilter(aircraftId);
                dataGridViewAircraftMaintenanceCompartmentIndexWithFilter.AutoGenerateColumns = true;
                dataGridViewAircraftMaintenanceCompartmentIndexWithFilter.DataSource = bindingSource;
                dataGridViewAircraftMaintenanceCompartmentIndexWithFilter.AutoResizeColumns();

                // position to previous row
                if (dataGridViewAircraftMaintenanceCompartmentIndexWithFilter.Rows.Count > 0) { 
                    dataGridViewAircraftMaintenanceCompartmentIndexWithFilter.CurrentCell = 
                        dataGridViewAircraftMaintenanceCompartmentIndexWithFilter.Rows[position].Cells[1];
                    dataGridViewAircraftMaintenanceCompartmentIndexWithFilter.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridAircraftMaintenanceCompartmentIndexWithFilter() {
            dataGridViewAircraftMaintenanceCompartmentIndexWithFilter.Columns.Clear();
            dataGridViewAircraftMaintenanceCompartmentIndexWithFilter.AutoGenerateColumns = false;
            dataGridViewAircraftMaintenanceCompartmentIndexWithFilter.Columns.Add("AircraftId","Aircraft Id");
            dataGridViewAircraftMaintenanceCompartmentIndexWithFilter.Columns.Add("AircraftName","Aircraft Name");
            dataGridViewAircraftMaintenanceCompartmentIndexWithFilter.Columns.Add("AircraftCompartmentTypeRcd","Aircraft Compartment Type");
            dataGridViewAircraftMaintenanceCompartmentIndexWithFilter.Columns.Add("AircraftCompartmentTypeName","Aircraft Compartment Type Name");
            dataGridViewAircraftMaintenanceCompartmentIndexWithFilter.Columns.Add("AircraftCompartmentName","Aircraft Compartment Name");
            dataGridViewAircraftMaintenanceCompartmentIndexWithFilter.Columns.Add("UserId","User Id");
            dataGridViewAircraftMaintenanceCompartmentIndexWithFilter.Columns.Add("DefaultUserName","Default User Name");
            dataGridViewAircraftMaintenanceCompartmentIndexWithFilter.Columns.Add("DateTime","Date Time");
            dataGridViewAircraftMaintenanceCompartmentIndexWithFilter.Columns.Add("AircraftCompartmentId","Aircraft Compartment Id");
            dataGridViewAircraftMaintenanceCompartmentIndexWithFilter.Columns.Add("AircraftCompartmentMeasurementId","Aircraft Compartment Measurement Id");
            dataGridViewAircraftMaintenanceCompartmentIndexWithFilter.Columns.Add("ExtensionData", "");
            dataGridViewAircraftMaintenanceCompartmentIndexWithFilter.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewAircraftMaintenanceCompartmentIndexWithFilter.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewAircraftMaintenanceCompartmentIndexWithFilter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewAircraftMaintenanceCompartmentIndexWithFilter.AutoResizeColumns();
        }
    }
}
