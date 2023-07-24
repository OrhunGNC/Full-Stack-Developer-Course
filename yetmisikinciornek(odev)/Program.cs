using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yetmisikinciornek_odev_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[10];
            Random random = new Random();
            int sayi = 0;
                sayi = random.Next(1, 20);
                sayilar[0] = sayi;
            Console.WriteLine(sayi);
            for (int j=1;j < 10; j++)
                {
                sayi = random.Next(1, 20);
                Console.WriteLine(sayi);
                for (int i = 0; i < j; i++)
                {
                    if (sayilar[i] == sayilar[j])
                    {
                        Console.WriteLine("Aynı Sayı Girilemez!");
                    }
                    else
                    {
                        
                        sayilar[j] = sayi;
                    }
                }
                    
                }
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("\nDizimin Sayıları: "+sayilar[i]);
            }
            Console.ReadLine();
        }
        }
    }
