using System;

namespace Alqoritm7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sozu daxil edin = "); string str = Console.ReadLine();
            string ilk2 = str.Substring(0, 2);
            if (ilk2 == "C#" || ilk2=="c#")
            {
       
                Console.WriteLine("Bu soz C# ile baslayib ✓");
            }
            else
            {

                Console.WriteLine("Bu soz C# ile baslamayib X");

            }

            Console.WriteLine("Successful ✓");
            Console.ReadLine();
        }
    }
}
