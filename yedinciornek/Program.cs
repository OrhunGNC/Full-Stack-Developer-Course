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
                double salary = 11000;
                double newsalary = 11000 * 1.15;
                Console.WriteLine("\nMesleğiniz: "+job);
                Console.WriteLine("Normal Maaşınız: " +salary);
                Console.WriteLine("Zam Oranınız: %15");
                Console.WriteLine("Yeni Maaşınız: " + newsalary);

            }
            else
            {
                Console.Write("Asgari Ücret Nedir? ");
                double asgarisalary = Convert.ToDouble(Console.ReadLine());
                double newasgarisalary = asgarisalary * 1.3;
                Console.WriteLine("\nNormal Maaşınız: " + asgarisalary);
                Console.WriteLine("Zam Oranınız: %30");
                Console.WriteLine("Yeni Maaşınız: " + newasgarisalary);

            }
            Console.ReadLine();
        }
    }
}
