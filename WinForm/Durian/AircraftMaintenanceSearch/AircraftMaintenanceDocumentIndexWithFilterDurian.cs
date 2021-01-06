using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class AircraftMaintenanceDocumentIndexWithFilterDurian : UserControl {
        
        public AircraftMaintenanceDocumentIndexWithFilterDurian() {
           InitializeComponent();
           InitializeGridAircraftMaintenanceDocumentIndexWithFilter();
        }
        
        public virtual System.Guid AircraftId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewAircraftMaintenanceDocumentIndexWithFilter.CurrentRow.Cells["AircraftId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual string AircraftName {
            get {
                if (!DesignMode) return (System.String) dataGridViewAircraftMaintenanceDocumentIndexWithFilter.CurrentRow.Cells["AircraftName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string AircraftDocumentTypeRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewAircraftMaintenanceDocumentIndexWithFilter.CurrentRow.Cells["AircraftDocumentTypeRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual string AircraftDocumentTypeName {
            get {
                if (!DesignMode) return (System.String) dataGridViewAircraftMaintenanceDocumentIndexWithFilter.CurrentRow.Cells["AircraftDocumentTypeName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string DocumentName {
            get {
                if (!DesignMode) return (System.String) dataGridViewAircraftMaintenanceDocumentIndexWithFilter.CurrentRow.Cells["DocumentName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.DateTime DocumentDateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewAircraftMaintenanceDocumentIndexWithFilter.CurrentRow.Cells["DocumentDateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual System.DateTime ExpiryDateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewAircraftMaintenanceDocumentIndexWithFilter.CurrentRow.Cells["ExpiryDateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual System.Guid UserId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewAircraftMaintenanceDocumentIndexWithFilter.CurrentRow.Cells["UserId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual string DefaultUserName {
            get {
                if (!DesignMode) return (System.String) dataGridViewAircraftMaintenanceDocumentIndexWithFilter.CurrentRow.Cells["DefaultUserName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.DateTime DateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewAircraftMaintenanceDocumentIndexWithFilter.CurrentRow.Cells["DateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual System.Guid AircraftDocumentId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewAircraftMaintenanceDocumentIndexWithFilter.CurrentRow.Cells["AircraftDocumentId"].Value; else return Guid.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewAircraftMaintenanceDocumentIndexWithFilter.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewAircraftMaintenanceDocumentIndexWithFilter_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshAircraftMaintenanceDocumentIndexWithFilter(System.Guid aircraftId) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewAircraftMaintenanceDocumentIndexWithFilter.CurrentRow != null)
                    position = dataGridViewAircraftMaintenanceDocumentIndexWithFilter.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new AircraftMaintenanceSearchServiceClient().AircraftMaintenanceDocumentIndexWithFilter(aircraftId);
                dataGridViewAircraftMaintenanceDocumentIndexWithFilter.AutoGenerateColumns = true;
                dataGridViewAircraftMaintenanceDocumentIndexWithFilter.DataSource = bindingSource;
                dataGridViewAircraftMaintenanceDocumentIndexWithFilter.AutoResizeColumns();

                // position to previous row
                if (dataGridViewAircraftMaintenanceDocumentIndexWithFilter.Rows.Count > 0) { 
                    dataGridViewAircraftMaintenanceDocumentIndexWithFilter.CurrentCell = 
                        dataGridViewAircraftMaintenanceDocumentIndexWithFilter.Rows[position].Cells[1];
                    dataGridViewAircraftMaintenanceDocumentIndexWithFilter.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridAircraftMaintenanceDocumentIndexWithFilter() {
            dataGridViewAircraftMaintenanceDocumentIndexWithFilter.Columns.Clear();
            dataGridViewAircraftMaintenanceDocumentIndexWithFilter.AutoGenerateColumns = false;
            dataGridViewAircraftMaintenanceDocumentIndexWithFilter.Columns.Add("AircraftId","Aircraft Id");
            dataGridViewAircraftMaintenanceDocumentIndexWithFilter.Columns.Add("AircraftName","Aircraft Name");
            dataGridViewAircraftMaintenanceDocumentIndexWithFilter.Columns.Add("AircraftDocumentTypeRcd","Aircraft Document Type");
            dataGridViewAircraftMaintenanceDocumentIndexWithFilter.Columns.Add("AircraftDocumentTypeName","Aircraft Document Type Name");
            dataGridViewAircraftMaintenanceDocumentIndexWithFilter.Columns.Add("DocumentName","Document Name");
            dataGridViewAircraftMaintenanceDocumentIndexWithFilter.Columns.Add("DocumentDateTime","Document Date Time");
            dataGridViewAircraftMaintenanceDocumentIndexWithFilter.Columns.Add("ExpiryDateTime","Expiry Date Time");
            dataGridViewAircraftMaintenanceDocumentIndexWithFilter.Columns.Add("UserId","User Id");
            dataGridViewAircraftMaintenanceDocumentIndexWithFilter.Columns.Add("DefaultUserName","Default User Name");
            dataGridViewAircraftMaintenanceDocumentIndexWithFilter.Columns.Add("DateTime","Date Time");
            dataGridViewAircraftMaintenanceDocumentIndexWithFilter.Columns.Add("AircraftDocumentId","Aircraft Document Id");
            dataGridViewAircraftMaintenanceDocumentIndexWithFilter.Columns.Add("ExtensionData", "");
            dataGridViewAircraftMaintenanceDocumentIndexWithFilter.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewAircraftMaintenanceDocumentIndexWithFilter.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewAircraftMaintenanceDocumentIndexWithFilter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewAircraftMaintenanceDocumentIndexWithFilter.AutoResizeColumns();
        }
    }
}
