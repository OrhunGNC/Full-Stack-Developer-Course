using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace doksansekizinciornek
{
    internal class MuhasebePersonelleri : Personeller
    {
        public int izinsayisi;
        public int prim;
        public void VeriAl()
        {
            Console.Write("Ad Soyad Giriniz: ");
            adsoyad = Console.ReadLine();
            Console.Write("Yaşınızı Giriniz: ");
            yas = int.Parse(Console.ReadLine());
            Console.Write("Maaşınızı Giriniz: ");
            maas = double.Parse(Console.ReadLine());
            Console.WriteLine("Çalışma Yılınızı Giriniz: ");
            calismayil = int.Parse(Console.ReadLine());
            Console.WriteLine("Cinsiyetinizi Giriniz: ");
            cinsiyet = Console.ReadLine();
            Console.WriteLine("İzin Sayinizi Giriniz: ");
            izinsayisi=int.Parse(Console.ReadLine());
            Console.WriteLine("Prim Giriniz: ");
            prim = int.Parse(Console.ReadLine());
        }
        public void Yazdir()
        {
            VeriAl();
            Console.WriteLine("\nZamlı Maaşınız: "+MaasZam(maas,calismayil));
            double sonmaas = EnflasyonFark(maas);
            Console.WriteLine("Enflasyon Farkından Doğan Zamlı Maaşınız: " + sonmaas);
            Console.WriteLine("Prim Dahil Edilidiğindeki Son Maaşınız: "+(sonmaas+prim));
        }

        public override double EnflasyonFark(double maas)
        {
            Console.WriteLine("Enflasyon Farkı Ne Kadar? ");
            double enfark = double.Parse(Console.ReadLine());
            maas += maas * enfark / 100;
            return maas;
        }

        public override double MaasZam(double maas, int calismayil)
        {
            if (maas > 11000 && calismayil > 5)
            {
                maas += maas * 35 / 100;
            }
            else
            {
                maas += maas * 20 / 100;
            }
            return maas;
        }
    }
}
