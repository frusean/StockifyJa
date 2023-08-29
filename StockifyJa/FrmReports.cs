using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxWMPLib;


namespace StockifyJa
{
    public partial class FrmReports : Form
    {
        public FrmReports()
        {
            InitializeComponent();

           
            axWMPSalesReport.URL = @"C:\Users\demet\Downloads\StockifyJa\StockifyJa\StockifyJa\Sales Report.mp4"; // Replace with your actual file path
            axWMPSalesReport.settings.autoStart = true; 

        }

        private void FrmReports_Load(object sender, EventArgs e)
        {
            axWMPSalesReport.Ctlcontrols.play();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

