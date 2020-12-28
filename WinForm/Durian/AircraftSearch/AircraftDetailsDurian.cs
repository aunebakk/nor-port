using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class AircraftDetailsDurian : UserControl {
        
        public AircraftDetailsDurian() {
           InitializeComponent();
           InitializeGridAircraftDetails();
        }
        
        public virtual string AircraftName {
            get {
                if (!DesignMode) return (System.String) dataGridViewAircraftDetails.CurrentRow.Cells["AircraftName"].Value; else return String.Empty;;
            }
        }
        
        public virtual byte[] AircraftFamilyImage {
            get {
                if (!DesignMode) return (System.Byte[]) dataGridViewAircraftDetails.CurrentRow.Cells["AircraftFamilyImage"].Value; else return null;;
            }
        }
        
        public virtual string AircraftConfigurationName {
            get {
                if (!DesignMode) return (System.String) dataGridViewAircraftDetails.CurrentRow.Cells["AircraftConfigurationName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string AircraftBodyName {
            get {
                if (!DesignMode) return (System.String) dataGridViewAircraftDetails.CurrentRow.Cells["AircraftBodyName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string AircraftTypeName {
            get {
                if (!DesignMode) return (System.String) dataGridViewAircraftDetails.CurrentRow.Cells["AircraftTypeName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ProductInfoValue {
            get {
                if (!DesignMode) return (System.String) dataGridViewAircraftDetails.CurrentRow.Cells["ProductInfoValue"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid AircraftId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewAircraftDetails.CurrentRow.Cells["AircraftId"].Value; else return Guid.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewAircraftDetails.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewAircraftDetails_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshAircraftDetails() {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewAircraftDetails.CurrentRow != null)
                    position = dataGridViewAircraftDetails.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new AircraftSearchService().AircraftDetails();
                dataGridViewAircraftDetails.AutoGenerateColumns = true;
                dataGridViewAircraftDetails.DataSource = bindingSource;
                dataGridViewAircraftDetails.AutoResizeColumns();

                // position to previous row
                if (dataGridViewAircraftDetails.Rows.Count > 0) { 
                    dataGridViewAircraftDetails.CurrentCell = 
                        dataGridViewAircraftDetails.Rows[position].Cells[1];
                    dataGridViewAircraftDetails.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridAircraftDetails() {
            dataGridViewAircraftDetails.Columns.Clear();
            dataGridViewAircraftDetails.AutoGenerateColumns = false;
            dataGridViewAircraftDetails.Columns.Add("AircraftName","Aircraft Name");
            dataGridViewAircraftDetails.Columns.Add("AircraftFamilyImage","Aircraft Family Image");
            dataGridViewAircraftDetails.Columns.Add("AircraftConfigurationName","Aircraft Configuration Name");
            dataGridViewAircraftDetails.Columns.Add("AircraftBodyName","Aircraft Body Name");
            dataGridViewAircraftDetails.Columns.Add("AircraftTypeName","Aircraft Type Name");
            dataGridViewAircraftDetails.Columns.Add("ProductInfoValue","Product Info Value");
            dataGridViewAircraftDetails.Columns.Add("AircraftId","Aircraft Id");
            dataGridViewAircraftDetails.Columns.Add("ExtensionData", "");
            dataGridViewAircraftDetails.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewAircraftDetails.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewAircraftDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewAircraftDetails.AutoResizeColumns();
        }
    }
}
