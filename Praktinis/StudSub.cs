using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktinis2
{
    class StudSub
    {
        public string Vardas { get; set; }
        public string Dalykas { get; set; }

        public StudSub(string vardas, string dalykas)
        {
            Vardas = vardas;
            Dalykas = dalykas;
        }
    }
}
