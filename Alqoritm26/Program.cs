using System;

namespace Alqoritm26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ededler = new int[2];
            for (int i = 0; i < ededler.Length; i++)
            {
                ededler[i] = int.Parse(Console.ReadLine());
               
            }
           
                if ((ededler[0] == 10 && ededler[1] == 10)||(ededler[0] == 20 && ededler[1] == 20))
                {
                    Console.WriteLine(true);
                }
                else
                {

                    Console.WriteLine(false);
                }
 

            }
    }
}
