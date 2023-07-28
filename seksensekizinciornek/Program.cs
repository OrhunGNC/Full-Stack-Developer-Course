using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seksensekizinciornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-IT Personeli");
            Console.WriteLine("2-IK Personeli");
            char departman = char.Parse(Console.ReadLine());
            if (departman == '1')
            {
                Personel it = new Personel();
                Console.Write("Personel No Giriniz: ");
                it.PersonelNo = Convert.ToInt32(Console.ReadLine());
                Console.Write("Personel İsmi Giriniz: ");
                it.Name = Console.ReadLine();
                Console.Write("Personel Yaşı Giriniz: ");
                it.yas = Convert.ToInt32(Console.ReadLine());
                Console.Write("Personel Maaşı Giriniz: ");
                it.maas = Convert.ToDouble(Console.ReadLine());
                Console.Write("Prim Giriniz: ");
                it.prim = Convert.ToDouble(Console.ReadLine());
                Console.Write("Mesainiz Var mı ? ");
                it.mesaidurum = Console.ReadLine();
                Console.WriteLine("Ad Soyad: "+it.Name);
                it.yardim(it.maastutar(it.maas, it.prim, it.mesaidurum));
            }
            else
            {
                Personel ik = new Personel();
                Console.Write("Personel No Giriniz: ");
                ik.PersonelNo = Convert.ToInt32(Console.ReadLine());
                Console.Write("Personel İsmi Giriniz: ");
                ik.Name = Console.ReadLine();
                Console.Write("Personel Yaşı Giriniz: ");
                ik.yas = Convert.ToInt32(Console.ReadLine());
                Console.Write("Personel Maaşı Giriniz: ");
                ik.maas = Convert.ToDouble(Console.ReadLine());
                Console.Write("Prim Giriniz: ");
                ik.prim = Convert.ToDouble(Console.ReadLine());
                Console.Write("Mesainiz Var mı ? ");
                ik.mesaidurum = Console.ReadLine();
                Console.WriteLine("Ad Soyad: " + ik.Name);
                ik.yardim(ik.maastutar(ik.maas, ik.prim, ik.mesaidurum));
            }
            
            Console.ReadLine();
        }
    }
}
