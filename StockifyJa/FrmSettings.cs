using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockifyJa
{
    public partial class FrmSettings : Form
    {
        private stockifydBEntities StockifydBEntities;
        public FrmSettings()
        {
            InitializeComponent();
            StockifydBEntities = new stockifydBEntities();
        }

       

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            // Populate the DataGridView with the current list of rates
            RefreshDataGridView();
        }
        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picAdd_Click(object sender, EventArgs e)
        {
            string GCT = txtGCT.Text;
            string Discount = txtDiscount.Text;

            var isValid = true;

            if (string.IsNullOrWhiteSpace(GCT))
            {
                isValid = false;
                MessageBox.Show("Enter valid GCT!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGCT.Focus();
            }

            if (string.IsNullOrWhiteSpace(Discount))
            {
                isValid = false;
                MessageBox.Show("Enter valid Discount!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiscount.Focus();
            }

            if (isValid)
            {
                try
                {
                    var rate = new Rate
                    {
                        GCT = decimal.Parse(GCT),
                        Discount = decimal.Parse(Discount)
                    };

                    StockifydBEntities.Rates.Add(rate);
                    StockifydBEntities.SaveChanges();

                    txtRateID.Text = rate.ID.ToString();
                    RefreshDataGridView();

                    MessageBox.Show("Rate Successfully Added!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var validationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            MessageBox.Show($"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void picUpdate_Click(object sender, EventArgs e)
        {
            if (dgvRates.SelectedRows.Count > 0)  // Check if a row is selected
            {
                int rateID = Convert.ToInt32(dgvRates.SelectedRows[0].Cells["ID"].Value);  // Fetch the RateID of the selected row

                var rateToUpdate = StockifydBEntities.Rates.Find(rateID);
                if (rateToUpdate != null)
                {
                    txtRateID.Text = rateToUpdate.ID.ToString();
                    txtGCT.Text = rateToUpdate.GCT.ToString();
                    txtDiscount.Text = rateToUpdate.Discount.ToString();
                }
                else
                {
                    MessageBox.Show("Rate ID was NOT FOUND!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a rate from the grid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string GCT = txtGCT.Text;
            string Discount = txtDiscount.Text;

            var isValid = true;

            if (string.IsNullOrWhiteSpace(GCT))
            {
                isValid = false;
                MessageBox.Show("Enter valid GCT!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGCT.Focus();
            }

            if (string.IsNullOrWhiteSpace(Discount))
            {
                isValid = false;
                MessageBox.Show("Enter valid Discount!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiscount.Focus();
            }

            if (isValid)
            {
                try
                {
                    Rate rate;
                    int rateID;
                    if (int.TryParse(txtRateID.Text, out rateID))
                    {
                        // Update existing rate
                        rate = StockifydBEntities.Rates.Find(rateID);
                        if (rate == null)
                        {
                            MessageBox.Show("Rate ID was NOT FOUND!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        // Add new rate
                        rate = new Rate();
                        StockifydBEntities.Rates.Add(rate);
                    }

                    rate.GCT = decimal.Parse(GCT);
                    rate.Discount = decimal.Parse(Discount);

                    StockifydBEntities.SaveChanges();

                    // Refresh DataGridView
                    RefreshDataGridView();

                    MessageBox.Show("Rate Successfully Saved!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var validationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            MessageBox.Show($"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void picSave_Click(object sender, EventArgs e)
        {

        }

        private void picDelete_Click(object sender, EventArgs e)
        {
            if (dgvRates.SelectedRows.Count == 0)
            {
                MessageBox.Show("No rate selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedRateID = (int)dgvRates.SelectedRows[0].Cells["ID"].Value;

            var rateToDelete = StockifydBEntities.Rates.Find(selectedRateID);

            if (rateToDelete == null)
            {
                MessageBox.Show("Rate not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure you want to delete this rate?", "Confirm Deletion!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (confirmResult != DialogResult.Yes) return;

            StockifydBEntities.Rates.Remove(rateToDelete);
            StockifydBEntities.SaveChanges();
            RefreshDataGridView();
            MessageBox.Show("Rate deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void picRefresh_Click(object sender, EventArgs e)
        {
            txtRateID.Text = string.Empty;
            txtGCT.Text = string.Empty;
            txtDiscount.Text = string.Empty;
        }
        private void RefreshDataGridView()
        {
            dgvRates.Rows.Clear();

            if (StockifydBEntities != null && StockifydBEntities.Rates != null)
            {
                foreach (var rate in StockifydBEntities.Rates.ToList())
                {
                    dgvRates.Rows.Add(
                        rate.ID,
                        rate.GCT,
                        rate.Discount
                    );
                }
            }
            else
            {
                MessageBox.Show("Error: Database not connected properly. Please check your connection and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
