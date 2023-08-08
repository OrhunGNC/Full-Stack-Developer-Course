using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace doksanucuncuornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-Standart Müşteri");
            Console.WriteLine("2-Vip Müşteri");
            Musteriler musteri = new Musteriler();
            int durum = int.Parse(Console.ReadLine());
            if (durum == 1)
            {
                Console.WriteLine("Standart Müşteri Ekranı\n");
                Console.WriteLine("Müşteri No Girin: ");
                musteri.musterino = int.Parse(Console.ReadLine());
                Console.WriteLine("Ad Soyad Girin: ");
                musteri.adsoyad = Console.ReadLine();
                Console.WriteLine("Tel No: ");
                musteri.TelNo = Console.ReadLine();
            go:
                Console.WriteLine("Mail Giriniz: ");
                musteri.Mail = Console.ReadLine();
                if (musteri.Mail == null)
                {
                    Console.WriteLine("Hatalı Tuşladınız!");
                    goto go;
                    
                }
                else
                {
                    Console.WriteLine("Bakiye Giriniz: ");
                    musteri.Bakiye = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Adres Giriniz: ");
                    musteri.adres = Console.ReadLine();
                }
                musteri.Yazdir();
            }
            else if (durum==2)
            {
                Console.WriteLine("Vip Müşteri Ekranı\n");
                Console.WriteLine("Müşteri No Girin: ");
                musteri.musterino = int.Parse(Console.ReadLine());
                Console.WriteLine("Ad Soyad Girin: ");
                musteri.adsoyad = Console.ReadLine();
                Console.WriteLine("Tel No: ");
                musteri.TelNo = Console.ReadLine();
                go:
                Console.WriteLine("Mail Giriniz: ");
                musteri.Mail = Console.ReadLine();
                if (musteri.Mail == null)
                {
                    Console.WriteLine("Hatalı Tuşladınız!");
                    goto go;
                }
                else {
                    Console.WriteLine("Bakiye Giriniz: ");
                    musteri.Bakiye = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Adres Giriniz: ");
                    musteri.adres = Console.ReadLine();
                }
                musteri.Yazdir();
                musteri.Faiz(musteri.Bakiye);

            }
            
            Console.ReadLine();
        }
    }
}
