using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onikinciornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            go:
            Console.WriteLine("1) 0 ile 2 yıl arasında ise 1 tıklayınız.");
            Console.WriteLine("2) 2 ile 3 yıl arasında ise 2 tıklayınız.");
            Console.WriteLine("3) 3 ile 5 yıl arasında ise 3 tıklayınız.");
            Console.WriteLine("4) 5 ile 10 yıl arasında ise 4 tıklayınız.");
            Console.Write("Garanti Süresini Giriniz: ");
            int warranity = Convert.ToInt32(Console.ReadLine());
            if (warranity == 1)
            {
                Console.WriteLine("1.Adım Çalıştı");
                Random rastgelesayi = new Random();
                int number = rastgelesayi.Next(100, 500);
                Console.WriteLine("Garanti Servisi Faturası: " + number + "TL");
            }
            else if (warranity == 2)
            {
                Console.WriteLine("2.Adım Çalıştı");
                Random rastgelesayi = new Random();
                int number = rastgelesayi.Next(500, 750);
                Console.WriteLine("Garanti Servisi Faturası: " + number + "TL");
            }
            else if ( warranity == 3)
            {
                Console.WriteLine("3.Adım Çalıştı");
                Random rastgelesayi = new Random();
                int number = rastgelesayi.Next(750, 900);
                Console.WriteLine("Garanti Servisi Faturası: " + number + "TL");
            }
            else if (warranity==4)
            {
                Console.WriteLine("4.Adım Çalıştı");
                Random rastgelesayi = new Random();
                int number = rastgelesayi.Next(900, 1250);
                Console.WriteLine("Garanti Servisi Faturası: " + number + "TL");
            }
            else
            {
                Console.WriteLine("Yanlış Kodlama Tekrar Deneyiniz.");
            }
            Console.Write("Tekrar Denemek İstermisiniz? ");
            string tryagain = Console.ReadLine();
            if (tryagain == "evet" || tryagain == "Evet" || tryagain == "EVET")
            {
                Console.Clear();
                goto go;
            }
            else
            {
                Console.WriteLine("İyi Günler.");
            }
            Console.ReadLine();
        }
    }
}
