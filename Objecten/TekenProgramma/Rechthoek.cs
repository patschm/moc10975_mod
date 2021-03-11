using System;
using System.Collections.Generic;
using System.Text;

namespace TekenProgramma
{
    class Rechthoek: Figuur
    {
        public int Breedte { get; set; }
        public int Hoogte { get; set; }

        public override void Teken()
        {
            Console.WriteLine($"Rechthoek ({X}, {Y}) met hoogte: {Hoogte} en breedte: {Breedte}");
        }
    }
}
