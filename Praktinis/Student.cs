using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktinis2
{
    
    class Student
    {
        public string Vardas { get; set; }
        public string Pavarde { get; set; }

        public Student(string vardas, string pavarde)
        {
            Vardas = vardas;
            Pavarde = pavarde;
        }
    }
}


