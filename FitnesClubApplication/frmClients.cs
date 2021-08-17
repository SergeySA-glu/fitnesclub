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
    public partial class frmClients : Form
    {
        FitnessClubEntities1 db = new FitnessClubEntities1();

        public frmClients()
        {
            InitializeComponent();
        }

        private void frmClients_Load(object sender, EventArgs e)
        {
            ShowClients();
        }

        private void ShowClients()
        {
            lstClients.Items.Clear();
            foreach (var client in db.Clients)
            {
                lstClients.Items.Add(client);
            }
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            Clients newClient = new Clients();
            frmEditClients frm = new frmEditClients(newClient);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                db.Clients.Add(newClient);
                db.SaveChanges();
                ShowClients();
            }
        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            Clients client;
            if (lstClients.SelectedItem == null)
                return;
            else
                client = lstClients.SelectedItem as Clients;

            frmEditClients frm = new frmEditClients(client);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                db.SaveChanges();
                ShowClients();
            }
        }

        private void lstClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstClientsSales.Items.Clear();
            Clients client;
            if (lstClients.SelectedItem == null)
                return;
            else
                client = lstClients.SelectedItem as Clients;
            string headersSales = "Продажа\tДата\t        Абонемент\tКлиент";
            lstClientsSales.Items.Add(headersSales);
            foreach (var sale in client.Sale)
            {
                lstClientsSales.Items.Add(sale);
            }
        }

        private void btnRemoveClient_Click(object sender, EventArgs e)
        {
            Clients client;
            if (lstClients.SelectedItem == null)
                return;
            else
                client = lstClients.SelectedItem as Clients;
            lstClients.Items.Remove(client);
            db.SaveChanges();
            ShowClients();

        }

        private void lstClientsSales_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(lstClientsSales.SelectedItem != null)
            {
                frmSales frm = new frmSales();
                frm.ShowDialog();
            }
        }
    }
}
