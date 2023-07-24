using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yirmibesinciornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir Sayı Giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int i;
            int carpim = 1;
            for (i = 1; i <= n; i++)
            {
                carpim *= i;
            }
            Console.WriteLine("Girilen sayının faktöriyeli: "+carpim);
            Console.ReadLine();
        }
    }
}
