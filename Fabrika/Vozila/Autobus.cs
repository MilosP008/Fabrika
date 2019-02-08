using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrika.Vozila
{
    abstract class Autobus : Vozilo
    {
        protected int brojMestaZaStajanje;
        protected int brojMestaZaSedenje;

        public Autobus(int brojMestaZaStajanje, int brojMestaZaSedenje, string marka, string boja) : base(marka, boja)
        {
            this.brojMestaZaStajanje = brojMestaZaStajanje;
            this.brojMestaZaSedenje = brojMestaZaSedenje;
        }
    }
}
