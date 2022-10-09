using System;

namespace Alqoritm11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Number 1 = "); string x = Console.ReadLine();
            //Console.Write("Number 2 = "); string y = Console.ReadLine();
            //string netice1 = x.Substring(x.Length - 1);
            //string netice2 = y.Substring(y.Length - 1);
            //if (netice1 == netice2)
            //{
            //    Console.WriteLine(true);
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //}
            //Console.WriteLine("Hello World!");
            Console.Write("Son reqemleri eyni olan proqram \n");

            Console.Write("Number 1 = "); int x = int.Parse(Console.ReadLine());
            Console.Write("Number 2 = "); int y = int.Parse(Console.ReadLine());
            if(x<0 || y < 0)
            {
                Console.WriteLine(" \n Menfi eded oldugu ucun emeliyyat yerine yetirile bilmir");
            }
            else
            {
                float netice1 = x % 10;
                float netice2 = y % 10;
                if (netice2 == netice1)
                {
                    Console.WriteLine("Netice 1 = " + netice1 + "\n Netice 2 =" + netice2 + " \n Serti odeyir");
                }
                else
                {
                    Console.WriteLine("Netice 1 = " + netice1 + "\n Netice 2 =" + netice2 + " \nodemir X");
                }
            }
            

        }
    }
}
