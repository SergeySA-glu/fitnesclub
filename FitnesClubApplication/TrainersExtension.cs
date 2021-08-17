using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnesClubApplication
{
    public partial class Trainers
    {
        public override string ToString()
        {
            return this.IdTrainer.ToString() + "\t" +
                this.NameTrainer.ToString();

        }
    }
}
