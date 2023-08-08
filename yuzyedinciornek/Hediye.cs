using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yuzyedinciornek
{
    internal class Hediye : Iveri,IOzellik
    {
        public void add()
        {
            Console.WriteLine("Veri Eklendi");
        }

        public int cek()
        {
            return 0;
        }

        public void delete()
        {
            Console.WriteLine("Veri Silindi");
        }

        public void filtre()
        {
            Console.WriteLine("Veri Filtrelendi");
        }

        public void kampanya()
        {
            Console.WriteLine("Kampanya Uygulandı");
        }

        public void update()
        {
            Console.WriteLine("Veri Güncellendi");
        }

        public int zam(int fiyat)
        {
            return fiyat;
        }
    }
}
