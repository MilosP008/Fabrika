using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrika.Vozila.Kamioni
{
    class SleperKamion : Kamion
    {
        private int vucnaSnaga;

        public SleperKamion(int vucnaSnaga, int brojOsovina, string marka, string boja) : base(brojOsovina, marka, boja)
        {
            this.vucnaSnaga = vucnaSnaga;
            zauzima = 15;
        }

        public override string ToString()
        {
            return "Sleper kamion" + ", marka: " + marka + ", boja: " + boja + ", broj osovina: " + brojOsovina + ", vucna snaga: " + vucnaSnaga + ", zauzima: " + zauzima + " m2, parking: " + Parking;
        }
    }
}
