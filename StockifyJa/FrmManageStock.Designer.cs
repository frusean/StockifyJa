namespace StockifyJa
{
    partial class FrmManageStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManageStock));
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.lblProductID = new System.Windows.Forms.Label();
            this.gboxStockID = new System.Windows.Forms.GroupBox();
            this.txtStockID = new System.Windows.Forms.TextBox();
            this.txtQuantityInStock = new System.Windows.Forms.TextBox();
            this.lblQuantityInStock = new System.Windows.Forms.Label();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.lblManageStocks = new System.Windows.Forms.Label();
            this.StockID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gboxStockID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(393, 169);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(128, 22);
            this.txtProductID.TabIndex = 4;
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(258, 169);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(69, 16);
            this.lblProductID.TabIndex = 3;
            this.lblProductID.Text = "Product ID";
            // 
            // gboxStockID
            // 
            this.gboxStockID.Controls.Add(this.txtStockID);
            this.gboxStockID.Location = new System.Drawing.Point(393, 82);
            this.gboxStockID.Name = "gboxStockID";
            this.gboxStockID.Size = new System.Drawing.Size(86, 50);
            this.gboxStockID.TabIndex = 5;
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
            // txtQuantityInStock
            // 
            this.txtQuantityInStock.Location = new System.Drawing.Point(393, 218);
            this.txtQuantityInStock.Name = "txtQuantityInStock";
            this.txtQuantityInStock.Size = new System.Drawing.Size(128, 22);
            this.txtQuantityInStock.TabIndex = 7;
            // 
            // lblQuantityInStock
            // 
            this.lblQuantityInStock.AutoSize = true;
            this.lblQuantityInStock.Location = new System.Drawing.Point(258, 218);
            this.lblQuantityInStock.Name = "lblQuantityInStock";
            this.lblQuantityInStock.Size = new System.Drawing.Size(99, 16);
            this.lblQuantityInStock.TabIndex = 6;
            this.lblQuantityInStock.Text = "QuantityInStock";
            // 
            // dgvStock
            // 
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StockID,
            this.ProductID,
            this.QuantityInStock});
            this.dgvStock.Location = new System.Drawing.Point(169, 302);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.RowHeadersWidth = 51;
            this.dgvStock.RowTemplate.Height = 24;
            this.dgvStock.Size = new System.Drawing.Size(508, 136);
            this.dgvStock.TabIndex = 15;
            // 
            // picExit
            // 
            this.picExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.Location = new System.Drawing.Point(735, 375);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(53, 47);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExit.TabIndex = 16;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // lblManageStocks
            // 
            this.lblManageStocks.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblManageStocks.AutoSize = true;
            this.lblManageStocks.BackColor = System.Drawing.Color.Transparent;
            this.lblManageStocks.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageStocks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(167)))));
            this.lblManageStocks.Location = new System.Drawing.Point(314, 18);
            this.lblManageStocks.Name = "lblManageStocks";
            this.lblManageStocks.Size = new System.Drawing.Size(201, 32);
            this.lblManageStocks.TabIndex = 17;
            this.lblManageStocks.Text = "Manage Stocks";
            this.lblManageStocks.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // StockID
            // 
            this.StockID.HeaderText = "Stock ID";
            this.StockID.MinimumWidth = 6;
            this.StockID.Name = "StockID";
            this.StockID.Width = 125;
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.MinimumWidth = 6;
            this.ProductID.Name = "ProductID";
            this.ProductID.Width = 125;
            // 
            // QuantityInStock
            // 
            this.QuantityInStock.HeaderText = "Quantity In Stock";
            this.QuantityInStock.MinimumWidth = 6;
            this.QuantityInStock.Name = "QuantityInStock";
            this.QuantityInStock.Width = 125;
            // 
            // FrmManageStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblManageStocks);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.dgvStock);
            this.Controls.Add(this.txtQuantityInStock);
            this.Controls.Add(this.lblQuantityInStock);
            this.Controls.Add(this.gboxStockID);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.lblProductID);
            this.Name = "FrmManageStock";
            this.Text = "FrmManageStock";
            this.gboxStockID.ResumeLayout(false);
            this.gboxStockID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.GroupBox gboxStockID;
        private System.Windows.Forms.TextBox txtStockID;
        private System.Windows.Forms.TextBox txtQuantityInStock;
        private System.Windows.Forms.Label lblQuantityInStock;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Label lblManageStocks;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityInStock;
    }
}