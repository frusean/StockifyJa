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
    public partial class FrmCustomerMDI : Form
    {
        public FrmCustomerMDI()
        {
            InitializeComponent();
        }

        private void chatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCustomerChat frmCustomerChat = new FrmCustomerChat();
            frmCustomerChat.MdiParent = this;
            frmCustomerChat.Show();

        }
    }
}
