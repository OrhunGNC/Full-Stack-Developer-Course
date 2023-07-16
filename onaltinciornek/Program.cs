 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onaltinciornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dört Elementi Giriniz: ");
            string element = Console.ReadLine();
            switch (element)
            {
                case "ateş":
                    Console.WriteLine("Berke,Anıl,Zeynep,Onur");
                    break;
                case "toprak":
                    Console.WriteLine("Elif,Orhun");
                    break;
                case "su":
                    Console.WriteLine("Esma,Şahin,Alp");
                    break;
                case "hava":
                    Console.WriteLine("Telet,Buğra");
                    break;
                default:
                    Console.WriteLine("Başka Element Yok.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
