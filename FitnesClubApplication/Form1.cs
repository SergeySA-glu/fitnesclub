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
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            frmClients frm = new frmClients();
            frm.ShowDialog();
        }

        private void btnAbonement_Click(object sender, EventArgs e)
        {
            frmAbonement frm = new frmAbonement();
            frm.ShowDialog();
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            frmServices frm = new frmServices();
            frm.ShowDialog();
        }

        private void btnTrainers_Click(object sender, EventArgs e)
        {
            frmTrainers frm = new frmTrainers();
            frm.ShowDialog();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            frmSales frm = new frmSales();
            frm.ShowDialog();
        }
    }
}
