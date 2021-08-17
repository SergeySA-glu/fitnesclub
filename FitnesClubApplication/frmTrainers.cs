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
    public partial class frmTrainers : Form
    {
        FitnessClubEntities1 db = new FitnessClubEntities1();

        public frmTrainers()
        {
            InitializeComponent();
        }

        private void frmTrainers_Load(object sender, EventArgs e)
        {
            ShowTrainers();
        }

        private void ShowTrainers()
        {
            lstTrainers.Items.Clear();
            foreach (var trainers in db.Trainers)
            {
                lstTrainers.Items.Add(trainers);
            }
        }

        private void btnAddTrainer_Click(object sender, EventArgs e)
        {
            Trainers newTrainer = new Trainers();
            frmEditTrainer frm = new frmEditTrainer(newTrainer);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                db.Trainers.Add(newTrainer);
                db.SaveChanges();
                ShowTrainers();
            }
        }

        private void btnEditTrainer_Click(object sender, EventArgs e)
        {
            Trainers trainer;
            if (lstTrainers.SelectedItem == null)
                return;
            else
                trainer = lstTrainers.SelectedItem as Trainers;

            frmEditTrainer frm = new frmEditTrainer(trainer);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                db.SaveChanges();
                ShowTrainers();
            }
        }

        private void lstTrainers_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstTrainers2.Items.Clear();
            Trainers trainer;
            if (lstTrainers.SelectedItem == null)
                return;
            else
                trainer = lstTrainers.SelectedItem as Trainers;

            lstTrainers2.Items.Add("Услуги тренера:");
            foreach (var service in trainer.Service)
            {
                lstTrainers2.Items.Add(service);
            }
        }

        private void lstTrainers2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstTrainers2.SelectedItem != null)
            {
                frmServices frm = new frmServices();
                frm.ShowDialog();
            }
        }
    }
}
