using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class AircraftMaintenanceIndexWithFilterDurian : UserControl {
        
        public AircraftMaintenanceIndexWithFilterDurian() {
           InitializeComponent();
           InitializeGridAircraftMaintenanceIndexWithFilter();
        }
        
        public virtual string AircraftName {
            get {
                if (!DesignMode) return (System.String) dataGridViewAircraftMaintenanceIndexWithFilter.CurrentRow.Cells["AircraftName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string AircraftConfigurationRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewAircraftMaintenanceIndexWithFilter.CurrentRow.Cells["AircraftConfigurationRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual string AircraftConfigurationName {
            get {
                if (!DesignMode) return (System.String) dataGridViewAircraftMaintenanceIndexWithFilter.CurrentRow.Cells["AircraftConfigurationName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string AircraftBodyRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewAircraftMaintenanceIndexWithFilter.CurrentRow.Cells["AircraftBodyRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual string AircraftBodyName {
            get {
                if (!DesignMode) return (System.String) dataGridViewAircraftMaintenanceIndexWithFilter.CurrentRow.Cells["AircraftBodyName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string AircraftTypeRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewAircraftMaintenanceIndexWithFilter.CurrentRow.Cells["AircraftTypeRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual string AircraftTypeName {
            get {
                if (!DesignMode) return (System.String) dataGridViewAircraftMaintenanceIndexWithFilter.CurrentRow.Cells["AircraftTypeName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string EngineType {
            get {
                if (!DesignMode) return (System.String) dataGridViewAircraftMaintenanceIndexWithFilter.CurrentRow.Cells["EngineType"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.DateTime OperationalDateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewAircraftMaintenanceIndexWithFilter.CurrentRow.Cells["OperationalDateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual System.DateTime FirstFlightDateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewAircraftMaintenanceIndexWithFilter.CurrentRow.Cells["FirstFlightDateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual int PassengerCapacity {
            get {
                if (!DesignMode) return (System.Int32) dataGridViewAircraftMaintenanceIndexWithFilter.CurrentRow.Cells["PassengerCapacity"].Value; else return 0;;
            }
        }
        
        public virtual System.Guid UserId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewAircraftMaintenanceIndexWithFilter.CurrentRow.Cells["UserId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual string DefaultUserName {
            get {
                if (!DesignMode) return (System.String) dataGridViewAircraftMaintenanceIndexWithFilter.CurrentRow.Cells["DefaultUserName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.DateTime DateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewAircraftMaintenanceIndexWithFilter.CurrentRow.Cells["DateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual System.Guid AircraftId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewAircraftMaintenanceIndexWithFilter.CurrentRow.Cells["AircraftId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual System.Guid ProductId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewAircraftMaintenanceIndexWithFilter.CurrentRow.Cells["ProductId"].Value; else return Guid.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewAircraftMaintenanceIndexWithFilter.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewAircraftMaintenanceIndexWithFilter_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshAircraftMaintenanceIndexWithFilter() {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewAircraftMaintenanceIndexWithFilter.CurrentRow != null)
                    position = dataGridViewAircraftMaintenanceIndexWithFilter.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new AircraftMaintenanceSearchService().AircraftMaintenanceIndexWithFilter();
                dataGridViewAircraftMaintenanceIndexWithFilter.AutoGenerateColumns = true;
                dataGridViewAircraftMaintenanceIndexWithFilter.DataSource = bindingSource;
                dataGridViewAircraftMaintenanceIndexWithFilter.AutoResizeColumns();

                // position to previous row
                if (dataGridViewAircraftMaintenanceIndexWithFilter.Rows.Count > 0) { 
                    dataGridViewAircraftMaintenanceIndexWithFilter.CurrentCell = 
                        dataGridViewAircraftMaintenanceIndexWithFilter.Rows[position].Cells[1];
                    dataGridViewAircraftMaintenanceIndexWithFilter.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridAircraftMaintenanceIndexWithFilter() {
            dataGridViewAircraftMaintenanceIndexWithFilter.Columns.Clear();
            dataGridViewAircraftMaintenanceIndexWithFilter.AutoGenerateColumns = false;
            dataGridViewAircraftMaintenanceIndexWithFilter.Columns.Add("AircraftName","Aircraft Name");
            dataGridViewAircraftMaintenanceIndexWithFilter.Columns.Add("AircraftConfigurationRcd","Aircraft Configuration");
            dataGridViewAircraftMaintenanceIndexWithFilter.Columns.Add("AircraftConfigurationName","Aircraft Configuration Name");
            dataGridViewAircraftMaintenanceIndexWithFilter.Columns.Add("AircraftBodyRcd","Aircraft Body");
            dataGridViewAircraftMaintenanceIndexWithFilter.Columns.Add("AircraftBodyName","Aircraft Body Name");
            dataGridViewAircraftMaintenanceIndexWithFilter.Columns.Add("AircraftTypeRcd","Aircraft Type");
            dataGridViewAircraftMaintenanceIndexWithFilter.Columns.Add("AircraftTypeName","Aircraft Type Name");
            dataGridViewAircraftMaintenanceIndexWithFilter.Columns.Add("EngineType","Engine Type");
            dataGridViewAircraftMaintenanceIndexWithFilter.Columns.Add("OperationalDateTime","Operational Date Time");
            dataGridViewAircraftMaintenanceIndexWithFilter.Columns.Add("FirstFlightDateTime","First Flight Date Time");
            dataGridViewAircraftMaintenanceIndexWithFilter.Columns.Add("PassengerCapacity","Passenger Capacity");
            dataGridViewAircraftMaintenanceIndexWithFilter.Columns.Add("UserId","User Id");
            dataGridViewAircraftMaintenanceIndexWithFilter.Columns.Add("DefaultUserName","Default User Name");
            dataGridViewAircraftMaintenanceIndexWithFilter.Columns.Add("DateTime","Date Time");
            dataGridViewAircraftMaintenanceIndexWithFilter.Columns.Add("AircraftId","Aircraft Id");
            dataGridViewAircraftMaintenanceIndexWithFilter.Columns.Add("ProductId","Product Id");
            dataGridViewAircraftMaintenanceIndexWithFilter.Columns.Add("ExtensionData", "");
            dataGridViewAircraftMaintenanceIndexWithFilter.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewAircraftMaintenanceIndexWithFilter.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewAircraftMaintenanceIndexWithFilter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewAircraftMaintenanceIndexWithFilter.AutoResizeColumns();
        }
    }
}
