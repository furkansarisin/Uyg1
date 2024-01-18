using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg1
{
    class Program
    {
        static void Main(string[] args)
        {
            AdresDefteri defterim = new AdresDefteri();
            defterim.Ekle("Furkan", "Sarışın", "+0539 ", "Kayseri");
            defterim.Ekle("Cagri", "Demir ", "0553", "Adana");
            defterim.Ekle("Mustafa Furkan", "Turkmen", "0555 ", "Eskisehir");
            defterim.Ekle("Mustafa", "Gumuskalem", "0531", "Istanbul");

            int indis = defterim.Bul("Furkan", "Sarışın");
            Console.WriteLine(indis);

            string veri = defterim.veriUret();
            Raporlama rNesne = new Raporlama();
            rNesne.printReport(veri);


            int sonuc = defterim.Sil("Furkan", "Sarışın");
            if (sonuc == -1)
                Console.WriteLine("Silinemedi");
            else
                Console.WriteLine(sonuc + ". Kişi Silindi");

            veri = defterim.veriUret();
            rNesne.printReport(veri);
            //Burada yukarıdaki sil işleminin çalışıp çalışmadığını kontrol ediyoruz
        }
    }




}