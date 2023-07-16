using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onuncuornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Üye Olmak İster misiniz? ");
            string register = Console.ReadLine();
            if (register=="Evet" || register=="evet" || register=="EVET") {
                Console.Write("Kullanıcı Adı Giriniz: ");
                string username=Console.ReadLine();
                Console.Write("Şifre Giriniz: ");
                string password=Console.ReadLine() ;
                Console.Write("Ödeme tutarını giriniz: ");
                double fee = Convert.ToDouble(Console.ReadLine());
                Console.Write("Kaç Aylık Hesap İstiyorsunuz: ");
                double month = Convert.ToDouble(Console.ReadLine());
                if (month>=6 && month <= 12)
                {
                    double kdv = fee * 12.5/100;
                    double newfee = kdv + fee;
                    Console.WriteLine("Alınacak KDV Tutarı: " + kdv);
                    Console.WriteLine("Toplam Ödenmesi Gereken Tutar: "+newfee*month);
                }
                else
                {
                    double kdv = fee * 30.5/100;
                    double newfee = kdv + fee;
                    Console.WriteLine("Alınacak KDV Tutarı: " + kdv);
                    Console.WriteLine("Toplam Ödenmesi Gereken Tutar: " + newfee*month);
                }
                Console.Write("Giriş Yapmak İster misiniz: ");
                string login=Console.ReadLine();
                if (login == "EVET" || login == "Evet" || login == "evet")
                {
                    go:
                    Console.Write("Kullanıcı Adınızı Giriniz: ");
                    string username3=Console.ReadLine();
                    Console.Write("Şifrenizi Giriniz: ");
                    string password3 = Console.ReadLine();
                    if (username3==username && password3 == password)
                    {
                        Console.WriteLine("Başarıyla Giriş Yaptınız.");
                    }
                    else
                    {
                        Console.WriteLine("Kullanıcı adı veya şifre yanlış!");
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
                }
            }
            else if (register=="Zaten Üyeyim")
            {
                Console.Write("Kullanıcı Adınızı Giriniz: ");
                string username2=Console.ReadLine();
                Console.Write("Şifrenizi Giriniz: ");
                string password2=Console.ReadLine() ;
                Console.WriteLine("Başarıyla Giriş Yaptınız.");
            }
            else
            {
                Console.WriteLine("İyi Günler.");
            }
            Console.ReadLine();
        }
    }
}
