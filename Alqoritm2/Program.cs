using System;

namespace Alqoritm2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sozu daxil edin"); string str = Console.ReadLine();
           
           
            string cavab = 
        
                str.Substring(str.Length - 1)
                + str.Substring(1, str.Length - 2)
                + str.Substring(0, 1);
      

            Console.WriteLine(str);
            Console.WriteLine(cavab);
            Console.ReadLine();
        }
    }
}
