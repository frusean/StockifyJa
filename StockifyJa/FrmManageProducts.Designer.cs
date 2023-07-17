namespace StockifyJa
{
    partial class FrmManageProducts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManageProducts));
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.gboxProductID = new System.Windows.Forms.GroupBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.gboxRateID = new System.Windows.Forms.GroupBox();
            this.cboRates = new System.Windows.Forms.ComboBox();
            this.gboxImageID = new System.Windows.Forms.GroupBox();
            this.txtImageID = new System.Windows.Forms.TextBox();
            this.txtImageURL = new System.Windows.Forms.TextBox();
            this.lblImageURL = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImageID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImageURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RateID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.lblManageProducts = new System.Windows.Forms.Label();
            this.picAdd = new System.Windows.Forms.PictureBox();
            this.picUpdate = new System.Windows.Forms.PictureBox();
            this.picDelete = new System.Windows.Forms.PictureBox();
            this.picRefresh = new System.Windows.Forms.PictureBox();
            this.picSave = new System.Windows.Forms.PictureBox();
            this.gboxProductID.SuspendLayout();
            this.gboxRateID.SuspendLayout();
            this.gboxImageID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSave)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(366, 187);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(285, 22);
            this.txtProductName.TabIndex = 5;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(169, 187);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(108, 18);
            this.lblProductName.TabIndex = 4;
            this.lblProductName.Text = "Product  Name";
            // 
            // gboxProductID
            // 
            this.gboxProductID.Controls.Add(this.txtProductID);
            this.gboxProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxProductID.Location = new System.Drawing.Point(457, 109);
            this.gboxProductID.Name = "gboxProductID";
            this.gboxProductID.Size = new System.Drawing.Size(86, 50);
            this.gboxProductID.TabIndex = 3;
            this.gboxProductID.TabStop = false;
            this.gboxProductID.Text = "Product ID";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(9, 22);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.ReadOnly = true;
            this.txtProductID.Size = new System.Drawing.Size(59, 24);
            this.txtProductID.TabIndex = 0;
            this.txtProductID.TabStop = false;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(366, 240);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(285, 22);
            this.txtCategory.TabIndex = 7;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(169, 240);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(68, 18);
            this.lblCategory.TabIndex = 6;
            this.lblCategory.Text = "Category";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(366, 283);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(285, 56);
            this.txtDescription.TabIndex = 9;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(169, 305);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(83, 18);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "Description";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(366, 364);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(285, 22);
            this.txtPrice.TabIndex = 11;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(169, 364);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(42, 18);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "Price";
            // 
            // gboxRateID
            // 
            this.gboxRateID.Controls.Add(this.cboRates);
            this.gboxRateID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxRateID.Location = new System.Drawing.Point(172, 425);
            this.gboxRateID.Name = "gboxRateID";
            this.gboxRateID.Size = new System.Drawing.Size(479, 62);
            this.gboxRateID.TabIndex = 4;
            this.gboxRateID.TabStop = false;
            this.gboxRateID.Text = "Rate ID";
            // 
            // cboRates
            // 
            this.cboRates.FormattingEnabled = true;
            this.cboRates.Location = new System.Drawing.Point(194, 21);
            this.cboRates.Name = "cboRates";
            this.cboRates.Size = new System.Drawing.Size(279, 26);
            this.cboRates.TabIndex = 1;
            this.cboRates.TabStop = false;
            // 
            // gboxImageID
            // 
            this.gboxImageID.Controls.Add(this.txtImageID);
            this.gboxImageID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxImageID.Location = new System.Drawing.Point(972, 109);
            this.gboxImageID.Name = "gboxImageID";
            this.gboxImageID.Size = new System.Drawing.Size(87, 50);
            this.gboxImageID.TabIndex = 4;
            this.gboxImageID.TabStop = false;
            this.gboxImageID.Text = "Image ID";
            // 
            // txtImageID
            // 
            this.txtImageID.Location = new System.Drawing.Point(9, 22);
            this.txtImageID.Name = "txtImageID";
            this.txtImageID.ReadOnly = true;
            this.txtImageID.Size = new System.Drawing.Size(59, 24);
            this.txtImageID.TabIndex = 0;
            this.txtImageID.TabStop = false;
            // 
            // txtImageURL
            // 
            this.txtImageURL.Location = new System.Drawing.Point(890, 200);
            this.txtImageURL.Multiline = true;
            this.txtImageURL.Name = "txtImageURL";
            this.txtImageURL.Size = new System.Drawing.Size(285, 63);
            this.txtImageURL.TabIndex = 13;
            // 
            // lblImageURL
            // 
            this.lblImageURL.AutoSize = true;
            this.lblImageURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImageURL.Location = new System.Drawing.Point(776, 224);
            this.lblImageURL.Name = "lblImageURL";
            this.lblImageURL.Size = new System.Drawing.Size(82, 18);
            this.lblImageURL.TabIndex = 12;
            this.lblImageURL.Text = "Image URL";
            // 
            // dgvProducts
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.Category,
            this.Description,
            this.Price,
            this.ImageID,
            this.ImageURL,
            this.RateID});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProducts.Location = new System.Drawing.Point(50, 592);
            this.dgvProducts.Name = "dgvProducts";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.Size = new System.Drawing.Size(1055, 184);
            this.dgvProducts.TabIndex = 14;
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.MinimumWidth = 6;
            this.ProductID.Name = "ProductID";
            this.ProductID.Width = 125;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 125;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.Width = 125;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // ImageID
            // 
            this.ImageID.HeaderText = "Image ID";
            this.ImageID.MinimumWidth = 6;
            this.ImageID.Name = "ImageID";
            this.ImageID.Width = 125;
            // 
            // ImageURL
            // 
            this.ImageURL.HeaderText = "Image URL";
            this.ImageURL.MinimumWidth = 6;
            this.ImageURL.Name = "ImageURL";
            this.ImageURL.Width = 125;
            // 
            // RateID
            // 
            this.RateID.HeaderText = "Rate";
            this.RateID.MinimumWidth = 6;
            this.RateID.Name = "RateID";
            this.RateID.Width = 125;
            // 
            // picExit
            // 
            this.picExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.Location = new System.Drawing.Point(1167, 678);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(53, 47);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExit.TabIndex = 15;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // lblManageProducts
            // 
            this.lblManageProducts.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblManageProducts.AutoSize = true;
            this.lblManageProducts.BackColor = System.Drawing.Color.Transparent;
            this.lblManageProducts.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(167)))));
            this.lblManageProducts.Location = new System.Drawing.Point(517, 30);
            this.lblManageProducts.Name = "lblManageProducts";
            this.lblManageProducts.Size = new System.Drawing.Size(231, 32);
            this.lblManageProducts.TabIndex = 16;
            this.lblManageProducts.Text = "Manage Products";
            this.lblManageProducts.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picAdd
            // 
            this.picAdd.Image = ((System.Drawing.Image)(resources.GetObject("picAdd.Image")));
            this.picAdd.Location = new System.Drawing.Point(544, 534);
            this.picAdd.Name = "picAdd";
            this.picAdd.Size = new System.Drawing.Size(43, 42);
            this.picAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAdd.TabIndex = 17;
            this.picAdd.TabStop = false;
            this.picAdd.Click += new System.EventHandler(this.picAdd_Click);
            // 
            // picUpdate
            // 
            this.picUpdate.Image = ((System.Drawing.Image)(resources.GetObject("picUpdate.Image")));
            this.picUpdate.Location = new System.Drawing.Point(603, 534);
            this.picUpdate.Name = "picUpdate";
            this.picUpdate.Size = new System.Drawing.Size(43, 42);
            this.picUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUpdate.TabIndex = 18;
            this.picUpdate.TabStop = false;
            this.picUpdate.Click += new System.EventHandler(this.picUpdate_Click);
            // 
            // picDelete
            // 
            this.picDelete.Image = ((System.Drawing.Image)(resources.GetObject("picDelete.Image")));
            this.picDelete.Location = new System.Drawing.Point(663, 534);
            this.picDelete.Name = "picDelete";
            this.picDelete.Size = new System.Drawing.Size(43, 42);
            this.picDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDelete.TabIndex = 19;
            this.picDelete.TabStop = false;
            this.picDelete.Click += new System.EventHandler(this.picDelete_Click);
            // 
            // picRefresh
            // 
            this.picRefresh.Image = ((System.Drawing.Image)(resources.GetObject("picRefresh.Image")));
            this.picRefresh.Location = new System.Drawing.Point(727, 534);
            this.picRefresh.Name = "picRefresh";
            this.picRefresh.Size = new System.Drawing.Size(43, 42);
            this.picRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRefresh.TabIndex = 20;
            this.picRefresh.TabStop = false;
            this.picRefresh.Click += new System.EventHandler(this.picRefresh_Click);
            // 
            // picSave
            // 
            this.picSave.Image = ((System.Drawing.Image)(resources.GetObject("picSave.Image")));
            this.picSave.Location = new System.Drawing.Point(789, 534);
            this.picSave.Name = "picSave";
            this.picSave.Size = new System.Drawing.Size(43, 42);
            this.picSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSave.TabIndex = 21;
            this.picSave.TabStop = false;
            this.picSave.Click += new System.EventHandler(this.picSave_Click);
            // 
            // FrmManageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(1241, 778);
            this.Controls.Add(this.picSave);
            this.Controls.Add(this.picRefresh);
            this.Controls.Add(this.picDelete);
            this.Controls.Add(this.picUpdate);
            this.Controls.Add(this.picAdd);
            this.Controls.Add(this.lblManageProducts);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.txtImageURL);
            this.Controls.Add(this.lblImageURL);
            this.Controls.Add(this.gboxImageID);
            this.Controls.Add(this.gboxRateID);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.gboxProductID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmManageProducts";
            this.Text = "Manage Products";
            this.Load += new System.EventHandler(this.FrmManageProducts_Load);
            this.gboxProductID.ResumeLayout(false);
            this.gboxProductID.PerformLayout();
            this.gboxRateID.ResumeLayout(false);
            this.gboxImageID.ResumeLayout(false);
            this.gboxImageID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.GroupBox gboxProductID;
        private System.Windows.Forms.GroupBox gboxRateID;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.GroupBox gboxImageID;
        private System.Windows.Forms.TextBox txtImageID;
        private System.Windows.Forms.TextBox txtImageURL;
        private System.Windows.Forms.Label lblImageURL;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.ComboBox cboRates;
        private System.Windows.Forms.Label lblManageProducts;
        private System.Windows.Forms.PictureBox picAdd;
        private System.Windows.Forms.PictureBox picUpdate;
        private System.Windows.Forms.PictureBox picDelete;
        private System.Windows.Forms.PictureBox picRefresh;
        private System.Windows.Forms.PictureBox picSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImageID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImageURL;
        private System.Windows.Forms.DataGridViewTextBoxColumn RateID;
    }
}