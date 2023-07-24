using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace kirkyedinciornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Toplam Kaç Sayı Yazdırılsın: ");
            int adet = int.Parse(Console.ReadLine());
            Random random=new Random();
            int[] number = new int[adet] ;
            int sayi;
            int toplam = 0;
            int sayac = 0;
            while (sayac < adet)
            {
            go:
                sayi = random.Next(1,1001);
                
                if (sayi % 2 == 0)
                {
                    number[sayac] = sayi;
                    
                    for (int j = 0; j <sayac  ; j++)
                    {
                        if (number[sayac] == number[j])
                        {
                            Console.WriteLine("Aynı Değer Kabul Edilmemekte");
                            goto go;
                        }
                    }
                    Console.WriteLine((sayac + 1) + ".Sayı Değeri: " + sayi);
                    sayac++;
                    toplam += sayi;
                }
            }
            Console.WriteLine("Sayıların Toplamı: "+toplam);
            Console.ReadLine();
        }
    }
}
