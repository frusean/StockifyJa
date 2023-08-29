namespace StockifyJa
{
    partial class FrmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.gboxRateID = new System.Windows.Forms.GroupBox();
            this.txtRateID = new System.Windows.Forms.TextBox();
            this.txtGCT = new System.Windows.Forms.TextBox();
            this.lblGCT = new System.Windows.Forms.Label();
            this.dgvRates = new System.Windows.Forms.DataGridView();
            this.RateID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.lblSettings = new System.Windows.Forms.Label();
            this.picSave = new System.Windows.Forms.PictureBox();
            this.picRefresh = new System.Windows.Forms.PictureBox();
            this.picDelete = new System.Windows.Forms.PictureBox();
            this.picUpdate = new System.Windows.Forms.PictureBox();
            this.picAdd = new System.Windows.Forms.PictureBox();
            this.picSaveStatus = new System.Windows.Forms.PictureBox();
            this.picRefreshStatus = new System.Windows.Forms.PictureBox();
            this.picDeleteStatus = new System.Windows.Forms.PictureBox();
            this.picUpdateStatus = new System.Windows.Forms.PictureBox();
            this.picAddStatus = new System.Windows.Forms.PictureBox();
            this.dgvStatus = new System.Windows.Forms.DataGridView();
            this.StatusID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gboxStatusID = new System.Windows.Forms.GroupBox();
            this.txtStatusID = new System.Windows.Forms.TextBox();
            this.txtStatusName = new System.Windows.Forms.TextBox();
            this.lblStatusName = new System.Windows.Forms.Label();
            this.gboxRateID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSaveStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefreshStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeleteStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdateStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatus)).BeginInit();
            this.gboxStatusID.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(290, 180);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(128, 22);
            this.txtDiscount.TabIndex = 4;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(174, 181);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(75, 18);
            this.lblDiscount.TabIndex = 3;
            this.lblDiscount.Text = "Discount";
            // 
            // gboxRateID
            // 
            this.gboxRateID.Controls.Add(this.txtRateID);
            this.gboxRateID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxRateID.Location = new System.Drawing.Point(290, 95);
            this.gboxRateID.Name = "gboxRateID";
            this.gboxRateID.Size = new System.Drawing.Size(86, 50);
            this.gboxRateID.TabIndex = 5;
            this.gboxRateID.TabStop = false;
            this.gboxRateID.Text = "Rate ID";
            // 
            // txtRateID
            // 
            this.txtRateID.Location = new System.Drawing.Point(9, 22);
            this.txtRateID.Name = "txtRateID";
            this.txtRateID.ReadOnly = true;
            this.txtRateID.Size = new System.Drawing.Size(59, 24);
            this.txtRateID.TabIndex = 0;
            this.txtRateID.TabStop = false;
            // 
            // txtGCT
            // 
            this.txtGCT.Location = new System.Drawing.Point(290, 229);
            this.txtGCT.Name = "txtGCT";
            this.txtGCT.Size = new System.Drawing.Size(128, 22);
            this.txtGCT.TabIndex = 7;
            // 
            // lblGCT
            // 
            this.lblGCT.AutoSize = true;
            this.lblGCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGCT.Location = new System.Drawing.Point(187, 233);
            this.lblGCT.Name = "lblGCT";
            this.lblGCT.Size = new System.Drawing.Size(43, 18);
            this.lblGCT.TabIndex = 6;
            this.lblGCT.Text = "GCT";
            // 
            // dgvRates
            // 
            this.dgvRates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RateID,
            this.Discount,
            this.GCT});
            this.dgvRates.Location = new System.Drawing.Point(90, 402);
            this.dgvRates.Name = "dgvRates";
            this.dgvRates.RowHeadersWidth = 51;
            this.dgvRates.RowTemplate.Height = 24;
            this.dgvRates.Size = new System.Drawing.Size(495, 136);
            this.dgvRates.TabIndex = 15;
            // 
            // RateID
            // 
            this.RateID.HeaderText = "Rate ID";
            this.RateID.MinimumWidth = 6;
            this.RateID.Name = "RateID";
            this.RateID.Width = 125;
            // 
            // Discount
            // 
            this.Discount.HeaderText = "Discount";
            this.Discount.MinimumWidth = 6;
            this.Discount.Name = "Discount";
            this.Discount.Width = 125;
            // 
            // GCT
            // 
            this.GCT.HeaderText = "GCT";
            this.GCT.MinimumWidth = 6;
            this.GCT.Name = "GCT";
            this.GCT.Width = 125;
            // 
            // picExit
            // 
            this.picExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.Location = new System.Drawing.Point(1361, 356);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(53, 47);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExit.TabIndex = 16;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // lblSettings
            // 
            this.lblSettings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSettings.AutoSize = true;
            this.lblSettings.BackColor = System.Drawing.Color.Transparent;
            this.lblSettings.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(167)))));
            this.lblSettings.Location = new System.Drawing.Point(677, 18);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(115, 32);
            this.lblSettings.TabIndex = 17;
            this.lblSettings.Text = "Settings";
            this.lblSettings.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picSave
            // 
            this.picSave.Image = ((System.Drawing.Image)(resources.GetObject("picSave.Image")));
            this.picSave.Location = new System.Drawing.Point(455, 292);
            this.picSave.Name = "picSave";
            this.picSave.Size = new System.Drawing.Size(43, 42);
            this.picSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSave.TabIndex = 26;
            this.picSave.TabStop = false;
            this.picSave.Click += new System.EventHandler(this.picSave_Click);
            // 
            // picRefresh
            // 
            this.picRefresh.Image = ((System.Drawing.Image)(resources.GetObject("picRefresh.Image")));
            this.picRefresh.Location = new System.Drawing.Point(393, 292);
            this.picRefresh.Name = "picRefresh";
            this.picRefresh.Size = new System.Drawing.Size(43, 42);
            this.picRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRefresh.TabIndex = 25;
            this.picRefresh.TabStop = false;
            this.picRefresh.Click += new System.EventHandler(this.picRefresh_Click);
            // 
            // picDelete
            // 
            this.picDelete.Image = ((System.Drawing.Image)(resources.GetObject("picDelete.Image")));
            this.picDelete.Location = new System.Drawing.Point(329, 292);
            this.picDelete.Name = "picDelete";
            this.picDelete.Size = new System.Drawing.Size(43, 42);
            this.picDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDelete.TabIndex = 24;
            this.picDelete.TabStop = false;
            this.picDelete.Click += new System.EventHandler(this.picDelete_Click);
            // 
            // picUpdate
            // 
            this.picUpdate.Image = ((System.Drawing.Image)(resources.GetObject("picUpdate.Image")));
            this.picUpdate.Location = new System.Drawing.Point(269, 292);
            this.picUpdate.Name = "picUpdate";
            this.picUpdate.Size = new System.Drawing.Size(43, 42);
            this.picUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUpdate.TabIndex = 23;
            this.picUpdate.TabStop = false;
            this.picUpdate.Click += new System.EventHandler(this.picUpdate_Click);
            // 
            // picAdd
            // 
            this.picAdd.Image = ((System.Drawing.Image)(resources.GetObject("picAdd.Image")));
            this.picAdd.Location = new System.Drawing.Point(210, 292);
            this.picAdd.Name = "picAdd";
            this.picAdd.Size = new System.Drawing.Size(43, 42);
            this.picAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAdd.TabIndex = 22;
            this.picAdd.TabStop = false;
            this.picAdd.Click += new System.EventHandler(this.picAdd_Click);
            // 
            // picSaveStatus
            // 
            this.picSaveStatus.Image = ((System.Drawing.Image)(resources.GetObject("picSaveStatus.Image")));
            this.picSaveStatus.Location = new System.Drawing.Point(1203, 292);
            this.picSaveStatus.Name = "picSaveStatus";
            this.picSaveStatus.Size = new System.Drawing.Size(43, 42);
            this.picSaveStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSaveStatus.TabIndex = 37;
            this.picSaveStatus.TabStop = false;
            this.picSaveStatus.Click += new System.EventHandler(this.picSaveStatus_Click);
            // 
            // picRefreshStatus
            // 
            this.picRefreshStatus.Image = ((System.Drawing.Image)(resources.GetObject("picRefreshStatus.Image")));
            this.picRefreshStatus.Location = new System.Drawing.Point(1141, 292);
            this.picRefreshStatus.Name = "picRefreshStatus";
            this.picRefreshStatus.Size = new System.Drawing.Size(43, 42);
            this.picRefreshStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRefreshStatus.TabIndex = 36;
            this.picRefreshStatus.TabStop = false;
            this.picRefreshStatus.Click += new System.EventHandler(this.picRefreshStatus_Click);
            // 
            // picDeleteStatus
            // 
            this.picDeleteStatus.Image = ((System.Drawing.Image)(resources.GetObject("picDeleteStatus.Image")));
            this.picDeleteStatus.Location = new System.Drawing.Point(1077, 292);
            this.picDeleteStatus.Name = "picDeleteStatus";
            this.picDeleteStatus.Size = new System.Drawing.Size(43, 42);
            this.picDeleteStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDeleteStatus.TabIndex = 35;
            this.picDeleteStatus.TabStop = false;
            this.picDeleteStatus.Click += new System.EventHandler(this.picDeleteStatus_Click);
            // 
            // picUpdateStatus
            // 
            this.picUpdateStatus.Image = ((System.Drawing.Image)(resources.GetObject("picUpdateStatus.Image")));
            this.picUpdateStatus.Location = new System.Drawing.Point(1017, 292);
            this.picUpdateStatus.Name = "picUpdateStatus";
            this.picUpdateStatus.Size = new System.Drawing.Size(43, 42);
            this.picUpdateStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUpdateStatus.TabIndex = 34;
            this.picUpdateStatus.TabStop = false;
            this.picUpdateStatus.Click += new System.EventHandler(this.picUpdateStatus_Click);
            // 
            // picAddStatus
            // 
            this.picAddStatus.Image = ((System.Drawing.Image)(resources.GetObject("picAddStatus.Image")));
            this.picAddStatus.Location = new System.Drawing.Point(958, 292);
            this.picAddStatus.Name = "picAddStatus";
            this.picAddStatus.Size = new System.Drawing.Size(43, 42);
            this.picAddStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAddStatus.TabIndex = 33;
            this.picAddStatus.TabStop = false;
            this.picAddStatus.Click += new System.EventHandler(this.picAddStatus_Click);
            // 
            // dgvStatus
            // 
            this.dgvStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StatusID,
            this.StatusName});
            this.dgvStatus.Location = new System.Drawing.Point(859, 402);
            this.dgvStatus.Name = "dgvStatus";
            this.dgvStatus.RowHeadersWidth = 51;
            this.dgvStatus.RowTemplate.Height = 24;
            this.dgvStatus.Size = new System.Drawing.Size(465, 136);
            this.dgvStatus.TabIndex = 32;
            // 
            // StatusID
            // 
            this.StatusID.HeaderText = "Staus ID";
            this.StatusID.MinimumWidth = 6;
            this.StatusID.Name = "StatusID";
            this.StatusID.Width = 125;
            // 
            // StatusName
            // 
            this.StatusName.HeaderText = "Status Name";
            this.StatusName.MinimumWidth = 6;
            this.StatusName.Name = "StatusName";
            this.StatusName.Width = 125;
            // 
            // gboxStatusID
            // 
            this.gboxStatusID.Controls.Add(this.txtStatusID);
            this.gboxStatusID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxStatusID.Location = new System.Drawing.Point(1010, 95);
            this.gboxStatusID.Name = "gboxStatusID";
            this.gboxStatusID.Size = new System.Drawing.Size(120, 50);
            this.gboxStatusID.TabIndex = 29;
            this.gboxStatusID.TabStop = false;
            this.gboxStatusID.Text = "Status ID";
            // 
            // txtStatusID
            // 
            this.txtStatusID.Location = new System.Drawing.Point(34, 20);
            this.txtStatusID.Name = "txtStatusID";
            this.txtStatusID.ReadOnly = true;
            this.txtStatusID.Size = new System.Drawing.Size(59, 24);
            this.txtStatusID.TabIndex = 0;
            this.txtStatusID.TabStop = false;
            // 
            // txtStatusName
            // 
            this.txtStatusName.Location = new System.Drawing.Point(1044, 180);
            this.txtStatusName.Name = "txtStatusName";
            this.txtStatusName.Size = new System.Drawing.Size(128, 22);
            this.txtStatusName.TabIndex = 28;
            // 
            // lblStatusName
            // 
            this.lblStatusName.AutoSize = true;
            this.lblStatusName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusName.Location = new System.Drawing.Point(909, 180);
            this.lblStatusName.Name = "lblStatusName";
            this.lblStatusName.Size = new System.Drawing.Size(105, 18);
            this.lblStatusName.TabIndex = 27;
            this.lblStatusName.Text = "Status Name";
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(1426, 624);
            this.Controls.Add(this.picSaveStatus);
            this.Controls.Add(this.picRefreshStatus);
            this.Controls.Add(this.picDeleteStatus);
            this.Controls.Add(this.picUpdateStatus);
            this.Controls.Add(this.picAddStatus);
            this.Controls.Add(this.dgvStatus);
            this.Controls.Add(this.gboxStatusID);
            this.Controls.Add(this.txtStatusName);
            this.Controls.Add(this.lblStatusName);
            this.Controls.Add(this.picSave);
            this.Controls.Add(this.picRefresh);
            this.Controls.Add(this.picDelete);
            this.Controls.Add(this.picUpdate);
            this.Controls.Add(this.picAdd);
            this.Controls.Add(this.lblSettings);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.dgvRates);
            this.Controls.Add(this.txtGCT);
            this.Controls.Add(this.lblGCT);
            this.Controls.Add(this.gboxRateID);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.lblDiscount);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.gboxRateID.ResumeLayout(false);
            this.gboxRateID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSaveStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefreshStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeleteStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdateStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatus)).EndInit();
            this.gboxStatusID.ResumeLayout(false);
            this.gboxStatusID.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.GroupBox gboxRateID;
        private System.Windows.Forms.TextBox txtRateID;
        private System.Windows.Forms.TextBox txtGCT;
        private System.Windows.Forms.Label lblGCT;
        private System.Windows.Forms.DataGridView dgvRates;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.PictureBox picSave;
        private System.Windows.Forms.PictureBox picRefresh;
        private System.Windows.Forms.PictureBox picDelete;
        private System.Windows.Forms.PictureBox picUpdate;
        private System.Windows.Forms.PictureBox picAdd;
        private System.Windows.Forms.PictureBox picSaveStatus;
        private System.Windows.Forms.PictureBox picRefreshStatus;
        private System.Windows.Forms.PictureBox picDeleteStatus;
        private System.Windows.Forms.PictureBox picUpdateStatus;
        private System.Windows.Forms.PictureBox picAddStatus;
        private System.Windows.Forms.DataGridView dgvStatus;
        private System.Windows.Forms.GroupBox gboxStatusID;
        private System.Windows.Forms.TextBox txtStatusID;
        private System.Windows.Forms.TextBox txtStatusName;
        private System.Windows.Forms.Label lblStatusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RateID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn GCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusName;
    }
}