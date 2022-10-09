using System;

namespace Alqoritma32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("_______17-den xaric bütün ededlerin toplanması_________");
            Console.WriteLine("_________Ededleri daxil et_________");
            int[] toplamamassivi = new int[5];
            for (int i = 0; i < toplamamassivi.Length; i++)
            {
                toplamamassivi[i] = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine("______________________________________________");
            int cem = 0;
            for (int i = 0; i < toplamamassivi.Length; i++)
            {
                if (toplamamassivi[i] == 17)
                {
                    cem += toplamamassivi[i] - 17;
                }
                else
                {
                    cem += toplamamassivi[i];
                }
            }
            Console.WriteLine("Cavab---->" + cem);

            
        }
    }
}
