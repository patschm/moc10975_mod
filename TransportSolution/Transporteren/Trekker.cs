using System;
using System.Collections.Generic;
using System.Text;

namespace Transporteren
{
    class Trekker : Voertuig
    {
        public float OperationeleKosten { get; set; }

        public override float BerekenKosten(double aantalKilometers)
        {
            return (float)aantalKilometers * OperationeleKosten;
        }
    }
}
