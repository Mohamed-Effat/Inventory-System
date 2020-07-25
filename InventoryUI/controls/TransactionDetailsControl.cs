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
    public partial class TransactionDetailsControl : UserControl
    {
        public class TransactionDetailsData
        {
            public DataGridViewTextBoxCell productVersionID { get; set; }
            public DataGridViewTextBoxCell quantity { get; set; }
            public DataGridViewTextBoxCell price { get; set; }
            public DataGridViewTextBoxCell discount { get; set; }
            public DataGridViewTextBoxCell shippingCost { get; set; }
        }

        public TransactionDetailsControl()
        {
            InitializeComponent();
            gridReceipt.EditingControlShowing += gridReceipt_EditingControlShowing;

            gridStock.AutoGenerateColumns = false;
            foreach (DataGridViewColumn col in gridStock.Columns)
            {
                col.DataPropertyName = col.Name;
                dtProducts.Columns.Add(col.Name);
            }
        }
        public DataTable dtProducts = new DataTable();
        protected override void OnLoad(EventArgs e)
        {
            // do stuff before Load-event is raised
            base.OnLoad(e);

            gridStock.DataSource = (DataTable)Utility.FillDataTable(dtProducts, "FillGridStockDetails");

            if (Utility.FillCombo(cmbBrand, "GetAllProductBrands"))
            {
                cmbBrand.Items.Insert(0, new Utility.ComboboxItem { Text = "", Value = -1 }); //add an empty item
                cmbBrand.SelectedIndex = 0;
            }
            if (Utility.FillCombo(cmbCategoty, "GetAllProductCategories"))
            {
                cmbCategoty.Items.Insert(0, new Utility.ComboboxItem { Text = "", Value = -1 }); //add an empty item
                cmbCategoty.SelectedIndex = 0;
            }
            if (Utility.FillCombo(cmbbxType, "GetAllTransaction"))
                cmbbxType.SelectedIndex = 0;
        }

        #region validation
        bool isSubbed = false;
        void gridReceipt_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (!isSubbed)
            {
                TextBox tb = e.Control as TextBox;
                tb.ShortcutsEnabled = false;        //disable copy/paste
                e.Control.KeyPress += new KeyPressEventHandler(gridReceiptCells_KeyPress);
                e.Control.TextChanged += new EventHandler(gridReceiptCells_TextChanged);
                isSubbed = true;
            }
        }
        void gridReceiptCells_TextChanged(object sender, EventArgs e)
        {
            var cell = ((DataGridViewTextBoxEditingControl)sender);
            if (String.IsNullOrWhiteSpace(cell.Text))       //if empty
            {
                cell.TextChanged -= new EventHandler(gridReceiptCells_TextChanged);            //unsubscribe to avoid recall the event on Text Change
                if (cell.EditingControlDataGridView.CurrentCell.OwningColumn == GridReceiptPrice ||     // if cell is price cell or shipping cost cell
                        cell.EditingControlDataGridView.CurrentCell.OwningColumn == GridReceiptShippingCost)
                    cell.Text = "0.0";
                else if (cell.EditingControlDataGridView.CurrentCell.OwningColumn == GridReceiptQuantity)
                    cell.Text = "1";
                else
                    cell.Text = "0";

                cell.TextChanged += new EventHandler(gridReceiptCells_TextChanged);            //subscribe back
                System.Media.SystemSounds.Beep.Play();
            }
            else    //if not empty
            {
                if (cell.EditingControlDataGridView.CurrentCell.OwningColumn == GridReceiptDiscount)    //if cell is discount
                {
                    if (Convert.ToDecimal(cell.Text) > 100)                                             //if cell value exceed 100
                    {
                        cell.TextChanged -= new EventHandler(gridReceiptCells_TextChanged);    //unsubscribe to avoid recall the event on Text Change
                        cell.Text = "100";
                        cell.TextChanged += new EventHandler(gridReceiptCells_TextChanged);    //subscribe back
                        System.Media.SystemSounds.Beep.Play();
                    }
                }
                else if (cell.EditingControlDataGridView.CurrentCell.OwningColumn == GridReceiptQuantity)   //if cell is Quantity
                {
                    if (Convert.ToInt32(cell.Text) < 1)
                    {
                        cell.TextChanged -= new EventHandler(gridReceiptCells_TextChanged);
                        cell.Text = "1";
                        cell.TextChanged += new EventHandler(gridReceiptCells_TextChanged);
                        System.Media.SystemSounds.Beep.Play();
                    }
                    else if (transactionTypeID == 2 && //--BAD IMPLEMENTATION, sell Transaction Type is statically stated as 2
                        Convert.ToInt32(cell.Text) > Convert.ToInt32(cell.EditingControlDataGridView["gridReceiptAvailableQuantity", cell.EditingControlRowIndex].Value))
                    {
                        cell.TextChanged -= new EventHandler(gridReceiptCells_TextChanged);
                        cell.Text = cell.EditingControlDataGridView["gridReceiptAvailableQuantity", cell.EditingControlRowIndex].Value.ToString();
                        cell.TextChanged += new EventHandler(gridReceiptCells_TextChanged);
                        System.Media.SystemSounds.Beep.Play();
                    }
                }
            }
        }

        private void gridReceiptCells_KeyPress(object sender, KeyPressEventArgs e)
        {
            var cell = ((DataGridViewTextBoxEditingControl)sender);
            if (cell.EditingControlDataGridView.CurrentCell.OwningColumn == GridReceiptPrice || // if cell is price cell or shipping cost cell
                    cell.EditingControlDataGridView.CurrentCell.OwningColumn == GridReceiptShippingCost)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !(e.KeyChar == '.'))
                {
                    System.Media.SystemSounds.Beep.Play();
                    e.Handled = true;
                }
                // only allow one decimal point
                else if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    System.Media.SystemSounds.Beep.Play();
                    e.Handled = true;
                }
                else if (string.IsNullOrWhiteSpace(((TextBox)sender).Text) && e.KeyChar == '.')
                {
                    cell.TextChanged -= new EventHandler(gridReceiptCells_TextChanged);
                    ((TextBox)sender).Text += "0.0";
                    cell.TextChanged += new EventHandler(gridReceiptCells_TextChanged);
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) //allow only 0-9 and control characters
                {
                    System.Media.SystemSounds.Beep.Play();
                    e.Handled = true;
                }
            }
        }
