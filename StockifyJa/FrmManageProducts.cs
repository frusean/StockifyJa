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
    public partial class FrmManageProducts : Form
    {
        private stockifydBEntities StockifydBEntities;
        public FrmManageProducts()
        {
            InitializeComponent();
            StockifydBEntities = new stockifydBEntities();
        }


        private void picAdd_Click(object sender, EventArgs e)
        {

            string category = txtCategory.Text;
            string productName = txtProductName.Text;
            string description = txtDescription.Text;
            string price = txtPrice.Text;
            string imageURL = txtImageURL.Text;
            int rateID = int.Parse(cboRates.SelectedItem.ToString());

            var isValid = true;

            if (isValid)
            {
                try
                {
                    // Fetch the last product ID and image ID, and increment them for the new entries
                    int lastProductID = StockifydBEntities.Products.Any() ? StockifydBEntities.Products.Max(p => p.ProductID) : 0;
                    int lastImageID = StockifydBEntities.ProductImages.Any() ? StockifydBEntities.ProductImages.Max(i => i.ImageID) : 0;

                    var product = new Product
                    {
                        ProductID = lastProductID + 1,
                        ProductName = productName,
                        Category = category,
                        Description = description,
                        Price = decimal.Parse(price),
                        RateID = rateID
                    };

                    var productImage = new ProductImage
                    {
                        ImageID = lastImageID + 1,
                        ImageURL = imageURL,
                        ProductID = product.ProductID
                    };

                    // Add the new product and productImage to the database
                    StockifydBEntities.Products.Add(product);
                    StockifydBEntities.ProductImages.Add(productImage);
                    StockifydBEntities.SaveChanges();

                    // Display the new IDs in the textboxes
                    txtProductID.Text = product.ProductID.ToString();
                    txtImageID.Text = productImage.ImageID.ToString();

                    // Refresh DataGridView
                    RefreshDataGridView();

                    MessageBox.Show("Product Item Successfully Added!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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



            var productID = Microsoft.VisualBasic.Interaction.InputBox("Enter product ID", "Update Product");

            if (!string.IsNullOrEmpty(productID))
            {
                int parsedProductID;
                if (int.TryParse(productID, out parsedProductID))
                {
                    // Fetch the product from the database
                    var productToUpdate = StockifydBEntities.Products.Find(parsedProductID);
                    if (productToUpdate != null)
                    {
                        // Fetch associated image
                        var productImage = StockifydBEntities.ProductImages.FirstOrDefault(i => i.ProductID == productToUpdate.ProductID);

                        // Fill the textboxes with the current values
                        txtProductID.Text = productToUpdate.ProductID.ToString();
                        txtCategory.Text = productToUpdate.Category;
                        txtProductName.Text = productToUpdate.ProductName;
                        txtDescription.Text = productToUpdate.Description;
                        txtPrice.Text = productToUpdate.Price.ToString();
                        cboRates.SelectedItem = productToUpdate.RateID.ToString();
                        txtImageID.Text = productImage?.ImageID.ToString();
                        txtImageURL.Text = productImage?.ImageURL;
                    }
                    else
                    {
                        MessageBox.Show("Product ID was NOT FOUND!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid Product ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
        private void picSave_Click(object sender, EventArgs e)
        {
            string category = txtCategory.Text;
            string productName = txtProductName.Text;
            string description = txtDescription.Text;
            string price = txtPrice.Text;
            string imageURL = txtImageURL.Text;
            int rateID = int.Parse(cboRates.SelectedValue.ToString());


            var isValid = true;



            if (isValid)
            {
                try
                {
                    Product product;
                    ProductImage productImage = null;

                    int productID;
                    if (int.TryParse(txtProductID.Text, out productID))
                    {
                        // Update existing product
                        product = StockifydBEntities.Products.Find(productID);
                        if (product != null)
                        {
                            productImage = StockifydBEntities.ProductImages.FirstOrDefault(i => i.ProductID == product.ProductID);
                        }
                        else
                        {
                            MessageBox.Show("Product ID was NOT FOUND!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        // Add new product
                        product = new Product();
                        StockifydBEntities.Products.Add(product);
                    }

                    product.ProductName = productName;
                    product.Category = category;
                    product.Description = description;
                    product.Price = decimal.Parse(price);
                    product.RateID = rateID;

                    if (productImage == null)
                    {
                        productImage = new ProductImage
                        {
                            ProductID = product.ProductID
                        };
                        StockifydBEntities.ProductImages.Add(productImage);
                    }
                    productImage.ImageURL = imageURL;

                    StockifydBEntities.SaveChanges();
                    if (string.IsNullOrWhiteSpace(productName))
                    {
                        isValid = false;
                        MessageBox.Show("Enter valid Product Name!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtProductName.Focus();
                    }

                    if (string.IsNullOrWhiteSpace(category))
                    {
                        isValid = false;
                        MessageBox.Show("Enter valid Product Category!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCategory.Focus();
                    }

                    if (string.IsNullOrWhiteSpace(description))
                    {
                        isValid = false;
                        MessageBox.Show("Enter valid Product Description!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDescription.Focus();
                    }

                    if (string.IsNullOrWhiteSpace(price))
                    {
                        isValid = false;
                        MessageBox.Show("Enter valid Product Price!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPrice.Focus();
                    }
                    if (string.IsNullOrWhiteSpace(imageURL))
                    {
                        isValid = false;
                        MessageBox.Show("Enter valid Image URL!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDescription.Focus();
                    }
                    // Refresh DataGridView
                    RefreshDataGridView();

                    MessageBox.Show("Product Item Successfully Saved!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void RefreshDataGridView()
        {
            // Clear DataGridView
            dgvProducts.Rows.Clear();

            // Ensure StockifydBEntities and StockifydBEntities.Products are not null
            if (StockifydBEntities != null && StockifydBEntities.Products != null)
            {
                // Load data from database and add to DataGridView
                foreach (var product in StockifydBEntities.Products.ToList())
                {
                    var productImage = StockifydBEntities.ProductImages.FirstOrDefault(i => i.ProductID == product.ProductID);
                    dgvProducts.Rows.Add(
                        product.ProductID,
                        product.ProductName,
                        product.Category,
                        product.Description,
                        product.Price,
                        productImage?.ImageID,
                        productImage?.ImageURL,
                        product.RateID
                    );
                }
            }
            else
            {
                // Handle null StockifydBEntities or StockifydBEntities.Products here
                MessageBox.Show("Error: Database not connected properly. Please check your connection and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picRefresh_Click(object sender, EventArgs e)
        {
            // Refresh DataGridView
            RefreshDataGridView();
        }


        private void picDelete_Click(object sender, EventArgs e)

        {
            
                string productIDInput = Microsoft.VisualBasic.Interaction.InputBox("Enter Product ID to delete", "Delete Product", "", -1, -1);

                if (!string.IsNullOrEmpty(productIDInput))
                {
                    int parsedProductID;
                    if (int.TryParse(productIDInput, out parsedProductID))
                    {
                        var productToDelete = StockifydBEntities.Products.Find(parsedProductID);
                        if (productToDelete != null)
                        {
                            // Fetch associated image
                            var productImage = StockifydBEntities.ProductImages.FirstOrDefault(i => i.ProductID == productToDelete.ProductID);

                            // Display the product details and ask for confirmation to delete
                            var confirmResult = MessageBox.Show($"Are you sure you want to delete this product?\n\n" +
                                $"Product ID: {productToDelete.ProductID}\n" +
                                $"Product Name: {productToDelete.ProductName}\n" +
                                $"Category: {productToDelete.Category}\n" +
                                $"Description: {productToDelete.Description}\n" +
                                $"Price: {productToDelete.Price}\n" +
                                $"Rate ID: {productToDelete.RateID}\n" +
                                $"Image ID: {productImage?.ImageID}\n" +
                                $"Image URL: {productImage?.ImageURL}",
                                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (confirmResult == DialogResult.Yes)
                            {
                                // Remove the product and its associated image from the database
                                StockifydBEntities.Products.Remove(productToDelete);
                                if (productImage != null)
                                {
                                    StockifydBEntities.ProductImages.Remove(productImage);
                                }
                                StockifydBEntities.SaveChanges();

                                // Refresh the DataGridView
                                RefreshDataGridView();

                                MessageBox.Show("Product successfully deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Product ID was NOT FOUND!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid Product ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                
            }


        }
        private void FrmManageProducts_Load(object sender, EventArgs e)
        {

             // Populate the DataGridView with the current list of products
    // RefreshDataGridView();

    // Populate the rates ComboBox with the current list of rates
    var rates = StockifydBEntities.Rates
        .ToList() // Materialize the query here
        .Select(r => new
        {
            r.ID,
            DisplayValue = $"{r.Discount}, {r.GCT}"
        })
        .ToList();

    // Insert a dummy rate at the beginning
    rates.Insert(0, new { ID = 0, DisplayValue = "" });

    cboRates.DataSource = rates;
    cboRates.DisplayMember = "DisplayValue";
    cboRates.ValueMember = "ID";

    cboRates.SelectedIndex = 0; // Set "" as the default selected item
        }
    }
    }
