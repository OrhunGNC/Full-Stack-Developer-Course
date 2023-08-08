using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yuzyedinciornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hediye hediye = new Hediye();
            hediye.add();
            hediye.delete();
            hediye.filtre();
            hediye.update();
            hediye.kampanya();
            int fiyat = 100;
            Console.WriteLine(hediye.zam(fiyat));
            Console.ReadLine();
        }
    }
}
