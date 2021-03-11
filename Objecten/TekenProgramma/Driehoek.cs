using System;
using System.Collections.Generic;
using System.Text;

namespace TekenProgramma
{
    class Driehoek: Figuur
    {
        public int Basis { get; set; }
        public int Hoogte { get; set; }
        public int Hoek { get; set; }

        public override void Teken()
        {
            Console.WriteLine($"Driehoek ({X}, {Y}) met hoogte: {Hoogte}, basis: {Basis} en hoek: {Hoek}");
        }
    }
}
