namespace InventoryUI.controls
{
    partial class ProdcutsAddControl
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
            this.pnlProductInfo = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioEdit = new System.Windows.Forms.RadioButton();
            this.radioAdd = new System.Windows.Forms.RadioButton();
            this.lblColorError = new System.Windows.Forms.Label();
            this.lblBrandError = new System.Windows.Forms.Label();
            this.lblCategoryError = new System.Windows.Forms.Label();
            this.lblPriceError = new System.Windows.Forms.Label();
            this.lblBarcodeError = new System.Windows.Forms.Label();
            this.lblNameError = new System.Windows.Forms.Label();
            this.picbxProduct = new PictureBoxAbouAmmar.صورة_دائرة();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbbxColor = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbbxBrand = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbbxCategory = new System.Windows.Forms.ComboBox();
            this.btnProductAdd = new System.Windows.Forms.Button();
            this.txtbxBarcode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbxPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbxSize = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbxCapacity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gridProducts = new System.Windows.Forms.DataGridView();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlProductInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbxProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlProductInfo
            // 
            this.pnlProductInfo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlProductInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlProductInfo.Controls.Add(this.groupBox1);
            this.pnlProductInfo.Controls.Add(this.lblColorError);
            this.pnlProductInfo.Controls.Add(this.lblBrandError);
            this.pnlProductInfo.Controls.Add(this.lblCategoryError);
            this.pnlProductInfo.Controls.Add(this.lblPriceError);
            this.pnlProductInfo.Controls.Add(this.lblBarcodeError);
            this.pnlProductInfo.Controls.Add(this.lblNameError);
            this.pnlProductInfo.Controls.Add(this.picbxProduct);
            this.pnlProductInfo.Controls.Add(this.btnBrowse);
            this.pnlProductInfo.Controls.Add(this.label3);
            this.pnlProductInfo.Controls.Add(this.cmbbxColor);
            this.pnlProductInfo.Controls.Add(this.label13);
            this.pnlProductInfo.Controls.Add(this.cmbbxBrand);
            this.pnlProductInfo.Controls.Add(this.label12);
            this.pnlProductInfo.Controls.Add(this.cmbbxCategory);
            this.pnlProductInfo.Controls.Add(this.btnProductAdd);
            this.pnlProductInfo.Controls.Add(this.txtbxBarcode);
            this.pnlProductInfo.Controls.Add(this.label9);
            this.pnlProductInfo.Controls.Add(this.txtbxPrice);
            this.pnlProductInfo.Controls.Add(this.label8);
            this.pnlProductInfo.Controls.Add(this.txtbxSize);
            this.pnlProductInfo.Controls.Add(this.label6);
            this.pnlProductInfo.Controls.Add(this.txtbxCapacity);
            this.pnlProductInfo.Controls.Add(this.label5);
            this.pnlProductInfo.Controls.Add(this.label2);
            this.pnlProductInfo.Controls.Add(this.txtbxProductName);
            this.pnlProductInfo.Controls.Add(this.label1);
            this.pnlProductInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProductInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlProductInfo.Name = "pnlProductInfo";
            this.pnlProductInfo.Size = new System.Drawing.Size(1080, 697);
            this.pnlProductInfo.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioEdit);
            this.groupBox1.Controls.Add(this.radioAdd);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.groupBox1.Location = new System.Drawing.Point(6, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 109;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mode";
            // 
            // radioEdit
            // 
            this.radioEdit.AutoSize = true;
            this.radioEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.radioEdit.Location = new System.Drawing.Point(6, 65);
            this.radioEdit.Name = "radioEdit";
            this.radioEdit.Size = new System.Drawing.Size(67, 29);
            this.radioEdit.TabIndex = 1;
            this.radioEdit.Text = "Edit";
            this.radioEdit.UseVisualStyleBackColor = true;
            // 
            // radioAdd
            // 
            this.radioAdd.AutoSize = true;
            this.radioAdd.Checked = true;
            this.radioAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.radioAdd.Location = new System.Drawing.Point(6, 23);
            this.radioAdd.Name = "radioAdd";
            this.radioAdd.Size = new System.Drawing.Size(68, 29);
            this.radioAdd.TabIndex = 0;
            this.radioAdd.TabStop = true;
            this.radioAdd.Text = "Add";
            this.radioAdd.UseVisualStyleBackColor = true;
            this.radioAdd.CheckedChanged += new System.EventHandler(this.radioAdd_CheckedChanged);
            // 
            // lblColorError
            // 
            this.lblColorError.AutoSize = true;
            this.lblColorError.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblColorError.ForeColor = System.Drawing.Color.Red;
            this.lblColorError.Location = new System.Drawing.Point(447, 575);
            this.lblColorError.Name = "lblColorError";
            this.lblColorError.Size = new System.Drawing.Size(88, 21);
            this.lblColorError.TabIndex = 108;
            this.lblColorError.Text = "Required";
            this.lblColorError.Visible = false;
            // 
            // lblBrandError
            // 
            this.lblBrandError.AutoSize = true;
            this.lblBrandError.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblBrandError.ForeColor = System.Drawing.Color.Red;
            this.lblBrandError.Location = new System.Drawing.Point(447, 533);
            this.lblBrandError.Name = "lblBrandError";
            this.lblBrandError.Size = new System.Drawing.Size(88, 21);
            this.lblBrandError.TabIndex = 107;
            this.lblBrandError.Text = "Required";
            this.lblBrandError.Visible = false;
            // 
            // lblCategoryError
            // 
            this.lblCategoryError.AutoSize = true;
            this.lblCategoryError.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblCategoryError.ForeColor = System.Drawing.Color.Red;
            this.lblCategoryError.Location = new System.Drawing.Point(447, 491);
            this.lblCategoryError.Name = "lblCategoryError";
            this.lblCategoryError.Size = new System.Drawing.Size(88, 21);
            this.lblCategoryError.TabIndex = 106;
            this.lblCategoryError.Text = "Required";
            this.lblCategoryError.Visible = false;
            // 
            // lblPriceError
            // 
            this.lblPriceError.AutoSize = true;
            this.lblPriceError.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblPriceError.ForeColor = System.Drawing.Color.Red;
            this.lblPriceError.Location = new System.Drawing.Point(447, 350);
            this.lblPriceError.Name = "lblPriceError";
            this.lblPriceError.Size = new System.Drawing.Size(88, 21);
            this.lblPriceError.TabIndex = 105;
            this.lblPriceError.Text = "Required";
            this.lblPriceError.Visible = false;
            // 
            // lblBarcodeError
            // 
            this.lblBarcodeError.AutoSize = true;
            this.lblBarcodeError.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblBarcodeError.ForeColor = System.Drawing.Color.Red;
            this.lblBarcodeError.Location = new System.Drawing.Point(447, 303);
            this.lblBarcodeError.Name = "lblBarcodeError";
            this.lblBarcodeError.Size = new System.Drawing.Size(88, 21);
            this.lblBarcodeError.TabIndex = 104;
            this.lblBarcodeError.Text = "Required";
            this.lblBarcodeError.Visible = false;
            // 
            // lblNameError
            // 
            this.lblNameError.AutoSize = true;
            this.lblNameError.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblNameError.ForeColor = System.Drawing.Color.Red;
            this.lblNameError.Location = new System.Drawing.Point(447, 261);
            this.lblNameError.Name = "lblNameError";
            this.lblNameError.Size = new System.Drawing.Size(88, 21);
            this.lblNameError.TabIndex = 103;
            this.lblNameError.Text = "Required";
            this.lblNameError.Visible = false;
            // 
            // picbxProduct
            // 
            this.picbxProduct.BackColor = System.Drawing.Color.Transparent;
            this.picbxProduct.Image = global::InventoryUI.Properties.Resources.shopping_cart_6;
            this.picbxProduct.Location = new System.Drawing.Point(501, 3);
            this.picbxProduct.Name = "picbxProduct";
            this.picbxProduct.Size = new System.Drawing.Size(195, 165);
            this.picbxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbxProduct.TabIndex = 99;
            this.picbxProduct.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.BackColor = System.Drawing.Color.LimeGreen;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(672, 137);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(79, 30);
            this.btnBrowse.TabIndex = 8;
            this.btnBrowse.Text = "Browse Image";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.label3.Location = new System.Drawing.Point(21, 575);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 21);
            this.label3.TabIndex = 96;
            this.label3.Text = "Color";
            // 
            // cmbbxColor
            // 
            this.cmbbxColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbxColor.FormattingEnabled = true;
            this.cmbbxColor.Location = new System.Drawing.Point(557, 575);
            this.cmbbxColor.Name = "cmbbxColor";
            this.cmbbxColor.Size = new System.Drawing.Size(121, 21);
            this.cmbbxColor.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.label13.Location = new System.Drawing.Point(21, 533);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 21);
            this.label13.TabIndex = 94;
            this.label13.Text = "Brand";
            // 
            // cmbbxBrand
            // 
            this.cmbbxBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbxBrand.FormattingEnabled = true;
            this.cmbbxBrand.Location = new System.Drawing.Point(557, 533);
            this.cmbbxBrand.Name = "cmbbxBrand";
            this.cmbbxBrand.Size = new System.Drawing.Size(121, 21);
            this.cmbbxBrand.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.label12.Location = new System.Drawing.Point(21, 491);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 21);
            this.label12.TabIndex = 92;
            this.label12.Text = "Category";
            // 
            // cmbbxCategory
            // 
            this.cmbbxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbxCategory.FormattingEnabled = true;
            this.cmbbxCategory.Location = new System.Drawing.Point(557, 491);
            this.cmbbxCategory.Name = "cmbbxCategory";
            this.cmbbxCategory.Size = new System.Drawing.Size(121, 21);
            this.cmbbxCategory.TabIndex = 5;
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnProductAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductAdd.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductAdd.ForeColor = System.Drawing.Color.White;
            this.btnProductAdd.Image = global::InventoryUI.Properties.Resources.add;
            this.btnProductAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductAdd.Location = new System.Drawing.Point(405, 608);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(130, 40);
            this.btnProductAdd.TabIndex = 9;
            this.btnProductAdd.Text = "Add";
            this.btnProductAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductAdd.UseVisualStyleBackColor = false;
            this.btnProductAdd.Click += new System.EventHandler(this.btnProductAdd_Click);
            // 
            // txtbxBarcode
            // 
            this.txtbxBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxBarcode.Location = new System.Drawing.Point(557, 298);
            this.txtbxBarcode.Name = "txtbxBarcode";
            this.txtbxBarcode.Size = new System.Drawing.Size(194, 26);
            this.txtbxBarcode.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.label9.Location = new System.Drawing.Point(21, 303);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 21);
            this.label9.TabIndex = 87;
            this.label9.Text = "Barcode";
            // 
            // txtbxPrice
            // 
            this.txtbxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxPrice.Location = new System.Drawing.Point(557, 345);
            this.txtbxPrice.Name = "txtbxPrice";
            this.txtbxPrice.Size = new System.Drawing.Size(194, 26);
            this.txtbxPrice.TabIndex = 2;
            this.txtbxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxPrice_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.label8.Location = new System.Drawing.Point(21, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 21);
            this.label8.TabIndex = 85;
            this.label8.Text = "Selling Price";
            // 
            // txtbxSize
            // 
            this.txtbxSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxSize.Location = new System.Drawing.Point(557, 439);
            this.txtbxSize.Name = "txtbxSize";
            this.txtbxSize.Size = new System.Drawing.Size(194, 26);
            this.txtbxSize.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.label6.Location = new System.Drawing.Point(21, 444);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 21);
            this.label6.TabIndex = 81;
            this.label6.Text = "Size";
            // 
            // txtbxCapacity
            // 
            this.txtbxCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxCapacity.Location = new System.Drawing.Point(557, 392);
            this.txtbxCapacity.Name = "txtbxCapacity";
            this.txtbxCapacity.Size = new System.Drawing.Size(194, 26);
            this.txtbxCapacity.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.label5.Location = new System.Drawing.Point(21, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 21);
            this.label5.TabIndex = 79;
            this.label5.Text = "Capacity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 29);
            this.label2.TabIndex = 78;
            this.label2.Text = "Product";
            // 
            // txtbxProductName
            // 
            this.txtbxProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxProductName.Location = new System.Drawing.Point(557, 256);
            this.txtbxProductName.Name = "txtbxProductName";
            this.txtbxProductName.Size = new System.Drawing.Size(194, 26);
            this.txtbxProductName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.label1.Location = new System.Drawing.Point(21, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 76;
            this.label1.Text = "Name";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // gridProducts
            // 
            this.gridProducts.AllowUserToAddRows = false;
            this.gridProducts.AllowUserToDeleteRows = false;
            this.gridProducts.AllowUserToResizeColumns = false;
            this.gridProducts.AllowUserToResizeRows = false;
            this.gridProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProducts.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productID,
            this.productName,
            this.barcode});
            this.gridProducts.Dock = System.Windows.Forms.DockStyle.Right;
            this.gridProducts.EnableHeadersVisualStyles = false;
            this.gridProducts.Location = new System.Drawing.Point(779, 0);
            this.gridProducts.MultiSelect = false;
            this.gridProducts.Name = "gridProducts";
            this.gridProducts.RowHeadersVisible = false;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.gridProducts.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProducts.Size = new System.Drawing.Size(301, 697);
            this.gridProducts.TabIndex = 9;
            this.gridProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProducts_CellClick);
            this.gridProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProducts_CellContentClick);
            // 
            // productID
            // 
            this.productID.HeaderText = "ProductID";
            this.productID.Name = "productID";
            this.productID.ReadOnly = true;
            // 
            // productName
            // 
            this.productName.HeaderText = "Product Name";
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            // 
            // barcode
            // 
            this.barcode.HeaderText = "Barcode";
            this.barcode.Name = "barcode";
            this.barcode.ReadOnly = true;
            // 
            // ProdcutsAddControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridProducts);
            this.Controls.Add(this.pnlProductInfo);
            this.Name = "ProdcutsAddControl";
            this.Size = new System.Drawing.Size(1080, 697);
            this.pnlProductInfo.ResumeLayout(false);
            this.pnlProductInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbxProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProductInfo;
        private System.Windows.Forms.TextBox txtbxProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxBarcode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbxPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbxSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbxCapacity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProductAdd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbbxBrand;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbbxCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbbxColor;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private PictureBoxAbouAmmar.صورة_دائرة picbxProduct;
        private System.Windows.Forms.Label lblColorError;
        private System.Windows.Forms.Label lblBrandError;
        private System.Windows.Forms.Label lblCategoryError;
        private System.Windows.Forms.Label lblPriceError;
        private System.Windows.Forms.Label lblBarcodeError;
        private System.Windows.Forms.Label lblNameError;
        private System.Windows.Forms.DataGridView gridProducts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioEdit;
        private System.Windows.Forms.RadioButton radioAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcode;
    }
}
