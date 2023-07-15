using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace StockifyJa
{
    public partial class FrmManageUsers : Form
    {
        private readonly stockifydBEntities StockifyEntities;

        public FrmManageUsers()
        {
            InitializeComponent();
            StockifyEntities = new stockifydBEntities();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmManageUsers_Load(object sender, EventArgs e)
        {
           // var role = StockifyEntities.Users.ToList();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
          
                string Username = txtUsername.Text;
                string Password = txtUserPassword.Text;
                string CompanyName = txtCompanyName.Text;
                string Name = txtPersonName.Text;
                string ContactType = txtContactType.Text;
                string Street = txtStreet.Text;
                string City = txtCity.Text;
                string Parish = txtParish.Text;
                string ZipCode = txtZipCode.Text;
                string Telephone = txtTelephone.Text;
                string Email = txtEmail.Text;


            //var Role = rbuttonAdministrator.Checked;
            //  string Role = gboxRole.Text;
            var isValid = true;

            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
             {
                isValid = false;
                   
             }

            if (string.IsNullOrEmpty(CompanyName) || string.IsNullOrEmpty(Name))
            {
                isValid = false;
             
            }

            if (string.IsNullOrEmpty(ContactType) || string.IsNullOrEmpty(Street))
            {
                isValid = false;
               
            }

            if (string.IsNullOrEmpty(City) || string.IsNullOrEmpty(Parish))
            {
                isValid = false;
            }

            if (string.IsNullOrEmpty(ZipCode) || string.IsNullOrEmpty(Telephone))
            {
                isValid = false;
            }

            if (string.IsNullOrEmpty(Email))
            {
                isValid = false;
            }

            if (isValid == false)
            {
                MessageBox.Show("Enter All Required Data", "Missing Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
