using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yetmisdokuzuncuornek
{
    internal class Program
    {
        //static void secim1(char secenek,double fiyat)
        //{
        //    string secenek2 = " ";
        //    Console.WriteLine("a-Dış Giyim");
        //    Console.WriteLine("b-İç Giyim");
        //    Console.Write("Hangi Giyim Olsun? ");
        //    secenek = Convert.ToChar(Console.ReadLine());
        //    Console.Write("Fiyat Giriniz: ");
        //    fiyat = Convert.ToDouble(Console.ReadLine());
        //    if (secenek == 'a')
        //    {
        //        fiyat += fiyat * 0.035;
        //        Console.WriteLine("Yeni Fiyat: "+fiyat);
        //        aksesuar(secenek2, fiyat);
        //    }
        //    else if (secenek == 'b')
        //    {
        //        fiyat += fiyat * 0.055;
        //        Console.WriteLine("Yeni Fiyat: "+fiyat);
        //        aksesuar(secenek2, fiyat);
        //    }
        //}
        
        //static void aksesuar(string secenek2,double fiyat)
        //{
        //    Console.Write("Aksesuar ister misiniz? ");
        //    secenek2 = Console.ReadLine();
        //    switch (secenek2)
        //    {
        //        case "evet":
        //            fiyat += 500;
        //            Console.WriteLine("Yeni Tutar: "+fiyat);
        //            break;
        //        case "hayır":
        //            fiyat += fiyat * 0.02;
        //            Console.WriteLine("Yeni Tutar: " + fiyat);
        //            break;
        //        default:
        //            Console.WriteLine("Yanlış Cevap Girdiniz!");
        //            break;
        //    }
        //}
        static double fiyat1()
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
            }
            else
            {
                fiyat += fiyat * 0.055;
            }
            return fiyat;
        }
        static void aksesuar(double fiyat2)
        {
            Console.Write("Aksesuar ister misiniz? ");
            string secenek2 = Console.ReadLine();
            switch (secenek2)
            {
                case "evet":
                    fiyat2 += 500;
                    Console.WriteLine("Yeni Tutar: " + fiyat2);
                    break;
                case "hayır":
                    fiyat2 += fiyat2 * 0.02;
                    Console.WriteLine("Yeni Tutar: " + fiyat2);
                    break;
                default:
                    Console.WriteLine("Yanlış Cevap Girdiniz!");
                    break;
            }
        }
        

        static void Main(string[] args)
        {
            double yenifiyat = 0;
            Console.WriteLine("1-Erkek Ürünleri");
            Console.WriteLine("2-Kadın Ürünleri");
            Console.WriteLine("3-Çocuk Ürünleri");
            Console.Write("Hangi Ürünlere Bakmıştınız? ");
            char secim = Convert.ToChar(Console.ReadLine());
            switch (secim)
            {
                case '1':
                    yenifiyat= fiyat1();
                    Console.WriteLine("Yeni fiyat: "+ yenifiyat);
                    aksesuar(yenifiyat);
                    break;
                case '2':
                    yenifiyat = fiyat1();
                    Console.WriteLine("Yeni fiyat: " + yenifiyat);
                    aksesuar(yenifiyat);
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
