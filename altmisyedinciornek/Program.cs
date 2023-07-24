using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace altmisyedinciornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int sayac = 0;
            decimal toplam = 0;
            int[] sayilar = new int[10];
            decimal[] yenisayilar = new decimal[10];
            for (int i = 0; i < 10; i++)
            {
                int sayi = random.Next(1, 1000);
                if (sayi %10==0)
                {
                    
                    sayilar[i] = sayi;
                  
                }
                else
                {
                    i--;
                }
            }
       

            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine("İlk Dizinin Elemanları: " + sayilar[j]);
                if (sayilar[j] % 10 == 0 )
                {
                    sayac++;
                    toplam += sayilar[j] *120/100;
                    yenisayilar[j] = sayilar[j] *120/100;

                }
          

            }
            Console.WriteLine(" ");
            for (int i = 0; i < 10; i++)
            {
                
                Console.WriteLine("İkinci Dizinin Elemanları: "+yenisayilar[i]);
            }

            Console.WriteLine("\nSayıların Adedi: " + sayac);
            Console.WriteLine("Sayıların Toplamı: " + toplam);
            Console.ReadLine();
                
            
        }
    }
}
        
