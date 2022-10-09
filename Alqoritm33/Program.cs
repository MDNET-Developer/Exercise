using System;
using System.Runtime.ConstrainedExecution;

namespace Alqoritm33
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("_______Ardicil 5,5 gedisatinin yoxlanilmasi_________");
            Console.WriteLine("_________Ededleri daxil et_________");
            int[] toplamamassivi = new int[5];
            for (int i = 0; i < toplamamassivi.Length; i++)
            {
                toplamamassivi[i] = Convert.ToInt16(Console.ReadLine());
            }
            string cavab = " ";
            for (int i = 0; i < toplamamassivi.Length - 1; i++)
            {
                if (toplamamassivi[i] == 5 && toplamamassivi[i + 1] == 5)
                    Console.WriteLine(true);
               
            }
            Console.ReadLine();
            Console.WriteLine("______________________________________________");
        }
    }
}
