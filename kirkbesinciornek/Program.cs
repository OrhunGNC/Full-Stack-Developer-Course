using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kirkbesinciornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0;
            int toplam = 0;
            while (sayi != 5)
            {
                go:
                try
                {
                    toplam += sayi;
                    Console.Write("Bir Sayı Giriniz: ");
                    sayi = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Yanlış değer girdiniz!");
                    Console.Write("Tekrar denemek ister misiniz? <y/n> ");
                    char cevap = char.Parse(Console.ReadLine());
                    if (cevap == 'y')
                    {
                        goto go;
                    }
                    else if (cevap == 'n')
                    {
                        Console.WriteLine("İyi Günler");
                    }
                }
                
            }
            Console.WriteLine("Girilen sayıların toplamı: "+toplam);
            Console.ReadLine();
        }
    }
}
