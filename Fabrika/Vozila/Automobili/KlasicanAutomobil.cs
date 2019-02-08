using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrika.Vozila.Automobili
{
    class KlasicanAutomobil : Automobil
    {
        private int nosivostKrova;

        public KlasicanAutomobil(int nosivostKrova, int brojSedista, string marka, string boja, string[] dodatnaOprema) : base(brojSedista, marka, boja, dodatnaOprema)
        {
            this.nosivostKrova = nosivostKrova;
        }

        public override string ToString()
        {
            return "Klasican automobil" + ", marka: " + marka + ", boja: " + boja + ", broj sedista: " + brojSedista + ", dodatna oprema: " + ((DodatnaOprema == string.Empty) ? "nema" : DodatnaOprema) + ", nosivost krova: " + nosivostKrova + " kg" + ", zauzima: " + zauzima + " m2, parking: " + Parking;
        }
    }
}
