﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg1
{
    class AdresDefteri
    {
        Kisi[] kisiler   = new Kisi[100];
        int kisiSayisi = 0;

        public int Ekle(string ad, string soyad, string tel, string adres)
        {
            int sonuc = -1;
            if (kisiSayisi <100)
            {
                kisiler[kisiSayisi] = new Kisi();
                kisiler[kisiSayisi].adi = ad;
                kisiler[kisiSayisi].soyadi = soyad;
                kisiler[kisiSayisi].tel = tel;
                kisiler[kisiSayisi].adres = adres;
                kisiSayisi++;
                sonuc = 1;
            }
            return sonuc;
        }
        public int Bul (String ad, String soyad)
        {
            int index = -1;
            for (int i = 0; i<kisiSayisi; i++)
            {
                if((kisiler[i].adi== ad) && (kisiler[i].soyadi == soyad))
                {
                    index = i;
                }
            }
            return index; 
        }
        public int Sil (String ad, String soyad)
        {
            int index = Bul(ad, soyad);
            if (index != -1)
            {
                for(int i = index; i<kisiSayisi - 1; i++)
                {
                    kisiler[i].adi = kisiler[i + 1].adi;
                    kisiler[i].soyadi = kisiler[i + 1].soyadi;
                    kisiler[i].tel = kisiler[i + 1].tel;
                    kisiler[i].adres = kisiler[i + 1].adres;
                }
                kisiSayisi--;
            }
            return index;
        } 
        public string veriUret()
        {
            string cikti = "";
            for (int i = 0; i < kisiSayisi; i++)
                cikti += kisiler[i].bilgiyiFormatla()+"\n";
            return cikti;
        }
    }
}
