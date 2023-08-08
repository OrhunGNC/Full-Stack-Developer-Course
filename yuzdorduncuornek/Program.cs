using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yuzdorduncuornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Yoneticiler.yazdir();
            Console.WriteLine("İsim Soyisim: "+Yoneticiler.adsoyad);
            Console.WriteLine("Yaş: "+Yoneticiler.yas);
            Console.ReadLine();
        }
    }
}
