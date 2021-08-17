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
    public partial class frmEditService : Form
    {
        Service service;

        public frmEditService(Service service)
        {
            InitializeComponent();
            this.service = service;
            ShowData();
        }

        private void ShowData()
        {
            nudCodeService.Value = service.IdService;
            txtNameService.Text = service.KindService;
            nudCodeTranerInService.Value = service.IdTrainer;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
