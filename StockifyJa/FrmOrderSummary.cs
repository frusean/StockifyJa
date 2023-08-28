using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
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
        private stockifydBEntities _db = new stockifydBEntities();

        private List<ItemDetails> _cartItems;
        private decimal _totalAmount;
        private decimal _gctAmount;

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

            _totalAmount = total;
            _gctAmount = total * 0.15m;
            lblGCT.Text = $"GCT (15%): {_gctAmount:C}";
            lblTotal.Text = $"Total: {_totalAmount + _gctAmount:C}";

        }

        private void pbxContinueToPayment_Click(object sender, EventArgs e)
        {
          
            FrmPayment frmPayment = new FrmPayment(_cartItems, _gctAmount, _totalAmount + _gctAmount);
            frmPayment.Show();

            frmPayment.Show();
        }




        private void FrmOrderSummary_Load(object sender, EventArgs e)
        {

        }

        private void lbxOrderSummary_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


       
    }
}

