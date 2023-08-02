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
    public partial class FrmManageOrders : Form
    {

        private stockifydBEntities _db;
        public FrmManageOrders()
        {
            InitializeComponent();
            _db = new stockifydBEntities();
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
        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpDateOrdered_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantityOrdred_TextChanged(object sender, EventArgs e)
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

                    txtProductID.Text = dgvOrders.CurrentRow.Cells["ProductID"].Value.ToString();

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

        }

        private void FrmManageOrders_Load(object sender, EventArgs e)
        {

        }


        
        private void picAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtProductID.Text))
                {
                    MessageBox.Show("Product ID is required.");
                    return;
                }

                int productId;

                if (!Int32.TryParse(txtProductID.Text, out productId))
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

                // Now it's safe to calculate the total cost
                decimal total = nudQuantityOrdered.Value * pricePerProduct.Value;

                // Calculate GCT
                decimal gct = total * (decimal)0.15;

                // Total cost including GCT
                total += gct;

                // Create new order
                Order newOrder = new Order
                {
                    OrderDate = dtpDateOrdered.Value,
                    Total = total,
                };

                // Add new order to database
                _db.Orders.Add(newOrder);
                _db.SaveChanges();

                // Create new order detail
                OrderDetail newOrderDetail = new OrderDetail
                {
                    OrderID = newOrder.OrderID,
                    ProductID = productId,
                    QuantityOrdered = Convert.ToInt32(nudQuantityOrdered.Value),
                    Price = total // total price including GCT
                };

                // Add new order detail to database
                _db.OrderDetails.Add(newOrderDetail);
                _db.SaveChanges();

                // Reload DataGridView
                LoadDataGrid();

                // Show the success message
                MessageBox.Show("Order made successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}

