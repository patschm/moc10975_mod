using System;

namespace TekenProgramma
{
    class Program
    {
        static void Main(string[] args)
        {
            Canvas canvas = new Canvas();
            //Cirkel c1 = new Cirkel { X = 10, Y = 20, Straal = 200 };
            //Cirkel c2 = new Cirkel { X = 120, Y = 120, Straal = 100 };

            //Rechthoek r1 = new Rechthoek { X = 50, Y = 10, Breedte = 100, Hoogte = 200 };
            //Rechthoek r2 = new Rechthoek { X = 150, Y = 320, Breedte = 300, Hoogte = 100 };

            //Driehoek d1 = new Driehoek { X = 30, Y = 200, Basis = 200, Hoogte = 100, Hoek = 67 };
            //Driehoek d2 = new Driehoek { X = 330, Y = 400, Basis = 100, Hoogte = 50, Hoek = 45 };

            //canvas.Add(c1);
            //canvas.Add(c2);
            //canvas.Add(r1);
            //canvas.Add(r2);
            //canvas.Add(d1);
            //canvas.Add(d2);

            do
            {
                Figuur f = KeuzeMenu();
                canvas.Add(f);
                Console.WriteLine("================================");
                canvas.Refresh();
                Console.WriteLine("================================");

            }
            while (ExitOrContinue());
        }

        static bool ExitOrContinue()
        {
            Console.WriteLine("Esc om te stoppen. Willekeurige toets om nog een figuur toe te voegen");
            ConsoleKeyInfo ki = Console.ReadKey();
            return ki.Key != ConsoleKey.Escape;
        }
        static Figuur KeuzeMenu()
        {
            do
            {
                Console.WriteLine("Wat voor een figuur?");
                Console.WriteLine("\tRechthoek (R)");
                Console.WriteLine("\tCirkel (C)");
                Console.WriteLine("\tDriehoek (D)");
                string keuze = Console.ReadLine();
                switch (keuze.ToLower())
                {
                    case "r":
                        return CreateRechthoek();
                    case "c":
                        return CreateCirkel();
                    case "d":
                        return CreateDriehoek();
                    default:
                        Console.WriteLine($"Ongeldig figuur ({keuze})");
                        break;
                }
            }
            while (true);
        }
        static Driehoek CreateDriehoek()
        {
            Console.Clear();
            int x = VraagGetal("X");
            int y = VraagGetal("Y");
            int hoogte = VraagGetal("Geef hoogte");
            int basis = VraagGetal("Geef basis");
            int hoek = VraagGetal("Geef hoek");
            return new Driehoek { Basis = basis, Hoek = hoek, Hoogte = hoogte, X=x, Y=y };
        }
        static Cirkel CreateCirkel()
        {
            Console.Clear();
            int x = VraagGetal("X");
            int y = VraagGetal("Y");
            int straal = VraagGetal("Geef straal");
            return new Cirkel { Straal = straal, X=x, Y=y };
        }
        static Rechthoek CreateRechthoek()
        {
            Console.Clear();
            int x = VraagGetal("X");
            int y = VraagGetal("Y");
            int hoogte = VraagGetal("Geef hoogte");
            int breedte = VraagGetal("Geef breedte");

            return new Rechthoek { Hoogte = hoogte, Breedte = breedte, X=x, Y=y };
        }
        static int VraagGetal(string label)
        {
            do
            {
                Console.Write($"{label}: ");
                string val = Console.ReadLine();
                if (int.TryParse(val, out int nr))
                {
                    return nr;
                }
            }
            while (true);
        }
    }
}
