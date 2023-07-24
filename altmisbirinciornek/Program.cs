using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace altmisbirinciornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            int ortalama = 0;
            int[] sayilar = {40,50,100,78,89};
            foreach(int sayi in sayilar)
            {
                toplam += sayi;
            }
            ortalama = toplam / 5;
            Console.WriteLine("Toplamı: "+toplam);
            Console.WriteLine("Ortalaması: "+ortalama);
            Console.ReadLine();


        }
    }
}
