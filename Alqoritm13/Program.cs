using System;

namespace Alqoritm13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sozu daxil edin = "); string a = Console.ReadLine();
            Console.WriteLine("Nece defe nusxe olacaqsa daxil edin"); int n = int.Parse(Console.ReadLine());
            string result = " ";
            for (int i = 0; i < n; i++)
            {
                result += a;
                                 Console.WriteLine(result);
            }
           
        }
    }
}
