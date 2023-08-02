using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yuzikinciornek
{
    internal class Magaza
    {
        private int magazano;
        string magazaadi;
        string magazatip;

        public Magaza()
        {
            magazano = 758;
            magazaadi = "Zara Şişli Merkez Şube";
            magazatip = "Çocuk Giyim";
        }
        public Magaza(int magazano, string magazaadi,string magazatip)
        {
            this .magazano = magazano;
            this .magazaadi = magazaadi;
            this .magazatip = magazatip;
        }
        public Magaza(int magazano, string magazaadi)
        {
            this.magazano = magazano;
            this.magazaadi = magazaadi;
        }

        public int MagazaNo { get { return magazano; } set { if (value == 1234) { magazano = value; } else { Console.WriteLine("Yanlış İşlem"); } } }
        public string MagazaAdi { get { return magazaadi; } set { if (value == "Zara") { magazaadi = value; } else { Console.WriteLine("Yanlış Mağaza Adı"); } } }
        public string MagazaTip { get { return magazatip; } set { magazatip = value; } } 

    }
}
