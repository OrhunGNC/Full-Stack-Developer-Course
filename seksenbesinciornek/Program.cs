using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seksenbesinciornek
{
    internal class Program
    {
        static void ortalama(int yazilisinav, int ikincisinav)
        {
            Console.Write("İlk Sınav Notunuz: ");
            yazilisinav = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci Sınav Notunuz: ");
            ikincisinav = Convert.ToInt32(Console.ReadLine());
            int ortalama =(yazilisinav+ikincisinav)/2;
            Console.WriteLine("Ortalama: "+ortalama);
        }
        static void ortalama(int yazilisinav,int ikincisinav,int sozlu)
        {
            Console.Write("İlk Sınav Notunuz: ");
            yazilisinav = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci Sınav Notunuz: ");
            ikincisinav = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sözlü Notunuz: ");
            sozlu = Convert.ToInt32(Console.ReadLine());
            int ortalama = (yazilisinav + ikincisinav+sozlu) / 3;
            Console.WriteLine("Ortalama: " + ortalama);
        }
        static void ortalama(int yazilisinav,double kanaat)
        {
            Console.Write("İlk Sınav Notunuz: ");
            yazilisinav = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kanaat Notunuz: ");
            kanaat = Convert.ToInt32(Console.ReadLine());
            int ortalama = (int)((yazilisinav + kanaat) / 2);
            Console.WriteLine("Ortalama: " + ortalama);
        }
        static void Main(string[] args)
        {
            int ilksinav = 0;
            int ikincisinav = 0;
            int sozlu = 0;
            double kanaat = 0;
            Console.WriteLine("1-İlkokul");
            Console.WriteLine("2-Lise");
            Console.WriteLine("3-Üniversite");
            Console.Write("Hangi Okula Gidiyorsunuz? ");
            int okul = Convert.ToInt32(Console.ReadLine());
            if (okul == 1)
            {
                ortalama(ilksinav, ikincisinav);
            }
            else if(okul == 2)
            {
                ortalama(ilksinav, ikincisinav,sozlu);
            }
            else if(okul == 3)
            {
                ortalama(ilksinav, kanaat);
            }
            Console.ReadLine();
        }
    }
}
