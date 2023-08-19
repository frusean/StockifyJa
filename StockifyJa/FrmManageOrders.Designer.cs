namespace StockifyJa
{
    partial class FrmManageOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManageOrders));
            this.cmbProductID = new System.Windows.Forms.ComboBox();
            this.picSave = new System.Windows.Forms.PictureBox();
            this.picDelete = new System.Windows.Forms.PictureBox();
            this.picRefresh = new System.Windows.Forms.PictureBox();
            this.picAdd = new System.Windows.Forms.PictureBox();
            this.picUpdate = new System.Windows.Forms.PictureBox();
            this.lblProductID = new System.Windows.Forms.Label();
            this.nudQuantityOrdered = new System.Windows.Forms.NumericUpDown();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDateOrdered = new System.Windows.Forms.DateTimePicker();
            this.txtQuantityOrdered = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblManageProducts = new System.Windows.Forms.Label();
            this.lblModifiedDate = new System.Windows.Forms.Label();
            this.dtpModifiedDate = new System.Windows.Forms.DateTimePicker();
            this.txtModifiedBy = new System.Windows.Forms.TextBox();
            this.lblModifiedBy = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantityOrdered)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbProductID
            // 
            this.cmbProductID.FormattingEnabled = true;
            this.cmbProductID.Location = new System.Drawing.Point(586, 106);
            this.cmbProductID.Name = "cmbProductID";
            this.cmbProductID.Size = new System.Drawing.Size(121, 24);
            this.cmbProductID.TabIndex = 66;
            // 
            // picSave
            // 
            this.picSave.Image = ((System.Drawing.Image)(resources.GetObject("picSave.Image")));
            this.picSave.Location = new System.Drawing.Point(1135, 465);
            this.picSave.Name = "picSave";
            this.picSave.Size = new System.Drawing.Size(43, 42);
            this.picSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSave.TabIndex = 65;
            this.picSave.TabStop = false;
            this.picSave.Click += new System.EventHandler(this.picSave_Click);
            // 
            // picDelete
            // 
            this.picDelete.Image = ((System.Drawing.Image)(resources.GetObject("picDelete.Image")));
            this.picDelete.Location = new System.Drawing.Point(1016, 465);
            this.picDelete.Name = "picDelete";
            this.picDelete.Size = new System.Drawing.Size(43, 42);
            this.picDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDelete.TabIndex = 64;
            this.picDelete.TabStop = false;
            this.picDelete.Click += new System.EventHandler(this.picDelete_Click);
            // 
            // picRefresh
            // 
            this.picRefresh.Image = ((System.Drawing.Image)(resources.GetObject("picRefresh.Image")));
            this.picRefresh.Location = new System.Drawing.Point(1065, 465);
            this.picRefresh.Name = "picRefresh";
            this.picRefresh.Size = new System.Drawing.Size(43, 42);
            this.picRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRefresh.TabIndex = 63;
            this.picRefresh.TabStop = false;
            this.picRefresh.Click += new System.EventHandler(this.picRefresh_Click);
            // 
            // picAdd
            // 
            this.picAdd.Image = ((System.Drawing.Image)(resources.GetObject("picAdd.Image")));
            this.picAdd.Location = new System.Drawing.Point(883, 465);
            this.picAdd.Name = "picAdd";
            this.picAdd.Size = new System.Drawing.Size(43, 42);
            this.picAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAdd.TabIndex = 62;
            this.picAdd.TabStop = false;
            this.picAdd.Click += new System.EventHandler(this.picAdd_Click);
            // 
            // picUpdate
            // 
            this.picUpdate.Image = ((System.Drawing.Image)(resources.GetObject("picUpdate.Image")));
            this.picUpdate.Location = new System.Drawing.Point(953, 465);
            this.picUpdate.Name = "picUpdate";
            this.picUpdate.Size = new System.Drawing.Size(43, 42);
            this.picUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUpdate.TabIndex = 61;
            this.picUpdate.TabStop = false;
            this.picUpdate.Click += new System.EventHandler(this.picUpdate_Click);
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductID.Location = new System.Drawing.Point(453, 109);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(79, 16);
            this.lblProductID.TabIndex = 60;
            this.lblProductID.Text = "Product ID";
            // 
            // nudQuantityOrdered
            // 
            this.nudQuantityOrdered.Location = new System.Drawing.Point(587, 179);
            this.nudQuantityOrdered.Name = "nudQuantityOrdered";
            this.nudQuantityOrdered.ReadOnly = true;
            this.nudQuantityOrdered.Size = new System.Drawing.Size(120, 22);
            this.nudQuantityOrdered.TabIndex = 59;
            this.nudQuantityOrdered.ValueChanged += new System.EventHandler(this.nudQuantityOrdered_ValueChanged);
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(17, 31);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.ReadOnly = true;
            this.txtOrderID.Size = new System.Drawing.Size(52, 22);
            this.txtOrderID.TabIndex = 19;
            this.txtOrderID.TextChanged += new System.EventHandler(this.txtOrderID_TextChanged);
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(37, 513);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowHeadersWidth = 51;
            this.dgvOrders.RowTemplate.Height = 24;
            this.dgvOrders.Size = new System.Drawing.Size(1141, 164);
            this.dgvOrders.TabIndex = 58;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(460, 315);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(43, 16);
            this.lblTotal.TabIndex = 56;
            this.lblTotal.Text = "Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(460, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 55;
            this.label1.Text = "Date Ordered";
            // 
            // dtpDateOrdered
            // 
            this.dtpDateOrdered.Location = new System.Drawing.Point(586, 243);
            this.dtpDateOrdered.Name = "dtpDateOrdered";
            this.dtpDateOrdered.Size = new System.Drawing.Size(245, 22);
            this.dtpDateOrdered.TabIndex = 54;
            this.dtpDateOrdered.ValueChanged += new System.EventHandler(this.dtpDateOrdered_ValueChanged);
            // 
            // txtQuantityOrdered
            // 
            this.txtQuantityOrdered.AutoSize = true;
            this.txtQuantityOrdered.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantityOrdered.Location = new System.Drawing.Point(450, 185);
            this.txtQuantityOrdered.Name = "txtQuantityOrdered";
            this.txtQuantityOrdered.Size = new System.Drawing.Size(115, 16);
            this.txtQuantityOrdered.TabIndex = 53;
            this.txtQuantityOrdered.Text = "Quantity Ordred";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(587, 309);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 22);
            this.txtTotal.TabIndex = 57;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtOrderID);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(147, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(88, 74);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order ID";
            // 
            // lblManageProducts
            // 
            this.lblManageProducts.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblManageProducts.AutoSize = true;
            this.lblManageProducts.BackColor = System.Drawing.Color.Transparent;
            this.lblManageProducts.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(167)))));
            this.lblManageProducts.Location = new System.Drawing.Point(514, 35);
            this.lblManageProducts.Name = "lblManageProducts";
            this.lblManageProducts.Size = new System.Drawing.Size(205, 32);
            this.lblManageProducts.TabIndex = 51;
            this.lblManageProducts.Text = "Manage Orders";
            this.lblManageProducts.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblModifiedDate
            // 
            this.lblModifiedDate.AutoSize = true;
            this.lblModifiedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifiedDate.Location = new System.Drawing.Point(461, 444);
            this.lblModifiedDate.Name = "lblModifiedDate";
            this.lblModifiedDate.Size = new System.Drawing.Size(104, 16);
            this.lblModifiedDate.TabIndex = 70;
            this.lblModifiedDate.Text = "Modified Date";
            // 
            // dtpModifiedDate
            // 
            this.dtpModifiedDate.Location = new System.Drawing.Point(579, 440);
            this.dtpModifiedDate.Name = "dtpModifiedDate";
            this.dtpModifiedDate.Size = new System.Drawing.Size(245, 22);
            this.dtpModifiedDate.TabIndex = 69;
            // 
            // txtModifiedBy
            // 
            this.txtModifiedBy.Location = new System.Drawing.Point(579, 373);
            this.txtModifiedBy.Name = "txtModifiedBy";
            this.txtModifiedBy.ReadOnly = true;
            this.txtModifiedBy.Size = new System.Drawing.Size(128, 22);
            this.txtModifiedBy.TabIndex = 68;
            // 
            // lblModifiedBy
            // 
            this.lblModifiedBy.AutoSize = true;
            this.lblModifiedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifiedBy.Location = new System.Drawing.Point(461, 373);
            this.lblModifiedBy.Name = "lblModifiedBy";
            this.lblModifiedBy.Size = new System.Drawing.Size(89, 16);
            this.lblModifiedBy.TabIndex = 67;
            this.lblModifiedBy.Text = "Modified By";
            // 
            // picExit
            // 
            this.picExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.Location = new System.Drawing.Point(1184, 630);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(53, 47);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExit.TabIndex = 71;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // FrmManageOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(219)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1234, 689);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.lblModifiedDate);
            this.Controls.Add(this.dtpModifiedDate);
            this.Controls.Add(this.txtModifiedBy);
            this.Controls.Add(this.lblModifiedBy);
            this.Controls.Add(this.cmbProductID);
            this.Controls.Add(this.picSave);
            this.Controls.Add(this.picDelete);
            this.Controls.Add(this.picRefresh);
            this.Controls.Add(this.picAdd);
            this.Controls.Add(this.picUpdate);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.nudQuantityOrdered);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDateOrdered);
            this.Controls.Add(this.txtQuantityOrdered);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblManageProducts);
            this.Name = "FrmManageOrders";
            this.Text = "Manage Orders";
            this.Load += new System.EventHandler(this.FrmManageOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantityOrdered)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProductID;
        private System.Windows.Forms.PictureBox picSave;
        private System.Windows.Forms.PictureBox picDelete;
        private System.Windows.Forms.PictureBox picRefresh;
        private System.Windows.Forms.PictureBox picAdd;
        private System.Windows.Forms.PictureBox picUpdate;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.NumericUpDown nudQuantityOrdered;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDateOrdered;
        private System.Windows.Forms.Label txtQuantityOrdered;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblManageProducts;
        private System.Windows.Forms.Label lblModifiedDate;
        private System.Windows.Forms.DateTimePicker dtpModifiedDate;
        private System.Windows.Forms.TextBox txtModifiedBy;
        private System.Windows.Forms.Label lblModifiedBy;
        private System.Windows.Forms.PictureBox picExit;
    }
}