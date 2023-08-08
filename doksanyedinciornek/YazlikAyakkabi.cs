using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doksanyedinciornek
{
    internal class YazlikAyakkabi:Ayakkabi
    {
        string durum;
        public string aksesuardurumu;
        public string renk;

        public string Durum
        {
            get { return durum; }
            set { durum = value; }
        }
        public void Yazlik()
        {
            VeriAl();
            Console.WriteLine("Durum Seçiniz: ");
            Durum = Console.ReadLine();
            Console.WriteLine("Aksesuar Durumu Seçiniz: ");
            aksesuardurumu = Console.ReadLine();
            Console.WriteLine("Renk Seçiniz: ");
            renk = Console.ReadLine();
            Yazdir();
            Console.WriteLine("Durum: "+Durum);
            Console.WriteLine("Aksesuar Durumu: "+aksesuardurumu);
            Console.WriteLine("Renk: "+renk);
            Console.WriteLine("Son Tutar: " + Kdv(fiyat));
        }

    }
}
