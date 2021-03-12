using System;

namespace Electronica
{
    class Program
    {
        static void Main(string[] args)
        {
            BuizenRadio r5 = new BuizenRadio();

            // Oerknal
            // Generaliseren. r2 is een gegeneraliseerd object
            Radio r2 = new DABRadio { Encoder = "MP4" };
            //((DABRadio)r2).Encoder = "WMV";
            r2.Aan();
            r2.FrequentieUp();
            r2.WijzigVolume(55);
            


            Radio r1 = new Radio();
            r1.Aan();

            r1.FrequentieUp();
            r1.WijzigVolume(10);

            // Big Crunch
        }
    }
}
