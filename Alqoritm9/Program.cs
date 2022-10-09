using System;

namespace Alqoritm9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("--- Find maximum number --- \n");
            Console.Write("  \n");
            Console.Write("Number 1 = "); int x = int.Parse(Console.ReadLine());
            Console.Write("Number 2 = "); int y = int.Parse(Console.ReadLine());
            Console.Write("Number 3 = "); int z = int.Parse(Console.ReadLine());
            if (x > y)
            {
                if (z > x)
                {
                    
                    Console.WriteLine("Cavab = " + z);
                }
                else
                {
                    Console.WriteLine("Cavab = " + x);
                }
            }


            else
            {
                if (z > y)
                {
                    Console.WriteLine("Cavab = " + z);
                }
                else
                {
                    Console.WriteLine("Cavab = " + y);
                }
            }
            Console.WriteLine("Successful ✓");
        }
    }
}
