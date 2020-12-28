using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class GetHotelIndexWithFilterDurian : UserControl {
        
        public GetHotelIndexWithFilterDurian() {
           InitializeComponent();
           InitializeGridGetHotelIndexWithFilter();
        }
        
        public virtual string HotelName {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetHotelIndexWithFilter.CurrentRow.Cells["HotelName"].Value; else return String.Empty;;
            }
        }
        
        public virtual decimal DayPriceAmount {
            get {
                if (!DesignMode) return (System.Decimal) dataGridViewGetHotelIndexWithFilter.CurrentRow.Cells["DayPriceAmount"].Value; else return 0;;
            }
        }
        
        public virtual System.Guid FinancialCurrencyId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewGetHotelIndexWithFilter.CurrentRow.Cells["FinancialCurrencyId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual string FinancialCurrencyTypeName {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetHotelIndexWithFilter.CurrentRow.Cells["FinancialCurrencyTypeName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid ProductId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewGetHotelIndexWithFilter.CurrentRow.Cells["ProductId"].Value; else return Guid.Empty;;
            }
        }
        
        public new virtual string ProductName {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetHotelIndexWithFilter.CurrentRow.Cells["ProductName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid UserId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewGetHotelIndexWithFilter.CurrentRow.Cells["UserId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual string DefaultUserName {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetHotelIndexWithFilter.CurrentRow.Cells["DefaultUserName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.DateTime DateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewGetHotelIndexWithFilter.CurrentRow.Cells["DateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual System.Guid ServiceHotelId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewGetHotelIndexWithFilter.CurrentRow.Cells["ServiceHotelId"].Value; else return Guid.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewGetHotelIndexWithFilter.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewGetHotelIndexWithFilter_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshGetHotelIndexWithFilter() {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewGetHotelIndexWithFilter.CurrentRow != null)
                    position = dataGridViewGetHotelIndexWithFilter.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new HotelSearchService().GetHotelIndexWithFilter();
                dataGridViewGetHotelIndexWithFilter.AutoGenerateColumns = true;
                dataGridViewGetHotelIndexWithFilter.DataSource = bindingSource;
                dataGridViewGetHotelIndexWithFilter.AutoResizeColumns();

                // position to previous row
                if (dataGridViewGetHotelIndexWithFilter.Rows.Count > 0) { 
                    dataGridViewGetHotelIndexWithFilter.CurrentCell = 
                        dataGridViewGetHotelIndexWithFilter.Rows[position].Cells[1];
                    dataGridViewGetHotelIndexWithFilter.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridGetHotelIndexWithFilter() {
            dataGridViewGetHotelIndexWithFilter.Columns.Clear();
            dataGridViewGetHotelIndexWithFilter.AutoGenerateColumns = false;
            dataGridViewGetHotelIndexWithFilter.Columns.Add("HotelName","Hotel Name");
            dataGridViewGetHotelIndexWithFilter.Columns.Add("DayPriceAmount","Day Price Amount");
            dataGridViewGetHotelIndexWithFilter.Columns.Add("FinancialCurrencyId","Financial Currency Id");
            dataGridViewGetHotelIndexWithFilter.Columns.Add("FinancialCurrencyTypeName","Financial Currency Type Name");
            dataGridViewGetHotelIndexWithFilter.Columns.Add("ProductId","Product Id");
            dataGridViewGetHotelIndexWithFilter.Columns.Add("ProductName","Product Name");
            dataGridViewGetHotelIndexWithFilter.Columns.Add("UserId","User Id");
            dataGridViewGetHotelIndexWithFilter.Columns.Add("DefaultUserName","Default User Name");
            dataGridViewGetHotelIndexWithFilter.Columns.Add("DateTime","Date Time");
            dataGridViewGetHotelIndexWithFilter.Columns.Add("ServiceHotelId","Service Hotel Id");
            dataGridViewGetHotelIndexWithFilter.Columns.Add("ExtensionData", "");
            dataGridViewGetHotelIndexWithFilter.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewGetHotelIndexWithFilter.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewGetHotelIndexWithFilter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewGetHotelIndexWithFilter.AutoResizeColumns();
        }
    }
}
