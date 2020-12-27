using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class ServiceCarRentalListDurian : UserControl {
        
        public ServiceCarRentalListDurian() {
           InitializeComponent();
           InitializeGridServiceCarRentalList();
        }
        
        public virtual string CarName {
            get {
                if (!DesignMode) return (System.String) dataGridViewServiceCarRentalList.CurrentRow.Cells["CarName"].Value; else return String.Empty;;
            }
        }
        
        public virtual decimal DayPriceAmount {
            get {
                if (!DesignMode) return (System.Decimal) dataGridViewServiceCarRentalList.CurrentRow.Cells["DayPriceAmount"].Value; else return 0;;
            }
        }
        
        public virtual string FinancialCurrencyTypeName {
            get {
                if (!DesignMode) return (System.String) dataGridViewServiceCarRentalList.CurrentRow.Cells["FinancialCurrencyTypeName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid ServiceCarRentalId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewServiceCarRentalList.CurrentRow.Cells["ServiceCarRentalId"].Value; else return Guid.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewServiceCarRentalList.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewServiceCarRentalList_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshServiceCarRentalList() {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewServiceCarRentalList.CurrentRow != null)
                    position = dataGridViewServiceCarRentalList.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new FinancialSearchService().ServiceCarRentalList();
                dataGridViewServiceCarRentalList.AutoGenerateColumns = true;
                dataGridViewServiceCarRentalList.DataSource = bindingSource;
                dataGridViewServiceCarRentalList.AutoResizeColumns();

                // position to previous row
                if (dataGridViewServiceCarRentalList.Rows.Count > 0) { 
                    dataGridViewServiceCarRentalList.CurrentCell = 
                        dataGridViewServiceCarRentalList.Rows[position].Cells[1];
                    dataGridViewServiceCarRentalList.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridServiceCarRentalList() {
            dataGridViewServiceCarRentalList.Columns.Clear();
            dataGridViewServiceCarRentalList.AutoGenerateColumns = false;
            dataGridViewServiceCarRentalList.Columns.Add("CarName","Car Name");
            dataGridViewServiceCarRentalList.Columns.Add("DayPriceAmount","Day Price Amount");
            dataGridViewServiceCarRentalList.Columns.Add("FinancialCurrencyTypeName","Financial Currency Type Name");
            dataGridViewServiceCarRentalList.Columns.Add("ServiceCarRentalId","Service Car Rental Id");
            dataGridViewServiceCarRentalList.Columns.Add("ExtensionData", "");
            dataGridViewServiceCarRentalList.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewServiceCarRentalList.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewServiceCarRentalList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewServiceCarRentalList.AutoResizeColumns();
        }
    }
}
