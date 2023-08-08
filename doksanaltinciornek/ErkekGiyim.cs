using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doksanaltinciornek
{
    internal class ErkekGiyim:Kiyafet
    {
        public string takimDurum;
        public int takimfiyat;
        public string aksesuar;//kravat,papyon,saat

        public void Erkek()
        {
            Yazdir();
            takimfiyat = 1000;
            takimDurum = "takim";
            aksesuar = "kravat";
            Console.WriteLine("Ödemeniz Gereken Tutar:"+(Zam(marka, fiyat)+takimfiyat));
        }
    }
}
