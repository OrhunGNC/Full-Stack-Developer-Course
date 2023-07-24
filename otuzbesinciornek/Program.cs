using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otuzbesinciornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir metin giriniz: ");
            string metin = Console.ReadLine();
            for (int i =0; i <= metin.Length-1; i++)
            {
                if (i == (metin.Length - 1))
                {
                    Console.WriteLine(metin[i]);
                }
                else
                {
                    Console.Write(metin[i] + "-");
                }
            }
            Console.ReadLine();
        }
    }
}
