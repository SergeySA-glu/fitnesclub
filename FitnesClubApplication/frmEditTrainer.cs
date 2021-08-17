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
    public partial class frmEditTrainer : Form
    {
        Trainers trainer;

        public frmEditTrainer(Trainers trainer)
        {
            InitializeComponent();
            this.trainer = trainer;
            ShowData();
        }

        private void ShowData()
        {
            nudCodeTrainer.Value = trainer.IdTrainer;
            txtNameTrainer.Text = trainer.NameTrainer;
            txtPhoneTrainer.Text = trainer.PhoneTrainer;
            txtAddressTrainer.Text = trainer.AddressTrainer;
            txtSalaryTrainer.Text = trainer.SalaryTrainer.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
