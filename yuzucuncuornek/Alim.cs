using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yuzucuncuornek
{
    internal class Alim : Emlak
    {
        public override void Hesapla(string alimdurum)
        {
            if (alimdurum == "kiralık")
            {
                Console.WriteLine("Kaç Yillik Kira Yapmak İstiyorsunuz? ");
                SozlesmeYil = int.Parse(Console.ReadLine());
                Console.WriteLine("Yıllık Kira Bedeli Giriniz: ");
                YillikKira=int.Parse(Console.ReadLine());
                if (SozlesmeYil >= 1 && SozlesmeYil <= 3)
                {
                    Fiyat =YillikKira* 2;
                    Console.WriteLine("Kira Bedeliniz: "+Fiyat);
                    KomisyonHesap(EmlakCins, Fiyat, SozlesmeYil, YillikKira, Komisyon);
                }
                else if (SozlesmeYil > 3 && SozlesmeYil <= 5)
                {
                    Fiyat= YillikKira* 3;
                    Console.WriteLine("Kira Bedeliniz: "+Fiyat);
                    KomisyonHesap(EmlakCins, Fiyat, SozlesmeYil, YillikKira, Komisyon);
                }
                else
                {
                    Console.WriteLine("Daha Uzun Süreli Kiralık Sözleşmemiz Yoktur.");
                }
            }
            else if(alimdurum == "satılık")
            {
                Console.WriteLine("Fiyat Giriniz: ");
                Fiyat = int.Parse(Console.ReadLine());
                Fiyat += Fiyat * 2 / 100;
                Console.WriteLine("Son Tutar: "+Fiyat);
            }
            else
            {
                Console.WriteLine("Böyle Bir Alım Durumu Yoktur.");
            }
        }


        public override void VeriAl()
        {
            Console.WriteLine("Yapı Durumu Nedir? ");
            YapiDurum = Console.ReadLine();
            Console.WriteLine("Alım Durumu Nedir? ");
            AlimDurum = Console.ReadLine();
            Console.WriteLine("Belge Adı nedir? ");
            BelgeAd = Console.ReadLine();
            Console.WriteLine("Belge No Nedir? ");
            BelgeNo = Console.ReadLine();
            Console.WriteLine("Emlak Cinsi Nedir ? ");
            EmlakCins = Console.ReadLine();
            Console.WriteLine("Bölge Sorumlusu Kim? ");
            BolgeSorumlusu = Console.ReadLine();
            Console.WriteLine("Komisyon Giriniz: ");
            Komisyon = int.Parse(Console.ReadLine());
            Hesapla(AlimDurum);
        }
        public override void KomisyonHesap(string emlakcinsi, int fiyat, int sozlesmeyil, int yillikkira,int komisyon)
        {
            if (emlakcinsi == "kurumsal")
            {
                fiyat += komisyon + (yillikkira * sozlesmeyil);
                Console.WriteLine("Son Komisyonlu Bedel: "+fiyat);
            }
            else if(emlakcinsi == "bireysel")
            {
                fiyat += komisyon;
                Console.WriteLine("Son Komisyonlu Bedel: "+fiyat);
            }
            else
            {
                Console.WriteLine("Böyle Bir Emlak Cinsi Yoktur.");
            }
        }
    }
}
