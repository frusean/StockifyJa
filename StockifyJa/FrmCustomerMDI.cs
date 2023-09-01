using StockifyjaLib;
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
        // Member variables to store single instances of each form
        private FrmCustomerChat frmCustomerChat;
        private FrmViewAllProducts frmViewAllProducts;
        private FrmPlaceOrder frmPlaceOrder;
        public FrmCustomerMDI()
        {
            InitializeComponent();
            
        }

        private void chatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmCustomerChat == null || frmCustomerChat.IsDisposed)
            {
                frmCustomerChat = new FrmCustomerChat();
                frmCustomerChat.MdiParent = this;
            }
            frmCustomerChat.Show();
            frmCustomerChat.Focus(); // Bring the form to the front

        }

        private void viewProductsInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmViewAllProducts == null || frmViewAllProducts.IsDisposed)
            {
                frmViewAllProducts = new FrmViewAllProducts();
                frmViewAllProducts.MdiParent = this;
            }
            frmViewAllProducts.Show();
            frmViewAllProducts.Focus(); // Bring the form to the front

        }

        private void placeOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmPlaceOrder == null || frmPlaceOrder.IsDisposed)
            {
                frmPlaceOrder = new FrmPlaceOrder();
                frmPlaceOrder.MdiParent = this;
            }
            frmPlaceOrder.Show();
            frmPlaceOrder.Focus(); // Bring the form to the front

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Clear the AppState.CartItems and lbxCart.Items
            AppState.CartItems.Clear();
         

            // Close the current form
            this.Close();

            // Show the login form
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
        }

       
        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Clear the AppState.CartItems and lbxCart.Items
            AppState.CartItems.Clear();


            // Close the current form
            this.Close();

            // Show the login form
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
        }
    }
}
