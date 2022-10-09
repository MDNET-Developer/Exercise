using System;
using System.Linq;

namespace Alqoritm20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cavab;
            int ortalamadanboyuk = 0;
            int ortalamadankicik = 0;
            Console.WriteLine("Daxil edin---->");
            int[] answer = new int[10];
            for (int i = 0; i < answer.Length; i++)
            {
                answer[i] = int.Parse(Console.ReadLine());
            }
            int toplam = 0;
            for (int i = 0; i < answer.Length; i++)
            {
                toplam += answer[i];
            }
            int ortalama = toplam / answer.Count();
            for (int i = 0; i < answer.Length; i++)
            {
                if (answer[i] > ortalama)
                {
                    ortalamadanboyuk += 1;
                }
                else
                {
                    ortalamadankicik += 1;
                }
            }
            Console.WriteLine("________________________________________");
            Console.WriteLine("Ortalama - " + ortalama + "dir");
            Console.WriteLine("________________________________________");
            Console.WriteLine("Ortalamadan  boyuk - " + ortalamadanboyuk + "ədəd var");
            Console.WriteLine("________________________________________");
            Console.WriteLine("Ortalamadan  kicik - " + ortalamadankicik + "ədəd var");
            Console.ReadLine();
        }
    }
}
