
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace StockifyJa
{
    public partial class FrmManageOrders : Form
    {
        private sTockifyJaEntities _db;

        public FrmManageOrders()
        {
            InitializeComponent();
            _db = new sTockifyJaEntities();
            LoadDataGrid();
        }

        private void LoadDataGrid()
        {
            var orderData = from order in _db.Orders
                            join orderDetail in _db.OrderDetails on order.OrderID equals orderDetail.OrderID
                            select new
                            {
                                OrderID = order.OrderID,
                                RetailerID = order.RetailerID,
                                OrderDate = order.OrderDate,
                                Total = order.Total,
                                StatusID = order.StatusID,
                                OrderDetailID = orderDetail.OrderDetailID,
                                ProductID = orderDetail.ProductID,
                                QuantityOrdered = orderDetail.QuantityOrdered,
                                Price = orderDetail.Price
                            };

            dgvOrders.DataSource = orderData.ToList();
        }

       

        private void dtpDateOrdered_ValueChanged(object sender, EventArgs e)
        {

        }

       
        private void picUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvOrders.CurrentRow != null)
                {
                    txtOrderID.Text = dgvOrders.CurrentRow.Cells["OrderID"].Value.ToString();

                    DateTime orderDate;
                    if (DateTime.TryParse(dgvOrders.CurrentRow.Cells["OrderDate"].Value.ToString(), out orderDate))
                    {
                        dtpDateOrdered.Value = orderDate;
                    }
                    else
                    {
                        MessageBox.Show("Invalid order date.");
                        return;
                    }

                    txtTotal.Text = dgvOrders.CurrentRow.Cells["Total"].Value.ToString();

                    int productID = Convert.ToInt32(dgvOrders.CurrentRow.Cells["ProductID"].Value.ToString());
                    cmbProductID.SelectedItem = productID;

                    decimal quantityOrdered;
                    if (Decimal.TryParse(dgvOrders.CurrentRow.Cells["QuantityOrdered"].Value.ToString(), out quantityOrdered))
                    {
                        nudQuantityOrdered.Value = quantityOrdered;
                    }
                    else
                    {
                        MessageBox.Show("Invalid quantity ordered.");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void txtOrderID_TextChanged(object sender, EventArgs e)
        {

        }

        private void nudQuantityOrdered_ValueChanged(object sender, EventArgs e)
        {
            var selectedProductId = Convert.ToInt32(cmbProductID.SelectedItem);
            var stock = _db.Stocks.FirstOrDefault(s => s.ProductID == selectedProductId);

            if (stock != null)
            {
                if (nudQuantityOrdered.Value > stock.QuantityInStock)
                {
                    MessageBox.Show($"Cannot order more than available stock. Current stock: {stock.QuantityInStock}",
                                    "Insufficient Stock",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    nudQuantityOrdered.Value = stock.QuantityInStock.HasValue ? Convert.ToDecimal(stock.QuantityInStock.Value) : 0;
                }
            }

            
            picAdd.Enabled = nudQuantityOrdered.Value >= 1;
        }



        private void FrmManageOrders_Load(object sender, EventArgs e)
        {
            var productIDs = (from product in _db.Products
                              select product.ProductID).ToList();

            cmbProductID.DataSource = productIDs;
            cmbProductID.SelectedIndexChanged += CmbProductID_SelectedIndexChanged;
        }

        private void CmbProductID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int productId;
            if (int.TryParse(cmbProductID.SelectedItem.ToString(), out productId))
            {
                var stock = _db.Stocks.FirstOrDefault(s => s.ProductID == productId);
                if (stock != null)
                {
                    nudQuantityOrdered.Value = stock.QuantityInStock.HasValue ? Convert.ToDecimal(stock.QuantityInStock.Value) : 0;

                }
            }
        }

        private void picAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the quantity is less than 1. If it is, show a message and return early.
                if (nudQuantityOrdered.Value < 1)
                {
                    MessageBox.Show("Please select a quantity of at least 1.",
                                    "Invalid Quantity",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                int productId;
                if (!Int32.TryParse(cmbProductID.SelectedItem.ToString(), out productId))
                {
                    MessageBox.Show("Product ID must be a valid integer.");
                    return;
                }

                var product = _db.Products.FirstOrDefault(p => p.ProductID == productId);

                if (product == null)
                {
                    MessageBox.Show("Product not found.");
                    return;
                }

                decimal? pricePerProduct = product.Price;

                if (pricePerProduct == null)
                {
                    MessageBox.Show("Product price is not set.");
                    return;
                }

                decimal total = nudQuantityOrdered.Value * pricePerProduct.Value;
                decimal gct = total * (decimal)0.15;
                total += gct;

                Order newOrder = new Order
                {
                    OrderDate = dtpDateOrdered.Value,
                    Total = total,
                };

                _db.Orders.Add(newOrder);
                _db.SaveChanges();

                OrderDetail newOrderDetail = new OrderDetail
                {
                    OrderID = newOrder.OrderID,
                    ProductID = productId,
                    QuantityOrdered = Convert.ToInt32(nudQuantityOrdered.Value),
                    Price = total
                };

                _db.OrderDetails.Add(newOrderDetail);

                var stock = _db.Stocks.FirstOrDefault(s => s.ProductID == productId);
                if (stock != null)
                {
                    stock.QuantityInStock -= newOrderDetail.QuantityOrdered;
                }

                _db.SaveChanges();

                LoadDataGrid();

                MessageBox.Show("Order made successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void picRefresh_Click(object sender, EventArgs e)
        {
            txtOrderID.Text = "";
            txtTotal.Text = "";
            nudQuantityOrdered.Value = 0;
            dtpDateOrdered.Value = DateTime.Now;
        }

        private void picDelete_Click(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow != null)
            {
                var orderIdStr = dgvOrders.CurrentRow.Cells["OrderID"].Value.ToString();

                if (!int.TryParse(orderIdStr, out var orderId))
                {
                    MessageBox.Show("Selected row doesn't have a valid OrderID.", "Invalid Selection",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirmResult = MessageBox.Show("Are you sure you want to delete this entry?", "Confirm Delete!",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    var orderToDelete = _db.Orders.FirstOrDefault(o => o.OrderID == orderId);

                    if (orderToDelete != null)
                    {
                        _db.Orders.Remove(orderToDelete);

                        var orderDetailsToDelete = _db.OrderDetails.Where(od => od.OrderID == orderId);

                        foreach (var orderDetail in orderDetailsToDelete)
                        {
                            _db.OrderDetails.Remove(orderDetail);
                        }

                        _db.SaveChanges();
                        LoadDataGrid();

                        MessageBox.Show("Order deleted successfully.", "Success",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No order found with the selected OrderID.", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row in the DataGridView.", "No Selection",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void picSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtOrderID.Text))
                {
                    MessageBox.Show("Order ID is required to save changes.");
                    return;
                }

                int orderId;
                if (!Int32.TryParse(txtOrderID.Text, out orderId))
                {
                    MessageBox.Show("Order ID must be a valid integer.");
                    return;
                }

                Order order = _db.Orders.FirstOrDefault(o => o.OrderID == orderId);

                if (order == null)
                {
                    MessageBox.Show("Order not found.");
                    return;
                }

                order.OrderDate = dtpDateOrdered.Value;

                decimal total;
                if (!Decimal.TryParse(txtTotal.Text, out total))
                {
                    MessageBox.Show("Total must be a valid decimal.");
                    return;
                }

                order.Total = total;

                _db.SaveChanges();

                LoadDataGrid();

                MessageBox.Show("Order updated successfully.");
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

      
    }
}

