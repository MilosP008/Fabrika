using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrika.Parkinzi
{
    class NadkriveniParking
    {
        private int povrsina;
        private double visina;
        private List<Vozilo> vozilaUNadkrivenomParkingu = new List<Vozilo>();

        public NadkriveniParking(int povrsina, double visina) {
            this.povrsina = povrsina;
            this.visina = visina;
        }

        public static NadkriveniParking operator-(NadkriveniParking nadkriveniParking, Vozilo vozilo)
        {
            nadkriveniParking.povrsina -= vozilo.GetZauzima;
            nadkriveniParking.vozilaUNadkrivenomParkingu.Add(vozilo);
            return new NadkriveniParking(nadkriveniParking.povrsina, nadkriveniParking.visina);
        }

        public static NadkriveniParking operator+(NadkriveniParking nadkriveniParking, Vozilo vozilo)
        {
            nadkriveniParking.povrsina += vozilo.GetZauzima;
            nadkriveniParking.vozilaUNadkrivenomParkingu.Remove(vozilo);
            return new NadkriveniParking(nadkriveniParking.povrsina, nadkriveniParking.visina);
        }

        public int Povrsina {
            get { return povrsina; }
            set { if (value == 30 || value == 50) {
                    povrsina = value;
                }
            }
        }

        public double Visina {
            get { return visina; }
            set { if (value == 2.5 || value == 5) {
                    visina = value;
                }
            }
        }

        public List<Vozilo> VozilaUNadkrivenomParkingu { get { return vozilaUNadkrivenomParkingu; } }
    }
}
