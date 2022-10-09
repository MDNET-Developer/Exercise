using System;

namespace Alqoritma34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[8];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine("___________________________");
            for (int i = 1; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.WriteLine(a[0]);
            Console.WriteLine("Hello World!");
        }
    }
}
