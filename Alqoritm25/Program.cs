using System;
using System.Linq;

namespace Alqoritm25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ededler = new int[4];
            for (int i = 0; i < ededler.Length; i++)
            {
                ededler[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("___________________________________________________");
            for (int i = ededler.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(ededler[i]);

            }

            Console.WriteLine("___________________________________________________");
            for (int i = 0; i < ededler.Length; i++)
            {
                int a = ededler.Max();
                Console.WriteLine(a);

            }
            Console.ReadLine();
        }
    }
}
