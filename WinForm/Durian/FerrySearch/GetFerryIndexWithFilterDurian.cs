using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class GetFerryIndexWithFilterDurian : UserControl {
        
        public GetFerryIndexWithFilterDurian() {
           InitializeComponent();
           InitializeGridGetFerryIndexWithFilter();
        }
        
        public virtual string FerryName {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetFerryIndexWithFilter.CurrentRow.Cells["FerryName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string FerryTypeRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetFerryIndexWithFilter.CurrentRow.Cells["FerryTypeRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual string FerryTypeName {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetFerryIndexWithFilter.CurrentRow.Cells["FerryTypeName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid ProductId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewGetFerryIndexWithFilter.CurrentRow.Cells["ProductId"].Value; else return Guid.Empty;;
            }
        }
        
        public new virtual string ProductName {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetFerryIndexWithFilter.CurrentRow.Cells["ProductName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.DateTime FirstFloatDateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewGetFerryIndexWithFilter.CurrentRow.Cells["FirstFloatDateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual System.DateTime OperationalDateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewGetFerryIndexWithFilter.CurrentRow.Cells["OperationalDateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual string EngineType {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetFerryIndexWithFilter.CurrentRow.Cells["EngineType"].Value; else return String.Empty;;
            }
        }
        
        public virtual int PassengerCapacity {
            get {
                if (!DesignMode) return (System.Int32) dataGridViewGetFerryIndexWithFilter.CurrentRow.Cells["PassengerCapacity"].Value; else return 0;;
            }
        }
        
        public virtual System.Guid UserId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewGetFerryIndexWithFilter.CurrentRow.Cells["UserId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual string DefaultUserName {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetFerryIndexWithFilter.CurrentRow.Cells["DefaultUserName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.DateTime DateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewGetFerryIndexWithFilter.CurrentRow.Cells["DateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual System.Guid FerryId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewGetFerryIndexWithFilter.CurrentRow.Cells["FerryId"].Value; else return Guid.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewGetFerryIndexWithFilter.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewGetFerryIndexWithFilter_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshGetFerryIndexWithFilter() {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewGetFerryIndexWithFilter.CurrentRow != null)
                    position = dataGridViewGetFerryIndexWithFilter.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new FerrySearchServiceClient().GetFerryIndexWithFilter();
                dataGridViewGetFerryIndexWithFilter.AutoGenerateColumns = true;
                dataGridViewGetFerryIndexWithFilter.DataSource = bindingSource;
                dataGridViewGetFerryIndexWithFilter.AutoResizeColumns();

                // position to previous row
                if (dataGridViewGetFerryIndexWithFilter.Rows.Count > 0) { 
                    dataGridViewGetFerryIndexWithFilter.CurrentCell = 
                        dataGridViewGetFerryIndexWithFilter.Rows[position].Cells[1];
                    dataGridViewGetFerryIndexWithFilter.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridGetFerryIndexWithFilter() {
            dataGridViewGetFerryIndexWithFilter.Columns.Clear();
            dataGridViewGetFerryIndexWithFilter.AutoGenerateColumns = false;
            dataGridViewGetFerryIndexWithFilter.Columns.Add("FerryName","Ferry Name");
            dataGridViewGetFerryIndexWithFilter.Columns.Add("FerryTypeRcd","Ferry Type");
            dataGridViewGetFerryIndexWithFilter.Columns.Add("FerryTypeName","Ferry Type Name");
            dataGridViewGetFerryIndexWithFilter.Columns.Add("ProductId","Product Id");
            dataGridViewGetFerryIndexWithFilter.Columns.Add("ProductName","Product Name");
            dataGridViewGetFerryIndexWithFilter.Columns.Add("FirstFloatDateTime","First Float Date Time");
            dataGridViewGetFerryIndexWithFilter.Columns.Add("OperationalDateTime","Operational Date Time");
            dataGridViewGetFerryIndexWithFilter.Columns.Add("EngineType","Engine Type");
            dataGridViewGetFerryIndexWithFilter.Columns.Add("PassengerCapacity","Passenger Capacity");
            dataGridViewGetFerryIndexWithFilter.Columns.Add("UserId","User Id");
            dataGridViewGetFerryIndexWithFilter.Columns.Add("DefaultUserName","Default User Name");
            dataGridViewGetFerryIndexWithFilter.Columns.Add("DateTime","Date Time");
            dataGridViewGetFerryIndexWithFilter.Columns.Add("FerryId","Ferry Id");
            dataGridViewGetFerryIndexWithFilter.Columns.Add("ExtensionData", "");
            dataGridViewGetFerryIndexWithFilter.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewGetFerryIndexWithFilter.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewGetFerryIndexWithFilter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewGetFerryIndexWithFilter.AutoResizeColumns();
        }
    }
}
