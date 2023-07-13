using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ilkornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string NameSurname = "Orhun Cem";
            string Job = "Muhendis";
            string Age = "22";
            int Result = 78;
            int Number = 5;
            Result = Result + Number;  //result+=number result-=number result*=number
            Console.WriteLine("Name Surname:"+NameSurname);
            Console.WriteLine("Job:"+Job);
            Console.WriteLine("Age:"+Age);
            Console.WriteLine("The Result:"+Result);
            Console.ReadLine();
        }
    }
}
