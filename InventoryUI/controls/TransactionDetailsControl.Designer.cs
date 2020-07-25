namespace InventoryUI.controls
{
    partial class TransactionDetailsControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlProducts = new System.Windows.Forms.Panel();
            this.gridStock = new System.Windows.Forms.DataGridView();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCategoty = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.pnlReceipt = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.gridReceipt = new System.Windows.Forms.DataGridView();
            this.pnlReceiptHeader = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbbxType = new System.Windows.Forms.ComboBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridReceiptID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridReceiptName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridReceiptPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridReceiptAvailableQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridReceiptQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridReceiptDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridReceiptShippingCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridReceiptRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridStock)).BeginInit();
            this.pnlInfo.SuspendLayout();
            this.pnlReceipt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridReceipt)).BeginInit();
            this.pnlReceiptHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlProducts
            // 
            this.pnlProducts.BackColor = System.Drawing.Color.White;
            this.pnlProducts.Controls.Add(this.gridStock);
            this.pnlProducts.Controls.Add(this.pnlInfo);
            this.pnlProducts.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlProducts.Location = new System.Drawing.Point(0, 0);
            this.pnlProducts.Name = "pnlProducts";
            this.pnlProducts.Size = new System.Drawing.Size(587, 697);
            this.pnlProducts.TabIndex = 0;
            // 
            // gridStock
            // 
            this.gridStock.AllowUserToAddRows = false;
            this.gridStock.AllowUserToDeleteRows = false;
            this.gridStock.AllowUserToResizeColumns = false;
            this.gridStock.AllowUserToResizeRows = false;
            this.gridStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridStock.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productID,
            this.barcode,
            this.productName,
            this.ProductQuantity,
            this.sellingPrice,
            this.size,
            this.capacity,
            this.ColorName,
            this.CategoryName,
            this.BrandName});
            this.gridStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridStock.EnableHeadersVisualStyles = false;
            this.gridStock.Location = new System.Drawing.Point(0, 101);
            this.gridStock.MultiSelect = false;
            this.gridStock.Name = "gridStock";
            this.gridStock.ReadOnly = true;
            this.gridStock.RowHeadersVisible = false;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.gridStock.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridStock.Size = new System.Drawing.Size(587, 596);
            this.gridStock.TabIndex = 9;
            this.gridStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridStock_CellClick);
            this.gridStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridStock_CellContentClick_1);
            // 
            // pnlInfo
            // 
            this.pnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlInfo.Controls.Add(this.cmbBrand);
            this.pnlInfo.Controls.Add(this.label4);
            this.pnlInfo.Controls.Add(this.cmbCategoty);
            this.pnlInfo.Controls.Add(this.label3);
            this.pnlInfo.Controls.Add(this.txtBarcode);
            this.pnlInfo.Controls.Add(this.label2);
            this.pnlInfo.Controls.Add(this.label1);
            this.pnlInfo.Controls.Add(this.txtProductName);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(587, 101);
            this.pnlInfo.TabIndex = 6;
            this.pnlInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlInfo_Paint);
            // 
            // cmbBrand
            // 
            this.cmbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Location = new System.Drawing.Point(431, 22);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(147, 21);
            this.cmbBrand.TabIndex = 8;
            this.cmbBrand.SelectionChangeCommitted += new System.EventHandler(this.cmbBrand_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.label4.Location = new System.Drawing.Point(326, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Brand ";
            // 
            // cmbCategoty
            // 
            this.cmbCategoty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoty.FormattingEnabled = true;
            this.cmbCategoty.Location = new System.Drawing.Point(431, 69);
            this.cmbCategoty.Name = "cmbCategoty";
            this.cmbCategoty.Size = new System.Drawing.Size(147, 21);
            this.cmbCategoty.TabIndex = 5;
            this.cmbCategoty.SelectionChangeCommitted += new System.EventHandler(this.cmbBrand_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.label3.Location = new System.Drawing.Point(326, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Category";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(152, 23);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(150, 20);
            this.txtBarcode.TabIndex = 3;
            this.txtBarcode.TextChanged += new System.EventHandler(this.cmbBrand_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Barcode";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(152, 70);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(150, 20);
            this.txtProductName.TabIndex = 0;
            this.txtProductName.TextChanged += new System.EventHandler(this.cmbBrand_SelectionChangeCommitted);
            // 
            // pnlReceipt
            // 
            this.pnlReceipt.BackColor = System.Drawing.Color.White;
            this.pnlReceipt.Controls.Add(this.btnNext);
            this.pnlReceipt.Controls.Add(this.gridReceipt);
            this.pnlReceipt.Controls.Add(this.pnlReceiptHeader);
            this.pnlReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReceipt.Location = new System.Drawing.Point(587, 0);
            this.pnlReceipt.Name = "pnlReceipt";
            this.pnlReceipt.Size = new System.Drawing.Size(493, 697);
            this.pnlReceipt.TabIndex = 1;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.LimeGreen;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Image = global::InventoryUI.Properties.Resources.forward_right_arrow_button;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.Location = new System.Drawing.Point(367, 657);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(123, 40);
            this.btnNext.TabIndex = 121;
            this.btnNext.Text = "Next";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // gridReceipt
            // 
            this.gridReceipt.AllowUserToAddRows = false;
            this.gridReceipt.AllowUserToDeleteRows = false;
            this.gridReceipt.AllowUserToResizeColumns = false;
            this.gridReceipt.AllowUserToResizeRows = false;
            this.gridReceipt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridReceipt.BackgroundColor = System.Drawing.Color.White;
            this.gridReceipt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridReceipt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridReceipt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GridReceiptID,
            this.GridReceiptName,
            this.GridReceiptPrice,
            this.gridReceiptAvailableQuantity,
            this.GridReceiptQuantity,
            this.GridReceiptDiscount,
            this.GridReceiptShippingCost,
            this.GridReceiptRemove});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridReceipt.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridReceipt.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gridReceipt.EnableHeadersVisualStyles = false;
            this.gridReceipt.Location = new System.Drawing.Point(0, 45);
            this.gridReceipt.MultiSelect = false;
            this.gridReceipt.Name = "gridReceipt";
            this.gridReceipt.RowHeadersVisible = false;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.gridReceipt.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gridReceipt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridReceipt.Size = new System.Drawing.Size(493, 652);
            this.gridReceipt.TabIndex = 7;
            this.gridReceipt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridReceipt_CellClick);
            this.gridReceipt.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.gridReceipt_CellPainting);
            // 
            // pnlReceiptHeader
            // 
            this.pnlReceiptHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlReceiptHeader.Controls.Add(this.label5);
            this.pnlReceiptHeader.Controls.Add(this.cmbbxType);
            this.pnlReceiptHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReceiptHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlReceiptHeader.Name = "pnlReceiptHeader";
            this.pnlReceiptHeader.Size = new System.Drawing.Size(493, 45);
            this.pnlReceiptHeader.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(4, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 21);
            this.label5.TabIndex = 102;
            this.label5.Text = "Transaction Type";
            // 
            // cmbbxType
            // 
            this.cmbbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbxType.FormattingEnabled = true;
            this.cmbbxType.Location = new System.Drawing.Point(365, 12);
            this.cmbbxType.Name = "cmbbxType";
            this.cmbbxType.Size = new System.Drawing.Size(121, 21);
            this.cmbbxType.TabIndex = 101;
            this.cmbbxType.SelectedIndexChanged += new System.EventHandler(this.cmbbxType_SelectedIndexChanged);
            this.cmbbxType.SelectionChangeCommitted += new System.EventHandler(this.cmbbxType_SelectionChangeCommitted);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlReceipt);
            this.pnlMain.Controls.Add(this.pnlProducts);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1080, 697);
            this.pnlMain.TabIndex = 8;
            // 
            // productID
            // 
            this.productID.HeaderText = "Product ID";
            this.productID.Name = "productID";
            this.productID.ReadOnly = true;
            this.productID.Width = 96;
            // 
            // barcode
            // 
            this.barcode.HeaderText = "Barcode";
            this.barcode.Name = "barcode";
            this.barcode.ReadOnly = true;
            this.barcode.Width = 92;
            // 
            // productName
            // 
            this.productName.HeaderText = "Product Name";
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            this.productName.Width = 120;
            // 
            // ProductQuantity
            // 
            this.ProductQuantity.HeaderText = "Quantity";
            this.ProductQuantity.Name = "ProductQuantity";
            this.ProductQuantity.ReadOnly = true;
            this.ProductQuantity.Width = 89;
            // 
            // sellingPrice
            // 
            this.sellingPrice.HeaderText = "Selling Price";
            this.sellingPrice.Name = "sellingPrice";
            this.sellingPrice.ReadOnly = true;
            this.sellingPrice.Width = 111;
            // 
            // size
            // 
            this.size.HeaderText = "Size";
            this.size.Name = "size";
            this.size.ReadOnly = true;
            this.size.Width = 63;
            // 
            // capacity
            // 
            this.capacity.HeaderText = "Capacity";
            this.capacity.Name = "capacity";
            this.capacity.ReadOnly = true;
            this.capacity.Width = 94;
            // 
            // ColorName
            // 
            this.ColorName.HeaderText = "ColorName";
            this.ColorName.Name = "ColorName";
            this.ColorName.ReadOnly = true;
            this.ColorName.Width = 111;
            // 
            // CategoryName
            // 
            this.CategoryName.HeaderText = "CategoryName";
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            this.CategoryName.Width = 137;
            // 
            // BrandName
            // 
            this.BrandName.HeaderText = "BrandName";
            this.BrandName.Name = "BrandName";
            this.BrandName.ReadOnly = true;
            this.BrandName.Width = 115;
            // 
            // GridReceiptID
            // 
            this.GridReceiptID.HeaderText = "Product ID";
            this.GridReceiptID.Name = "GridReceiptID";
            this.GridReceiptID.ReadOnly = true;
            // 
            // GridReceiptName
            // 
            this.GridReceiptName.HeaderText = "Product Name";
            this.GridReceiptName.Name = "GridReceiptName";
            this.GridReceiptName.ReadOnly = true;
            // 
            // GridReceiptPrice
            // 
            this.GridReceiptPrice.HeaderText = "Price";
            this.GridReceiptPrice.Name = "GridReceiptPrice";
            // 
            // gridReceiptAvailableQuantity
            // 
            this.gridReceiptAvailableQuantity.HeaderText = "AvailableQuantity";
            this.gridReceiptAvailableQuantity.Name = "gridReceiptAvailableQuantity";
            this.gridReceiptAvailableQuantity.Visible = false;
            // 
            // GridReceiptQuantity
            // 
            this.GridReceiptQuantity.HeaderText = "Quantity";
            this.GridReceiptQuantity.Name = "GridReceiptQuantity";
            // 
            // GridReceiptDiscount
            // 
            this.GridReceiptDiscount.HeaderText = "Discount";
            this.GridReceiptDiscount.Name = "GridReceiptDiscount";
            // 
            // GridReceiptShippingCost
            // 
            this.GridReceiptShippingCost.HeaderText = "Shipping Cost";
            this.GridReceiptShippingCost.Name = "GridReceiptShippingCost";
            // 
            // GridReceiptRemove
            // 
            this.GridReceiptRemove.HeaderText = "Remove";
            this.GridReceiptRemove.Name = "GridReceiptRemove";
            // 
            // TransactionDetailsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.pnlMain);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TransactionDetailsControl";
            this.Size = new System.Drawing.Size(1080, 697);
            this.VisibleChanged += new System.EventHandler(this.TransactionDetailsControl_VisibleChanged);
            this.pnlProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridStock)).EndInit();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.pnlReceipt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridReceipt)).EndInit();
            this.pnlReceiptHeader.ResumeLayout(false);
            this.pnlReceiptHeader.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProducts;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCategoty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Panel pnlReceipt;
        private System.Windows.Forms.DataGridView gridReceipt;
        private System.Windows.Forms.Panel pnlReceiptHeader;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnNext;
        public System.Windows.Forms.DataGridView gridStock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbbxType;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridReceiptID;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridReceiptName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridReceiptPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridReceiptAvailableQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridReceiptQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridReceiptDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridReceiptShippingCost;
        private System.Windows.Forms.DataGridViewButtonColumn GridReceiptRemove;

    }
}
