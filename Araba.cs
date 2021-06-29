using System;
using System.Collections.Generic;
using System.Text;

namespace galeri_otomasyonu
{
    class Araba
    {
        // kiralam süresi sayesinde daha detaylı verilere erişebileceğiz
        public List<int> KiralanmaSureleri = new List<int>();
        public string Plaka { get; set; }
        public string Marka { get; set; }
        public float KiralamaBedeli { get; set; }


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

        public float AracinCirosu 
        {
            get
            {

               return this.ToplamKiralanmaSuresi * KiralamaBedeli;
               
            }
        }// İHTİYAÇ DOĞRULTUSUNDA EKLENDİ

        public ARAC_TIPI AracTipi { get; set; }
        public DURUM Durum { get; set; }

        public Araba()
        {
            
        }
        public Araba(string plaka, string marka, float kiralamaBedeli, ARAC_TIPI aracTipi)
        {
            //burada atamayı yaparken tüm harfleri büyüterek atayalım.
            this.Plaka = plaka.ToUpper();
            this.Marka = marka;
            this.KiralamaBedeli = kiralamaBedeli;
            this.AracTipi = aracTipi;
            this.Durum = DURUM.Galeride;
        }

        public string AracBilgisi()
        {
            string sonuc = this.Plaka.PadRight(10) + this.Marka.PadRight(15) + (this.KiralamaBedeli + "TL").ToString().PadRight(20) + this.AracTipi.ToString().PadRight(15) + this.KiralanmaSayisi.ToString().PadRight(20) + this.Durum.ToString().PadRight(15);

            return sonuc;
        }

        public bool KiradaMi()
        {
            if(this.Durum == DURUM.Kirada)
                return true;
            
            return false;
        }

        
    } // end class

    public enum DURUM{Empty,Kirada,Galeride}

    public enum ARAC_TIPI{Empty,SUV,Sedan,Hatcback}

} 
