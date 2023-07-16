using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace onbirinciornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rastgelesayi = new Random();
            int score = rastgelesayi.Next(0, 3);
            if (score == 0)
            {
                Console.WriteLine("FB ve gs berabere kaldı");
            }
            else if (score == 1)
            {
                Console.WriteLine("FB Kazandı");
            }
            else
            {
                Console.WriteLine("Gs şike yaptı");
            }
            Console.ReadLine();
        }
    }
}
