using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ellisekizinciornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] yaslar = new int[5];
            yaslar[0] = 23;
            yaslar[1] = 24;
            yaslar[2]= 25;
            yaslar[3]= 27;
            yaslar[4] = 23;
            for (int i=0;i<5;i++)
            {
                Console.WriteLine("Dizimizin "+(i+1)+".Elemanı: " + yaslar[i]);
            }
            foreach (int yas in yaslar) {
                Console.WriteLine(yas);
            }
            Console.ReadLine();
        }
    }
}
