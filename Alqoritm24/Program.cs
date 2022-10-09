using System;

namespace Alqoritm24
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
            int cem = 0;
            for (int i = 0; i < ededler.Length; i++)
            {
                cem += ededler[i];
            }
                Console.WriteLine("Cavab-->" +cem);
        }
    }
}
