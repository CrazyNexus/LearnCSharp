using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    class Loewe : ITier
    {
        public int Alter { get; set; }
        public string Geschlecht { get; set; }

        // Konstruktor
        public Loewe(int _alter, string _geschlecht)
        {
            Alter = _alter;
            Geschlecht = _geschlecht;
        }

        public void Essen()
        {
            Console.WriteLine("Der Löwe isst...");
        }

        public void Trinken()
        {
            Console.WriteLine("Der Löwe trinkt ...");
        }
    }
}
