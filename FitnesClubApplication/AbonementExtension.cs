using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnesClubApplication
{
    public partial class Abonement
    {
        public override string ToString()
        {
            return this.IdAbonement.ToString() + "\t" +
                this.NameAbonement.ToString();

        }
    }
}
