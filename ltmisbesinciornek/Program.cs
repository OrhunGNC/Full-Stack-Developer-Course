using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace altmisbesinciornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] sayilar = new int[10];
            int sayac=0;
            int toplam = 0;
            for (int i = 0; i < 10; i++)
            {
                int sayi = random.Next(1,200);
                sayilar[i] = sayi;
                if (sayi < 100)
                {
                    sayac++;
                    toplam += sayi;
                }
            }
            Console.WriteLine("100'den Küçük Sayıların Toplamı: "+toplam);
            Console.WriteLine("100'den Küçük Sayıların Adedi: "+sayac);
            Console.ReadLine();
        }
    }
}
