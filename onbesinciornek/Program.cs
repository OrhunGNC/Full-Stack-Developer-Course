using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onbesinciornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            go:
            try
            {
                Console.WriteLine("1) Gemi");
                Console.WriteLine("2) Marmaray");
                Console.WriteLine("3) Otobüs");
                Console.Write("Ulaşım Aracı Seçiniz: ");
                char transport=Convert.ToChar(Console.ReadLine());
                if (transport == '1')
                {
                    Console.WriteLine("\nGemiye Hoşgeldiniz");
                    Console.WriteLine("A- Anadolu Yakası Yolculuğu");
                    Console.WriteLine("B- Kıtalar Arası Geçiş");
                    Console.Write("Ulaşım Şekli Seçiniz: ");
                    char choice=Convert.ToChar(Console.ReadLine());
                    if (choice=='A')
                    {
                        Random random=new Random();
                        int fee = random.Next(70,101);
                        Console.WriteLine("\nTutar: " + fee);
                    }
                    else if (choice == 'B')
                    {
                        Random random = new Random();
                        int fee = random.Next(200, 301);
                        Console.WriteLine("\nTutar: " + fee);
                    }
                    else
                    {
                        Console.WriteLine("\nHata Yakalandı Tekrar Dene!");
                        Console.Write("\nİşleme devam etmek ister misiniz? ");
                        string islem = Console.ReadLine();
                        if (islem == "evet" || islem == "Evet" || islem == "EVET")
                        {
                            Console.Clear();
                            goto go;
                        }
                        else
                        {
                            Console.WriteLine("\nİyi Günler.");
                        }
                    }
                }
                else if (transport == '2')
                {
                    Console.WriteLine("\nYolculuk Ücreti: 21TL");
                    int fee = 21;
                    Console.Write("\nKaç durak gideceksiniz? ");
                    int stops = Convert.ToInt32(Console.ReadLine());
                    if(stops>=0 && stops < 5)
                    {
                        fee -= 10;
                        Console.WriteLine("\nİade Sonrası Toplam Tutar: "+fee);
                    }
                    else if (stops>=5 && stops <= 10)
                    {
                        fee -= 5;
                        Console.WriteLine("\nİade Sonrası Toplam Tutar: " + fee);
                    }
                    else 
                    {
                        Console.WriteLine("\nToplam Tutar: " + fee);
                    }
                }
                else if (transport == '3')
                {
                    Console.Write("\nOtobüste Aylık Var mı? ");
                    string monthlybus= Console.ReadLine();
                    if (monthlybus=="Evet" || monthlybus=="EVET"|| monthlybus == "evet")
                    {
                        Console.WriteLine("\nAylık Ücreti 140TL'dir.");
                        Console.WriteLine("\nAylık Basım Limitiniz: 200");
                        Console.Write("\nGünde Kaç Sefer Yolculuk Yaptınız? ");
                        int daily=Convert.ToInt32(Console.ReadLine());
                        int monthly= daily*30;
                        int kalanhak = 200 - monthly;
                        if (kalanhak>=0 && kalanhak <= 20)
                        {
                            Console.WriteLine("\nÖdemeniz Gereken Tutar: 110TL");
                            Console.WriteLine("\nİade Tutarı:"+(140-110));
                        }
                        else if (kalanhak>20 && kalanhak <= 40)
                        {
                            Console.WriteLine("\nÖdemeniz Gereken Tutar: 90TL");
                            Console.WriteLine("\nİade Tutarı:" + (140 - 90));
                        }
                        else if (kalanhak < 0)
                        {
                            Console.WriteLine("\nKullanım limitinizi aştınız!");
                        }
                        else
                        {
                            Console.WriteLine("\nİade Bulunmamaktadır.");
                            Console.WriteLine("\nÖdemeniz Gereken Tutar: 140TL");
                        }


                    }
                    else
                    {
                        
                    }
                }

            }
            catch
            {
                Console.WriteLine("\nHata Yakalandı Tekrar Dene!");
                Console.Write("\nİşleme devam etmek ister misiniz? ");
                string islem=Console.ReadLine();
                if (islem =="evet" || islem =="Evet"  || islem == "EVET")
                {
                    Console.Clear();
                    goto go;
                }
            }
            finally
            {
                Console.WriteLine("\nYine Bekleriz...");
            }
            Console.Write("\nİşleme devam etmek ister misiniz? ");
            string islem2 = Console.ReadLine();
            if (islem2 == "evet" || islem2 == "Evet" || islem2 == "EVET")
            {
                Console.Clear();
                goto go;
            }
            else
            {
                Console.WriteLine("\nGörüşmek Üzere...");
            }
            Console.ReadLine();
            
        }
    }
}
