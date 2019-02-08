using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrika.Vozila.Autobusi
{
    class GradskiAutobus : Autobus
    {
        private bool zglobni;

        public GradskiAutobus(bool zglobni, int brojMestaZaStajanje, int brojMestaZaSedenje, string marka, string boja) : base(brojMestaZaStajanje, brojMestaZaSedenje, marka, boja)
        {
            this.zglobni = zglobni;
            zauzima = 30;
        }

        private string GetZglobni {
            get {
                if (zglobni == true)
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
            return "Gradski autobus" + ", marka: " + marka + ", boja: " + boja + ", broj mesta za stajanje: " + brojMestaZaStajanje + ", broj mesta za sedenje: " + brojMestaZaSedenje + ", zglobni: " + GetZglobni + ", zauzima: " + zauzima + " m2, parking: " + Parking;
        }
    }
}