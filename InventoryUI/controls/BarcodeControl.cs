using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace InventoryUI.controls
{
    public partial class BarcodeControl : UserControl
    {
        public BarcodeControl()
        {
            InitializeComponent();
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            BarcodeWriter writer = new BarcodeWriter(){Format = BarcodeFormat.CODE_128};
            picbxBarcode.Image = writer.Write(txtbxEncode.Text);
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode((Bitmap)picbxBarcode.Image);
            if (result != null)
                txtbxDecode.Text = result.Text;
        }
    }
}
