﻿using System;
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
    public partial class UCProductDetails : UserControl
    {
        public UCProductDetails()
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
            set { lblProductPrice.Text = "Price: $ " + value.ToString(); }
        }

        public decimal Discount
        {
            /* get { return decimal.Parse(lblDiscount.Text); } // Assumes lblDiscount is a label that will display the Discount
             set { lblDiscount.Text = value.ToString() + "% off"; } // Set the text of lblDiscount to show the discount percentage*/
            get
            {
                // Attempt to parse the discount from the label text
                if (decimal.TryParse(lblDiscount.Text.Replace("% off", ""), out decimal discount))
                {
                    return discount;
                }
                // Default to 0 if the label text cannot be parsed
                return 0;
            }
            set
            {
                // Only show the discount if it is not zero
                if (value != 0)
                {
                    // Format the discount as a percentage and update the label text
                    lblDiscount.Text = (value * 100).ToString() + "% off";
                }
                else
                {
                    lblDiscount.Text = "";
                }
            }
        }

        public Image ProductImage
        {
            get { return picProduct.Image; }
            set { picProduct.Image = value; }
        }

        public string Description
        {
            get { return lblDescription.Text; }
            set { lblDescription.Text = "Description: " + value; }
        }

        public string Category
        {
            get { return lblCategory.Text; }
            set { lblCategory.Text = "Category: " + value; }
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


    }
}
