using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ellibirinciornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kad;
            string sifre;
            do
            {
                Console.Write("Kullanıcı Adı Giriniz: ");
                kad = Console.ReadLine();
                Console.Write("Şifre Giriniz: ");
                sifre = Console.ReadLine();

            }
            while (kad != "admin" || sifre != "1234");
            Console.WriteLine("İşlem Başarılı Hoşgeldiniz.");
            Console.ReadLine();
        }
    }
}
