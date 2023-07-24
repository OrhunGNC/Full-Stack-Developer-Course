using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kirkdorduncuornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0;
            int toplam = 0;
            while (sayi >= 0)
            {
                Console.Write("Bir Sayı Giriniz: ");
                sayi = int.Parse(Console.ReadLine());
                if (sayi < 0)
                {
                    break;
                }
                toplam += sayi;
            }
            Console.WriteLine("Girilen Sayıların Toplamı: " + toplam);
            Console.ReadLine();
        }
    }
}
