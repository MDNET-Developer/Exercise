using System;

namespace Alqoritm10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("--- Find maximum number between 20 and 30 --- \n");
            Console.Write("  \n");
            Console.Write("Number 1 = "); int x = int.Parse(Console.ReadLine());
            Console.Write("Number 2 = "); int y = int.Parse(Console.ReadLine());

            if((20<x && x<30) && (20 < y && y < 30))
            {
                int z = Math.Max(x, y);
                Console.WriteLine("Result = " + z);
            }
            else
            {
                Console.WriteLine("Result = " + 0);
            }
            
        }
    }
}
