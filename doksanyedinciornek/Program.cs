using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doksanyedinciornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-Yazlık");
            Console.WriteLine("2-Kışlık");
            int tercih = int.Parse(Console.ReadLine());
            if (tercih == 1)
            {
                YazlikAyakkabi yazlikayakkabi = new YazlikAyakkabi();
                yazlikayakkabi.Yazlik();
            }
            else
            {
                KislikAyakkabi kisliayakkabi = new KislikAyakkabi();
                kisliayakkabi.Kislik();
            }
            Console.ReadLine();
        }
    }
}
