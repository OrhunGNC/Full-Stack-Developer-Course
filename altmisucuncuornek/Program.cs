using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace altmisucuncuornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] sayilar = new double[6];
            for (int i=0;i < sayilar.Length; i++)
            {
                sayilar[i] = Math.Pow(i,2);
            }
            for (int j=0;j < sayilar.Length; j++)
            {
                Console.WriteLine(sayilar[j]);
            }
            Console.ReadLine();
        }
    }
}
