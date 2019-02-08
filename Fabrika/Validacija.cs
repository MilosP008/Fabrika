using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fabrika.Vozila.Autobusi;

namespace Fabrika
{
    interface IValidacija
    {
        
    }

    static class Validacija
    {
        private static string ProveriVozilo(string marka, string boja)
        {
            string[] marke = { "Reno", "Citroen", "Pezo", "BMW", "Lasta", "Ford", "Audi", "Opel", "Nissan", "Honda", "Porse", "Mercedes", "Mazda", "Toyota", "Fiat", "Mini", "Alfa romeo", "Chrysler", "Land rover", "Jeep", "Volvo", "Seat" };
            string[] boje = { "Crna", "Bela", "Zuta", "Crvena", "Zelena", "Plava", "Narandzasta", "Braon", "Roza", "Siva", "Ljubicasta" };
            string greska = "";

            if (!Array.Exists(marke, e => e == marka))
            {
                greska += "Marka ne postoji.\n";
            }

            if(!Array.Exists(boje, e => e == boja))
            {
                greska += "Boja ne postoji.\n";
            }

            return greska;
        }

        private static string ProveriAutobus(int brojMestaZaStajanje, int brojMestaZaSedenje)
        {
            string greska = "";
            
            if (brojMestaZaStajanje < 5 || brojMestaZaStajanje > 20)
            {
                greska += "Broj mesta za stajanje mora biti izmedju 5 i 20.\n";
            }

            if (brojMestaZaSedenje < 5 || brojMestaZaSedenje > 20)
            {
                greska += "Broj mesta za sedenje mora biti izmedju 5 i 20.\n";
            }

            return greska;
        }

        private static string ProveriAutomobil(int brojSedista)
        {
            string greska = "";

            if (brojSedista < 4 || brojSedista > 8)
            {
                greska += "Broj sedista mora biti izmedju 4 i 8.\n";
            }

            return greska;
        }

        private static string ProveriKamion(int brojOsovina)
        {
            string greska = "";

            if (brojOsovina < 2 || brojOsovina > 4)
            {
                greska += "Broj osovina mora biti izmedju 2 i 4.\n";
            }

            return greska;
        }

        public static string ProveriGradskiAutobus(int brojMestaZaStajanje, int brojMestaZaSedenje, string marka, string boja)
        {
            string greska = ProveriVozilo(marka, boja);
            greska += ProveriAutobus(brojMestaZaStajanje, brojMestaZaSedenje);

            return greska;
        }

        public static string ProveriMedjugradskiAutobus(double kapacitetPrtljaznogProstora, int brojMestaZaStajanje, int brojMestaZaSedenje, string marka, string boja)
        {
            string greska = ProveriVozilo(marka, boja);
            greska += ProveriAutobus(brojMestaZaStajanje, brojMestaZaSedenje);

            if(kapacitetPrtljaznogProstora > 20)
            {
                greska += "Kapacitet prtljaznog prostora mora biti manji od 20.\n";
            }

            return greska;
        }

        public static string ProveriKabrioletAutomobil(int brojSedista, string marka, string boja)
        {
            string greska = ProveriVozilo(marka, boja);
            greska += ProveriAutomobil(brojSedista);

            return greska;
        }

        public static string ProveriKlasicanAutomobil(int nosivostKrova, int brojSedista, string marka, string boja)
        {
            string greska = ProveriVozilo(marka, boja);
            greska += ProveriAutomobil(brojSedista);

            if(nosivostKrova < 10 || nosivostKrova > 50)
            {
                greska += "Nosivost krova mora biti izmedju 10 kg i 50 kg.\n";
            }

            return greska;
        }

        public static string ProveriCisternaKamion(double kapacitetTanka, int brojOsovina, string marka, string boja)
        {
            string greska = ProveriVozilo(marka, boja);
            greska += ProveriKamion(brojOsovina);
            
            if(kapacitetTanka > 100.0)
            {
                greska += "Kapacitet tanka mora biti manji od 100.\n";
            }

            return greska;
        }

        public static string ProveriSleperKamion(int vucnaSnaga, int brojOsovina, string marka, string boja)
        {
            string greska = ProveriVozilo(marka, boja);
            greska += ProveriKamion(brojOsovina);
            
            if(vucnaSnaga < 5 || vucnaSnaga > 20)
            {
                greska += "Vucna snaga mora biti izmedju 5 i 20.\n";
            }

            return greska;
        }
    }
}
