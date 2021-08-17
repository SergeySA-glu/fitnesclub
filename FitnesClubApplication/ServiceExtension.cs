using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnesClubApplication
{
    public partial class Service
    {
        public override string ToString()
        {
            return this.IdService.ToString() + "\t" +
                this.KindService.ToString();

        }
    }
}
