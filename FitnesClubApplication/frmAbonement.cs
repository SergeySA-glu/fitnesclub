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
    public partial class frmAbonement : Form
    {
        FitnessClubEntities1 db = new FitnessClubEntities1();

        public frmAbonement()
        {
            InitializeComponent();
        }

        

        private void ShowAbonement()
        {
            lstAbonement.Items.Clear();
            foreach (Abonement abonement in db.Abonement)
            {
                lstAbonement.Items.Add(abonement);
            }
        }

        private void btnAddAbonement_Click(object sender, EventArgs e)
        {
            Abonement newAbonement = new Abonement();
            frmEditAbonement frm = new frmEditAbonement(newAbonement);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                db.Abonement.Add(newAbonement);
                db.SaveChanges();
                ShowAbonement();
            }
        }

        private void btnEditAbonement_Click(object sender, EventArgs e)
        {
            Abonement abonement;
            if (lstAbonement.SelectedItem == null)
                return;
            else
                abonement = lstAbonement.SelectedItem as Abonement;

            frmEditAbonement frm = new frmEditAbonement(abonement);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                db.SaveChanges();
                ShowAbonement();
            }
        }

        private void frmAbonement_Load(object sender, EventArgs e)
        {
            ShowAbonement();
        }

        private void lstAbonement_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstAbonementService.Items.Clear();
            Abonement abonement;
            if (lstAbonement.SelectedItem == null)
                return;
            else
                abonement = lstAbonement.SelectedItem as Abonement;
            lstAbonementService.Items.Add("Услуга:");
            lstAbonementService.Items.Add(abonement.Service);
            lstAbonementService.Items.Add("Тренер:");
            lstAbonementService.Items.Add(abonement.Service.Trainers);
            lstAbonementService.Items.Add("Продано:");
            foreach (var sale in abonement.Sale)
            {
                lstAbonementService.Items.Add(sale);
            }
        }

        private void lstAbonementService_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstAbonementService.SelectedIndex > 4)
            {
                frmSales frm = new frmSales();
                frm.ShowDialog();
            }
        }
    }
}
