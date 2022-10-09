using System;

namespace Alqoritm22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ededler = new int[2];
            Console.WriteLine("Ededi daxil edi --> ");
            for (int i = 0; i < ededler.Length; i++)
            {
                ededler[i] = int.Parse(Console.ReadLine());
             

            }
            Console.WriteLine("_________________________");
            Console.WriteLine("10% artmis variantlari ---->");

            for (int i = 0; i < ededler.Length; i++)
            {
                Console.WriteLine(ededler[i] *1.1);
            }
                Console.WriteLine("_________________________");
        }
    }
}
