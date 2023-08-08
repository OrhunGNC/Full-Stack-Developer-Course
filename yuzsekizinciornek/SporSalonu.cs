using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yuzsekizinciornek
{
    internal class SporSalonu : IUye,Ihizmet
    {
        public int Aidat(int ay, int fiyat)
        {
            if (ay>15 && fiyat < 500)
            {
                fiyat += 100;
                return fiyat;
            }
            else
            {
                return fiyat;
            }
        }

        public void Hizmetler(int fiyat)
        {
            Console.WriteLine("Hizmetler...");
        }

        public void kampanya(int fiyat)
        {
            if(fiyat>1000 && fiyat < 2000)
            {
                Console.WriteLine("Sauna Kazandınız.");
            }
        }

        public void UyeKontrol()
        {
            Console.WriteLine("Üyelik Devam Etsin mi? ");
            string durum = Console.ReadLine();
            if (durum == "evet")
            {
                Console.WriteLine("Kartınız Aktif Edilmiştir.");
            }
            else
            {
                Console.WriteLine("Üyelik Hakkınız için Son 5 Gün.");
            }
        }

        public int Zam(int fiyat)
        {
            fiyat += fiyat * 20 / 100;
            return fiyat;
        }
    }
}
