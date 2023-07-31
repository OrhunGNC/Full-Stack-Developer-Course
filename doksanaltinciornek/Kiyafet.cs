using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace doksanaltinciornek
{
    internal class Kiyafet
    {
        public int kiyafetno;
        public string kiyafetisim;
        public int beden;
        public int olcu;
        public string marka;
        public string renk;
        public int fiyat;
        public int Zam(string marka,int fiyat)
        {
            if (marka == "Zara")
            {
                fiyat += (fiyat * 20 / 100);
                return fiyat;
            }
            else
            {
                return fiyat;
            }
        }
        public void VeriAl()
        {
            Console.WriteLine("Kıyafet No Giriniz: ");
            kiyafetno = int.Parse(Console.ReadLine());

            Console.WriteLine("Kıyafet Adı Giriniz: ");
            kiyafetisim = Console.ReadLine();

            Console.WriteLine("Beden Giriniz: ");
            beden = int.Parse(Console.ReadLine());

            Console.WriteLine("Ölçü Giriniz: ");
            olcu=int.Parse(Console.ReadLine());

            Console.WriteLine("Marka Giriniz: ");
            marka = Console.ReadLine();

            Console.WriteLine("Renk Giriniz: ");
            renk = Console.ReadLine();

            Console.WriteLine("Fiyat Giriniz: ");
            fiyat = int.Parse(Console.ReadLine());
        }
        public void Yazdir()
        {
            VeriAl();
            Console.WriteLine("Kıyafet No: "+kiyafetno);
            Console.WriteLine("Kıyafet Adı: "+kiyafetisim);
            Console.WriteLine("Beden: "+beden);
            Console.WriteLine("Ölçü: "+olcu);
            Console.WriteLine("Marka: "+marka);
            Console.WriteLine("Renk: "+renk);
            Console.WriteLine("Fiyat: "+fiyat);
        }
    }
}
