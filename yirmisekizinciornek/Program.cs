using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace yirmisekizinciornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, i;
            int carpim = 1;
            Console.Write("Tabanı Giriniz: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Üssü Giriniz: ");
            b = Convert.ToInt32(Console.ReadLine());
            int carpim2 = (int)Math.Pow(a, b);
            for (i = 1; i <= b; i++)
            {
                carpim *= a;
            }
            Console.WriteLine("Sonuç: "+carpim);
            Console.WriteLine("Sonuç: "+carpim2);
            Console.ReadLine();

        }
    }
}
