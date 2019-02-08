using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrika.Vozila
{
    abstract class Kamion : Vozilo
    {
        protected int brojOsovina;

        public Kamion(int brojOsovina, string marka, string boja) : base(marka, boja)
        {
            this.brojOsovina = brojOsovina;
        }
    }
}
