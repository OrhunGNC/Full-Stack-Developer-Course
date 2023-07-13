using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace besinciornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sigorta Prim Gün Sayısı Giriniz: ");
            int primday = Convert.ToInt32(Console.ReadLine());
            if (primday>=7200)
            {
                Console.WriteLine("Tebrikler Emekli Oldunuz.");
            }
            else
            {
                Console.WriteLine("Prim Gün Sayısını Doldurunuz.");
                int kalanday = 7200 - primday;
                Console.WriteLine("Emekli olmanıza " + kalanday + " gününüz kalmıştır.");
            }
            Console.WriteLine("Yine Bekleriz...");
            Console.ReadLine();
        }
    }
}
