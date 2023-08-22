namespace StockifyJa
{
    partial class UCProductDetails
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flpProductDetails = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.picProduct = new System.Windows.Forms.PictureBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.flpProductDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // flpProductDetails
            // 
            this.flpProductDetails.Controls.Add(this.lblDiscount);
            this.flpProductDetails.Controls.Add(this.picProduct);
            this.flpProductDetails.Controls.Add(this.lblCategory);
            this.flpProductDetails.Controls.Add(this.lblProductName);
            this.flpProductDetails.Controls.Add(this.lblProductPrice);
            this.flpProductDetails.Controls.Add(this.lblStock);
            this.flpProductDetails.Controls.Add(this.lblDescription);
            this.flpProductDetails.Location = new System.Drawing.Point(55, 27);
            this.flpProductDetails.Name = "flpProductDetails";
            this.flpProductDetails.Size = new System.Drawing.Size(404, 535);
            this.flpProductDetails.TabIndex = 2;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(3, 0);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(59, 16);
            this.lblDiscount.TabIndex = 6;
            this.lblDiscount.Text = "Discount";
            // 
            // picProduct
            // 
            this.flpProductDetails.SetFlowBreak(this.picProduct, true);
            this.picProduct.ImageLocation = "";
            this.picProduct.Location = new System.Drawing.Point(68, 3);
            this.picProduct.Name = "picProduct";
            this.picProduct.Size = new System.Drawing.Size(129, 85);
            this.picProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProduct.TabIndex = 0;
            this.picProduct.TabStop = false;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.flpProductDetails.SetFlowBreak(this.lblCategory, true);
            this.lblCategory.Location = new System.Drawing.Point(3, 91);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(104, 16);
            this.lblCategory.TabIndex = 5;
            this.lblCategory.Text = "Category              ";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.flpProductDetails.SetFlowBreak(this.lblProductName, true);
            this.lblProductName.Location = new System.Drawing.Point(3, 107);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(192, 16);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Product                                  Name";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.flpProductDetails.SetFlowBreak(this.lblProductPrice, true);
            this.lblProductPrice.Location = new System.Drawing.Point(3, 123);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(120, 16);
            this.lblProductPrice.TabIndex = 2;
            this.lblProductPrice.Text = "Product            Price";
            this.lblProductPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.flpProductDetails.SetFlowBreak(this.lblStock, true);
            this.lblStock.Location = new System.Drawing.Point(3, 139);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(41, 16);
            this.lblStock.TabIndex = 4;
            this.lblStock.Text = "Stock";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.flpProductDetails.SetFlowBreak(this.lblDescription, true);
            this.lblDescription.Location = new System.Drawing.Point(3, 155);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(342, 16);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Description                                                                      " +
    "                   ";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UCProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpProductDetails);
            this.Name = "UCProductDetails";
            this.Size = new System.Drawing.Size(527, 589);
            this.flpProductDetails.ResumeLayout(false);
            this.flpProductDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpProductDetails;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.PictureBox picProduct;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblDescription;
    }
}
