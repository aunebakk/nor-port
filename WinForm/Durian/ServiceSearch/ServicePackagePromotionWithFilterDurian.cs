using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class ServicePackagePromotionWithFilterDurian : UserControl {
        
        public ServicePackagePromotionWithFilterDurian() {
           InitializeComponent();
           InitializeGridServicePackagePromotionWithFilter();
        }
        
        public virtual string ServicePackageName {
            get {
                if (!DesignMode) return (System.String) dataGridViewServicePackagePromotionWithFilter.CurrentRow.Cells["ServicePackageName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid ClientId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewServicePackagePromotionWithFilter.CurrentRow.Cells["ClientId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual string ClientName {
            get {
                if (!DesignMode) return (System.String) dataGridViewServicePackagePromotionWithFilter.CurrentRow.Cells["ClientName"].Value; else return String.Empty;;
            }
        }
        
        public virtual decimal PromotionPriceAmount {
            get {
                if (!DesignMode) return (System.Decimal) dataGridViewServicePackagePromotionWithFilter.CurrentRow.Cells["PromotionPriceAmount"].Value; else return 0;;
            }
        }
        
        public virtual System.Guid FinancialCurrencyId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewServicePackagePromotionWithFilter.CurrentRow.Cells["FinancialCurrencyId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual string FinancialCurrencyTypeName {
            get {
                if (!DesignMode) return (System.String) dataGridViewServicePackagePromotionWithFilter.CurrentRow.Cells["FinancialCurrencyTypeName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid UserId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewServicePackagePromotionWithFilter.CurrentRow.Cells["UserId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual string DefaultUserName {
            get {
                if (!DesignMode) return (System.String) dataGridViewServicePackagePromotionWithFilter.CurrentRow.Cells["DefaultUserName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.DateTime DateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewServicePackagePromotionWithFilter.CurrentRow.Cells["DateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual System.Guid ServicePackagePromotionId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewServicePackagePromotionWithFilter.CurrentRow.Cells["ServicePackagePromotionId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual System.Guid ServicePackageId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewServicePackagePromotionWithFilter.CurrentRow.Cells["ServicePackageId"].Value; else return Guid.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewServicePackagePromotionWithFilter.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewServicePackagePromotionWithFilter_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshServicePackagePromotionWithFilter(System.Guid clientId) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewServicePackagePromotionWithFilter.CurrentRow != null)
                    position = dataGridViewServicePackagePromotionWithFilter.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new ServiceSearchServiceClient().ServicePackagePromotionWithFilter(clientId);
                dataGridViewServicePackagePromotionWithFilter.AutoGenerateColumns = true;
                dataGridViewServicePackagePromotionWithFilter.DataSource = bindingSource;
                dataGridViewServicePackagePromotionWithFilter.AutoResizeColumns();

                // position to previous row
                if (dataGridViewServicePackagePromotionWithFilter.Rows.Count > 0) { 
                    dataGridViewServicePackagePromotionWithFilter.CurrentCell = 
                        dataGridViewServicePackagePromotionWithFilter.Rows[position].Cells[1];
                    dataGridViewServicePackagePromotionWithFilter.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridServicePackagePromotionWithFilter() {
            dataGridViewServicePackagePromotionWithFilter.Columns.Clear();
            dataGridViewServicePackagePromotionWithFilter.AutoGenerateColumns = false;
            dataGridViewServicePackagePromotionWithFilter.Columns.Add("ServicePackageName","Service Package Name");
            dataGridViewServicePackagePromotionWithFilter.Columns.Add("ClientId","Client Id");
            dataGridViewServicePackagePromotionWithFilter.Columns.Add("ClientName","Client Name");
            dataGridViewServicePackagePromotionWithFilter.Columns.Add("PromotionPriceAmount","Promotion Price Amount");
            dataGridViewServicePackagePromotionWithFilter.Columns.Add("FinancialCurrencyId","Financial Currency Id");
            dataGridViewServicePackagePromotionWithFilter.Columns.Add("FinancialCurrencyTypeName","Financial Currency Type Name");
            dataGridViewServicePackagePromotionWithFilter.Columns.Add("UserId","User Id");
            dataGridViewServicePackagePromotionWithFilter.Columns.Add("DefaultUserName","Default User Name");
            dataGridViewServicePackagePromotionWithFilter.Columns.Add("DateTime","Date Time");
            dataGridViewServicePackagePromotionWithFilter.Columns.Add("ServicePackagePromotionId","Service Package Promotion Id");
            dataGridViewServicePackagePromotionWithFilter.Columns.Add("ServicePackageId","Service Package Id");
            dataGridViewServicePackagePromotionWithFilter.Columns.Add("ExtensionData", "");
            dataGridViewServicePackagePromotionWithFilter.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewServicePackagePromotionWithFilter.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewServicePackagePromotionWithFilter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewServicePackagePromotionWithFilter.AutoResizeColumns();
        }
    }
}
