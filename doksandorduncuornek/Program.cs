using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doksandorduncuornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-Yurt Dışı");
            Console.WriteLine("2-Yurt İçi");
            int secim = Convert.ToInt32(Console.ReadLine());
            if (secim == 1)
            {
                Yurtdisi yurtdisi = new Yurtdisi();
                yurtdisi.Yazdir();
            }
            if (secim == 2)
            {
                Yurtici yurtici = new Yurtici();
                yurtici.Yazdir();
            }
            
            Console.ReadLine();
        }
    }
}
