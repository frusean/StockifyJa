namespace StockifyJa
{
    partial class FrmManageUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManageUsers));
            this.lblManageUsers = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.lblUserPassword = new System.Windows.Forms.Label();
            this.lblContactDetails = new System.Windows.Forms.Label();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.txtContactID = new System.Windows.Forms.TextBox();
            this.lblContactID = new System.Windows.Forms.Label();
            this.txtFkeyUserID = new System.Windows.Forms.TextBox();
            this.lblFkeyUserID = new System.Windows.Forms.Label();
            this.txtPersonName = new System.Windows.Forms.TextBox();
            this.txtContactType = new System.Windows.Forms.TextBox();
            this.lblContactType = new System.Windows.Forms.Label();
            this.lblPersonName = new System.Windows.Forms.Label();
            this.txtParish = new System.Windows.Forms.TextBox();
            this.lblParish = new System.Windows.Forms.Label();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.picAddUser = new System.Windows.Forms.PictureBox();
            this.picUpdateUser = new System.Windows.Forms.PictureBox();
            this.picDeleteUser = new System.Windows.Forms.PictureBox();
            this.picViewUser = new System.Windows.Forms.PictureBox();
            this.picRefresh = new System.Windows.Forms.PictureBox();
            this.gboxRole = new System.Windows.Forms.GroupBox();
            this.rbuttonCustomer = new System.Windows.Forms.RadioButton();
            this.rbuttonAdministrator = new System.Windows.Forms.RadioButton();
            this.picExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdateUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeleteUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picViewUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).BeginInit();
            this.gboxRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // lblManageUsers
            // 
            this.lblManageUsers.AutoSize = true;
            this.lblManageUsers.Font = new System.Drawing.Font("Georgia", 16.2F);
            this.lblManageUsers.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblManageUsers.Location = new System.Drawing.Point(742, 9);
            this.lblManageUsers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblManageUsers.Name = "lblManageUsers";
            this.lblManageUsers.Size = new System.Drawing.Size(190, 32);
            this.lblManageUsers.TabIndex = 0;
            this.lblManageUsers.Text = "Manage Users";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(287, 522);
            this.txtCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(285, 22);
            this.txtCity.TabIndex = 21;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(87, 520);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(33, 16);
            this.lblCity.TabIndex = 20;
            this.lblCity.Text = "City";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet.Location = new System.Drawing.Point(87, 482);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(48, 16);
            this.lblStreet.TabIndex = 18;
            this.lblStreet.Text = "Street";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(292, 108);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(285, 22);
            this.txtUsername.TabIndex = 17;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(92, 108);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(78, 16);
            this.lblUsername.TabIndex = 16;
            this.lblUsername.Text = "Username";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(287, 360);
            this.txtCompanyName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(285, 22);
            this.txtCompanyName.TabIndex = 15;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.Location = new System.Drawing.Point(87, 367);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(117, 16);
            this.lblCompanyName.TabIndex = 14;
            this.lblCompanyName.Text = "Company Name";
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(292, 68);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(285, 22);
            this.txtUserID.TabIndex = 23;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(92, 68);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(59, 16);
            this.lblUserID.TabIndex = 22;
            this.lblUserID.Text = "User ID";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(287, 483);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(285, 22);
            this.txtStreet.TabIndex = 24;
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(632, 68);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.Size = new System.Drawing.Size(842, 299);
            this.dgvUsers.TabIndex = 25;
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Location = new System.Drawing.Point(292, 146);
            this.txtUserPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.Size = new System.Drawing.Size(285, 22);
            this.txtUserPassword.TabIndex = 31;
            // 
            // lblUserPassword
            // 
            this.lblUserPassword.AutoSize = true;
            this.lblUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserPassword.Location = new System.Drawing.Point(92, 146);
            this.lblUserPassword.Name = "lblUserPassword";
            this.lblUserPassword.Size = new System.Drawing.Size(75, 16);
            this.lblUserPassword.TabIndex = 30;
            this.lblUserPassword.Text = "Password";
            // 
            // lblContactDetails
            // 
            this.lblContactDetails.AutoSize = true;
            this.lblContactDetails.Font = new System.Drawing.Font("Georgia", 16.2F);
            this.lblContactDetails.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblContactDetails.Location = new System.Drawing.Point(203, 245);
            this.lblContactDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContactDetails.Name = "lblContactDetails";
            this.lblContactDetails.Size = new System.Drawing.Size(205, 32);
            this.lblContactDetails.TabIndex = 32;
            this.lblContactDetails.Text = "Contact Details";
            // 
            // lblUserRole
            // 
            this.lblUserRole.AutoSize = true;
            this.lblUserRole.Location = new System.Drawing.Point(92, 182);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(0, 16);
            this.lblUserRole.TabIndex = 33;
            // 
            // txtContactID
            // 
            this.txtContactID.Location = new System.Drawing.Point(287, 287);
            this.txtContactID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContactID.Name = "txtContactID";
            this.txtContactID.Size = new System.Drawing.Size(285, 22);
            this.txtContactID.TabIndex = 36;
            // 
            // lblContactID
            // 
            this.lblContactID.AutoSize = true;
            this.lblContactID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactID.Location = new System.Drawing.Point(87, 293);
            this.lblContactID.Name = "lblContactID";
            this.lblContactID.Size = new System.Drawing.Size(78, 16);
            this.lblContactID.TabIndex = 35;
            this.lblContactID.Text = "Contact ID";
            // 
            // txtFkeyUserID
            // 
            this.txtFkeyUserID.Location = new System.Drawing.Point(287, 323);
            this.txtFkeyUserID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFkeyUserID.Name = "txtFkeyUserID";
            this.txtFkeyUserID.Size = new System.Drawing.Size(285, 22);
            this.txtFkeyUserID.TabIndex = 38;
            // 
            // lblFkeyUserID
            // 
            this.lblFkeyUserID.AutoSize = true;
            this.lblFkeyUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFkeyUserID.Location = new System.Drawing.Point(87, 330);
            this.lblFkeyUserID.Name = "lblFkeyUserID";
            this.lblFkeyUserID.Size = new System.Drawing.Size(59, 16);
            this.lblFkeyUserID.TabIndex = 37;
            this.lblFkeyUserID.Text = "User ID";
            // 
            // txtPersonName
            // 
            this.txtPersonName.Location = new System.Drawing.Point(287, 399);
            this.txtPersonName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPersonName.Name = "txtPersonName";
            this.txtPersonName.Size = new System.Drawing.Size(285, 22);
            this.txtPersonName.TabIndex = 42;
            // 
            // txtContactType
            // 
            this.txtContactType.Location = new System.Drawing.Point(287, 442);
            this.txtContactType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContactType.Name = "txtContactType";
            this.txtContactType.Size = new System.Drawing.Size(285, 22);
            this.txtContactType.TabIndex = 41;
            // 
            // lblContactType
            // 
            this.lblContactType.AutoSize = true;
            this.lblContactType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactType.Location = new System.Drawing.Point(87, 443);
            this.lblContactType.Name = "lblContactType";
            this.lblContactType.Size = new System.Drawing.Size(99, 16);
            this.lblContactType.TabIndex = 40;
            this.lblContactType.Text = "Contact Type";
            // 
            // lblPersonName
            // 
            this.lblPersonName.AutoSize = true;
            this.lblPersonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonName.Location = new System.Drawing.Point(87, 406);
            this.lblPersonName.Name = "lblPersonName";
            this.lblPersonName.Size = new System.Drawing.Size(48, 16);
            this.lblPersonName.TabIndex = 39;
            this.lblPersonName.Text = "Name";
            // 
            // txtParish
            // 
            this.txtParish.Location = new System.Drawing.Point(287, 563);
            this.txtParish.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtParish.Name = "txtParish";
            this.txtParish.Size = new System.Drawing.Size(285, 22);
            this.txtParish.TabIndex = 44;
            // 
            // lblParish
            // 
            this.lblParish.AutoSize = true;
            this.lblParish.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParish.Location = new System.Drawing.Point(87, 560);
            this.lblParish.Name = "lblParish";
            this.lblParish.Size = new System.Drawing.Size(51, 16);
            this.lblParish.TabIndex = 43;
            this.lblParish.Text = "Parish";
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(287, 601);
            this.txtZipCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(285, 22);
            this.txtZipCode.TabIndex = 46;
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZipCode.Location = new System.Drawing.Point(87, 601);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(66, 16);
            this.lblZipCode.TabIndex = 45;
            this.lblZipCode.Text = "ZipCode";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(287, 688);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(285, 22);
            this.txtEmail.TabIndex = 48;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(87, 686);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 16);
            this.lblEmail.TabIndex = 47;
            this.lblEmail.Text = "Email";
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(287, 645);
            this.txtTelephone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(285, 22);
            this.txtTelephone.TabIndex = 50;
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelephone.Location = new System.Drawing.Point(87, 643);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(82, 16);
            this.lblTelephone.TabIndex = 49;
            this.lblTelephone.Text = "Telephone";
            // 
            // picAddUser
            // 
            this.picAddUser.Image = ((System.Drawing.Image)(resources.GetObject("picAddUser.Image")));
            this.picAddUser.Location = new System.Drawing.Point(1095, 425);
            this.picAddUser.Name = "picAddUser";
            this.picAddUser.Size = new System.Drawing.Size(46, 39);
            this.picAddUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAddUser.TabIndex = 75;
            this.picAddUser.TabStop = false;
            this.picAddUser.Click += new System.EventHandler(this.picAddUser_Click);
            // 
            // picUpdateUser
            // 
            this.picUpdateUser.Image = ((System.Drawing.Image)(resources.GetObject("picUpdateUser.Image")));
            this.picUpdateUser.Location = new System.Drawing.Point(1160, 425);
            this.picUpdateUser.Name = "picUpdateUser";
            this.picUpdateUser.Size = new System.Drawing.Size(51, 39);
            this.picUpdateUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUpdateUser.TabIndex = 76;
            this.picUpdateUser.TabStop = false;
            this.picUpdateUser.Click += new System.EventHandler(this.picUpdateUser_Click);
            // 
            // picDeleteUser
            // 
            this.picDeleteUser.Image = ((System.Drawing.Image)(resources.GetObject("picDeleteUser.Image")));
            this.picDeleteUser.Location = new System.Drawing.Point(1233, 425);
            this.picDeleteUser.Name = "picDeleteUser";
            this.picDeleteUser.Size = new System.Drawing.Size(46, 39);
            this.picDeleteUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDeleteUser.TabIndex = 77;
            this.picDeleteUser.TabStop = false;
            this.picDeleteUser.Click += new System.EventHandler(this.picDeleteUser_Click);
            // 
            // picViewUser
            // 
            this.picViewUser.Image = ((System.Drawing.Image)(resources.GetObject("picViewUser.Image")));
            this.picViewUser.Location = new System.Drawing.Point(1308, 425);
            this.picViewUser.Name = "picViewUser";
            this.picViewUser.Size = new System.Drawing.Size(46, 39);
            this.picViewUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picViewUser.TabIndex = 78;
            this.picViewUser.TabStop = false;
            this.picViewUser.Click += new System.EventHandler(this.picViewUser_Click);
            // 
            // picRefresh
            // 
            this.picRefresh.Image = ((System.Drawing.Image)(resources.GetObject("picRefresh.Image")));
            this.picRefresh.Location = new System.Drawing.Point(1380, 425);
            this.picRefresh.Name = "picRefresh";
            this.picRefresh.Size = new System.Drawing.Size(46, 39);
            this.picRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRefresh.TabIndex = 79;
            this.picRefresh.TabStop = false;
            this.picRefresh.Click += new System.EventHandler(this.picRefresh_Click);
            // 
            // gboxRole
            // 
            this.gboxRole.Controls.Add(this.rbuttonCustomer);
            this.gboxRole.Controls.Add(this.rbuttonAdministrator);
            this.gboxRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxRole.Location = new System.Drawing.Point(90, 182);
            this.gboxRole.Name = "gboxRole";
            this.gboxRole.Size = new System.Drawing.Size(487, 60);
            this.gboxRole.TabIndex = 80;
            this.gboxRole.TabStop = false;
            this.gboxRole.Text = "Role";
            // 
            // rbuttonCustomer
            // 
            this.rbuttonCustomer.AutoSize = true;
            this.rbuttonCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbuttonCustomer.Location = new System.Drawing.Point(359, 21);
            this.rbuttonCustomer.Name = "rbuttonCustomer";
            this.rbuttonCustomer.Size = new System.Drawing.Size(93, 20);
            this.rbuttonCustomer.TabIndex = 1;
            this.rbuttonCustomer.TabStop = true;
            this.rbuttonCustomer.Text = "Customer";
            this.rbuttonCustomer.UseVisualStyleBackColor = true;
            // 
            // rbuttonAdministrator
            // 
            this.rbuttonAdministrator.AutoSize = true;
            this.rbuttonAdministrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbuttonAdministrator.Location = new System.Drawing.Point(94, 21);
            this.rbuttonAdministrator.Name = "rbuttonAdministrator";
            this.rbuttonAdministrator.Size = new System.Drawing.Size(115, 20);
            this.rbuttonAdministrator.TabIndex = 0;
            this.rbuttonAdministrator.TabStop = true;
            this.rbuttonAdministrator.Text = "Adminstrator";
            this.rbuttonAdministrator.UseVisualStyleBackColor = true;
            // 
            // picExit
            // 
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.Location = new System.Drawing.Point(1445, 679);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(61, 47);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExit.TabIndex = 81;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // FrmManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(1518, 738);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.gboxRole);
            this.Controls.Add(this.picRefresh);
            this.Controls.Add(this.picViewUser);
            this.Controls.Add(this.picDeleteUser);
            this.Controls.Add(this.picUpdateUser);
            this.Controls.Add(this.picAddUser);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtZipCode);
            this.Controls.Add(this.lblZipCode);
            this.Controls.Add(this.txtParish);
            this.Controls.Add(this.lblParish);
            this.Controls.Add(this.txtPersonName);
            this.Controls.Add(this.txtContactType);
            this.Controls.Add(this.lblContactType);
            this.Controls.Add(this.lblPersonName);
            this.Controls.Add(this.txtFkeyUserID);
            this.Controls.Add(this.lblFkeyUserID);
            this.Controls.Add(this.txtContactID);
            this.Controls.Add(this.lblContactID);
            this.Controls.Add(this.lblUserRole);
            this.Controls.Add(this.lblContactDetails);
            this.Controls.Add(this.txtUserPassword);
            this.Controls.Add(this.lblUserPassword);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.lblManageUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmManageUsers";
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.FrmManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdateUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeleteUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picViewUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).EndInit();
            this.gboxRole.ResumeLayout(false);
            this.gboxRole.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblManageUsers;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.Label lblUserPassword;
        private System.Windows.Forms.Label lblContactDetails;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.TextBox txtContactID;
        private System.Windows.Forms.Label lblContactID;
        private System.Windows.Forms.TextBox txtFkeyUserID;
        private System.Windows.Forms.Label lblFkeyUserID;
        private System.Windows.Forms.TextBox txtPersonName;
        private System.Windows.Forms.TextBox txtContactType;
        private System.Windows.Forms.Label lblContactType;
        private System.Windows.Forms.Label lblPersonName;
        private System.Windows.Forms.TextBox txtParish;
        private System.Windows.Forms.Label lblParish;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.PictureBox picAddUser;
        private System.Windows.Forms.PictureBox picUpdateUser;
        private System.Windows.Forms.PictureBox picDeleteUser;
        private System.Windows.Forms.PictureBox picViewUser;
        private System.Windows.Forms.PictureBox picRefresh;
        private System.Windows.Forms.GroupBox gboxRole;
        private System.Windows.Forms.RadioButton rbuttonCustomer;
        private System.Windows.Forms.RadioButton rbuttonAdministrator;
        private System.Windows.Forms.PictureBox picExit;
    }
}