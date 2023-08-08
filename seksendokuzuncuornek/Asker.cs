using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seksendokuzuncuornek
{
    internal class Asker
    {
        public int askerno;
        public string adsoyad;
        public int yas;
        public string mezuniyet;
        public string memleket;
        public string meslek;
        public string donembilgisi;

        public double maashesap()
        {
            double maas;
            //Random random = new Random();
            if (mezuniyet == "lisans" || mezuniyet == "master")
            {
                maas = 5000;
                return maas;
            }
            else if (mezuniyet == "önlisans")
            {
                maas = 3000;
                return maas;
            }
            else
            {
                maas = 1500;
                return maas;
            }
        }
        public int kalangun(double maas)
        {  
            Console.WriteLine("Kaç Gün Askerlik Yapıcaksınız? ");
            int day = Convert.ToInt32(Console.ReadLine());
            if(maas<=5000 && maas>3000)
            {
                day -= 20;
                return day;
            }
            else if (maas<=3000 && maas > 1500)
            {
                day -= 15;
                return day;
            }
            else
            {
                day -= 5;
                return day;
            }
        }
        public void hesapla(double maas, int kalangun,string meslek, string donembilgisi)
        {
            if (donembilgisi=="uzun" && meslek == "mühendis")
            {
                maas +=(kalangun * maas);
                Console.WriteLine("Alacağınız Ücret: "+maas);
                Console.WriteLine("Kalan Gününüz: "+kalangun);
            }
            else if (donembilgisi == "kısa" && meslek == "mühendis")
            {
                maas += ((kalangun * maas)/2);
                Console.WriteLine("Alacağınız Ücret: " + maas);
                Console.WriteLine("Kalan Gününüz: " + kalangun);
            }
            else
            {
                Console.WriteLine("Alacağınız Ücret: " + maas);
                Console.WriteLine("Kalan Gününüz: " + kalangun);
            }
        }
        public void ekranbas()
        {
            Console.Write("İsim Soyisim Giriniz: ");
            adsoyad = Console.ReadLine();
            Console.Write("Yaş Giriniz: ");
            yas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mezuniyet Bilgisi Giriniz: ");
            mezuniyet = Console.ReadLine();
            Console.Write("Memleket Giriniz: ");
            memleket = Console.ReadLine();
            Console.Write("Meslek Giriniz: ");
            meslek = Console.ReadLine();
            Console.Write("Dönem Bilgisi Giriniz: ");
            donembilgisi = Console.ReadLine();
        }

    }

}
