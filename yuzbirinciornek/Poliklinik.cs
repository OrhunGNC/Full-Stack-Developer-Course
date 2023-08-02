using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yuzbirinciornek
{
    abstract internal class Poliklinik
    {
        int polno;
        int calisansayisi;
        string aciklama;
        public int maas;
        public int donerSermaye;
        public int PolNo { get { return polno; } set { polno = value; } }
        public int CalisanSayisi { get { return calisansayisi; } set { calisansayisi = value; } }
        public string Aciklama { get { return aciklama; } set { aciklama = value; } }

        public virtual void BasHemsire()
        {
            Console.WriteLine("Hastanemizin Baş Hemşiresi Emine Hanımdır.");
        }
        public virtual int Aylik(int maas,int donersermaye)
        {
            maas += maas * donersermaye / 100;
            return maas;
        }
        public abstract int Kesinti(int maas);
        public void Uyari()
        {
            Console.WriteLine("Çıkış Saatine Uymayanların Maaşından Kesinti Olacaktır!");
        }
    }
}
