using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yuzucuncuornek
{
    sealed internal class Arsa : Emlak
    {
        string tapudurum;
        int parselno;
        public string TapuDurum { get { return tapudurum; } set { tapudurum = value; } }
        public int ParselNo { get { return parselno; } set {parselno=value; } }
        public override void Hesapla(string alimdurum)
        {
            
        }

        public override void VeriAl()
        {
            Console.WriteLine("Tapu Durumu Nedir? ");
            TapuDurum = Console.ReadLine();
            Console.WriteLine("Parsel No Nedir? ");
            ParselNo = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nTapu Durumu: {TapuDurum} \nParsel No: {ParselNo}");
        }
    }
}
