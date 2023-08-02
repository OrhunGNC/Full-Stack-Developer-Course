using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yuzucuncuornek
{
    abstract internal class Emlak
    {
        string yapidurum;
        string belgead;
        string belgeno;
        string emlakcins;
        string bolgesorumlusu;
        string alimdurum;
        int komisyon;
        int fiyat;
        int sozlesmeyil;
        int yillikkira;
        public string YapiDurum { get { return yapidurum; } set { if (value == "bag"&&value=="arazi"&&value=="tarla") { yapidurum = value; } } }
        public string BelgeAd { get { return belgead; } set { belgead = value; } }
        public string BelgeNo { get { return belgeno; } set { if (value.Length == 5) { belgeno = value; } } }
        public string EmlakCins { get { return emlakcins; } set { emlakcins = value; } }
        public string BolgeSorumlusu { get { return bolgesorumlusu; } set { bolgesorumlusu = value; } }
        public string AlimDurum { get { return alimdurum; } set { alimdurum = value; } }
        public int Komisyon { get { return komisyon; } set { komisyon= value; } }
        public int Fiyat { get { return fiyat; } set { fiyat = value; } }
        public int SozlesmeYil { get { return sozlesmeyil; } set { sozlesmeyil = value; } }
        public int YillikKira { get { return yillikkira; } set { yillikkira = value; } }

        public abstract void VeriAl();
        public abstract void Hesapla(string alimdurum);
        public virtual void KomisyonHesap(string emlakcinsi,int fiyat,int sozlesmeyil,int yillikkira,int komisyon)
        {

        }
    }
}
