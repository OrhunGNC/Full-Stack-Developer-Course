using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doksanaltinciornek
{
    internal class ErkekCocukGiyim:ErkekGiyim
    {
        public int yas;
        public string kumasturu;

        public void ErkekCocuk()
        {
            Yazdir();
            yas = 10;
            kumasturu = "pamuk";
            aksesuar = "Papyon";
            Console.WriteLine("Yaş: "+yas);
            Console.WriteLine("Kumaş Türü: "+kumasturu);
            Console.WriteLine("Aksesuar: "+aksesuar);
            Console.WriteLine("Son Ödemeniz Gereken Tutar: " + Zam(marka, fiyat));
        }
    }
}
