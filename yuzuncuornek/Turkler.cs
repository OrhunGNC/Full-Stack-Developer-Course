using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yuzuncuornek
{
    internal class Turkler:Insanlar
    {
        public override void SelamVer()
        {
            Console.WriteLine("Merhabalar");
        }
        public override string Selam()
        {
            return "Hoşgeldiniz";
        }
    }
}
