using System;
using System.Collections.Generic;
using System.Text;

namespace Transporteren
{
    class Combinatie : Voertuig
    {
        private List<Voertuig> voertuigen = new List<Voertuig>();

        public void Combine(Voertuig vt)
        {
            voertuigen.Add(vt);
        }
        public override float BerekenKosten(double aantalKilometers)
        {
            float prijs = 0;
            foreach(Voertuig vt in voertuigen)
            {
                prijs += vt.BerekenKosten(aantalKilometers);
            }
            return prijs;
        }
        public override void ShowInfo()
        {
            foreach(Voertuig vt in voertuigen)
            {
                vt.ShowInfo();
            }
            Console.WriteLine();
        }
        
    }
}
