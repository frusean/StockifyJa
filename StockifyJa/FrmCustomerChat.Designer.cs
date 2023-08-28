namespace StockifyJa
{
    partial class FrmCustomerChat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomerChat));
            this.txtCustomerMessageInput = new System.Windows.Forms.TextBox();
            this.lbxCustomerMessageView = new System.Windows.Forms.ListBox();
            this.btnCustomerMessageSendButton = new System.Windows.Forms.Button();
            this.lblLiveChat = new System.Windows.Forms.Label();
            this.picSend = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSend)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCustomerMessageInput
            // 
            this.txtCustomerMessageInput.Location = new System.Drawing.Point(53, 433);
            this.txtCustomerMessageInput.Multiline = true;
            this.txtCustomerMessageInput.Name = "txtCustomerMessageInput";
            this.txtCustomerMessageInput.Size = new System.Drawing.Size(578, 53);
            this.txtCustomerMessageInput.TabIndex = 49;
            // 
            // lbxCustomerMessageView
            // 
            this.lbxCustomerMessageView.FormattingEnabled = true;
            this.lbxCustomerMessageView.ItemHeight = 16;
            this.lbxCustomerMessageView.Location = new System.Drawing.Point(53, 36);
            this.lbxCustomerMessageView.Name = "lbxCustomerMessageView";
            this.lbxCustomerMessageView.Size = new System.Drawing.Size(578, 372);
            this.lbxCustomerMessageView.TabIndex = 48;
            // 
            // btnCustomerMessageSendButton
            // 
            this.btnCustomerMessageSendButton.Location = new System.Drawing.Point(672, 448);
            this.btnCustomerMessageSendButton.Name = "btnCustomerMessageSendButton";
            this.btnCustomerMessageSendButton.Size = new System.Drawing.Size(75, 23);
            this.btnCustomerMessageSendButton.TabIndex = 47;
            this.btnCustomerMessageSendButton.Text = "Send";
            this.btnCustomerMessageSendButton.UseVisualStyleBackColor = true;
            this.btnCustomerMessageSendButton.Click += new System.EventHandler(this.btnCustomerMessageSendButton_Click);
            // 
            // lblLiveChat
            // 
            this.lblLiveChat.AutoSize = true;
            this.lblLiveChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLiveChat.Location = new System.Drawing.Point(325, -36);
            this.lblLiveChat.Name = "lblLiveChat";
            this.lblLiveChat.Size = new System.Drawing.Size(164, 38);
            this.lblLiveChat.TabIndex = 46;
            this.lblLiveChat.Text = "Live Chat";
            // 
            // picSend
            // 
            this.picSend.Image = ((System.Drawing.Image)(resources.GetObject("picSend.Image")));
            this.picSend.Location = new System.Drawing.Point(753, 438);
            this.picSend.Name = "picSend";
            this.picSend.Size = new System.Drawing.Size(37, 33);
            this.picSend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSend.TabIndex = 50;
            this.picSend.TabStop = false;
            // 
            // FrmCustomerChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(219)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1066, 543);
            this.Controls.Add(this.picSend);
            this.Controls.Add(this.txtCustomerMessageInput);
            this.Controls.Add(this.lbxCustomerMessageView);
            this.Controls.Add(this.btnCustomerMessageSendButton);
            this.Controls.Add(this.lblLiveChat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCustomerChat";
            this.Text = "Customer Chat";
            this.Load += new System.EventHandler(this.FrmCustomerChat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomerMessageInput;
        private System.Windows.Forms.ListBox lbxCustomerMessageView;
        private System.Windows.Forms.Button btnCustomerMessageSendButton;
        private System.Windows.Forms.Label lblLiveChat;
        private System.Windows.Forms.PictureBox picSend;
    }
}