using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockifyjaLib;

namespace StockifyJa
{
    public partial class FrmSplashScreen : Form
    {
        public FrmSplashScreen()
        {
            InitializeComponent();
            LoginProgressBar.Value = 0;
        }

        private void FrmSplashScreen_Load(object sender, EventArgs e)
        {

        }

        private void Loadtimer_Tick(object sender, EventArgs e)
        {

            LoginProgressBar.Value += 1;
            LoginProgressBar.Text = LoginProgressBar.Value.ToString() + "%";

            if (LoginProgressBar.Value == 100)
            {
                Loadtimer.Enabled = false;

                switch (AppState.UserRole)
                {
                    case "Administrator":
                        FrmAdmin adminForm = new FrmAdmin();
                        adminForm.Show();
                        break;
                    case "Customer":
                        FrmCustomerMDI customerForm = new FrmCustomerMDI();
                        customerForm.Show();
                        break;
                    default:
                        MessageBox.Show($"Invalid User Role: {AppState.UserRole}!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

                this.Hide();
            }


         }

        
    }
}
