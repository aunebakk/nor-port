using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class AircraftMaintenanceIdentifierIndexWithFilterDurian : UserControl {
        
        public AircraftMaintenanceIdentifierIndexWithFilterDurian() {
           InitializeComponent();
           InitializeGridAircraftMaintenanceIdentifierIndexWithFilter();
        }
        
        public virtual System.Guid AircraftId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewAircraftMaintenanceIdentifierIndexWithFilter.CurrentRow.Cells["AircraftId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual string AircraftName {
            get {
                if (!DesignMode) return (System.String) dataGridViewAircraftMaintenanceIdentifierIndexWithFilter.CurrentRow.Cells["AircraftName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string AircraftIdentifierTypeRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewAircraftMaintenanceIdentifierIndexWithFilter.CurrentRow.Cells["AircraftIdentifierTypeRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual string AircraftIdentifierTypeName {
            get {
                if (!DesignMode) return (System.String) dataGridViewAircraftMaintenanceIdentifierIndexWithFilter.CurrentRow.Cells["AircraftIdentifierTypeName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string AircraftIdentifierCode {
            get {
                if (!DesignMode) return (System.String) dataGridViewAircraftMaintenanceIdentifierIndexWithFilter.CurrentRow.Cells["AircraftIdentifierCode"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid UserId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewAircraftMaintenanceIdentifierIndexWithFilter.CurrentRow.Cells["UserId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual string DefaultUserName {
            get {
                if (!DesignMode) return (System.String) dataGridViewAircraftMaintenanceIdentifierIndexWithFilter.CurrentRow.Cells["DefaultUserName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.DateTime DateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewAircraftMaintenanceIdentifierIndexWithFilter.CurrentRow.Cells["DateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual System.Guid AircraftIdentifierId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewAircraftMaintenanceIdentifierIndexWithFilter.CurrentRow.Cells["AircraftIdentifierId"].Value; else return Guid.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewAircraftMaintenanceIdentifierIndexWithFilter.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewAircraftMaintenanceIdentifierIndexWithFilter_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshAircraftMaintenanceIdentifierIndexWithFilter(System.Guid aircraftId) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewAircraftMaintenanceIdentifierIndexWithFilter.CurrentRow != null)
                    position = dataGridViewAircraftMaintenanceIdentifierIndexWithFilter.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new AircraftMaintenanceSearchServiceClient().AircraftMaintenanceIdentifierIndexWithFilter(aircraftId);
                dataGridViewAircraftMaintenanceIdentifierIndexWithFilter.AutoGenerateColumns = true;
                dataGridViewAircraftMaintenanceIdentifierIndexWithFilter.DataSource = bindingSource;
                dataGridViewAircraftMaintenanceIdentifierIndexWithFilter.AutoResizeColumns();

                // position to previous row
                if (dataGridViewAircraftMaintenanceIdentifierIndexWithFilter.Rows.Count > 0) { 
                    dataGridViewAircraftMaintenanceIdentifierIndexWithFilter.CurrentCell = 
                        dataGridViewAircraftMaintenanceIdentifierIndexWithFilter.Rows[position].Cells[1];
                    dataGridViewAircraftMaintenanceIdentifierIndexWithFilter.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridAircraftMaintenanceIdentifierIndexWithFilter() {
            dataGridViewAircraftMaintenanceIdentifierIndexWithFilter.Columns.Clear();
            dataGridViewAircraftMaintenanceIdentifierIndexWithFilter.AutoGenerateColumns = false;
            dataGridViewAircraftMaintenanceIdentifierIndexWithFilter.Columns.Add("AircraftId","Aircraft Id");
            dataGridViewAircraftMaintenanceIdentifierIndexWithFilter.Columns.Add("AircraftName","Aircraft Name");
            dataGridViewAircraftMaintenanceIdentifierIndexWithFilter.Columns.Add("AircraftIdentifierTypeRcd","Aircraft Identifier Type");
            dataGridViewAircraftMaintenanceIdentifierIndexWithFilter.Columns.Add("AircraftIdentifierTypeName","Aircraft Identifier Type Name");
            dataGridViewAircraftMaintenanceIdentifierIndexWithFilter.Columns.Add("AircraftIdentifierCode","Aircraft Identifier Code");
            dataGridViewAircraftMaintenanceIdentifierIndexWithFilter.Columns.Add("UserId","User Id");
            dataGridViewAircraftMaintenanceIdentifierIndexWithFilter.Columns.Add("DefaultUserName","Default User Name");
            dataGridViewAircraftMaintenanceIdentifierIndexWithFilter.Columns.Add("DateTime","Date Time");
            dataGridViewAircraftMaintenanceIdentifierIndexWithFilter.Columns.Add("AircraftIdentifierId","Aircraft Identifier Id");
            dataGridViewAircraftMaintenanceIdentifierIndexWithFilter.Columns.Add("ExtensionData", "");
            dataGridViewAircraftMaintenanceIdentifierIndexWithFilter.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewAircraftMaintenanceIdentifierIndexWithFilter.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewAircraftMaintenanceIdentifierIndexWithFilter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewAircraftMaintenanceIdentifierIndexWithFilter.AutoResizeColumns();
        }
    }
}
