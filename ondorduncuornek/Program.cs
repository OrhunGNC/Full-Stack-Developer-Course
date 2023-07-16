using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ondorduncuornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(sayi);
            }
            catch
            {
                Console.WriteLine("Sayı Giriniz!");
            }
            
            Console.ReadLine();
        }
    }
}
