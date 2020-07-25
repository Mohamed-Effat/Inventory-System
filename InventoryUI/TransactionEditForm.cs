using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryUI
{
    public partial class TransactionEditForm : Form
    {
        public TransactionEditForm()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            // do stuff before Load-event is raised
            base.OnLoad(e);
            if (Utility.FillCombo(cmbbxClient, "GetAllClient"))
            {
                cmbbxClient.SelectedIndex = 0;
            }

            data = ((DashboardControl)this.Owner.Controls.Find("dashboardControl", true)[0]).transactionData;
            dateTransaction.Value = data.transactionsDate;
            dateOpen.Value = data.openDate;
            dateStart.Value = data.startDate;
            dateRefund.Value = data.refundDate;
            dateFinish.Value = data.finishDate;
            chkbxRefund.Checked = data.refundState;
            chkbxFinished.Checked = data.finishState;

            Utility.SelectItem(cmbbxClient, data.clientName);
        }
        DashboardControl.TransactionData data = new  DashboardControl.TransactionData();
        private void btnExitHeader_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkbxRefund_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxRefund.Checked)
            {
                dateRefund.Enabled = true;
                lblRefundDate.ForeColor = Color.White;
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
                lblFinishDate.ForeColor = Color.White;
            }
            else
            {
                dateFinish.Enabled = false;
                lblFinishDate.ForeColor = SystemColors.ControlDark;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //(@TransactionID int ,@clientID int,@employeeID int,@transactionTypeID int,@transactionsDate datetime2(0)
            //,@openDate datetime2(0),@startDate datetime2(0),@refundDate datetime2(0),@finishDate datetime2(0),
            //@refundState bit ,@finishState bit,@totalDiscount tinyint ,@totalshipping money,@totalPrice money )
            List<Utility.ProcedureParameter> parameters = new List<Utility.ProcedureParameter>()
                {
                    new Utility.ProcedureParameter(){ parameterName = "TransactionID", DType = SqlDbType.Int, SourceObject = data.TransactionID},
                    new Utility.ProcedureParameter(){ parameterName = "clientID", DType = SqlDbType.Int, SourceObject = cmbbxClient},
                    new Utility.ProcedureParameter(){ parameterName = "employeeID", DType = SqlDbType.Int, SourceObject = DBNull.Value},
                    new Utility.ProcedureParameter(){ parameterName = "transactionTypeID", DType = SqlDbType.Int, SourceObject = DBNull.Value},
                    new Utility.ProcedureParameter(){ parameterName = "transactionsDate ", DType = SqlDbType.DateTime2, SourceObject = dateTransaction},
                    new Utility.ProcedureParameter(){ parameterName = "openDate", DType = SqlDbType.DateTime2, SourceObject = dateOpen},
                    new Utility.ProcedureParameter(){ parameterName = "startDate", DType = SqlDbType.DateTime2, SourceObject = dateStart},
                    new Utility.ProcedureParameter(){ parameterName = "totalDiscount", DType = SqlDbType.TinyInt, SourceObject = DBNull.Value},
                    new Utility.ProcedureParameter(){ parameterName = "totalshipping ", DType = SqlDbType.Money, SourceObject = DBNull.Value},
                    new Utility.ProcedureParameter() { parameterName = "refundState", DType = SqlDbType.Bit, SourceObject = chkbxRefund },
                    new Utility.ProcedureParameter() { parameterName = "finishState ", DType = SqlDbType.Bit, SourceObject = chkbxFinished },
                    new Utility.ProcedureParameter(){ parameterName = "totalPrice ", DType = SqlDbType.Money, SourceObject = DBNull.Value}
                };


            if (chkbxRefund.Checked)
                parameters.Add(new Utility.ProcedureParameter() { parameterName = "refundDate ", DType = SqlDbType.DateTime2, SourceObject = dateRefund });
            else
                parameters.Add(new Utility.ProcedureParameter() { parameterName = "refundDate ", DType = SqlDbType.DateTime2, SourceObject = DBNull.Value });
            if (chkbxFinished.Checked)
                parameters.Add(new Utility.ProcedureParameter() { parameterName = "finishDate", DType = SqlDbType.DateTime2, SourceObject = dateFinish });
            else
                parameters.Add(new Utility.ProcedureParameter() { parameterName = "finishDate", DType = SqlDbType.DateTime2, SourceObject = DBNull.Value });

            if (Convert.ToBoolean(Utility.InsertProcedure("InsertTransaction", parameters)))
            {
                MessageBox.Show(null, "Transaction Edit Complete", "Products", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
            
        }
    }
}
