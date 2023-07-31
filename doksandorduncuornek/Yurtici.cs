using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace doksandorduncuornek
{
    internal class Yurtici
    {
        string guzergah;
        string ucretliyol;//var ise fiyat ata yok ise 0tl ata)
        string durum;//şehir içi şehir dışı kontrol et
        string tasimacilikdurum;
        string bolge;
        string isturu;//bireysel kurumsal
        string vasitno;//6 karakter kontrol yap.
        int fiyat;
        int elemansayisi;
        public int artifiyat;
        public int km;
        public int birimyakitfiyati = 34;
        public string uyelik;

        public string Guzergah { get { return guzergah; } set { guzergah = value; } }
        public string UcretliYol { get { return ucretliyol; } set { if (value == "var") { ucretliyol = value; artifiyat = 100; } else { ucretliyol = value; } } }
        public string Durum { get { return durum; } set { durum = value; } }
        public string TasimacilikDurum { get { return tasimacilikdurum; } set { tasimacilikdurum = value; } }
        public string Bolge { get { return bolge; } set { bolge = value; } }
        public string IsTuru { get { return isturu; } set { isturu = value; } }
        public string VasitNo { get { return vasitno; } set { if (value.Length > 6) { Console.WriteLine("Yanlış Vasıta No!"); } else { vasitno = value; } } }
        public int Fiyat { get { return fiyat; } set { fiyat = value; } }
        public int ElemanSayisi { get { return elemansayisi; } set { elemansayisi = value; } }
        public void Menu()
        {
            Console.WriteLine("Güzergah Bilgisi Giriniz: ");
            Guzergah = Console.ReadLine();
            Console.WriteLine("Ücretli Yol Var mı? ");
            UcretliYol = Console.ReadLine();
            Console.WriteLine("Şehir içi mi Şehir Dışı mı: ");
            Durum = Console.ReadLine();
            Console.WriteLine("Taşımacılık Durumu Nedir? ");
            TasimacilikDurum = Console.ReadLine();
            Console.WriteLine("Bölge: ");
            Bolge = Console.ReadLine();
            Console.WriteLine("İş Türü Nedir: ");
            IsTuru = Console.ReadLine();
            Console.WriteLine("Vasıta No Giriniz: ");
            VasitNo = Console.ReadLine();
            Console.WriteLine("Fiyat Bilgisi Giriniz: ");
            Fiyat = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Eleman Sayısı Giriniz: ");
            ElemanSayisi = Convert.ToInt32(Console.ReadLine());
        }
        public void Yazdir()
        {
            Menu();
            int ilkhesap = Hesapla(ElemanSayisi, Fiyat);
            int ikincihesap = BolgeHesap(Bolge, IsTuru, ilkhesap);
            int sonhesap=DurumHesap(Durum,ikincihesap);
            Console.WriteLine("Son Hesap: "+sonhesap);
            Console.WriteLine("Güzergah Bilgisi: "+Guzergah);
            Console.WriteLine("Ücretli Yol: "+UcretliYol);
            Console.WriteLine("Durum: "+Durum);
            Console.WriteLine("Taşımacılık Durumu: "+TasimacilikDurum);
            Console.WriteLine("Bölge: "+Bolge);
            Console.WriteLine("İş Türü: "+IsTuru);
            Console.WriteLine("Vasıta No: "+VasitNo);
            Console.WriteLine("Eleman Sayısı: " + ElemanSayisi);
            Bitis(IsTuru, TasimacilikDurum, sonhesap+artifiyat);
            

        }
        public int Hesapla(int elemansayisi, int fiyat)
        {
            if (elemansayisi < 10)
            {
                return fiyat;
            }
            else if(elemansayisi>=10 && elemansayisi < 30)
            {
                fiyat =fiyat+ (elemansayisi-10) * 1000;
                fiyat =fiyat* 13 / 10;
                return fiyat;
            }
            else
            {
                fiyat =fiyat+ (elemansayisi - 10) * 1000;
                fiyat =fiyat* 15 / 10;
                return fiyat;
            }
        }
        public int BolgeHesap(string bolge,string isturu,int fiyat)
        {
            if (bolge == "doguanadolu" && isturu == "bireysel")
            {
                fiyat =fiyat* 105/100;
                fiyat =fiyat* 107/100;
                fiyat =fiyat+ 1000;
                return fiyat;
            }
            else if( bolge == "marmara" && isturu == "kurumsal")
            {
                fiyat =fiyat* 80/100;
                return fiyat;
            }
            else
            {
                fiyat =fiyat* 120 / 100;
                return fiyat;
            }
        }
        public int DurumHesap(string durum, int fiyat)
        {
            Console.Write("Kilometre Giriniz: ");
            km = Convert.ToInt32(Console.ReadLine());
            if(durum=="şehir içi")
            {
                fiyat =fiyat+ ( (km * birimyakitfiyati) * 30 / 100);
                return fiyat;
            }
            else
            {
                fiyat =fiyat + ( (km * birimyakitfiyati) * 130 / 100);
                return fiyat;
            }
        }
        public void Bitis(string isturu,string tasimadurum,int fiyat)
        {
            if (isturu == "kurumsal")
            {
                Console.WriteLine("Üyelik Sistemi Var mı? ");
                uyelik = Console.ReadLine();
                if (uyelik == "var"&&tasimadurum=="kara")
                {
                    fiyat =fiyat* 80/100;
                    Console.WriteLine("Son Fiyat: "+fiyat);
                }
                else if (uyelik == "var" && tasimadurum == "deniz")
                {
                    fiyat =fiyat* 65 / 100;
                    Console.WriteLine("Son Fiyat: "+fiyat);
                }
                else
                {
                    Console.WriteLine("Son Fiyat: "+fiyat);
                }
            }
            else if (isturu == "bireysel")
            {
                Console.WriteLine("Daha Önce Bizimle Çalıştınız mı? ");
                string evethayir = Console.ReadLine();
                if (evethayir == "evet")
                {
                    fiyat =fiyat* 95 / 100;
                    Console.WriteLine("Son Fiyat: "+fiyat);
                }
                else
                {
                    Console.WriteLine("Son Fiyat: "+fiyat);
                }
            }
        }

    }
    
}
