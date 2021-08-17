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
    public partial class frmEditClients : Form
    {
        Clients client;

        public frmEditClients(Clients client)
        {
            InitializeComponent();
            this.client = client;
            ShowData();
        }

        private void frmEditClients_Load(object sender, EventArgs e)
        {

        }

        private void ShowData()
        {
            nudCode.Value = client.IdClient;
            txtName.Text = client.NameClient;
            txtAddress.Text = client.AddressClient;
            txtPhone.Text = client.Phone;
            txtBirthday.Text = client.DateOfBirthdayClient;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            client.IdClient = (int)nudCode.Value;
            client.NameClient = txtName.Text;
            client.AddressClient = txtAddress.Text;
            client.Phone = txtPhone.Text;
            client.DateOfBirthdayClient = txtBirthday.Text;
            this.Hide();
        }
    }
}
