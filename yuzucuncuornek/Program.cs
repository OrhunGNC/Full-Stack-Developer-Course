using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yuzucuncuornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alim alim = new Alim();
            alim.VeriAl();
            
            Apartman apartman = new Apartman();
            Console.WriteLine("\nBina Yılı: "+ apartman.BinaYil);
            Console.WriteLine("Bina Katı: "+apartman.BinaKat);
            Console.WriteLine("Daire Sayısı: "+apartman.DaireSayisi);
            Console.WriteLine("Isınma Tipi: "+apartman.IsitmaTip);
            Console.WriteLine("Balkon Durumu: "+apartman.BalkonDurum);

            Apartman apartman2=new Apartman(3,6,14);
            Console.WriteLine("\nBina Yılı: "+apartman2.BinaYil);
            Console.WriteLine("Bina Katı: "+apartman2.BinaKat);
            Console.WriteLine("Daire Sayısı: "+apartman2.DaireSayisi);

            Arsa arsam2 = new Arsa();
            arsam2.VeriAl();
            Console.ReadLine();
        }
    }
}
