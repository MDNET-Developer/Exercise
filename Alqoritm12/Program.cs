using System;

namespace Alqoritm12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sozu daxil edin = "); string a = Console.ReadLine();
            if (a.Length > 3)
            {
                string son3 = a.Substring(a.Length - 3).ToUpper();
                string evvelki = a.Remove(a.Length - 3, 3);
                Console.WriteLine("Cavab = " + evvelki + son3);
            }
            else
            {
                Console.WriteLine("Cavab = " + a.ToUpper());
            }
    
        }
    }
}
