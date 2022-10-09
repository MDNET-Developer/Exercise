using System;

namespace Alqoritm1
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Console.Write("Proqrami ise salmaq ucun sifreni daxil edin = ");
            string password = Console.ReadLine();
            if (password == "Salam123")
            {
                Console.Write("Sozu daxil edin=");
                Console.Write("Sozu daxil edin="); string s = Console.ReadLine(); ;
                Console.Write("Necenci hisseni silmek isteyirsiz ="); int n = int.Parse(Console.ReadLine());
                Console.ReadLine();
                string yenideyer = s.Remove(n, 2);
               
                Console.WriteLine(s);
                Console.WriteLine(yenideyer);
            }
            else
            {
                Console.Write("Daxil ola bilmediz");
            }
        }
    }
}
