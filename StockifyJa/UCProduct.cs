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
    public partial class UCProduct : UserControl
    {
        public UCProduct()
        {
            InitializeComponent();
        }
        public string ProductName
        {
            get { return lblProductName.Text; }
            set { lblProductName.Text = "Name: " + value; }
        }

        public decimal ProductPrice
        {
            get { return decimal.Parse(lblProductPrice.Text); }
            set { lblProductPrice.Text = "Price: $" + value.ToString(); }
        }

        public Image ProductImage
        {
            get { return picProduct.Image; }
            set { picProduct.Image = value; }
        }


        private int productId;
        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        public int Stock
        {
            get
            {
                if (int.TryParse(lblStock.Text, out int stock))
                {
                    return stock;
                }
                return 0;
            }
            set { lblStock.Text = "In stock: " + value.ToString(); }
        }

        public decimal Discount
        {
            get
            {
                // Attempt to parse the discount from the label text
                if (decimal.TryParse(lblDiscount.Text, out decimal discount))
                {
                    return discount;
                }
                // Default to 0 if the label text cannot be parsed
                return 0;
            }
            set
            {
                // Format the discount as a percentage and update the label text
                lblDiscount.Text = (value * 100).ToString() + "% off";
            }
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            FrmProductDetails details = new FrmProductDetails(productId);
            details.Show();
        }

       
    }
}
