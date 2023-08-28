﻿using Google.Protobuf.Reflection;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Shapes;
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

        private void GenerateReceipt()
        {
            Document receipt = new Document();
            Section section = receipt.AddSection();

            var receiptHeading = section.AddParagraph("Receipt");
            receiptHeading.Format.Font.Size = 14;
            receiptHeading.Format.Alignment = ParagraphAlignment.Center;

            // Add the logo
            string imagePath = @"C:\Users\demet\Downloads\StockifyJa\StockifyJa\StockifyJa\AppleNova.png";
            var image = section.Headers.Primary.AddImage(imagePath);
            image.Width = "2cm";
            image.LockAspectRatio = true;

           
            section.AddParagraph("\n");
            section.AddParagraph("Apple Nova").Format.Alignment = ParagraphAlignment.Right;
            section.AddParagraph("Bridgeport, Portmore, St.Catherine").Format.Alignment = ParagraphAlignment.Right;
            section.AddParagraph($"Order #: {GetLatestOrderID()}").Format.Alignment = ParagraphAlignment.Left;
            section.AddParagraph($"Date: {DateTime.Now:d}").Format.Alignment = ParagraphAlignment.Left;
            // Spacer
            section.AddParagraph("\n");

            // Display cart items with spaces
            foreach (var item in _cartItems)
            {
                section.AddParagraph($"{item.ProductName} x{item.Quantity}  ${item.Price:0.00} each");
            }

            // Spacer
            section.AddParagraph("\n");

            // Display totals on the right side
            string totalText = lblTotal.Text.Replace("Total: ", "").Trim();
            string gctText = lblGCT.Text.Replace("GCT: ", "").Trim();
            section.AddParagraph($"Subtotal: {totalText}").Format.Alignment = ParagraphAlignment.Right;
            section.AddParagraph(gctText).Format.Alignment = ParagraphAlignment.Right;
            section.AddParagraph($"Total: {totalText}").Format.Alignment = ParagraphAlignment.Right;

            // Spacer
            section.AddParagraph("\n");

            // Thank you message
            section.AddParagraph("Thank you for making it Apple Nova!").Format.Alignment = ParagraphAlignment.Center;

            // Render the receipt
            PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer();
            pdfRenderer.Document = receipt;
            pdfRenderer.RenderDocument();

            // Use SaveFileDialog to let the user choose where to save the receipt
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
            saveFileDialog.DefaultExt = "pdf";
            saveFileDialog.AddExtension = true;
            saveFileDialog.FileName = "OrderReceipt.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                pdfRenderer.PdfDocument.Save(saveFileDialog.FileName);
                MessageBox.Show($"Receipt saved as {saveFileDialog.FileName}");
            }
        }


        private int GetLatestOrderID()
        {
            // This function queries the database to get the most recent order ID.
            // This is an example, and you should ensure your actual database query is correct.
            return _db.Orders.OrderByDescending(o => o.OrderDate).FirstOrDefault()?.OrderID ?? 0;
        }

        private void picReceipt_Click(object sender, EventArgs e)
        {
            GenerateReceipt();
        }
    }
}

