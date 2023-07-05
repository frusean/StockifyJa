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
            this.gboxImageID = new System.Windows.Forms.GroupBox();
            this.txtImageID = new System.Windows.Forms.TextBox();
            this.txtImageURL = new System.Windows.Forms.TextBox();
            this.lblImageURL = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.cboRates = new System.Windows.Forms.ComboBox();
            this.lblManageProducts = new System.Windows.Forms.Label();
            this.gboxProductID.SuspendLayout();
            this.gboxRateID.SuspendLayout();
            this.gboxImageID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
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
            this.lblProductName.Location = new System.Drawing.Point(169, 187);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(96, 16);
            this.lblProductName.TabIndex = 4;
            this.lblProductName.Text = "Product  Name";
            // 
            // gboxProductID
            // 
            this.gboxProductID.Controls.Add(this.txtProductID);
            this.gboxProductID.Location = new System.Drawing.Point(424, 109);
            this.gboxProductID.Name = "gboxProductID";
            this.gboxProductID.Size = new System.Drawing.Size(100, 50);
            this.gboxProductID.TabIndex = 3;
            this.gboxProductID.TabStop = false;
            this.gboxProductID.Text = "Product ID";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(9, 22);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.ReadOnly = true;
            this.txtProductID.Size = new System.Drawing.Size(59, 22);
            this.txtProductID.TabIndex = 0;
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
            this.lblCategory.Location = new System.Drawing.Point(169, 240);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(62, 16);
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
            this.lblDescription.Location = new System.Drawing.Point(169, 305);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(75, 16);
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
            this.lblPrice.Location = new System.Drawing.Point(169, 364);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(38, 16);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "Price";
            // 
            // gboxRateID
            // 
            this.gboxRateID.Controls.Add(this.cboRates);
            this.gboxRateID.Location = new System.Drawing.Point(172, 425);
            this.gboxRateID.Name = "gboxRateID";
            this.gboxRateID.Size = new System.Drawing.Size(479, 62);
            this.gboxRateID.TabIndex = 4;
            this.gboxRateID.TabStop = false;
            this.gboxRateID.Text = "Rate ID";
            // 
            // gboxImageID
            // 
            this.gboxImageID.Controls.Add(this.txtImageID);
            this.gboxImageID.Location = new System.Drawing.Point(907, 109);
            this.gboxImageID.Name = "gboxImageID";
            this.gboxImageID.Size = new System.Drawing.Size(100, 50);
            this.gboxImageID.TabIndex = 4;
            this.gboxImageID.TabStop = false;
            this.gboxImageID.Text = "Image ID";
            // 
            // txtImageID
            // 
            this.txtImageID.Location = new System.Drawing.Point(9, 22);
            this.txtImageID.Name = "txtImageID";
            this.txtImageID.ReadOnly = true;
            this.txtImageID.Size = new System.Drawing.Size(59, 22);
            this.txtImageID.TabIndex = 0;
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
            this.lblImageURL.Location = new System.Drawing.Point(714, 234);
            this.lblImageURL.Name = "lblImageURL";
            this.lblImageURL.Size = new System.Drawing.Size(75, 16);
            this.lblImageURL.TabIndex = 12;
            this.lblImageURL.Text = "Image URL";
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(123, 509);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.Size = new System.Drawing.Size(949, 184);
            this.dgvProducts.TabIndex = 14;
            // 
            // picExit
            // 
            this.picExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.Location = new System.Drawing.Point(1158, 605);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(53, 47);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExit.TabIndex = 15;
            this.picExit.TabStop = false;
            // 
            // cboRates
            // 
            this.cboRates.FormattingEnabled = true;
            this.cboRates.Location = new System.Drawing.Point(194, 21);
            this.cboRates.Name = "cboRates";
            this.cboRates.Size = new System.Drawing.Size(279, 24);
            this.cboRates.TabIndex = 1;
            // 
            // lblManageProducts
            // 
            this.lblManageProducts.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblManageProducts.AutoSize = true;
            this.lblManageProducts.BackColor = System.Drawing.Color.Transparent;
            this.lblManageProducts.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(167)))));
            this.lblManageProducts.Location = new System.Drawing.Point(437, 37);
            this.lblManageProducts.Name = "lblManageProducts";
            this.lblManageProducts.Size = new System.Drawing.Size(231, 32);
            this.lblManageProducts.TabIndex = 16;
            this.lblManageProducts.Text = "Manage Products";
            this.lblManageProducts.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmManageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 705);
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
            this.Name = "FrmManageProducts";
            this.Text = "Manage Products";
            this.gboxProductID.ResumeLayout(false);
            this.gboxProductID.PerformLayout();
            this.gboxRateID.ResumeLayout(false);
            this.gboxImageID.ResumeLayout(false);
            this.gboxImageID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
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
    }
}