using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace altmisikinciornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[10];
            int sayi = 0;
            int karetoplam = 0;
            int kuptoplam = 0;
            Random random = new Random();
            for (int i =0; i < sayilar.Length; i++)
            {
                sayilar[i] = sayi = random.Next(4, 60);
                Console.WriteLine(sayi);
                if (sayilar[i]%2==0)
                {
                    karetoplam += sayilar[i] * sayilar[i];
                }
                else if (sayilar[i] % 2 == 1)
                {
                    kuptoplam += sayilar[i] * sayilar[i] * sayilar[i];
                }
            }
            Console.WriteLine("Çift Sayıların Kareleri Toplamı: "+karetoplam);
            Console.WriteLine("Tek Sayıların Küpleri Toplamı: "+kuptoplam);
            Console.ReadLine();
        }
    }
}
