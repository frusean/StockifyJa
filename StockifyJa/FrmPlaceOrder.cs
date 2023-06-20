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
    public partial class FrmPlaceOrder : Form
    {
        private stockifydBEntities _db;

        public FrmPlaceOrder()
        {
            InitializeComponent();
            _db = new stockifydBEntities();
            _db.Database.CommandTimeout = 180;
            btnViewOrder.Enabled = false;

            var productList = _db.Products.ToList();
            productList.Insert(0, new Product { ProductName = "Select a product", ProductID = 0 });

            cbProduct.DataSource = productList;
            cbProduct.DisplayMember = "ProductName";
            cbProduct.ValueMember = "ProductID";
            cbProduct.SelectedIndexChanged += cbProduct_SelectedIndexChanged;
            cbProduct.DropDownStyle = ComboBoxStyle.DropDownList;

            nudQuantity.ValueChanged += nudQuantity_ValueChanged;
            nudQuantity.ReadOnly = true;
            nudQuantity.KeyPress += new KeyPressEventHandler(nudQuantity_KeyPress);
        }

        private void nudQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Ignore all key press events
            e.Handled = true;
        }

        private async void cbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product selectedProduct = cbProduct.SelectedItem as Product;

            if (selectedProduct != null && selectedProduct.ProductID != 0)
            {
                int productId = selectedProduct.ProductID;

                var stock = await Task.Run(() =>
                {
                    try
                    {
                        return _db.Stocks.FirstOrDefault(s => s.ProductID == productId);
                    }
                    catch (Exception ex)
                    {
                        // Handle exception as necessary
                        Console.WriteLine(ex.ToString());
                        return null;
                    }
                });

                if (stock != null)
                {
                    nudQuantity.Maximum = (decimal)stock.QuantityInStock.GetValueOrDefault();
                    nudQuantity.ReadOnly = false;
                }
                else
                {
                    nudQuantity.ReadOnly = true;
                }
            }
        }

        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {
            if (cbProduct.SelectedItem is Product selectedProduct && selectedProduct.ProductID != 0)
            {
                var stock = _db.Stocks.FirstOrDefault(s => s.ProductID == selectedProduct.ProductID);

                if (stock != null && nudQuantity.Value > (decimal)stock.QuantityInStock.GetValueOrDefault())
                {
                    MessageBox.Show($"You cannot select more than {stock.QuantityInStock} of {selectedProduct.ProductName}");
                    nudQuantity.Value = (decimal)stock.QuantityInStock.GetValueOrDefault();
                }
            }
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            if (cbProduct.SelectedItem is Product selectedProduct && selectedProduct.ProductID != 0)
            {
                var stock = _db.Stocks.FirstOrDefault(s => s.ProductID == selectedProduct.ProductID);
                if (stock != null)
                {
                    if (nudQuantity.Value > (decimal)stock.QuantityInStock.GetValueOrDefault())
                    {
                        MessageBox.Show($"The selected quantity exceeds the available stock. \n\n" +
                                        $"Product: {selectedProduct.ProductName}\n" +
                                        $"Maximum available quantity: {stock.QuantityInStock}",
                                        "Quantity Exceeds Stock",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        // Create an instance of ItemDetails and populate it with the captured information
                        ItemDetails itemDetails = new ItemDetails
                        {
                            ProductName = selectedProduct.ProductName,
                            Quantity = (int)nudQuantity.Value,
                            Price = selectedProduct.Price.GetValueOrDefault()
                        };

                        // Display the captured information in a MessageBox
                        MessageBox.Show($"The product has been successfully added to your cart. \n\n" +
                                        $"Product: {itemDetails.ProductName}\n" +
                                        $"Quantity: {itemDetails.Quantity}\n" +
                                        $"Price per unit: {itemDetails.Price:C}",
                                        "Product Added to Cart",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                        // Add the itemDetails object to the ListBox
                        lbxCart.Items.Add(itemDetails.ToString());

                        // Deduct from stock
                        stock.QuantityInStock -= (int)nudQuantity.Value;
                        // _db.SaveChanges();

                        // Enable View Order button after adding an item to the cart
                        btnViewOrder.Enabled = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a product before proceeding.",
                                "No Product Selected",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void btnRemoveFromOrder_Click(object sender, EventArgs e)
        {
            if (lbxCart.SelectedItem != null)
            {
                lbxCart.Items.Remove(lbxCart.SelectedItem);

                // If cart is empty, disable View Order button
                if (lbxCart.Items.Count == 0)
                {
                    btnViewOrder.Enabled = false;
                }
            }
        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            List<string> selectedItems = lbxCart.Items.Cast<string>().ToList();
            FrmOrderSummary frmOrderSummary = new FrmOrderSummary(selectedItems);
            frmOrderSummary.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPlaceOrder_Load(object sender, EventArgs e)
        {
            // Code to execute when the form loads
        }

        private void lbxCart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}