using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace kirkaltinciornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char harf=' ';
            string metin = "";
            while (harf != 'i')
            {
                Console.Write("Bir Harf Giriniz: ");
                harf = char.Parse(Console.ReadLine());
                if (harf == 'i')
                {
                    break;
                }
                metin += harf;
            }
            Console.WriteLine("\n"+metin);
            Console.ReadLine();
        }
    }
}
