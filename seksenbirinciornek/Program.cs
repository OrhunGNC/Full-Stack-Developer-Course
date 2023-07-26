using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace seksenbirinciornek
{
    internal class Program
    {
        static double turhesaplama(double day)
        {
            Console.Write("Fiyat Giriniz: ");
            double price = Convert.ToDouble(Console.ReadLine());
            double totalprice = day * price;
            return totalprice;
        }
        static double ekstra(double ilkfiyat)
        {
            Console.Write("Yemek ve Eğlence Dahil Olsun mu ? <true/false>: ");
            bool secim = Convert.ToBoolean(Console.ReadLine());
            double price = 0;
            if (secim == true)
            {
                price = ilkfiyat + 1000;
            }
            else
            {
                price = ilkfiyat * 0.92d;
            }
            return price;
        }
        static void fatura(double day,double fiyat)
        {
            if (day < 10)
            {
                fiyat *= 1.12;
                Console.WriteLine("İşlem Bedeli Sonrası Tutar: "+fiyat);
            }
            else
            {
                fiyat *= 1.22;
                Console.WriteLine("İşlem Bedeli Sonrası Tutar: " + fiyat);
            }
        }
        static double kraliyet(double fiyat)
        {
            Console.WriteLine("a-Sauna");
            Console.WriteLine("b-Jakuzi");
            Console.WriteLine("c-Hepsi");
            Console.Write("Oda Özellikleri Arasından Seçim Yapınız: ");
            char secim = Convert.ToChar(Console.ReadLine());
            if (secim == 'a' || secim == 'b')
            {
                fiyat += 10000;
            }
            else
            {
                fiyat += 25000;
            }
            return fiyat;
        }
        static void Main(string[] args)
        {
            go:
            Console.WriteLine("1-Standart Oda");
            Console.WriteLine("2-Ekonomik Oda");
            Console.WriteLine("3-Kral Odası");
            Console.Write("Oda Seçimi Yapınız: ");
            char secim = Convert.ToChar(Console.ReadLine());
            double ilkfiyat = 0;
            double day = 0;
            double secimsonrasi = 0;
            switch (secim)
            {
                case '1':
                    Console.Write("Gün Sayısı Giriniz: ");
                    day = Convert.ToDouble(Console.ReadLine());
                    ilkfiyat = turhesaplama(day);
                    Console.WriteLine("İlk Tutar: " + ilkfiyat);
                    secimsonrasi = ekstra(ilkfiyat);
                    Console.WriteLine("Yemek ve Eğlence Seçimi Sonrası Tutar: " + secimsonrasi);
                    fatura(day, secimsonrasi);
                    break;
                case '2':
                    Console.Write("Gün Sayısı Giriniz: ");
                    day = Convert.ToDouble(Console.ReadLine());
                    ilkfiyat = turhesaplama(day);
                    Console.WriteLine("İlk Tutar: " + ilkfiyat);
                    secimsonrasi = ekstra(ilkfiyat);
                    Console.WriteLine("Yemek ve Eğlence Seçimi Sonrası Tutar: " + secimsonrasi);
                    fatura(day, secimsonrasi);
                    break;
                case '3':
                    Console.Write("Gün Sayısı Giriniz: ");
                    day = Convert.ToDouble(Console.ReadLine());
                    ilkfiyat = turhesaplama(day);
                    Console.WriteLine("İlk Tutar: " + ilkfiyat);
                    secimsonrasi = ekstra(ilkfiyat);
                    Console.WriteLine("Yemek ve Eğlence Seçimi Sonrası Tutar: " + secimsonrasi);
                    double sonfiyat = kraliyet(secimsonrasi);
                    Console.WriteLine("Oda Özellikleri Seçimi Sonrası Tutar: "+sonfiyat);
                    fatura(day, sonfiyat);
                    break;
                default:
                    Console.WriteLine("Yanlış Numara Yazdınız.");
                    Console.WriteLine("Tekrar Denemek İster misiniz? <true/false> ");
                    bool tekrar = Convert.ToBoolean(Console.ReadLine());
                    if (tekrar == true)
                    {
                        Console.Clear();
                        goto go;
                    }
                    else
                    {
                        Console.WriteLine("İyi Günler.");
                    }
                    break;
            }
            Console.ReadLine();
        }   
    }
}