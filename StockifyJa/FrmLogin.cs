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
    public partial class FrmLogin : Form
    {
        private readonly stockifydBEntities _db;
        public FrmLogin()
        {
            InitializeComponent();
            _db = new stockifydBEntities();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }


        //private void btnLogin_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        string username = txtUserName.Text;
        //        string password = txtPassword.Text;

        //        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
        //        {
        //            MessageBox.Show("Please enter BOTH Username and Password!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            txtUserName.Focus();
        //            return;
        //        }

        //        var user = _db.Users.SingleOrDefault(u => u.Username == username && u.Password == password);

        //        if (user == null)
        //        {
        //            MessageBox.Show("Invalid username or password!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            txtUserName.Focus();
        //            return;
        //        }

        //        AppState.CurrentUserID = user.UserID; // set current user ID

        //        var cartItems = _db.Carts.Where(c => c.UserID == AppState.CurrentUserID).ToList();

        //        foreach (var cartItem in cartItems)
        //        {
        //            var product = _db.Products.FirstOrDefault(p => p.ProductID == cartItem.ProductID);

        //            if (product != null)
        //            {
        //                ItemDetails itemDetails = new ItemDetails
        //                {
        //                    ProductName = product.ProductName,
        //                    Quantity = cartItem.Quantity.GetValueOrDefault(),
        //                    Price = product.Price.GetValueOrDefault(),
        //                    ProductID = product.ProductID
        //                };

        //                AppState.CartItems.Add(itemDetails);
        //            }
        //        }

        //        string role = user.Role.Trim();
        //        if (role == "administrator")
        //        {
        //            var notifyLoginSuccess = new NotifyIcon();
        //            notifyLoginSuccess.Icon = SystemIcons.Information;
        //            notifyLoginSuccess.Visible = true;
        //            notifyLoginSuccess.ShowBalloonTip(5000, "Admininstrator Login Success", "You have successfully logged in as an Administrator!", ToolTipIcon.Info);
        //            FrmAdminMDI adminForm = new FrmAdminMDI();
        //            adminForm.Show();
        //        }
        //        else if (role == "customer")
        //        {
        //            var notifyLoginSuccess = new NotifyIcon();
        //            notifyLoginSuccess.Icon = SystemIcons.Information;
        //            notifyLoginSuccess.Visible = true;
        //            notifyLoginSuccess.ShowBalloonTip(5000, " Customer Login Success", "You have successfully logged in Customer!", ToolTipIcon.Info);
        //            FrmCustomerMDI customerForm = new FrmCustomerMDI();
        //            customerForm.Show();
        //        }
        //        else
        //        {
        //            MessageBox.Show($"Invalid user role: {role}!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }

        //        this.Hide(); // Hide the login form
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"An error occurred: {ex.Message}");
        //    }
        //}

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUserName.Text;
                string password = txtPassword.Text;

                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Please enter BOTH Username and Password!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.Focus();
                    return;
                }

                var user = _db.Users.SingleOrDefault(u => u.Username == username && u.Password == password);

                if (user == null)
                {
                    MessageBox.Show("Invalid username or password!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.Focus();
                    return;
                }

                AppState.CurrentUserID = user.UserID; // set current user ID

                var cartItems = _db.Carts.Where(c => c.UserID == AppState.CurrentUserID).ToList();

                foreach (var cartItem in cartItems)
                {
                    var product = _db.Products.FirstOrDefault(p => p.ProductID == cartItem.ProductID);

                    if (product != null)
                    {
                        ItemDetails itemDetails = new ItemDetails
                        {
                            ProductName = product.ProductName,
                            Quantity = cartItem.Quantity.GetValueOrDefault(),
                            Price = product.Price.GetValueOrDefault(),
                            ProductID = product.ProductID
                        };

                        AppState.CartItems.Add(itemDetails);
                    }
                }

                string role = user.Role.Trim();

                if (role == "Administrator")
                {
                    
                    var notifyLoginSuccess = new NotifyIcon();
                    notifyLoginSuccess.Icon = SystemIcons.Information;
                    notifyLoginSuccess.Visible = true;
                    notifyLoginSuccess.ShowBalloonTip(5000, "Admininstrator Login Success", "You have successfully logged in as an Administrator!", ToolTipIcon.Info);
                    FrmAdminMDI adminForm = new FrmAdminMDI();
                    adminForm.Show();

                    // Check if any product's stock is 10 or below
                    var lowStockItems = _db.Stocks.Where(s => s.QuantityInStock <= 10).ToList();
                    if (lowStockItems.Count > 0)
                    {
                        var notifyLowStock = new NotifyIcon();
                        notifyLowStock.Icon = SystemIcons.Exclamation;
                        notifyLowStock.Visible = true;
                        notifyLowStock.ShowBalloonTip(5000, "Low Stock Warning", "Some products have low stock. Please check inventory!", ToolTipIcon.Warning);
                    }
                }
               

                else if (role == "Customer")
                {
                    var notifyLoginSuccess = new NotifyIcon();
                    notifyLoginSuccess.Icon = SystemIcons.Information;
                    notifyLoginSuccess.Visible = true;
                    notifyLoginSuccess.ShowBalloonTip(5000, " Customer Login Success", "You have successfully logged in Customer!", ToolTipIcon.Info);
                    FrmCustomerMDI customerForm = new FrmCustomerMDI();
                    customerForm.Show();
                }
                else
                {
                    MessageBox.Show($"Invalid user role: {role}!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.Hide(); // Hide the login form
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }



        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
