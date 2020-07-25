namespace InventoryUI
{
    partial class adminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminForm));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlAccount = new System.Windows.Forms.Panel();
            this.lblNotification = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlHeaderInfo = new System.Windows.Forms.Panel();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.pnlDropdownHeader = new System.Windows.Forms.Panel();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.pnlNotifications = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlMenuButtons = new System.Windows.Forms.Panel();
            this.pnlMenuHeader = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timerNotification = new System.Windows.Forms.Timer(this.components);
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.picbxDropdown = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnSetup = new System.Windows.Forms.Button();
            this.btnStocks = new System.Windows.Forms.Button();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.picbxUserImg1 = new PictureBoxAbouAmmar.صورة_دائرة();
            this.bunifuiOSSwitch1 = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.صورة_دائرة1 = new PictureBoxAbouAmmar.صورة_دائرة();
            this.pnlHeader.SuspendLayout();
            this.pnlAccount.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlHeaderInfo.SuspendLayout();
            this.pnlOptions.SuspendLayout();
            this.pnlDropdownHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlControl.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlMenuButtons.SuspendLayout();
            this.pnlMenuHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbxDropdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxUserImg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.صورة_دائرة1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.pnlHeader.Controls.Add(this.pnlAccount);
            this.pnlHeader.Controls.Add(this.label5);
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1366, 71);
            this.pnlHeader.TabIndex = 0;
            // 
            // pnlAccount
            // 
            this.pnlAccount.BackColor = System.Drawing.Color.Transparent;
            this.pnlAccount.Controls.Add(this.lblNotification);
            this.pnlAccount.Controls.Add(this.pictureBox2);
            this.pnlAccount.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlAccount.Location = new System.Drawing.Point(1041, 0);
            this.pnlAccount.Name = "pnlAccount";
            this.pnlAccount.Size = new System.Drawing.Size(325, 71);
            this.pnlAccount.TabIndex = 3;
            // 
            // lblNotification
            // 
            this.lblNotification.AutoSize = true;
            this.lblNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotification.ForeColor = System.Drawing.Color.Red;
            this.lblNotification.Location = new System.Drawing.Point(118, 25);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(44, 24);
            this.lblNotification.TabIndex = 0;
            this.lblNotification.Text = "99+";
            this.lblNotification.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(66, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(300, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "INVENTORY MANAGMENT SYSTEM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(22, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "My Account";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlHeaderInfo);
            this.pnlMain.Controls.Add(this.pnlBody);
            this.pnlMain.Controls.Add(this.pnlHeader);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1366, 768);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlHeaderInfo
            // 
            this.pnlHeaderInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeaderInfo.AutoSize = true;
            this.pnlHeaderInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlHeaderInfo.BackColor = System.Drawing.Color.Indigo;
            this.pnlHeaderInfo.Controls.Add(this.pnlOptions);
            this.pnlHeaderInfo.Controls.Add(this.pnlDropdownHeader);
            this.pnlHeaderInfo.Location = new System.Drawing.Point(1197, 25);
            this.pnlHeaderInfo.MinimumSize = new System.Drawing.Size(165, 46);
            this.pnlHeaderInfo.Name = "pnlHeaderInfo";
            this.pnlHeaderInfo.Size = new System.Drawing.Size(165, 132);
            this.pnlHeaderInfo.TabIndex = 13;
            // 
            // pnlOptions
            // 
            this.pnlOptions.AutoSize = true;
            this.pnlOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.pnlOptions.Controls.Add(this.btnSettings);
            this.pnlOptions.Controls.Add(this.btnLogout);
            this.pnlOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOptions.Location = new System.Drawing.Point(0, 46);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(165, 86);
            this.pnlOptions.TabIndex = 12;
            this.pnlOptions.Visible = false;
            // 
            // pnlDropdownHeader
            // 
            this.pnlDropdownHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.pnlDropdownHeader.Controls.Add(this.picbxDropdown);
            this.pnlDropdownHeader.Controls.Add(this.label3);
            this.pnlDropdownHeader.Controls.Add(this.pictureBox3);
            this.pnlDropdownHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDropdownHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlDropdownHeader.Name = "pnlDropdownHeader";
            this.pnlDropdownHeader.Size = new System.Drawing.Size(165, 46);
            this.pnlDropdownHeader.TabIndex = 11;
            this.pnlDropdownHeader.Click += new System.EventHandler(this.pnlDropdown_Click);
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.pnlControl);
            this.pnlBody.Controls.Add(this.pnlMenu);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 71);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1366, 697);
            this.pnlBody.TabIndex = 0;
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.pnlNotifications);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControl.Location = new System.Drawing.Point(286, 0);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(1080, 697);
            this.pnlControl.TabIndex = 4;
            this.pnlControl.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlControl_Paint);
            // 
            // pnlNotifications
            // 
            this.pnlNotifications.AutoSize = true;
            this.pnlNotifications.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlNotifications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.pnlNotifications.Location = new System.Drawing.Point(666, 0);
            this.pnlNotifications.MinimumSize = new System.Drawing.Size(245, 42);
            this.pnlNotifications.Name = "pnlNotifications";
            this.pnlNotifications.Size = new System.Drawing.Size(245, 42);
            this.pnlNotifications.TabIndex = 0;
            this.pnlNotifications.Visible = false;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.pnlMenu.Controls.Add(this.pnlMenuButtons);
            this.pnlMenu.Controls.Add(this.pnlMenuHeader);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(286, 697);
            this.pnlMenu.TabIndex = 3;
            // 
            // pnlMenuButtons
            // 
            this.pnlMenuButtons.BackColor = System.Drawing.Color.Transparent;
            this.pnlMenuButtons.Controls.Add(this.btnSetup);
            this.pnlMenuButtons.Controls.Add(this.btnStocks);
            this.pnlMenuButtons.Controls.Add(this.btnTransaction);
            this.pnlMenuButtons.Controls.Add(this.btnDashboard);
            this.pnlMenuButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenuButtons.Location = new System.Drawing.Point(0, 101);
            this.pnlMenuButtons.Name = "pnlMenuButtons";
            this.pnlMenuButtons.Size = new System.Drawing.Size(286, 596);
            this.pnlMenuButtons.TabIndex = 13;
            // 
            // pnlMenuHeader
            // 
            this.pnlMenuHeader.Controls.Add(this.label4);
            this.pnlMenuHeader.Controls.Add(this.picbxUserImg1);
            this.pnlMenuHeader.Controls.Add(this.label2);
            this.pnlMenuHeader.Controls.Add(this.bunifuiOSSwitch1);
            this.pnlMenuHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuHeader.Name = "pnlMenuHeader";
            this.pnlMenuHeader.Size = new System.Drawing.Size(286, 101);
            this.pnlMenuHeader.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(135, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "Online";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(113, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Admin";
            // 
            // timerNotification
            // 
            this.timerNotification.Enabled = true;
            this.timerNotification.Interval = 3000;
            this.timerNotification.Tick += new System.EventHandler(this.timerNotification_Tick);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe WP Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSettings.Image = global::InventoryUI.Properties.Resources.settings__1_;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 43);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(165, 43);
            this.btnSettings.TabIndex = 12;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe WP Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(165, 43);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "log out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // picbxDropdown
            // 
            this.picbxDropdown.Image = global::InventoryUI.Properties.Resources.white_down_expand_arrow_50;
            this.picbxDropdown.Location = new System.Drawing.Point(126, 9);
            this.picbxDropdown.Name = "picbxDropdown";
            this.picbxDropdown.Size = new System.Drawing.Size(21, 31);
            this.picbxDropdown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbxDropdown.TabIndex = 4;
            this.picbxDropdown.TabStop = false;
            this.picbxDropdown.Click += new System.EventHandler(this.pnlDropdown_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(86, 32);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // btnSetup
            // 
            this.btnSetup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.btnSetup.FlatAppearance.BorderSize = 0;
            this.btnSetup.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnSetup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSetup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetup.Font = new System.Drawing.Font("Segoe WP Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSetup.Image = global::InventoryUI.Properties.Resources.settings__2_;
            this.btnSetup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetup.Location = new System.Drawing.Point(0, 402);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(286, 75);
            this.btnSetup.TabIndex = 10;
            this.btnSetup.Text = "Setup";
            this.btnSetup.UseVisualStyleBackColor = true;
            this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click);
            // 
            // btnStocks
            // 
            this.btnStocks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.btnStocks.FlatAppearance.BorderSize = 0;
            this.btnStocks.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnStocks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnStocks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnStocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStocks.Font = new System.Drawing.Font("Segoe WP Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStocks.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStocks.Image = ((System.Drawing.Image)(resources.GetObject("btnStocks.Image")));
            this.btnStocks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStocks.Location = new System.Drawing.Point(-3, 301);
            this.btnStocks.Name = "btnStocks";
            this.btnStocks.Size = new System.Drawing.Size(286, 75);
            this.btnStocks.TabIndex = 8;
            this.btnStocks.Text = "Stocks";
            this.btnStocks.UseVisualStyleBackColor = true;
            this.btnStocks.Click += new System.EventHandler(this.btnStocks_Click);
            // 
            // btnTransaction
            // 
            this.btnTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.btnTransaction.FlatAppearance.BorderSize = 0;
            this.btnTransaction.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnTransaction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnTransaction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaction.Font = new System.Drawing.Font("Segoe WP Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransaction.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTransaction.Image = ((System.Drawing.Image)(resources.GetObject("btnTransaction.Image")));
            this.btnTransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransaction.Location = new System.Drawing.Point(3, 194);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(286, 75);
            this.btnTransaction.TabIndex = 7;
            this.btnTransaction.Text = "Transaction";
            this.btnTransaction.UseVisualStyleBackColor = true;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe WP Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(3, 80);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(286, 75);
            this.btnDashboard.TabIndex = 9;
            this.btnDashboard.Text = "Dashboard ";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // picbxUserImg1
            // 
            this.picbxUserImg1.BackColor = System.Drawing.Color.DarkGray;
            this.picbxUserImg1.Image = global::InventoryUI.Properties.Resources.man3;
            this.picbxUserImg1.InitialImage = global::InventoryUI.Properties.Resources.add;
            this.picbxUserImg1.Location = new System.Drawing.Point(12, 6);
            this.picbxUserImg1.Name = "picbxUserImg1";
            this.picbxUserImg1.Size = new System.Drawing.Size(80, 73);
            this.picbxUserImg1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbxUserImg1.TabIndex = 8;
            this.picbxUserImg1.TabStop = false;
            // 
            // bunifuiOSSwitch1
            // 
            this.bunifuiOSSwitch1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuiOSSwitch1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuiOSSwitch1.BackgroundImage")));
            this.bunifuiOSSwitch1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuiOSSwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuiOSSwitch1.Enabled = false;
            this.bunifuiOSSwitch1.Location = new System.Drawing.Point(94, 59);
            this.bunifuiOSSwitch1.Name = "bunifuiOSSwitch1";
            this.bunifuiOSSwitch1.OffColor = System.Drawing.Color.Gray;
            this.bunifuiOSSwitch1.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.bunifuiOSSwitch1.Size = new System.Drawing.Size(35, 20);
            this.bunifuiOSSwitch1.TabIndex = 9;
            this.bunifuiOSSwitch1.Value = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(87, 38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 39);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // صورة_دائرة1
            // 
            this.صورة_دائرة1.BackColor = System.Drawing.Color.DarkGray;
            this.صورة_دائرة1.Location = new System.Drawing.Point(0, 0);
            this.صورة_دائرة1.Name = "صورة_دائرة1";
            this.صورة_دائرة1.Size = new System.Drawing.Size(100, 50);
            this.صورة_دائرة1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.صورة_دائرة1.TabIndex = 0;
            this.صورة_دائرة1.TabStop = false;
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.pnlMain);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "adminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlAccount.ResumeLayout(false);
            this.pnlAccount.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlHeaderInfo.ResumeLayout(false);
            this.pnlHeaderInfo.PerformLayout();
            this.pnlOptions.ResumeLayout(false);
            this.pnlDropdownHeader.ResumeLayout(false);
            this.pnlDropdownHeader.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenuButtons.ResumeLayout(false);
            this.pnlMenuHeader.ResumeLayout(false);
            this.pnlMenuHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbxDropdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxUserImg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.صورة_دائرة1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private PictureBoxAbouAmmar.صورة_دائرة صورة_دائرة1;
        
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlAccount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlMenuButtons;
        private System.Windows.Forms.Button btnStocks;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.Button btnDashboard;
        private Bunifu.Framework.UI.BunifuiOSSwitch bunifuiOSSwitch1;
        private System.Windows.Forms.Label label2;
        private PictureBoxAbouAmmar.صورة_دائرة picbxUserImg1;
        private System.Windows.Forms.Panel pnlHeaderInfo;
        private System.Windows.Forms.Panel pnlDropdownHeader;
        private System.Windows.Forms.PictureBox picbxDropdown;
        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlMenuHeader;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Button btnSetup;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Timer timerNotification;
        private System.Windows.Forms.Panel pnlNotifications;
        private System.Windows.Forms.Label lblNotification;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}