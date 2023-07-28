using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace seksenikinciornek
{
    internal class Program
    {
        static int fiyat;
        static void anamenu(int secim)
        {
            if (secim == 1)
            {   
                Console.WriteLine("\n"+"m-Mercimek Çorbası");
                Console.WriteLine("t-Tarhana Çorbası");
                Console.Write("Tercihiniz: ");
                char corba=char.Parse(Console.ReadLine());
                switch (corba)
                {
                    case 'm':
                        fiyat += 30;
                        fiyat= fis(fiyat);
                        Console.WriteLine("\n"+"Ödemeniz Gereken Tutar: " +fiyat);
                        break;
                    case 't':
                        fiyat += 50;
                        fiyat = fis(fiyat);
                        Console.WriteLine("\n" + "Ödemeniz Gereken Tutar: " + fiyat);
                        break;
                    default:
                        break;
                }
            }
            else if (secim ==2)
            {
                fiyat += 75;
                fiyat = fis(fiyat);
                Console.WriteLine("\n" + "Ödemeniz Gereken Tutar: " + fiyat);
            }
        }

        static int fis(int fiyat)
        {
            Console.Write("İçecek ister misiniz? ");
            string durum = Console.ReadLine();
            if (durum == "evet")
            {
                fiyat += 40;
                return fiyat;
            }
            else
            {
                return fiyat;
            }
        }
        


        static void Main(string[] args)
        {
            go:
            Console.WriteLine("1-Çorba");
            Console.WriteLine("2-Sebze");
            Console.Write("Tercihiniz: ");
            int secim = Convert.ToInt32(Console.ReadLine());
            anamenu(secim);
            Console.Write("İşleme devam etmek istiyor musunuz? ");
            string islem = Console.ReadLine();
            if (islem == "evet")
            {
                goto go;
            }
            //int sonfiyat = fis();
            //Console.WriteLine("\n" + "Son Tutar: " +sonfiyat);
            Console.ReadLine();
        }
    }
}
