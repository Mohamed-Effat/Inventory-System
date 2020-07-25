namespace InventoryUI
{
    partial class TransactionEditForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionEditForm));
            this.pnlTInfo = new System.Windows.Forms.Panel();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnExitHeader = new System.Windows.Forms.PictureBox();
            this.lblClientError = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnTransactionPrint = new System.Windows.Forms.Button();
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
            this.label12 = new System.Windows.Forms.Label();
            this.cmbbxClient = new System.Windows.Forms.ComboBox();
            this.btnTransactionAdd = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlTInfo.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTInfo
            // 
            this.pnlTInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.pnlTInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTInfo.Controls.Add(this.bunifuGradientPanel1);
            this.pnlTInfo.Controls.Add(this.lblClientError);
            this.pnlTInfo.Controls.Add(this.btnEdit);
            this.pnlTInfo.Controls.Add(this.btnTransactionPrint);
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
            this.pnlTInfo.Controls.Add(this.label12);
            this.pnlTInfo.Controls.Add(this.cmbbxClient);
            this.pnlTInfo.Controls.Add(this.btnTransactionAdd);
            this.pnlTInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlTInfo.Name = "pnlTInfo";
            this.pnlTInfo.Size = new System.Drawing.Size(1049, 433);
            this.pnlTInfo.TabIndex = 2;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.lblHeader);
            this.bunifuGradientPanel1.Controls.Add(this.btnExitHeader);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1045, 38);
            this.bunifuGradientPanel1.TabIndex = 133;
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHeader.Location = new System.Drawing.Point(403, 1);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(242, 33);
            this.lblHeader.TabIndex = 122;
            this.lblHeader.Text = "Transaction Edit";
            // 
            // btnExitHeader
            // 
            this.btnExitHeader.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitHeader.Image = global::InventoryUI.Properties.Resources.Close_Window_32px;
            this.btnExitHeader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExitHeader.Location = new System.Drawing.Point(1002, 6);
            this.btnExitHeader.Name = "btnExitHeader";
            this.btnExitHeader.Size = new System.Drawing.Size(32, 32);
            this.btnExitHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnExitHeader.TabIndex = 8;
            this.btnExitHeader.TabStop = false;
            this.btnExitHeader.Click += new System.EventHandler(this.btnExitHeader_Click);
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
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = global::InventoryUI.Properties.Resources.add;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(452, 381);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(144, 40);
            this.btnEdit.TabIndex = 119;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnTransactionPrint
            // 
            this.btnTransactionPrint.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTransactionPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactionPrint.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactionPrint.ForeColor = System.Drawing.Color.White;
            this.btnTransactionPrint.Image = global::InventoryUI.Properties.Resources.add;
            this.btnTransactionPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransactionPrint.Location = new System.Drawing.Point(869, 615);
            this.btnTransactionPrint.Name = "btnTransactionPrint";
            this.btnTransactionPrint.Size = new System.Drawing.Size(203, 40);
            this.btnTransactionPrint.TabIndex = 118;
            this.btnTransactionPrint.Text = "Print Recipt";
            this.btnTransactionPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTransactionPrint.UseVisualStyleBackColor = false;
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
            this.label6.ForeColor = System.Drawing.Color.White;
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
            this.label4.ForeColor = System.Drawing.Color.White;
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
            this.label5.ForeColor = System.Drawing.Color.White;
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
            this.chkbxRefund.ForeColor = System.Drawing.Color.White;
            this.chkbxRefund.Location = new System.Drawing.Point(137, 248);
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
            this.chkbxFinished.ForeColor = System.Drawing.Color.White;
            this.chkbxFinished.Location = new System.Drawing.Point(137, 310);
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(16, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 21);
            this.label12.TabIndex = 97;
            this.label12.Text = "Client Name";
            // 
            // cmbbxClient
            // 
            this.cmbbxClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbxClient.FormattingEnabled = true;
            this.cmbbxClient.Location = new System.Drawing.Point(904, 63);
            this.cmbbxClient.Name = "cmbbxClient";
            this.cmbbxClient.Size = new System.Drawing.Size(121, 21);
            this.cmbbxClient.TabIndex = 96;
            // 
            // btnTransactionAdd
            // 
            this.btnTransactionAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnTransactionAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactionAdd.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactionAdd.ForeColor = System.Drawing.Color.White;
            this.btnTransactionAdd.Image = global::InventoryUI.Properties.Resources.add;
            this.btnTransactionAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransactionAdd.Location = new System.Drawing.Point(20, 615);
            this.btnTransactionAdd.Name = "btnTransactionAdd";
            this.btnTransactionAdd.Size = new System.Drawing.Size(130, 40);
            this.btnTransactionAdd.TabIndex = 95;
            this.btnTransactionAdd.Text = "Add";
            this.btnTransactionAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTransactionAdd.UseVisualStyleBackColor = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.bunifuGradientPanel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.lblHeader;
            this.bunifuDragControl2.Vertical = true;
            // 
            // TransactionEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 433);
            this.Controls.Add(this.pnlTInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TransactionEditForm";
            this.Text = "TransactionEditForm";
            this.pnlTInfo.ResumeLayout(false);
            this.pnlTInfo.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitHeader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTInfo;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox btnExitHeader;
        private System.Windows.Forms.Label lblClientError;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnTransactionPrint;
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
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbbxClient;
        private System.Windows.Forms.Button btnTransactionAdd;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
    }
}