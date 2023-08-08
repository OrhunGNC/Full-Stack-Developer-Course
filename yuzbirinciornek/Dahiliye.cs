using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yuzbirinciornek
{
    internal class Dahiliye : Poliklinik
    {
        public Dahiliye()
        {
            maas = 25000;
            donerSermaye = 100;
        }
        public Dahiliye(int maas,int donerSermaye)
        {
            this.maas = maas;
            this.donerSermaye = donerSermaye;
        }
        ~Dahiliye()
        {
            Console.WriteLine("Yıkıcı Metot Çalıştı Nesne Silindi");
            Console.ReadLine();
        }
        public override int Kesinti(int maas)
        {
            maas -= maas * 30 / 100;
            return maas;
        }
    }
}
