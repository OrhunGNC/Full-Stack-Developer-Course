using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doksandorduncuornek
{
    internal class Yurtdisi
    {
        string ulkeadi;
        string sehir;
        string vasitatip;
        int km;
        int fiyat;
        int komisyon;
        public string sorumlukisi;

        public void VeriAl()
        {
            Console.Write("Ülke Adı Giriniz: ");
            UlkeAdi = Console.ReadLine();
            Console.Write("Şehir Giriniz: ");
            Sehir = Console.ReadLine();
            Console.Write("Vasıta Tipi Giriniz: ");
            VasitaTip = Console.ReadLine();
            Console.Write("Kilometre Bilgisi Giriniz: ");
            Km = Convert.ToInt32(Console.ReadLine());
            Console.Write("Fiyat Giriniz: ");
            Fiyat = int.Parse(Console.ReadLine());
            Console.Write("Komisyon Giriniz: ");
            Komisyon = int.Parse(Console.ReadLine());
            Console.Write("Sorumlu Kişi: ");
            sorumlukisi = Console.ReadLine();
        }
        public string UlkeAdi { get{return ulkeadi;} set { if(value != "brezilya" && value != "meksika"){ulkeadi = value;} else{Console.WriteLine("Yanlış Ülke!");}}}
        public string Sehir { get { return sehir; } set { sehir = value; } }
        public string VasitaTip { get { return vasitatip; } set { if (value != "motor" && value != "minibüs") { vasitatip = value; } else { Console.WriteLine("Yanlış Vasıta!"); } } }
        public int Km { get { return km; } set { if (value > 500 && value < 25000) { km = value; } else { Console.WriteLine("Yanlış Kilometre!"); } } }
        public int Fiyat { get { return fiyat; } set { if (value > 3000 && value < 15000) { fiyat = value; } else { Console.WriteLine("Yanlış Fiyat!"); } } }
        public int Komisyon { get { return komisyon; } set { komisyon = value; } }

        public void Yazdir() {
            VeriAl();
            Console.WriteLine("Sorumlu Kişi: "+sorumlukisi);
            Console.WriteLine("Ülke Adı: "+UlkeAdi);
            Console.WriteLine("Şehir: "+Sehir);
            Console.WriteLine("Vasıta Tipi: "+VasitaTip);
            Console.WriteLine("Kilometre: "+Km);
            Hesap(VasitaTip, KomisyonHesap());
            Console.WriteLine("Komisyon: "+Komisyon);
        }
        public int KomisyonHesap()
        {
            if(UlkeAdi=="fransa"&& km < 1500)
            {
                Komisyon += Komisyon * 20 / 100;
                return Komisyon;
            }
            else
            {
                Komisyon += Komisyon * 30 / 100;
                return Komisyon;
            }
        }
        public void Hesap(string vasitatip,int komisyon2)
        {
            if (vasitatip == "uçak" || vasitatip == "helikopter")
            {
                fiyat += komisyon2 * km;
                Console.WriteLine("Fiyat: " +fiyat);
            }
            else if (vasitatip == "gemi")
            {
                fiyat = (fiyat+ komisyon2 * km)*88/100;
                Console.WriteLine("Fiyat: " + fiyat);
            }
            else
            {
                fiyat = (fiyat + komisyon2 * km)*93/100;
                Console.WriteLine("Fiyat: " + fiyat);
            }
        }
    }
}