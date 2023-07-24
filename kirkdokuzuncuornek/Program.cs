using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kirkdokuzuncuornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int adet = 0;
            int sayi = 0;
            int sayac = 1;
            while (sayac <= 100)
            {
                sayi=random.Next(100,501);
                if (sayi%5==0 && sayi % 7 == 0)
                {
                    Console.WriteLine(sayac + ".Sayı Değeri: " + sayi);
                    adet++;
                    sayac++;   
                }
                else
                {
                    sayac++;
                }
            }
            Console.WriteLine("Sayı Adedi: "+adet);
            Console.ReadLine();
        }
    }
}
