﻿namespace StockifyJa
{
    partial class FrmPlaceOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPlaceOrder));
            this.btnViewOrder = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.lbxCart = new System.Windows.Forms.ListBox();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.lblPlaceOrder = new System.Windows.Forms.Label();
            this.lblItems = new System.Windows.Forms.Label();
            this.picAdd = new System.Windows.Forms.PictureBox();
            this.picRemove = new System.Windows.Forms.PictureBox();
            this.TxtCartID = new System.Windows.Forms.TextBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.picExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnViewOrder
            // 
            this.btnViewOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewOrder.Location = new System.Drawing.Point(1141, 418);
            this.btnViewOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnViewOrder.Name = "btnViewOrder";
            this.btnViewOrder.Size = new System.Drawing.Size(132, 26);
            this.btnViewOrder.TabIndex = 36;
            this.btnViewOrder.Text = "View Order";
            this.btnViewOrder.UseVisualStyleBackColor = true;
            this.btnViewOrder.Click += new System.EventHandler(this.btnViewOrder_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(199, 159);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(75, 18);
            this.lblQuantity.TabIndex = 35;
            this.lblQuantity.Text = "Quantity:";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(322, 152);
            this.nudQuantity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.ReadOnly = true;
            this.nudQuantity.Size = new System.Drawing.Size(69, 24);
            this.nudQuantity.TabIndex = 34;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.ValueChanged += new System.EventHandler(this.nudQuantity_ValueChanged);
            // 
            // lbxCart
            // 
            this.lbxCart.FormattingEnabled = true;
            this.lbxCart.ItemHeight = 18;
            this.lbxCart.Location = new System.Drawing.Point(81, 290);
            this.lbxCart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbxCart.Name = "lbxCart";
            this.lbxCart.Size = new System.Drawing.Size(995, 310);
            this.lbxCart.TabIndex = 33;
            this.lbxCart.SelectedIndexChanged += new System.EventHandler(this.lbxCart_SelectedIndexChanged);
            // 
            // cbProduct
            // 
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(322, 90);
            this.cbProduct.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(523, 26);
            this.cbProduct.TabIndex = 30;
            this.cbProduct.SelectedIndexChanged += new System.EventHandler(this.cbProduct_SelectedIndexChanged);
            // 
            // lblPlaceOrder
            // 
            this.lblPlaceOrder.AutoSize = true;
            this.lblPlaceOrder.Font = new System.Drawing.Font("Georgia", 16.2F);
            this.lblPlaceOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(167)))));
            this.lblPlaceOrder.Location = new System.Drawing.Point(581, 10);
            this.lblPlaceOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlaceOrder.Name = "lblPlaceOrder";
            this.lblPlaceOrder.Size = new System.Drawing.Size(160, 32);
            this.lblPlaceOrder.TabIndex = 29;
            this.lblPlaceOrder.Text = "Place Order";
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItems.Location = new System.Drawing.Point(199, 93);
            this.lblItems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(49, 18);
            this.lblItems.TabIndex = 41;
            this.lblItems.Text = "Items";
            // 
            // picAdd
            // 
            this.picAdd.Image = ((System.Drawing.Image)(resources.GetObject("picAdd.Image")));
            this.picAdd.Location = new System.Drawing.Point(872, 90);
            this.picAdd.Name = "picAdd";
            this.picAdd.Size = new System.Drawing.Size(36, 26);
            this.picAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAdd.TabIndex = 42;
            this.picAdd.TabStop = false;
            this.picAdd.Click += new System.EventHandler(this.picAdd_Click);
            // 
            // picRemove
            // 
            this.picRemove.Image = ((System.Drawing.Image)(resources.GetObject("picRemove.Image")));
            this.picRemove.Location = new System.Drawing.Point(936, 90);
            this.picRemove.Name = "picRemove";
            this.picRemove.Size = new System.Drawing.Size(35, 26);
            this.picRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRemove.TabIndex = 43;
            this.picRemove.TabStop = false;
            this.picRemove.Click += new System.EventHandler(this.picRemove_Click);
            // 
            // TxtCartID
            // 
            this.TxtCartID.Location = new System.Drawing.Point(1124, 37);
            this.TxtCartID.Name = "TxtCartID";
            this.TxtCartID.Size = new System.Drawing.Size(91, 24);
            this.TxtCartID.TabIndex = 44;
            this.TxtCartID.TextChanged += new System.EventHandler(this.TxtCartID_TextChanged);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(1124, 102);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 45;
            this.BtnDelete.Text = "Reset ";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // picExit
            // 
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.Location = new System.Drawing.Point(1308, 614);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(61, 47);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExit.TabIndex = 46;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // FrmPlaceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(219)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1381, 673);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.TxtCartID);
            this.Controls.Add(this.picRemove);
            this.Controls.Add(this.picAdd);
            this.Controls.Add(this.lblItems);
            this.Controls.Add(this.btnViewOrder);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.lbxCart);
            this.Controls.Add(this.cbProduct);
            this.Controls.Add(this.lblPlaceOrder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmPlaceOrder";
            this.Text = "Place Order";
            this.Load += new System.EventHandler(this.FrmPlaceOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnViewOrder;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.ListBox lbxCart;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.Label lblPlaceOrder;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.PictureBox picAdd;
        private System.Windows.Forms.PictureBox picRemove;
        private System.Windows.Forms.TextBox TxtCartID;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.PictureBox picExit;
    }
}

