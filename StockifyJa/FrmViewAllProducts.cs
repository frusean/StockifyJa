using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockifyJa
{
    public partial class FrmViewAllProducts : Form
    {
        private List<UCProduct> originalProductControls;
        public FrmViewAllProducts()
        {
            InitializeComponent();
            originalProductControls = new List<UCProduct>();
             refreshTimer.Start();
        }

        private async void FrmViewAllProducts_Load(object sender, EventArgs e)
        {
            /*
            using (var context = new stockifydBEntities())
            {
                var products = from p in context.Products
                               join i in context.ProductImages on p.ProductID equals i.ProductID
                               join s in context.Stocks on p.ProductID equals s.ProductID
                               join r in context.Rates on p.RateID equals r.ID // Join on RateID
                               select new
                               {
                                   ProductId = p.ProductID,
                                   ProductName = p.ProductName,
                                   ImageUrl = i.ImageURL,
                                   Price = p.Price,
                                   Stock = s.QuantityInStock,
                                   Discount = r.Discount
                               };

                foreach (var product in products)
                {
                    UCProduct productControl = new UCProduct();
                    productControl.ProductId = product.ProductId;
                    productControl.ProductName = product.ProductName;
                    productControl.ProductPrice = (decimal)product.Price;
                    productControl.Stock = product.Stock.HasValue ? product.Stock.Value : 0;
                    productControl.Discount = (decimal)product.Discount;
                    productControl.Width = flpProducts.Width / 4;

                    productControl.ProductImage = await LoadImageAsync(product.ImageUrl);
                    flpProducts.Controls.Add(productControl);
                    originalProductControls.Add(productControl);
                }
            }*/
            try
            {
                // Stop the timer while refreshing the data
                refreshTimer.Stop();

                using (var context = new stockifydBEntities())
                {
                    // Clear originalProductControls list
                    originalProductControls.Clear();
                    flpProducts.Controls.Clear(); // Clear the existing controls

                    var products = from p in context.Products
                                   join i in context.ProductImages on p.ProductID equals i.ProductID
                                   join s in context.Stocks on p.ProductID equals s.ProductID
                                   join r in context.Rates on p.RateID equals r.ID
                                   select new
                                   {
                                       ProductId = p.ProductID,
                                       ProductName = p.ProductName,
                                       ImageUrl = i.ImageURL,
                                       Price = p.Price,
                                       Stock = s.QuantityInStock,
                                       Discount = r.Discount
                                   };

                    // Force all tracked entities to be reloaded from the database
                    foreach (var entity in context.ChangeTracker.Entries())
                    {
                        entity.Reload();
                    }

                    foreach (var product in products)
                    {
                        UCProduct productControl = new UCProduct();
                        productControl.ProductId = product.ProductId;
                        productControl.ProductName = product.ProductName;
                        productControl.ProductPrice = (decimal)product.Price;
                        productControl.Stock = product.Stock.HasValue ? product.Stock.Value : 0;
                        productControl.Discount = (decimal)product.Discount;
                        productControl.Width = flpProducts.Width / 4;

                        productControl.ProductImage = await LoadImageAsync(product.ImageUrl);
                        flpProducts.Controls.Add(productControl);

                        // Add newly created UCProduct to originalProductControls list
                        originalProductControls.Add(productControl);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Restart the timer
               refreshTimer.Start();
            }

        }


        public async Task<Image> LoadImageAsync(string imageUrl)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(imageUrl);
            request.UserAgent = "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident/6.0)";

            using (var response = await request.GetResponseAsync())
            using (var stream = response.GetResponseStream())
            {
                return Image.FromStream(stream);
            }
        }

        private async void picSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text;
            await SearchProductsAsync(searchText);
        }

        private async Task SearchProductsAsync(string searchText)
        {
            flpProducts.Controls.Clear(); // clear out the old controls

            // If search text is empty, reset to original view
            if (string.IsNullOrWhiteSpace(searchText))
            {
                ResetToOriginalView();
                return;
            }

            using (var context = new stockifydBEntities())
            {
                var productsQuery = from p in context.Products
                                    join i in context.ProductImages on p.ProductID equals i.ProductID
                                    join s in context.Stocks on p.ProductID equals s.ProductID
                                    join r in context.Rates on p.RateID equals r.ID 
                                    select new
                                    {
                                        ProductId = p.ProductID,
                                        ProductName = p.ProductName,
                                        ImageUrl = i.ImageURL,
                                        Price = p.Price,
                                        Stock = s.QuantityInStock,
                                        Discount = r.Discount
                                    };

                decimal price;
                bool isDecimal = Decimal.TryParse(searchText, out price);

                if (isDecimal)
                {
                    productsQuery = productsQuery.Where(p => p.Price == price);
                }
                else
                {
                    productsQuery = productsQuery.Where(p => p.ProductName.Contains(searchText));
                }

                var products = await productsQuery.ToListAsync();

                if (products.Count == 0)
                {
                    MessageBox.Show("No results were found.", "Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                foreach (var product in products)
                {
                    UCProduct productControl = new UCProduct();
                    productControl.ProductId = product.ProductId;
                    productControl.ProductName = product.ProductName;
                    productControl.ProductPrice = (decimal)product.Price;
                    productControl.Stock = product.Stock.HasValue ? product.Stock.Value : 0;
                    productControl.Discount = (decimal)product.Discount;
                    productControl.Width = flpProducts.Width / 4;

                    productControl.ProductImage = await LoadImageAsync(product.ImageUrl);
                    flpProducts.Controls.Add(productControl);
                }
            }
        }

        private void ResetToOriginalView()
        {
            flpProducts.Controls.Clear();
            foreach (var productControl in originalProductControls)
            {
                flpProducts.Controls.Add(productControl);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                ResetToOriginalView();
            }
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
           FrmViewAllProducts_Load(sender, e);
        }

        private void picRefresh_Click(object sender, EventArgs e)
        {
            {
                FrmViewAllProducts_Load(sender, e);
                
            }
        }
    }
}
