using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yirmiikinciornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            go:
            int n;
            double carpim = 1;
            Console.Write("Başlangıç Değerini Giriniz: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kaç Sayı ile Çalışacaksınız? ");
            n = Convert.ToInt32(Console.ReadLine());
            if (a > n)
            {
                Console.WriteLine("Başlangıç Sayısı Daha Büyük Olamaz!");
                goto go;
            }
            for (int i=a; i <= n; i++)
            {
                Console.Write(i+".Değeri Giriniz: ");
                double number = Convert.ToInt32(Console.ReadLine());
                carpim = carpim* number;
            }
            Console.WriteLine("Çarpım: "+carpim);
            Console.ReadLine();
        }
    }
}
