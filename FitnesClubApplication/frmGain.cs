using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace FitnesClubApplication
{
    public partial class frmGain : Form
    {
        FitnessClubEntities1 db = new FitnessClubEntities1();
        public frmGain()
        {
            InitializeComponent();
        }

        private void btnSumGain_Click(object sender, EventArgs e)
        {
            DateTime minSaleDate = new DateTime();
            DateTime maxSaleDate = new DateTime();

            minSaleDate = dtpMinSaleDate.Value;
            maxSaleDate = dtpMaxSaleDate.Value;
            decimal sum = 0;

            foreach (var sale in db.Sale)
            {
                if (sale.SaleDate <= maxSaleDate & sale.SaleDate > minSaleDate.AddDays(-1))
                    sum += sale.Abonement.PriceAbonement;
            }
            txtSumGain.Text = sum.ToString();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            DateTime minSaleDate = new DateTime();
            DateTime maxSaleDate = new DateTime();

            minSaleDate = dtpMinSaleDate.Value;
            maxSaleDate = dtpMaxSaleDate.Value;
            decimal sum = 0;
            
            string path = @"c:\Report.txt";
            StreamWriter write = new StreamWriter(path, false, System.Text.Encoding.Default);

            FileInfo file = new FileInfo(path);
            if (!file.Exists) file.Create();
            else
            {
                var text = db.Sale.ToList();
                write.WriteLine("Код продажи: Дата продажи - Услуга по абонементу - Клиент - Стоимость абонемента\n");
                write.WriteLine("");
                foreach (var row in text)
                {
                    if (row.SaleDate <= maxSaleDate & row.SaleDate > minSaleDate.AddDays(-1))
                    {
                        write.Write("{0}: {1} - {2} - {3} - {4}", 
                            row.SaleCode, 
                            row.SaleDate.ToShortDateString(), 
                            row.Abonement.Service.KindService, 
                            row.Clients.NameClient, 
                            row.Abonement.PriceAbonement);
                        sum += row.Abonement.PriceAbonement;
                        write.WriteLine();
                    }
                }
                write.WriteLine("\n");
                write.WriteLine("");
                write.WriteLine("Общая сумма: {0}", sum);
                write.Close();
            }
        }

        private void frmGain_Load(object sender, EventArgs e)
        {

        }
    }
}
