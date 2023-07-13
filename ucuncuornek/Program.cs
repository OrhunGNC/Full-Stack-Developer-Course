using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucuncuornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adınızı Giriniz: ");
            //string adsoyad=Convert.ToString(Console.ReadLine());
            string adsoyad=Console.ReadLine();
            Console.Write("Yasinizi Giriniz: ");
            int yas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Maaşınızı Giriniz: ");
            decimal maas = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Prim Tutarınızı Giriniz: ");
            decimal prim = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Cinsiyet Giriniz<E/K>");
            char cinsiyet = Convert.ToChar(Console.ReadLine());
            decimal toplammaas = maas + prim;
            Console.WriteLine("Sayın " + adsoyad + " yasınız " + yas + " baya büyükmüş");
            Console.WriteLine("Maaşınız: " + maas);
            Console.WriteLine("Priminiz: " + prim);
            Console.WriteLine("Cinsiyetiniz: "+cinsiyet);
            Console.WriteLine("Toplam Maaşınız: "+toplammaas);
            Console.ReadLine();
        }
    }
}
