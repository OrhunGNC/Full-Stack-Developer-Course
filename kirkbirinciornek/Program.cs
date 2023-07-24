using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kirkbirinciornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int toplam = 0;
            while (i>0 && i <= 100)
            {
                if (i % 2 == 0)
                {
                    toplam += i;
                }
                i++;
            }
            Console.WriteLine("Çift sayıların toplamı: "+toplam);
            Console.ReadLine();
        }
    }
}
