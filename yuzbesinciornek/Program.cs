using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yuzbesinciornek
{
    internal class Program
    {
        enum Gunler
        {
            pazartesi,
            sali,
            carsamba
        }
        static void Main(string[] args)
        {
            int a = (int)Gunler.pazartesi;
            Console.WriteLine(Gunler.pazartesi+" haftanın " +((int)Gunler.sali+1)+".günüdür");
            Console.ReadLine();
        }
    }
}
