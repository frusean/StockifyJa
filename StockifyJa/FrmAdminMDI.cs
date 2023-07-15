using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockifyJa
{
    public partial class FrmAdminMDI : Form
    {
        public FrmAdminMDI()
        {
            InitializeComponent();
        }

        private void chatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdminChat frmAdminChat = new FrmAdminChat();
            frmAdminChat.MdiParent = this;
            frmAdminChat.Show();
        }

        private void manageProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManageProducts frmManageProducts = new FrmManageProducts();
            frmManageProducts.MdiParent = this;
            frmManageProducts.Show();
        }

        private void manageStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManageStock frmManageStock = new FrmManageStock();
            frmManageStock.MdiParent = this;
            frmManageStock.Show();
        }

        private void manageSuppliesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManageSupplies frmManageSupplies = new FrmManageSupplies();
            frmManageSupplies.MdiParent = this;
            frmManageSupplies.Show();
        }
    }
}
