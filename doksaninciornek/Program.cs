using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doksaninciornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Futbolcular futbolcu = new Futbolcular();
            futbolcu.yazdir();
            Console.ReadLine();
        }
    }
}
