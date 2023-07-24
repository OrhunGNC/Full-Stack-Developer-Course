using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elliucuncuornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number;
            int sayac = 0;
            int toplam = 0;
            do
            {
                number = random.Next(1,100);
                sayac++;
                toplam += number;
            }
            while (number != 50);
            Console.WriteLine(sayac+".Deneyişte bulundu.");
            Console.WriteLine("Sayıların Toplamı: "+toplam);
            Console.ReadLine();

        }
    }
}
