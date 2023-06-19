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
                if (_db == null)
                {
                    // Handle the case when _db is not initialized
                    throw new InvalidOperationException("_db is not initialized");
                }

                if (_db.Supplies == null)
                {
                    // Handle the case when Supplies is not initialized
                    throw new InvalidOperationException("_db.Supplies is not initialized");
                }

                if (selectedProduct.ProductID == null)
                {
                    // Handle the case when ProductID is not initialized
                    throw new InvalidOperationException("selectedProduct.ProductID is null");
                }

                // get the product ID before running the async task
                int productId = selectedProduct.ProductID;

                try
                {
                    var supply = await Task.Run(() =>
                    {
                        try
                        {
                            return _db.Supplies.FirstOrDefault(s => s.ProductID == productId);
                        }
                        catch (System.Data.Entity.Core.EntityException ex)
                        {
                            // Log the exception (consider using a logging library like log4net, Serilog, NLog, etc.)
                            Console.WriteLine(ex.ToString());

                            // Show a user-friendly error message
                            MessageBox.Show("Oops! An error occurred while communicating with the database.\n" +
                                            "Please try to reconnect or refresh the database connection, or try again later.",
                                            "Database Communication Error",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);

                            // TODO: You might want to attempt to reconnect to the database or take other corrective action here.

                            return null; // return null or some default value
                        }
                        catch (NullReferenceException ex)
                        {
                            // Log the exception
                            Console.WriteLine(ex.ToString());

                            // Show a user-friendly error message
                            MessageBox.Show("Oops! An unexpected error occurred.\n" +
                                            "Please try again later.",
                                            "Unexpected Error",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);

                            return null; // return null or some default value
                        }
                    });

                    if (supply != null)
                    {
                        nudQuantity.Maximum = (decimal)supply.Quantity.GetValueOrDefault();
                        nudQuantity.ReadOnly = false;
                    }
                    else
                    {
                        nudQuantity.ReadOnly = true;
                    }
                }
                catch (Exception ex) // This will catch any other exceptions
                {
                    // Handle any other exceptions that could happen outside of the task
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {
            if (cbProduct.SelectedItem is Product selectedProduct && selectedProduct.ProductID != 0)
            {
                var supply = _db.Supplies.FirstOrDefault(s => s.ProductID == selectedProduct.ProductID);

                if (supply != null && nudQuantity.Value > (decimal)supply.Quantity.GetValueOrDefault())
                {
                    MessageBox.Show($"You cannot select more than {supply.Quantity} of {selectedProduct.ProductName}");
                    nudQuantity.Value = (decimal)supply.Quantity.GetValueOrDefault();
                }
            }
        }

        private void lbxCart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            if (cbProduct.SelectedItem is Product selectedProduct && selectedProduct.ProductID != 0)
            {
                var supply = _db.Supplies.FirstOrDefault(s => s.ProductID == selectedProduct.ProductID);
                if (supply != null)
                {
                    if (nudQuantity.Value > (decimal)supply.Quantity.GetValueOrDefault())
                    {
                        MessageBox.Show($"The selected quantity exceeds the available stock. \n\n" +
                                        $"Product: {selectedProduct.ProductName}\n" +
                                        $"Maximum available quantity: {supply.Quantity}",
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

                        // Deduct from supply
                        supply.Quantity -= (int)nudQuantity.Value;
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

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPlaceOrder_Load(object sender, EventArgs e)
        {

        }
    }
}
