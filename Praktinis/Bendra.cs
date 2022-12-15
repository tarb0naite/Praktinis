using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktinis2
{
    class Bendra
    {
        public string Vardas { get; set; }
       public string Dalykas { get; set; }
        public string Grupe { get; set; }

        public Bendra(string vardas, string dalykas, string grupe)
        {
            Vardas = vardas;
            Dalykas = dalykas;
            Grupe = grupe;
        }
    }
}
