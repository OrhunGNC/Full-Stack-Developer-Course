using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace altinciornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Fiyatı Giriniz: ");
            double price=Convert.ToDouble(Console.ReadLine());
            if (price >= 200)
            {
                price*=1.5d;
            }
            else
            {
                price *= 1.2d;
            }
            Console.WriteLine("Yeni Fiyat: " + price);
            Console.ReadLine();
        }
    }
}
