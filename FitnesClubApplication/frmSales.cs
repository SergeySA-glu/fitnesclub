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
    public partial class frmSales : Form
    {
        FitnessClubEntities1 db = new FitnessClubEntities1();

        public frmSales()
        {
            InitializeComponent();
        }

        private void frmSales_Load(object sender, EventArgs e)
        {
            ShowSales();
        }

        private void ShowSales()
        {
            lstSales.Items.Clear();
            string headersSales = "Продажа\tДата\t        Абонемент\tКлиент";
            lstSales.Items.Add(headersSales);
            foreach (var sale in db.Sale)
            {
                lstSales.Items.Add(sale);
            }
        }

        private void btnAddSale_Click(object sender, EventArgs e)
        {
            Sale newSale = new Sale();
            newSale.SaleDate = DateTime.Now;
            frmEditSale frm = new frmEditSale(newSale);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                db.Sale.Add(newSale);
                db.SaveChanges();
                ShowSales();
            }
        }

        private void btnEditSale_Click(object sender, EventArgs e)
        {
            Sale sale;
            if (lstSales.SelectedItem == null)
                return;
            else
                sale = lstSales.SelectedItem as Sale;

            frmEditSale frm = new frmEditSale(sale);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                db.SaveChanges();
                ShowSales();
            }
        }

        private void btnRemoveSale_Click(object sender, EventArgs e)
        {
            Sale sale;
            if (lstSales.SelectedItem == null)
                return;
            else
                sale = lstSales.SelectedItem as Sale;
            lstSales.Items.Remove(sale);
            db.SaveChanges();
            ShowSales();
        }

        private void lstSales_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstSaleData.Items.Clear();
            Sale sale;
            if (lstSales.SelectedItem == null)
                return;
            else
                sale = lstSales.SelectedItem as Sale;
            lstSaleData.Items.Add("Абонемент:");
            lstSaleData.Items.Add(sale.Abonement);
            lstSaleData.Items.Add("Продано клиенту:");
            lstSaleData.Items.Add(sale.Clients);
        }

        private void lstSaleData_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstSaleData.SelectedIndex == 1)
            {
                frmAbonement frm = new frmAbonement();
                frm.ShowDialog();
            }

            if (lstSaleData.SelectedIndex == 3)
            {
                frmClients frm = new frmClients();
                frm.ShowDialog();
            }

        }

        private void btnGain_Click(object sender, EventArgs e)
        {
            frmGain frm = new frmGain();
            frm.ShowDialog();
        }
    }
}
