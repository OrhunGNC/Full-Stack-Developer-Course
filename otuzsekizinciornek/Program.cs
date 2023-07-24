using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace otuzsekizinciornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ürün Sayısı Giriniz: ");
            int urunsayisi = Convert.ToInt32(Console.ReadLine());
            double fiyat = 0;
            double kupon=0;
            double toplamindirim = 0;
            double toplamfiyat = 0;
            for(int i=1;i<=urunsayisi;i++)
            {
                Console.Write(i+".Ürünün Fiyatını Giriniz: ");
                fiyat=Convert.ToDouble(Console.ReadLine());
                for (int j=1;j<=3;j++)
                {
                    Console.Write(j+". İndirim Kuponu Miktarını Giriniz: ");
                    kupon=double.Parse(Console.ReadLine());
                    fiyat -= kupon;
                    toplamindirim += kupon;
                }
                toplamfiyat += fiyat;
                Console.WriteLine(i+". Ürünün kuponlar sonrası indirimli fiyatı: "+fiyat);
            }
            Console.WriteLine("Toplam İndirim: "+toplamindirim);
            Console.WriteLine("Toplam Fiyat: "+toplamfiyat);
            Console.ReadLine();
        }
    }
}
