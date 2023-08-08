using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yuzsekizinciornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SporSalonu spor = new SporSalonu();
            spor.UyeKontrol();
            Console.WriteLine("\nKaç Aylık Üyelik Seçtiniz? ");
            int ay = int.Parse(Console.ReadLine());
            Console.WriteLine("\nFiyat Giriniz: ");
            int fiyat = int.Parse(Console.ReadLine());
            Console.WriteLine("\nYeni Aidatınız: "+spor.Aidat(ay, fiyat));
            fiyat = spor.Aidat(ay, fiyat);
            fiyat = spor.Zam(fiyat);
            Console.WriteLine("\nZamlı Ödeyeceğiniz Tutar: "+ fiyat);
            spor.kampanya(fiyat);
            spor.Hizmetler(fiyat);
            CocukSalonu cocuk = new CocukSalonu();
            cocuk.Uyarı();
            Console.ReadLine();
        }
    }
}
