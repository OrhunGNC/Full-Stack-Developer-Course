using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otuzucuncuornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int number;
            int carpim = 1;
            Console.Write("Son Sayıyı Giriniz: ");
            number = int.Parse(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                carpim = i * number;
                Console.WriteLine($"{i} x {number} = {carpim}");

            }
            Console.ReadLine();
        }
    }
}
