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
        public FrmOrderSummary(List<string> cartItems)
        {
            InitializeComponent();

            decimal total = 0;
            int yOffset = 0; // this offset is used to position the labels

            foreach (string item in cartItems)
            {
                lbxOrderSummary.Items.Add(item);

                // Create a new Label control for each item
                Label lblItem = new Label();
                lblItem.Text = item;
                lblItem.Location = new Point(10, 50 + yOffset); // adjust the coordinates as necessary
                this.Controls.Add(lblItem);
                yOffset += 25; // increase the offset for the next label

                // Split the item string into parts
                string[] parts = item.Split(new string[] { " - " }, StringSplitOptions.None);
                // Extract the quantity and price
                decimal quantity = Decimal.Parse(parts[1].Split(':').Last().Trim());
                decimal price = Decimal.Parse(parts[2].Split(':').Last().Trim(), NumberStyles.Currency);
                // Add to the total
                total += price;
            }

            decimal gct = total * 0.15m;
            lblGCT.Text = $"GCT (15%): {gct:C}";
            lblTotal.Text = $"Total: {(total + gct):C}";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Extract the numeric part of the string
            string totalText = lblTotal.Text.Replace("Total: ", "").Trim();

            if (Decimal.TryParse(totalText, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal total))
            {
                FrmPayment frmPayment = new FrmPayment();
                frmPayment.TotalAmount = total;
                frmPayment.Show();
            }
            else
            {
                MessageBox.Show("Could not parse the total amount.");
            }
        }



        private void lbxOrderSummary_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmOrderSummary_Load(object sender, EventArgs e)
        {

        }

        private void pbxContinueToPayment_Click(object sender, EventArgs e)
        {
            // Extract the numeric part of the string
            string totalText = lblTotal.Text.Replace("Total: ", "").Trim();

            if (Decimal.TryParse(totalText, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal total))
            {
                FrmPayment frmPayment = new FrmPayment();
                frmPayment.TotalAmount = total;
                frmPayment.Show();
            }
            else
            {
                MessageBox.Show("Could not parse the total amount.");
            }
        }
    }
}
