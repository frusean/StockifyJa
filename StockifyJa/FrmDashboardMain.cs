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
    public partial class FrmDashboardMain : Form
    {
        public FrmDashboardMain()
        {
            InitializeComponent();
        }

        private void picChat_Click(object sender, EventArgs e)
        {

            FrmAdminChat frmAdminChat = new FrmAdminChat();
           frmAdminChat.Show();
        }

        private void lblDetails_Click(object sender, EventArgs e)
        {
            FrmReports frmReports = new FrmReports();
            frmReports.Show();
        }

        private void picManageSupplies_Click(object sender, EventArgs e)
        {
            FrmManageSupplies frmManageSupplies = new FrmManageSupplies();
            frmManageSupplies.Show();
        }

        private void picManageOrders_Click(object sender, EventArgs e)
        {
            FrmManageOrders frmManageOrders = new FrmManageOrders();
            frmManageOrders.Show();
        }

        private void picManageProducts_Click(object sender, EventArgs e)
        {
            FrmManageProducts frmManageProducts = new FrmManageProducts();
            frmManageProducts.Show();
        }

        private void picManageUser_Click(object sender, EventArgs e)
        {
            FrmManageUsers frmManageUsers = new FrmManageUsers();
             frmManageUsers.Show();
        }

        private void picSettings_Click(object sender, EventArgs e)
        {
            FrmSettings frmSettings = new FrmSettings();
            frmSettings.Show();
        }

        private void picReports_Click(object sender, EventArgs e)
        {
            FrmReports frmReports = new FrmReports();
            frmReports.Show();
        }

        private void lblReports_Click(object sender, EventArgs e)
        {
            FrmReports frmReports = new FrmReports();
            frmReports.Show();
        }
    }
}
