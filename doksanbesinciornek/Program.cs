using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doksanbesinciornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TeknolojikUrunler tekno = new TeknolojikUrunler();
            tekno.UrunNo = 789;
            tekno.Marka = "Bosch";
            tekno.Model = "df74";
            tekno.Fiyat = 20000;
            tekno.Mensei = "Almanya";
            tekno.Durum();
            tekno.enerjidurum = "A++";
            tekno.malzemeDurum = "plastik";
            tekno.volt = 220;
            int sonfiyat = tekno.Ekstra(tekno.enerjidurum, tekno.Fiyat);
            tekno.Uyari(tekno.volt);
            KucukEvUrunleri evurun = new KucukEvUrunleri();
            evurun.Yazdir();
            Console.ReadLine();
        }
    }
}
