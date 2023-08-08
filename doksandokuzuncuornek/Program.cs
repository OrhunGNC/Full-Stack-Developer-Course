using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doksandokuzuncuornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-Kara");
            Console.WriteLine("2-Gemi");
            int cevap = int.Parse(Console.ReadLine());
            if (cevap == 1)
            {
                Kara kara = new Kara();
                kara.Yazdir();
            }
            else if (cevap == 2)
            {
                Gemi gemi = new Gemi();
                gemi.Yazdir();
            }
            Console.ReadLine();
        }
    }
}
