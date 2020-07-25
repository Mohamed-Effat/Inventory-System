namespace InventoryUI.controls
{
    partial class DependenciesControl
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
            this.pnlInfo2 = new System.Windows.Forms.Panel();
            this.pnlColor = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbxColorName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlCategory = new System.Windows.Forms.Panel();
            this.txtbxCategoryName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlBrand = new System.Windows.Forms.Panel();
            this.txtbxBrandName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBrandError = new System.Windows.Forms.Label();
            this.lblCategoryError = new System.Windows.Forms.Label();
            this.lblColorError = new System.Windows.Forms.Label();
            this.btnColorAdd = new System.Windows.Forms.Button();
            this.btnCategoryAdd = new System.Windows.Forms.Button();
            this.btnBrandAdd = new System.Windows.Forms.Button();
            this.pnlInfo2.SuspendLayout();
            this.pnlColor.SuspendLayout();
            this.pnlCategory.SuspendLayout();
            this.pnlBrand.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInfo2
            // 
            this.pnlInfo2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlInfo2.Controls.Add(this.pnlColor);
            this.pnlInfo2.Controls.Add(this.pnlCategory);
            this.pnlInfo2.Controls.Add(this.pnlBrand);
            this.pnlInfo2.Location = new System.Drawing.Point(0, 0);
            this.pnlInfo2.Name = "pnlInfo2";
            this.pnlInfo2.Size = new System.Drawing.Size(946, 577);
            this.pnlInfo2.TabIndex = 123;
            this.pnlInfo2.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlInfo2_Paint);
            // 
            // pnlColor
            // 
            this.pnlColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlColor.Controls.Add(this.lblColorError);
            this.pnlColor.Controls.Add(this.label7);
            this.pnlColor.Controls.Add(this.txtbxColorName);
            this.pnlColor.Controls.Add(this.btnColorAdd);
            this.pnlColor.Controls.Add(this.label5);
            this.pnlColor.Location = new System.Drawing.Point(0, 177);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(946, 96);
            this.pnlColor.TabIndex = 121;
            this.pnlColor.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlColor_Paint);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.label7.Location = new System.Drawing.Point(1, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 24);
            this.label7.TabIndex = 99;
            this.label7.Text = "Color";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtbxColorName
            // 
            this.txtbxColorName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbxColorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxColorName.Location = new System.Drawing.Point(163, 40);
            this.txtbxColorName.Name = "txtbxColorName";
            this.txtbxColorName.Size = new System.Drawing.Size(323, 26);
            this.txtbxColorName.TabIndex = 119;
            this.txtbxColorName.TextChanged += new System.EventHandler(this.txtbxColorName_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(1, -2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 29);
            this.label5.TabIndex = 118;
            this.label5.Text = "Color Name";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pnlCategory
            // 
            this.pnlCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlCategory.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlCategory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCategory.Controls.Add(this.lblCategoryError);
            this.pnlCategory.Controls.Add(this.btnCategoryAdd);
            this.pnlCategory.Controls.Add(this.txtbxCategoryName);
            this.pnlCategory.Controls.Add(this.label2);
            this.pnlCategory.Controls.Add(this.label3);
            this.pnlCategory.Location = new System.Drawing.Point(0, 87);
            this.pnlCategory.Name = "pnlCategory";
            this.pnlCategory.Size = new System.Drawing.Size(946, 94);
            this.pnlCategory.TabIndex = 2;
            this.pnlCategory.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCategory_Paint);
            // 
            // txtbxCategoryName
            // 
            this.txtbxCategoryName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbxCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxCategoryName.Location = new System.Drawing.Point(163, 41);
            this.txtbxCategoryName.Name = "txtbxCategoryName";
            this.txtbxCategoryName.Size = new System.Drawing.Size(323, 26);
            this.txtbxCategoryName.TabIndex = 9;
            this.txtbxCategoryName.TextChanged += new System.EventHandler(this.txtbxCategoryName_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.label2.Location = new System.Drawing.Point(2, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 80;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 29);
            this.label3.TabIndex = 79;
            this.label3.Text = "Category";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // pnlBrand
            // 
            this.pnlBrand.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBrand.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlBrand.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBrand.Controls.Add(this.lblBrandError);
            this.pnlBrand.Controls.Add(this.btnBrandAdd);
            this.pnlBrand.Controls.Add(this.txtbxBrandName);
            this.pnlBrand.Controls.Add(this.label1);
            this.pnlBrand.Controls.Add(this.label4);
            this.pnlBrand.Location = new System.Drawing.Point(0, -292);
            this.pnlBrand.Name = "pnlBrand";
            this.pnlBrand.Size = new System.Drawing.Size(946, 565);
            this.pnlBrand.TabIndex = 3;
            this.pnlBrand.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBrand_Paint);
            // 
            // txtbxBrandName
            // 
            this.txtbxBrandName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbxBrandName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxBrandName.Location = new System.Drawing.Point(163, 327);
            this.txtbxBrandName.Name = "txtbxBrandName";
            this.txtbxBrandName.Size = new System.Drawing.Size(323, 26);
            this.txtbxBrandName.TabIndex = 11;
            this.txtbxBrandName.TextChanged += new System.EventHandler(this.txtbxBrandName_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.label1.Location = new System.Drawing.Point(13, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 82;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(0, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 29);
            this.label4.TabIndex = 80;
            this.label4.Text = "Brand";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblBrandError
            // 
            this.lblBrandError.AutoSize = true;
            this.lblBrandError.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblBrandError.ForeColor = System.Drawing.Color.Red;
            this.lblBrandError.Location = new System.Drawing.Point(542, 327);
            this.lblBrandError.Name = "lblBrandError";
            this.lblBrandError.Size = new System.Drawing.Size(88, 21);
            this.lblBrandError.TabIndex = 106;
            this.lblBrandError.Text = "Required";
            this.lblBrandError.Visible = false;
            // 
            // lblCategoryError
            // 
            this.lblCategoryError.AutoSize = true;
            this.lblCategoryError.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblCategoryError.ForeColor = System.Drawing.Color.Red;
            this.lblCategoryError.Location = new System.Drawing.Point(542, 33);
            this.lblCategoryError.Name = "lblCategoryError";
            this.lblCategoryError.Size = new System.Drawing.Size(88, 21);
            this.lblCategoryError.TabIndex = 107;
            this.lblCategoryError.Text = "Required";
            this.lblCategoryError.Visible = false;
            // 
            // lblColorError
            // 
            this.lblColorError.AutoSize = true;
            this.lblColorError.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblColorError.ForeColor = System.Drawing.Color.Red;
            this.lblColorError.Location = new System.Drawing.Point(542, 40);
            this.lblColorError.Name = "lblColorError";
            this.lblColorError.Size = new System.Drawing.Size(88, 21);
            this.lblColorError.TabIndex = 108;
            this.lblColorError.Text = "Required";
            this.lblColorError.Visible = false;
            // 
            // btnColorAdd
            // 
            this.btnColorAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnColorAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnColorAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColorAdd.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColorAdd.ForeColor = System.Drawing.Color.White;
            this.btnColorAdd.Image = global::InventoryUI.Properties.Resources.add;
            this.btnColorAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnColorAdd.Location = new System.Drawing.Point(795, 25);
            this.btnColorAdd.Name = "btnColorAdd";
            this.btnColorAdd.Size = new System.Drawing.Size(123, 41);
            this.btnColorAdd.TabIndex = 120;
            this.btnColorAdd.Text = "Add";
            this.btnColorAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnColorAdd.UseVisualStyleBackColor = false;
            this.btnColorAdd.Click += new System.EventHandler(this.btnColorAdd_Click);
            // 
            // btnCategoryAdd
            // 
            this.btnCategoryAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCategoryAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCategoryAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoryAdd.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoryAdd.ForeColor = System.Drawing.Color.White;
            this.btnCategoryAdd.Image = global::InventoryUI.Properties.Resources.add;
            this.btnCategoryAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategoryAdd.Location = new System.Drawing.Point(795, 33);
            this.btnCategoryAdd.Name = "btnCategoryAdd";
            this.btnCategoryAdd.Size = new System.Drawing.Size(123, 41);
            this.btnCategoryAdd.TabIndex = 10;
            this.btnCategoryAdd.Text = "Add";
            this.btnCategoryAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCategoryAdd.UseVisualStyleBackColor = false;
            this.btnCategoryAdd.Click += new System.EventHandler(this.btnCategoryAdd_Click);
            // 
            // btnBrandAdd
            // 
            this.btnBrandAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBrandAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnBrandAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrandAdd.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrandAdd.ForeColor = System.Drawing.Color.White;
            this.btnBrandAdd.Image = global::InventoryUI.Properties.Resources.add;
            this.btnBrandAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrandAdd.Location = new System.Drawing.Point(795, 319);
            this.btnBrandAdd.Name = "btnBrandAdd";
            this.btnBrandAdd.Size = new System.Drawing.Size(123, 41);
            this.btnBrandAdd.TabIndex = 12;
            this.btnBrandAdd.Text = "Add";
            this.btnBrandAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBrandAdd.UseVisualStyleBackColor = false;
            this.btnBrandAdd.Click += new System.EventHandler(this.btnBrandAdd_Click);
            // 
            // DependenciesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlInfo2);
            this.Name = "DependenciesControl";
            this.Size = new System.Drawing.Size(946, 577);
            this.pnlInfo2.ResumeLayout(false);
            this.pnlColor.ResumeLayout(false);
            this.pnlColor.PerformLayout();
            this.pnlCategory.ResumeLayout(false);
            this.pnlCategory.PerformLayout();
            this.pnlBrand.ResumeLayout(false);
            this.pnlBrand.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInfo2;
        private System.Windows.Forms.Panel pnlCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrandAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbxBrandName;
        private System.Windows.Forms.Button btnColorAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCategoryAdd;
        private System.Windows.Forms.TextBox txtbxColorName;
        private System.Windows.Forms.TextBox txtbxCategoryName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlColor;
        private System.Windows.Forms.Panel pnlBrand;
        private System.Windows.Forms.Label lblColorError;
        private System.Windows.Forms.Label lblCategoryError;
        private System.Windows.Forms.Label lblBrandError;
    }
}
