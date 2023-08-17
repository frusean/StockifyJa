using StockifyjaLib;
using Stripe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockifyJa
{
    public partial class FrmPayment : Form
    {
        private decimal _total;
        private List<ItemDetails> _cartItems;
        private stockifydBEntities _db;

        public FrmPayment(List<ItemDetails> cartItems)
        {
            InitializeComponent();
            _cartItems = cartItems;
            _db = new stockifydBEntities();
            _db.Database.CommandTimeout = 180;
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
            btnPayOnDelivery.Enabled = false;
        }


        //private async void btnPay_Click(object sender, EventArgs e)
        //{
        //    string cardNumber = txtCardNumber.Text;
        //    string expMonth = cmbExpMonth.Text;
        //    string expYear = cmbExpYear.Text;
        //    string cvc = txtCvc.Text;

        //    if (string.IsNullOrEmpty(cardNumber) || cardNumber.Length != 16)
        //    {
        //        MessageBox.Show("Invalid card number.");
        //        return;
        //    }

        //    if (!long.TryParse(expMonth, out long expMonthLong) || expMonthLong < 1 || expMonthLong > 12)
        //    {
        //        MessageBox.Show("Invalid expiry month.");
        //        return;
        //    }

        //    if (!long.TryParse(expYear, out long expYearLong) || expYearLong < DateTime.Now.Year)
        //    {
        //        MessageBox.Show("Invalid expiry year.");
        //        return;
        //    }

        //    if (string.IsNullOrEmpty(cvc) || cvc.Length != 3)
        //    {
        //        MessageBox.Show("Invalid CVC.");
        //        return;
        //    }

        //    try
        //    {
        //        var tokenOptions = new TokenCreateOptions
        //        {
        //            Card = new TokenCardOptions
        //            {
        //                Number = cardNumber,
        //                ExpMonth = expMonthLong.ToString(),
        //                ExpYear = expYearLong.ToString(),
        //                Cvc = cvc
        //            }
        //        };

        //        var tokenService = new TokenService();
        //        Token stripeToken = await tokenService.CreateAsync(tokenOptions);

        //        decimal amount = _total;

        //        var chargeOptions = new ChargeCreateOptions
        //        {
        //            Amount = (long)(amount * 100),
        //            Currency = "usd",
        //            Description = "Stock purchase",
        //            Source = stripeToken.Id
        //        };

        //        var chargeService = new ChargeService();
        //        Charge charge = await chargeService.CreateAsync(chargeOptions);

        //        if (charge.Paid)
        //        {
        //            foreach (var item in _cartItems)
        //            {
        //                var stock = _db.Stocks.FirstOrDefault(s => s.ProductID == item.ProductID);
        //                if (stock != null)
        //                {
        //                    stock.QuantityInStock -= item.Quantity;
        //                }

        //                // Remove the corresponding entry from the Cart table
        //                var cartItem = _db.Carts.FirstOrDefault(c => c.CartID == item.CartItemID);
        //                if (cartItem != null)
        //                {
        //                    _db.Carts.Remove(cartItem);
        //                }
        //            }

        //            // Save changes to database
        //            await _db.SaveChangesAsync();

        //            // Clear the AppState.CartItems
        //            AppState.CartItems.Clear();

        //            MessageBox.Show("Payment processed successfully");
        //        }

        //        else
        //        {
        //            MessageBox.Show("Payment failed. Please check your card details and try again.");
        //        }
        //    }
        //    catch (StripeException ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
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
                    // 1. Add entry to Orders table
                    Order newOrder = new Order
                    {
                        RetailerID = AppState.CurrentUserID,
                        OrderDate = DateTime.Now,
                        Total = _total
                    };
                    _db.Orders.Add(newOrder);
                    await _db.SaveChangesAsync();

                    foreach (var item in _cartItems)
                    {
                        // 2. Add entry for each item in the OrderDetails table
                        OrderDetail orderDetail = new OrderDetail
                        {
                            OrderID = newOrder.OrderID,
                            ProductID = item.ProductID,
                            QuantityOrdered = item.Quantity,
                            Price = item.Price
                        };
                        _db.OrderDetails.Add(orderDetail);

                        // Adjust stock quantities
                        var stock = _db.Stocks.FirstOrDefault(s => s.ProductID == item.ProductID);
                        if (stock != null)
                        {
                            stock.QuantityInStock -= item.Quantity;
                        }

                        // Remove the corresponding entry from the Cart table
                        var cartItem = _db.Carts.FirstOrDefault(c => c.CartID == item.CartItemID);
                        if (cartItem != null)
                        {
                            _db.Carts.Remove(cartItem);
                        }
                    }

                    // Save changes to database
                    await _db.SaveChangesAsync();

                    // Clear the AppState.CartItems
                    AppState.CartItems.Clear();

                    MessageBox.Show("Payment and Order processed successfully");
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
                btnPayOnDelivery.Enabled = false;
            }
        }

        private void rdbPayOnDropOff_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = rdbCashOnDelivery.Checked;

            // Enable/Disable the PayOnDropOff button
            btnPayOnDelivery.Enabled = isChecked;

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
    // Step 1: Ask for the payment method
    string[] paymentMethods = { "Debit Card", "Credit Card", "Cash", "Cheque" };
    string chosenMethod = "";

    using (Form methodForm = new Form())
    {
        methodForm.StartPosition = FormStartPosition.CenterParent;
        methodForm.Size = new Size(300, 150);
        methodForm.Text = "Choose Payment Method";

        ComboBox cmbMethods = new ComboBox
        {
            DataSource = paymentMethods,
            Location = new Point(50, 30),
            DropDownStyle = ComboBoxStyle.DropDownList
        };
        methodForm.Controls.Add(cmbMethods);

        Button btnConfirmMethod = new Button
        {
            Text = "Confirm",
            Location = new Point(110, 70)
        };
        btnConfirmMethod.Click += (s, ea) =>
        {
            chosenMethod = cmbMethods.SelectedItem.ToString();
            methodForm.Close();
        };
        methodForm.Controls.Add(btnConfirmMethod);

        methodForm.ShowDialog();
    }

    if (string.IsNullOrEmpty(chosenMethod)) return;

    // Step 2: Confirm the chosen method
    DialogResult confirmation = MessageBox.Show($"Are you sure you would like to pay with {chosenMethod}?", "Confirm Payment Method", MessageBoxButtons.YesNo);

    if (confirmation == DialogResult.No) return;

    // Step 3: Save the payment details
    PaymentDetail paymentDetail = new PaymentDetail
    {
        PaymentMethod = chosenMethod,
        TransactionDate = DateTime.Now,
        Amount = _total,
        StatusID = 1 // Assuming 1 is the default status. Adjust as needed.
    };

    _db.PaymentDetails.Add(paymentDetail);
    _db.SaveChanges();

    // Step 4: Add the order to Orders and OrderDetails tables
    Order newOrder = new Order
    {
        RetailerID = AppState.CurrentUserID,
        OrderDate = DateTime.Now,
        Total = _total,
        StatusID = 1 // Assuming 1 is the default status. Adjust as needed.
    };

    _db.Orders.Add(newOrder);
    _db.SaveChanges();

    foreach (var item in _cartItems)
    {
        OrderDetail orderDetail = new OrderDetail
        {
            OrderID = newOrder.OrderID,
            ProductID = item.ProductID,
            QuantityOrdered = item.Quantity,
            Price = item.Price
        };

        _db.OrderDetails.Add(orderDetail);

                var stock = _db.Stocks.FirstOrDefault(s => s.ProductID == item.ProductID);
                if (stock != null)
                {
                    stock.QuantityInStock -= item.Quantity;
                }

                // Remove the corresponding entry from the Cart table
                var cartItem = _db.Carts.FirstOrDefault(c => c.CartID == item.CartItemID);
        if (cartItem != null)
        {
            _db.Carts.Remove(cartItem);
        }
    }

    _db.SaveChanges();

    // Clear the AppState.CartItems
    AppState.CartItems.Clear();

    MessageBox.Show("Order placed successfully with Pay On Delivery method Shipment will occur in 4 Business Days.","Order Success!",MessageBoxButtons.OK);
}



        private void btnInStorePickUp_Click(object sender, EventArgs e)
        {
            // Step 1: Ask for the payment method
            string[] paymentMethods = { "Debit Card", "Credit Card", "Cash", "Cheque" };
            string chosenMethod = "";

            using (Form methodForm = new Form())
            {
                methodForm.StartPosition = FormStartPosition.CenterParent;
                methodForm.Size = new Size(300, 150);
                methodForm.Text = "Choose which mehtod you intend to pay with in store";

                ComboBox cmbMethods = new ComboBox
                {
                    DataSource = paymentMethods,
                    Location = new Point(50, 30),
                    DropDownStyle = ComboBoxStyle.DropDownList
                };
                methodForm.Controls.Add(cmbMethods);

                Button btnConfirmMethod = new Button
                {
                    Text = "Confirm",
                    Location = new Point(110, 70)
                };
                btnConfirmMethod.Click += (s, ea) =>
                {
                    chosenMethod = cmbMethods.SelectedItem.ToString();
                    methodForm.Close();
                };
                methodForm.Controls.Add(btnConfirmMethod);

                methodForm.ShowDialog();
            }

            if (string.IsNullOrEmpty(chosenMethod)) return;

            // Step 2: Confirm the chosen method
            DialogResult confirmation = MessageBox.Show($"Are you sure you would like to pay with {chosenMethod} in store?", "Confirm Payment Method", MessageBoxButtons.YesNo);

            if (confirmation == DialogResult.No) return;

            // Step 3: Save the payment details
            PaymentDetail paymentDetail = new PaymentDetail
            {
                PaymentMethod = chosenMethod,
                TransactionDate = DateTime.Now,
                Amount = _total,
                StatusID = 1 // Assuming 1 is the default status. Adjust as needed.
            };

            _db.PaymentDetails.Add(paymentDetail);
            _db.SaveChanges();

            // Step 4: Add the order to Orders and OrderDetails tables
            Order newOrder = new Order
            {
                RetailerID = AppState.CurrentUserID,
                OrderDate = DateTime.Now,
                Total = _total,
                StatusID = 9 
            };

            _db.Orders.Add(newOrder);
            _db.SaveChanges();

            foreach (var item in _cartItems)
            {
                OrderDetail orderDetail = new OrderDetail
                {
                    OrderID = newOrder.OrderID,
                    ProductID = item.ProductID,
                    QuantityOrdered = item.Quantity,
                    Price = item.Price
                };

                _db.OrderDetails.Add(orderDetail);

                var stock = _db.Stocks.FirstOrDefault(s => s.ProductID == item.ProductID);
                if (stock != null)
                {
                    stock.QuantityInStock -= item.Quantity;
                }

                // Remove the corresponding entry from the Cart table
                var cartItem = _db.Carts.FirstOrDefault(c => c.CartID == item.CartItemID);
                if (cartItem != null)
                {
                    _db.Carts.Remove(cartItem);

                }
            }

            _db.SaveChanges();

            // Clear the AppState.CartItems
            AppState.CartItems.Clear();

            MessageBox.Show("Order placed successfully you may pickup your order in two business days .", "Order Success!", MessageBoxButtons.OK);
        }
    }
}
