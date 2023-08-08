using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doksanyedinciornek
{
    internal class Ayakkabi
    {
        public int ayakkabino;
        public string marka;
        public string model;
        public int fiyat;
        public string tip;
        public string malzemeturu;

        public void VeriAl()
        {
            Console.WriteLine("Ayakkabı No Giriniz: ");
            ayakkabino = int.Parse(Console.ReadLine());
            Console.WriteLine("Marka Giriniz: ");
            marka = Console.ReadLine();
            Console.WriteLine("Model Giriniz: ");
            model= Console.ReadLine();
            Console.WriteLine("Fiyat Giriniz: ");
            fiyat = int.Parse(Console.ReadLine());
            Console.WriteLine("Tip Seçiniz: ");
            tip = Console.ReadLine();
            Console.WriteLine("Malzeme Türü Seçiniz: ");
            malzemeturu = Console.ReadLine();
        }
        public void Yazdir()
        {
            Console.WriteLine("\nAyakkabı No: "+ayakkabino);
            Console.WriteLine("Marka: "+marka);
            Console.WriteLine("Model: "+model);
            Console.WriteLine("Fiyat: "+fiyat);
            Console.WriteLine("Tip: "+tip);
            Console.WriteLine("Malzeme Türü: "+malzemeturu);
        }
        public int Kdv(int fiyat)
        {
            fiyat += (fiyat * 20 / 100);
            return fiyat;
        }
    }
}
