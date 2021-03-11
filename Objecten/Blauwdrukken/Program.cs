using System;

namespace Blauwdrukken
{
    class Program
    {
        static void Main(string[] args)
        {
            BroodBakMachine bbm1 = new BroodBakMachine(-123);
            BroodBakMachine bbm2 = new BroodBakMachine { BakTijd = 90, BakTemperatuur=200 };

            bbm1.BakTemperatuur = 170;
            bbm1.BakTijd = 170;
            bbm1.Bak();
            
        }
    }
}
