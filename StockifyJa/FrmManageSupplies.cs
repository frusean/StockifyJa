using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockifyJa
{
    public partial class FrmManageSupplies : Form
    {
        private stockifydBEntities StockifydBEntities;
        private Supply currentSupply = null;
        public FrmManageSupplies()
        {
            InitializeComponent();
            StockifydBEntities = new stockifydBEntities();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmManageSupplies_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void picAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtProductID.Text) ||
                    nudQuantityPurchased.Value <= 0 ||
                    string.IsNullOrWhiteSpace(txtCost.Text))
                {
                    MessageBox.Show("Please ensure all fields are properly filled in.");
                    return;
                }

                int productID = int.Parse(txtProductID.Text);
                decimal cost = decimal.Parse(txtCost.Text);

                if (!StockifydBEntities.Products.Any(p => p.ProductID == productID))
                {
                    MessageBox.Show("Invalid Product ID. Please make sure the Product ID exists.");
                    return;
                }

                AddSupplyAndUpdateStock(productID, (int)nudQuantityPurchased.Value, cost);
                RefreshDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
         }

        private void picUpdate_Click(object sender, EventArgs e)
        {
              try
              {
                  // Enable or disable fields as needed
                  txtProductID.ReadOnly = false;
                  nudQuantityPurchased.Enabled = true;
                  txtCost.ReadOnly = false;
                  dtpSupplyDate.Enabled = true;

                  // Disable StockID and QuantityInStock fields
                  txtStockID.ReadOnly = true;
                  txtQuantityInStock.ReadOnly = true;

                  if (dgvSupplies.SelectedCells.Count > 0)
                  {
                      int selectedRowIndex = dgvSupplies.SelectedCells[0].RowIndex;
                      DataGridViewRow selectedRow = dgvSupplies.Rows[selectedRowIndex];
                      int supplyID = Convert.ToInt32(selectedRow.Cells["SupplyID"].Value);

                      currentSupply = StockifydBEntities.Supplies.FirstOrDefault(s => s.SupplyID == supplyID);

                      if (currentSupply != null)
                      {
                          txtProductID.Text = currentSupply.ProductID.ToString();
                          nudQuantityPurchased.Value = (decimal)currentSupply.QuantityPurchased;
                          txtCost.Text = currentSupply.Cost.ToString();
                          dtpSupplyDate.Value = (DateTime)currentSupply.SupplyDate;

                          // get the associated stock
                          var stock = StockifydBEntities.Stocks.FirstOrDefault(s => s.ProductID == currentSupply.ProductID);
                          if (stock != null)
                          {
                              txtStockID.Text = stock.StockID.ToString();
                              txtQuantityInStock.Text = stock.QuantityInStock.ToString();
                          }
                          else
                          {
                              txtStockID.Text = string.Empty;
                              txtQuantityInStock.Text = string.Empty;
                          }
                      }
                  }
              }
              catch (Exception ex)
              {
                  MessageBox.Show($"An error occurred: {ex.Message}");
              }
            
      }

    private void picDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSupplies.SelectedCells.Count > 0)
                {
                    int selectedRowIndex = dgvSupplies.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvSupplies.Rows[selectedRowIndex];
                    int supplyID = Convert.ToInt32(selectedRow.Cells["SupplyID"].Value);

                    currentSupply = StockifydBEntities.Supplies.FirstOrDefault(s => s.SupplyID == supplyID);

                    if (currentSupply != null)
                    {
                        var relatedStock = StockifydBEntities.Stocks.FirstOrDefault(s => s.ProductID == currentSupply.ProductID);

                        if (relatedStock != null)
                        {
                            string message = $"Product ID: {currentSupply.ProductID}\n" +
                                             $"Quantity Purchased: {currentSupply.QuantityPurchased}\n" +
                                             $"Cost: {currentSupply.Cost}\n" +
                                             $"Supply Date: {currentSupply.SupplyDate}\n" +
                                             $"Stock ID: {relatedStock.StockID}\n" +
                                             $"Quantity In Stock: {relatedStock.QuantityInStock}\n" +
                                             $"Are you sure you want to delete Supply ID: {currentSupply.SupplyID}?";

                            var result = MessageBox.Show(message, "Confirm Deletion", MessageBoxButtons.YesNo);

                            if (result == DialogResult.Yes)
                            {
                                StockifydBEntities.Supplies.Remove(currentSupply);
                                StockifydBEntities.SaveChanges();

                                var stockToDelete = StockifydBEntities.Stocks.FirstOrDefault(s => s.ProductID == currentSupply.ProductID);
                                if (stockToDelete != null)
                                {
                                    StockifydBEntities.Stocks.Remove(stockToDelete);
                                    StockifydBEntities.SaveChanges();
                                }

                                RefreshDataGridView();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Related stock not found.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Supply not found.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a supply.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void picRefresh_Click(object sender, EventArgs e)
        {
            // clear the fields
            txtSupplyID.Text = string.Empty;
            txtProductID.Text = string.Empty;
            nudQuantityPurchased.Value = 0;
            txtCost.Text = string.Empty;
            dtpSupplyDate.Value = DateTime.Now;
            txtStockID.Text = string.Empty;
            txtQuantityInStock.Text = string.Empty;

            currentSupply = null; // reset current supply
        }

        private void picSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtProductID.Text) ||
                    nudQuantityPurchased.Value <= 0 ||
                    string.IsNullOrWhiteSpace(txtCost.Text))
                {
                    MessageBox.Show("Please ensure all fields are properly filled in.");
                    return;
                }

                int productID = int.Parse(txtProductID.Text);
                decimal cost = decimal.Parse(txtCost.Text);

                if (!StockifydBEntities.Products.Any(p => p.ProductID == productID))
                {
                    MessageBox.Show("Invalid Product ID. Please make sure the Product ID exists.");
                    return;
                }

                if (currentSupply != null)
                {
                    currentSupply.ProductID = productID;
                    currentSupply.QuantityPurchased = (int)nudQuantityPurchased.Value;
                    currentSupply.Cost = cost;
                    currentSupply.SupplyDate = dtpSupplyDate.Value;

                    StockifydBEntities.Entry(currentSupply).State = EntityState.Modified;
                    StockifydBEntities.SaveChanges();

                    var stockToUpdate = StockifydBEntities.Stocks.FirstOrDefault(s => s.ProductID == currentSupply.ProductID);
                    if (stockToUpdate != null)
                    {
                        stockToUpdate.QuantityInStock += (int)nudQuantityPurchased.Value;
                        StockifydBEntities.Entry(stockToUpdate).State = EntityState.Modified;
                        StockifydBEntities.SaveChanges();
                    }

                    RefreshDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        private void AddSupplyAndUpdateStock(int productId, int quantity, decimal cost)
        {
            // Add supply
            var supply = new Supply()
            {
                ProductID = productId,
                QuantityPurchased = quantity,
                Cost = cost,
                SupplyDate = DateTime.Now
            };
            StockifydBEntities.Supplies.Add(supply);
            StockifydBEntities.SaveChanges();

            // Update stock
            var stock = StockifydBEntities.Stocks.FirstOrDefault(s => s.ProductID == productId);
            if (stock == null)
            {
                stock = new Stock()
                {
                    ProductID = productId,
                    QuantityInStock = quantity
                };
                StockifydBEntities.Stocks.Add(stock);
            }
            else
            {
                stock.QuantityInStock += quantity;
            }
            StockifydBEntities.SaveChanges();
        }

        private void RefreshDataGridView()
        {
            // Clear DataGridView
    dgvSupplies.Rows.Clear();

    // Ensure StockifydBEntities and StockifydBEntities.Supplies are not null
    if (StockifydBEntities != null && StockifydBEntities.Supplies != null)
    {
        // Load data from database and add to DataGridView
        foreach (var supply in StockifydBEntities.Supplies.ToList())
        {
            var stock = StockifydBEntities.Stocks.FirstOrDefault(s => s.ProductID == supply.ProductID);
            dgvSupplies.Rows.Add(
                supply.SupplyID,
                supply.ProductID,
                supply.QuantityPurchased,
                supply.Cost,
                supply.SupplyDate,
                stock?.StockID,
                stock?.QuantityInStock
            );
        }
    }
    else
    {
        // Handle null StockifydBEntities or StockifydBEntities.Supplies here
        MessageBox.Show("Error: Database not connected properly. Please check your connection and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
        }
    }
}
