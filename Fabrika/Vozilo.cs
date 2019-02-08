using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrika
{
    abstract class Vozilo
    {
        protected string marka;
        protected string boja;
        protected int zauzima;

        public Vozilo(string marka, string boja) {
            this.marka = marka;
            this.boja = boja;
        }

        public int GetZauzima { get { return zauzima; } }
        public string Parking { get; set; }
    }
}
