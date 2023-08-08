using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yuzucuncuornek
{
    internal class Apartman : Emlak
    {
        private int binayil;
        private int binakat;
        private int dairesayisi;
        private string isitmatip;
        private string balkondurum;
        public int BinaYil{ get { return binayil; } set { binayil = value; } }
        public int BinaKat { get { return binakat; } set { binakat = value; } }
        public int DaireSayisi { get { return dairesayisi; } set { dairesayisi = value; } }
        public string IsitmaTip { get { return isitmatip; } set { isitmatip = value; } }
        public string BalkonDurum { get { return balkondurum; } set { balkondurum = value; } }
        public Apartman()
        {
            BinaYil = 30;
            BinaKat = 8;
            DaireSayisi = 18;
            IsitmaTip = "doğalgaz";
            BalkonDurum = "Salona Bağlı";
        }
        public Apartman(int binayil, int binakat,int dairesayisi)
        {
            this.BinaYil = binayil;
            this.BinaKat = binakat;
            this.DaireSayisi= dairesayisi;
        }
        public override void Hesapla(string alimdurum)
        {
            
        }

        public override void VeriAl()
        {
            
        }
    }
}
