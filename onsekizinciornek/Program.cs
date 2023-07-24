using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onsekizinciornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            go:
            Console.WriteLine("Üretim için 1 basınız");
            Console.WriteLine("İthalat için 2 basınız");
            Console.WriteLine("İhracat için 3 basınız");
            try
            {
                int secenek = Convert.ToInt32(Console.ReadLine());
                switch (secenek)
                {
                    case 1:
                        Console.Write("\nHammadde üretimi 100 ile 200 arasında değer giriniz:");
                        int uretimmiktar = Convert.ToInt32(Console.ReadLine());
                        if (uretimmiktar > 100 && uretimmiktar < 200)
                        {
                            int malfiyat = 500;
                            malfiyat *= uretimmiktar;
                            malfiyat += malfiyat * 20 / 100;
                            Console.WriteLine("\nVergili ham maddenin tutarı " + malfiyat+"TL'dir.");
                        }
                        else
                        {
                            int hamucret = 2000;
                            hamucret *= uretimmiktar;
                            Console.WriteLine("\nVergisiz üretim dışı bedel " + hamucret+"TL'dir.");
                        }
                        break;
                    case 2:
                        Console.WriteLine("\nİthalat Ekranına Hoşgeldiniz");
                        Console.Write("\nÜlke Adını Giriniz: ");
                        string country = Console.ReadLine();
                        Console.Write("\nTaşıma Yolu Giriniz: ");
                        string transportation = Console.ReadLine();
                        if ((country=="italya" || country=="fransa") && transportation == "deniz")
                        {
                            Random random2 = new Random();
                            double fee = random2.Next(1000,2001);
                            fee *= 1.3;
                            Console.WriteLine("\nİthalat Ücreti + Deniz Taşıma Ücreti "+fee+"TL'dir.");
                        }
                        else if ((country=="almanya" || country=="ispanya") && transportation == "kara")
                        {
                            Random random3 = new Random();
                            double fee = random3.Next(500, 1001);
                            fee *= 1.2;
                            Console.WriteLine("\nİthalat Ücreti + Karadan Taşıma Ücreti " + fee + "TL'dir.");
                        }
                        else
                        {
                            Console.WriteLine("\nBaşka seferimiz yok iyi günler.");
                        }
                        break;
                    case 3:
                        Random random = new Random();
                        Console.WriteLine("\nTeknoloji Firması ise 1'e Basın");
                        Console.WriteLine("Sanayi Firması ise 2'ye Basın");
                        Console.WriteLine("Ekonomi ve Kalkınma ise 3'e Basın");
                        char secenekler =Convert.ToChar(Console.ReadLine());
                        switch (secenekler)
                        {
                            case '1':
                                int tutar = random.Next(3000,7500);
                                Console.WriteLine("\nTeknoloji için ödenecek tutar: " + tutar);
                                break;
                            case '2':
                                int tutar2 = random.Next(7500, 9000);
                                Console.WriteLine("\nSanayi için ödenecek tutar: " + tutar2);
                                break;
                            case '3':
                                int tutar3 = random.Next(9000, 12000);
                                Console.WriteLine("\nEkonomi ve Kalkınma için ödenecek tutar: " + tutar3);
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("\nHatalı giriş tekrar deneyiniz.");
                        break;
                }

                
            }
            catch
            {
                Console.WriteLine("\nHatalı Giriş Yapıldı Tekrar Deneyiniz!\n");
                goto go;
            }
            Console.Write("\nMenüye Dönmek İsterseniz <true> yazınız: ");
            bool menu = Convert.ToBoolean(Console.ReadLine());
            if (menu == true)
            {
                Console.Clear();
                goto go;
            }
            else
            {
                Console.WriteLine("\nİyi Günler Dileriz.");
            }
            Console.ReadLine();
        }
    }
}