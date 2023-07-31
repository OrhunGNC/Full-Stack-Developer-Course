using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doksanbesinciornek
{
    internal class KucukEvUrunleri:TeknolojikUrunler
    {
        public int motorgucu;
        public int bicaksayisi;
        public int takimadet;
        public int programsayisi;

        public void ProgramDurum(int bicaksayisi,int takimadet)
        {
            if (bicaksayisi>4 && bicaksayisi < 8)
            {
                takimadet += 2;
                Console.WriteLine("Takım Adet Hediye Edildi Yeni Takım Sayısı: "+takimadet);
            }
            else
            {
                Console.WriteLine("Hediye Kazanamadınız.");
            }
        }
        public void Yazdir()
        {
            motorgucu = 400;
            bicaksayisi = 6;
            takimadet = 10;
            programsayisi = 5;
            ProgramDurum(bicaksayisi, takimadet);
        }
    }
}
