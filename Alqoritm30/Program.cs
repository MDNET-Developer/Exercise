using System;

namespace Alqoritm30
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
            Console.WriteLine("________________CAVAB________________________");
            for (int i = 0; i < ededler.Length; i++)
            {
                if (ededler[i] % 2 == 0)
                {
                    Console.WriteLine(ededler[i]);
                }
        
            }
        }
    }
}
