using System;

namespace Alqoritm27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ededler = new int[5];
            for (int i = 0; i < ededler.Length; i++)
            {
                ededler[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Hello World!________________________");
            int[] yenimassiv = new int[ededler.Length*2];
            yenimassiv[0]=ededler[0];
            Console.WriteLine(yenimassiv[0]);
            for (int i = 1; i < yenimassiv.Length; i++)
            {
                Console.WriteLine(yenimassiv[i]);
            }
               
        }
    }
}
