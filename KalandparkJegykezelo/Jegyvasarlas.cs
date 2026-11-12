using System;
using System.Collections.Generic;
using System.Text;

namespace KalandparkJegykezelo
{
    public class Jegyvasarlas
    {
        public string LatogatoNeve { get; set; }

        public int felnottJegy { get; set; }

        public int gyerekJegy { get; set; }

        public Jegyvasarlas(string sor)
        {
            string[] adatok = sor.Split(';');
            LatogatoNeve = adatok[0];
            felnottJegy = int.Parse(adatok[1]);
            gyerekJegy = int.Parse(adatok[2]);
        }
        public int FizetendoOsszeg()
        {
            return felnottJegy * 4000 + gyerekJegy * 2500;
        }


    }
}
