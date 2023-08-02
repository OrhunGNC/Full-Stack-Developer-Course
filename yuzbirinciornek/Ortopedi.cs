using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yuzbirinciornek
{
    internal class Ortopedi : Poliklinik
    {
        public override int Kesinti(int maas)
        {
            maas -= maas * 20 / 100;
            return maas;
        }
        public override int Aylik(int maas, int donersermaye)
        {
            maas += maas * donersermaye * 3 / 100;
            return maas;
        }
        public override void BasHemsire()
        {
            Console.WriteLine("Ortopedi Bölümünün Baş Hemşiresi Mehmet Beydir.");
        }
    }
}
