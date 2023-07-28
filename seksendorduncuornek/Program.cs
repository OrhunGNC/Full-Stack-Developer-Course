using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace seksendorduncuornek
{
    internal class Program
    {
        static void zam(int fiyat)
        {
            fiyat += 500;
            Console.WriteLine("Fiyat: "+fiyat);
        }
        static void zam(int fiyat,int oran)
        {
            fiyat += fiyat * oran/100;
            Console.WriteLine("Fiyat: "+fiyat);
        }
        static void zam (string uruntip,int fiyat)
        {
            if (uruntip == "ütü")
            {
                fiyat += 400;
                Console.WriteLine("Fiyat: "+fiyat);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Fiyat Giriniz: ");
            int fiyat = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ürün Tipi Giriniz: ");
            string uruntip= Console.ReadLine();
            Console.Write("Oran Giriniz: ");
            int oran =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Beyaz Eşya İçin: ");
            zam(fiyat);
            Console.WriteLine("Laptop İçin: ");
            zam(fiyat, oran);
            Console.WriteLine("Küçük Ev Aleti İçin: ");
            zam(uruntip, fiyat);
            Console.ReadLine();
        }
    }
}
