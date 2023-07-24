using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yetmisaltinciornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tutar = tutarhesapla(400, 26);
            Console.WriteLine("Tutar: "+tutar);
            Console.ReadLine();
        }
        static double tutarhesapla(double para,double doviz)
        {
            para *= doviz;
            return para;
        }
    }
}
