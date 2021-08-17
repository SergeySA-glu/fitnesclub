using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnesClubApplication
{
    public partial class Sale
    {
        public override string ToString()
        {
            return this.SaleCode.ToString() + "\t\t" +
                this.SaleDate.ToShortDateString() + "\t" +
                this.IdAbonement.ToString() + "\t" +
                this.IdClient.ToString();

        }
    }
}
