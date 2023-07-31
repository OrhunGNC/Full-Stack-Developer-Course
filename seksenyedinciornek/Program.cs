using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seksenyedinciornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ElektronikEsya elektronik = new ElektronikEsya();
            elektronik.marka = "samsung";
            elektronik.model = "x504";
            elektronik.fiyat = 20000;
            elektronik.yil = 2023;
            elektronik.mensei = "kore";

            ElektronikEsya alet = new ElektronikEsya();
            Console.Write("Marka Adını Giriniz: ");
            alet.marka = Console.ReadLine();
            Console.Write("Model Giriniz: ");
            alet.model = Console.ReadLine();
            Console.Write("Fiyat Giriniz: ");
            alet.fiyat = Convert.ToInt32(Console.ReadLine());
            Console.Write("Yıl Giriniz: ");
            alet.yil = Convert.ToInt32(Console.ReadLine());
            Console.Write("Menşei Giriniz: ");
            alet.mensei = Console.ReadLine();

            

            Console.WriteLine("Elektronik marka: "+elektronik.marka);
            Console.WriteLine("Fiyat: "+elektronik.fiyat);
            Console.WriteLine("\n"+"İkinci Cihazın Markası: "+alet.marka);
            Console.WriteLine("İkinci Cihazın Fiyatı: "+alet.fiyat);
            Console.WriteLine("KDV Eklenmesi Sonrası Fiyat: " + alet.kdv(alet.fiyat));
            alet.hediye();
            Console.ReadLine();
        }
    }
}
