using Stripe;
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
    public partial class FrmPayment : Form
    {
        private decimal _total;
        public FrmPayment()
        {
            InitializeComponent();
            //  _total = total;
            StripeConfiguration.ApiKey = "sk_test_51NDiUAH4zO9awdaeS7UqsirCvNEBr42gC4oZTRD0V9Idd2djlMcv17M256OIjwlSpGSbcB6r9YJ8P8nfIHEAwJvY00A4N70Joa"; // Your Stripe API Key here
        }

        public decimal TotalAmount
        {
            set
            {
                _total = value;
                txtTotalPay.Text = $"Total: {_total:C}";
            }
        }
       
        private void FrmPayment_Load(object sender, EventArgs e)
        {
            for (int month = 1; month <= 12; month++)
            {
                cmbExpMonth.Items.Add(month);
            }

            int currentYear = DateTime.Now.Year;
            for (int year = currentYear; year <= currentYear + 10; year++)
            {
                cmbExpYear.Items.Add(year);
            }

            // disable the components initially
            txtCardNumber.Enabled = false;
            cmbExpMonth.Enabled = false;
            cmbExpYear.Enabled = false;
            txtCvc.Enabled = false;
            btnPay.Enabled = false;

            // disable the PayOnDropOff button initially
            btnPayOnDropOff.Enabled = false;
        }



        private async void btnPay_Click(object sender, EventArgs e)
        {
            string cardNumber = txtCardNumber.Text;
            string expMonth = cmbExpMonth.Text;
            string expYear = cmbExpYear.Text;
            string cvc = txtCvc.Text;

            if (string.IsNullOrEmpty(cardNumber) || cardNumber.Length != 16)
            {
                MessageBox.Show("Invalid card number.");
                return;
            }

            if (!long.TryParse(expMonth, out long expMonthLong) || expMonthLong < 1 || expMonthLong > 12)
            {
                MessageBox.Show("Invalid expiry month.");
                return;
            }

            if (!long.TryParse(expYear, out long expYearLong) || expYearLong < DateTime.Now.Year)
            {
                MessageBox.Show("Invalid expiry year.");
                return;
            }

            if (string.IsNullOrEmpty(cvc) || cvc.Length != 3)
            {
                MessageBox.Show("Invalid CVC.");
                return;
            }

            try
            {
                var tokenOptions = new TokenCreateOptions
                {
                    Card = new TokenCardOptions
                    {
                        Number = cardNumber,
                        ExpMonth = expMonthLong.ToString(),
                        ExpYear = expYearLong.ToString(),
                        Cvc = cvc
                    }
                };

                var tokenService = new TokenService();
                Token stripeToken = await tokenService.CreateAsync(tokenOptions);

                decimal amount = _total;

                var chargeOptions = new ChargeCreateOptions
                {
                    Amount = (long)(amount * 100),
                    Currency = "usd",
                    Description = "Stock purchase",
                    Source = stripeToken.Id
                };

                var chargeService = new ChargeService();
                Charge charge = await chargeService.CreateAsync(chargeOptions);

                if (charge.Paid)
                {
                    MessageBox.Show("Payment processed successfully");
                }
                else
                {
                    MessageBox.Show("Payment failed. Please check your card details and try again.");
                }
            }
            catch (StripeException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtTotalPay_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCardNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdbPayNow_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = rdbPayNow.Checked;

            // Enable/Disable the card info components
            txtCardNumber.Enabled = isChecked;
            cmbExpMonth.Enabled = isChecked;
            cmbExpYear.Enabled = isChecked;
            txtCvc.Enabled = isChecked;
            btnPay.Enabled = isChecked;

            // If PayNow is selected, disable the PayOnDropOff button
            if (isChecked)
            {
                btnPayOnDropOff.Enabled = false;
            }
        }

        private void rdbPayOnDropOff_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = rdbPayOnDropOff.Checked;

            // Enable/Disable the PayOnDropOff button
            btnPayOnDropOff.Enabled = isChecked;

            // If PayOnDropOff is selected, disable the card info components
            if (isChecked)
            {
                txtCardNumber.Enabled = false;
                cmbExpMonth.Enabled = false;
                cmbExpYear.Enabled = false;
                txtCvc.Enabled = false;
                btnPay.Enabled = false;
            }
        }

        private void btnPayOnDropOff_Click(object sender, EventArgs e)
        {

        }
    }
}
