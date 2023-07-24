using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yirmialtinciornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int i;
            int sayac = 0;
            int toplam = 0;
            
            for (i = 0; i < 10; i++)
            {
                Console.Write((i+1)+".Sayıyı Giriniz:");
                int number = Convert.ToInt32(Console.ReadLine());
                if ((number / 100) > 0 && (number / 100) < 10)
                {
                    sayac += 1;
                }
                else
                {
                    toplam += number;
                }

            }
            Console.WriteLine("Üç Basamaklı Sayıların Adedi: "+sayac);
            Console.WriteLine("Üç Basamaklı Olmayan Sayıların Toplamı: "+toplam);
            Console.ReadLine();
        }
    }
}
