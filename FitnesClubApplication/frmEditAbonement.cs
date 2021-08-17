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
    public partial class frmEditAbonement : Form
    {
        Abonement abonement;

        public frmEditAbonement(Abonement abonement)
        {
            InitializeComponent();
            this.abonement = abonement;
            ShowData();
        }

        private void ShowData()
        {
            nudCodeAbonement.Value = abonement.IdAbonement;
            txtNameAbonement.Text = abonement.NameAbonement;
            nudDuration.Value = abonement.DurationAbonement;
            txtPrice.Text = abonement.PriceAbonement.ToString();
            nudIdServiceInAbonement.Value = abonement.IdService;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
