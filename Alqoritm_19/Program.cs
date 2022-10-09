using System;

namespace Alqoritm_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Avtomobil daxil edin --->");
           string avtomobil = Console.ReadLine();
            Console.WriteLine("________________________________________________");
            Console.WriteLine("Qalma müddətini daxil edin --->");
            int zaman = int.Parse(Console.ReadLine());
            Console.WriteLine("________________________________________________");
        
            double umumimebleg = 0;

            if(zaman <= 1)
            {
                if (avtomobil == "Taksi")
                {
                    umumimebleg = zaman*0.5;
                }
                if (avtomobil == "Mikroavtobus")
                {
                    umumimebleg = zaman * 0.6;
                }
                if (avtomobil == "Yuk")
                {
                    umumimebleg = zaman * 1;
                }
            }
            else
            {
                for (int i = 1; i < zaman; i++)
                {
                    if (avtomobil == "Taksi")
                    {
                        umumimebleg += zaman * 0.5*1.2;
                    }
                    if (avtomobil == "Mikroavtobus")
                    {
                        umumimebleg += zaman * 0.6*1.215;
                    }
                    if (avtomobil == "Yuk avtomobili")
                    {
                        umumimebleg += zaman * 1*25;
                    }
                }
            }

            Console.WriteLine("Cavab-->" + " "+umumimebleg+"AZN");
            Console.ReadLine();
            

        }
    }
}
