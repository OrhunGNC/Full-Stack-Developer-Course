using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ellidokuzuncuornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kaç Eleman Olsun: ");
            int eleman = int.Parse(Console.ReadLine());
            int[] sayilar = new int[eleman];
            for(int i=0;i<sayilar.Length;i++)
            {
                Console.Write(i+1+".Sayıyı Giriniz: ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int j=0;j<sayilar.Length;j++)
            {
                Console.WriteLine(j+1+".Elemanın Değeri: " + sayilar[j]);
            }
            Console.ReadLine();
        }
    }
}
