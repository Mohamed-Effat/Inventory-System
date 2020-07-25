using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace InventoryUI.controls
{
    public partial class ProdcutsAddControl : UserControl
    {
        public ProdcutsAddControl()
        {
            InitializeComponent();

            gridProducts.AutoGenerateColumns = false;
            foreach (DataGridViewColumn col in gridProducts.Columns)
            {
                col.DataPropertyName = col.Name;
                dtProducts.Columns.Add(col.Name);
            }
            dtSelectedProduct.Columns.Add("ProductVersionID", typeof(int));
            dtSelectedProduct.Columns.Add("ProductName", typeof(string));
            dtSelectedProduct.Columns.Add("Barcode", typeof(string));
            dtSelectedProduct.Columns.Add("SellingPrice", typeof(string));
            dtSelectedProduct.Columns.Add("ProductImage", typeof(byte[]));
            dtSelectedProduct.Columns.Add("Size", typeof(string));
            dtSelectedProduct.Columns.Add("Capacity", typeof(string));
            dtSelectedProduct.Columns.Add("ColorID", typeof(int));
            dtSelectedProduct.Columns.Add("CategoryID", typeof(int));
            dtSelectedProduct.Columns.Add("BrandID", typeof(int));
        }
        DataTable dtProducts = new DataTable();
        DataTable dtSelectedProduct = new DataTable();
        protected override void OnLoad(EventArgs e)
        {
            // do stuff before Load-event is raised
            base.OnLoad(e);
            // do stuff after Load-event was raised
            if (Utility.FillCombo(cmbbxCategory, "GetAllProductCategories"))
                cmbbxCategory.SelectedIndex = 0;
            if (Utility.FillCombo(cmbbxBrand, "GetAllProductBrands"))
                cmbbxBrand.SelectedIndex = 0;
            if (Utility.FillCombo(cmbbxColor, "GetAllcolors"))
                cmbbxColor.SelectedIndex = 0;
            //force select the first item (assume that no product can be created without a category/brand)
            openFileDialog1.Multiselect = false;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.bmp; *.png)|*.jpg; *.jpeg; *.bmp; *.png";

            gridProducts.DataSource = Utility.FillDataTable(dtProducts, "FillGridProducts");
        }
        int currentProductID = -1;
        private void gridProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (radioAdd.Checked || gridProducts.SelectedRows.Count == 0)
                return;
            GetProductByID();
        }
        void GetProductByID()
        {
            List<Utility.ProcedureParameter> parameters = new List<Utility.ProcedureParameter>()
                {
                    new Utility.ProcedureParameter(){ parameterName = "ProductVersionID", DType = SqlDbType.Int, SourceObject =  gridProducts.SelectedRows[0].Cells["productID"]},
                };

            dtSelectedProduct = Utility.FillDataTable(dtSelectedProduct, "GetProductByID", parameters);

            //ProductVersionID,ProductName,Barcode,SellingPrice,ProductImage
            //,Size,Capacity,ColorID,CategoryID,BrandID
            byte[] MyData = new byte[0];
            foreach (DataRow row in dtSelectedProduct.Rows)
            {
                currentProductID = row.Field<int>("ProductVersionID");
                txtbxProductName.Text = row.Field<string>("ProductName");
                txtbxBarcode.Text = row.Field<string>("Barcode");
                txtbxPrice.Text = row.Field<string>("SellingPrice");
                txtbxCapacity.Text = row.Field<string>("Capacity");
                txtbxSize.Text = row.Field<string>("Size");
                Utility.SelectItem(cmbbxCategory, row.Field<int>("CategoryID"));
                Utility.SelectItem(cmbbxBrand, row.Field<int>("BrandID"));
                Utility.SelectItem(cmbbxColor, row.Field<int>("ColorID"));
                MyData = row.Field<byte[]>("ProductImage");
            }
            //MyData = (byte[])dtSelectedProduct.Rows[0]["ProductImage"];
            if (MyData == null)
            {
                picbxProduct.Image = Properties.Resources.shopping_cart_6;
            }
            else
            {
                MemoryStream stream = new MemoryStream(MyData);
                stream.Position = 0;
                picbxProduct.Image = Image.FromStream(stream);
            }
        }
        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            List<Utility.ValidationItem> validationList = new List<Utility.ValidationItem>()
                {
                   new Utility.ValidationItem(){ control = txtbxProductName, lblError =lblNameError,},
                   new Utility.ValidationItem(){ control = txtbxBarcode, lblError =lblBarcodeError,},
                   new Utility.ValidationItem(){ control = txtbxPrice, lblError =lblPriceError,},
                   new Utility.ValidationItem(){ control = cmbbxCategory, lblError =lblCategoryError,},
                   new Utility.ValidationItem(){ control = cmbbxBrand, lblError =lblBrandError,},
                   new Utility.ValidationItem(){ control = cmbbxColor, lblError =lblColorError,},
                };


            if (!Utility.ValidateControlList(validationList))
            {
                System.Media.SystemSounds.Beep.Play();
                return;
            }
            //@ProductVersionID int,@ProductName nvarchar(50),@Barcode varchar(50),
            //@Price money,@ProductImage varbinary(MAX),
            //@Size nvarchar(50),@Capacity nvarchar(50), @ColorID int,@CategoryID int, @BrandID int


            List<Utility.ProcedureParameter> parameters = new List<Utility.ProcedureParameter>()
                {
                    new Utility.ProcedureParameter(){ parameterName = "ProductName", DType = SqlDbType.NVarChar, SourceObject = txtbxProductName},
                    new Utility.ProcedureParameter(){ parameterName = "Barcode", DType = SqlDbType.VarChar, SourceObject = txtbxBarcode},
                    new Utility.ProcedureParameter(){ parameterName = "SellingPrice", DType = SqlDbType.Money, SourceObject = txtbxPrice},
                    new Utility.ProcedureParameter(){ parameterName = "Size", DType = SqlDbType.NVarChar, SourceObject = txtbxSize},
                    new Utility.ProcedureParameter(){ parameterName = "Capacity", DType = SqlDbType.NVarChar, SourceObject = txtbxCapacity},
                    new Utility.ProcedureParameter(){ parameterName = "ColorID", DType = SqlDbType.Int, SourceObject = cmbbxColor},
                    new Utility.ProcedureParameter(){ parameterName = "CategoryID", DType = SqlDbType.Int, SourceObject = cmbbxCategory},
                    new Utility.ProcedureParameter(){ parameterName = "BrandID", DType = SqlDbType.Int, SourceObject = cmbbxBrand},
                };
            if (currentProductID != -1)
                parameters.Add(new Utility.ProcedureParameter() { parameterName = "ProductVersionID", DType = SqlDbType.Int, SourceObject = currentProductID });
            else
                parameters.Add(new Utility.ProcedureParameter() { parameterName = "ProductVersionID", DType = SqlDbType.Int, SourceObject = DBNull.Value });
            if (string.IsNullOrWhiteSpace(defaultImagePath))
            {
                parameters.Add(new Utility.ProcedureParameter() { parameterName = "productImage", DType = SqlDbType.VarBinary, SourceObject = DBNull.Value });
            }
            else
            {
                FileInfo file = new FileInfo(defaultImagePath.Trim());
                byte[] content = new byte[file.Length];
                FileStream imagefile = file.OpenRead();
                imagefile.Read(content, 0, content.Length);
                parameters.Add(new Utility.ProcedureParameter() { parameterName = "productImage", DType = SqlDbType.VarBinary, SourceObject = content });
            }
               
            if (Convert.ToBoolean((Utility.InsertProcedure("InsertProductVersion", parameters))))
            {
                MessageBox.Show(null, "Product Added", "Products", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Utility.clearPanel(pnlProductInfo);
                defaultImagePath = "";
                gridProducts.DataSource = Utility.FillDataTable(dtProducts, "FillGridProducts");
            }
        }

        string defaultImagePath = "";
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                defaultImagePath = openFileDialog1.FileName;
                picbxProduct.ImageLocation = defaultImagePath;
            }
        }

        private void txtbxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !(e.KeyChar == '.'))
            {
                System.Media.SystemSounds.Beep.Play();
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                System.Media.SystemSounds.Beep.Play();
                e.Handled = true;
            }
            if (string.IsNullOrWhiteSpace(((TextBox)sender).Text) && e.KeyChar == '.')
            {
                ((TextBox)sender).Text += "0.0";
                e.Handled = true;
            }
        }

        private void radioAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAdd.Checked)    //Add Mode
            {
                Utility.clearPanel(pnlProductInfo);
                currentProductID = -1;
            }
            else                     //Edit Mode
            {
                if (gridProducts.SelectedRows.Count != 0)
                {
                    GetProductByID();
                }
            }
        }

        private void gridProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}