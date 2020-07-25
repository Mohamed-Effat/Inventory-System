namespace InventoryUI.controls
{
    partial class TransactionAddControl
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
            this.pnlTInfo = new System.Windows.Forms.Panel();
            this.lblTypeError = new System.Windows.Forms.Label();
            this.lblDetailsError = new System.Windows.Forms.Label();
            this.lblClientError = new System.Windows.Forms.Label();
            this.txtbxShipping = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbxDiscount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFinishDate = new System.Windows.Forms.Label();
            this.dateFinish = new System.Windows.Forms.DateTimePicker();
            this.lblRefundDate = new System.Windows.Forms.Label();
            this.dateRefund = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateOpen = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.chkbxRefund = new System.Windows.Forms.CheckBox();
            this.chkbxFinished = new System.Windows.Forms.CheckBox();
            this.dateTransaction = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbbxClientName = new System.Windows.Forms.ComboBox();
            this.transactionDetailsControl = new InventoryUI.controls.TransactionDetailsControl();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnTransactionAdd = new System.Windows.Forms.Button();
            this.pnlTInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTInfo
            // 
            this.pnlTInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTInfo.Controls.Add(this.lblTypeError);
            this.pnlTInfo.Controls.Add(this.lblDetailsError);
            this.pnlTInfo.Controls.Add(this.lblClientError);
            this.pnlTInfo.Controls.Add(this.btnPrevious);
            this.pnlTInfo.Controls.Add(this.txtbxShipping);
            this.pnlTInfo.Controls.Add(this.label9);
            this.pnlTInfo.Controls.Add(this.txtbxDiscount);
            this.pnlTInfo.Controls.Add(this.label1);
            this.pnlTInfo.Controls.Add(this.lblFinishDate);
            this.pnlTInfo.Controls.Add(this.dateFinish);
            this.pnlTInfo.Controls.Add(this.lblRefundDate);
            this.pnlTInfo.Controls.Add(this.dateRefund);
            this.pnlTInfo.Controls.Add(this.label6);
            this.pnlTInfo.Controls.Add(this.dateStart);
            this.pnlTInfo.Controls.Add(this.label4);
            this.pnlTInfo.Controls.Add(this.dateOpen);
            this.pnlTInfo.Controls.Add(this.label5);
            this.pnlTInfo.Controls.Add(this.chkbxRefund);
            this.pnlTInfo.Controls.Add(this.chkbxFinished);
            this.pnlTInfo.Controls.Add(this.dateTransaction);
            this.pnlTInfo.Controls.Add(this.label2);
            this.pnlTInfo.Controls.Add(this.label12);
            this.pnlTInfo.Controls.Add(this.cmbbxClientName);
            this.pnlTInfo.Controls.Add(this.btnTransactionAdd);
            this.pnlTInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlTInfo.Name = "pnlTInfo";
            this.pnlTInfo.Size = new System.Drawing.Size(1080, 697);
            this.pnlTInfo.TabIndex = 0;
            this.pnlTInfo.Visible = false;
            this.pnlTInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTInfo_Paint);
            // 
            // lblTypeError
            // 
            this.lblTypeError.AutoSize = true;
            this.lblTypeError.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTypeError.ForeColor = System.Drawing.Color.Red;
            this.lblTypeError.Location = new System.Drawing.Point(361, 542);
            this.lblTypeError.Name = "lblTypeError";
            this.lblTypeError.Size = new System.Drawing.Size(297, 21);
            this.lblTypeError.TabIndex = 123;
            this.lblTypeError.Text = "Must Choose A Transaction Type";
            this.lblTypeError.Visible = false;
            // 
            // lblDetailsError
            // 
            this.lblDetailsError.AutoSize = true;
            this.lblDetailsError.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblDetailsError.ForeColor = System.Drawing.Color.Red;
            this.lblDetailsError.Location = new System.Drawing.Point(252, 574);
            this.lblDetailsError.Name = "lblDetailsError";
            this.lblDetailsError.Size = new System.Drawing.Size(515, 21);
            this.lblDetailsError.TabIndex = 122;
            this.lblDetailsError.Text = "You must choose at least ONE product for the transaction";
            this.lblDetailsError.Visible = false;
            // 
            // lblClientError
            // 
            this.lblClientError.AutoSize = true;
            this.lblClientError.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblClientError.ForeColor = System.Drawing.Color.Red;
            this.lblClientError.Location = new System.Drawing.Point(775, 58);
            this.lblClientError.Name = "lblClientError";
            this.lblClientError.Size = new System.Drawing.Size(88, 21);
            this.lblClientError.TabIndex = 121;
            this.lblClientError.Text = "Required";
            this.lblClientError.Visible = false;
            // 
            // txtbxShipping
            // 
            this.txtbxShipping.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxShipping.Location = new System.Drawing.Point(724, 429);
            this.txtbxShipping.Name = "txtbxShipping";
            this.txtbxShipping.Size = new System.Drawing.Size(301, 26);
            this.txtbxShipping.TabIndex = 117;
            this.txtbxShipping.Text = "0";
            this.txtbxShipping.TextChanged += new System.EventHandler(this.txtbxShipping_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.label9.Location = new System.Drawing.Point(16, 431);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 21);
            this.label9.TabIndex = 116;
            this.label9.Text = "Total Shipping";
            // 
            // txtbxDiscount
            // 
            this.txtbxDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxDiscount.Location = new System.Drawing.Point(724, 373);
            this.txtbxDiscount.Name = "txtbxDiscount";
            this.txtbxDiscount.Size = new System.Drawing.Size(301, 26);
            this.txtbxDiscount.TabIndex = 115;
            this.txtbxDiscount.Text = "0";
            this.txtbxDiscount.TextChanged += new System.EventHandler(this.txtbxDiscount_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.label1.Location = new System.Drawing.Point(16, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 21);
            this.label1.TabIndex = 114;
            this.label1.Text = "Total Discount";
            // 
            // lblFinishDate
            // 
            this.lblFinishDate.AutoSize = true;
            this.lblFinishDate.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblFinishDate.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblFinishDate.Location = new System.Drawing.Point(16, 325);
            this.lblFinishDate.Name = "lblFinishDate";
            this.lblFinishDate.Size = new System.Drawing.Size(115, 21);
            this.lblFinishDate.TabIndex = 113;
            this.lblFinishDate.Text = "Finish Date";
            // 
            // dateFinish
            // 
            this.dateFinish.Enabled = false;
            this.dateFinish.Location = new System.Drawing.Point(825, 325);
            this.dateFinish.Name = "dateFinish";
            this.dateFinish.Size = new System.Drawing.Size(200, 20);
            this.dateFinish.TabIndex = 112;
            // 
            // lblRefundDate
            // 
            this.lblRefundDate.AutoSize = true;
            this.lblRefundDate.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblRefundDate.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblRefundDate.Location = new System.Drawing.Point(16, 272);
            this.lblRefundDate.Name = "lblRefundDate";
            this.lblRefundDate.Size = new System.Drawing.Size(120, 21);
            this.lblRefundDate.TabIndex = 111;
            this.lblRefundDate.Text = "Refund Date";
            // 
            // dateRefund
            // 
            this.dateRefund.Enabled = false;
            this.dateRefund.Location = new System.Drawing.Point(825, 272);
            this.dateRefund.Name = "dateRefund";
            this.dateRefund.Size = new System.Drawing.Size(200, 20);
            this.dateRefund.TabIndex = 110;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.label6.Location = new System.Drawing.Point(16, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 21);
            this.label6.TabIndex = 109;
            this.label6.Text = "Start Date";
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(825, 219);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(200, 20);
            this.dateStart.TabIndex = 108;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.label4.Location = new System.Drawing.Point(16, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 107;
            this.label4.Text = "Open Date";
            // 
            // dateOpen
            // 
            this.dateOpen.Location = new System.Drawing.Point(825, 166);
            this.dateOpen.Name = "dateOpen";
            this.dateOpen.Size = new System.Drawing.Size(200, 20);
            this.dateOpen.TabIndex = 106;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.label5.Location = new System.Drawing.Point(16, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 21);
            this.label5.TabIndex = 105;
            this.label5.Text = "Transaction Date";
            // 
            // chkbxRefund
            // 
            this.chkbxRefund.AutoSize = true;
            this.chkbxRefund.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.chkbxRefund.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.chkbxRefund.Location = new System.Drawing.Point(124, 245);
            this.chkbxRefund.Name = "chkbxRefund";
            this.chkbxRefund.Size = new System.Drawing.Size(87, 24);
            this.chkbxRefund.TabIndex = 101;
            this.chkbxRefund.Text = "Refund";
            this.chkbxRefund.UseVisualStyleBackColor = true;
            this.chkbxRefund.CheckedChanged += new System.EventHandler(this.chkbxRefund_CheckedChanged);
            // 
            // chkbxFinished
            // 
            this.chkbxFinished.AutoSize = true;
            this.chkbxFinished.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.chkbxFinished.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.chkbxFinished.Location = new System.Drawing.Point(124, 298);
            this.chkbxFinished.Name = "chkbxFinished";
            this.chkbxFinished.Size = new System.Drawing.Size(96, 24);
            this.chkbxFinished.TabIndex = 102;
            this.chkbxFinished.Text = "Finished";
            this.chkbxFinished.UseVisualStyleBackColor = true;
            this.chkbxFinished.CheckedChanged += new System.EventHandler(this.chkbxFinished_CheckedChanged);
            // 
            // dateTransaction
            // 
            this.dateTransaction.Location = new System.Drawing.Point(825, 113);
            this.dateTransaction.Name = "dateTransaction";
            this.dateTransaction.Size = new System.Drawing.Size(200, 20);
            this.dateTransaction.TabIndex = 104;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.label2.Location = new System.Drawing.Point(479, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 21);
            this.label2.TabIndex = 98;
            this.label2.Text = "Transactions";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.label12.Location = new System.Drawing.Point(16, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 21);
            this.label12.TabIndex = 97;
            this.label12.Text = "Client Name";
            // 
            // cmbbxClientName
            // 
            this.cmbbxClientName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbxClientName.FormattingEnabled = true;
            this.cmbbxClientName.Location = new System.Drawing.Point(904, 63);
            this.cmbbxClientName.Name = "cmbbxClientName";
            this.cmbbxClientName.Size = new System.Drawing.Size(121, 21);
            this.cmbbxClientName.TabIndex = 96;
            // 
            // transactionDetailsControl
            // 
            this.transactionDetailsControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.transactionDetailsControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.transactionDetailsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transactionDetailsControl.Location = new System.Drawing.Point(0, 0);
            this.transactionDetailsControl.Margin = new System.Windows.Forms.Padding(0);
            this.transactionDetailsControl.Name = "transactionDetailsControl";
            this.transactionDetailsControl.Size = new System.Drawing.Size(1080, 697);
            this.transactionDetailsControl.TabIndex = 120;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.LimeGreen;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Image = global::InventoryUI.Properties.Resources.forward_left_arrow_button;
            this.btnPrevious.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrevious.Location = new System.Drawing.Point(16, 1);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(140, 40);
            this.btnPrevious.TabIndex = 119;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnTransactionAdd
            // 
            this.btnTransactionAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnTransactionAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactionAdd.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactionAdd.ForeColor = System.Drawing.Color.White;
            this.btnTransactionAdd.Image = global::InventoryUI.Properties.Resources.add;
            this.btnTransactionAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransactionAdd.Location = new System.Drawing.Point(444, 615);
            this.btnTransactionAdd.Name = "btnTransactionAdd";
            this.btnTransactionAdd.Size = new System.Drawing.Size(130, 40);
            this.btnTransactionAdd.TabIndex = 95;
            this.btnTransactionAdd.Text = "Add";
            this.btnTransactionAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTransactionAdd.UseVisualStyleBackColor = false;
            this.btnTransactionAdd.Click += new System.EventHandler(this.btnTransactionAdd_Click);
            // 
            // TransactionAddControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlTInfo);
            this.Controls.Add(this.transactionDetailsControl);
            this.Name = "TransactionAddControl";
            this.Size = new System.Drawing.Size(1080, 697);
            this.pnlTInfo.ResumeLayout(false);
            this.pnlTInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbbxClientName;
        private System.Windows.Forms.Button btnTransactionAdd;
        private System.Windows.Forms.Label lblFinishDate;
        private System.Windows.Forms.DateTimePicker dateFinish;
        private System.Windows.Forms.Label lblRefundDate;
        private System.Windows.Forms.DateTimePicker dateRefund;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateOpen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkbxRefund;
        private System.Windows.Forms.CheckBox chkbxFinished;
        private System.Windows.Forms.DateTimePicker dateTransaction;
        private System.Windows.Forms.TextBox txtbxShipping;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbxDiscount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrevious;
        private TransactionDetailsControl transactionDetailsControl;
        private System.Windows.Forms.Label lblDetailsError;
        private System.Windows.Forms.Label lblClientError;
        private System.Windows.Forms.Label lblTypeError;
    }
}
