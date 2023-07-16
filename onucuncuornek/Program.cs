using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onucuncuornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            go:
            Console.WriteLine("1)Gömlek");
            Console.WriteLine("2)Pantolon");
            Console.WriteLine("3)Ayakkabı");
            Console.Write("Ürünü Seçiniz: ");
            string product = Console.ReadLine();
            Random random = new Random();   
            if (product == "1")
            {
                double number=random.Next(500,1001);
                Console.WriteLine("\nÜrünün Fiyatı " + number+"TL'dir");
                Console.Write("\nİndirim Kuponunuz Var mı? ");
                string coupon = Console.ReadLine();
                if (coupon == "var" || coupon == "VAR" || coupon == "Var")
                {
                    number *= 0.70;
                    Console.WriteLine("\nÖdeme Tutarınız " + number + "TL'dir");
                }
                else
                {
                    number *= 0.90;
                    Console.WriteLine("\nÖdeme Tutarınız " + number + "TL'dir");
                }
            }
            else if (product == "2")
            {
                double number = random.Next(250, 750);
                Console.WriteLine("\nÜrünün Fiyatı " + number + "TL'dir");
                Console.Write("\nİndirim Kuponunuz Var mı? ");
                string coupon = Console.ReadLine();
                if (coupon == "var" || coupon == "VAR" || coupon == "Var")
                {
                    number *= 0.70;
                    Console.WriteLine("\nÖdeme Tutarınız " + number + "TL'dir");
                }
                else
                {
                    number *= 0.90;
                    Console.WriteLine("\nÖdeme Tutarınız " + number + "TL'dir");
                }
            }
            else if (product == "3")
            {
                double number = random.Next(1000, 2001);
                Console.WriteLine("\nÜrünün Fiyatı " + number + "TL'dir");
                Console.WriteLine("\nOnline'mı Kapıda Ödeme mi Olsun? ");
                string odeme=Console.ReadLine();
                if (odeme == "online" || odeme == "Online" || odeme == "ONLINE")
                {
                    number *= 1.05;
                    Console.WriteLine("\nÖdeme Tutarınız " + number + "TL'dir");
                    Console.Write("\nİndirim Kuponunuz Var mı? ");
                    string coupon = Console.ReadLine();
                    if (coupon == "var" || coupon == "VAR" || coupon == "Var")
                    {
                        number *= 0.70;
                        Console.WriteLine("\nÖdeme Tutarınız " + number + "TL'dir");
                    }
                    else
                    {
                        number *= 0.90;
                        Console.WriteLine("\nÖdeme Tutarınız " + number + "TL'dir");
                    }
                }
                else if (odeme == "Kapıda" || odeme == "KAPIDA" || odeme == "kapıda")
                {
                    number *= 1.20;
                    Console.WriteLine("\nÖdeme Tutarınız " + number + "TL'dir");
                    Console.Write("\nİndirim Kuponunuz Var mı? ");
                    string coupon = Console.ReadLine();
                    if (coupon == "var" || coupon == "VAR" || coupon == "Var")
                    {
                        number *= 0.70;
                        Console.WriteLine("\nÖdeme Tutarınız " + number+"TL'dir");
                    }
                    else
                    {
                        number *= 0.90;
                        Console.WriteLine("\nÖdeme Tutarınız " + number + "TL'dir");
                    }
                }
                else
                {
                    Console.WriteLine("\nYanlış Tuşlama Yaptınız.");
                }
            }
            else
            {
                Console.WriteLine("\nYanlış Tuşlama Yaptınız.");
            }
            Console.Write("\nTekrar Denemek İster misiniz? ");
            string tryagain= Console.ReadLine();
            if (tryagain == "evet" || tryagain == "EVET" || tryagain == "Evet")
            {
                Console.Clear();
                goto go;
            }
            else
            {
                Console.WriteLine("\nİyi Günler.");
            }
            Console.ReadLine();

        }
    }
}
