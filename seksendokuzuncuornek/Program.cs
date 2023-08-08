using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seksendokuzuncuornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Asker asker = new Asker();
            asker.ekranbas();
            asker.hesapla(asker.maashesap(), asker.kalangun(asker.maashesap()), asker.meslek, asker.donembilgisi);
            Console.ReadLine();
        }
    }
}
