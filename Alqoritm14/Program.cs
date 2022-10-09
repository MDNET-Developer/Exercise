using System;

namespace Alqoritm14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sozu daxil edin = "); string x = Console.ReadLine();
            int saygac = 0;
            for(int i = 0; i < x.Length; i++)
            {
                if (x[i] == 'z' || x[i]=='Z')
                {
                    saygac++;
                }
               
            }
           if(saygac >= 2   && saygac < 4)
            {
                Console.WriteLine(saygac + " " + "True");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(saygac + " " + "False");
                Console.ReadLine();
            }
           
        }
    }
}
