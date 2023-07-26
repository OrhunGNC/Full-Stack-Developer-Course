using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sekseninciornek
{
    internal class Program
    {
        static double hesap()
        {
            Console.WriteLine("a-Dış Giyim");
            Console.WriteLine("b-İç Giyim");
            Console.Write("Hangi Giyim Olsun? ");
            char secenek = Convert.ToChar(Console.ReadLine());
            Console.Write("Fiyat Giriniz: ");
            double fiyat = Convert.ToDouble(Console.ReadLine());
            if (secenek == 'a')
            {
                fiyat += fiyat * 0.035;
                Console.WriteLine("Tutar: "+fiyat);
            }
            else
            {
                fiyat += fiyat * 0.055;
                Console.WriteLine("Tutar: " + fiyat);
            }
            double yenifiyat = kdv(fiyat);
            return yenifiyat;
        }
        static double kdv(double fiyat)
        {
            Console.Write("Aksesuar ister misiniz? ");
            string secenek2 = Console.ReadLine();
            switch (secenek2)
            {
                case "evet":
                    fiyat += 500;

                    break;
                case "hayır":
                    fiyat += fiyat * 0.02;

                    break;
                default:

                    break;
            }
            return fiyat;
        }
        static void Main(string[] args)
        {
            double fiyat = 0;
            Console.WriteLine("1-Erkek Ürünleri");
            Console.WriteLine("2-Kadın Ürünleri");
            Console.WriteLine("3-Çocuk Ürünleri");
            Console.Write("Hangi Ürünlere Bakmıştınız? ");
            char secim = Convert.ToChar(Console.ReadLine());
            switch (secim)
            {
                case '1':
                    fiyat = hesap();
                    Console.WriteLine("Son Tutar: "+fiyat);
                    break;
                case '2':
                    fiyat = hesap();
                    Console.WriteLine("Son Tutar: " + fiyat);
                    break;
                case '3':
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }
    }
}
