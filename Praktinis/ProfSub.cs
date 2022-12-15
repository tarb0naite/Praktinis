using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktinis2
{
    class ProfSub
    {
        public string Vardas { get; set; }
        public string Dalykas { get; set; }
        public string Pavarde { get; set; }

        public ProfSub(string vardas, string dalykas, string pavarde)
        {
            Vardas = vardas;
            Dalykas = dalykas;
            Pavarde = pavarde;
        }
    }
}
