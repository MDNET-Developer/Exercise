using System;

namespace Alqoritm6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sozu daxil edin = "); string str = Console.ReadLine();

            if (str.Length >= 3)
            {
                string ilk3 = str.Substring(0,3);

                string cavab = ilk3 + str + ilk3;
                Console.WriteLine(cavab);
            }
            else
            {
                string cavab = str + str + str;
                Console.WriteLine(cavab);

            }
            
            Console.WriteLine("Successful ✓");
            Console.ReadLine();
        }
    }
}
