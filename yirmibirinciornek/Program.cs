using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yirmibirinciornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            for(int i = 1; i <= 5; i++)
            {
                Console.Write(i+".Sayı Giriniz: ");
                int number = Convert.ToInt32(Console.ReadLine());
                toplam += number;
            }
            Console.WriteLine("Toplam: "+toplam);
            Console.ReadLine();
        }
    }
}
