using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktinis2
{
    class Mark
    {
        public string Vardas { get; set; }
        

        public string Dalykas { get; set; }
        public string Grupe { get; set; }
    
        public string Pažymis { get; set; }

        public Mark(string vardas, string dalykas, string grupe, string pažymis)
        {
            Vardas = vardas;
            Dalykas = dalykas;
            Grupe = grupe;
            Pažymis = pažymis;
        }
    }
}
