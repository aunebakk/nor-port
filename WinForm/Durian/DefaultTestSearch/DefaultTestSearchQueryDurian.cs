using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class DefaultTestSearchQueryDurian : UserControl {
        
        public DefaultTestSearchQueryDurian() {
           InitializeComponent();
           InitializeGridDefaultTestSearchQuery();
        }
        
        public virtual string TestArea {
            get {
                if (!DesignMode) return (System.String) dataGridViewDefaultTestSearchQuery.CurrentRow.Cells["TestArea"].Value; else return String.Empty;;
            }
        }
        
        public virtual string TestSubArea {
            get {
                if (!DesignMode) return (System.String) dataGridViewDefaultTestSearchQuery.CurrentRow.Cells["TestSubArea"].Value; else return String.Empty;;
            }
        }
        
        public virtual string DefaultTestRunResultRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewDefaultTestSearchQuery.CurrentRow.Cells["DefaultTestRunResultRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual int ElapsedMilliseconds {
            get {
                if (!DesignMode) return (System.Int32) dataGridViewDefaultTestSearchQuery.CurrentRow.Cells["ElapsedMilliseconds"].Value; else return 0;;
            }
        }
        
        public virtual System.DateTime DateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewDefaultTestSearchQuery.CurrentRow.Cells["DateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual string TestAddress {
            get {
                if (!DesignMode) return (System.String) dataGridViewDefaultTestSearchQuery.CurrentRow.Cells["TestAddress"].Value; else return String.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewDefaultTestSearchQuery.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewDefaultTestSearchQuery_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshDefaultTestSearchQuery() {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewDefaultTestSearchQuery.CurrentRow != null)
                    position = dataGridViewDefaultTestSearchQuery.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new DefaultTestSearchServiceClient().DefaultTestSearchQuery();
                dataGridViewDefaultTestSearchQuery.AutoGenerateColumns = true;
                dataGridViewDefaultTestSearchQuery.DataSource = bindingSource;
                dataGridViewDefaultTestSearchQuery.AutoResizeColumns();

                // position to previous row
                if (dataGridViewDefaultTestSearchQuery.Rows.Count > 0) { 
                    dataGridViewDefaultTestSearchQuery.CurrentCell = 
                        dataGridViewDefaultTestSearchQuery.Rows[position].Cells[1];
                    dataGridViewDefaultTestSearchQuery.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridDefaultTestSearchQuery() {
            dataGridViewDefaultTestSearchQuery.Columns.Clear();
            dataGridViewDefaultTestSearchQuery.AutoGenerateColumns = false;
            dataGridViewDefaultTestSearchQuery.Columns.Add("TestArea","Test Area");
            dataGridViewDefaultTestSearchQuery.Columns.Add("TestSubArea","Test Sub Area");
            dataGridViewDefaultTestSearchQuery.Columns.Add("DefaultTestRunResultRcd","Default Test Run Result");
            dataGridViewDefaultTestSearchQuery.Columns.Add("ElapsedMilliseconds","Elapsed Milliseconds");
            dataGridViewDefaultTestSearchQuery.Columns.Add("DateTime","Date Time");
            dataGridViewDefaultTestSearchQuery.Columns.Add("TestAddress","Test Address");
            dataGridViewDefaultTestSearchQuery.Columns.Add("ExtensionData", "");
            dataGridViewDefaultTestSearchQuery.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewDefaultTestSearchQuery.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewDefaultTestSearchQuery.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewDefaultTestSearchQuery.AutoResizeColumns();
        }
    }
}
