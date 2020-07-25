namespace InventoryUI
{
    partial class NotificationMessageControl
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
            this.btnMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMessage
            // 
            this.btnMessage.BackColor = System.Drawing.Color.Transparent;
            this.btnMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMessage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnMessage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMessage.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMessage.ForeColor = System.Drawing.Color.White;
            this.btnMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMessage.Location = new System.Drawing.Point(0, 0);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(245, 42);
            this.btnMessage.TabIndex = 5;
            this.btnMessage.Text = "Warning: Product padfj Quantity is 5";
            this.btnMessage.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnMessage.UseVisualStyleBackColor = false;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // NotificationMessageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.btnMessage);
            this.Name = "NotificationMessageControl";
            this.Size = new System.Drawing.Size(245, 42);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMessage;

    }
}
