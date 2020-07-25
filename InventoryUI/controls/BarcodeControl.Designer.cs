namespace InventoryUI.controls
{
    partial class BarcodeControl
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
            this.txtbxEncode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxDecode = new System.Windows.Forms.TextBox();
            this.picbxBarcode = new System.Windows.Forms.PictureBox();
            this.btnEncode = new System.Windows.Forms.Button();
            this.btnDecode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbxBarcode)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbxEncode
            // 
            this.txtbxEncode.Location = new System.Drawing.Point(232, 225);
            this.txtbxEncode.Name = "txtbxEncode";
            this.txtbxEncode.Size = new System.Drawing.Size(159, 20);
            this.txtbxEncode.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Encode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Decode";
            // 
            // txtbxDecode
            // 
            this.txtbxDecode.Location = new System.Drawing.Point(232, 277);
            this.txtbxDecode.Name = "txtbxDecode";
            this.txtbxDecode.Size = new System.Drawing.Size(159, 20);
            this.txtbxDecode.TabIndex = 2;
            // 
            // picbxBarcode
            // 
            this.picbxBarcode.Location = new System.Drawing.Point(99, 33);
            this.picbxBarcode.Name = "picbxBarcode";
            this.picbxBarcode.Size = new System.Drawing.Size(301, 134);
            this.picbxBarcode.TabIndex = 4;
            this.picbxBarcode.TabStop = false;
            // 
            // btnEncode
            // 
            this.btnEncode.Location = new System.Drawing.Point(140, 325);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(75, 23);
            this.btnEncode.TabIndex = 5;
            this.btnEncode.Text = "Encode";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // btnDecode
            // 
            this.btnDecode.Location = new System.Drawing.Point(280, 325);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(75, 23);
            this.btnDecode.TabIndex = 6;
            this.btnDecode.Text = "Decode";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // BarcodeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.btnEncode);
            this.Controls.Add(this.picbxBarcode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbxDecode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbxEncode);
            this.Name = "BarcodeControl";
            this.Size = new System.Drawing.Size(611, 375);
            ((System.ComponentModel.ISupportInitialize)(this.picbxBarcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxEncode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbxDecode;
        private System.Windows.Forms.PictureBox picbxBarcode;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.Button btnDecode;
    }
}
