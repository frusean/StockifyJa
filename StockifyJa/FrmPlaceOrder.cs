﻿
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
using StockifyjaLib;

namespace StockifyJa
{


    public partial class FrmPlaceOrder : Form
    {
        private stockifydBEntities _db;
        private List<ItemDetails> _cartItems;

        public FrmPlaceOrder()
        {
            InitializeComponent();
            _db = new stockifydBEntities();
            _db.Database.CommandTimeout = 180;
            btnViewOrder.Enabled = false;
            _cartItems = new List<ItemDetails>();

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
            btnRemoveFromOrder.Click += new System.EventHandler(this.btnRemoveFromOrder_Click);

            // Load AppState.CartItems into the lbxCart ListBox
            foreach (var item in AppState.CartItems)
            {
                lbxCart.Items.Add(item.ToString());
            }
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

                Stock stock = null;
                try
                {
                    stock = await _db.Stocks.FirstOrDefaultAsync(s => s.ProductID == productId);
                }
                catch (Exception ex)
                {
                    // Handle exception as necessary
                    Console.WriteLine(ex.ToString());
                }

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
                        ItemDetails itemDetails = new ItemDetails
                        {
                            ProductName = selectedProduct.ProductName,
                            Quantity = (int)nudQuantity.Value,
                            Price = selectedProduct.Price.GetValueOrDefault(),
                            ProductID = selectedProduct.ProductID
                        };

                        AppState.CartItems.Add(itemDetails);
                        lbxCart.Items.Add(itemDetails.ToString());

                        MessageBox.Show($"The product has been successfully added to your cart. \n\n" +
                                        $"Product: {itemDetails.ProductName}\n" +
                                        $"Quantity: {itemDetails.Quantity}\n" +
                                        $"Price per unit: {itemDetails.Price:C}",
                                        "Product Added to Cart",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        btnViewOrder.Enabled = true;

                        Cart newCartItem = new Cart
                        {
                            UserID = AppState.CurrentUserID,
                            ProductID = selectedProduct.ProductID,
                            Quantity = (int)nudQuantity.Value
                        };

                        _db.Carts.Add(newCartItem);
                        _db.SaveChanges();

                        // After saving, set the CartItemID
                        itemDetails.CartItemID = newCartItem.CartID;
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









        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            FrmOrderSummary frmOrderSummary = new FrmOrderSummary(AppState.CartItems);
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

        private void FrmPlaceOrder_Load_1(object sender, EventArgs e)
        {

        }

        private void btnRemoveFromOrder_Click(object sender, EventArgs e)
        {
            if (lbxCart.SelectedItem != null)
            {
                string selectedItemString = lbxCart.SelectedItem.ToString();

                // Find the corresponding CartItem in AppState.CartItems
                ItemDetails selectedItem = AppState.CartItems.FirstOrDefault(ci => ci.ToString() == selectedItemString);

                if (selectedItem != null)
                {
                    // Remove from AppState.CartItems
                    AppState.CartItems.Remove(selectedItem);

                    // Remove from database
                    var cartItem = _db.Carts.FirstOrDefault(ci => ci.CartID == selectedItem.CartItemID);
                    if (cartItem != null)
                    {
                        _db.Carts.Remove(cartItem);
                        _db.SaveChanges();
                    }
                }

                // Remove from ListBox
                lbxCart.Items.Remove(lbxCart.SelectedItem);

                // If cart is empty, disable View Order button
                if (lbxCart.Items.Count == 0)
                {
                    btnViewOrder.Enabled = false;
                }
            }

    }
    }
}
