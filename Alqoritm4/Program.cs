using System;

namespace Alqoritm4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sozu daxil edin = "); string str = Console.ReadLine();
            string sonuncuherf = str.Substring(str.Length - 1);
           
            string cavab = sonuncuherf + str + sonuncuherf;
            Console.Write("Cavab = ");
            Console.WriteLine(cavab + "✓");
        }
    }
}
