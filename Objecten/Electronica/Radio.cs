using System;
using System.Collections.Generic;
using System.Text;

namespace Electronica
{
    class Radio
    {
        private float _frequentie = 80;
        public float Frequentie
        {
            get
            {
                return _frequentie;
            }
            set
            {
                if (value >= 80 && value <= 110)
                {
                    _frequentie = value;
                }
            }
        }
        public int Volume { get; set; } = 10;

        public void WijzigVolume(int dvol)
        {
            Volume += dvol;
            Console.WriteLine($"Het volume is nu {Volume}db");
        }
        public void FrequentieUp()
        {
            Frequentie += .1F;
            Console.WriteLine($"De frequentie is nu {Frequentie}MHz");
        }
        public virtual void Aan()
        {
            Console.WriteLine($"De radio is getuned op {Frequentie}MHz en speelt op {Volume}db");
        }
    }
}
