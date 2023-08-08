using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace yuzaltinciornek
{
    internal interface Iislem
    {
        //field ve metotların yapısı tanımlanabilir.
        string adsoyad { get; set; }
        void bb();
        int hesaplama(int fiyat);
    }
}
