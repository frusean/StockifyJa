namespace StockifyJa
{
    partial class FrmProductDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductDetails));
            this.lblProductDetails = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.flpProductDetails = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductDetails
            // 
            this.lblProductDetails.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblProductDetails.AutoSize = true;
            this.lblProductDetails.BackColor = System.Drawing.Color.Transparent;
            this.lblProductDetails.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(167)))));
            this.lblProductDetails.Location = new System.Drawing.Point(333, 9);
            this.lblProductDetails.Name = "lblProductDetails";
            this.lblProductDetails.Size = new System.Drawing.Size(207, 32);
            this.lblProductDetails.TabIndex = 2;
            this.lblProductDetails.Text = "Product Details";
            this.lblProductDetails.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picExit
            // 
            this.picExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.Location = new System.Drawing.Point(782, 502);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(53, 47);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExit.TabIndex = 4;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // flpProductDetails
            // 
            this.flpProductDetails.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flpProductDetails.AutoScroll = true;
            this.flpProductDetails.AutoSize = true;
            this.flpProductDetails.Location = new System.Drawing.Point(20, 54);
            this.flpProductDetails.Name = "flpProductDetails";
            this.flpProductDetails.Size = new System.Drawing.Size(818, 523);
            this.flpProductDetails.TabIndex = 3;
            // 
            // FrmProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(841, 561);
            this.Controls.Add(this.lblProductDetails);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.flpProductDetails);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmProductDetails";
            this.Text = "Product Details";
            this.Load += new System.EventHandler(this.FrmProductDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductDetails;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.FlowLayoutPanel flpProductDetails;
    }
}