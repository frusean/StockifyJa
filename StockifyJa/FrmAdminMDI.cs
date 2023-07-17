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


        private void FrmAdminMDI_Load(object sender, EventArgs e)
        {

        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManageUsers frmManageUsers = new FrmManageUsers();
            frmManageUsers.MdiParent = this;
            frmManageUsers.Show();

        }
    }
}
