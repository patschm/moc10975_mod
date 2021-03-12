using System;
using System.Collections.Generic;
using System.Linq;

namespace Transporteren
{
    class Program
    {
        static List<Locatie> locaties = new List<Locatie>();
        static List<Voertuig> vehicles = new List<Voertuig>();

        static void Main(string[] args)
        {
            PopulateLocations();
            PopulateVehicles();
            TransportOpdracht to = new TransportOpdracht();
            to.Locaties.Add(locaties.First());
            to.Locaties.Add(locaties.Last());
            to.Lading = 200;

            Console.WriteLine(to.Afstand);

            TruckConfiguration tconf = new TruckConfiguration();
            List<Voertuig> cheapest = tconf.CreateConfiguration(to);

            Console.WriteLine("De goedkoopste combo is:");
            foreach(Voertuig v in cheapest)
            {
                Console.Write($"[{v.BerekenKosten(to.Afstand)}] ");
                v.ShowInfo();
            }             
        }

        private static void PopulateVehicles()
        {
            Random rnd = new Random();
            for(int i = 0; i < 20; i++)
            {
                vehicles.Add(new Trekker { HeeftMotor = true, Kenteken = $"TR-{i}", OperationeleKosten=rnd.Next(1, 3) });
            }
            for(int i = 0; i < 100; i++)
            {
                vehicles.Add(new Oplegger { 
                    HeeftMotor=false, 
                    Kenteken=$"OPL-{i}", 
                    LaadMeters=rnd.Next(80, 136)/10, 
                    LaadPrijs=rnd.Next(20, 40) });
            }
        }

        private static void PopulateLocations()
        {
            Locatie l1 = new Locatie { Name = "Zwolle", X = 0, Y = 0 };
            locaties.Add(l1);
            locaties.Add(new Locatie { Name = "Rotterdam", X = -150, Y = -150 });
            locaties.Add(new Locatie { Name = "Groningen", X = 100, Y = 100 });
            locaties.Add(new Locatie { Name = "Maastricht", X = 20, Y = -200 });
        }
    }
}
