using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yirmiucuncuornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int sayac = 0;
            int toplam = 0;
            Random random= new Random();
            for (i = 1; i <= 5; i++)
            {
                //Console.Write(i+".Sayıyı Giriniz: ");
                //int number = Convert.ToInt32(Console.ReadLine());
                int number = random.Next(0, 1000);
                Console.WriteLine(i+".Sayı: "+number);
                if (number % 2 == 0)
                {
                    toplam += number;
                }
                else
                {
                    sayac++;
                }
            }
            Console.WriteLine("Çift olan sayıların toplamı: "+toplam);
            Console.WriteLine("Tek sayıların sayısı: "+sayac);
            Console.ReadLine();
        }
    }
}
