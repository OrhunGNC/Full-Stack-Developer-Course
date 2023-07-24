using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yetmisinciornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sehirler = new string[4];
            int sayac = 0;
            for (int i = 0; i < sehirler.Length; i++)
            {
                Console.Write("Şehir İsmi Giriniz: ");
                string sehir = Console.ReadLine();
                sehirler[i] = sehir;
            }
            Console.Write("Aramak İstediğiniz Şehrin İsmini Giriniz: ");
            string sehir2 = Console.ReadLine();
            for (int i = 0; i < sehirler.Length; i++)
            {
                if (sehirler[i] == sehir2)
                {
                    sayac++;
                }
            }
            if (sayac >= 1) {
                Console.WriteLine("Şehir Bulundu.");
            }
            else
            {
                Console.WriteLine("Şehir Bulunamadı.");
            }
            Console.ReadLine();
        }
    }
}
