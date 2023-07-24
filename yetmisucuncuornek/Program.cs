using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace yetmisucuncuornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int toplam = a * zam();
            Console.WriteLine(toplam);
            Console.ReadLine();
        }
        static int zam()
        {
            return 100;
        }
    }
}
