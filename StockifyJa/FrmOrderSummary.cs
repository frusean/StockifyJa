using StockifyjaLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockifyJa
{
    public partial class FrmOrderSummary : Form
    {
        private List<ItemDetails> _cartItems;
        public FrmOrderSummary(List<ItemDetails> cartItems)
        {
            InitializeComponent();
            _cartItems = cartItems;

            decimal total = 0;

            foreach (ItemDetails item in _cartItems)
            {
                lbxOrderSummary.Items.Add(item.ToString());

                decimal quantity = item.Quantity;
                decimal price = item.Price;
                total += quantity * price;
            }

            decimal gct = total * 0.15m;
            lblGCT.Text = $"GCT (15%): {gct:C}";
            lblTotal.Text = $"Total: {(total + gct):C}";
        }

        private void pbxContinueToPayment_Click(object sender, EventArgs e)
        {
            // Extract the numeric part of the string
            string totalText = lblTotal.Text.Replace("Total: ", "").Trim();

            if (Decimal.TryParse(totalText, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal total))
            {
                FrmPayment frmPayment = new FrmPayment(_cartItems);
                frmPayment.TotalAmount = total;
                frmPayment.Show();
            }
            else
            {
                MessageBox.Show("Could not parse the total amount.");
            }
        }

        private void FrmOrderSummary_Load(object sender, EventArgs e)
        {

        }
    }
    }

