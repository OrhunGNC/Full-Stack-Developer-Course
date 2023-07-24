using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace yetmişbesinciornek
{
    internal class Program
    {
        static double vergihesap(double fiyat,string urunadi)
        {
            if (urunadi == "şemsiye")
            {
                fiyat += fiyat * 20 / 100;
                return fiyat;
            }
            else if(urunadi=="şapka")
            {
                fiyat += fiyat * 30 / 100;
                return fiyat;
            }
            else
            {
                return fiyat;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Ürün Adı Giriniz: ");
            double vergitutar = vergihesap(40, Console.ReadLine());
            Console.WriteLine(vergitutar);
            Console.ReadLine();
        }
    }
}
