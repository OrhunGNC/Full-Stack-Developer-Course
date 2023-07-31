using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doksandokuzuncuornek
{
    abstract internal class Ulasim
    {
        public int ulasimno;
        public int biletfiyat;
        public int adet;
        public string guzergah;
        public string gorevlikisi;

        public abstract int Zam(int biletfiyat);
        public abstract int Indirim(string guzergah, int adet, int fiyat);
    }
}
