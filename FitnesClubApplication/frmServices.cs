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
    public partial class frmServices : Form
    {
        FitnessClubEntities1 db = new FitnessClubEntities1();

        public frmServices()
        {
            InitializeComponent();
        }

        private void frmServices_Load(object sender, EventArgs e)
        {
            ShowServices();
        }

        private void ShowServices()
        {
            lstServices.Items.Clear();
            foreach (var service in db.Service)
            {
                lstServices.Items.Add(service);
            }
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            Service newService = new Service();
            frmEditService frm = new frmEditService(newService);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                db.Service.Add(newService);
                db.SaveChanges();
                ShowServices();
            }
        }

        private void btnEditService_Click(object sender, EventArgs e)
        {
            Service service;
            if (lstServices.SelectedItem == null)
                return;
            else
                service = lstServices.SelectedItem as Service;

            frmEditService frm = new frmEditService(service);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                db.SaveChanges();
                ShowServices();
            }
        }

        private void lstServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstTrainerService.Items.Clear();
            Service service;
            if (lstServices.SelectedItem == null)
                return;
            else
                service = lstServices.SelectedItem as Service;
            lstTrainerService.Items.Add("Тренер:");
            lstTrainerService.Items.Add(service.Trainers);
            lstTrainerService.Items.Add("Абонементы:");
            foreach (var abonement in service.Abonement)
            {
                lstTrainerService.Items.Add(abonement);
            }
        }

        private void lstTrainerService_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstTrainerService.SelectedIndex > 2)
            {
                frmAbonement frm = new frmAbonement();
                frm.ShowDialog();
            }
        }
    }
}
