using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace altmisdokuzuncuornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] fiyat = new double[10];
            double[] yenifiyat=new double[10];
            double toplamzam = 0;
            for (int i =0;i< 10; i++)
            {
                Console.Write("Ürün Fiyatı Giriniz: ");
                double fee = int.Parse(Console.ReadLine());
                fiyat[i] = fee;
                if (fee>9 && fee<100)
                {
                    fee *= 1.2d;
                    yenifiyat[i] = fee;
                }
                else if (fee > 99 && fee<1000)
                {
                    fee *= 1.5d;
                    yenifiyat[i] = fee;
                }
                toplamzam =toplamzam+ (yenifiyat[i] - fiyat[i]);
                Console.WriteLine($"{i+1}.Ürünün Zam Miktarı: {yenifiyat[i]-fiyat[i]}");
                
            }
            Console.WriteLine("Toplam Zam Miktarı: " + toplamzam);
            Console.ReadLine();
        }
    }
}
