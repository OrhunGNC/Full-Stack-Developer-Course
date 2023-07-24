using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ellialtinciornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Metin Giriniz: ");
            string metin = Console.ReadLine();
            string rakam = "0123456789";
            string sesliharf = "aeiıuüoöAEIİOÖUÜ";
            string sessizharf = "qwrtypğsdfghjklşzxcvbnmçQWRTYPĞSDFGHJKLŞZXCVBNMÇ";
            int rakamsayac = 0;
            int seslisayac = 0;
            int sessizsayac = 0;
            int ozelsayac = 0;
            foreach(char harf in metin)
            {
                foreach(char rakamlar in rakam)
                {
                    if (harf == rakamlar)
                    {
                        rakamsayac++;
                    }

                }
                foreach (char sharf in sesliharf) { if (harf == sharf)
                    {
                        seslisayac++;
                    }
                }
                foreach (char ssizharf in sessizharf) {
                    if (harf == ssizharf)
                    {
                        sessizsayac++;
                    }
                }
                
            }
            ozelsayac=metin.Length- (sessizsayac + seslisayac + rakamsayac);
            Console.WriteLine("Metin Uzunluğu: "+metin.Length);
            Console.WriteLine("Sesli Harfler: "+seslisayac);
            Console.WriteLine("Sessiz Harfler: "+sessizsayac);
            Console.WriteLine("Rakamlar: "+rakamsayac);
            Console.WriteLine("Özel Karakterler: "+ozelsayac);
            Console.ReadLine();
        }
    }
}
