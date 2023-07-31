using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doksansekizinciornek
{
    internal class Developer : Personeller
    {
        public string gorevtip;
        public string gorevtanimi;
        public string mesaitip;
        public override double EnflasyonFark(double maas)
        {
            Console.WriteLine("Enflasyon Farkı Ne Kadar? ");
            double enfark = double.Parse(Console.ReadLine());
            maas += maas * (enfark / 100);
            return maas;
        }
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
            Console.WriteLine("Görev Tipinizi Giriniz: ");
            gorevtip = Console.ReadLine();
            Console.WriteLine("Görev Tanımınızı Giriniz: ");
            gorevtanimi = Console.ReadLine();
            Console.WriteLine("Mesai Tipinizi Giriniz: ");
            mesaitip = Console.ReadLine();
        }
        public double Vergilendirme(double maas,string mesaitip)
        {
            if (mesaitip == "freelance")
            {
                maas -= maas * 30 / 100;
            }
            else
            {
                maas -= maas * 10 / 100;
            }
            return maas;
        }

        public override double MaasZam(double maas, int calismayil)
        {
            if (maas > 50000 && calismayil > 5)
            {
                maas += maas * 60 / 100;
            }
            else
            {
                maas += maas * 30 / 100;
            }
            return maas;
        }
        public void Yazdir()
        {
            VeriAl();
            Console.WriteLine("\nZamlı Maaşınız: " + MaasZam(maas, calismayil));
            double enflasyonlumaas = EnflasyonFark(maas);
            Console.WriteLine("Enflasyon Farkından Doğan Zamlı Maaşınız: " + enflasyonlumaas);
            Console.WriteLine("Mesai Tipinize Bağlı Vergilendirme Sonrası Maaşınız: "+Vergilendirme(enflasyonlumaas, mesaitip));
        }
    }
}
