using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryUI.controls
{
    public partial class StockControl : UserControl
    {
        public StockControl()
        {

            InitializeComponent();
            gridStock.AutoGenerateColumns = false;
            foreach (DataGridViewColumn col in gridStock.Columns)
            {
                col.DataPropertyName = col.Name;
                dtStock.Columns.Add(col.Name);
            }
        }
        DataTable dtStock = new DataTable();

        protected override void OnLoad(EventArgs e)
        {
            // do stuff before Load-event is raised
            base.OnLoad(e);

            gridStock.DataSource = (DataTable)Utility.FillDataTable(dtStock, "FillGridStockDetails");

            Utility.FillCombo(cmbBrand, "GetAllProductBrands");
            cmbBrand.Items.Insert(0, new Utility.ComboboxItem { Text = "", Value = -1 }); //add an empty item
            cmbBrand.SelectedIndex = 0;

            Utility.FillCombo(cmbCategoty, "GetAllProductCategories");

            cmbCategoty.Items.Insert(0, new Utility.ComboboxItem { Text = "", Value = -1 }); //add an empty item
            cmbCategoty.SelectedIndex = 0;

        }

        private void SearchGridStockWithData()
        {
            //@Barcode nvarchar(50),@ProductName nvarchar(50) ,@CategoryID int ,@BrandID int
            List<Utility.ProcedureParameter> parameters = new List<Utility.ProcedureParameter>()
                {
                   new Utility.ProcedureParameter(){ parameterName = "Barcode", DType = SqlDbType.NVarChar, SourceObject = txtBarcode},
                   new Utility.ProcedureParameter(){ parameterName = "ProductName", DType = SqlDbType.NVarChar, SourceObject = txtProductName},
                   new Utility.ProcedureParameter(){ parameterName = "CategoryID", DType = SqlDbType.Int, SourceObject =cmbCategoty},
                   new Utility.ProcedureParameter(){ parameterName = "BrandID", DType = SqlDbType.Int, SourceObject = cmbBrand},
                };

            gridStock.DataSource = (DataTable)Utility.FillDataTable(dtStock, "SearchStockDetailsByData", parameters);
        }

        private void cmbBrand_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SearchGridStockWithData();
        }

        private void gridStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnlInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
