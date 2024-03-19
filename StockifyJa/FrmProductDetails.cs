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
using Stripe;

namespace StockifyJa
{
    public partial class FrmProductDetails : Form
    {
        private int ProductId;
        public FrmProductDetails(int productId)
        {
            InitializeComponent();
            this.ProductId = productId;
        }
        private async void FrmProductDetails_Load(object sender, EventArgs e)
        {
            using (var context = new sTockifyJaEntities())
            {
                var product = await (from p in context.Products
                                     join i in context.ProductImages on p.ProductID equals i.ProductID
                                     join s in context.Stocks on p.ProductID equals s.ProductID
                                     join r in context.Rates on p.RateID equals r.ID 
                                     where p.ProductID == this.ProductId
                                     select new
                                     {
                                         ProductId = p.ProductID,
                                         ProductName = p.ProductName,
                                         Description = p.Description,
                                         Category = p.Category,
                                         ImageUrl = i.ImageURL,
                                         Price = p.Price,
                                         Discount = r.Discount, 
                                         Stock = s.QuantityInStock
                                     }).FirstOrDefaultAsync();

                if (product != null)
                {
                    UCProductDetails productControl = new UCProductDetails();
                    productControl.ProductId = product.ProductId;
                    productControl.ProductName = product.ProductName;
                    productControl.Description = product.Description;
                    productControl.Category = product.Category;
                    productControl.ProductPrice = (decimal)product.Price;
                    productControl.Discount = (decimal)product.Discount;
                    productControl.Stock = product.Stock.HasValue ? product.Stock.Value : 0;

                    productControl.ProductImage = await LoadImageAsync(product.ImageUrl);
                    flpProductDetails.Controls.Add(productControl);
                }
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

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
