using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace altmisaltinciornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[1000];
            int psayac = 0;
            int nsayac = 0;
            int notrsayac = 0;
            Random random = new Random();
            for (int i = 0; i < 1000; i++)
            {
                //Console.Write("Sayı Giriniz: ");
                //int sayi = Convert.ToInt32(Console.ReadLine());
                int sayi = random.Next(-1000, 1000);
                sayilar[i] = sayi;
            }
            foreach(int sayis in sayilar)
            {
                if (sayis > 0)
                {
                    psayac++;
                }
                else if (sayis < 0)
                {
                    nsayac++;
                }
                else
                {
                    notrsayac++;
                }
            }
            Console.WriteLine("Pozitif Sayıların Adedi: "+psayac);
            Console.WriteLine("Negatif Sayıların Adedi: "+nsayac);
            Console.WriteLine("Notr Sayıların Adedi: "+notrsayac);
            Console.ReadLine();
        }
    }
}
