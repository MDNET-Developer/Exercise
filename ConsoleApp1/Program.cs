using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ədədi daxil edin = "); int n = int.Parse(Console.ReadLine());

            float s;
            float s1;

            s = n % 3;
            s1 = n % 7;

            if (s == 0 || s1==0)
            {
                Console.WriteLine("Tam ededdir");
            }
            else
            {
                Console.WriteLine("Kesr eded alinacaq");
            }
            Console.ReadLine();
        }
    }
}