#endregion
       
        private void gridReceipt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn)   //if the Clicked Cell is of type Button and an actual row is Clicked
            {
                gridReceipt.Rows.RemoveAt(e.RowIndex);                                              //remove the Row at the event sender's location
                return;
            }
        }


        private void SearchGridStockWithData()
        {
            List<Utility.ProcedureParameter> parameters = new List<Utility.ProcedureParameter>()
                {
                   new Utility.ProcedureParameter(){ parameterName = "Barcode", DType = SqlDbType.NVarChar, SourceObject = txtBarcode},
                   new Utility.ProcedureParameter(){ parameterName = "ProductName", DType = SqlDbType.NVarChar, SourceObject = txtProductName},
                   new Utility.ProcedureParameter(){ parameterName = "CategoryID", DType = SqlDbType.Int, SourceObject =cmbCategoty},
                   new Utility.ProcedureParameter(){ parameterName = "BrandID", DType = SqlDbType.Int, SourceObject = cmbBrand},
                };

            gridStock.DataSource = (DataTable)Utility.FillDataTable(dtProducts, "SearchStockDetailsByData", parameters);
        }


        private void cmbBrand_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SearchGridStockWithData();
        }

        private void gridStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridStock.SelectedRows.Count == 0 || e.RowIndex == -1)
                return;

            foreach (DataGridViewRow row in gridReceipt.Rows)   //prevent entering two products with the same ID
            {
                if (gridStock.Rows[e.RowIndex].Cells["productID"].Value == row.Cells["GridReceiptID"].Value)
                {
                    if (transactionTypeID == 2 && Convert.ToInt32(gridStock.Rows[e.RowIndex].Cells["ProductQuantity"].Value) < Convert.ToInt32(row.Cells["GridReceiptQuantity"].Value) + 1)
                        System.Media.SystemSounds.Beep.Play();
                    else
                        row.Cells["GridReceiptQuantity"].Value = (Convert.ToInt32(row.Cells["GridReceiptQuantity"].Value) + 1).ToString();
                    return;
                }
            }
            TransferProduct();
        }
        void TransferProduct()
        {
            if (transactionTypeID == 2 && Convert.ToInt32(gridStock.SelectedRows[0].Cells["ProductQuantity"].Value) < 1)  //--BAD IMPLEMENTATION, sell Transaction Type is statically stated as 2
            {
                MessageBox.Show(null, "Cannot Sell an Item with 0 Quantity", "Transaction Details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int rowIndex = gridReceipt.Rows.Add();
            gridReceipt.Rows[rowIndex].Cells["GridReceiptID"].Value = gridStock.SelectedRows[0].Cells["productID"].Value;
            gridReceipt.Rows[rowIndex].Cells["GridReceiptName"].Value = gridStock.SelectedRows[0].Cells["productName"].Value;
            gridReceipt.Rows[rowIndex].Cells["GridReceiptQuantity"].Value = "1";
            gridReceipt.Rows[rowIndex].Cells["gridReceiptAvailableQuantity"].Value = gridStock.SelectedRows[0].Cells["ProductQuantity"].Value;
            gridReceipt.Rows[rowIndex].Cells["GridReceiptDiscount"].Value = "0";
            gridReceipt.Rows[rowIndex].Cells["GridReceiptShippingCost"].Value = "0.0";
            if (transactionTypeID == 1)       //--BAD IMPLEMENTATION, buy Transaction Type is statically stated as 1
                gridReceipt.Rows[rowIndex].Cells["GridReceiptPrice"].Value = "0.0";
            else if (transactionTypeID == 2)   //--BAD IMPLEMENTATION, sell Transaction Type is statically stated as 2
                gridReceipt.Rows[rowIndex].Cells["GridReceiptPrice"].Value = gridStock.SelectedRows[0].Cells["sellingPrice"].Value;

        }

        //this is the way to create data object
        public List<TransactionDetailsData> dataList = new List<TransactionDetailsData>();
        public double TotalPrice = 0;
        public double TotalDiscount = 0;
        private void btnNext_Click(object sender, EventArgs e)
        {


            this.Visible = false;
            dataList.Clear();
            TotalDiscount = 0;
            TotalPrice = 0;
            foreach (DataGridViewRow row in gridReceipt.Rows)
            {
                TotalDiscount = Convert.ToDouble(row.Cells["GridReceiptQuantity"].Value) *
                 Convert.ToDouble(row.Cells["GridReceiptPrice"].Value) *
                 Utility.convertPercent(Convert.ToDouble(row.Cells["GridReceiptDiscount"].Value));

                TotalPrice += (Convert.ToDouble(row.Cells["GridReceiptQuantity"].Value) *
                    Convert.ToDouble(row.Cells["GridReceiptPrice"].Value) - TotalDiscount)
                    + Convert.ToDouble(row.Cells["GridReceiptShippingCost"].Value);
                ;
                dataList.Add(new TransactionDetailsData()
                {
                    productVersionID = (DataGridViewTextBoxCell)row.Cells["GridReceiptID"],
                    quantity = (DataGridViewTextBoxCell)row.Cells["GridReceiptQuantity"],
                    price = (DataGridViewTextBoxCell)row.Cells["GridReceiptPrice"],
                    discount = (DataGridViewTextBoxCell)row.Cells["GridReceiptDiscount"],
                    shippingCost = (DataGridViewTextBoxCell)row.Cells["GridReceiptShippingCost"],

                });

            }

            this.Parent.Controls["pnlTInfo"].Visible = true;

        }
        public int transactionTypeID = -1;
        private void cmbbxType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (((Utility.ComboboxItem)cmbbxType.SelectedItem).Value == 1)            //--BAD IMPLEMENTATION, buy Transaction Type is statically stated as 1
            {
                GridReceiptPrice.ReadOnly = false;
                gridReceipt.Rows.Clear();
            }
            else if (((Utility.ComboboxItem)cmbbxType.SelectedItem).Value == 2)   //--BAD IMPLEMENTATION, sell Transaction Type is statically stated as 2
            {
                GridReceiptPrice.ReadOnly = true;
                gridReceipt.Rows.Clear();
            }
        }
         private void cmbbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbbxType.Items.Count > 0)
                transactionTypeID = ((Utility.ComboboxItem)cmbbxType.SelectedItem).Value;
        }
        private void gridReceipt_CellPainting(object sender, DataGridViewCellPaintingEventArgs e) //Places an Image on the datagridview Buttons
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == gridReceipt.Columns["GridReceiptRemove"].Index) //button Index Location
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.datagridX.Width;
                var h = Properties.Resources.datagridX.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.datagridX, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }
        private void gridStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void pnlInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TransactionDetailsControl_VisibleChanged(object sender, EventArgs e)
        {


        }

        private void gridStock_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

       


    }
}
