namespace StockifyJa
{
    partial class FrmPayment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPay = new System.Windows.Forms.Button();
            this.lblPlaceOrder = new System.Windows.Forms.Label();
            this.txtTotalPay = new System.Windows.Forms.TextBox();
            this.lbltotalpay = new System.Windows.Forms.Label();
            this.txtCvc = new System.Windows.Forms.TextBox();
            this.cmbExpYear = new System.Windows.Forms.ComboBox();
            this.cmbExpMonth = new System.Windows.Forms.ComboBox();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxPaymentPreference = new System.Windows.Forms.GroupBox();
            this.rdbPayOnDropOff = new System.Windows.Forms.RadioButton();
            this.rdbPayNow = new System.Windows.Forms.RadioButton();
            this.btnPayOnDropOff = new System.Windows.Forms.Button();
            this.gbxPaymentPreference.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(302, 355);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(75, 23);
            this.btnPay.TabIndex = 38;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lblPlaceOrder
            // 
            this.lblPlaceOrder.AutoSize = true;
            this.lblPlaceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaceOrder.Location = new System.Drawing.Point(399, 28);
            this.lblPlaceOrder.Name = "lblPlaceOrder";
            this.lblPlaceOrder.Size = new System.Drawing.Size(153, 38);
            this.lblPlaceOrder.TabIndex = 37;
            this.lblPlaceOrder.Text = "Payment";
            // 
            // txtTotalPay
            // 
            this.txtTotalPay.Location = new System.Drawing.Point(172, 468);
            this.txtTotalPay.Name = "txtTotalPay";
            this.txtTotalPay.ReadOnly = true;
            this.txtTotalPay.Size = new System.Drawing.Size(139, 22);
            this.txtTotalPay.TabIndex = 36;
            this.txtTotalPay.TextChanged += new System.EventHandler(this.txtTotalPay_TextChanged);
            // 
            // lbltotalpay
            // 
            this.lbltotalpay.AutoSize = true;
            this.lbltotalpay.Location = new System.Drawing.Point(91, 474);
            this.lbltotalpay.Name = "lbltotalpay";
            this.lbltotalpay.Size = new System.Drawing.Size(41, 16);
            this.lbltotalpay.TabIndex = 35;
            this.lbltotalpay.Text = "Total:";
            // 
            // txtCvc
            // 
            this.txtCvc.Location = new System.Drawing.Point(265, 271);
            this.txtCvc.Name = "txtCvc";
            this.txtCvc.Size = new System.Drawing.Size(62, 22);
            this.txtCvc.TabIndex = 34;
            // 
            // cmbExpYear
            // 
            this.cmbExpYear.FormattingEnabled = true;
            this.cmbExpYear.Location = new System.Drawing.Point(459, 188);
            this.cmbExpYear.Name = "cmbExpYear";
            this.cmbExpYear.Size = new System.Drawing.Size(76, 24);
            this.cmbExpYear.TabIndex = 33;
            this.cmbExpYear.Text = "Year";
            // 
            // cmbExpMonth
            // 
            this.cmbExpMonth.FormattingEnabled = true;
            this.cmbExpMonth.Location = new System.Drawing.Point(320, 188);
            this.cmbExpMonth.Name = "cmbExpMonth";
            this.cmbExpMonth.Size = new System.Drawing.Size(71, 24);
            this.cmbExpMonth.TabIndex = 32;
            this.cmbExpMonth.Text = "Month";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(329, 115);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(223, 22);
            this.txtCardNumber.TabIndex = 31;
            this.txtCardNumber.TextChanged += new System.EventHandler(this.txtCardNumber_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "CVV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Exp Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Card Number:";
            // 
            // gbxPaymentPreference
            // 
            this.gbxPaymentPreference.Controls.Add(this.rdbPayOnDropOff);
            this.gbxPaymentPreference.Controls.Add(this.rdbPayNow);
            this.gbxPaymentPreference.Location = new System.Drawing.Point(885, 115);
            this.gbxPaymentPreference.Name = "gbxPaymentPreference";
            this.gbxPaymentPreference.Size = new System.Drawing.Size(330, 100);
            this.gbxPaymentPreference.TabIndex = 39;
            this.gbxPaymentPreference.TabStop = false;
            this.gbxPaymentPreference.Text = "Payment  Preference";
            // 
            // rdbPayOnDropOff
            // 
            this.rdbPayOnDropOff.AutoSize = true;
            this.rdbPayOnDropOff.Location = new System.Drawing.Point(172, 40);
            this.rdbPayOnDropOff.Name = "rdbPayOnDropOff";
            this.rdbPayOnDropOff.Size = new System.Drawing.Size(124, 20);
            this.rdbPayOnDropOff.TabIndex = 1;
            this.rdbPayOnDropOff.TabStop = true;
            this.rdbPayOnDropOff.Text = "Pay On Drop Off";
            this.rdbPayOnDropOff.UseVisualStyleBackColor = true;
            this.rdbPayOnDropOff.CheckedChanged += new System.EventHandler(this.rdbPayOnDropOff_CheckedChanged);
            // 
            // rdbPayNow
            // 
            this.rdbPayNow.AutoSize = true;
            this.rdbPayNow.Location = new System.Drawing.Point(21, 41);
            this.rdbPayNow.Name = "rdbPayNow";
            this.rdbPayNow.Size = new System.Drawing.Size(88, 20);
            this.rdbPayNow.TabIndex = 0;
            this.rdbPayNow.TabStop = true;
            this.rdbPayNow.Text = "Pay Now !";
            this.rdbPayNow.UseVisualStyleBackColor = true;
            this.rdbPayNow.CheckedChanged += new System.EventHandler(this.rdbPayNow_CheckedChanged);
            // 
            // btnPayOnDropOff
            // 
            this.btnPayOnDropOff.Location = new System.Drawing.Point(1082, 302);
            this.btnPayOnDropOff.Name = "btnPayOnDropOff";
            this.btnPayOnDropOff.Size = new System.Drawing.Size(112, 29);
            this.btnPayOnDropOff.TabIndex = 40;
            this.btnPayOnDropOff.Text = "Pay on Drop Off";
            this.btnPayOnDropOff.UseVisualStyleBackColor = true;
            this.btnPayOnDropOff.Click += new System.EventHandler(this.btnPayOnDropOff_Click);
            // 
            // FrmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 636);
            this.Controls.Add(this.btnPayOnDropOff);
            this.Controls.Add(this.gbxPaymentPreference);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.lblPlaceOrder);
            this.Controls.Add(this.txtTotalPay);
            this.Controls.Add(this.lbltotalpay);
            this.Controls.Add(this.txtCvc);
            this.Controls.Add(this.cmbExpYear);
            this.Controls.Add(this.cmbExpMonth);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmPayment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.FrmPayment_Load);
            this.gbxPaymentPreference.ResumeLayout(false);
            this.gbxPaymentPreference.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label lblPlaceOrder;
        private System.Windows.Forms.TextBox txtTotalPay;
        private System.Windows.Forms.Label lbltotalpay;
        private System.Windows.Forms.TextBox txtCvc;
        private System.Windows.Forms.ComboBox cmbExpYear;
        private System.Windows.Forms.ComboBox cmbExpMonth;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxPaymentPreference;
        private System.Windows.Forms.RadioButton rdbPayOnDropOff;
        private System.Windows.Forms.RadioButton rdbPayNow;
        private System.Windows.Forms.Button btnPayOnDropOff;
    }
}