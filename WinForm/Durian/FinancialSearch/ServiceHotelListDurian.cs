using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class ServiceHotelListDurian : UserControl {
        
        public ServiceHotelListDurian() {
           InitializeComponent();
           InitializeGridServiceHotelList();
        }
        
        public virtual string HotelName {
            get {
                if (!DesignMode) return (System.String) dataGridViewServiceHotelList.CurrentRow.Cells["HotelName"].Value; else return String.Empty;;
            }
        }
        
        public virtual decimal DayPriceAmount {
            get {
                if (!DesignMode) return (System.Decimal) dataGridViewServiceHotelList.CurrentRow.Cells["DayPriceAmount"].Value; else return 0;;
            }
        }
        
        public virtual string FinancialCurrencyTypeName {
            get {
                if (!DesignMode) return (System.String) dataGridViewServiceHotelList.CurrentRow.Cells["FinancialCurrencyTypeName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid ServiceHotelId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewServiceHotelList.CurrentRow.Cells["ServiceHotelId"].Value; else return Guid.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewServiceHotelList.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewServiceHotelList_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshServiceHotelList() {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewServiceHotelList.CurrentRow != null)
                    position = dataGridViewServiceHotelList.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new FinancialSearchServiceClient().ServiceHotelList();
                dataGridViewServiceHotelList.AutoGenerateColumns = true;
                dataGridViewServiceHotelList.DataSource = bindingSource;
                dataGridViewServiceHotelList.AutoResizeColumns();

                // position to previous row
                if (dataGridViewServiceHotelList.Rows.Count > 0) { 
                    dataGridViewServiceHotelList.CurrentCell = 
                        dataGridViewServiceHotelList.Rows[position].Cells[1];
                    dataGridViewServiceHotelList.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridServiceHotelList() {
            dataGridViewServiceHotelList.Columns.Clear();
            dataGridViewServiceHotelList.AutoGenerateColumns = false;
            dataGridViewServiceHotelList.Columns.Add("HotelName","Hotel Name");
            dataGridViewServiceHotelList.Columns.Add("DayPriceAmount","Day Price Amount");
            dataGridViewServiceHotelList.Columns.Add("FinancialCurrencyTypeName","Financial Currency Type Name");
            dataGridViewServiceHotelList.Columns.Add("ServiceHotelId","Service Hotel Id");
            dataGridViewServiceHotelList.Columns.Add("ExtensionData", "");
            dataGridViewServiceHotelList.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewServiceHotelList.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewServiceHotelList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewServiceHotelList.AutoResizeColumns();
        }
    }
}
