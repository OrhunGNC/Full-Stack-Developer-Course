using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otuzdorduncuornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir metin giriniz: ");
            string metin = Console.ReadLine();
            for (int i=metin.Length-1; i>=0; i--)
            {
                Console.Write(metin[i]);
            }
            Console.WriteLine("");
            for (int j=0;j<=metin.Length-1; j++)
            {
                Console.Write(metin[j]);
            }
            Console.ReadLine();
        }
    }
}
