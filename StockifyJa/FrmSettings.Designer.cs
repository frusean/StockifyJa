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
            this.gboxRateID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(267, 194);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(128, 22);
            this.txtDiscount.TabIndex = 4;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(132, 194);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(75, 18);
            this.lblDiscount.TabIndex = 3;
            this.lblDiscount.Text = "Discount";
            // 
            // gboxRateID
            // 
            this.gboxRateID.Controls.Add(this.txtRateID);
            this.gboxRateID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxRateID.Location = new System.Drawing.Point(267, 109);
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
            this.txtGCT.Location = new System.Drawing.Point(267, 243);
            this.txtGCT.Name = "txtGCT";
            this.txtGCT.Size = new System.Drawing.Size(128, 22);
            this.txtGCT.TabIndex = 7;
            // 
            // lblGCT
            // 
            this.lblGCT.AutoSize = true;
            this.lblGCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGCT.Location = new System.Drawing.Point(132, 243);
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
            this.dgvRates.Location = new System.Drawing.Point(27, 439);
            this.dgvRates.Name = "dgvRates";
            this.dgvRates.RowHeadersWidth = 51;
            this.dgvRates.RowTemplate.Height = 24;
            this.dgvRates.Size = new System.Drawing.Size(508, 136);
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
            this.picExit.Location = new System.Drawing.Point(747, 549);
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
            this.lblSettings.Location = new System.Drawing.Point(376, 18);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(115, 32);
            this.lblSettings.TabIndex = 17;
            this.lblSettings.Text = "Settings";
            this.lblSettings.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picSave
            // 
            this.picSave.Image = ((System.Drawing.Image)(resources.GetObject("picSave.Image")));
            this.picSave.Location = new System.Drawing.Point(436, 341);
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
            this.picRefresh.Location = new System.Drawing.Point(374, 341);
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
            this.picDelete.Location = new System.Drawing.Point(310, 341);
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
            this.picUpdate.Location = new System.Drawing.Point(250, 341);
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
            this.picAdd.Location = new System.Drawing.Point(191, 341);
            this.picAdd.Name = "picAdd";
            this.picAdd.Size = new System.Drawing.Size(43, 42);
            this.picAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAdd.TabIndex = 22;
            this.picAdd.TabStop = false;
            this.picAdd.Click += new System.EventHandler(this.picAdd_Click);
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(825, 624);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn RateID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn GCT;
        private System.Windows.Forms.PictureBox picSave;
        private System.Windows.Forms.PictureBox picRefresh;
        private System.Windows.Forms.PictureBox picDelete;
        private System.Windows.Forms.PictureBox picUpdate;
        private System.Windows.Forms.PictureBox picAdd;
    }
}