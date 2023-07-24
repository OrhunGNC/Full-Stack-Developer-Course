using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace ellibesinciornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayac=0;
            string sesliharf = "aeiıoöuü";
            string metin = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";
            foreach(char harf in metin)
            {
                foreach(char sharf in sesliharf)
                {
                    if (sharf == harf)
                    {
                        sayac++;
                    }
                }
            }
            Console.WriteLine("Metin Uzunluğu: "+metin.Length);
            Console.WriteLine("Metin İçerisindeki Sesli Harf Sayısı: "+sayac);
            Console.ReadLine();
        }
    }
}
