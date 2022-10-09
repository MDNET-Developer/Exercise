using System;

namespace Alqoritm8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sozu daxil edin = "); string str = Console.ReadLine();
            string teqdimolunan = str.Substring(1,2);
            if (teqdimolunan == "yt" || teqdimolunan == "YT")
            {
                string cavab = str.Remove(1, 2);
                Console.Write("Cavab = ");
                Console.WriteLine(cavab + "✓");
            }
            else
            {
                Console.Write("Cavab = ");
                Console.WriteLine(str + "✓");
            }

        }
    }
}
