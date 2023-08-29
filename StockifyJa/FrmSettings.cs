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
                    int lastRateID = StockifydBEntities.Rates.Any() ? StockifydBEntities.Rates.Max(r => r.ID) : 0;
                    var rate = new Rate
                    {
                        ID = lastRateID + 1,
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
            if (dgvRates.SelectedRows.Count > 0)
            {
                int rateID = Convert.ToInt32(dgvRates.SelectedRows[0].Cells["ID"].Value);
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



        private void picSave_Click(object sender, EventArgs e)
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

            // Check for dependent Products
            var dependentProducts = StockifydBEntities.Products.Where(p => p.RateID == selectedRateID).ToList();

            if (dependentProducts.Count > 0)
            {
                var confirmResult = MessageBox.Show($"There are {dependentProducts.Count} Products dependent on this Rate. Do you want to set them to NULL and continue?",
                                                    "Confirm Deletion!",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Exclamation);

                if (confirmResult != DialogResult.Yes) return;

                // Set RateID to NULL for dependent Products
                foreach (var product in dependentProducts)
                {
                    product.RateID = null;
                }
            }

            var confirmDelete = MessageBox.Show($"Are you sure you want to delete this rate?\nGCT: {rateToDelete.GCT}\nDiscount: {rateToDelete.Discount}",
                                                "Confirm Deletion!",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Exclamation);

            if (confirmDelete != DialogResult.Yes) return;

            try
            {
                StockifydBEntities.Rates.Remove(rateToDelete);
                StockifydBEntities.SaveChanges();
                RefreshDataGridView();
                MessageBox.Show("Rate deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the rate: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

            dgvStatus.Rows.Clear();
            if (StockifydBEntities != null && StockifydBEntities.Status != null)
            {
                foreach (var status in StockifydBEntities.Status.ToList())
                {
                    dgvStatus.Rows.Add(
                        status.StatusID,
                        status.StatusName
                    );
                }
            }
            else
            {
                MessageBox.Show("Error: Database not connected properly. Please check your connection and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void picAddStatus_Click(object sender, EventArgs e)
        {
            string StatusName = txtStatusName.Text;

            if (string.IsNullOrWhiteSpace(StatusName))
            {
                MessageBox.Show("Enter a valid Status Name!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStatusName.Focus();
                return;
            }

            try
            {
                int lastStatusID = StockifydBEntities.Status.Any() ? StockifydBEntities.Status.Max(s => s.StatusID) : 0;
                var status = new Status
                {
                    StatusID = lastStatusID + 1,
                    StatusName = StatusName
                };

                StockifydBEntities.Status.Add(status);
                StockifydBEntities.SaveChanges();

                txtStatusID.Text = status.StatusID.ToString();
                RefreshDataGridView();

                MessageBox.Show("Status Successfully Added!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picUpdateStatus_Click(object sender, EventArgs e)
        {
            if (dgvStatus.SelectedRows.Count > 0)
            {
                int StatusID = Convert.ToInt32(dgvStatus.SelectedRows[0].Cells["StatusID"].Value);
                var statusToUpdate = StockifydBEntities.Status.Find(StatusID);
                if (statusToUpdate != null)
                {
                    txtStatusID.Text = statusToUpdate.StatusID.ToString();
                    txtStatusName.Text = statusToUpdate.StatusName;
                }
                else
                {
                    MessageBox.Show("Status ID was NOT FOUND!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a status from the grid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picSaveStatus_Click(object sender, EventArgs e)
        {
            string StatusName = txtStatusName.Text;
            if (string.IsNullOrWhiteSpace(StatusName))
            {
                MessageBox.Show("Enter a valid Status Name!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStatusName.Focus();
                return;
            }

            try
            {
                Status status;
                int StatusID;
                if (int.TryParse(txtStatusID.Text, out StatusID))
                {
                    // Update existing status
                    status = StockifydBEntities.Status.Find(StatusID);
                    if (status == null)
                    {
                        MessageBox.Show("Status ID was NOT FOUND!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    // Add new status
                    status = new Status();
                    StockifydBEntities.Status.Add(status);
                }

                status.StatusName = StatusName;
                StockifydBEntities.SaveChanges();

                RefreshDataGridView();

                MessageBox.Show("Status Successfully Saved!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picRefreshStatus_Click(object sender, EventArgs e)
        {
            txtStatusID.Text = string.Empty;
            txtStatusName.Text = string.Empty;
        }

        private void picDeleteStatus_Click(object sender, EventArgs e)
        {
            if (dgvStatus.SelectedRows.Count == 0)
            {
                MessageBox.Show("No status selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedStatusID = (int)dgvStatus.SelectedRows[0].Cells["StatusID"].Value;

            var statusToDelete = StockifydBEntities.Status.Find(selectedStatusID);

            if (statusToDelete == null)
            {
                MessageBox.Show("Status not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check for dependent Orders
            var dependentOrders = StockifydBEntities.Orders.Where(o => o.StatusID == selectedStatusID).ToList();

            if (dependentOrders.Count > 0)
            {
                var confirmResult = MessageBox.Show($"There are {dependentOrders.Count} Orders dependent on this Status. Do you want to set them to NULL and continue?",
                                                    "Confirm Deletion!",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Exclamation);

                if (confirmResult != DialogResult.Yes) return;

                // Set StatusID to NULL for dependent Orders
                foreach (var order in dependentOrders)
                {
                    order.StatusID = null;
                }
            }

            var confirmDelete = MessageBox.Show($"Are you sure you want to delete this status?\nStatus Name: {statusToDelete.StatusName}",
                                                "Confirm Deletion!",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Exclamation);

            if (confirmDelete != DialogResult.Yes) return;

            try
            {
                StockifydBEntities.Status.Remove(statusToDelete);
                StockifydBEntities.SaveChanges();
                RefreshDataGridView();
                MessageBox.Show("Status deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the status: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
