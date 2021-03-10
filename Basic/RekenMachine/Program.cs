using System;

namespace RekenMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();

                int a = VraagGetal("Geef getal A");
                int b = VraagGetal("Geef getal B");
                string oper = VraagOperatie();

                ToonBerekening(a, b, oper);            
            }
            while (NogEenKeer());
        }

        static bool NogEenKeer()
        {
            Console.WriteLine("Nog een berekening? (y or n)");
            ConsoleKeyInfo key = Console.ReadKey();
            return key.KeyChar == 'y' || key.KeyChar == 'Y';
        }
        static int VraagGetal(string label)
        {
            do
            {
                Console.WriteLine(label);
                string strB = Console.ReadLine();
                int.TryParse(strB, out int b);
                return b;
            }
            while (true);
        }
        static string VraagOperatie()
        {
            do
            {
                Console.WriteLine("Welke berekening? (+, - of *)");
                string berekening = Console.ReadLine();
                if (berekening == "+" || berekening == "-" || berekening == "*")
                {
                    return berekening;
                }
                Console.WriteLine("Ongeldige Operatie");
            }
            while (true);
        }
        static void ToonBerekening(int a, int b, string op)
        {
            switch (op)
            {
                case "+":
                    Console.WriteLine($"{a} + {b} = {a + b}");
                    break;
                case "-":
                    Console.WriteLine($"{a} - {b} = {a - b}");
                    break;
                case "*":
                    Console.WriteLine($"{a} x {b} = {a * b}");
                    break;
                default:
                    Console.WriteLine("Ongeldige operatie");
                    break;
            }
        }

    }
}
