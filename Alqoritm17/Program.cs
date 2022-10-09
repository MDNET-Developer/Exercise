using System;

namespace Alqoritm17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sozu daxil edin = "); string a = Console.ReadLine();
            string cavab = " ";
            string silinen = a.Remove(0, 1);
            for (int i = 0; i < a.Length - 1; i++)
            {
               
                    cavab += a[i] + "a" ;
              
            }
            Console.WriteLine(cavab + silinen);
        }
    }
}
