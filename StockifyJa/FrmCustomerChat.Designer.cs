﻿namespace StockifyJa
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
            this.lblLiveChat = new System.Windows.Forms.Label();
            this.picSend = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.lblManageUsers = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCustomerMessageInput
            // 
            this.txtCustomerMessageInput.Location = new System.Drawing.Point(213, 458);
            this.txtCustomerMessageInput.Multiline = true;
            this.txtCustomerMessageInput.Name = "txtCustomerMessageInput";
            this.txtCustomerMessageInput.Size = new System.Drawing.Size(578, 53);
            this.txtCustomerMessageInput.TabIndex = 49;
            // 
            // lbxCustomerMessageView
            // 
            this.lbxCustomerMessageView.FormattingEnabled = true;
            this.lbxCustomerMessageView.ItemHeight = 16;
            this.lbxCustomerMessageView.Location = new System.Drawing.Point(213, 61);
            this.lbxCustomerMessageView.Name = "lbxCustomerMessageView";
            this.lbxCustomerMessageView.Size = new System.Drawing.Size(578, 372);
            this.lbxCustomerMessageView.TabIndex = 48;
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
            this.picSend.Location = new System.Drawing.Point(816, 467);
            this.picSend.Name = "picSend";
            this.picSend.Size = new System.Drawing.Size(37, 33);
            this.picSend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSend.TabIndex = 50;
            this.picSend.TabStop = false;
            this.picSend.Click += new System.EventHandler(this.picSend_Click);
            // 
            // picExit
            // 
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.Location = new System.Drawing.Point(1006, 496);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(61, 47);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExit.TabIndex = 51;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // lblManageUsers
            // 
            this.lblManageUsers.AutoSize = true;
            this.lblManageUsers.Font = new System.Drawing.Font("Georgia", 16.2F);
            this.lblManageUsers.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblManageUsers.Location = new System.Drawing.Point(489, 9);
            this.lblManageUsers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblManageUsers.Name = "lblManageUsers";
            this.lblManageUsers.Size = new System.Drawing.Size(73, 32);
            this.lblManageUsers.TabIndex = 52;
            this.lblManageUsers.Text = "Chat";
            // 
            // FrmCustomerChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(219)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1066, 543);
            this.Controls.Add(this.lblManageUsers);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.picSend);
            this.Controls.Add(this.txtCustomerMessageInput);
            this.Controls.Add(this.lbxCustomerMessageView);
            this.Controls.Add(this.lblLiveChat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCustomerChat";
            this.Text = "Customer Chat";
            this.Load += new System.EventHandler(this.FrmCustomerChat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomerMessageInput;
        private System.Windows.Forms.ListBox lbxCustomerMessageView;
        private System.Windows.Forms.Label lblLiveChat;
        private System.Windows.Forms.PictureBox picSend;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Label lblManageUsers;
    }
}