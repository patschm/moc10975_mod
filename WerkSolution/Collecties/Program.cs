using System;
using System.Collections.Generic;

namespace Collecties
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays();
            //Collections();
            Lookups();
        }

        private static void Lookups()
        {
            // Typenaam variabelenaam
            var name = "patrick";
            var lookup = new Dictionary<string, int>();
            lookup.Add("een", 1);
            lookup.Add("twee", 2);
            lookup.Add("drie", 3);

            int tmp = lookup["twee"];
            Console.WriteLine(tmp);
        }

        private static void Collections()
        {
            List<int> nrs = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            nrs.Add(8);

            foreach (int tmp2 in nrs)
            {
                //Console.WriteLine(tmp2);
            }

            Stack<double> stack = new Stack<double>();
            stack.Push(1.3);
            stack.Push(5.1);

            double tmp3 = stack.Pop();
            Console.WriteLine(tmp3);

            Queue<double> queue = new Queue<double>();
            queue.Enqueue(5.6);
            queue.Enqueue(7.9);
            queue.Enqueue(3.2);
            Console.WriteLine(queue.Count);

            double tmp = queue.Dequeue();
            Console.WriteLine(tmp);
            tmp = queue.Dequeue();
            Console.WriteLine(tmp);
            tmp = queue.Dequeue();
            Console.WriteLine(tmp);
            Console.WriteLine(queue.Count);
        }

        private static void Arrays()
        {
            // Typenaam variabelenaam
            int[] kluisjes = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //kluisjes[0] = 1;
            //kluisjes[1] = 2;

            for (int idx = 0; idx < kluisjes.Length; idx++)
            {
                int tmp = kluisjes[idx];
                //Console.WriteLine(tmp);
            }

            foreach(int tmp in kluisjes)
            {
                Console.WriteLine(tmp);
            }

        }
    }
}
