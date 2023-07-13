using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dorduncuornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kıyafet Adı Giriniz: ");
            string clothes=Console.ReadLine();
            Console.Write("Üretici Adı Giriniz: ");
            string producer=Console.ReadLine();
            Console.Write("Cinsiyet Giriniz<E/K>: ");
            char gender=Convert.ToChar(Console.ReadLine());
            Console.Write("Fiyat Giriniz: ");
            decimal price = Convert.ToDecimal(Console.ReadLine());
            Console.Write("İndirim Tutarı Giriniz: ");
            decimal sale=Convert.ToDecimal(Console.ReadLine());
            Console.Write("KDV Oranı Giriniz: ");
            decimal kdv=Convert.ToDecimal(Console.ReadLine());
            decimal saleprice = price - (price * sale/100);
            decimal realprice = saleprice + (saleprice * kdv/100);
            Console.WriteLine("\nÜrün Adı: " + clothes);
            Console.WriteLine("Üretici Adı: " + producer);
            Console.WriteLine("Cinsiyet: " + gender);
            Console.WriteLine("Ürün Fiyatı: " + price);
            Console.WriteLine("İndirim Oranı: " + sale);
            Console.WriteLine("KDV: " + kdv);
            Console.WriteLine("Ürün Tutarı: " + realprice);
            Console.ReadLine();
        }
    }
}
