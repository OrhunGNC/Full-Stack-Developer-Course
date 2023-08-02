using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yuzbirinciornek
{
    internal class Kardiyoloji : Poliklinik
    {
        public override int Kesinti(int maas)
        {
            maas -= maas * 10 / 100;
            return maas;
        }
        public override int Aylik(int maas, int donersermaye)
        {
            maas += maas * donersermaye / 100;
            maas += 1000;
            return maas;
        }
        public override void BasHemsire()
        {
            Console.WriteLine("Kardiyoloji Bölümü Hemşiresi Seyfettin Beydir.");
        }
    }
}
