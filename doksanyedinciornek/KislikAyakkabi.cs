using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doksanyedinciornek
{
    internal class KislikAyakkabi:Ayakkabi
    {
        public string uzunluk;
        public string tur;

        public void Kislik()
        {
            VeriAl();
            Console.WriteLine("Uzunluk Seçiniz: ");
            uzunluk = Console.ReadLine();
            Console.WriteLine("Tür Seçiniz: ");
            tur = Console.ReadLine();
            Yazdir();
            Console.WriteLine("Uzunluk: "+uzunluk);
            Console.WriteLine("Tür: "+tur);
            Console.WriteLine("Son Tutar: " + Kdv(fiyat));
        }

    }
}
