using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elliyedinciornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[] {1,2,3,4,5,6,7};
            Console.WriteLine(dizi[5]);
            string[] dizi2 = new string[4];
            for(int i=0; i<4;i++)
            {
                Console.WriteLine((i+1)+".Kelmeyi girin: ");
                string name = Console.ReadLine();
                dizi2[i] = name;
                
            }
            for (int j=0;j<4;j++) {
                Console.Write(dizi2[j]+" ");
            }
            
            Console.ReadLine();
        }
    }
}
