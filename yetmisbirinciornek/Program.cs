using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yetmisbirinciornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] metin = new string[5];
            string enuzun="";
            int sayac = 0;
            for (int i =0;i < metin.Length;i++)
            {
                Console.Write("Bir Metin Giriniz: ");
                string metin2 = Console.ReadLine();
                metin[i] = metin2;
                if (enuzun.Length < metin[i].Length)
                {
                   enuzun = metin[i];
                    sayac = i;
                }

            }
            Console.WriteLine("\nEn Uzun Metin: "+enuzun);
            Console.WriteLine("En Uzun Metnin Harf Sayısı: "+enuzun.Length);
            Console.WriteLine("En Uzun Metin Dizinin "+(sayac+1)+".Elemanı");
            Console.ReadLine();
        }
    }
}
