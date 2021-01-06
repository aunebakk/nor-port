using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class ServiceFerryListDurian : UserControl {
        
        public ServiceFerryListDurian() {
           InitializeComponent();
           InitializeGridServiceFerryList();
        }
        
        public virtual string FerryName {
            get {
                if (!DesignMode) return (System.String) dataGridViewServiceFerryList.CurrentRow.Cells["FerryName"].Value; else return String.Empty;;
            }
        }
        
        public virtual decimal Amount {
            get {
                if (!DesignMode) return (System.Decimal) dataGridViewServiceFerryList.CurrentRow.Cells["Amount"].Value; else return 0;;
            }
        }
        
        public virtual string FinancialCurrencyTypeName {
            get {
                if (!DesignMode) return (System.String) dataGridViewServiceFerryList.CurrentRow.Cells["FinancialCurrencyTypeName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid FerryId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewServiceFerryList.CurrentRow.Cells["FerryId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual System.Guid ProductId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewServiceFerryList.CurrentRow.Cells["ProductId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual System.Guid ServiceFerryId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewServiceFerryList.CurrentRow.Cells["ServiceFerryId"].Value; else return Guid.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewServiceFerryList.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewServiceFerryList_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshServiceFerryList() {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewServiceFerryList.CurrentRow != null)
                    position = dataGridViewServiceFerryList.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new FinancialSearchServiceClient().ServiceFerryList();
                dataGridViewServiceFerryList.AutoGenerateColumns = true;
                dataGridViewServiceFerryList.DataSource = bindingSource;
                dataGridViewServiceFerryList.AutoResizeColumns();

                // position to previous row
                if (dataGridViewServiceFerryList.Rows.Count > 0) { 
                    dataGridViewServiceFerryList.CurrentCell = 
                        dataGridViewServiceFerryList.Rows[position].Cells[1];
                    dataGridViewServiceFerryList.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridServiceFerryList() {
            dataGridViewServiceFerryList.Columns.Clear();
            dataGridViewServiceFerryList.AutoGenerateColumns = false;
            dataGridViewServiceFerryList.Columns.Add("FerryName","Ferry Name");
            dataGridViewServiceFerryList.Columns.Add("Amount","Amount");
            dataGridViewServiceFerryList.Columns.Add("FinancialCurrencyTypeName","Financial Currency Type Name");
            dataGridViewServiceFerryList.Columns.Add("FerryId","Ferry Id");
            dataGridViewServiceFerryList.Columns.Add("ProductId","Product Id");
            dataGridViewServiceFerryList.Columns.Add("ServiceFerryId","Service Ferry Id");
            dataGridViewServiceFerryList.Columns.Add("ExtensionData", "");
            dataGridViewServiceFerryList.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewServiceFerryList.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewServiceFerryList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewServiceFerryList.AutoResizeColumns();
        }
    }
}
