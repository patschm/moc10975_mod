using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Transporteren
{
    class TransportOpdracht
    {
        public List<Locatie> Locaties { get; set; } = new List<Locatie>();

        public double Afstand
        {
            get
            {
                Locatie first = Locaties.First();
                Locatie last = Locaties.Last();
                double dx = Math.Pow(last.X - first.X, 2);
                double dy = Math.Pow(last.Y - first.Y, 2);
                return Math.Sqrt(dx + dy);
            }
        }
        public float Lading { get; set; }
    }
}
