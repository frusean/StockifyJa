namespace StockifyJa
{
    partial class FrmOrderSummary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrderSummary));
            this.pbxContinueToPayment = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblGCT = new System.Windows.Forms.Label();
            this.lbxOrderSummary = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxContinueToPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxContinueToPayment
            // 
            this.pbxContinueToPayment.BackColor = System.Drawing.Color.Transparent;
            this.pbxContinueToPayment.Image = ((System.Drawing.Image)(resources.GetObject("pbxContinueToPayment.Image")));
            this.pbxContinueToPayment.Location = new System.Drawing.Point(1079, 479);
            this.pbxContinueToPayment.Name = "pbxContinueToPayment";
            this.pbxContinueToPayment.Size = new System.Drawing.Size(76, 53);
            this.pbxContinueToPayment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxContinueToPayment.TabIndex = 11;
            this.pbxContinueToPayment.TabStop = false;
            this.pbxContinueToPayment.Click += new System.EventHandler(this.pbxContinueToPayment_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Total:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "GCT:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(148, 215);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 16);
            this.lblTotal.TabIndex = 8;
            // 
            // lblGCT
            // 
            this.lblGCT.AutoSize = true;
            this.lblGCT.Location = new System.Drawing.Point(148, 154);
            this.lblGCT.Name = "lblGCT";
            this.lblGCT.Size = new System.Drawing.Size(0, 16);
            this.lblGCT.TabIndex = 7;
            // 
            // lbxOrderSummary
            // 
            this.lbxOrderSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(219)))), ((int)(((byte)(217)))));
            this.lbxOrderSummary.FormattingEnabled = true;
            this.lbxOrderSummary.ItemHeight = 16;
            this.lbxOrderSummary.Location = new System.Drawing.Point(1, 1);
            this.lbxOrderSummary.Name = "lbxOrderSummary";
            this.lbxOrderSummary.Size = new System.Drawing.Size(1238, 676);
            this.lbxOrderSummary.TabIndex = 6;
            // 
            // FrmOrderSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(1241, 572);
            this.Controls.Add(this.pbxContinueToPayment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblGCT);
            this.Controls.Add(this.lbxOrderSummary);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOrderSummary";
            this.Text = "OrderSummary";
            this.Load += new System.EventHandler(this.FrmOrderSummary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxContinueToPayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxContinueToPayment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblGCT;
        private System.Windows.Forms.ListBox lbxOrderSummary;
    }
}