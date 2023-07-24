using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kirkikinciornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Aylık Kiranız Ne Kadar? ");
            float kira = float.Parse(Console.ReadLine());
            Console.Write("\n" + "Kira Sözleşmenizin Başlangıç Yılı Nedir? ");
            float yil = float.Parse(Console.ReadLine());
            Console.Write("\n" + "Kira Sözleşmenizin Bitiş Yılı Nedir? ");
            float bitisyil = float.Parse(Console.ReadLine());
            float toplamkira = kira*12;
            while (yil <= bitisyil)
            {
                kira *= 1.25f;
                toplamkira += kira*12;
                yil++;
            }
            Console.WriteLine("\n" + "Sözleşme Sonundaki Kiranız: " +kira);
            Console.WriteLine("\n" + "Şu Ana Kadar Ödediğiniz Kira Miktarı: "+toplamkira);
            Console.ReadLine();
        }
    }
}
