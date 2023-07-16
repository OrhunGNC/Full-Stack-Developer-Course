using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sekizinciornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Taksimetre Kilometre Giriniz: ");
            double taximeter = Convert.ToDouble(Console.ReadLine());
            Console.Write("Taksimetre ücreti giriniz: ");
            double fee = Convert.ToDouble(Console.ReadLine());
            if (taximeter>=1000 && taximeter <= 2000)
            {
                fee += fee * 10 / 100;
                Console.WriteLine("Ödemeniz gereken tutar: " + fee);
            }
            else
            {
                fee+= fee * 30 / 100;
                Console.WriteLine("Ödemeniz gereken tutar: " + fee);
            }
            Console.ReadLine();
        }
    }
}
