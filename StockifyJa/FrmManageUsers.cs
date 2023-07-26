using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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

            {
                string EmailPattern = @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$";
                bool IsEmailValid = false;

                if (string.IsNullOrWhiteSpace(Email))
                {
                    isValid = false;
                    MessageBox.Show("Enter valid Restaurant Email!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Focus();

                    try
                    {
                        IsEmailValid = Regex.IsMatch(txtEmail.Text, EmailPattern);
                    }
                    catch (ArgumentException ex)
                    {
                        MessageBox.Show("Error in email pattern: " + ex.Message);
                        return;
                    }
                    if (!IsEmailValid)
                    {
                        MessageBox.Show("Invalid Email");
                        txtEmail.Focus();
                    }
                }
            }
        }
    }
}   