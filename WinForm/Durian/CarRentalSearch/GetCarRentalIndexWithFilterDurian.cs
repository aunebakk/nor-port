using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class GetCarRentalIndexWithFilterDurian : UserControl {
        
        public GetCarRentalIndexWithFilterDurian() {
           InitializeComponent();
           InitializeGridGetCarRentalIndexWithFilter();
        }
        
        public virtual string CarName {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetCarRentalIndexWithFilter.CurrentRow.Cells["CarName"].Value; else return String.Empty;;
            }
        }
        
        public virtual decimal DayPriceAmount {
            get {
                if (!DesignMode) return (System.Decimal) dataGridViewGetCarRentalIndexWithFilter.CurrentRow.Cells["DayPriceAmount"].Value; else return 0;;
            }
        }
        
        public virtual System.Guid FinancialCurrencyId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewGetCarRentalIndexWithFilter.CurrentRow.Cells["FinancialCurrencyId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual string FinancialCurrencyTypeName {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetCarRentalIndexWithFilter.CurrentRow.Cells["FinancialCurrencyTypeName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid ProductId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewGetCarRentalIndexWithFilter.CurrentRow.Cells["ProductId"].Value; else return Guid.Empty;;
            }
        }
        
        public new virtual string ProductName {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetCarRentalIndexWithFilter.CurrentRow.Cells["ProductName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid UserId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewGetCarRentalIndexWithFilter.CurrentRow.Cells["UserId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual string DefaultUserName {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetCarRentalIndexWithFilter.CurrentRow.Cells["DefaultUserName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.DateTime DateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewGetCarRentalIndexWithFilter.CurrentRow.Cells["DateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual System.Guid ServiceCarRentalId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewGetCarRentalIndexWithFilter.CurrentRow.Cells["ServiceCarRentalId"].Value; else return Guid.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewGetCarRentalIndexWithFilter.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewGetCarRentalIndexWithFilter_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshGetCarRentalIndexWithFilter() {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewGetCarRentalIndexWithFilter.CurrentRow != null)
                    position = dataGridViewGetCarRentalIndexWithFilter.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new CarRentalSearchServiceClient().GetCarRentalIndexWithFilter();
                dataGridViewGetCarRentalIndexWithFilter.AutoGenerateColumns = true;
                dataGridViewGetCarRentalIndexWithFilter.DataSource = bindingSource;
                dataGridViewGetCarRentalIndexWithFilter.AutoResizeColumns();

                // position to previous row
                if (dataGridViewGetCarRentalIndexWithFilter.Rows.Count > 0) { 
                    dataGridViewGetCarRentalIndexWithFilter.CurrentCell = 
                        dataGridViewGetCarRentalIndexWithFilter.Rows[position].Cells[1];
                    dataGridViewGetCarRentalIndexWithFilter.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridGetCarRentalIndexWithFilter() {
            dataGridViewGetCarRentalIndexWithFilter.Columns.Clear();
            dataGridViewGetCarRentalIndexWithFilter.AutoGenerateColumns = false;
            dataGridViewGetCarRentalIndexWithFilter.Columns.Add("CarName","Car Name");
            dataGridViewGetCarRentalIndexWithFilter.Columns.Add("DayPriceAmount","Day Price Amount");
            dataGridViewGetCarRentalIndexWithFilter.Columns.Add("FinancialCurrencyId","Financial Currency Id");
            dataGridViewGetCarRentalIndexWithFilter.Columns.Add("FinancialCurrencyTypeName","Financial Currency Type Name");
            dataGridViewGetCarRentalIndexWithFilter.Columns.Add("ProductId","Product Id");
            dataGridViewGetCarRentalIndexWithFilter.Columns.Add("ProductName","Product Name");
            dataGridViewGetCarRentalIndexWithFilter.Columns.Add("UserId","User Id");
            dataGridViewGetCarRentalIndexWithFilter.Columns.Add("DefaultUserName","Default User Name");
            dataGridViewGetCarRentalIndexWithFilter.Columns.Add("DateTime","Date Time");
            dataGridViewGetCarRentalIndexWithFilter.Columns.Add("ServiceCarRentalId","Service Car Rental Id");
            dataGridViewGetCarRentalIndexWithFilter.Columns.Add("ExtensionData", "");
            dataGridViewGetCarRentalIndexWithFilter.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewGetCarRentalIndexWithFilter.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewGetCarRentalIndexWithFilter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewGetCarRentalIndexWithFilter.AutoResizeColumns();
        }
    }
}
