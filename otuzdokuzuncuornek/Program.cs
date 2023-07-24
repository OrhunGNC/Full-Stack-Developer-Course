using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace otuzdokuzuncuornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Öğrenci Sayısı Giriniz: ");
            int ogrenci = Convert.ToInt32(Console.ReadLine());
            double notlar = 0;
            
            double ortalama = 0;
            int sayac = 0;
            for (int i=1; i<=ogrenci; i++)
            {
                double notlartoplami = 0;
                for (int j = 1; j <= 4; j++)
                {
                    Console.Write("\n"+i+".Öğrencinin"+j+". Dersinin Notunu Giriniz: ");
                    notlar = double.Parse(Console.ReadLine());
                    notlartoplami += notlar;
                }
                ortalama = notlartoplami / 4;
                Console.WriteLine("\n" + i +".Öğrencinin Not Ortalaması: "+ortalama);
                if (ortalama >= 50)
                {
                    Console.WriteLine("\n" + i +".Öğrenci Geçti");
                    sayac++;
                }
                else
                {
                    Console.WriteLine("\n" + i +".Öğrenci Kaldı");
                }
            }
            if (sayac == ogrenci)
            {
                Console.WriteLine("\n" + "Tüm öğrenciler geçti.");
            }
            else
            {
                Console.WriteLine("\n" + "Tüm öğrenciler geçemedi. Kalanlar var...");
            }
            Console.ReadLine();
        }
    }
}
