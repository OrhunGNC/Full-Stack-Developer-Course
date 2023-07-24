using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yirminciornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            for(int i = 0; i < 100; i+=2)
            {
                toplam += i;
                Console.WriteLine("Sayı Değerim: "+i);
            }
            Console.WriteLine("Toplam: "+toplam);
            Console.ReadLine();
        }
    }
}
