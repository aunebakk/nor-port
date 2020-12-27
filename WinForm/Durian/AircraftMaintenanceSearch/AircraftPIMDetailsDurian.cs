using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class AircraftPIMDetailsDurian : UserControl {
        
        public AircraftPIMDetailsDurian() {
           InitializeComponent();
           InitializeGridAircraftPIMDetails();
        }
        
        public virtual string AircraftName {
            get {
                if (!DesignMode) return (System.String) dataGridViewAircraftPIMDetails.CurrentRow.Cells["AircraftName"].Value; else return String.Empty;;
            }
        }
        
        public virtual byte[] AircraftFamilyImage {
            get {
                if (!DesignMode) return (System.Byte[]) dataGridViewAircraftPIMDetails.CurrentRow.Cells["AircraftFamilyImage"].Value; else return null;;
            }
        }
        
        public virtual string AircraftConfigurationName {
            get {
                if (!DesignMode) return (System.String) dataGridViewAircraftPIMDetails.CurrentRow.Cells["AircraftConfigurationName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string AircraftBodyName {
            get {
                if (!DesignMode) return (System.String) dataGridViewAircraftPIMDetails.CurrentRow.Cells["AircraftBodyName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string AircraftTypeName {
            get {
                if (!DesignMode) return (System.String) dataGridViewAircraftPIMDetails.CurrentRow.Cells["AircraftTypeName"].Value; else return String.Empty;;
            }
        }
        
        public virtual int ProductInfoValue {
            get {
                if (!DesignMode) return (System.Int32) dataGridViewAircraftPIMDetails.CurrentRow.Cells["ProductInfoValue"].Value; else return 0;;
            }
        }
        
        public virtual System.Guid AircraftId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewAircraftPIMDetails.CurrentRow.Cells["AircraftId"].Value; else return Guid.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewAircraftPIMDetails.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewAircraftPIMDetails_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshAircraftPIMDetails() {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewAircraftPIMDetails.CurrentRow != null)
                    position = dataGridViewAircraftPIMDetails.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new AircraftMaintenanceSearchService().AircraftPIMDetails();
                dataGridViewAircraftPIMDetails.AutoGenerateColumns = true;
                dataGridViewAircraftPIMDetails.DataSource = bindingSource;
                dataGridViewAircraftPIMDetails.AutoResizeColumns();

                // position to previous row
                if (dataGridViewAircraftPIMDetails.Rows.Count > 0) { 
                    dataGridViewAircraftPIMDetails.CurrentCell = 
                        dataGridViewAircraftPIMDetails.Rows[position].Cells[1];
                    dataGridViewAircraftPIMDetails.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridAircraftPIMDetails() {
            dataGridViewAircraftPIMDetails.Columns.Clear();
            dataGridViewAircraftPIMDetails.AutoGenerateColumns = false;
            dataGridViewAircraftPIMDetails.Columns.Add("AircraftName","Aircraft Name");
            dataGridViewAircraftPIMDetails.Columns.Add("AircraftFamilyImage","Aircraft Family Image");
            dataGridViewAircraftPIMDetails.Columns.Add("AircraftConfigurationName","Aircraft Configuration Name");
            dataGridViewAircraftPIMDetails.Columns.Add("AircraftBodyName","Aircraft Body Name");
            dataGridViewAircraftPIMDetails.Columns.Add("AircraftTypeName","Aircraft Type Name");
            dataGridViewAircraftPIMDetails.Columns.Add("ProductInfoValue","Product Info Value");
            dataGridViewAircraftPIMDetails.Columns.Add("AircraftId","Aircraft Id");
            dataGridViewAircraftPIMDetails.Columns.Add("ExtensionData", "");
            dataGridViewAircraftPIMDetails.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewAircraftPIMDetails.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewAircraftPIMDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewAircraftPIMDetails.AutoResizeColumns();
        }
    }
}
