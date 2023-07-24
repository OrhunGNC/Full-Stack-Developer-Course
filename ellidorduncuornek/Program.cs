using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ellidorduncuornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kelime = "abdfpgfe";
            string sayi = "41321541212";
            foreach (char harf in kelime) {
                Console.WriteLine(harf);
            }
            foreach (char rakam in sayi)
            {
                Console.WriteLine(rakam);
            }
            Console.ReadLine();
        }
    }
}
