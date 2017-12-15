using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    enum Wochentag
    {
        Montag,
        Dienstag,
        Mittwoch,
        Donnerstag,
        Freitag,
        Samstag,
        Sonntag
    }

    enum Himmelsrichtung
    {
        Nord = 10,
        Süd,
        West,
        Ost
    }

    class Program
    {
        static void Main(string[] args)
        {
            ITier[] tiere = new ITier[3];

            tiere[0] = new Loewe(10, "Weibchen");
            tiere[1] = new HausHund(4, "Männchen");
            tiere[2] = new HausHund(8, "Weibchen");

            foreach (ITier tier in tiere)
            {
                if (tier is Loewe)
                {
                    Console.WriteLine("Der Löwe ist " + tier.Alter + " und ein " + tier.Geschlecht);
                    var loewe = tier as Loewe;
                    loewe.FutterBesorgen();
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

            // verwendung von abstrakten Klassen
            var elektriker = new Elektriker();
            elektriker.ArbeitVerrichten();

            // Verwendung von Strukturen
            Buch buch1 = new Buch("C# für Beginner", "Thomas Dubiel", 42);
            Console.WriteLine(buch1.titel);
            Console.WriteLine(buch1.autor);
            Console.WriteLine(buch1.seitenAnzahl);

            Buch buch2;
            buch2.titel = "Java für Anfänger";
            buch2.autor = "Jens Jensen";
            buch2.seitenAnzahl = 88;
            Console.WriteLine(buch2.titel);
            Console.WriteLine(buch2.autor);
            Console.WriteLine(buch2.seitenAnzahl);

            Wochentag tag = Wochentag.Montag;
            Console.WriteLine("Es ist " + tag);

            Himmelsrichtung richtung = Himmelsrichtung.West;
            Console.WriteLine("Es geht nach " + richtung + " mit Wert " + (int)richtung);

            // Verwendung von Delegaten
            Delegate myDelegate = new Delegate();
            myDelegate.Berechnung();
            myDelegate.Multicast();

            Console.ReadLine();
        }
    }

    struct Buch
    {
        // Variablen
        public string titel;
        public string autor;
        public int seitenAnzahl;

        // Konstruktor
        public Buch(string _titel, string _autor, int _seiten)
        {
            titel = _titel;
            autor = _autor;
            seitenAnzahl = _seiten;
        }
    }
}
