using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ITier[] tiere = new ITier[3];

            tiere[0] = new Loewe(10, "Weibchen");
            tiere[1] = new HausHund(4, "Männchen");
            tiere[2] = new HausHund(8, "Weibchen");

            foreach(ITier tier in tiere)
            {
                if (tier is Loewe)
                {
                    Console.WriteLine("Der Löwe ist " + tier.Alter + " und ein " + tier.Geschlecht);
                }
                else if (tier is HausHund)
                {
                    Console.WriteLine("Der Hund ist " + tier.Alter + " und ein " + tier.Geschlecht);
                    var hund = tier as HausHund;
                    hund.Bellen();
                }
                
                tier.Essen();
                tier.Trinken();
            }

            Console.ReadLine();
        }
    }
}
