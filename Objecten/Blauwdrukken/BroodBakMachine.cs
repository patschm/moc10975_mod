using System;
using System.Collections.Generic;
using System.Text;

namespace Blauwdrukken
{
    // Blauwdruk van de broodbakmachine
    class BroodBakMachine
    {
        // Field. Hierin sla je eigenschappen op
        private int _bakTijd = 120;

        // Property. Hiermee controleer ik de waardes die aan een field mogen worden toegekend
        public int BakTijd
        {
            get
            {
                return _bakTijd;
            }
            set
            {
                if (value >= 0 && value < 250)
                {
                    _bakTijd = value;
                }
            }
        }
        // Auto-generating property. Genereert zijn eigen private field
        public int BakTemperatuur { get; set; }

        // Gedrag. Leg je vast in functies of procedures (Method)
        public void Bak()
        {
            Console.WriteLine($"Check temperatuur ({BakTemperatuur} gr C)");
            if (BakTemperatuur >= 160)
            {
                Console.WriteLine($"We bakken nu {BakTijd} minuten");
            }
        }

        // Constructor
        // Gebruik je om _fields_ van een initiele waarde te voorzien
        public BroodBakMachine(int tijd)
        {
            BakTijd = tijd;
        }
        public BroodBakMachine()
        {

        }
    }


}
