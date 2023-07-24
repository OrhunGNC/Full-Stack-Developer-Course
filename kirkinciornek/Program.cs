using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kirkinciornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i+1+".Tekrar");
                i++;
            }
            Console.ReadLine();
        }
    }
}
