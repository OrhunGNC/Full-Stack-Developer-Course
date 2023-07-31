using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doksanbesinciornek
{
    internal class TeknolojikUrunler:Urunler
    {
        public string enerjidurum;
        public int volt;
        public string malzemeDurum;

        public int Ekstra(string enerji,int fiyat)
        {
            if (enerji == "A++")
            {
                fiyat += 1000;
                return fiyat;
            }
            else
            {
                return fiyat;
            }
        }
        public void Uyari(int volt)
        {
            Console.WriteLine("Volt Fazlalığı Durumunda Bozulmadan Sorumlu Değiliz...");
        }
    }
}
