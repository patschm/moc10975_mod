using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Transporteren
{
    class TruckConfiguration
    {
        private List<Voertuig> wagenpark = new List<Voertuig>();
        private int maxNrVoertuigen = 3;
        private bool mustHaveEngine = true;

        public List<Voertuig> CreateConfiguration(TransportOpdracht rt)
        {
            
            List<Voertuig> combos = new List<Voertuig>();

            foreach (Voertuig trekker in wagenpark.Where(v => v.HeeftMotor))
            {
                    Combinatie combo = new Combinatie();
                    combo.Combine(trekker);
                    Combinatie beste;
                    foreach(Voertuig oplegger in wagenpark.Where(v=>v.LaadMeters > 0).OrderByDescending(v=>v.LaadMeters))
                    {
                        combo.Combine(oplegger);
                        float prijs = combo.BerekenKosten(rt.Afstand);
                        
                    }

            }

            return combos;
        }
    }
}
