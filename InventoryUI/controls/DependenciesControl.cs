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
    public partial class DependenciesControl : UserControl
    {
        public DependenciesControl()
        {
            InitializeComponent();
        }

       
        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            List<Utility.ValidationItem> validationList = new List<Utility.ValidationItem>()
                {
                   new Utility.ValidationItem(){ control = txtbxCategoryName, lblError = lblCategoryError,},
                };

            if (!Utility.ValidateControlList(validationList))
            {
                System.Media.SystemSounds.Beep.Play();
                return;
            }
            //@CategoryID int,@CategoryName nvarchar(50)
            List<Utility.ProcedureParameter> parameters = new List<Utility.ProcedureParameter>()
                {
                    new Utility.ProcedureParameter(){ parameterName = "CategoryID", DType = SqlDbType.Int, SourceObject = DBNull.Value},
                    new Utility.ProcedureParameter(){ parameterName = "CategoryName", DType = SqlDbType.NVarChar, SourceObject = txtbxCategoryName},
                };

            if (Convert.ToBoolean(Utility.InsertProcedure("InsertProductCategory", parameters)))
            {
                MessageBox.Show(null, "Category Added", "Dependencies", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Utility.clearPanel(pnlCategory);
            }
        }

        private void btnBrandAdd_Click(object sender, EventArgs e)
        {
            List<Utility.ValidationItem> validationList = new List<Utility.ValidationItem>()
                {
                   new Utility.ValidationItem(){ control = txtbxBrandName, lblError =lblBrandError,},
                };

            if (!Utility.ValidateControlList(validationList))
            {
                System.Media.SystemSounds.Beep.Play();
                return;
            }

            //@BrandID int,@BrandName nvarchar(50)
            List<Utility.ProcedureParameter> parameters = new List<Utility.ProcedureParameter>()
                {
                    new Utility.ProcedureParameter(){ parameterName = "BrandID", DType = SqlDbType.Int, SourceObject = DBNull.Value},
                    new Utility.ProcedureParameter(){ parameterName = "BrandName", DType = SqlDbType.NVarChar, SourceObject = txtbxBrandName},
                };

            if (Convert.ToBoolean(Utility.InsertProcedure("InsertProductBrand", parameters)))
            {
                MessageBox.Show(null, "Brand Added", "Dependencies", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Utility.clearPanel(pnlBrand);
            }
        }

        private void btnColorAdd_Click(object sender, EventArgs e)
        {
            List<Utility.ValidationItem> validationList = new List<Utility.ValidationItem>()
                {
                   new Utility.ValidationItem(){ control = txtbxColorName, lblError = lblColorError,},
                };

            if (!Utility.ValidateControlList(validationList))
            {
                System.Media.SystemSounds.Beep.Play();
                return;
            }
            //@colorName nvarchar(50)
            List<Utility.ProcedureParameter> parameters = new List<Utility.ProcedureParameter>()
                {
                    new Utility.ProcedureParameter(){ parameterName = "colorName", DType = SqlDbType.NVarChar, SourceObject = txtbxColorName},
                };

            if (Convert.ToBoolean(Utility.InsertProcedure("InsertColor", parameters)))
            {
                MessageBox.Show(null, "Color Added", "Dependencies", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Utility.clearPanel(pnlColor);
            }
        }

        private void pnlTType_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtbxColorName_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlInfo2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtbxCategoryName_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlColor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtbxTypeAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void txtbxBrandName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnlCategory_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void pnlBrand_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
