using System;
using System.Linq;

namespace Alqoritm21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int uzunluq=0;
            string enuzunmetn = " ";
            int a;
            string[] metnler = new string[3];
            Console.WriteLine("Sozu daxil edi --> ");
            for (int i = 0; i < metnler.Length; i++)
            {
              metnler[i] = Console.ReadLine();
              a =   metnler[i].Length;
                Console.WriteLine("Herf sayi --> " + a);
                
            }
            Console.WriteLine("___________________________________________________________________");
            for (int i = 0; i < metnler.Length; i++)
            {
                if (metnler[i].Length > uzunluq)
                {
                    uzunluq = metnler[i].Length;
                    enuzunmetn = metnler[i];
                    Console.WriteLine("En cox herf olan ---" + uzunluq + " / " + enuzunmetn);
                }
                
          
            }
            Console.ReadLine();


        }
    }
}
