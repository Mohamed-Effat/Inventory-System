using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryUI
{
    public partial class DashboardControl : UserControl
    {
        public class TransactionData
        {
            public int TransactionID { get; set; }
            public string clientName { get; set; }
            public DateTime transactionsDate { get; set; }
            public DateTime openDate { get; set; }
            public DateTime startDate { get; set; }
            public DateTime refundDate { get; set; }
            public DateTime finishDate { get; set; }
            public bool refundState { get; set; }
            public bool finishState { get; set; }
        }
        public DashboardControl()
        {
            InitializeComponent();
            gridTransactions.AutoGenerateColumns = false;
            gridTrasactionDetails.AutoGenerateColumns = false;

            foreach (DataGridViewColumn col in gridTransactions.Columns)
            {
                col.DataPropertyName = col.Name;
                dtTransaction.Columns.Add(col.Name);

            }
            dtTransaction.Columns.Remove("Edit");
            foreach (DataGridViewColumn col in gridTrasactionDetails.Columns)
            {
                col.DataPropertyName = col.Name;
                dtTransactionDetails.Columns.Add(col.Name);
            }
        }

        DataTable dtTransaction = new DataTable();
        DataTable dtTransactionDetails = new DataTable();
        protected override void OnLoad(EventArgs e)
        {
            // do stuff before Load-event is raised
            base.OnLoad(e);
            if (Utility.FillCombo(cmbbxClient, "GetAllClient"))
            {
                cmbbxClient.Items.Insert(0, new Utility.ComboboxItem { Text = "", Value = -1 }); //add an empty item
                cmbbxClient.SelectedIndex = 0;
            }
            if (Utility.FillCombo(cmbbxType, "GetAllTransaction"))
            {
                cmbbxType.Items.Insert(0, new Utility.ComboboxItem { Text = "", Value = -1 }); //add an empty item
                cmbbxType.SelectedIndex = 0;
            }

            dateStartFrom.ValueChanged -= new EventHandler(dateStartFrom_ValueChanged); //unsubscribe
            dateStartTo.ValueChanged -= new EventHandler(dateStartFrom_ValueChanged);
            dateFinishFrom.ValueChanged -= new EventHandler(dateStartFrom_ValueChanged);
            dateFinishTo.ValueChanged -= new EventHandler(dateStartFrom_ValueChanged);

            dateStartFrom.Value = DateTime.Now;
            dateStartTo.Value = DateTime.Now;
            dateFinishFrom.Value = DateTime.Now;
            dateFinishTo.Value = DateTime.Now;

            dateStartFrom.ValueChanged += new EventHandler(dateStartFrom_ValueChanged); //subscrube
            dateStartTo.ValueChanged += new EventHandler(dateStartFrom_ValueChanged);
            dateFinishFrom.ValueChanged += new EventHandler(dateStartFrom_ValueChanged);
            dateFinishTo.ValueChanged += new EventHandler(dateStartFrom_ValueChanged);

            gridTransactions.DataSource = (DataTable)Utility.FillDataTable(dtTransaction, "FillGridTransactions");
            SearchTransactionDetailsBytransactionID();
        }

        TransactionEditForm editForm = new TransactionEditForm();
        public TransactionData transactionData = new TransactionData();
        private void grdTransaction_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridTransactions.SelectedRows.Count == 0 || e.RowIndex == -1)
                return;

            SearchTransactionDetailsBytransactionID();

            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn)   //if the Clicked Cell is of type Button and an actual row is Clicked
            {
                transactionData.TransactionID = Convert.ToInt32(gridTransactions.SelectedRows[0].Cells["transactionID"].Value);
                transactionData.clientName = gridTransactions.SelectedRows[0].Cells["clientName"].Value.ToString();
                transactionData.transactionsDate = Convert.ToDateTime(gridTransactions.SelectedRows[0].Cells["transactionDate"].Value);
                transactionData.openDate = Convert.ToDateTime(gridTransactions.SelectedRows[0].Cells["openDate"].Value);
                transactionData.startDate = Convert.ToDateTime(gridTransactions.SelectedRows[0].Cells["StartDate"].Value);
                if (gridTransactions.SelectedRows[0].Cells["refundDate"].Value == DBNull.Value)
                    transactionData.refundDate = DateTime.Now;
                else
                    transactionData.refundDate = Convert.ToDateTime(gridTransactions.SelectedRows[0].Cells["refundDate"].Value);

                if (gridTransactions.SelectedRows[0].Cells["finishDate"].Value == DBNull.Value)
                    transactionData.finishDate = DateTime.Now;
                else
                    transactionData.finishDate = Convert.ToDateTime(gridTransactions.SelectedRows[0].Cells["finishDate"].Value);

                transactionData.refundState = Convert.ToBoolean(gridTransactions.SelectedRows[0].Cells["refundState"].Value);
                transactionData.finishState = Convert.ToBoolean(gridTransactions.SelectedRows[0].Cells["finishState"].Value);
                editForm.ShowDialog(this);

                gridTransactions.DataSource = (DataTable)Utility.FillDataTable(dtTransaction, "FillGridTransactions");
                SearchTransactionDetailsBytransactionID();

            }
        }


        private void SearchTransactionDetailsBytransactionID()
        {
            gridTrasactionDetails.DataSource = null;
            gridTrasactionDetails.Rows.Clear();
            if (gridTransactions.SelectedRows.Count == 0 || gridTransactions.SelectedRows[0].Index == -1)
                return;
            List<Utility.ProcedureParameter> parameters = new List<Utility.ProcedureParameter>()
                {
                   new Utility.ProcedureParameter(){ parameterName = "transactionID", DType = SqlDbType.Int, SourceObject =gridTransactions.SelectedRows[0].Cells["transactionID"]},
                };

            gridTrasactionDetails.DataSource = (DataTable)Utility.FillDataTable(dtTransactionDetails, "SearchTransactionDetailsBytransactioID", parameters);
        }
        private void SearchGridTransactionsWithData()
        {
            //(@ClientID int, @TypeID int, @dateStartFrom datetime2(50), @dateStartTo datetime2(50), @dateFinishFrom datetime2(50), @DateFinishTo datetime2(50))
            List<Utility.ProcedureParameter> parameters = new List<Utility.ProcedureParameter>()
                {
                   new Utility.ProcedureParameter(){ parameterName = "ClientID", DType = SqlDbType.Int, SourceObject = cmbbxClient},
                   new Utility.ProcedureParameter(){ parameterName = "TypeID", DType = SqlDbType.Int, SourceObject = cmbbxType},
                };
            if (chkbxDateStart.Checked)
            {
                parameters.Add(new Utility.ProcedureParameter() { parameterName = "dateStartFrom", DType = SqlDbType.VarChar, SourceObject = dateStartFrom.Text });
                parameters.Add(new Utility.ProcedureParameter() { parameterName = "dateStartTo", DType = SqlDbType.VarChar, SourceObject = dateStartTo.Text });
            }
            else
            {
                parameters.Add(new Utility.ProcedureParameter() { parameterName = "dateStartFrom", DType = SqlDbType.VarChar, SourceObject = DBNull.Value });
                parameters.Add(new Utility.ProcedureParameter() { parameterName = "dateStartTo", DType = SqlDbType.VarChar, SourceObject = DBNull.Value });
            }

            if (chkbxDateFinish.Checked)
            {
                parameters.Add(new Utility.ProcedureParameter() { parameterName = "dateFinishFrom", DType = SqlDbType.VarChar, SourceObject = dateFinishFrom.Text });
                parameters.Add(new Utility.ProcedureParameter() { parameterName = "DateFinishTo", DType = SqlDbType.VarChar, SourceObject = dateFinishTo.Text });
            }
            else
            {
                parameters.Add(new Utility.ProcedureParameter() { parameterName = "dateFinishFrom", DType = SqlDbType.VarChar, SourceObject = DBNull.Value });
                parameters.Add(new Utility.ProcedureParameter() { parameterName = "DateFinishTo", DType = SqlDbType.VarChar, SourceObject = DBNull.Value });
            }
            gridTransactions.DataSource = (DataTable)Utility.FillDataTable(dtTransaction, "SearchTransactionsByData", parameters);
            SearchTransactionDetailsBytransactionID();
        }
        private void chkbxDateStart_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxDateStart.CheckState == CheckState.Checked)
            {
                dateStartFrom.Enabled = true;
                dateStartTo.Enabled = true;
            }
            else
            {
                dateStartFrom.Enabled = false;
                dateStartTo.Enabled = false;
            }
            SearchGridTransactionsWithData();
        }

        private void chkbxDateFinish_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxDateFinish.CheckState == CheckState.Checked)
            {
                dateFinishFrom.Enabled = true;
                dateFinishTo.Enabled = true;
            }
            else
            {
                dateFinishFrom.Enabled = false;
                dateFinishTo.Enabled = false;
            }
            SearchGridTransactionsWithData();
        }
        private void cmbbxClient_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SearchGridTransactionsWithData();
        }

        private void dateStartFrom_ValueChanged(object sender, EventArgs e)
        {
            SearchGridTransactionsWithData();
        }


    }
}
