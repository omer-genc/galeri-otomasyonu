using System;
using System.Collections.Generic;
using System.Text;

namespace galeri_otomasyonu
{
    class Araba
    {
        public string Plaka { get; set; }
        public string Marka { get; set; }
        public float KiralamaBedeli { get; set; }

        public List<int> KiralanmaSureleri = new List<int>();

        public int ToplamKiralanmaSuresi
        {
            get
            {
                int toplam = 0;
                foreach (int x in this.KiralanmaSureleri)
                {
                    toplam += x;
                }
                return toplam;
            }
        }
        public int KiralanmaSayisi
        {
            get
            {
                return this.KiralanmaSureleri.Count;
            }
        }

        public ARAC_TIPI AracTipi { get; set; }
        public DURUM Durum { get; set; }


        public Araba(string plaka, string marka, float kiralamaBedeli, ARAC_TIPI aracTipi)
        {
            //burada atamayı yaparken tüm harfleri büyüterek atayalım.
            this.Plaka = plaka.ToUpper();
            this.Marka = marka;
            this.KiralamaBedeli = kiralamaBedeli;
            this.AracTipi = aracTipi;
            this.Durum = DURUM.Galeride;
        }
        
    } // end class

     public enum DURUM
    {
        Empty = 45,
        Kirada = 65,
        Galeride = 74
    }

    public enum ARAC_TIPI
    {
        Empty = 34,
        SUV = 56,
        Sedan = 23,
        Hatcback = 76
    }

}
