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
        public FrmAdmin()
        {
            InitializeComponent();
                pnlNav.Height = btnHome.Height;
                pnlNav.Top = btnHome.Top;
                pnlNav.Left = btnHome.Left;
                // btnHome.BackColor = Color.FromArgb(141, 153, 174);
                lblTitle.Text = "Dashboard";
                this.pnlFormLoader.Controls.Clear();
                FrmDashboardMain frmDashboard = new FrmDashboardMain() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
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
                // btnHome.BackColor = Color.FromArgb(141, 153, 174);
                lblTitle.Text = "Dashboard";
                this.pnlFormLoader.Controls.Clear();
                FrmDashboardMain frmDashboard = new FrmDashboardMain() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frmDashboard.FormBorderStyle = FormBorderStyle.None;
                this.pnlFormLoader.Controls.Add(frmDashboard);
                frmDashboard.Show();
            }

            private void btnManageUsers_Click(object sender, EventArgs e)
            {
                pnlNav.Height = btnManageUsers.Height;
                pnlNav.Top = btnManageUsers.Top;
                pnlNav.Left = btnManageUsers.Left;
                //  btnManageUsers.BackColor = Color.FromArgb(141, 153, 174);

                lblTitle.Text = "Manage Users";
                this.pnlFormLoader.Controls.Clear();
                FrmManageUsers frmDashboard = new FrmManageUsers() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frmDashboard.FormBorderStyle = FormBorderStyle.None;
                this.pnlFormLoader.Controls.Add(frmDashboard);
                frmDashboard.Show();
            }

            private void btnManageProducts_Click(object sender, EventArgs e)
            {
                pnlNav.Height = btnManageProducts.Height;
                pnlNav.Top = btnManageProducts.Top;
                pnlNav.Left = btnManageProducts.Left;
                //  btnManageProducts.BackColor = Color.FromArgb(141, 153, 174);


                lblTitle.Text = "Manage Products";
                this.pnlFormLoader.Controls.Clear();
                FrmManageProducts frmDashboard = new FrmManageProducts() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frmDashboard.FormBorderStyle = FormBorderStyle.None;
                this.pnlFormLoader.Controls.Add(frmDashboard);
                frmDashboard.Show();
            }

            private void btnManageOrders_Click(object sender, EventArgs e)
            {
                pnlNav.Height = btnManageOrders.Height;
                pnlNav.Top = btnManageOrders.Top;
                pnlNav.Left = btnManageOrders.Left;
                //   btnManageOrders.BackColor = Color.FromArgb(141, 153, 174);

                lblTitle.Text = "Manage Orders";
                this.pnlFormLoader.Controls.Clear();
                FrmManageOrders frmDashboard = new FrmManageOrders() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frmDashboard.FormBorderStyle = FormBorderStyle.None;
                this.pnlFormLoader.Controls.Add(frmDashboard);
                frmDashboard.Show();
            }

            private void btnChat_Click(object sender, EventArgs e)
            {
                pnlNav.Height = btnChat.Height;

                pnlNav.Top = btnChat.Top;
                pnlNav.Left = btnChat.Left;
                // btnChat.BackColor = Color.FromArgb(141, 153, 174);

                lblTitle.Text = "Chat";
                this.pnlFormLoader.Controls.Clear();
                FrmAdminChat frmDashboard = new FrmAdminChat() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frmDashboard.FormBorderStyle = FormBorderStyle.None;
                this.pnlFormLoader.Controls.Add(frmDashboard);
                frmDashboard.Show();
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
            //                LoginTimer.Start();
            loginTime = DateTime.Now;
            lblUsertext.Text = loginTime.ToString("HH:mm:ss");  // Set the time to lblUsertext
            LoginTimer.Start();
        }

            private void btnLogout_Click(object sender, EventArgs e)
            {
                LoginTimer.Stop();
            }

            private void btnManageSupplies_Click(object sender, EventArgs e)
            {
                pnlNav.Height = btnChat.Height;

                pnlNav.Top = btnChat.Top;
                pnlNav.Left = btnChat.Left;
                // btnChat.BackColor = Color.FromArgb(141, 153, 174);

                lblTitle.Text = "Manage Supplies";
                this.pnlFormLoader.Controls.Clear();
                FrmManageSupplies frmDashboard = new FrmManageSupplies() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frmDashboard.FormBorderStyle = FormBorderStyle.None;
                this.pnlFormLoader.Controls.Add(frmDashboard);
                frmDashboard.Show();
            }

            private void btnReports_Click(object sender, EventArgs e)
            {
                pnlNav.Height = btnReports.Height;

                pnlNav.Top = btnReports.Top;
                pnlNav.Left = btnReports.Left;
                // btnChat.BackColor = Color.FromArgb(141, 153, 174);

                lblTitle.Text = "Reports";
                this.pnlFormLoader.Controls.Clear();
                FrmReports frmDashboard = new FrmReports() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frmDashboard.FormBorderStyle = FormBorderStyle.None;
                this.pnlFormLoader.Controls.Add(frmDashboard);
                frmDashboard.Show();
            }

            private void picSettings_Click(object sender, EventArgs e)
            {
                pnlNav.Height = picSettings.Height;
                pnlNav.Top = picSettings.Top;
                pnlNav.Left = picSettings.Left;
                // btnChat.BackColor = Color.FromArgb(141, 153, 174);

                lblTitle.Text = "Settings";
                this.pnlFormLoader.Controls.Clear();
                FrmSettings frmDashboard = new FrmSettings() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frmDashboard.FormBorderStyle = FormBorderStyle.None;
                this.pnlFormLoader.Controls.Add(frmDashboard);
                frmDashboard.Show();
            }
    }
}



