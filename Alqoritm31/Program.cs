using System;
using System.Linq;

namespace Alqoritm31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ededler = new int[7];
            for (int i = 0; i < ededler.Length; i++)
            {
                ededler[i] = int.Parse(Console.ReadLine());
            }
            int cavab = 0;
            cavab = ededler.Max() - ededler.Min();
            Console.WriteLine("_______________________________________________________________");
            Console.WriteLine("Cavab-->" + cavab);
        }
    }
}
