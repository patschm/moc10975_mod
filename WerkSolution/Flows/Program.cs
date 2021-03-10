using System;

namespace Flows
{
    class Program
    {
        static void Main(string[] args)
        {                
            int age = 0;
            bool isOk = true;
            //for (int x = 0; x < 5; x++)
            //while (!isOk)
            do
            {
                Console.WriteLine("Uw leeftijd?");
                string sAge = Console.ReadLine();
                isOk = int.TryParse(sAge, out age);
                //if (isOk) break;
            }
            while (!isOk) ;

            int nr = 23;
            //bool ba = age >= 18;
            //bool bb = age <= 67;
            // Range checks
            if (age >= 18 && age <= 67)
            {
                nr = 45;
                Console.WriteLine("Jij mag deze film bekijken");
            }
            else if (age >= 10)
            {
                
                Console.WriteLine("Scoobie Doo");
            }
            else
            {
                Console.WriteLine("Teletubbies voor jou");
            }

            // Testen op concrete waardes
            switch(age)
            {
                case 10:
                    Console.WriteLine("De leeftijd is tien");
                    break;
                case 20:
                    Console.WriteLine("De leeftijd is twintig");
                    break;
                default:
                    Console.WriteLine("Alle andere leeftijden");
                    break;
            }

            Console.WriteLine("Hier gaan we verder " + nr);

           

        }
    }
}
