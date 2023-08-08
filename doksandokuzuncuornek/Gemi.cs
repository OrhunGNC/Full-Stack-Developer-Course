using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doksandokuzuncuornek
{
    internal class Gemi : Ulasim
    {
        public void VeriAl()
        {
            Console.WriteLine("Ulaşım No Giriniz: ");
            ulasimno = int.Parse(Console.ReadLine());
            Console.WriteLine("Bilet Fiyatı Giriniz: ");
            biletfiyat = int.Parse(Console.ReadLine());
            Console.WriteLine("Adet Giriniz: ");
            adet = int.Parse(Console.ReadLine());
            Console.WriteLine("Güzergah Giriniz: ");
            guzergah = Console.ReadLine();
            Console.WriteLine("Görevli Kişiyi Giriniz: ");
            gorevlikisi = Console.ReadLine();
        }
        public void Yazdir()
        {
            VeriAl();
            int ilkfiyat = Zam(biletfiyat);
            int yenifiyat = Indirim(guzergah, adet, ilkfiyat);
            Console.WriteLine("Son Bilet Fiyatı: " + yenifiyat);
        }
        public override int Indirim(string guzergah, int adet, int fiyat)
        {
            if (guzergah == "anadolu yakası" && adet > 5)
            {
                fiyat -= fiyat * 10 / 100;
            }
            else if (guzergah == "avrupa yakası" && adet > 3)
            {
                fiyat -= fiyat * 5 / 100;
            }
            return fiyat;
        }

        public override int Zam(int biletfiyat)
        {
            biletfiyat += biletfiyat * 30 / 100;
            return biletfiyat;
        }
    }
}
