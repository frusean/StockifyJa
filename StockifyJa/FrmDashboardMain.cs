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
        FrmAdmin parentAdminForm;
        public FrmDashboardMain(FrmAdmin parentAdminForm)
        {
            InitializeComponent();
            this.parentAdminForm = parentAdminForm;
        }

        private void picChat_Click(object sender, EventArgs e)
        {

            FrmAdminChat frmChat = new FrmAdminChat();
            parentAdminForm.LoadFormInPanel(frmChat);
        }

        private void lblDetails_Click(object sender, EventArgs e)
        {
            FrmReports frmReport = new FrmReports();
            parentAdminForm.LoadFormInPanel(frmReport);
        }

        private void picManageSupplies_Click(object sender, EventArgs e)
        {
            FrmManageSupplies frmManageSupply = new FrmManageSupplies();
            parentAdminForm.LoadFormInPanel(frmManageSupply);
        }

        private void picManageOrders_Click(object sender, EventArgs e)
        {
            FrmManageOrders frmManageOrder = new FrmManageOrders();
            parentAdminForm.LoadFormInPanel(frmManageOrder);
        }

        private void picManageProducts_Click(object sender, EventArgs e)
        {
            FrmManageProducts frmManageProduct = new FrmManageProducts();
            parentAdminForm.LoadFormInPanel(frmManageProduct);
        }

        private void picManageUser_Click(object sender, EventArgs e)
        {
            FrmManageUsers frmManageUser = new FrmManageUsers();
            parentAdminForm.LoadFormInPanel(frmManageUser);
        }

        private void picSettings_Click(object sender, EventArgs e)
        {
            FrmSettings frmSettings = new FrmSettings();
            parentAdminForm.LoadFormInPanel(frmSettings);
        }

        private void picReports_Click(object sender, EventArgs e)
        {
            FrmReports frmReport = new FrmReports();
            parentAdminForm.LoadFormInPanel(frmReport);
        }

        private void lblReports_Click(object sender, EventArgs e)
        {
            FrmReports frmReport = new FrmReports();
            parentAdminForm.LoadFormInPanel(frmReport);
        }
    }
}
