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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPayment));
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
            this.rdbCashOnDelivery = new System.Windows.Forms.RadioButton();
            this.rdbPayNow = new System.Windows.Forms.RadioButton();
            this.btnPayOnDelivery = new System.Windows.Forms.Button();
            this.btnInStorePickUp = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.cmbCardType = new System.Windows.Forms.ComboBox();
            this.lblCardType = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.gbxPaymentPreference.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(311, 414);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(75, 33);
            this.btnPay.TabIndex = 38;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lblPlaceOrder
            // 
            this.lblPlaceOrder.AutoSize = true;
            this.lblPlaceOrder.Font = new System.Drawing.Font("Georgia", 16.2F);
            this.lblPlaceOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(167)))));
            this.lblPlaceOrder.Location = new System.Drawing.Point(603, 20);
            this.lblPlaceOrder.Name = "lblPlaceOrder";
            this.lblPlaceOrder.Size = new System.Drawing.Size(125, 32);
            this.lblPlaceOrder.TabIndex = 37;
            this.lblPlaceOrder.Text = "Payment";
            // 
            // txtTotalPay
            // 
            this.txtTotalPay.Location = new System.Drawing.Point(609, 510);
            this.txtTotalPay.Name = "txtTotalPay";
            this.txtTotalPay.ReadOnly = true;
            this.txtTotalPay.Size = new System.Drawing.Size(139, 22);
            this.txtTotalPay.TabIndex = 36;
            // 
            // lbltotalpay
            // 
            this.lbltotalpay.AutoSize = true;
            this.lbltotalpay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalpay.Location = new System.Drawing.Point(522, 510);
            this.lbltotalpay.Name = "lbltotalpay";
            this.lbltotalpay.Size = new System.Drawing.Size(62, 22);
            this.lbltotalpay.TabIndex = 35;
            this.lbltotalpay.Text = "Total:";
            // 
            // txtCvc
            // 
            this.txtCvc.Location = new System.Drawing.Point(285, 348);
            this.txtCvc.Name = "txtCvc";
            this.txtCvc.Size = new System.Drawing.Size(62, 22);
            this.txtCvc.TabIndex = 34;
            // 
            // cmbExpYear
            // 
            this.cmbExpYear.FormattingEnabled = true;
            this.cmbExpYear.Location = new System.Drawing.Point(424, 265);
            this.cmbExpYear.Name = "cmbExpYear";
            this.cmbExpYear.Size = new System.Drawing.Size(76, 24);
            this.cmbExpYear.TabIndex = 33;
            this.cmbExpYear.TabStop = false;
            this.cmbExpYear.Text = "Year";
            // 
            // cmbExpMonth
            // 
            this.cmbExpMonth.FormattingEnabled = true;
            this.cmbExpMonth.Location = new System.Drawing.Point(285, 265);
            this.cmbExpMonth.Name = "cmbExpMonth";
            this.cmbExpMonth.Size = new System.Drawing.Size(71, 24);
            this.cmbExpMonth.TabIndex = 32;
            this.cmbExpMonth.TabStop = false;
            this.cmbExpMonth.Text = "Month";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(285, 192);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(223, 22);
            this.txtCardNumber.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 30;
            this.label3.Text = "CVV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "Exp Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "Card Number:";
            // 
            // gbxPaymentPreference
            // 
            this.gbxPaymentPreference.Controls.Add(this.rdbCashOnDelivery);
            this.gbxPaymentPreference.Controls.Add(this.rdbPayNow);
            this.gbxPaymentPreference.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPaymentPreference.Location = new System.Drawing.Point(850, 149);
            this.gbxPaymentPreference.Name = "gbxPaymentPreference";
            this.gbxPaymentPreference.Size = new System.Drawing.Size(361, 100);
            this.gbxPaymentPreference.TabIndex = 39;
            this.gbxPaymentPreference.TabStop = false;
            this.gbxPaymentPreference.Text = "Payment  Preference";
            // 
            // rdbCashOnDelivery
            // 
            this.rdbCashOnDelivery.AutoSize = true;
            this.rdbCashOnDelivery.Location = new System.Drawing.Point(172, 40);
            this.rdbCashOnDelivery.Name = "rdbCashOnDelivery";
            this.rdbCashOnDelivery.Size = new System.Drawing.Size(160, 22);
            this.rdbCashOnDelivery.TabIndex = 1;
            this.rdbCashOnDelivery.TabStop = true;
            this.rdbCashOnDelivery.Text = "Cash On Delivery";
            this.rdbCashOnDelivery.UseVisualStyleBackColor = true;
            this.rdbCashOnDelivery.CheckedChanged += new System.EventHandler(this.rdbPayOnDropOff_CheckedChanged);
            // 
            // rdbPayNow
            // 
            this.rdbPayNow.AutoSize = true;
            this.rdbPayNow.Location = new System.Drawing.Point(21, 41);
            this.rdbPayNow.Name = "rdbPayNow";
            this.rdbPayNow.Size = new System.Drawing.Size(105, 22);
            this.rdbPayNow.TabIndex = 0;
            this.rdbPayNow.TabStop = true;
            this.rdbPayNow.Text = "Pay Now !";
            this.rdbPayNow.UseVisualStyleBackColor = true;
            this.rdbPayNow.CheckedChanged += new System.EventHandler(this.rdbPayNow_CheckedChanged);
            // 
            // btnPayOnDelivery
            // 
            this.btnPayOnDelivery.Location = new System.Drawing.Point(871, 321);
            this.btnPayOnDelivery.Name = "btnPayOnDelivery";
            this.btnPayOnDelivery.Size = new System.Drawing.Size(125, 29);
            this.btnPayOnDelivery.TabIndex = 40;
            this.btnPayOnDelivery.Text = "Pay On Delivery";
            this.btnPayOnDelivery.UseVisualStyleBackColor = true;
            this.btnPayOnDelivery.Click += new System.EventHandler(this.btnPayOnDropOff_Click);
            // 
            // btnInStorePickUp
            // 
            this.btnInStorePickUp.Location = new System.Drawing.Point(1087, 321);
            this.btnInStorePickUp.Name = "btnInStorePickUp";
            this.btnInStorePickUp.Size = new System.Drawing.Size(117, 29);
            this.btnInStorePickUp.TabIndex = 41;
            this.btnInStorePickUp.Text = "In Store Pickup";
            this.btnInStorePickUp.UseVisualStyleBackColor = true;
            this.btnInStorePickUp.Click += new System.EventHandler(this.btnInStorePickUp_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblOrderID);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(103, 58);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order ID";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(19, 28);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(27, 16);
            this.lblOrderID.TabIndex = 0;
            this.lblOrderID.Text = "     ";
            // 
            // cmbCardType
            // 
            this.cmbCardType.FormattingEnabled = true;
            this.cmbCardType.Items.AddRange(new object[] {
            "Debit Card",
            "Credit Card"});
            this.cmbCardType.Location = new System.Drawing.Point(285, 133);
            this.cmbCardType.Name = "cmbCardType";
            this.cmbCardType.Size = new System.Drawing.Size(223, 24);
            this.cmbCardType.TabIndex = 54;
            this.cmbCardType.TabStop = false;
            this.cmbCardType.Text = "Select Card Type";
            // 
            // lblCardType
            // 
            this.lblCardType.AutoSize = true;
            this.lblCardType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardType.Location = new System.Drawing.Point(104, 134);
            this.lblCardType.Name = "lblCardType";
            this.lblCardType.Size = new System.Drawing.Size(90, 18);
            this.lblCardType.TabIndex = 55;
            this.lblCardType.Text = "Card Type:";
            // 
            // picExit
            // 
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.Location = new System.Drawing.Point(1208, 565);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(61, 47);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExit.TabIndex = 47;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // FrmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(219)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1298, 636);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.lblCardType);
            this.Controls.Add(this.cmbCardType);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnInStorePickUp);
            this.Controls.Add(this.btnPayOnDelivery);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPayment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.FrmPayment_Load);
            this.gbxPaymentPreference.ResumeLayout(false);
            this.gbxPaymentPreference.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
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
        private System.Windows.Forms.RadioButton rdbCashOnDelivery;
        private System.Windows.Forms.RadioButton rdbPayNow;
        private System.Windows.Forms.Button btnPayOnDelivery;
        private System.Windows.Forms.Button btnInStorePickUp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.ComboBox cmbCardType;
        private System.Windows.Forms.Label lblCardType;
        private System.Windows.Forms.PictureBox picExit;
    }
}