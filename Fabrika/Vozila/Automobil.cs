using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrika.Vozila
{
    abstract class Automobil : Vozilo
    {
        protected int brojSedista;
        private string[] dodatnaOprema;

        public Automobil(int brojSedista, string marka, string boja, string[] dodatnaOprema) : base(marka, boja)
        {
            this.brojSedista = brojSedista;
            this.dodatnaOprema = dodatnaOprema;
            zauzima = 8;
        }

        protected string DodatnaOprema {
            get
            {
                string oprema = "";
                foreach(string stavka in dodatnaOprema)
                {
                    oprema += stavka;
                    if(dodatnaOprema.Length > 1 && !stavka.Equals(dodatnaOprema.Last()))
                    {
                        oprema += " - ";
                    }
                }
                return oprema;
            }
        }
    }
}
