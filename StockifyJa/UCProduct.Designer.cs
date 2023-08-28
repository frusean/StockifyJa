namespace StockifyJa
{
    partial class UCProduct
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.picProduct = new System.Windows.Forms.PictureBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.lblProductName = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblDiscount);
            this.flowLayoutPanel1.Controls.Add(this.picProduct);
            this.flowLayoutPanel1.Controls.Add(this.lblProductName);
            this.flowLayoutPanel1.Controls.Add(this.lblProductPrice);
            this.flowLayoutPanel1.Controls.Add(this.lblStock);
            this.flowLayoutPanel1.Controls.Add(this.btnViewDetails);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(141, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(230, 494);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // picProduct
            // 
            this.flowLayoutPanel1.SetFlowBreak(this.picProduct, true);
            this.picProduct.ImageLocation = "";
            this.picProduct.Location = new System.Drawing.Point(77, 3);
            this.picProduct.Name = "picProduct";
            this.picProduct.Size = new System.Drawing.Size(110, 106);
            this.picProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProduct.TabIndex = 0;
            this.picProduct.TabStop = false;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(3, 0);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(68, 16);
            this.lblDiscount.TabIndex = 5;
            this.lblDiscount.Text = "Discount   ";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.flowLayoutPanel1.SetFlowBreak(this.lblProductPrice, true);
            this.lblProductPrice.Location = new System.Drawing.Point(3, 128);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(135, 16);
            this.lblProductPrice.TabIndex = 2;
            this.lblProductPrice.Text = "Product                 Price";
            this.lblProductPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.flowLayoutPanel1.SetFlowBreak(this.lblStock, true);
            this.lblStock.Location = new System.Drawing.Point(3, 144);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(62, 16);
            this.lblStock.TabIndex = 4;
            this.lblStock.Text = "Stock       ";
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnViewDetails.Location = new System.Drawing.Point(3, 181);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(110, 28);
            this.btnViewDetails.TabIndex = 3;
            this.btnViewDetails.Text = "View Details";
            this.btnViewDetails.UseVisualStyleBackColor = true;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.flowLayoutPanel1.SetFlowBreak(this.lblProductName, true);
            this.lblProductName.Location = new System.Drawing.Point(3, 112);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(174, 16);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Product                            Name";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UCProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "UCProduct";
            this.Size = new System.Drawing.Size(519, 540);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.PictureBox picProduct;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.Label lblProductName;
    }
}
