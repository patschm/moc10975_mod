using System;
using System.Collections.Generic;
using System.Text;

namespace Transporteren
{
    class Oplegger: Voertuig
    {
       
        public float LaadPrijs { get; set; }

        public override float BerekenKosten(double aantalKilometers)
        {
            return LaadMeters * LaadPrijs;
        }
    }
}
