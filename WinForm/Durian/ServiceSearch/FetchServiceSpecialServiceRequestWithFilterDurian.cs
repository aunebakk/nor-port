using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class FetchServiceSpecialServiceRequestWithFilterDurian : UserControl {
        
        public FetchServiceSpecialServiceRequestWithFilterDurian() {
           InitializeComponent();
           InitializeGridFetchServiceSpecialServiceRequestWithFilter();
        }
        
        public virtual string ServiceSpecialServiceRequestGroupRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewFetchServiceSpecialServiceRequestWithFilter.CurrentRow.Cells["ServiceSpecialServiceRequestGroupRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ServiceSpecialServiceRequestGroupName {
            get {
                if (!DesignMode) return (System.String) dataGridViewFetchServiceSpecialServiceRequestWithFilter.CurrentRow.Cells["ServiceSpecialServiceRequestGroupName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ServiceSpecialServiceRequestCode {
            get {
                if (!DesignMode) return (System.String) dataGridViewFetchServiceSpecialServiceRequestWithFilter.CurrentRow.Cells["ServiceSpecialServiceRequestCode"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ServiceSpecialServiceRequestName {
            get {
                if (!DesignMode) return (System.String) dataGridViewFetchServiceSpecialServiceRequestWithFilter.CurrentRow.Cells["ServiceSpecialServiceRequestName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ServiceDescription {
            get {
                if (!DesignMode) return (System.String) dataGridViewFetchServiceSpecialServiceRequestWithFilter.CurrentRow.Cells["ServiceDescription"].Value; else return String.Empty;;
            }
        }
        
        public virtual decimal Amount {
            get {
                if (!DesignMode) return (System.Decimal) dataGridViewFetchServiceSpecialServiceRequestWithFilter.CurrentRow.Cells["Amount"].Value; else return 0;;
            }
        }
        
        public virtual System.Guid FinancialCurrencyId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewFetchServiceSpecialServiceRequestWithFilter.CurrentRow.Cells["FinancialCurrencyId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual string FinancialCurrencyTypeName {
            get {
                if (!DesignMode) return (System.String) dataGridViewFetchServiceSpecialServiceRequestWithFilter.CurrentRow.Cells["FinancialCurrencyTypeName"].Value; else return String.Empty;;
            }
        }
        
        public virtual bool InventoryControlledFlag {
            get {
                if (!DesignMode) return (System.Boolean) dataGridViewFetchServiceSpecialServiceRequestWithFilter.CurrentRow.Cells["InventoryControlledFlag"].Value; else return false;;
            }
        }
        
        public virtual string RequestServiceSpecialServiceRequestRequirementRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewFetchServiceSpecialServiceRequestWithFilter.CurrentRow.Cells["RequestServiceSpecialServiceRequestRequirementRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual string RequestRequirementName {
            get {
                if (!DesignMode) return (System.String) dataGridViewFetchServiceSpecialServiceRequestWithFilter.CurrentRow.Cells["RequestRequirementName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ReplyServiceSpecialServiceRequestRequirementRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewFetchServiceSpecialServiceRequestWithFilter.CurrentRow.Cells["ReplyServiceSpecialServiceRequestRequirementRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ReplyRequirementName {
            get {
                if (!DesignMode) return (System.String) dataGridViewFetchServiceSpecialServiceRequestWithFilter.CurrentRow.Cells["ReplyRequirementName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ServiceSpecialServiceRequestOperationRuleRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewFetchServiceSpecialServiceRequestWithFilter.CurrentRow.Cells["ServiceSpecialServiceRequestOperationRuleRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ServiceSpecialServiceRequestOperationRuleName {
            get {
                if (!DesignMode) return (System.String) dataGridViewFetchServiceSpecialServiceRequestWithFilter.CurrentRow.Cells["ServiceSpecialServiceRequestOperationRuleName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid UserId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewFetchServiceSpecialServiceRequestWithFilter.CurrentRow.Cells["UserId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual string DefaultUserName {
            get {
                if (!DesignMode) return (System.String) dataGridViewFetchServiceSpecialServiceRequestWithFilter.CurrentRow.Cells["DefaultUserName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.DateTime DateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewFetchServiceSpecialServiceRequestWithFilter.CurrentRow.Cells["DateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual System.Guid ServiceSpecialServiceRequestId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewFetchServiceSpecialServiceRequestWithFilter.CurrentRow.Cells["ServiceSpecialServiceRequestId"].Value; else return Guid.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewFetchServiceSpecialServiceRequestWithFilter.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewFetchServiceSpecialServiceRequestWithFilter_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshFetchServiceSpecialServiceRequestWithFilter(string serviceSpecialServiceRequestGroupRcd, string serviceSpecialServiceRequestCode, string requestServiceSpecialServiceRequestRequirementRcd, string replyServiceSpecialServiceRequestRequirementRcd, string serviceSpecialServiceRequestOperationRuleRcd) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewFetchServiceSpecialServiceRequestWithFilter.CurrentRow != null)
                    position = dataGridViewFetchServiceSpecialServiceRequestWithFilter.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new ServiceSearchService().FetchServiceSpecialServiceRequestWithFilter(serviceSpecialServiceRequestGroupRcd,serviceSpecialServiceRequestCode,requestServiceSpecialServiceRequestRequirementRcd,replyServiceSpecialServiceRequestRequirementRcd,serviceSpecialServiceRequestOperationRuleRcd);
                dataGridViewFetchServiceSpecialServiceRequestWithFilter.AutoGenerateColumns = true;
                dataGridViewFetchServiceSpecialServiceRequestWithFilter.DataSource = bindingSource;
                dataGridViewFetchServiceSpecialServiceRequestWithFilter.AutoResizeColumns();

                // position to previous row
                if (dataGridViewFetchServiceSpecialServiceRequestWithFilter.Rows.Count > 0) { 
                    dataGridViewFetchServiceSpecialServiceRequestWithFilter.CurrentCell = 
                        dataGridViewFetchServiceSpecialServiceRequestWithFilter.Rows[position].Cells[1];
                    dataGridViewFetchServiceSpecialServiceRequestWithFilter.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridFetchServiceSpecialServiceRequestWithFilter() {
            dataGridViewFetchServiceSpecialServiceRequestWithFilter.Columns.Clear();
            dataGridViewFetchServiceSpecialServiceRequestWithFilter.AutoGenerateColumns = false;
            dataGridViewFetchServiceSpecialServiceRequestWithFilter.Columns.Add("ServiceSpecialServiceRequestGroupRcd","Service Special Service Request Group");
            dataGridViewFetchServiceSpecialServiceRequestWithFilter.Columns.Add("ServiceSpecialServiceRequestGroupName","Service Special Service Request Group Name");
            dataGridViewFetchServiceSpecialServiceRequestWithFilter.Columns.Add("ServiceSpecialServiceRequestCode","Service Special Service Request Code");
            dataGridViewFetchServiceSpecialServiceRequestWithFilter.Columns.Add("ServiceSpecialServiceRequestName","Service Special Service Request Name");
            dataGridViewFetchServiceSpecialServiceRequestWithFilter.Columns.Add("ServiceDescription","Service Description");
            dataGridViewFetchServiceSpecialServiceRequestWithFilter.Columns.Add("Amount","Amount");
            dataGridViewFetchServiceSpecialServiceRequestWithFilter.Columns.Add("FinancialCurrencyId","Financial Currency Id");
            dataGridViewFetchServiceSpecialServiceRequestWithFilter.Columns.Add("FinancialCurrencyTypeName","Financial Currency Type Name");
            dataGridViewFetchServiceSpecialServiceRequestWithFilter.Columns.Add("InventoryControlledFlag","Inventory Controlled Flag");
            dataGridViewFetchServiceSpecialServiceRequestWithFilter.Columns.Add("RequestServiceSpecialServiceRequestRequirementRcd","Request Service Special Service Request Requirement");
            dataGridViewFetchServiceSpecialServiceRequestWithFilter.Columns.Add("RequestRequirementName","Request Requirement Name");
            dataGridViewFetchServiceSpecialServiceRequestWithFilter.Columns.Add("ReplyServiceSpecialServiceRequestRequirementRcd","Reply Service Special Service Request Requirement");
            dataGridViewFetchServiceSpecialServiceRequestWithFilter.Columns.Add("ReplyRequirementName","Reply Requirement Name");
            dataGridViewFetchServiceSpecialServiceRequestWithFilter.Columns.Add("ServiceSpecialServiceRequestOperationRuleRcd","Service Special Service Request Operation Rule");
            dataGridViewFetchServiceSpecialServiceRequestWithFilter.Columns.Add("ServiceSpecialServiceRequestOperationRuleName","Service Special Service Request Operation Rule Name");
            dataGridViewFetchServiceSpecialServiceRequestWithFilter.Columns.Add("UserId","User Id");
            dataGridViewFetchServiceSpecialServiceRequestWithFilter.Columns.Add("DefaultUserName","Default User Name");
            dataGridViewFetchServiceSpecialServiceRequestWithFilter.Columns.Add("DateTime","Date Time");
            dataGridViewFetchServiceSpecialServiceRequestWithFilter.Columns.Add("ServiceSpecialServiceRequestId","Service Special Service Request Id");
            dataGridViewFetchServiceSpecialServiceRequestWithFilter.Columns.Add("ExtensionData", "");
            dataGridViewFetchServiceSpecialServiceRequestWithFilter.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewFetchServiceSpecialServiceRequestWithFilter.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewFetchServiceSpecialServiceRequestWithFilter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewFetchServiceSpecialServiceRequestWithFilter.AutoResizeColumns();
        }
    }
}
