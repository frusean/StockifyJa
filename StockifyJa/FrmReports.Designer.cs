namespace StockifyJa
{
    partial class FrmReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReports));
            this.picSalesReport = new System.Windows.Forms.PictureBox();
            this.axWMPSalesReport = new AxWMPLib.AxWindowsMediaPlayer();
            this.picExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSalesReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWMPSalesReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // picSalesReport
            // 
            this.picSalesReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picSalesReport.Image = ((System.Drawing.Image)(resources.GetObject("picSalesReport.Image")));
            this.picSalesReport.Location = new System.Drawing.Point(760, 489);
            this.picSalesReport.Name = "picSalesReport";
            this.picSalesReport.Size = new System.Drawing.Size(147, 146);
            this.picSalesReport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSalesReport.TabIndex = 2;
            this.picSalesReport.TabStop = false;
            // 
            // axWMPSalesReport
            // 
            this.axWMPSalesReport.Enabled = true;
            this.axWMPSalesReport.Location = new System.Drawing.Point(158, 12);
            this.axWMPSalesReport.Name = "axWMPSalesReport";
            this.axWMPSalesReport.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWMPSalesReport.OcxState")));
            this.axWMPSalesReport.Size = new System.Drawing.Size(965, 471);
            this.axWMPSalesReport.TabIndex = 1;
            // 
            // picExit
            // 
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.Location = new System.Drawing.Point(1476, 553);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(61, 47);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExit.TabIndex = 82;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // FrmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(167)))));
            this.ClientSize = new System.Drawing.Size(1562, 647);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.picSalesReport);
            this.Controls.Add(this.axWMPSalesReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.FrmReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSalesReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWMPSalesReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AxWMPLib.AxWindowsMediaPlayer axWMPSalesReport;
        private System.Windows.Forms.PictureBox picSalesReport;
        private System.Windows.Forms.PictureBox picExit;
    }
}