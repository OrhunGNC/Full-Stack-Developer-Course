using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace altmissekizinciornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { -3, -4, -5, -7, -6, -8 };
            for (int i=0;i < sayilar.Length;i++)
            {
                sayilar[i] = -1 * sayilar[i];
            }
            for (int i = 0; i < sayilar.Length; i++) 
                Console.WriteLine(sayilar[i]);

            Console.ReadLine();
        }
    }
}
