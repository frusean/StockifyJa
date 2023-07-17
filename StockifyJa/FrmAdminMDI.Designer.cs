namespace StockifyJa
{
    partial class FrmAdminMDI
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.manageProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mangeOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageSuppliesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageUsersToolStripMenuItem,
            this.mangeOrdersToolStripMenuItem,
            this.manageProductsToolStripMenuItem,
            this.manageSuppliesToolStripMenuItem,
            this.manageStockToolStripMenuItem,
            this.chatToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(600, 24);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // manageProductsToolStripMenuItem
            // 
            this.manageProductsToolStripMenuItem.Name = "manageProductsToolStripMenuItem";
            this.manageProductsToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.manageProductsToolStripMenuItem.Text = "Manage Products";
            this.manageProductsToolStripMenuItem.Click += new System.EventHandler(this.manageProductsToolStripMenuItem_Click);
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.manageUsersToolStripMenuItem.Text = "Manage Users";
            this.manageUsersToolStripMenuItem.Click += new System.EventHandler(this.manageUsersToolStripMenuItem_Click);
            // 
            // mangeOrdersToolStripMenuItem
            // 
            this.mangeOrdersToolStripMenuItem.Name = "mangeOrdersToolStripMenuItem";
            this.mangeOrdersToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.mangeOrdersToolStripMenuItem.Text = "Mange Orders";
            // 
            // chatToolStripMenuItem
            // 
            this.chatToolStripMenuItem.Name = "chatToolStripMenuItem";
            this.chatToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.chatToolStripMenuItem.Text = "Chat";
            this.chatToolStripMenuItem.Click += new System.EventHandler(this.chatToolStripMenuItem_Click);
            // 
            // manageSuppliesToolStripMenuItem
            // 
            this.manageSuppliesToolStripMenuItem.Name = "manageSuppliesToolStripMenuItem";
            this.manageSuppliesToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.manageSuppliesToolStripMenuItem.Text = "Manage Supplies";
            this.manageSuppliesToolStripMenuItem.Click += new System.EventHandler(this.manageSuppliesToolStripMenuItem_Click);
            // 
            // manageStockToolStripMenuItem
            // 
            this.manageStockToolStripMenuItem.Name = "manageStockToolStripMenuItem";
            this.manageStockToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.manageStockToolStripMenuItem.Text = "Manage Stock";
            this.manageStockToolStripMenuItem.Click += new System.EventHandler(this.manageStockToolStripMenuItem_Click);
            // 
            // FrmAdminMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmAdminMDI";
            this.Text = "Administrator ";
            this.Load += new System.EventHandler(this.FrmAdminMDI_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem manageProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mangeOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageSuppliesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageStockToolStripMenuItem;
    }
}