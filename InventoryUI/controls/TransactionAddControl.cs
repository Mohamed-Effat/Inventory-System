using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventoryUI.controls
{
    public partial class TransactionAddControl : UserControl
    {
        public TransactionAddControl()
        {
            InitializeComponent();
            transactionDetailsControl.BringToFront();
        }
        protected override void OnLoad(EventArgs e)
        {
            // do stuff before Load-event is raised
            base.OnLoad(e);
            if (Utility.FillCombo(cmbbxClientName, "GetAllClient"))
                cmbbxClientName.SelectedIndex = 0;
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            pnlTInfo.Visible = false;

            transactionDetailsControl.Visible = true;
        }

        private void btnTransactionAdd_Click(object sender, EventArgs e)
        {
            List<Utility.ValidationItem> validationList = new List<Utility.ValidationItem>()
                {
                   new Utility.ValidationItem(){ control = cmbbxClientName, lblError =lblClientError,},
                };

            if (transactionDetailsControl.dataList.Count == 0)
                lblDetailsError.Visible = true;
            else
                lblDetailsError.Visible = false;

            if (transactionDetailsControl.transactionTypeID == -1)
                lblTypeError.Visible = true;
            else
                lblTypeError.Visible = false;


            if (!Utility.ValidateControlList(validationList) || transactionDetailsControl.dataList.Count == 0 || transactionDetailsControl.transactionTypeID == -1)
            {
                System.Media.SystemSounds.Beep.Play();
                return;
            }

            double price = (transactionDetailsControl.TotalPrice
                - Utility.convertPercent(Convert.ToDouble(txtbxDiscount.Text)) *
                transactionDetailsControl.TotalPrice)
                + Convert.ToDouble(txtbxShipping.Text);
            //(@TransactionID int ,@clientID int,@employeeID int,@transactionTypeID int,@transactionsDate datetime2(0),@openDate datetime2(0),
            //@startDate datetime2(0),@refundDate datetime2(0),@finishDate datetime2(0),@refundState bit ,@finishState bit,@totalDiscount tinyint ,
            //@totalshipping money,@totalPrice money )
            List<Utility.ProcedureParameter> parameters = new List<Utility.ProcedureParameter>()
                {
                    new Utility.ProcedureParameter(){ parameterName = "TransactionID", DType = SqlDbType.Int, SourceObject = DBNull.Value},
                    new Utility.ProcedureParameter(){ parameterName = "clientID", DType = SqlDbType.Int, SourceObject = cmbbxClientName},
                    new Utility.ProcedureParameter(){ parameterName = "employeeID", DType = SqlDbType.Int, SourceObject = DBNull.Value},
                    new Utility.ProcedureParameter(){ parameterName = "transactionTypeID", DType = SqlDbType.Int, SourceObject = transactionDetailsControl.transactionTypeID},
                    new Utility.ProcedureParameter(){ parameterName = "transactionsDate ", DType = SqlDbType.DateTime2, SourceObject = dateTransaction},
                    new Utility.ProcedureParameter(){ parameterName = "openDate", DType = SqlDbType.DateTime2, SourceObject = dateOpen},
                    new Utility.ProcedureParameter(){ parameterName = "startDate", DType = SqlDbType.DateTime2, SourceObject = dateStart},
                    new Utility.ProcedureParameter(){ parameterName = "totalDiscount", DType = SqlDbType.TinyInt, SourceObject = txtbxDiscount},
                    new Utility.ProcedureParameter(){ parameterName = "totalshipping ", DType = SqlDbType.Money, SourceObject = txtbxShipping},
                    new Utility.ProcedureParameter() { parameterName = "refundState", DType = SqlDbType.Bit, SourceObject = chkbxRefund },
                    new Utility.ProcedureParameter() { parameterName = "finishState ", DType = SqlDbType.Bit, SourceObject = chkbxFinished },
                    new Utility.ProcedureParameter(){ parameterName = "totalPrice ", DType = SqlDbType.Money, SourceObject = price}
                };


            if (chkbxRefund.Checked)
                parameters.Add(new Utility.ProcedureParameter() { parameterName = "refundDate ", DType = SqlDbType.DateTime2, SourceObject = dateRefund });
            else
                parameters.Add(new Utility.ProcedureParameter() { parameterName = "refundDate ", DType = SqlDbType.DateTime2, SourceObject = DBNull.Value });
            if (chkbxFinished.Checked)
                parameters.Add(new Utility.ProcedureParameter() { parameterName = "finishDate", DType = SqlDbType.DateTime2, SourceObject = dateFinish });

            else
                parameters.Add(new Utility.ProcedureParameter() { parameterName = "finishDate", DType = SqlDbType.DateTime2, SourceObject = DBNull.Value });

            int transactionId = Utility.InsertProcedure("InsertTransaction", parameters);
            if (transactionId <= 0)
            {
                MessageBox.Show(null, "InsertTransaction Failed", "tansaction", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            foreach (TransactionDetailsControl.TransactionDetailsData data in transactionDetailsControl.dataList)
            {
                List<Utility.ProcedureParameter> transactioDetailsParameters = new List<Utility.ProcedureParameter>()
                 {
                  //(@TransactionID int,@ProductVersionID int,@Quantity int, @Price money,
                  //@Discount tinyint,@ShippingCost money,
                  //@UpdatedStockQuantity int)
                    new Utility.ProcedureParameter(){ parameterName = "TransactionID", DType = SqlDbType.Int, SourceObject = transactionId },
                    new Utility.ProcedureParameter(){ parameterName = "ProductVersionID", DType = SqlDbType.Int, SourceObject = data.productVersionID},
                    new Utility.ProcedureParameter(){ parameterName = "Quantity", DType = SqlDbType.Int, SourceObject = data.quantity},
                    new Utility.ProcedureParameter(){ parameterName = "Price ", DType = SqlDbType.Money, SourceObject = data.price}, 
                    new Utility.ProcedureParameter(){ parameterName = "Discount", DType = SqlDbType.TinyInt, SourceObject = data.discount},
                    new Utility.ProcedureParameter(){ parameterName = "ShippingCost", DType = SqlDbType.Money, SourceObject = data.shippingCost},
                 };


                if (Utility.InsertProcedure("InsertTransactionDetail", transactioDetailsParameters) == 0)
                {
                    MessageBox.Show(null, "InsertTransactionDetail Failed", "Products", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }

            MessageBox.Show(null, "Transaction Added", "Products", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtbxShipping.TextChanged -= new EventHandler(txtbxShipping_TextChanged);   //unsubscribe from event to prevent the clearPanel from calling the event
            txtbxDiscount.TextChanged -= new EventHandler(txtbxDiscount_TextChanged);
            
            Utility.clearPanel(pnlTInfo);
            Utility.clearPanel((Panel)transactionDetailsControl.Controls["pnlMain"]);
            txtbxDiscount.Text = "0";
            txtbxShipping.Text = "0.0";
            txtbxShipping.TextChanged += new EventHandler(txtbxShipping_TextChanged);   //subscribe back
            txtbxDiscount.TextChanged += new EventHandler(txtbxDiscount_TextChanged);
            pnlTInfo.Visible = false;
            transactionDetailsControl.Visible = true;
            Utility.ClearDataTable(transactionDetailsControl.dtProducts);
            transactionDetailsControl.gridStock.DataSource = (DataTable)Utility.FillDataTable(transactionDetailsControl.dtProducts, "FillGridStockDetails");

        }

        private void chkbxRefund_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxRefund.Checked)
            {
                dateRefund.Enabled = true;
                lblRefundDate.ForeColor = Color.FromArgb(39, 40, 68);
            }
            else
            {
                dateRefund.Enabled = false;
                lblRefundDate.ForeColor = SystemColors.ControlDark;
            }
        }

        private void chkbxFinished_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxFinished.Checked)
            {
                dateFinish.Enabled = true;
                lblFinishDate.ForeColor = Color.FromArgb(39, 40, 68);
            }
            else
            {
                dateFinish.Enabled = false;
                lblFinishDate.ForeColor = SystemColors.ControlDark;
            }
        }

        private void pnlTInfo_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnTransactionPrint_Click(object sender, EventArgs e)
        {



        }

        private void txtbxDiscount_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(((TextBox)sender).Text))
            {
                System.Media.SystemSounds.Beep.Play();
                ((TextBox)sender).Text += "0";
            }

        }

        private void txtbxShipping_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(((TextBox)sender).Text))
            {
                System.Media.SystemSounds.Beep.Play();
                ((TextBox)sender).Text += "0.0";
            }
        }
    }
}
