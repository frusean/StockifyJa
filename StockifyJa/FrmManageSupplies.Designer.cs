namespace StockifyJa
{
    partial class FrmManageSupplies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManageSupplies));
            this.gboxSupplyID = new System.Windows.Forms.GroupBox();
            this.txtSupplyID = new System.Windows.Forms.TextBox();
            this.lblProductID = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.lblQuantityPurchased = new System.Windows.Forms.Label();
            this.nudQuantityPurchased = new System.Windows.Forms.NumericUpDown();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblSupplyDate = new System.Windows.Forms.Label();
            this.dtpSupplyDate = new System.Windows.Forms.DateTimePicker();
            this.txtQuantityInStock = new System.Windows.Forms.TextBox();
            this.lblQuantityInStock = new System.Windows.Forms.Label();
            this.gboxStockID = new System.Windows.Forms.GroupBox();
            this.txtStockID = new System.Windows.Forms.TextBox();
            this.dgvSupplies = new System.Windows.Forms.DataGridView();
            this.SupplyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityPurchased = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplyDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.lblManageSupplies = new System.Windows.Forms.Label();
            this.picSave = new System.Windows.Forms.PictureBox();
            this.picRefresh = new System.Windows.Forms.PictureBox();
            this.picDelete = new System.Windows.Forms.PictureBox();
            this.picUpdate = new System.Windows.Forms.PictureBox();
            this.picAdd = new System.Windows.Forms.PictureBox();
            this.gboxSupplyID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantityPurchased)).BeginInit();
            this.gboxStockID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxSupplyID
            // 
            this.gboxSupplyID.Controls.Add(this.txtSupplyID);
            this.gboxSupplyID.Location = new System.Drawing.Point(378, 100);
            this.gboxSupplyID.Name = "gboxSupplyID";
            this.gboxSupplyID.Size = new System.Drawing.Size(100, 50);
            this.gboxSupplyID.TabIndex = 0;
            this.gboxSupplyID.TabStop = false;
            this.gboxSupplyID.Text = "Supply ID";
            // 
            // txtSupplyID
            // 
            this.txtSupplyID.Location = new System.Drawing.Point(9, 22);
            this.txtSupplyID.Name = "txtSupplyID";
            this.txtSupplyID.ReadOnly = true;
            this.txtSupplyID.Size = new System.Drawing.Size(59, 22);
            this.txtSupplyID.TabIndex = 0;
            this.txtSupplyID.TabStop = false;
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(169, 189);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(69, 16);
            this.lblProductID.TabIndex = 1;
            this.lblProductID.Text = "Product ID";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(366, 189);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(136, 22);
            this.txtProductID.TabIndex = 2;
            // 
            // lblQuantityPurchased
            // 
            this.lblQuantityPurchased.AutoSize = true;
            this.lblQuantityPurchased.Location = new System.Drawing.Point(169, 258);
            this.lblQuantityPurchased.Name = "lblQuantityPurchased";
            this.lblQuantityPurchased.Size = new System.Drawing.Size(123, 16);
            this.lblQuantityPurchased.TabIndex = 3;
            this.lblQuantityPurchased.Text = "Quantity Purchased";
            // 
            // nudQuantityPurchased
            // 
            this.nudQuantityPurchased.Location = new System.Drawing.Point(366, 258);
            this.nudQuantityPurchased.Name = "nudQuantityPurchased";
            this.nudQuantityPurchased.Size = new System.Drawing.Size(136, 22);
            this.nudQuantityPurchased.TabIndex = 4;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(304, 333);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(247, 22);
            this.txtCost.TabIndex = 6;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(169, 333);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(34, 16);
            this.lblCost.TabIndex = 5;
            this.lblCost.Text = "Cost";
            // 
            // lblSupplyDate
            // 
            this.lblSupplyDate.AutoSize = true;
            this.lblSupplyDate.Location = new System.Drawing.Point(169, 399);
            this.lblSupplyDate.Name = "lblSupplyDate";
            this.lblSupplyDate.Size = new System.Drawing.Size(81, 16);
            this.lblSupplyDate.TabIndex = 7;
            this.lblSupplyDate.Text = "Supply Date";
            // 
            // dtpSupplyDate
            // 
            this.dtpSupplyDate.Location = new System.Drawing.Point(304, 399);
            this.dtpSupplyDate.Name = "dtpSupplyDate";
            this.dtpSupplyDate.Size = new System.Drawing.Size(247, 22);
            this.dtpSupplyDate.TabIndex = 8;
            // 
            // txtQuantityInStock
            // 
            this.txtQuantityInStock.Location = new System.Drawing.Point(838, 199);
            this.txtQuantityInStock.Name = "txtQuantityInStock";
            this.txtQuantityInStock.ReadOnly = true;
            this.txtQuantityInStock.Size = new System.Drawing.Size(128, 22);
            this.txtQuantityInStock.TabIndex = 13;
            // 
            // lblQuantityInStock
            // 
            this.lblQuantityInStock.AutoSize = true;
            this.lblQuantityInStock.Location = new System.Drawing.Point(642, 202);
            this.lblQuantityInStock.Name = "lblQuantityInStock";
            this.lblQuantityInStock.Size = new System.Drawing.Size(105, 16);
            this.lblQuantityInStock.TabIndex = 12;
            this.lblQuantityInStock.Text = "Quantity In Stock";
            // 
            // gboxStockID
            // 
            this.gboxStockID.Controls.Add(this.txtStockID);
            this.gboxStockID.Location = new System.Drawing.Point(818, 100);
            this.gboxStockID.Name = "gboxStockID";
            this.gboxStockID.Size = new System.Drawing.Size(100, 50);
            this.gboxStockID.TabIndex = 11;
            this.gboxStockID.TabStop = false;
            this.gboxStockID.Text = "Stock ID";
            // 
            // txtStockID
            // 
            this.txtStockID.Location = new System.Drawing.Point(9, 22);
            this.txtStockID.Name = "txtStockID";
            this.txtStockID.ReadOnly = true;
            this.txtStockID.Size = new System.Drawing.Size(59, 22);
            this.txtStockID.TabIndex = 0;
            this.txtStockID.TabStop = false;
            // 
            // dgvSupplies
            // 
            this.dgvSupplies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SupplyID,
            this.ProductID,
            this.QuantityPurchased,
            this.Cost,
            this.SupplyDate,
            this.StockID,
            this.QuantityInStock});
            this.dgvSupplies.Location = new System.Drawing.Point(2, 507);
            this.dgvSupplies.Name = "dgvSupplies";
            this.dgvSupplies.RowHeadersWidth = 51;
            this.dgvSupplies.RowTemplate.Height = 24;
            this.dgvSupplies.Size = new System.Drawing.Size(1025, 209);
            this.dgvSupplies.TabIndex = 15;
            // 
            // SupplyID
            // 
            this.SupplyID.HeaderText = "Supply ID";
            this.SupplyID.MinimumWidth = 6;
            this.SupplyID.Name = "SupplyID";
            this.SupplyID.Width = 125;
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.MinimumWidth = 6;
            this.ProductID.Name = "ProductID";
            this.ProductID.Width = 125;
            // 
            // QuantityPurchased
            // 
            this.QuantityPurchased.HeaderText = "Quantity Purchased";
            this.QuantityPurchased.MinimumWidth = 6;
            this.QuantityPurchased.Name = "QuantityPurchased";
            this.QuantityPurchased.Width = 125;
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Cost";
            this.Cost.MinimumWidth = 6;
            this.Cost.Name = "Cost";
            this.Cost.Width = 125;
            // 
            // SupplyDate
            // 
            this.SupplyDate.HeaderText = "Supply Date";
            this.SupplyDate.MinimumWidth = 6;
            this.SupplyDate.Name = "SupplyDate";
            this.SupplyDate.Width = 125;
            // 
            // StockID
            // 
            this.StockID.HeaderText = "StockID";
            this.StockID.MinimumWidth = 6;
            this.StockID.Name = "StockID";
            this.StockID.Width = 125;
            // 
            // QuantityInStock
            // 
            this.QuantityInStock.HeaderText = "Quantity In Stock";
            this.QuantityInStock.MinimumWidth = 6;
            this.QuantityInStock.Name = "QuantityInStock";
            this.QuantityInStock.Width = 125;
            // 
            // picExit
            // 
            this.picExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.Location = new System.Drawing.Point(1033, 684);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(53, 47);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExit.TabIndex = 16;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // lblManageSupplies
            // 
            this.lblManageSupplies.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblManageSupplies.AutoSize = true;
            this.lblManageSupplies.BackColor = System.Drawing.Color.Transparent;
            this.lblManageSupplies.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageSupplies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(167)))));
            this.lblManageSupplies.Location = new System.Drawing.Point(481, 26);
            this.lblManageSupplies.Name = "lblManageSupplies";
            this.lblManageSupplies.Size = new System.Drawing.Size(227, 32);
            this.lblManageSupplies.TabIndex = 17;
            this.lblManageSupplies.Text = "Manage Supplies";
            this.lblManageSupplies.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picSave
            // 
            this.picSave.Image = ((System.Drawing.Image)(resources.GetObject("picSave.Image")));
            this.picSave.Location = new System.Drawing.Point(900, 459);
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
            this.picRefresh.Location = new System.Drawing.Point(838, 459);
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
            this.picDelete.Location = new System.Drawing.Point(774, 459);
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
            this.picUpdate.Location = new System.Drawing.Point(714, 459);
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
            this.picAdd.Location = new System.Drawing.Point(655, 459);
            this.picAdd.Name = "picAdd";
            this.picAdd.Size = new System.Drawing.Size(43, 42);
            this.picAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAdd.TabIndex = 22;
            this.picAdd.TabStop = false;
            this.picAdd.Click += new System.EventHandler(this.picAdd_Click);
            // 
            // FrmManageSupplies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(1100, 757);
            this.Controls.Add(this.picSave);
            this.Controls.Add(this.picRefresh);
            this.Controls.Add(this.picDelete);
            this.Controls.Add(this.picUpdate);
            this.Controls.Add(this.picAdd);
            this.Controls.Add(this.lblManageSupplies);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.dgvSupplies);
            this.Controls.Add(this.txtQuantityInStock);
            this.Controls.Add(this.lblQuantityInStock);
            this.Controls.Add(this.gboxStockID);
            this.Controls.Add(this.dtpSupplyDate);
            this.Controls.Add(this.lblSupplyDate);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.nudQuantityPurchased);
            this.Controls.Add(this.lblQuantityPurchased);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.gboxSupplyID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmManageSupplies";
            this.Text = "Manage Supplies";
            this.Load += new System.EventHandler(this.FrmManageSupplies_Load);
            this.gboxSupplyID.ResumeLayout(false);
            this.gboxSupplyID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantityPurchased)).EndInit();
            this.gboxStockID.ResumeLayout(false);
            this.gboxStockID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplies)).EndInit();
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

        private System.Windows.Forms.GroupBox gboxSupplyID;
        private System.Windows.Forms.TextBox txtSupplyID;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label lblQuantityPurchased;
        private System.Windows.Forms.NumericUpDown nudQuantityPurchased;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblSupplyDate;
        private System.Windows.Forms.DateTimePicker dtpSupplyDate;
        private System.Windows.Forms.TextBox txtQuantityInStock;
        private System.Windows.Forms.Label lblQuantityInStock;
        private System.Windows.Forms.GroupBox gboxStockID;
        private System.Windows.Forms.TextBox txtStockID;
        private System.Windows.Forms.DataGridView dgvSupplies;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Label lblManageSupplies;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityPurchased;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplyDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockID;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityInStock;
        private System.Windows.Forms.PictureBox picSave;
        private System.Windows.Forms.PictureBox picRefresh;
        private System.Windows.Forms.PictureBox picDelete;
        private System.Windows.Forms.PictureBox picUpdate;
        private System.Windows.Forms.PictureBox picAdd;
    }
}