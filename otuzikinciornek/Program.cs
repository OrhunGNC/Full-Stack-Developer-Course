using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otuzikinciornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double komisyon = 0 ;
            double toplam = 0;
            int i;
            for (i = 1; i <= 5; i++)
            {
                Console.Write(i+".Ürünün Fiyatını Giriniz: ");
                double price = double.Parse(Console.ReadLine());
                if (price < 50)
                {
                    komisyon = 0.03;
                    Console.WriteLine("\n" + i + ".Üründen alınan komisyon= " + komisyon*price + "\n");
                    toplam += (komisyon * price);
                    
                }
                else if (price >= 50)
                {
                    komisyon = 0.02;
                    Console.WriteLine("\n" + i + ".Üründen alınan komisyon= " + komisyon * price + "\n");
                    toplam += (komisyon * price);
                }
            }
            Console.WriteLine("Satıcının Aldığı Toplam Komisyon: " + toplam);
            Console.ReadLine();
        }
    }
}
