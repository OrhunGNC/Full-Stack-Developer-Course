using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doksansekizinciornek
{
    abstract internal class Personeller//ana class
    {
        public string adsoyad;
        public int yas;
        public double maas;
        public int calismayil;
        public string cinsiyet;

        public abstract double MaasZam(double maas,int calismayil);
        public abstract double EnflasyonFark(double maas);
    }
}
