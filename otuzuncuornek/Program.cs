using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otuzuncuornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double toplam = 0;
            double bolum = 0;
            double sonuc=0;
            for(int i = 1; i <= 7; i++)
            {
                Console.Write(i+".Bir Sayı Giriniz: ");
                double number = Convert.ToDouble(Console.ReadLine());
                toplam += number;
                if (i == 5)
                {
                    bolum = number;
                }
                sonuc = toplam / bolum;

            }
            Console.WriteLine("Sonuç: "+ sonuc);
            Console.ReadLine();
        }
    }
}
