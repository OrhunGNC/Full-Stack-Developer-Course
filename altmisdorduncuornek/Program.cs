using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace altmisdorduncuornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[10];
            int sayac = 0;
            int toplam = 0;
            int sayitoplam = 0;
            for (int i =0; i < sayilar.Length; i++)
            {
                Console.Write("Sayı Giriniz: ");
                int sayi = int.Parse(Console.ReadLine());
                sayilar[i] = sayi;
                if (sayi%8==0 && sayi%5 == 0)
                {
                    sayac++;
                    toplam += sayi;
                }
            }
            foreach(int sayii in sayilar)
            {
                sayitoplam += sayii;
            }
            Console.WriteLine("\n" + "Girilen Sayılardan 8 ve 5'in Katı Olanların Adedi:  " +sayac);
            Console.WriteLine("\n" + "Girilen Sayılardan 8 ve 5'in Katı Olanların Toplamı: " +toplam);
            Console.WriteLine("\n" + "Girilen Tüm Sayıların Toplamı: " +sayitoplam);
            Console.ReadLine();

        }
    }
}
