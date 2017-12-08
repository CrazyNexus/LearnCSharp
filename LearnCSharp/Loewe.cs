using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    class Loewe : Saeuger
    {

        // Konstruktor
        public Loewe(int _alter, string _geschlecht)
        {
            Alter = _alter;
            Geschlecht = _geschlecht;
        }

        public override void Essen()
        {
            Console.WriteLine("Der Löwe isst...");
        }

        public override void FutterBesorgen()
        {
            Console.WriteLine("Der Löwe fängt sich ein Känguru ...");
        }

        public override void Trinken()
        {
            Console.WriteLine("Der Löwe trinkt ...");
        }
    }

    abstract public class Saeuger : ITier
    {
        public int Alter { get; set; }
        public string Geschlecht { get; set; }

        public virtual void Essen()
        {
            Console.WriteLine("Das Saeugetier isst ...");
        }

        public virtual void Trinken()
        {
            Console.WriteLine("Das Saeugetier trinkt ...");
        }

        public virtual void Wachsen()
        {
            Console.WriteLine("Das Saeugetier waechst ...");
        }

        public abstract void FutterBesorgen();
    }
}
