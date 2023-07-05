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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtQuantityInStock = new System.Windows.Forms.TextBox();
            this.lblQuantityInStock = new System.Windows.Forms.Label();
            this.gboxStockID = new System.Windows.Forms.GroupBox();
            this.txtStockID = new System.Windows.Forms.TextBox();
            this.dgvSupplies = new System.Windows.Forms.DataGridView();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.lblManageSupplies = new System.Windows.Forms.Label();
            this.gboxSupplyID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantityPurchased)).BeginInit();
            this.gboxStockID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxSupplyID
            // 
            this.gboxSupplyID.Controls.Add(this.txtSupplyID);
            this.gboxSupplyID.Location = new System.Drawing.Point(342, 100);
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(304, 399);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(247, 22);
            this.dateTimePicker1.TabIndex = 8;
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
            // 
            // dgvSupplies
            // 
            this.dgvSupplies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplies.Location = new System.Drawing.Point(97, 457);
            this.dgvSupplies.Name = "dgvSupplies";
            this.dgvSupplies.RowHeadersWidth = 51;
            this.dgvSupplies.RowTemplate.Height = 24;
            this.dgvSupplies.Size = new System.Drawing.Size(833, 154);
            this.dgvSupplies.TabIndex = 15;
            // 
            // picExit
            // 
            this.picExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.Location = new System.Drawing.Point(993, 564);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(53, 47);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExit.TabIndex = 16;
            this.picExit.TabStop = false;
            // 
            // lblManageSupplies
            // 
            this.lblManageSupplies.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblManageSupplies.AutoSize = true;
            this.lblManageSupplies.BackColor = System.Drawing.Color.Transparent;
            this.lblManageSupplies.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageSupplies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(167)))));
            this.lblManageSupplies.Location = new System.Drawing.Point(387, 26);
            this.lblManageSupplies.Name = "lblManageSupplies";
            this.lblManageSupplies.Size = new System.Drawing.Size(227, 32);
            this.lblManageSupplies.TabIndex = 17;
            this.lblManageSupplies.Text = "Manage Supplies";
            this.lblManageSupplies.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmManageSupplies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 640);
            this.Controls.Add(this.lblManageSupplies);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.dgvSupplies);
            this.Controls.Add(this.txtQuantityInStock);
            this.Controls.Add(this.lblQuantityInStock);
            this.Controls.Add(this.gboxStockID);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblSupplyDate);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.nudQuantityPurchased);
            this.Controls.Add(this.lblQuantityPurchased);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.gboxSupplyID);
            this.Name = "FrmManageSupplies";
            this.Text = "Manage Supplies";
            this.gboxSupplyID.ResumeLayout(false);
            this.gboxSupplyID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantityPurchased)).EndInit();
            this.gboxStockID.ResumeLayout(false);
            this.gboxStockID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtQuantityInStock;
        private System.Windows.Forms.Label lblQuantityInStock;
        private System.Windows.Forms.GroupBox gboxStockID;
        private System.Windows.Forms.TextBox txtStockID;
        private System.Windows.Forms.DataGridView dgvSupplies;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Label lblManageSupplies;
    }
}