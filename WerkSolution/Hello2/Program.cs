using System;

namespace Hello2
{
    class Program
    {
        static void Main()
        {
            // DataType naam_van_het_potje
            long nummer = -30;
            double f = 3.14;
            decimal d = 34.4567M;

            char c = 'A';
            string str = "I \t am";
            bool isOk = true;
            int age = 42;
            int result = age * 6;
            bool isWaar = age != 30;

            bool ba = true;
            bool bb = false;

            bool br = ba && bb;

            int a = 1; // 0001
            int b = 3; // 0011
            int brr = a ^ b;  // 0010

            Console.WriteLine(br);
           


            string invoer = Console.ReadLine();
            try
            {
                int nr = int.Parse(invoer);
                Console.WriteLine("U zei " + nr);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
