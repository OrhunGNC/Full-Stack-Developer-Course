using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otuzbirinciornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bakteri = 1;
            Console.Write("Dakika Giriniz: ");
            int dakika = Convert.ToInt32(Console.ReadLine());
            for (int i = 4; i <= dakika; i+=4)
            {
                bakteri =bakteri * 2;
            }
            Console.WriteLine("1 Saat sonunda oluşan bakteri sayısı: "+bakteri);
            Console.ReadLine();
        }
    }
}
