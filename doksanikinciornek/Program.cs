using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doksanikinciornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mudurler mudur = new Mudurler();
            Calisanlar calisan=new Calisanlar();
            calisan.adsoyad = "mahmut";
            Console.WriteLine(calisan.adsoyad);
            Console.Write("Maaş Giriniz: ");
            mudur.Maas = int.Parse(Console.ReadLine());//set çalıştı
            Console.WriteLine("Maaşınız: "+mudur.Maas);//get çalıştı
            int yenimaas = mudur.Maas * 120 / 100;
            Console.WriteLine("Yeni Maaşınız: "+yenimaas);
            Console.ReadLine();
        }
    }
}
