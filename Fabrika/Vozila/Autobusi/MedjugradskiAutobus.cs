using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrika.Vozila.Autobusi
{
    class MedjugradskiAutobus : Autobus
    {
        private double kapacitetPrtljaznogProstora;

        public MedjugradskiAutobus(double kapacitetPrtljaznogProstora, int brojMestaZaStajanje, int brojMestaZaSedenje, string marka, string boja) : base(brojMestaZaStajanje, brojMestaZaSedenje, marka, boja)
        {
            this.kapacitetPrtljaznogProstora = kapacitetPrtljaznogProstora;
            zauzima = 15;
        }

        public override string ToString()
        {
            return "Medjugradski autobus" + ", marka: " + marka + ", boja: " + boja + ", broj mesta za stajanje: " + brojMestaZaStajanje + ", broj mesta za sedenje: " + brojMestaZaSedenje + ", kapacitet prtljaznog prostora: " + kapacitetPrtljaznogProstora + ", zauzima: " + zauzima + " m2, parking: " + Parking;
        }
    }
}
