using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    class HausHund : ITier
    {
        public int Alter { get; set; }
        public string Geschlecht { get; set; }

        // Konstruktor
        public HausHund(int _alter, string _geschlecht)
        {
            Alter = _alter;
            Geschlecht = _geschlecht;
        }

        public void Essen()
        {
            Console.WriteLine("Der Hund isst ...");
        }

        public void Trinken()
        {
            Console.WriteLine("Der Hund trinkt ...");
        }

        public void Bellen ()
        {
            Console.WriteLine("Der Hund bellt ...");
        }
    }
}
