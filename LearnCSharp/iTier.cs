using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    interface ITier
    {
        // Eigenschaften
        int Alter { set; get; }
        string Geschlecht { set; get; }

        // Methoden
        void Essen();
        void Trinken();
    }
}
