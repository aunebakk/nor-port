using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class SpecialServiceRequestListDurian : UserControl {
        
        public SpecialServiceRequestListDurian() {
           InitializeComponent();
           InitializeGridSpecialServiceRequestList();
        }
        
        public virtual string ServiceSpecialServiceRequestGroupRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewSpecialServiceRequestList.CurrentRow.Cells["ServiceSpecialServiceRequestGroupRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ServiceSpecialServiceRequestCode {
            get {
                if (!DesignMode) return (System.String) dataGridViewSpecialServiceRequestList.CurrentRow.Cells["ServiceSpecialServiceRequestCode"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ServiceSpecialServiceRequestName {
            get {
                if (!DesignMode) return (System.String) dataGridViewSpecialServiceRequestList.CurrentRow.Cells["ServiceSpecialServiceRequestName"].Value; else return String.Empty;;
            }
        }
        
        public virtual decimal Amount {
            get {
                if (!DesignMode) return (System.Decimal) dataGridViewSpecialServiceRequestList.CurrentRow.Cells["Amount"].Value; else return 0;;
            }
        }
        
        public virtual string FinancialCurrencyTypeName {
            get {
                if (!DesignMode) return (System.String) dataGridViewSpecialServiceRequestList.CurrentRow.Cells["FinancialCurrencyTypeName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ServiceDescription {
            get {
                if (!DesignMode) return (System.String) dataGridViewSpecialServiceRequestList.CurrentRow.Cells["ServiceDescription"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ServiceSpecialServiceRequestRequirementName {
            get {
                if (!DesignMode) return (System.String) dataGridViewSpecialServiceRequestList.CurrentRow.Cells["ServiceSpecialServiceRequestRequirementName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ServiceSpecialServiceRequestOperationRuleName {
            get {
                if (!DesignMode) return (System.String) dataGridViewSpecialServiceRequestList.CurrentRow.Cells["ServiceSpecialServiceRequestOperationRuleName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid ServiceSpecialServiceRequestId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewSpecialServiceRequestList.CurrentRow.Cells["ServiceSpecialServiceRequestId"].Value; else return Guid.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewSpecialServiceRequestList.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewSpecialServiceRequestList_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshSpecialServiceRequestList() {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewSpecialServiceRequestList.CurrentRow != null)
                    position = dataGridViewSpecialServiceRequestList.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new FinancialSearchServiceClient().SpecialServiceRequestList();
                dataGridViewSpecialServiceRequestList.AutoGenerateColumns = true;
                dataGridViewSpecialServiceRequestList.DataSource = bindingSource;
                dataGridViewSpecialServiceRequestList.AutoResizeColumns();

                // position to previous row
                if (dataGridViewSpecialServiceRequestList.Rows.Count > 0) { 
                    dataGridViewSpecialServiceRequestList.CurrentCell = 
                        dataGridViewSpecialServiceRequestList.Rows[position].Cells[1];
                    dataGridViewSpecialServiceRequestList.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridSpecialServiceRequestList() {
            dataGridViewSpecialServiceRequestList.Columns.Clear();
            dataGridViewSpecialServiceRequestList.AutoGenerateColumns = false;
            dataGridViewSpecialServiceRequestList.Columns.Add("ServiceSpecialServiceRequestGroupRcd","Service Special Service Request Group");
            dataGridViewSpecialServiceRequestList.Columns.Add("ServiceSpecialServiceRequestCode","Service Special Service Request Code");
            dataGridViewSpecialServiceRequestList.Columns.Add("ServiceSpecialServiceRequestName","Service Special Service Request Name");
            dataGridViewSpecialServiceRequestList.Columns.Add("Amount","Amount");
            dataGridViewSpecialServiceRequestList.Columns.Add("FinancialCurrencyTypeName","Financial Currency Type Name");
            dataGridViewSpecialServiceRequestList.Columns.Add("ServiceDescription","Service Description");
            dataGridViewSpecialServiceRequestList.Columns.Add("ServiceSpecialServiceRequestRequirementName","Service Special Service Request Requirement Name");
            dataGridViewSpecialServiceRequestList.Columns.Add("ServiceSpecialServiceRequestOperationRuleName","Service Special Service Request Operation Rule Name");
            dataGridViewSpecialServiceRequestList.Columns.Add("ServiceSpecialServiceRequestId","Service Special Service Request Id");
            dataGridViewSpecialServiceRequestList.Columns.Add("ExtensionData", "");
            dataGridViewSpecialServiceRequestList.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewSpecialServiceRequestList.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewSpecialServiceRequestList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewSpecialServiceRequestList.AutoResizeColumns();
        }
    }
}
