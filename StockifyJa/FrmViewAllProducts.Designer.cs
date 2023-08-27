namespace StockifyJa
{
    partial class FrmViewAllProducts
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmViewAllProducts));
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.gboxSearch = new System.Windows.Forms.GroupBox();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.flpProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.lblProductCatalog = new System.Windows.Forms.Label();
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.picRefresh = new System.Windows.Forms.PictureBox();
            this.pnlSearch.SuspendLayout();
            this.gboxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.gboxSearch);
            this.pnlSearch.Location = new System.Drawing.Point(3, 30);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(328, 60);
            this.pnlSearch.TabIndex = 4;
            // 
            // gboxSearch
            // 
            this.gboxSearch.Controls.Add(this.picSearch);
            this.gboxSearch.Controls.Add(this.txtSearch);
            this.gboxSearch.Location = new System.Drawing.Point(12, 3);
            this.gboxSearch.Name = "gboxSearch";
            this.gboxSearch.Size = new System.Drawing.Size(313, 48);
            this.gboxSearch.TabIndex = 2;
            this.gboxSearch.TabStop = false;
            // 
            // picSearch
            // 
            this.picSearch.Image = ((System.Drawing.Image)(resources.GetObject("picSearch.Image")));
            this.picSearch.Location = new System.Drawing.Point(268, 18);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(30, 20);
            this.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSearch.TabIndex = 1;
            this.picSearch.TabStop = false;
            this.picSearch.Click += new System.EventHandler(this.picSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(6, 18);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(256, 22);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // flpProducts
            // 
            this.flpProducts.AutoScroll = true;
            this.flpProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(219)))), ((int)(((byte)(217)))));
            this.flpProducts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpProducts.Location = new System.Drawing.Point(0, 221);
            this.flpProducts.Name = "flpProducts";
            this.flpProducts.Size = new System.Drawing.Size(1040, 502);
            this.flpProducts.TabIndex = 3;
            // 
            // picExit
            // 
            this.picExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.Location = new System.Drawing.Point(975, 43);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(53, 47);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExit.TabIndex = 5;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // lblProductCatalog
            // 
            this.lblProductCatalog.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblProductCatalog.AutoSize = true;
            this.lblProductCatalog.BackColor = System.Drawing.Color.Transparent;
            this.lblProductCatalog.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCatalog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(167)))));
            this.lblProductCatalog.Location = new System.Drawing.Point(409, 5);
            this.lblProductCatalog.Name = "lblProductCatalog";
            this.lblProductCatalog.Size = new System.Drawing.Size(244, 32);
            this.lblProductCatalog.TabIndex = 6;
            this.lblProductCatalog.Text = "Product Catalogue";
            this.lblProductCatalog.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // refreshTimer
            // 
            this.refreshTimer.Interval = 50000;
            this.refreshTimer.Tick += new System.EventHandler(this.refreshTimer_Tick);
            // 
            // picRefresh
            // 
            this.picRefresh.Image = ((System.Drawing.Image)(resources.GetObject("picRefresh.Image")));
            this.picRefresh.Location = new System.Drawing.Point(356, 40);
            this.picRefresh.Name = "picRefresh";
            this.picRefresh.Size = new System.Drawing.Size(44, 41);
            this.picRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRefresh.TabIndex = 7;
            this.picRefresh.TabStop = false;
            this.picRefresh.Click += new System.EventHandler(this.picRefresh_Click);
            // 
            // FrmViewAllProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(219)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1040, 723);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.picRefresh);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.flpProducts);
            this.Controls.Add(this.lblProductCatalog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmViewAllProducts";
            this.Text = "View All Products";
            this.Load += new System.EventHandler(this.FrmViewAllProducts_Load);
            this.pnlSearch.ResumeLayout(false);
            this.gboxSearch.ResumeLayout(false);
            this.gboxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.GroupBox gboxSearch;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.FlowLayoutPanel flpProducts;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Label lblProductCatalog;
        private System.Windows.Forms.Timer refreshTimer;
        private System.Windows.Forms.PictureBox picRefresh;
    }
}