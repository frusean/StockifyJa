namespace StockifyJa
{
    partial class FrmAdminChat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminChat));
            this.txtAdminMessageInput = new System.Windows.Forms.TextBox();
            this.lbxAdminMessageView = new System.Windows.Forms.ListBox();
            this.btnAdminMessageSendButton = new System.Windows.Forms.Button();
            this.picSend = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSend)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAdminMessageInput
            // 
            this.txtAdminMessageInput.Location = new System.Drawing.Point(25, 463);
            this.txtAdminMessageInput.Multiline = true;
            this.txtAdminMessageInput.Name = "txtAdminMessageInput";
            this.txtAdminMessageInput.Size = new System.Drawing.Size(585, 53);
            this.txtAdminMessageInput.TabIndex = 44;
            this.txtAdminMessageInput.TextChanged += new System.EventHandler(this.txtAdminMessageInput_TextChanged);
            // 
            // lbxAdminMessageView
            // 
            this.lbxAdminMessageView.FormattingEnabled = true;
            this.lbxAdminMessageView.ItemHeight = 16;
            this.lbxAdminMessageView.Location = new System.Drawing.Point(43, 58);
            this.lbxAdminMessageView.Name = "lbxAdminMessageView";
            this.lbxAdminMessageView.Size = new System.Drawing.Size(567, 372);
            this.lbxAdminMessageView.TabIndex = 43;
            this.lbxAdminMessageView.SelectedIndexChanged += new System.EventHandler(this.lbxAdminMessageView_SelectedIndexChanged);
            // 
            // btnAdminMessageSendButton
            // 
            this.btnAdminMessageSendButton.Location = new System.Drawing.Point(660, 480);
            this.btnAdminMessageSendButton.Name = "btnAdminMessageSendButton";
            this.btnAdminMessageSendButton.Size = new System.Drawing.Size(75, 23);
            this.btnAdminMessageSendButton.TabIndex = 42;
            this.btnAdminMessageSendButton.Text = "Send";
            this.btnAdminMessageSendButton.UseVisualStyleBackColor = true;
            this.btnAdminMessageSendButton.Click += new System.EventHandler(this.btnAdminMessageSendButton_Click);
            // 
            // picSend
            // 
            this.picSend.Image = ((System.Drawing.Image)(resources.GetObject("picSend.Image")));
            this.picSend.Location = new System.Drawing.Point(774, 470);
            this.picSend.Name = "picSend";
            this.picSend.Size = new System.Drawing.Size(37, 33);
            this.picSend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSend.TabIndex = 51;
            this.picSend.TabStop = false;
            // 
            // FrmAdminChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(1060, 635);
            this.Controls.Add(this.picSend);
            this.Controls.Add(this.txtAdminMessageInput);
            this.Controls.Add(this.lbxAdminMessageView);
            this.Controls.Add(this.btnAdminMessageSendButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdminChat";
            this.Text = "Administrator Chat";
            this.Load += new System.EventHandler(this.FrmAdminChat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdminMessageInput;
        private System.Windows.Forms.ListBox lbxAdminMessageView;
        private System.Windows.Forms.Button btnAdminMessageSendButton;
        private System.Windows.Forms.PictureBox picSend;
    }
}