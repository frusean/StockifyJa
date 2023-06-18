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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                //MessageBox.Show("Please enter both username and password.");
                MessageBox.Show("Please enter BOTH Username and Password!)", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            // check the role and open the appropriate form
            string role = user.Role.Trim();
            if (role == "administrator")
            {
                var notifyLoginSuccess = new NotifyIcon();
                notifyLoginSuccess.Icon = SystemIcons.Information;
                notifyLoginSuccess.Visible = true;
                notifyLoginSuccess.ShowBalloonTip(5000, "Admininstrator Login Success", "You have successfully logged in as an Administrator!", ToolTipIcon.Info);
                FrmAdminMDI adminForm = new FrmAdminMDI();
                adminForm.Show();
            }
            else if (role == "customer")
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

        private void picExit_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
