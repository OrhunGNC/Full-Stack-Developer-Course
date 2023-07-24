using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ondokuzuncuornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("1-Bilgisayar");
            Console.WriteLine("2-Beyaz Eşya");
            Console.WriteLine("3-Telefon");
            Console.Write("\nÜrününüzü Seçiniz: ");
            char secim = Convert.ToChar(Console.ReadLine());
            switch (secim)
            {
                case '1':
                    Console.WriteLine("\nA-Notebook");
                    Console.WriteLine("B-Desktop");
                    Console.WriteLine("C-Tablet");
                    Console.Write("\nÜrününüzü Seçiniz: ");
                    char secenek = Convert.ToChar(Console.ReadLine());
                    switch (secenek)
                    {
                        case 'a':
                            Console.Write("\nMarkayı Giriniz: ");
                            string brand= Console.ReadLine();
                            if (brand == "asus" || brand == "lenovo")
                            {
                                double price = random.Next(10000, 20000);
                                Console.WriteLine("\nÜrünün Vergisiz Fiyatı: " + price+"TL");
                                price *= 1.05;
                                price *= 1.18;
                                Console.WriteLine("\nÜrünün Vergi Dahil Fiyatı: " + price+"TL");
                            }
                            else if (brand == "dell" || brand == "casper")
                            {
                                double price2 = random.Next(7500, 15000);
                                Console.WriteLine("\nÜrünün Vergisiz Fiyatı: " + price2 + "TL");
                                price2 *= 1.07;
                                price2 *= 1.20;
                                Console.WriteLine("\nÜrünün Vergi Dahil Fiyatı: " + price2 + "TL");
                            }
                            else
                            {
                                double price3 = random.Next(5000, 20000);
                                Console.WriteLine("\nÜrünün Vergisiz Fiyatı: " + price3 + "TL");
                                price3 *= 1.1;
                                price3 *= 1.3;
                                Console.WriteLine("\nÜrünün Vergi Dahil Fiyatı: " + price3 + "TL");
                            }
                            break;
                        case 'b':
                            Console.Write("\nDonanım Giriniz: ");
                            string donanim= Console.ReadLine();
                            Console.Write("\nEkran Boyutu Giriniz: ");
                            int inch=Convert.ToInt32( Console.ReadLine());
                            if (donanim == "full" && (inch>= 20 || inch <= 24))
                            {
                                double fee = random.Next(10000, 25000);
                                Console.WriteLine("\nÜrünün İndirimsiz Fiyatı: " + fee+"TL");
                                fee *= 0.85;
                                Console.WriteLine("\nÜrünün İndirimli Yeni Fiyatı: " + fee+"TL");
                            }
                            else if(donanim=="yarım" &&(inch>=15 || inch < 20))
                            {
                                double fee2 = random.Next(5000, 15000);
                                Console.WriteLine("\nÜrünün İndirimsiz Fiyatı: " + fee2 + "TL");
                                fee2 *= 0.75;
                                Console.WriteLine("\nÜrünün İndirimli Yeni Fiyatı: " + fee2 + "TL");
                            }
                            else
                            {
                                double fee3 = random.Next(10000, 30000);
                                Console.WriteLine("\nÜrünün İndirimsiz Fiyatı: " + fee3 + "TL");
                                fee3 *= 0.94;
                                Console.WriteLine("\nÜrünün İndirimli Yeni Fiyatı: " + fee3 + "TL");
                            }
                            break;
                        case 'c':
                            Console.Write("\nTablet Fiyatını Giriniz: ");
                            double tabletprice = Convert.ToInt32(Console.ReadLine());
                            if (tabletprice >= 10000)
                            {
                                tabletprice *= 1.3;
                                Console.WriteLine("\nTabletin KDV dahil fiyatı: " + tabletprice+"TL");
                            }
                            else
                            {
                                tabletprice *= 1.275;
                                Console.WriteLine("\nTabletin KDV dahil fiyatı: " + tabletprice + "TL");
                            }
                            break;
                        default:
                            Console.WriteLine("\nBöyle Bir Ürün Bulunmamaktadır.");
                            break;
                    }
                    break;
                    
            }
            Console.ReadLine();
        }
    }
}
