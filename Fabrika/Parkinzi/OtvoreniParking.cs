using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrika.Parkinzi
{
    class OtvoreniParking
    {
        private int povrsina;
        private List<Vozilo> vozilaUOtvorenomParkingu = new List<Vozilo>();

        public OtvoreniParking()
        {
            povrsina = 1000;
        }

        private OtvoreniParking(int povrsina)
        {
            this.povrsina = povrsina;
        }

        public static OtvoreniParking operator-(OtvoreniParking otvoreniParking, Vozilo vozilo)
        {
            otvoreniParking.povrsina = otvoreniParking.povrsina - vozilo.GetZauzima;
            otvoreniParking.vozilaUOtvorenomParkingu.Add(vozilo);
            return new OtvoreniParking(otvoreniParking.povrsina);
        }

        public static OtvoreniParking operator+(OtvoreniParking otvoreniParking, Vozilo vozilo)
        {
            otvoreniParking.povrsina = otvoreniParking.povrsina + vozilo.GetZauzima;
            otvoreniParking.vozilaUOtvorenomParkingu.Remove(vozilo);
            return new OtvoreniParking(otvoreniParking.povrsina);
        }

        public List<Vozilo> VozilaUOtvorenomParkingu{ get { return vozilaUOtvorenomParkingu; } }
    }
}
