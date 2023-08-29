namespace StockifyJa
{
    partial class FrmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            this.LoginTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlMenuIcon = new System.Windows.Forms.Panel();
            this.lblMenu = new System.Windows.Forms.Label();
            this.picMenuIcon = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlUserInfo = new System.Windows.Forms.Panel();
            this.lblUsertext = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.pnlLogOut = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SideBartimer = new System.Windows.Forms.Timer(this.components);
            this.picSettings = new System.Windows.Forms.PictureBox();
            this.btnChat = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnManageSupplies = new System.Windows.Forms.Button();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnManageOrders = new System.Windows.Forms.Button();
            this.btnManageProducts = new System.Windows.Forms.Button();
            this.pnlManageUsers = new System.Windows.Forms.Panel();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.pnlFormLoader = new System.Windows.Forms.Panel();
            this.pnlManageProducts = new System.Windows.Forms.Panel();
            this.pnlManageOrders = new System.Windows.Forms.Panel();
            this.pnlManageSupplies = new System.Windows.Forms.Panel();
            this.pnlReports = new System.Windows.Forms.Panel();
            this.pnlChat = new System.Windows.Forms.Panel();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.flSideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlMenuIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuIcon)).BeginInit();
            this.pnlUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.pnlLogOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSettings)).BeginInit();
            this.pnlHome.SuspendLayout();
            this.pnlManageUsers.SuspendLayout();
            this.pnlManageProducts.SuspendLayout();
            this.pnlManageOrders.SuspendLayout();
            this.pnlManageSupplies.SuspendLayout();
            this.pnlReports.SuspendLayout();
            this.pnlChat.SuspendLayout();
            this.pnlSettings.SuspendLayout();
            this.flSideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginTimer
            // 
            this.LoginTimer.Tick += new System.EventHandler(this.LoginTimer_Tick);
            // 
            // pnlMenuIcon
            // 
            this.pnlMenuIcon.Controls.Add(this.lblMenu);
            this.pnlMenuIcon.Controls.Add(this.picMenuIcon);
            this.pnlMenuIcon.Location = new System.Drawing.Point(3, 3);
            this.pnlMenuIcon.Name = "pnlMenuIcon";
            this.pnlMenuIcon.Size = new System.Drawing.Size(197, 51);
            this.pnlMenuIcon.TabIndex = 0;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(69, 25);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(51, 19);
            this.lblMenu.TabIndex = 1;
            this.lblMenu.Text = "Menu";
            // 
            // picMenuIcon
            // 
            this.picMenuIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMenuIcon.Image = ((System.Drawing.Image)(resources.GetObject("picMenuIcon.Image")));
            this.picMenuIcon.Location = new System.Drawing.Point(36, 21);
            this.picMenuIcon.Name = "picMenuIcon";
            this.picMenuIcon.Size = new System.Drawing.Size(27, 24);
            this.picMenuIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMenuIcon.TabIndex = 0;
            this.picMenuIcon.TabStop = false;
            this.picMenuIcon.Click += new System.EventHandler(this.picMenuIcon_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.Location = new System.Drawing.Point(944, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(78, 38);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Title";
            // 
            // pnlUserInfo
            // 
            this.pnlUserInfo.Controls.Add(this.lblUsertext);
            this.pnlUserInfo.Controls.Add(this.lblUsername);
            this.pnlUserInfo.Controls.Add(this.picUser);
            this.pnlUserInfo.Controls.Add(this.pnlLogOut);
            this.pnlUserInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUserInfo.Location = new System.Drawing.Point(3, 60);
            this.pnlUserInfo.Name = "pnlUserInfo";
            this.pnlUserInfo.Size = new System.Drawing.Size(197, 188);
            this.pnlUserInfo.TabIndex = 4;
            // 
            // lblUsertext
            // 
            this.lblUsertext.AutoSize = true;
            this.lblUsertext.Location = new System.Drawing.Point(65, 114);
            this.lblUsertext.Name = "lblUsertext";
            this.lblUsertext.Size = new System.Drawing.Size(59, 16);
            this.lblUsertext.TabIndex = 2;
            this.lblUsertext.Text = "User text";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(65, 80);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(76, 16);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "  Username";
            // 
            // picUser
            // 
            this.picUser.Image = ((System.Drawing.Image)(resources.GetObject("picUser.Image")));
            this.picUser.Location = new System.Drawing.Point(73, 3);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(62, 58);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUser.TabIndex = 0;
            this.picUser.TabStop = false;
            // 
            // pnlLogOut
            // 
            this.pnlLogOut.Controls.Add(this.btnLogout);
            this.pnlLogOut.Location = new System.Drawing.Point(1, 143);
            this.pnlLogOut.Name = "pnlLogOut";
            this.pnlLogOut.Size = new System.Drawing.Size(197, 42);
            this.pnlLogOut.TabIndex = 3;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(193, 42);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "   Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // SideBartimer
            // 
            this.SideBartimer.Interval = 10;
            this.SideBartimer.Tick += new System.EventHandler(this.SideBartimer_Tick);
            // 
            // picSettings
            // 
            this.picSettings.Image = ((System.Drawing.Image)(resources.GetObject("picSettings.Image")));
            this.picSettings.Location = new System.Drawing.Point(27, 6);
            this.picSettings.Name = "picSettings";
            this.picSettings.Size = new System.Drawing.Size(36, 33);
            this.picSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSettings.TabIndex = 6;
            this.picSettings.TabStop = false;
            this.picSettings.Click += new System.EventHandler(this.picSettings_Click);
            // 
            // btnChat
            // 
            this.btnChat.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnChat.FlatAppearance.BorderSize = 0;
            this.btnChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChat.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChat.Image = ((System.Drawing.Image)(resources.GetObject("btnChat.Image")));
            this.btnChat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChat.Location = new System.Drawing.Point(0, 0);
            this.btnChat.Name = "btnChat";
            this.btnChat.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnChat.Size = new System.Drawing.Size(192, 42);
            this.btnChat.TabIndex = 0;
            this.btnChat.Text = "   Chat";
            this.btnChat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChat.UseVisualStyleBackColor = true;
            this.btnChat.Click += new System.EventHandler(this.btnChat_Click);
            // 
            // btnReports
            // 
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Image = ((System.Drawing.Image)(resources.GetObject("btnReports.Image")));
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(0, 0);
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnReports.Size = new System.Drawing.Size(192, 42);
            this.btnReports.TabIndex = 0;
            this.btnReports.Text = "  Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnManageSupplies
            // 
            this.btnManageSupplies.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnManageSupplies.FlatAppearance.BorderSize = 0;
            this.btnManageSupplies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageSupplies.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageSupplies.Image = ((System.Drawing.Image)(resources.GetObject("btnManageSupplies.Image")));
            this.btnManageSupplies.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageSupplies.Location = new System.Drawing.Point(0, 0);
            this.btnManageSupplies.Name = "btnManageSupplies";
            this.btnManageSupplies.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnManageSupplies.Size = new System.Drawing.Size(236, 42);
            this.btnManageSupplies.TabIndex = 0;
            this.btnManageSupplies.Text = "   Manage Supplies";
            this.btnManageSupplies.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageSupplies.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageSupplies.UseVisualStyleBackColor = true;
            this.btnManageSupplies.Click += new System.EventHandler(this.btnManageSupplies_Click);
            // 
            // pnlHome
            // 
            this.pnlHome.Controls.Add(this.btnHome);
            this.pnlHome.Controls.Add(this.pnlNav);
            this.pnlHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHome.Location = new System.Drawing.Point(3, 254);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(197, 42);
            this.pnlHome.TabIndex = 1;
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(192, 42);
            this.btnHome.TabIndex = 6;
            this.btnHome.Text = "  Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.SystemColors.Desktop;
            this.pnlNav.Location = new System.Drawing.Point(0, 0);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(10, 253);
            this.pnlNav.TabIndex = 5;
            // 
            // btnManageOrders
            // 
            this.btnManageOrders.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnManageOrders.FlatAppearance.BorderSize = 0;
            this.btnManageOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageOrders.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageOrders.Image = ((System.Drawing.Image)(resources.GetObject("btnManageOrders.Image")));
            this.btnManageOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageOrders.Location = new System.Drawing.Point(0, 0);
            this.btnManageOrders.Name = "btnManageOrders";
            this.btnManageOrders.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnManageOrders.Size = new System.Drawing.Size(220, 42);
            this.btnManageOrders.TabIndex = 0;
            this.btnManageOrders.Text = "  Manage Orders";
            this.btnManageOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageOrders.UseVisualStyleBackColor = true;
            this.btnManageOrders.Click += new System.EventHandler(this.btnManageOrders_Click);
            // 
            // btnManageProducts
            // 
            this.btnManageProducts.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnManageProducts.FlatAppearance.BorderSize = 0;
            this.btnManageProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageProducts.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageProducts.Image = ((System.Drawing.Image)(resources.GetObject("btnManageProducts.Image")));
            this.btnManageProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageProducts.Location = new System.Drawing.Point(0, 0);
            this.btnManageProducts.Name = "btnManageProducts";
            this.btnManageProducts.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnManageProducts.Size = new System.Drawing.Size(220, 42);
            this.btnManageProducts.TabIndex = 0;
            this.btnManageProducts.Text = " Manage Products";
            this.btnManageProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageProducts.UseVisualStyleBackColor = true;
            this.btnManageProducts.Click += new System.EventHandler(this.btnManageProducts_Click);
            // 
            // pnlManageUsers
            // 
            this.pnlManageUsers.Controls.Add(this.btnManageUsers);
            this.pnlManageUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlManageUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlManageUsers.Location = new System.Drawing.Point(3, 302);
            this.pnlManageUsers.Name = "pnlManageUsers";
            this.pnlManageUsers.Size = new System.Drawing.Size(197, 42);
            this.pnlManageUsers.TabIndex = 2;
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnManageUsers.FlatAppearance.BorderSize = 0;
            this.btnManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageUsers.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnManageUsers.Image")));
            this.btnManageUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageUsers.Location = new System.Drawing.Point(0, 0);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnManageUsers.Size = new System.Drawing.Size(192, 42);
            this.btnManageUsers.TabIndex = 0;
            this.btnManageUsers.Text = "  Manage Users";
            this.btnManageUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageUsers.UseVisualStyleBackColor = true;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // pnlFormLoader
            // 
            this.pnlFormLoader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.pnlFormLoader.Location = new System.Drawing.Point(357, 82);
            this.pnlFormLoader.Name = "pnlFormLoader";
            this.pnlFormLoader.Size = new System.Drawing.Size(1453, 690);
            this.pnlFormLoader.TabIndex = 12;
            this.pnlFormLoader.SizeChanged += new System.EventHandler(this.pnlFormLoader_SizeChanged);
            // 
            // pnlManageProducts
            // 
            this.pnlManageProducts.Controls.Add(this.btnManageProducts);
            this.pnlManageProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlManageProducts.Location = new System.Drawing.Point(3, 350);
            this.pnlManageProducts.Name = "pnlManageProducts";
            this.pnlManageProducts.Size = new System.Drawing.Size(197, 42);
            this.pnlManageProducts.TabIndex = 2;
            // 
            // pnlManageOrders
            // 
            this.pnlManageOrders.Controls.Add(this.btnManageOrders);
            this.pnlManageOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlManageOrders.Location = new System.Drawing.Point(3, 398);
            this.pnlManageOrders.Name = "pnlManageOrders";
            this.pnlManageOrders.Size = new System.Drawing.Size(197, 42);
            this.pnlManageOrders.TabIndex = 2;
            // 
            // pnlManageSupplies
            // 
            this.pnlManageSupplies.Controls.Add(this.btnManageSupplies);
            this.pnlManageSupplies.Location = new System.Drawing.Point(3, 446);
            this.pnlManageSupplies.Name = "pnlManageSupplies";
            this.pnlManageSupplies.Size = new System.Drawing.Size(220, 42);
            this.pnlManageSupplies.TabIndex = 5;
            // 
            // pnlReports
            // 
            this.pnlReports.Controls.Add(this.btnReports);
            this.pnlReports.Location = new System.Drawing.Point(3, 494);
            this.pnlReports.Name = "pnlReports";
            this.pnlReports.Size = new System.Drawing.Size(197, 42);
            this.pnlReports.TabIndex = 6;
            // 
            // pnlChat
            // 
            this.pnlChat.Controls.Add(this.btnChat);
            this.pnlChat.Location = new System.Drawing.Point(3, 542);
            this.pnlChat.Name = "pnlChat";
            this.pnlChat.Size = new System.Drawing.Size(197, 42);
            this.pnlChat.TabIndex = 7;
            // 
            // pnlSettings
            // 
            this.pnlSettings.Controls.Add(this.picSettings);
            this.pnlSettings.Location = new System.Drawing.Point(3, 590);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(197, 42);
            this.pnlSettings.TabIndex = 4;
            // 
            // flSideBar
            // 
            this.flSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.flSideBar.Controls.Add(this.pnlMenuIcon);
            this.flSideBar.Controls.Add(this.pnlUserInfo);
            this.flSideBar.Controls.Add(this.pnlHome);
            this.flSideBar.Controls.Add(this.pnlManageUsers);
            this.flSideBar.Controls.Add(this.pnlManageProducts);
            this.flSideBar.Controls.Add(this.pnlManageOrders);
            this.flSideBar.Controls.Add(this.pnlManageSupplies);
            this.flSideBar.Controls.Add(this.pnlReports);
            this.flSideBar.Controls.Add(this.pnlChat);
            this.flSideBar.Controls.Add(this.pnlSettings);
            this.flSideBar.Location = new System.Drawing.Point(1, 19);
            this.flSideBar.MaximumSize = new System.Drawing.Size(260, 1000);
            this.flSideBar.MinimumSize = new System.Drawing.Size(78, 700);
            this.flSideBar.Name = "flSideBar";
            this.flSideBar.Size = new System.Drawing.Size(210, 736);
            this.flSideBar.TabIndex = 9;
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1836, 897);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlFormLoader);
            this.Controls.Add(this.flSideBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FrmAdmin";
            this.Text = "Administrator";
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.pnlMenuIcon.ResumeLayout(false);
            this.pnlMenuIcon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuIcon)).EndInit();
            this.pnlUserInfo.ResumeLayout(false);
            this.pnlUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.pnlLogOut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSettings)).EndInit();
            this.pnlHome.ResumeLayout(false);
            this.pnlManageUsers.ResumeLayout(false);
            this.pnlManageProducts.ResumeLayout(false);
            this.pnlManageOrders.ResumeLayout(false);
            this.pnlManageSupplies.ResumeLayout(false);
            this.pnlReports.ResumeLayout(false);
            this.pnlChat.ResumeLayout(false);
            this.pnlSettings.ResumeLayout(false);
            this.flSideBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer LoginTimer;
        private System.Windows.Forms.Panel pnlMenuIcon;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.PictureBox picMenuIcon;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlUserInfo;
        private System.Windows.Forms.Label lblUsertext;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Panel pnlLogOut;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Timer SideBartimer;
        private System.Windows.Forms.PictureBox picSettings;
        private System.Windows.Forms.Button btnChat;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnManageSupplies;
        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnManageOrders;
        private System.Windows.Forms.Button btnManageProducts;
        private System.Windows.Forms.Panel pnlManageUsers;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Panel pnlFormLoader;
        private System.Windows.Forms.Panel pnlManageProducts;
        private System.Windows.Forms.Panel pnlManageOrders;
        private System.Windows.Forms.Panel pnlManageSupplies;
        private System.Windows.Forms.Panel pnlReports;
        private System.Windows.Forms.Panel pnlChat;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.FlowLayoutPanel flSideBar;
    }
}