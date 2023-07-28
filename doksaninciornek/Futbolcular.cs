using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doksaninciornek
{
    internal class Futbolcular
    {
        public string adsoyad;
        public int formano;
        public string mevki;
        public double bonservis;
        public string memleket;
        public string takım;
        public int yas;
        public string durum;
        public void Menu()
        {
            Console.Write("Ad Soyad: ");
            adsoyad = Console.ReadLine();
            Console.Write("Forma No: ");
            formano = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mevki: ");
            mevki = Console.ReadLine();
            Console.Write("Bonservis: ");
            bonservis = Convert.ToDouble(Console.ReadLine());
            Console.Write("Memleketi: ");
            memleket = Console.ReadLine();
            Console.Write("Oynadığı Takım: ");
            takım = Console.ReadLine();
            Console.Write("Yaş: ");
            yas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Maç Sonucu: ");
            durum = Console.ReadLine();
        }
        public void yazdir()
        {
            Menu();
            Console.WriteLine("\n"+"Bonservis Bedeli: "+bonservis);
            Console.WriteLine("Oynadığı Takım: "+takım);
        }

    }

}
