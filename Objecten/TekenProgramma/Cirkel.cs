using System;
using System.Collections.Generic;
using System.Text;

namespace TekenProgramma
{
    class Cirkel: Figuur
    {
        public int Straal { get; set; }

        public override void Teken()
        {
            Console.WriteLine($"Cirkel ({X}, {Y}) met straal {Straal}");
        }
    }
}
