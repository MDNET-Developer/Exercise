using System;

namespace Alqoritm29
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
            Console.WriteLine("_____________________________");
            Console.WriteLine(ededler[ededler.Length-1]);
            for (int i = 1; i < ededler.Length - 1; i++)
            {
                Console.WriteLine(ededler[i]);
            }
            Console.WriteLine(ededler[0]);
        }
    }
}