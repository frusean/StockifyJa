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
    public partial class FrmAdmin : Form
    {
        private FrmDashboardMain frmDashboardMain;
        private FrmManageUsers frmManageUsers;
        private FrmManageProducts frmManageProducts;
        private FrmManageOrders frmManageOrders;
        private FrmAdminChat frmAdminChat;
        private FrmManageSupplies frmManageSupplies;
        private FrmReports frmReports;
        private FrmSettings frmSettings;

        public FrmAdmin()
        {
            InitializeComponent();
            pnlNav.Height = btnHome.Height;
            pnlNav.Top = btnHome.Top;
            pnlNav.Left = btnHome.Left;
            lblTitle.Text = "Dashboard";
            this.pnlFormLoader.Controls.Clear();

            // This is the updated line
            FrmDashboardMain frmDashboard = new FrmDashboardMain(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            frmDashboard.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmDashboard);
            frmDashboard.Show();

            this.Resize += new EventHandler(FrmMainAdmin_Resize);



                loginTime = DateTime.Now;

                LoginTimer.Start();
            }

            private void FrmAdmin_Load(object sender, EventArgs e)
            {
                lblUsername.Text = UserName;
            }

            bool sidebarExpand;
            public string UserName { get; set; }
            private DateTime loginTime;




            private void picMenuIcon_Click(object sender, EventArgs e)
            {
                SideBartimer.Start();
            }

            private void SideBartimer_Tick(object sender, EventArgs e)
            {
                if (sidebarExpand)
                {
                    flSideBar.Width -= 10;
                    if (flSideBar.Width == flSideBar.MinimumSize.Width)
                    {
                        sidebarExpand = false;
                        SideBartimer.Stop();
                    }
                }
                else
                {
                    flSideBar.Width += 10;
                    if (flSideBar.Width == flSideBar.MaximumSize.Width)
                    {
                        sidebarExpand = true;
                        SideBartimer.Stop();
                    }
                }
            }

            private void btnHome_Click(object sender, EventArgs e)
            {
            pnlNav.Height = btnHome.Height;
            pnlNav.Top = btnHome.Top;
            pnlNav.Left = btnHome.Left;
            lblTitle.Text = "Dashboard";
            this.pnlFormLoader.Controls.Clear();

            // Check if form is null or disposed before creating a new instance
            if (frmDashboardMain == null || frmDashboardMain.IsDisposed)
            {
                frmDashboardMain = new FrmDashboardMain(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frmDashboardMain.FormBorderStyle = FormBorderStyle.None;
            }

            // This will either load a new form or bring the existing one to the front
            LoadFormInPanel(frmDashboardMain);
        }

            private void btnManageUsers_Click(object sender, EventArgs e)
            {
            pnlNav.Height = btnManageUsers.Height;
            pnlNav.Top = btnManageUsers.Top;
            pnlNav.Left = btnManageUsers.Left;
            lblTitle.Text = "Manage Users";
            this.pnlFormLoader.Controls.Clear();

            if (frmManageUsers == null || frmManageUsers.IsDisposed)
            {
                frmManageUsers = new FrmManageUsers() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frmManageUsers.FormBorderStyle = FormBorderStyle.None;
            }
            LoadFormInPanel(frmManageUsers);

        }

            private void btnManageProducts_Click(object sender, EventArgs e)
            {
            pnlNav.Height = btnManageProducts.Height;
            pnlNav.Top = btnManageProducts.Top;
            pnlNav.Left = btnManageProducts.Left;
            lblTitle.Text = "Manage Products";
            this.pnlFormLoader.Controls.Clear();

            if (frmManageProducts == null || frmManageProducts.IsDisposed)
            {
                frmManageProducts = new FrmManageProducts() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frmManageProducts.FormBorderStyle = FormBorderStyle.None;
            }
            LoadFormInPanel(frmManageProducts);
        }

            private void btnManageOrders_Click(object sender, EventArgs e)
            {
            pnlNav.Height = btnManageOrders.Height;
            pnlNav.Top = btnManageOrders.Top;
            pnlNav.Left = btnManageOrders.Left;
            lblTitle.Text = "Manage Orders";
            this.pnlFormLoader.Controls.Clear();

            if (frmManageOrders == null || frmManageOrders.IsDisposed)
            {
                frmManageOrders = new FrmManageOrders() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frmManageOrders.FormBorderStyle = FormBorderStyle.None;
            }
            LoadFormInPanel(frmManageOrders);
        }

            private void btnChat_Click(object sender, EventArgs e)
            {
            pnlNav.Height = btnChat.Height;
            pnlNav.Top = btnChat.Top;
            pnlNav.Left = btnChat.Left;
            lblTitle.Text = "Chat";
            this.pnlFormLoader.Controls.Clear();

            if (frmAdminChat == null || frmAdminChat.IsDisposed)
            {
                frmAdminChat = new FrmAdminChat() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frmAdminChat.FormBorderStyle = FormBorderStyle.None;
            }
            LoadFormInPanel(frmAdminChat);
        }

        private void btnManageSupplies_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnManageSupplies.Height;
            pnlNav.Top = btnManageSupplies.Top;
            pnlNav.Left = btnManageSupplies.Left;
            lblTitle.Text = "Manage Supplies";
            this.pnlFormLoader.Controls.Clear();

            if (frmManageSupplies == null || frmManageSupplies.IsDisposed)
            {
                frmManageSupplies = new FrmManageSupplies() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frmManageSupplies.FormBorderStyle = FormBorderStyle.None;
            }
            LoadFormInPanel(frmManageSupplies);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnReports.Height;
            pnlNav.Top = btnReports.Top;
            pnlNav.Left = btnReports.Left;
            lblTitle.Text = "Reports";
            this.pnlFormLoader.Controls.Clear();

            if (frmReports == null || frmReports.IsDisposed)
            {
                frmReports = new FrmReports() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frmReports.FormBorderStyle = FormBorderStyle.None;
            }
            LoadFormInPanel(frmReports);
        }

        private void picSettings_Click(object sender, EventArgs e)
        {
            pnlNav.Height = picSettings.Height;
            pnlNav.Top = picSettings.Top;
            pnlNav.Left = picSettings.Left;
            lblTitle.Text = "Settings";
            this.pnlFormLoader.Controls.Clear();

            if (frmSettings == null || frmSettings.IsDisposed)
            {
                frmSettings = new FrmSettings() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frmSettings.FormBorderStyle = FormBorderStyle.None;
            }
            LoadFormInPanel(frmSettings);
        }

        private void FrmMainAdmin_Resize(object sender, EventArgs e)
            {
                // Adjust the height of flSideBar and pnlFormLoader to match the height of the form.
                flSideBar.Height = this.Height;
                pnlFormLoader.Height = this.Height;

                // Adjust the width of pnlFormLoader to take up the rest of the form width minus the width of flSideBar.
                pnlFormLoader.Width = this.Width - flSideBar.Width;

                // You might also want to reposition pnlFormLoader to always be next to flSideBar.
                pnlFormLoader.Left = flSideBar.Width;
            }



            private void LoginTimer_Tick(object sender, EventArgs e)
            {
               // loginTime = DateTime.Now;
            //   LoginTimer.Start();
            loginTime = DateTime.Now;
            lblUsertext.Text = loginTime.ToString("HH:mm:ss");  // Set the time to lblUsertext
            LoginTimer.Start();
        }

            private void btnLogout_Click(object sender, EventArgs e)
            {
                LoginTimer.Stop();
            // Close the current form
            this.Close();

            // Show the login form
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
        }

          
        private void pnlFormLoader_SizeChanged(object sender, EventArgs e)
        {

        }

        public void LoadFormInPanel(Form childForm)
        {
            pnlFormLoader.Controls.Clear();
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            pnlFormLoader.Controls.Add(childForm);
            childForm.Show();
        }
    }
}



