using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace seksensekizinciornek
{
    internal class Personel
    {
        public int PersonelNo;
        public string Name;
        public int yas;
        public double maas;
        public double prim;
        public string mesaidurum;

        public double maastutar(double maas, double prim, string mesaidurum)
        {
            if(mesaidurum == "var")
            {
                maas *= prim;
                return maas;
            }
            else
            {
                maas += prim;
                return maas;
            }
        }
        public void yardim(double maas)
        {
            Console.Write("Evli misiniz Bekar mı? ");
            string medenidurum = Console.ReadLine();
            if(medenidurum == "evet")
            {
                maas += 1000;
                Console.WriteLine("Agi Tutat: "+maas);
            }
            else
            {
                Console.WriteLine("Maaş: "+maas);
            }
        }
    }
}
