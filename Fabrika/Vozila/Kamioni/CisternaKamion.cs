using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrika.Vozila.Kamioni
{
    class CisternaKamion : Kamion
    {
        private double kapacitetTanka;

        public CisternaKamion(double kapacitetTanka, int brojOsovina, string marka, string boja) : base(brojOsovina, marka, boja)
        {
            this.kapacitetTanka = kapacitetTanka;
            zauzima = 20;
        }

        public override string ToString()
        {
            return "Cisterna kamion" + ", marka: " + marka + ", boja: " + boja + ", broj osovina: " + brojOsovina + ", kapacitet tanka: " + kapacitetTanka + ", zauzima: " + zauzima + " m2, parking: " + Parking;
        }
    }
}
