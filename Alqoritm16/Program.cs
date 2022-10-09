using System;

namespace Alqoritm16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sozu daxil edin = "); string a = Console.ReadLine();
            string cavab = " ";
            for (int i = 0; i < a.Length-1; i++)
            {
                float s = i % 2;
                if (s == 0)
                {
                    cavab += a[i] +"a";
                }
            }
            Console.WriteLine(cavab);
        }
    }
}
