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
        private sTockifyJaEntities StockifydBEntities;
        private Supply currentSupply = null;
        public FrmManageSupplies()
        {
            InitializeComponent();
            StockifydBEntities = new sTockifyJaEntities();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public List<Stock> CheckLowStock()
        {
            using (var context = new stockifydBEntities())
            {
                // Get all stocks that have 10 or less quantity.
                var lowStocks = context.Stocks.Where(s => s.QuantityInStock <= 10).ToList();

                return lowStocks;
            }
        }

        private void FrmManageSupplies_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
            var lowStocks = CheckLowStock();

            if (lowStocks.Count > 0)
            {
                StringBuilder lowStockMessage = new StringBuilder("Warning: The following products have low stock:\n\n");

                foreach (var stock in lowStocks)
                {
                    string productName = stock.ProductID.HasValue ? GetProductNameById(stock.ProductID.Value) : "Unknown Product";

                    lowStockMessage.AppendLine($"Product Name: {productName} Quantity: {stock.QuantityInStock}");
                }

                MessageBox.Show(lowStockMessage.ToString(), "Stock Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private string GetProductNameById(int productId)
        {
            return StockifydBEntities.Products.Where(p => p.ProductID == productId).Select(p => p.ProductName).FirstOrDefault();
        }
        private void picAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtProductID.Text) ||
                    nudQuantityPurchased.Value <= 0 ||
                    string.IsNullOrWhiteSpace(txtCost.Text))
                {
                    MessageBox.Show("Please ensure all fields are properly filled in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int productID = int.Parse(txtProductID.Text);
                decimal cost = decimal.Parse(txtCost.Text);

                if (!StockifydBEntities.Products.Any(p => p.ProductID == productID))
                {
                    MessageBox.Show("Invalid Product ID. Please make sure the Product ID exists.","Invalid Product ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var addedSupply = AddSupplyAndUpdateStock(productID, (int)nudQuantityPurchased.Value, cost); // Capture the added supply

                // Update the associated stock
                var associatedStock = StockifydBEntities.Stocks.FirstOrDefault(s => s.ProductID == addedSupply.ProductID);
                if (associatedStock != null)
                {
                    txtSupplyID.Text = addedSupply.SupplyID.ToString();
                    txtStockID.Text = associatedStock.StockID.ToString();
                    txtQuantityInStock.Text = associatedStock.QuantityInStock.ToString();
                }

                RefreshDataGridView();
                MessageBox.Show("Product successfully added!","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        txtSupplyID.Text = currentSupply.SupplyID.ToString(); // Display SupplyID
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
                    else
                    {
                        MessageBox.Show("Supply not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a supply.", "Invalid Supply", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

                            var result = MessageBox.Show(message, "Confirm Deletion", MessageBoxButtons.YesNo,  MessageBoxIcon.Warning);

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
                            MessageBox.Show("Stock not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Supply not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a supply.","Invalid Supply", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

            currentSupply = null; 
        }

        private void picSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtProductID.Text) ||
                    nudQuantityPurchased.Value <= 0 ||
                    string.IsNullOrWhiteSpace(txtCost.Text))
                {
                    MessageBox.Show("Please ensure all fields are filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int productID = int.Parse(txtProductID.Text);
                decimal cost = decimal.Parse(txtCost.Text);

                if (!StockifydBEntities.Products.Any(p => p.ProductID == productID))
                {
                    MessageBox.Show("Invalid Product ID. Please make sure the Product ID exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        private Supply AddSupplyAndUpdateStock(int productId, int quantity, decimal cost)
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

            return supply; // Return added supply
                       
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
        
        MessageBox.Show("Error: Database not connected properly. Please check your connection and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
        }
    }
}
