using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yuzbirinciornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kardiyoloji kardiyo = new Kardiyoloji();
            //Console.WriteLine("Maaş Giriniz: ");
            //kardiyo.maas = int.Parse(Console.ReadLine());
            //Console.WriteLine("Döner Sermaye Giriniz: ");
            //kardiyo.donerSermaye = int.Parse(Console.ReadLine());
            //kardiyo.Uyari();
            //kardiyo.BasHemsire();
            //kardiyo.maas=kardiyo.Kesinti(kardiyo.maas);
            //Console.WriteLine("Yeni Maaş: "+ kardiyo.Aylik(kardiyo.maas, kardiyo.donerSermaye));

            //Ortopedi ortopedi = new Ortopedi();
            //Console.WriteLine("Maaş Giriniz: ");
            //ortopedi.maas = int.Parse(Console.ReadLine());
            //Console.WriteLine("Döner Sermaye Giriniz: ");
            //ortopedi.donerSermaye = int.Parse(Console.ReadLine());
            //ortopedi.Uyari();
            //ortopedi.BasHemsire();
            //int tutar = ortopedi.Aylik(ortopedi.maas, ortopedi.donerSermaye);
            //Console.WriteLine("Kesintili Yeni Maaşınız: " + ortopedi.Kesinti(tutar));

            Dahiliye dahiliye = new Dahiliye();
            Dahiliye dahiliye1 = new Dahiliye(30000,200);
            int tutar2= dahiliye.Aylik(dahiliye.maas, dahiliye.donerSermaye);
            Console.WriteLine("Kesintili Yeni Maaşınız: " + dahiliye.Kesinti(tutar2));
            


            int tutar3 = dahiliye1.Aylik(dahiliye1.maas, dahiliye1.donerSermaye);
            Console.WriteLine("Kesintili Yeni Maaşınız: "+dahiliye1.Kesinti(tutar3));

            Lab lab = new Lab();
            lab.labdurum = "Kan";

            Console.ReadLine();
        }
    }
}
