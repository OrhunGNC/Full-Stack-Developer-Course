using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elliikinciornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int toplam = 0;
            do
            {
                Console.Write("Bir Sayı Giriniz: ");
                number = int.Parse(Console.ReadLine());
                toplam += number;
            }
            while (number != 0);
            Console.WriteLine("Sayıların Toplamı: "+toplam);
            Console.ReadLine();
        }
    }
}
