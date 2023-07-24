using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yirmidorduncuornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0;
            for (int i = 75; i <= 300; i++)
            {
                if (i % 5 == 0 && i%2==0)
                {
                    sayac++;
                }
            }
            Console.WriteLine("Beşe bölünen çift sayıların sayısı: "+sayac);
            Console.ReadLine();
        }
    }
}
