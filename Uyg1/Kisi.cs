using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg1
{
    class Kisi
    {
        public string adi;
        public string soyadi;
        public string tel;
        public string adres;
        public string bilgiyiFormatla()
        {


            string cikti = "Adi: " + adi + "Soyadi: " + soyadi + "Tel:" + tel + "Adres:" + adres;
            return cikti;
        }
}
}

