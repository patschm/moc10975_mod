using System;
using System.Collections.Generic;
using System.Text;

namespace Transporteren
{
    abstract class Voertuig
    {
        public string Kenteken { get; set; }
        public bool HeeftMotor { get; set; }
        public float LaadMeters { get; set; } = 0;

        public abstract float BerekenKosten(double aantalKilometers);
        public virtual void ShowInfo()
        {
            Console.Write($"{Kenteken} ");
        }
    }
}
