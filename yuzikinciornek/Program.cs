using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yuzikinciornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Magaza magaza = new Magaza();
            Console.WriteLine("Mağaza No Giriniz: ");
            magaza.MagazaNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Mağaza Adı Giriniz: ");
            magaza.MagazaAdi = Console.ReadLine();
            Console.WriteLine("Mağaza Tipi Giriniz: ");
            magaza.MagazaTip = Console.ReadLine();
            Console.WriteLine($"\n{magaza.MagazaNo}\n{magaza.MagazaAdi}\n{magaza.MagazaTip}");

            Magaza magaza1 = new Magaza(20,"koton","kadin giyim");
            Console.WriteLine("\nMağaza No Giriniz: ");
            magaza1.MagazaNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Mağaza Adı Giriniz: ");
            magaza1.MagazaAdi = Console.ReadLine();
            Console.WriteLine("Mağaza Tipi Giriniz: ");
            magaza1.MagazaTip = Console.ReadLine();
            Console.WriteLine($"\n{magaza1.MagazaNo}\n{magaza1.MagazaAdi}\n{magaza1.MagazaTip}");

            Console.ReadLine();
            

        }
    }
}
