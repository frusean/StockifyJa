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
            this.txtCustomerMessageInput = new System.Windows.Forms.TextBox();
            this.lbxCustomerMessageView = new System.Windows.Forms.ListBox();
            this.btnCustomerMessageSendButton = new System.Windows.Forms.Button();
            this.lblLiveChat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCustomerMessageInput
            // 
            this.txtCustomerMessageInput.Location = new System.Drawing.Point(53, 433);
            this.txtCustomerMessageInput.Multiline = true;
            this.txtCustomerMessageInput.Name = "txtCustomerMessageInput";
            this.txtCustomerMessageInput.Size = new System.Drawing.Size(454, 53);
            this.txtCustomerMessageInput.TabIndex = 49;
         //   this.txtCustomerMessageInput.TextChanged += new System.EventHandler(this.txtCustomerMessageInput_TextChanged);
            // 
            // lbxCustomerMessageView
            // 
            this.lbxCustomerMessageView.FormattingEnabled = true;
            this.lbxCustomerMessageView.ItemHeight = 16;
            this.lbxCustomerMessageView.Location = new System.Drawing.Point(53, 36);
            this.lbxCustomerMessageView.Name = "lbxCustomerMessageView";
            this.lbxCustomerMessageView.Size = new System.Drawing.Size(436, 372);
            this.lbxCustomerMessageView.TabIndex = 48;
           // this.lbxCustomerMessageView.SelectedIndexChanged += new System.EventHandler(this.lbxCustomerMessageView_SelectedIndexChanged);
            // 
            // btnCustomerMessageSendButton
            // 
            this.btnCustomerMessageSendButton.Location = new System.Drawing.Point(672, 448);
            this.btnCustomerMessageSendButton.Name = "btnCustomerMessageSendButton";
            this.btnCustomerMessageSendButton.Size = new System.Drawing.Size(75, 23);
            this.btnCustomerMessageSendButton.TabIndex = 47;
            this.btnCustomerMessageSendButton.Text = "button1";
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
            // FrmCustomerChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 543);
            this.Controls.Add(this.txtCustomerMessageInput);
            this.Controls.Add(this.lbxCustomerMessageView);
            this.Controls.Add(this.btnCustomerMessageSendButton);
            this.Controls.Add(this.lblLiveChat);
            this.Name = "FrmCustomerChat";
            this.Text = "FrmCustomerChat";
            this.Load += new System.EventHandler(this.FrmCustomerChat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomerMessageInput;
        private System.Windows.Forms.ListBox lbxCustomerMessageView;
        private System.Windows.Forms.Button btnCustomerMessageSendButton;
        private System.Windows.Forms.Label lblLiveChat;
    }
}