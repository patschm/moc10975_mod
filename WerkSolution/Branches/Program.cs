using System;

namespace Branches
{
    class Program
    {
        static void Main(string[] args)
        {
            int leeftijd = VraagOmLeeftijd();
            ShowTVProgram(leeftijd);

            leeftijd = VraagOmLeeftijd();
            ShowTVProgram(leeftijd);
        }

        // Function
        static int VraagOmLeeftijd()
        {
            do
            {
                Console.WriteLine("Uw leeftijd?");
                string sAge = Console.ReadLine();
                bool isOk = int.TryParse(sAge, out int age);
                if (isOk)
                {
                    return age;
                }
            }
            while (true);

        }

        // Procedure (return type is void)
        static void ShowTVProgram(int age)
        {
            if (age >= 18 && age <= 67)
            {
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
        }
    }
}
