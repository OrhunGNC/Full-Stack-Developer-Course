using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yedinciornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Yaşı Giriniz: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
            {
                Console.Write("Mesleğiniz Nedir? ");
                string job = Console.ReadLine();
                string job2 = "Mühendis";
                string job3 = "Yazılım Mühendisi";
                if (job == job2)
                {
                    double engineersalary = 25000;
                    double newengsalary = 25000 * 1.15;
                    Console.WriteLine("\nMesleğiniz: " + job);
                    Console.WriteLine("Normal Maaşınız: " + engineersalary);
                    Console.WriteLine("Zam Oranınız: %15");
                    Console.WriteLine("Yeni Maaşınız: " + newengsalary);
                }
                else if (job == job3)
                {
                    double softengineersalary = 35000;
                    double newsoftengsalary = 35000 * 1.15;
                    Console.WriteLine("\nMesleğiniz: " + job);
                    Console.WriteLine("Normal Maaşınız: " + softengineersalary);
                    Console.WriteLine("Zam Oranınız: %15");
                    Console.WriteLine("Yeni Maaşınız: " + newsoftengsalary);
                }
                else
                {
                    double salary = 11000;
                    double newsalary = 11000 * 1.15;
                    Console.WriteLine("\nMesleğiniz: " + job);
                    Console.WriteLine("Normal Maaşınız: " + salary);
                    Console.WriteLine("Zam Oranınız: %15");
                    Console.WriteLine("Yeni Maaşınız: " + newsalary);
                }
            }
            else
            {
                Console.Write("Asgari Ücret Nedir? ");
                double asgarisalary = Convert.ToDouble(Console.ReadLine());
                double newasgarisalary = asgarisalary * 0.3;
                Console.WriteLine("\nNormal Maaşınız: " + asgarisalary);
                Console.WriteLine("Maaş Oranınız: %30");
                Console.WriteLine("Yeni Maaşınız: " + newasgarisalary);

            }
            Console.ReadLine();
        }
    }
}