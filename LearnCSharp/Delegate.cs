//
// Delegate.cs
//
// Created by Thomas Dubiel on 12/15/2017
// Copyright 2017 Thomas Dubiel (td@crazynexus.de). All rights reserved.
//
using System;
namespace LearnCSharp
{
    public class Delegate
    {

        delegate int Berechne(int x, int y);
        delegate void Ausgabe();

        public Delegate()
        {
        }

        public void Berechnung()
        {
            Berechne aufrufer = new Berechne(Addition);
            Console.WriteLine("Das Ergebnis ist " + aufrufer(5, 2));

            aufrufer = new Berechne(Subtraktion);
            Console.WriteLine("Das Ergebnis ist " + aufrufer(5, 2));
        }

        public void Multicast()
        {
            // das geht auch - Anlegen einer neuen Variablen mit einer delegate Methode
            Ausgabe aufrufer = Begruessung;
            // Anlegen eines Multicast Delegaten
            aufrufer += Smalltalk;
            aufrufer += Verabschiedung;

            // alle Methoden ausführen
            aufrufer();
        }

        static int Addition(int x, int y)
        {
            return x + y;
        }

        static int Subtraktion(int x, int y)
        {
            return x - y;
        }

        static void Begruessung()
        {
            Console.WriteLine("Hallo!");
        }

        static void Smalltalk()
        {
            Console.WriteLine("Heute ist das Wetter schön");
        }

        static void Verabschiedung()
        {
            Console.WriteLine("Und Tschüß!");
        }
    }
}
