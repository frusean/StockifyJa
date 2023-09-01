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
            this.picSend = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.lblManageUsers = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAdminMessageInput
            // 
            this.txtAdminMessageInput.Location = new System.Drawing.Point(235, 484);
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
            this.lbxAdminMessageView.Location = new System.Drawing.Point(244, 78);
            this.lbxAdminMessageView.Name = "lbxAdminMessageView";
            this.lbxAdminMessageView.Size = new System.Drawing.Size(567, 372);
            this.lbxAdminMessageView.TabIndex = 43;
            this.lbxAdminMessageView.SelectedIndexChanged += new System.EventHandler(this.lbxAdminMessageView_SelectedIndexChanged);
            // 
            // picSend
            // 
            this.picSend.Image = ((System.Drawing.Image)(resources.GetObject("picSend.Image")));
            this.picSend.Location = new System.Drawing.Point(848, 495);
            this.picSend.Name = "picSend";
            this.picSend.Size = new System.Drawing.Size(37, 33);
            this.picSend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSend.TabIndex = 51;
            this.picSend.TabStop = false;
            this.picSend.Click += new System.EventHandler(this.picSend_Click);
            // 
            // picExit
            // 
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.Location = new System.Drawing.Point(987, 576);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(61, 47);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExit.TabIndex = 52;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // lblManageUsers
            // 
            this.lblManageUsers.AutoSize = true;
            this.lblManageUsers.Font = new System.Drawing.Font("Georgia", 16.2F);
            this.lblManageUsers.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblManageUsers.Location = new System.Drawing.Point(497, 9);
            this.lblManageUsers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblManageUsers.Name = "lblManageUsers";
            this.lblManageUsers.Size = new System.Drawing.Size(73, 32);
            this.lblManageUsers.TabIndex = 53;
            this.lblManageUsers.Text = "Chat";
            // 
            // FrmAdminChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(1060, 635);
            this.Controls.Add(this.lblManageUsers);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.picSend);
            this.Controls.Add(this.txtAdminMessageInput);
            this.Controls.Add(this.lbxAdminMessageView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdminChat";
            this.Text = "Administrator Chat";
            this.Load += new System.EventHandler(this.FrmAdminChat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdminMessageInput;
        private System.Windows.Forms.ListBox lbxAdminMessageView;
        private System.Windows.Forms.PictureBox picSend;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Label lblManageUsers;
    }
}