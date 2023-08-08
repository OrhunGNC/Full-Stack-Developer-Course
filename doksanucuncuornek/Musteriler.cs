using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doksanucuncuornek
{
    internal class Musteriler
    {
        public int musterino;
        public string adsoyad;
        string telno;
        string mail;
        private int bakiye;
        public string adres;

        //public int MusteriNo { get { return musterino; } set { if (value == 4758) { musterino = value; } else { Console.WriteLine("Yanlış Değer!"); } } }
        //public string AdSoyad 
        //    { 
        //    get { return adsoyad; } 
        //    set { adsoyad=value; } 
        //    }
        public string TelNo 
        {
            get
            {
                return telno;
            }

            set
            {
                if (value.Length == 11)
                {
                    telno = value;
                }
                else
                {
                    Console.WriteLine("Geçersiz Telefon Numarası!");
                }
            }

        }
        public string Mail 
        {
            get
            {
                return mail;
            }

            set
            {
                if (value.Contains("@")){
                    mail = value;
                }
                else
                {
                    Console.WriteLine("Mail Adresi Giriniz!");
                }
            }
                
        }
        public int Bakiye
        {
            get
            {
                return bakiye;
            }
            set
            {
                if(value>100000 && value < 500000)
                {
                    bakiye = value;
                }
                else
                {
                    Console.WriteLine("Yanlış Bakiye Girdiniz!");
                }
            }
        }
        public int faizlibakiye
        {
            get { return bakiye; }
            set {
                if (value > 100000 && value < 500000)
                {
                    bakiye = value*110/100;
                }
                else
                {
                    Console.WriteLine("Yanlış Bakiye Girdiniz!");
                }
            }
        }
        public void Yazdir()
        {
            Console.WriteLine("Müşteri No: " + musterino);
            Console.WriteLine("Ad Soyad: " + adsoyad);
            Console.WriteLine("Tel No: " + TelNo);
            Console.WriteLine("Mail: " + Mail);
            Console.WriteLine("Bakiye: " + Bakiye);
            
        }
        public void Faiz(int bakiye)
        {
            bakiye += bakiye * 10 / 100;
            Console.WriteLine("Faizli Bakiye: " + bakiye);
        }
    }
}
