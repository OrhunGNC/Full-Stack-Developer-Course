using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kirkucuncuornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            while (true)
            {
                Console.Write("Bir Sayı Giriniz: " );
                int number = int.Parse(Console.ReadLine());
                while ((number % 2) != 0)
                {
                    toplam += number;
                    break;
                }
                if (number % 2 == 0)
                    break;
            }
            Console.WriteLine("\n"+"Girilen Tek Sayıların Toplamı: " + toplam);
            Console.ReadLine();
        }
    }
}