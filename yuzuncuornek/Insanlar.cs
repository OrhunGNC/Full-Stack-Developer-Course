using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yuzuncuornek
{
    internal class Insanlar
    {
        public string adsoyad;
        public int yas;

        //polymorphism method tanımlama
        
        public virtual void SelamVer()
        {
            Console.WriteLine("Hello");
        }
        public virtual string Selam()
        {
            return "welcome";
        }
    }
}
