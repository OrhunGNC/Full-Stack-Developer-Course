using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yuzuncuornek
{
    internal class Fransizlar:Insanlar
    {
        public override void SelamVer()
        {
            Console.WriteLine("Bonjour");
        }
        public override string Selam()
        {
            return "Bienvenue";
        }
    }
}
