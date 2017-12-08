//
// Arbeiter.cs
//
// Created by Thomas Dubiel on 01.12.2017
// Copyright 2017 Thomas Dubiel. All rights reserved.
using System;
namespace LearnCSharp
{
    abstract public class Arbeiter
    {
        // Eigenschaften
        public string Name { get; set; }
        public double Gehalt { get; set; }

        // Methoden
        public abstract void ArbeitVerrichten();

    }

    public class Elektriker : Arbeiter
    {
        public override void ArbeitVerrichten()
        {
            Console.WriteLine("Der Elektriker arbeitet ...");
        }
    }
}
