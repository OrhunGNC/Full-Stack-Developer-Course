using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yirmidokuzuncuornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir Sayı Giriniz: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int i;
            int sayac = 0;
            for (i = 1; i < (number); i++)
            {
                if (number % i == 0)
                {
                    sayac++;
                }
                
            }
            if (sayac == 1)
            {
                Console.WriteLine("Asaldır.");
            }
            else
            {
                Console.WriteLine("Girilen Sayı Asal Değildir.");
            }
            Console.ReadLine();
        }
    }
}
