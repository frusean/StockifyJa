using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using MigraDoc.DocumentObjectModel.Internals;

namespace StockifyJa
{
    public partial class FrmDashboardMain : Form
    {
        FrmAdmin parentAdminForm;
        FrmAdminChat frmAdminChat;
        FrmReports frmReports;
        FrmManageSupplies frmManageSupplies;
        FrmManageOrders frmManageOrders;
        FrmManageProducts frmManageProducts;
        FrmManageUsers frmManageUsers;
        FrmSettings frmSettings;
        public FrmDashboardMain(FrmAdmin parentAdminForm)
        {
            InitializeComponent();
            this.parentAdminForm = parentAdminForm;
        }

        private void picChat_Click(object sender, EventArgs e)
        {

            if (frmAdminChat == null || frmAdminChat.IsDisposed)
            {
                frmAdminChat = new FrmAdminChat();
            }
            parentAdminForm.LoadFormInPanel(frmAdminChat);
        }

        private void lblDetails_Click(object sender, EventArgs e)
        {
            if (frmReports == null || frmReports.IsDisposed)
            {
                frmReports = new FrmReports();
            }
            parentAdminForm.LoadFormInPanel(frmReports);
        }

        private void picManageSupplies_Click(object sender, EventArgs e)
        {
            if (frmManageSupplies == null || frmManageSupplies.IsDisposed)
            {
                frmManageSupplies = new FrmManageSupplies();
            }
            parentAdminForm.LoadFormInPanel(frmManageSupplies);
        }

        private void picManageOrders_Click(object sender, EventArgs e)
        {
            if (frmManageOrders == null || frmManageOrders.IsDisposed)
            {
                frmManageOrders = new FrmManageOrders();
            }
            parentAdminForm.LoadFormInPanel(frmManageOrders);
        }

        private void picManageProducts_Click(object sender, EventArgs e)
        {
            if (frmManageProducts == null || frmManageProducts.IsDisposed)
            {
                frmManageProducts = new FrmManageProducts();
            }
            parentAdminForm.LoadFormInPanel(frmManageProducts);
        }

        private void picManageUser_Click(object sender, EventArgs e)
        {
            if (frmManageUsers == null || frmManageUsers.IsDisposed)
            {
                frmManageUsers = new FrmManageUsers();
            }
            parentAdminForm.LoadFormInPanel(frmManageUsers);
        }

        private void picSettings_Click(object sender, EventArgs e)
        {
            if (frmSettings == null || frmSettings.IsDisposed)
            {
                frmSettings = new FrmSettings();
            }
            parentAdminForm.LoadFormInPanel(frmSettings);
        }

        private void picReports_Click(object sender, EventArgs e)
        {
            if (frmReports == null || frmReports.IsDisposed)
            {
                frmReports = new FrmReports();
            }
            parentAdminForm.LoadFormInPanel(frmReports);
        }

        private void lblReports_Click(object sender, EventArgs e)
        {
            if (frmReports == null || frmReports.IsDisposed)
            {
                frmReports = new FrmReports();
            }
            parentAdminForm.LoadFormInPanel(frmReports);
        }
      
}
}
