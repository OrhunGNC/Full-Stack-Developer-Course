using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace onyedinciornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            go:
            Console.WriteLine("1-Samsung");
            Console.WriteLine("2-iPhone");
            Console.WriteLine("3-Xiaomi");
            Console.Write("Telefon Markası Seçiniz: ");
            int brand = Convert.ToInt32(Console.ReadLine());
            switch (brand)
            {
                case 1:
                    Console.WriteLine("Model Seçiniz: ");
                    Console.WriteLine("X-Galaxy");
                    Console.WriteLine("N-Note");
                    Console.WriteLine("T-Tablet");
                    char model = Convert.ToChar(Console.ReadLine());
                    switch (model)
                    {
                        case 'X':
                            Console.WriteLine("10000TL");
                            break;
                        case 'N':
                            Console.WriteLine("20000TL");
                            break;
                        case 'T':
                            Console.WriteLine("250000TL");
                            break;
                        default:
                            Console.WriteLine("Böyle Bir Model Yok.");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine();
                    break;
            }
            Console.Write("İşleme devam etmek ister misin? ");
            string process= Console.ReadLine();
            if (process=="evet"|| process == "EVET" || process == "Evet")
            {
                Console.Clear();
                goto go;
            }
            else
            {
                Console.WriteLine("Görüşmek Üzere...");
            }
            Console.ReadLine();
        }
    }
}
