using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yetmisyedinciornek
{
    internal class Program
    {
        static double hesapla(double birim, double kur)
        {
            double sonuc = birim * kur;
            return sonuc;
        }
        static void Main(string[] args)
        {
            Console.Write("Birim Fiyatı Giriniz: ");
            double fiyat = Convert.ToDouble(Console.ReadLine());
            Console.Write("Kur Miktarını Giriniz: ");
            double kur = Convert.ToDouble(Console.ReadLine());
            double sonuc =hesapla(fiyat,kur);
            Console.WriteLine("Tutar: "+sonuc);
            Console.ReadLine();
        }
    }
}
