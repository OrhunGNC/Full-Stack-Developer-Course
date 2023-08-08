using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yuzsekizinciornek
{
    internal interface IUye:Iislem
    {
        void UyeKontrol();
        int Aidat(int ay, int fiyat);
    }
}
