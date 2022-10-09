using System;

namespace Alqoritm23
{
    internal class Program
    {
        static void Main(string[] arglams)
        {
            String metin = "www.yazilimkodlama.com";
            metin = metin.ToLower();
            String karakterler = "0123456789abcdefghijklmnopqrstuvwxyz.?,;";
            int[] count = new int[karakterler.Length];
            for (int i = 0; i < metin.Length; i++)
            {
                int index = karakterler.IndexOf(metin[i]);
                if (index < 0)
                    continue;
                else
                {
                    count[index]++;
                }
            }
            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] < 1)
                    continue;
                else
                {
                    Console.WriteLine(karakterler[i] + " " + count[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
