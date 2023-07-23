using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Rpc;
using Google.Type;
using static Google.Rpc.Context.AttributeContext.Types;
using static System.Net.Mime.MediaTypeNames;

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

            int rateID = cboRates.SelectedValue == null ? 0 : (int)cboRates.SelectedValue;

            var isValid = true;

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
                txtImageURL.Focus();
            }

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
                    UpdateImage();
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
                      
            if (dgvProducts.SelectedRows.Count > 0)  // Check if a row is selected
            {
                int productID = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells["ProductID"].Value);  // Fetch the ProductID of the selected row

                var productToUpdate = StockifydBEntities.Products.Find(productID);
                if (productToUpdate != null)
                {
                    var productImage = StockifydBEntities.ProductImages.FirstOrDefault(i => i.ProductID == productToUpdate.ProductID);

                    txtProductID.Text = productToUpdate.ProductID.ToString();
                    txtCategory.Text = productToUpdate.Category;
                    txtProductName.Text = productToUpdate.ProductName;
                    txtDescription.Text = productToUpdate.Description;
                    txtPrice.Text = productToUpdate.Price.ToString();

                    // Set SelectedValue for the ComboBox, not SelectedItem
                    cboRates.SelectedValue = productToUpdate.RateID;

                    txtImageID.Text = productImage?.ImageID.ToString();
                    txtImageURL.Text = productImage?.ImageURL;
                    UpdateImage();
                }
                else
                {
                    MessageBox.Show("Product ID was NOT FOUND!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a product from the grid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




       
        private void UpdateImage()
        {
            string imageUrl = txtImageURL.Text; // This is the URL of the image you want to display

            try
            {
                var request = WebRequest.Create(imageUrl); // Create a web request to fetch the image

                using (var response = request.GetResponse()) // Send the web request and get the response
                using (var stream = response.GetResponseStream()) // Get a stream to read the image data from the response
                {
                    picImage.Image = Bitmap.FromStream(stream); // Create an image from the stream and display it in the PictureBox
                }
            }
            catch (Exception ex) // Catch any exceptions that might occur (invalid URL, server error, etc.)
            {
                MessageBox.Show("Could not load image: " + ex.Message); // Display an error message
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
                txtImageURL.Focus();
            }

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
                    //UpdateImage();
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
           // RefreshDataGridView();
            // Clear the text fields
            txtProductID.Text = string.Empty;
            txtCategory.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtPrice.Text = string.Empty;
            cboRates.SelectedItem = null;
            txtImageID.Text = string.Empty;
            txtImageURL.Text = string.Empty;
            picImage.Image = null;
        }


        private void picDelete_Click(object sender, EventArgs e)

        {

            /* if (dgvProducts.SelectedRows.Count == 0)
              {
                  MessageBox.Show("No product selected!", "Error");
                  return;
              }

              // Get product ID from the selected row. Replace "ProductID" with the name of the column holding the product ID.
              var selectedProductID = (int)dgvProducts.SelectedRows[0].Cells["ProductID"].Value;

              try
              {
                  var productToDelete = StockifydBEntities.Products.Find(selectedProductID);
                  UpdateImage();
                  if (productToDelete == null)
                  {
                      MessageBox.Show("Product not found!", "Error");
                      return;
                  }

                  var confirmResult = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Deletion!", MessageBoxButtons.YesNo);
                  if (confirmResult != DialogResult.Yes) return;

                  DeleteProductWithImages(productToDelete);

                  this.Invoke(new Action(() =>
                  {
                      RefreshDataGridView();
                      MessageBox.Show("Product deleted successfully!", "Success");
                  }));
              }
              catch (Exception ex)
              {
                  // Log the exception details as per your logging strategy
                  MessageBox.Show("An error occurred while deleting the product.", "Error");
              }*/
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("No product selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get product ID from the selected row. Replace "ProductID" with the name of the column holding the product ID.
            var selectedProductID = (int)dgvProducts.SelectedRows[0].Cells["ProductID"].Value;

            // Fetch the product and its associated image from the database
            var productToDelete = StockifydBEntities.Products.Find(selectedProductID);
            var productImage = StockifydBEntities.ProductImages.FirstOrDefault(i => i.ProductID == productToDelete.ProductID);

            if (productToDelete == null)
            {
                MessageBox.Show("Product not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Populate the form fields with the product data
            txtProductID.Text = productToDelete.ProductID.ToString();
            txtCategory.Text = productToDelete.Category;
            txtProductName.Text = productToDelete.ProductName;
            txtDescription.Text = productToDelete.Description;
            txtPrice.Text = productToDelete.Price.ToString();
            cboRates.SelectedValue = productToDelete.RateID;

            if (productImage != null)
            {
                txtImageID.Text = productImage.ImageID.ToString();
                txtImageURL.Text = productImage.ImageURL;
                try
                {
                    var request = WebRequest.Create(productImage.ImageURL);
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        picImage.Image = Bitmap.FromStream(stream);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not load image: " + ex.Message);
                }
            }

            // Ask for deletion confirmation
            var confirmResult = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Deletion!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (confirmResult != DialogResult.Yes) return;

            try
            {
                DeleteProductWithImages(productToDelete);

                this.Invoke(new Action(() =>
                {
                    RefreshDataGridView();
                    MessageBox.Show("Product deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void DeleteProductWithImages(Product productToDelete)
        {
            // This should be run in a transaction so that the operation is atomic.
            using (var dbContextTransaction = StockifydBEntities.Database.BeginTransaction())
            {
                try
                {
                    foreach (var image in productToDelete.ProductImages.ToList())
                    {
                        StockifydBEntities.ProductImages.Remove(image);
                    }

                    StockifydBEntities.Products.Remove(productToDelete);

                    StockifydBEntities.SaveChanges();

                    dbContextTransaction.Commit();
                }
                catch (Exception)
                {
                    dbContextTransaction.Rollback();
                    throw;
                }
            }
        }

            private void FrmManageProducts_Load(object sender, EventArgs e)
        {

             // Populate the DataGridView with the current list of products
     RefreshDataGridView();

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

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
