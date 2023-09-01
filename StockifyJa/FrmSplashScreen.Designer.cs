namespace StockifyJa
{
    partial class FrmSplashScreen
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
            this.components = new System.ComponentModel.Container();
            this.Loadtimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblLoading = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.LoginProgressBar = new CircularProgressBar.CircularProgressBar();
            this.SuspendLayout();
            // 
            // Loadtimer
            // 
            this.Loadtimer.Enabled = true;
            this.Loadtimer.Tick += new System.EventHandler(this.Loadtimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Copyright © Stockify Ja 2023";
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.Location = new System.Drawing.Point(85, 248);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(76, 18);
            this.lblLoading.TabIndex = 4;
            this.lblLoading.Text = "Loading....";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(12, 42);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(213, 20);
            this.lblWelcome.TabIndex = 5;
            this.lblWelcome.Text = "Welcome to Stockify Ja!";
            // 
            // LoginProgressBar
            // 
            this.LoginProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.LoginProgressBar.AnimationSpeed = 500;
            this.LoginProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.LoginProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.LoginProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LoginProgressBar.InnerColor = System.Drawing.Color.OldLace;
            this.LoginProgressBar.InnerMargin = 2;
            this.LoginProgressBar.InnerWidth = -1;
            this.LoginProgressBar.Location = new System.Drawing.Point(88, 129);
            this.LoginProgressBar.MarqueeAnimationSpeed = 2000;
            this.LoginProgressBar.Name = "LoginProgressBar";
            this.LoginProgressBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.LoginProgressBar.OuterMargin = -25;
            this.LoginProgressBar.OuterWidth = 26;
            this.LoginProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(167)))));
            this.LoginProgressBar.ProgressWidth = 3;
            this.LoginProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.LoginProgressBar.Size = new System.Drawing.Size(102, 95);
            this.LoginProgressBar.StartAngle = 270;
            this.LoginProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.LoginProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.LoginProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.LoginProgressBar.SubscriptText = "";
            this.LoginProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.LoginProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.LoginProgressBar.SuperscriptText = "";
            this.LoginProgressBar.TabIndex = 2;
            this.LoginProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.LoginProgressBar.Value = 68;
            // 
            // FrmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(167)))));
            this.ClientSize = new System.Drawing.Size(255, 378);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.LoginProgressBar);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash Screen";
            this.Load += new System.EventHandler(this.FrmSplashScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer Loadtimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Label lblWelcome;
        private CircularProgressBar.CircularProgressBar LoginProgressBar;
    }
}