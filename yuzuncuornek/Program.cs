using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yuzuncuornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-Türkler");
            Console.WriteLine("2-Fransızlar");
            Console.WriteLine("3-İngilizler");
            int secim = int.Parse(Console.ReadLine());
            if (secim == 1)
            {
                Turkler turk = new Turkler();
                turk.SelamVer();
                Console.WriteLine(turk.Selam());
            }
            else if (secim == 2)
            {
                Fransizlar fransiz = new Fransizlar();
                fransiz.SelamVer();
                Console.WriteLine(fransiz.Selam());
            }
            else if (secim==3)
            {
                Ingilizler ingiliz = new Ingilizler();
                ingiliz.SelamVer();
            }
            else
            {
                Console.WriteLine("Öyle Bir Seçenek Yok");
            }
            Console.ReadLine();
        }
    }
}
