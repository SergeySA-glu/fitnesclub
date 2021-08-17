using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnesClubApplication
{
    public partial class frmEditSale : Form
    {
        Sale sale;

        public frmEditSale(Sale sale)
        {
            InitializeComponent();
            this.sale = sale;
            ShowData();
        }
        

        private void ShowData()
        {
            nudCodeSale.Value = sale.SaleCode;
            dtpSaleDate.Value = sale.SaleDate;
            nudIdAbonementInSales.Value = sale.IdAbonement;
            nudIdClientInSales.Value = sale.IdClient;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            sale.SaleCode = (int)nudCodeSale.Value;
            sale.SaleDate = dtpSaleDate.Value;
            sale.IdAbonement = (int)nudIdAbonementInSales.Value;
            sale.IdClient = (int)nudIdClientInSales.Value;
            this.Hide();
        }
    }
}
