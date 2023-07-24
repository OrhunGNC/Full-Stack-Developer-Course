using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yirmiyedinciornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir Sayı Giriniz: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int i;
            int sayac = 0;
            int toplam = 0;
            for (i=1;i<=number;i++)
            {
                if (i % 7 == 0)
                {
                    sayac++;
                }
                else
                {
                    toplam += i;
                }
            }
            Console.WriteLine("\n7'ye Bölünen Sayıların Sayısı: "+sayac);
            Console.WriteLine("\n7'ye Bölünmeyen Sayıların Toplamı: " + toplam);
            Console.ReadLine();
        }
    }
}
