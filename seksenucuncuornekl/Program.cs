using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seksenucuncuornek
{
    internal class Program
    {
        static int fiyat;
        static void anamenu(int secim)
        {
            if (secim == 1)
            {
                Console.WriteLine("a-Karaca");
                Console.WriteLine("b-Güral Porselen");
                Console.Write("Tercihiniz: ");
                char secenek = Convert.ToChar(Console.ReadLine());
                if (secenek == 'a' || secenek == 'b')
                {
                    fiyat += 5000;
                    fiyat = fis(fiyat);
                    Console.WriteLine("Son Fiyat: " + fiyat);
                }
                else
                {
                    fiyat += 3000;
                    fiyat = fis(fiyat);
                    Console.WriteLine("Son Fiyat: " + fiyat);
                }
            }
            else if (secim == 2)
            {
                Console.WriteLine("a-Tam Paket");
                Console.WriteLine("b-Yarı Paket");
                Console.Write("Tercihiniz: ");
                char secenek=Convert.ToChar(Console.ReadLine());
                if (secenek == 'a')
                {
                    fiyat += 7500;
                    fiyat = fis(fiyat);
                    Console.WriteLine("Son Fiyat: "+fiyat);
                }
                else if (secenek == 'b')
                {
                    Console.Write("Parça Sayısı Giriniz: ");
                    int parcasayisi = Convert.ToInt32(Console.ReadLine());
                    fiyat += parcasayisi * 750;
                    fiyat = fis(fiyat);
                    Console.WriteLine("Son Fiyat: " + fiyat);
                }
            }
        }
        static int fis(int fiyat)
        {
            Console.Write("İndirimde Ütü Var Almak İster misiniz? <true/false> ");
            bool indirim = Convert.ToBoolean(Console.ReadLine());
            if (indirim == true)
            {
                fiyat += 1000;
                fiyat += fiyat* 10/100;
                return fiyat;
            }
            else
            {
                fiyat += fiyat * 10 / 100;
                return fiyat;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("BAÜ Züccaciye");
            Console.WriteLine("1-Yemek Takımı");
            Console.WriteLine("2-Tencere Takımı");
            Console.Write("Terchiniz: ");
            int secim = Convert.ToInt32(Console.ReadLine());
            anamenu(secim);
            Console.ReadLine();
        }
    }
}
