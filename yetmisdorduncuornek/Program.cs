using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yetmisdorduncuornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            mesaj();
            hesapla();
            zam(Convert.ToInt32(Console.ReadLine()));

            Console.ReadLine();
        }
        static void zam(int fiyat)
        {
            fiyat += 50;
            Console.WriteLine("Ödemeniz Gereken Tutar: "+fiyat);
        }
        static void mesaj()
        {
            Console.WriteLine("Hoşgeldiniz bol bol alışveriş yapın");
        }
        static void hesapla()
        {
            int fiyat = 100;
            fiyat += 20;
            Console.WriteLine("Ödemeniz gereken tutar: "+fiyat);
        }
    }
}
