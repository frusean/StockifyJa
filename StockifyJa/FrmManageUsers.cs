using Google.Api.Gax.ResourceNames;
using StockifyjaLib;
using Stripe;
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

        private void FrmManageUsers_Load(object sender, EventArgs e)
        {
            PopulateUsersGridView();
        }
        /*
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (ValidateUserData())
            {
                var newUser = new User
                {
                    Username = txtUsername.Text.Trim(),
                    Password = txtUserPassword.Text.Trim(),
                    Role = rbuttonAdministrator.Checked ? "Administrator" : "Customer"
                };

                StockifyEntities.Users.Add(newUser);
                StockifyEntities.SaveChanges();

                var newContactDetails = new ContactDetail
                {
                    UserID = newUser.UserID,
                    CompanyName = txtCompanyName.Text.Trim(),
                    PersonName = txtPersonName.Text.Trim(),
                    ContactType = txtContactType.Text.Trim(),
                    Street = txtStreet.Text.Trim(),
                    City = txtCity.Text.Trim(),
                    Parish = txtParish.Text.Trim(),
                    ZipCode = txtZipCode.Text.Trim(),
                    Telephone = txtTelephone.Text.Trim(),
                    Email = txtEmail.Text.Trim()
                };

                StockifyEntities.ContactDetails.Add(newContactDetails);
                StockifyEntities.SaveChanges();

                PopulateUsersGridView();
                MessageBox.Show("User Successfully Created!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                var userId = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["UserID"].Value);
                var user = StockifyEntities.Users.FirstOrDefault(u => u.UserID == userId);
                var contact = StockifyEntities.ContactDetails.FirstOrDefault(c => c.UserID == userId);

                if (user != null)
                {
                    txtUserID.Text = user.UserID.ToString();
                    txtUsername.Text = user.Username;
                    txtUserPassword.Text = user.Password;
                    rbuttonAdministrator.Checked = user.Role == "Administrator";
                    rbuttonCustomer.Checked = user.Role == "Customer";
                }

                if (contact != null)
                {
                    txtContactID.Text = contact.ContactID.ToString();
                    txtFkeyUserID.Text = contact.UserID.ToString();
                    txtCompanyName.Text = contact.CompanyName;
                    txtPersonName.Text = contact.PersonName;
                    txtContactType.Text = contact.ContactType;
                    txtStreet.Text = contact.Street;
                    txtCity.Text = contact.City;
                    txtParish.Text = contact.Parish;
                    txtZipCode.Text = contact.ZipCode;
                    txtTelephone.Text = contact.Telephone;
                    txtEmail.Text = contact.Email;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0 && ValidateUserData())
            {
                var userId = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["UserID"].Value);
                var user = StockifyEntities.Users.FirstOrDefault(u => u.UserID == userId);
                var contact = StockifyEntities.ContactDetails.FirstOrDefault(c => c.UserID == userId);

                if (user != null)
                {
                    user.Username = txtUsername.Text.Trim();
                    user.Password = txtUserPassword.Text.Trim();
                    user.Role = rbuttonAdministrator.Checked ? "Administrator" : "Customer";
                }

                if (contact != null)
                {
                    contact.CompanyName = txtCompanyName.Text.Trim();
                    contact.PersonName = txtPersonName.Text.Trim();
                    contact.ContactType = txtContactType.Text.Trim();
                    contact.Street = txtStreet.Text.Trim();
                    contact.City = txtCity.Text.Trim();
                    contact.Parish = txtParish.Text.Trim();
                    contact.ZipCode = txtZipCode.Text.Trim();
                    contact.Telephone = txtTelephone.Text.Trim();
                    contact.Email = txtEmail.Text.Trim();
                }

                StockifyEntities.SaveChanges();
                PopulateUsersGridView();
                MessageBox.Show("User Successfully Updated!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Are you sure you want to delete this user?", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    var userId = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["UserID"].Value);
                    var user = StockifyEntities.Users.FirstOrDefault(u => u.UserID == userId);
                    var contact = StockifyEntities.ContactDetails.FirstOrDefault(c => c.UserID == userId);

                    if (contact != null)
                    {
                        StockifyEntities.ContactDetails.Remove(contact);
                    }

                    if (user != null)
                    {
                        StockifyEntities.Users.Remove(user);
                    }

                    StockifyEntities.SaveChanges();
                    PopulateUsersGridView();
                    MessageBox.Show("User Successfully Deleted!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }*/

        private bool ValidateUserData()
        {
            // Add validations for contact details here...
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtUserPassword.Text))
            {
                MessageBox.Show("Username and password are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void PopulateUsersGridView()
        {
            dgvUsers.DataSource = (from u in StockifyEntities.Users
                                   join cd in StockifyEntities.ContactDetails on u.UserID equals cd.UserID into details
                                   from d in details.DefaultIfEmpty()
                                   select new
                                   {
                                       u.UserID,
                                       u.Username,
                                       u.Password,
                                       u.Role,
                                       CompanyName = d != null ? d.CompanyName : string.Empty,
                                       PersonName = d != null ? d.PersonName : string.Empty,
                                       ContactType = d != null ? d.ContactType : string.Empty,
                                       Street = d != null ? d.Street : string.Empty,
                                       City = d != null ? d.City : string.Empty,
                                       Parish = d != null ? d.Parish : string.Empty,
                                       ZipCode = d != null ? d.ZipCode : string.Empty,
                                       Telephone = d != null ? d.Telephone : string.Empty,
                                       Email = d != null ? d.Email : string.Empty
                                   }).ToList();
        }
        private void picAddUser_Click(object sender, EventArgs e)
        {
            if (ValidateUserData())
            {
                var newUser = new User
                {
                    Username = txtUsername.Text.Trim(),
                    Password = txtUserPassword.Text.Trim(),
                    Role = rbuttonAdministrator.Checked ? "Administrator" : "Customer"
                };

                StockifyEntities.Users.Add(newUser);
                StockifyEntities.SaveChanges();

                var newContactDetails = new ContactDetail
                {
                    UserID = newUser.UserID,
                    CompanyName = txtCompanyName.Text.Trim(),
                    PersonName = txtPersonName.Text.Trim(),
                    ContactType = txtContactType.Text.Trim(),
                    Street = txtStreet.Text.Trim(),
                    City = txtCity.Text.Trim(),
                    Parish = txtParish.Text.Trim(),
                    ZipCode = txtZipCode.Text.Trim(),
                    Telephone = txtTelephone.Text.Trim(),
                    Email = txtEmail.Text.Trim()
                };

                StockifyEntities.ContactDetails.Add(newContactDetails);
                StockifyEntities.SaveChanges();

                PopulateUsersGridView();
                MessageBox.Show("User Successfully Created!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void picUpdateUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0 && ValidateUserData())
            {
                var userId = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["UserID"].Value);
                var user = StockifyEntities.Users.FirstOrDefault(u => u.UserID == userId);
                var contact = StockifyEntities.ContactDetails.FirstOrDefault(c => c.UserID == userId);

                if (user != null)
                {
                    user.Username = txtUsername.Text.Trim();
                    user.Password = txtUserPassword.Text.Trim();
                    user.Role = rbuttonAdministrator.Checked ? "Administrator" : "Customer";
                }

                if (contact != null)
                {
                    contact.CompanyName = txtCompanyName.Text.Trim();
                    contact.PersonName = txtPersonName.Text.Trim();
                    contact.ContactType = txtContactType.Text.Trim();
                    contact.Street = txtStreet.Text.Trim();
                    contact.City = txtCity.Text.Trim();
                    contact.Parish = txtParish.Text.Trim();
                    contact.ZipCode = txtZipCode.Text.Trim();
                    contact.Telephone = txtTelephone.Text.Trim();
                    contact.Email = txtEmail.Text.Trim();
                }

                StockifyEntities.SaveChanges();
                PopulateUsersGridView();
                MessageBox.Show("User Successfully Updated!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void picDeleteUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Are you sure you want to delete this user?", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    var userId = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["UserID"].Value);
                    var user = StockifyEntities.Users.FirstOrDefault(u => u.UserID == userId);
                    var contact = StockifyEntities.ContactDetails.FirstOrDefault(c => c.UserID == userId);

                    if (contact != null)
                    {
                        StockifyEntities.ContactDetails.Remove(contact);
                    }

                    if (user != null)
                    {
                        StockifyEntities.Users.Remove(user);
                    }

                    StockifyEntities.SaveChanges();
                    PopulateUsersGridView();
                    MessageBox.Show("User Successfully Deleted!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void picViewUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                var userId = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["UserID"].Value);
                var user = StockifyEntities.Users.FirstOrDefault(u => u.UserID == userId);
                var contact = StockifyEntities.ContactDetails.FirstOrDefault(c => c.UserID == userId);

                if (user != null)
                
                {
                   txtUserID.Text = user.UserID.ToString();
                    txtUsername.Text = user.Username;
                    txtUserPassword.Text = user.Password;

                    var roleMessage = $"User Role: {user.Role}";
                    MessageBox.Show($"User Role: {user.Role}","Role Information",MessageBoxButtons.OK, MessageBoxIcon.Information);


                    if (roleMessage.Contains("Administrator"))
                    {
                        rbuttonAdministrator.Checked = true;
                        rbuttonCustomer.Checked = false;
                    }
                    else if (roleMessage.Contains("Customer"))
                    {
                        rbuttonAdministrator.Checked = false;
                        rbuttonCustomer.Checked = true;
                    }

                }



                if (contact != null)
                {
                    txtContactID.Text = contact.ContactID.ToString();
                    txtFkeyUserID.Text = contact.UserID.ToString();
                    txtCompanyName.Text = contact.CompanyName;
                    txtPersonName.Text = contact.PersonName;
                    txtContactType.Text = contact.ContactType;
                    txtStreet.Text = contact.Street;
                    txtCity.Text = contact.City;
                    txtParish.Text = contact.Parish;
                    txtZipCode.Text = contact.ZipCode;
                    txtTelephone.Text = contact.Telephone;
                    txtEmail.Text = contact.Email;
                }
            }
            }

        private void picRefresh_Click(object sender, EventArgs e)
        {
            // Clear User Fields
            txtUserID.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtUserPassword.Text = string.Empty;
            rbuttonAdministrator.Checked = false;
           rbuttonCustomer.Checked = false;
            // Clear Contact Fields
            txtContactID.Text = string.Empty;
            txtFkeyUserID.Text = string.Empty;
            txtCompanyName.Text = string.Empty;
            txtPersonName.Text = string.Empty;
            txtContactType.Text = string.Empty;
            txtStreet.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtParish.Text = string.Empty;
            txtZipCode.Text = string.Empty;
            txtTelephone.Text = string.Empty;
            txtEmail.Text = string.Empty;

            //rbuttonAdministrator.Refresh();
           // rbuttonCustomer.Refresh();

        }
    }
}