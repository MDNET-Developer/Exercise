using System;

namespace Alqoritm28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ededleri daxil edin----->");

           int[] ededler = new int[8];
            for (int i = 0; i < ededler.Length; i++)
            {
                ededler[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("_____________________________________________");
            Console.WriteLine("Cavab----->");
            Console.WriteLine(ededler[(ededler.Length / 2) - 1] +  " / "   +  ededler[ededler.Length / 2] );
        }
    }
}
