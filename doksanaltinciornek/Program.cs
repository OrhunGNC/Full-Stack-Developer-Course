using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doksanaltinciornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ErkekGiyim erkek=new ErkekGiyim();
            ErkekCocukGiyim erkekcocuk = new ErkekCocukGiyim();
            erkekcocuk.ErkekCocuk();
            Console.ReadLine();
        }
    }
}
