using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace doksanikinciornek
{
    class Mudurler
    {
        private int maas;
        private string unvan;
        private string pozisyon;
        public int Maas
        {
            set {if (value > 50000 && value < 100000)
                {
                    maas = value;
                }
                else { Console.WriteLine("Hatalı Giriş!"); }
            }//atama
            get { return maas; }//okuma
        }
    }
}
