using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seksenyedinciornek
{
    internal class ElektronikEsya
    {
        public string marka;
        public string model;
        public int fiyat;
        public int yil;
        public string mensei;
        public int kdv(int fiyat)
        {
            fiyat += fiyat * 20/100;
            return fiyat;
        }
        public void hediye()
        {
            Console.WriteLine("Tebrikler Bir Dahaki ALışverişte Kargo Bedava...");
        }
    }
}
