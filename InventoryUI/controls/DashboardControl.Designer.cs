namespace InventoryUI
{
    partial class DashboardControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbbxType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbbxClient = new System.Windows.Forms.ComboBox();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateFinishFrom = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.chkbxDateFinish = new System.Windows.Forms.CheckBox();
            this.dateFinishTo = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateStartFrom = new System.Windows.Forms.DateTimePicker();
            this.label50 = new System.Windows.Forms.Label();
            this.chkbxDateStart = new System.Windows.Forms.CheckBox();
            this.dateStartTo = new System.Windows.Forms.DateTimePicker();
            this.gridTrasactionDetails = new System.Windows.Forms.DataGridView();
            this.barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridReceiptName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridReceiptQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridReceiptPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridReceiptDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridReceiptShippingCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridTransactions = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.transactionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refundDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finishDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refundState = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.finishState = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.totalDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalShipping = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlInfo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTrasactionDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.label3.Location = new System.Drawing.Point(282, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Transaction Type";
            // 
            // cmbbxType
            // 
            this.cmbbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbxType.FormattingEnabled = true;
            this.cmbbxType.Location = new System.Drawing.Point(462, 90);
            this.cmbbxType.Name = "cmbbxType";
            this.cmbbxType.Size = new System.Drawing.Size(147, 21);
            this.cmbbxType.TabIndex = 5;
            this.cmbbxType.SelectionChangeCommitted += new System.EventHandler(this.cmbbxClient_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.label4.Location = new System.Drawing.Point(12, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Client";
            // 
            // cmbbxClient
            // 
            this.cmbbxClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbxClient.FormattingEnabled = true;
            this.cmbbxClient.Location = new System.Drawing.Point(101, 90);
            this.cmbbxClient.Name = "cmbbxClient";
            this.cmbbxClient.Size = new System.Drawing.Size(147, 21);
            this.cmbbxClient.TabIndex = 8;
            this.cmbbxClient.SelectionChangeCommitted += new System.EventHandler(this.cmbbxClient_SelectionChangeCommitted);
            // 
            // pnlInfo
            // 
            this.pnlInfo.Controls.Add(this.groupBox2);
            this.pnlInfo.Controls.Add(this.groupBox1);
            this.pnlInfo.Controls.Add(this.cmbbxType);
            this.pnlInfo.Controls.Add(this.label3);
            this.pnlInfo.Controls.Add(this.cmbbxClient);
            this.pnlInfo.Controls.Add(this.label4);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(1080, 117);
            this.pnlInfo.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dateFinishFrom);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.chkbxDateFinish);
            this.groupBox2.Controls.Add(this.dateFinishTo);
            this.groupBox2.Location = new System.Drawing.Point(462, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 63);
            this.groupBox2.TabIndex = 119;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(241, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 21);
            this.label5.TabIndex = 36;
            this.label5.Text = "And";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(6, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 21);
            this.label6.TabIndex = 35;
            this.label6.Text = "Between";
            // 
            // dateFinishFrom
            // 
            this.dateFinishFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateFinishFrom.CustomFormat = "MM/dd/yyyy";
            this.dateFinishFrom.Enabled = false;
            this.dateFinishFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFinishFrom.Location = new System.Drawing.Point(115, 33);
            this.dateFinishFrom.Name = "dateFinishFrom";
            this.dateFinishFrom.Size = new System.Drawing.Size(97, 20);
            this.dateFinishFrom.TabIndex = 29;
            this.dateFinishFrom.Value = new System.DateTime(2019, 7, 3, 0, 0, 0, 0);
            this.dateFinishFrom.ValueChanged += new System.EventHandler(this.dateStartFrom_ValueChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(23, -1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 21);
            this.label7.TabIndex = 28;
            this.label7.Text = "Finish Date";
            // 
            // chkbxDateFinish
            // 
            this.chkbxDateFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkbxDateFinish.AutoSize = true;
            this.chkbxDateFinish.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkbxDateFinish.Location = new System.Drawing.Point(144, 0);
            this.chkbxDateFinish.Name = "chkbxDateFinish";
            this.chkbxDateFinish.Size = new System.Drawing.Size(15, 14);
            this.chkbxDateFinish.TabIndex = 27;
            this.chkbxDateFinish.UseVisualStyleBackColor = true;
            this.chkbxDateFinish.CheckedChanged += new System.EventHandler(this.chkbxDateFinish_CheckedChanged);
            // 
            // dateFinishTo
            // 
            this.dateFinishTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateFinishTo.CustomFormat = "MM/dd/yyyy";
            this.dateFinishTo.Enabled = false;
            this.dateFinishTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFinishTo.Location = new System.Drawing.Point(313, 34);
            this.dateFinishTo.Name = "dateFinishTo";
            this.dateFinishTo.Size = new System.Drawing.Size(95, 20);
            this.dateFinishTo.TabIndex = 14;
            this.dateFinishTo.Value = new System.DateTime(2019, 7, 3, 0, 0, 0, 0);
            this.dateFinishTo.ValueChanged += new System.EventHandler(this.dateStartFrom_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateStartFrom);
            this.groupBox1.Controls.Add(this.label50);
            this.groupBox1.Controls.Add(this.chkbxDateStart);
            this.groupBox1.Controls.Add(this.dateStartTo);
            this.groupBox1.Location = new System.Drawing.Point(14, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 63);
            this.groupBox1.TabIndex = 118;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(241, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 21);
            this.label2.TabIndex = 36;
            this.label2.Text = "And";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 35;
            this.label1.Text = "Between";
            // 
            // dateStartFrom
            // 
            this.dateStartFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateStartFrom.CustomFormat = "MM/dd/yyyy";
            this.dateStartFrom.Enabled = false;
            this.dateStartFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateStartFrom.Location = new System.Drawing.Point(115, 33);
            this.dateStartFrom.Name = "dateStartFrom";
            this.dateStartFrom.Size = new System.Drawing.Size(97, 20);
            this.dateStartFrom.TabIndex = 29;
            this.dateStartFrom.Value = new System.DateTime(2019, 7, 3, 0, 0, 0, 0);
            this.dateStartFrom.ValueChanged += new System.EventHandler(this.dateStartFrom_ValueChanged);
            // 
            // label50
            // 
            this.label50.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.label50.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.label50.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label50.Location = new System.Drawing.Point(23, -1);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(100, 21);
            this.label50.TabIndex = 28;
            this.label50.Text = "Start Date";
            // 
            // chkbxDateStart
            // 
            this.chkbxDateStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkbxDateStart.AutoSize = true;
            this.chkbxDateStart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkbxDateStart.Location = new System.Drawing.Point(129, 0);
            this.chkbxDateStart.Name = "chkbxDateStart";
            this.chkbxDateStart.Size = new System.Drawing.Size(15, 14);
            this.chkbxDateStart.TabIndex = 27;
            this.chkbxDateStart.UseVisualStyleBackColor = true;
            this.chkbxDateStart.CheckedChanged += new System.EventHandler(this.chkbxDateStart_CheckedChanged);
            // 
            // dateStartTo
            // 
            this.dateStartTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateStartTo.CustomFormat = "MM/dd/yyyy";
            this.dateStartTo.Enabled = false;
            this.dateStartTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateStartTo.Location = new System.Drawing.Point(313, 34);
            this.dateStartTo.Name = "dateStartTo";
            this.dateStartTo.Size = new System.Drawing.Size(95, 20);
            this.dateStartTo.TabIndex = 14;
            this.dateStartTo.Value = new System.DateTime(2019, 7, 3, 0, 0, 0, 0);
            this.dateStartTo.ValueChanged += new System.EventHandler(this.dateStartFrom_ValueChanged);
            // 
            // gridTrasactionDetails
            // 
            this.gridTrasactionDetails.AllowUserToAddRows = false;
            this.gridTrasactionDetails.AllowUserToDeleteRows = false;
            this.gridTrasactionDetails.AllowUserToResizeColumns = false;
            this.gridTrasactionDetails.AllowUserToResizeRows = false;
            this.gridTrasactionDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridTrasactionDetails.BackgroundColor = System.Drawing.Color.White;
            this.gridTrasactionDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTrasactionDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridTrasactionDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTrasactionDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barcode,
            this.GridReceiptName,
            this.GridReceiptQuantity,
            this.GridReceiptPrice,
            this.GridReceiptDiscount,
            this.GridReceiptShippingCost});
            this.gridTrasactionDetails.Dock = System.Windows.Forms.DockStyle.Right;
            this.gridTrasactionDetails.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gridTrasactionDetails.EnableHeadersVisualStyles = false;
            this.gridTrasactionDetails.Location = new System.Drawing.Point(609, 117);
            this.gridTrasactionDetails.MultiSelect = false;
            this.gridTrasactionDetails.Name = "gridTrasactionDetails";
            this.gridTrasactionDetails.ReadOnly = true;
            this.gridTrasactionDetails.RowHeadersVisible = false;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.gridTrasactionDetails.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridTrasactionDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTrasactionDetails.Size = new System.Drawing.Size(471, 580);
            this.gridTrasactionDetails.TabIndex = 10;
            // 
            // barcode
            // 
            this.barcode.HeaderText = "Barcode";
            this.barcode.Name = "barcode";
            this.barcode.ReadOnly = true;
            // 
            // GridReceiptName
            // 
            this.GridReceiptName.HeaderText = "Product Name";
            this.GridReceiptName.Name = "GridReceiptName";
            this.GridReceiptName.ReadOnly = true;
            // 
            // GridReceiptQuantity
            // 
            this.GridReceiptQuantity.HeaderText = "Quantity";
            this.GridReceiptQuantity.Name = "GridReceiptQuantity";
            this.GridReceiptQuantity.ReadOnly = true;
            // 
            // GridReceiptPrice
            // 
            this.GridReceiptPrice.HeaderText = "Price";
            this.GridReceiptPrice.Name = "GridReceiptPrice";
            this.GridReceiptPrice.ReadOnly = true;
            // 
            // GridReceiptDiscount
            // 
            this.GridReceiptDiscount.HeaderText = "Discount";
            this.GridReceiptDiscount.Name = "GridReceiptDiscount";
            this.GridReceiptDiscount.ReadOnly = true;
            // 
            // GridReceiptShippingCost
            // 
            this.GridReceiptShippingCost.HeaderText = "Shipping Cost";
            this.GridReceiptShippingCost.Name = "GridReceiptShippingCost";
            this.GridReceiptShippingCost.ReadOnly = true;
            // 
            // gridTransactions
            // 
            this.gridTransactions.AllowUserToAddRows = false;
            this.gridTransactions.AllowUserToDeleteRows = false;
            this.gridTransactions.AllowUserToResizeColumns = false;
            this.gridTransactions.AllowUserToResizeRows = false;
            this.gridTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridTransactions.BackgroundColor = System.Drawing.Color.White;
            this.gridTransactions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.transactionID,
            this.clientName,
            this.transactionType,
            this.transactionDate,
            this.openDate,
            this.StartDate,
            this.refundDate,
            this.finishDate,
            this.refundState,
            this.finishState,
            this.totalDiscount,
            this.totalShipping,
            this.totalPrice});
            this.gridTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTransactions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gridTransactions.EnableHeadersVisualStyles = false;
            this.gridTransactions.Location = new System.Drawing.Point(0, 117);
            this.gridTransactions.MultiSelect = false;
            this.gridTransactions.Name = "gridTransactions";
            this.gridTransactions.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTransactions.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridTransactions.RowHeadersVisible = false;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.gridTransactions.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTransactions.Size = new System.Drawing.Size(609, 580);
            this.gridTransactions.TabIndex = 12;
            this.gridTransactions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTransaction_CellClick);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Width = 41;
            // 
            // transactionID
            // 
            this.transactionID.HeaderText = "transactionID";
            this.transactionID.Name = "transactionID";
            this.transactionID.ReadOnly = true;
            this.transactionID.Width = 124;
            // 
            // clientName
            // 
            this.clientName.HeaderText = "client Name";
            this.clientName.Name = "clientName";
            this.clientName.ReadOnly = true;
            this.clientName.Width = 105;
            // 
            // transactionType
            // 
            this.transactionType.HeaderText = "transaction Type";
            this.transactionType.Name = "transactionType";
            this.transactionType.ReadOnly = true;
            this.transactionType.Width = 136;
            // 
            // transactionDate
            // 
            this.transactionDate.HeaderText = "transaction Date";
            this.transactionDate.Name = "transactionDate";
            this.transactionDate.ReadOnly = true;
            this.transactionDate.Width = 133;
            // 
            // openDate
            // 
            this.openDate.HeaderText = "open Date";
            this.openDate.Name = "openDate";
            this.openDate.ReadOnly = true;
            this.openDate.Width = 96;
            // 
            // StartDate
            // 
            this.StartDate.HeaderText = "Start Date";
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            this.StartDate.Width = 94;
            // 
            // refundDate
            // 
            this.refundDate.HeaderText = "refund Date";
            this.refundDate.Name = "refundDate";
            this.refundDate.ReadOnly = true;
            this.refundDate.Width = 104;
            // 
            // finishDate
            // 
            this.finishDate.HeaderText = "finish Date";
            this.finishDate.Name = "finishDate";
            this.finishDate.ReadOnly = true;
            this.finishDate.Width = 97;
            // 
            // refundState
            // 
            this.refundState.HeaderText = "refund State";
            this.refundState.Name = "refundState";
            this.refundState.ReadOnly = true;
            this.refundState.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.refundState.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.refundState.Width = 106;
            // 
            // finishState
            // 
            this.finishState.HeaderText = "finish State";
            this.finishState.Name = "finishState";
            this.finishState.ReadOnly = true;
            this.finishState.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.finishState.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // totalDiscount
            // 
            this.totalDiscount.HeaderText = "total Discount";
            this.totalDiscount.Name = "totalDiscount";
            this.totalDiscount.ReadOnly = true;
            this.totalDiscount.Width = 116;
            // 
            // totalShipping
            // 
            this.totalShipping.HeaderText = "total Shipping";
            this.totalShipping.Name = "totalShipping";
            this.totalShipping.ReadOnly = true;
            this.totalShipping.Width = 117;
            // 
            // totalPrice
            // 
            this.totalPrice.HeaderText = "total Price";
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.ReadOnly = true;
            this.totalPrice.Width = 95;
            // 
            // DashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridTransactions);
            this.Controls.Add(this.gridTrasactionDetails);
            this.Controls.Add(this.pnlInfo);
            this.DoubleBuffered = true;
            this.Name = "DashboardControl";
            this.Size = new System.Drawing.Size(1080, 697);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTrasactionDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransactions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbbxType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbbxClient;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.DataGridView gridTrasactionDetails;
        private System.Windows.Forms.DataGridView gridTransactions;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateFinishFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkbxDateFinish;
        private System.Windows.Forms.DateTimePicker dateFinishTo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateStartFrom;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.CheckBox chkbxDateStart;
        private System.Windows.Forms.DateTimePicker dateStartTo;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn openDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn refundDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn finishDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn refundState;
        private System.Windows.Forms.DataGridViewCheckBoxColumn finishState;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalShipping;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridReceiptName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridReceiptQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridReceiptPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridReceiptDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridReceiptShippingCost;
    }
}
