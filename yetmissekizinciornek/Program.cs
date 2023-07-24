using System;

namespace yetmissekizinciornek
{
    internal class Program
    {
        static double zam(double miktar)
        {
            Console.Write("Fiyatı Kaç Olsun? ");
            double fiyat = Convert.ToDouble(Console.ReadLine());
            double tutar = miktar * fiyat;
            tutar += tutar * 20 / 100;
            return tutar;
        }
        static double OTV(double cointutar)
        {
            cointutar += cointutar * 60 / 100;
            return cointutar;

        }
        static void sistem(bool durum,double tutar,int secenek)
        {
            if (durum == true)
            {
                Console.WriteLine("Sisteme Üye Olduğunuz için 100tl bonus kazandınız.");
                if (secenek==1 || secenek == 3)
                {
                    tutar -= 100;
                    Console.WriteLine(tutar);
                }
                else
                {
                    tutar -= 100;
                    Console.WriteLine(tutar);
                }
            }
            else
            {
                Console.WriteLine("Üye ol da gel...");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("1-Borsa Piyasaları");//%20 zam
            Console.WriteLine("2-Coin Piyasaları");//%60 ötv
            Console.WriteLine("3-Altın Piyasaları");//%20 zam
            int secim = int.Parse(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    Console.Write("Lot Sayısını Giriniz: ");
                    double hesaplama = double.Parse(Console.ReadLine());
                    double tutar = zam(hesaplama);
                    Console.WriteLine("Tutar: "+tutar);
                    Console.WriteLine("Sisteme katılmak ister misiniz? ");
                    bool cevap = Convert.ToBoolean(Console.ReadLine());
                    sistem(cevap,tutar,secim);
                    break;
                case 2:
                    Console.Write("Coin Tutarını Giriniz: ");
                    double coin = double.Parse(Console.ReadLine());
                    double tutar2 = OTV(coin);
                    Console.WriteLine("Tutar: "+tutar2);
                    Console.WriteLine("Sisteme katılmak ister misiniz? ");
                    bool cevap1 = Convert.ToBoolean(Console.ReadLine());
                    sistem(cevap1,tutar2,secim);
                    break;
                case 3:
                    Console.Write("Gramı Giriniz: ");
                    double hesaplama1 = double.Parse(Console.ReadLine());
                    double tutar3 = zam(hesaplama1);
                    Console.WriteLine("Tutar: " + tutar3);
                    Console.WriteLine("Sisteme katılmak ister misiniz? ");
                    bool cevap2 = Convert.ToBoolean(Console.ReadLine());
                    sistem(cevap2, tutar3, secim);
                    break;
                default:
                    Console.WriteLine("Yanlış Tuşlama Yaptınız!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
