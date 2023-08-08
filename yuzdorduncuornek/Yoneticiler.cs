using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yuzdorduncuornek
{
    static internal class Yoneticiler
    {
        public static int yas;
        public static string adsoyad;
        public static void yazdir()
        {
            Console.WriteLine("Ekrana Veri Yaz");
            yas = int.Parse(Console.ReadLine());
            Console.WriteLine("Adını yaz");
            adsoyad = Console.ReadLine();
        }
    }
}
