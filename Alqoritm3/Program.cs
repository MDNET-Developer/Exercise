using System;

namespace Alqoritm3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sozu daxil edin = "); string str = Console.ReadLine();
         
            for (int i = 1; i <= 4; i++)
            {
                string cavab = str.Substring(0, 2);
                Console.WriteLine(i + " → " + cavab+"✓");
       
            }
            Console.WriteLine("Successful ✓");
            Console.ReadLine();
        }
    }
}
