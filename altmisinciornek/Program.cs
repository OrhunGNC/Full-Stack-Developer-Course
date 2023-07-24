using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace altmisinciornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kaç Eleman Olsun: ");
            int eleman = int.Parse(Console.ReadLine());
            string[] isimler = new string[eleman];
            for (int i = 0; i < isimler.Length; i++)
            {
                Console.Write(i + 1 + ".İsmi Giriniz: ");
                isimler[i] = Console.ReadLine();
            }
            for (int j = 0; j < isimler.Length; j++)
            {
                Console.WriteLine(j + 1 + ".İsim: " + isimler[j]);
            }
            Console.ReadLine();
        }
    }
}