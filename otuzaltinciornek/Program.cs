using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otuzaltinciornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.Write("Çalışan Sayısı Giriniz: ");
            int calisan = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;
            int toplammaas = 0;
            for (int i=1;i<=calisan;i++)
            {
                Console.Write("\n"+i +".Çalışanın Maaşını Giriniz: ");
                int maas = Convert.ToInt32(Console.ReadLine());
                if (maas>10000 && maas < 20000)
                {
                    Console.Write("\n"+"Kaç Yıldır Çalışıyorsunuz? ");
                    int yil = Convert.ToInt32(Console.ReadLine());
                    if (yil>5 && yil < 9)
                    {
                        int mesai = random.Next(3500, 7000);
                        maas += mesai;
                        toplammaas += maas;
                        Console.WriteLine("\nToplam Mesainiz: "+mesai);
                        Console.WriteLine("\n"+"Zamlanmış yeni maaşınız: " +maas);
                        toplam += mesai;
                    }
                    else
                    {
                        int mesai2 = random.Next(2000, 3400);
                        maas += mesai2;
                        toplammaas += maas;
                        Console.WriteLine("\nToplam Mesainiz: " + mesai2);
                        Console.WriteLine("\n"+"Zamlanmış yeni maaşınız: " + maas);
                        toplam += mesai2;
                    }
                }
                else
                {
                    int mesai3 = random.Next(1000, 4000);
                    maas += mesai3;
                    toplammaas += maas;
                    Console.WriteLine("\nToplam Mesainiz: " + mesai3);
                    Console.WriteLine("\n"+"Zamlanmış yeni maaşınız: " + maas);
                    toplam += mesai3;
                }
                Console.WriteLine("\n"+i+".Çalışanın Yeni Maaşı: "+maas);
            }
            Console.WriteLine("\n"+"Toplam Maaş: "+toplammaas);
            Console.WriteLine("\n"+"Toplam Mesai: " +toplam);
            Console.ReadLine();
        }
    }
}
