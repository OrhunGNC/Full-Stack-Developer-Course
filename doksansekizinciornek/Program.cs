using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doksansekizinciornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            go:
            Console.WriteLine("1-Muhasebe");
            Console.WriteLine("2-Developer");
            int secim = int.Parse(Console.ReadLine());
            if (secim == 1)
            {
                MuhasebePersonelleri muhasebePersonelleri = new MuhasebePersonelleri();
                muhasebePersonelleri.Yazdir();
            }
            else if(secim==2)
            {
                Developer developer = new Developer();
                developer.Yazdir();
            }
            else
            {
                Console.WriteLine("Yanlış Seçim Yaptınız Yeniden Deneyin!\n");
                goto go;
            }
            Console.ReadLine();
        }
    }
}
