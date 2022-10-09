using System;

namespace Alqoritm15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sozu daxil edin = "); string a = Console.ReadLine();
            //int saygac = 0;
            for (int i = 0; i < a.Length-1; i++)
            {
                if (a.Substring(i, 2) == "aa")
                {
                    //saygac++;
                    Console.WriteLine(true);
                    break;
                }

                else
                {
                    Console.WriteLine(false);
                    break;
                }
            }
 

            //Console.WriteLine(saygac);
            //int saygac = 0;
            //for(int i = 0; i < a.Length; i++)
            //{
            //    if(a[i] =='a')
            //    {
            //        saygac++;
            //    }
            //}
            //if (saygac % 2 == 0)
            //{
            //    int s = saygac / 2;
            //    Console.WriteLine("Cavab = " + s);
            //}
            //else
            //{
            //    if (saygac % 3 == 0)
            //    {
            //        saygac = 2;

            //        Console.WriteLine("Cavab = " + saygac);
            //    }
        }
      
        }
    }

