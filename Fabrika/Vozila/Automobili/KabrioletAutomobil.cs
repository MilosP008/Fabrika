using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrika.Vozila.Automobili
{
    class KabrioletAutomobil : Automobil
    {
        private bool krovKojiSeMozeSkinuti;

        public KabrioletAutomobil(bool krovKojiSeMozeSkinuti, int brojSedista, string marka, string boja, string[] dodatnaOprema) : base(brojSedista, marka, boja, dodatnaOprema) {
            this.krovKojiSeMozeSkinuti = krovKojiSeMozeSkinuti;
        }

        public string GetKrovKojiSeMozeSkinuti {
            get
            {
                if(krovKojiSeMozeSkinuti == true)
                {
                    return "jeste";
                }
                else
                {
                    return "nije";
                }
            }
        }

        public override string ToString()
        {
            return "Kabriolet automobil" + ", marka: " + marka + ", boja: " + boja + ", broj sedista: " + brojSedista + ", dodatna oprema: " + ((DodatnaOprema == string.Empty) ? "nema" : DodatnaOprema) + ", skidajuci krov: " + GetKrovKojiSeMozeSkinuti + ", zauzima: " + zauzima + " m2, parking: " + Parking;
        }
    }
}
