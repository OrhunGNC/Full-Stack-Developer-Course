using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace dokuzuncuornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            go:
            Console.Write("Kullanıcı Adı Giriniz: ");
            string nickname = Console.ReadLine();
            if (nickname == "admin" || nickname == "ADMIN" || nickname == "Admin")
            {
                Console.WriteLine("Hoşgeldiniz " + nickname);
                gopassword:
                Console.Write("Şifre Giriniz: ");
                string password = Console.ReadLine();
                if (password == "Aa123")
                {
                    Console.WriteLine("Başarılı Bir Şekilde Giriş Yaptınız.");
                }
                else
                {
                    Console.WriteLine("Yanlış Şifre Tekrar Deneyiniz!");
                    Console.Write("İşleme Devam Etmek İstiyor musun? ");
                    bool islem = Convert.ToBoolean(Console.ReadLine());
                    if (islem == true)
                    {
                        Console.Clear();
                        goto gopassword;
                    }
                    else
                    {
                        Console.WriteLine("İyi Günler");
                    }
                }
            }
            else
            {
                Console.WriteLine("Kullanıcı Adı Yanlış Tekrar Dene!");
                Console.Write("İşleme Devam Etmek İstiyor musun? ");
                bool islem = Convert.ToBoolean(Console.ReadLine());
                if (islem == true)
                {
                    Console.Clear();
                    goto go;
                }
                else
                {
                    Console.WriteLine("İyi Günler");
                }
            }
            //while (true)
            //{
            //    Console.Write("Kullanıcı Adı Giriniz: ");
            //    string nickname = Console.ReadLine();
            //    if (nickname == "admin" || nickname == "ADMIN" || nickname == "Admin")
            //    {
            //        Console.WriteLine("Hoşgeldiniz " + nickname);
            //        Console.Write("Şifre Giriniz: ");
            //        string password = Console.ReadLine();
            //        if (password == "Aa123")
            //        {
            //            Console.WriteLine("Başarılı Bir Şekilde Giriş Yaptınız.");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Yanlış Şifre Tekrar Deneyiniz!");
            //            continue;
            //        }

            //    }
            //    else
            //    {
            //        Console.WriteLine("Kullanıcı Adı Yanlış Tekrar Dene!");
            //        Console.Write("İşleme Devam Etmek İstiyor musun? ");
            //        bool islem = Convert.ToBoolean(Console.ReadLine());
            //        if (islem == true)
            //        {
            //            continue;
            //        }
            //        else
            //        {
            //            Console.WriteLine("İyi Günler");
            //        }
            //    }
            //}

            Console.ReadLine();
        }
    }
}
