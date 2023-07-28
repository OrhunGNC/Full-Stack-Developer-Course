using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doksanbirinciornek
{
    internal class Oyuncaklar
    {
        public string oyuncakadi;
        public string marka;
        public string model;
        public double fiyat;
        public string hediyecek;
        public string magazaadi;
        public void Menu()
        {
            Console.Write("Oyuncak Adı: ");
            oyuncakadi = Console.ReadLine();
            Console.Write("Marka: ");
            marka = Console.ReadLine();
            Console.Write("Model: ");
            model = Console.ReadLine();
            Console.Write("Fiyatı ");
            fiyat = Convert.ToDouble(Console.ReadLine());
            Console.Write("Hediye Çeki Var mı : ");
            hediyecek = Console.ReadLine();
            Console.Write("Mağaza Adı: ");
            magazaadi = Console.ReadLine();
        }
        public void Yazdir()
        {
            Menu();
            double yenifiyat = fiyathesap(marka, fiyat, hediyecek);
            Console.WriteLine("Oyuncak Adı: "+oyuncakadi);
            Console.WriteLine("Oyuncak Markası: "+marka);
            Console.WriteLine("Fiyat: " + yenifiyat) ;
        }
        public double fiyathesap(string marka,  double tutar,string hediyeceki)
        {
            if (marka=="toys" && hediyeceki == "var")
            {
                tutar *= 0.9d;
                return tutar;
            }
            else if(marka=="barbie" && hediyeceki == "var")
            {
                tutar *= 0.8d;
                return tutar;
            }
            else
            {
                tutar *= 1.02d;
                return tutar;
            }
        }
    }
}
