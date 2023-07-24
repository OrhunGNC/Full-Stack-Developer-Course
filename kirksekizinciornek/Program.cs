using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kirksekizinciornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int sayi = 0;
            int toplam = 0;
            while (toplam <= 1000)
            {
                sayi = random.Next(1,101);
                if (toplam > 1000)
                {
                    break;
                }
                toplam += sayi;
            }
            Console.WriteLine("Sayıların Toplamı"+toplam);
            Console.ReadLine();
        }
    }
}
