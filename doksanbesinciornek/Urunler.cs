using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doksanbesinciornek
{
    internal class Urunler //ana class
    {
        int urunno;
        int fiyat;
        string marka;
        string model;
        string mensei;
        
        public int UrunNo
        {
            get { return urunno; }
            set { urunno = value; }
        }
        public int Fiyat
        {
            get { return fiyat; }
            set { fiyat = value; }
        }
        public string Marka
        {
            get { return marka; }
            set { marka = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public string Mensei
        {
            get { return mensei; }
            set { mensei = value; }
        }
        public void Durum()
        {
            Console.WriteLine("Ürünleriniz Bir Dahaki Ay Zamlanacak Fırsatı Kaçırmayın!");
        }
    }
}
