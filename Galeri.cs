using System;
using System.Collections.Generic;
using System.Text;
namespace galeri_otomasyonu
{
    class Galeri
    {
        public List<Araba> Arabalar = new List<Araba>();

        public int KiradakiAracSayisi
        {
            get
            {
                int adet = 0;

                foreach (Araba item in this.Arabalar)
                {
                    if (item.Durum == DURUM.Kirada)
                    {
                        adet++;
                    }
                }

                return adet;
            }
        }

        public int GaleridekiToplamArac
        {
            get
            {
                return Arabalar.Count;
            }
        }
        public int GaleridekiAracSayisi 
        { 
            get
            {
                return  this.GaleridekiToplamArac - this.KiradakiAracSayisi;
                
            } 
        }

        public int ToplamAracKiralanmaSuresi { 
            get
            {
                int toplam = 0; 
                foreach(Araba t in Arabalar)
                {
                    toplam += t.ToplamKiralanmaSuresi;
                }
                return toplam;
            } 
        
        }
        public int ToplamAracKiralanmaAdedi { 
            get
            {
                int toplam = 0;
                foreach(Araba t in Arabalar)
                {
                    toplam += t.KiralanmaSayisi;
                }
                return toplam;
            } 
        }
        public float Ciro { 
            get
            {
                float toplam = 0;
                foreach(Araba t in Arabalar)
                {
                    toplam += t.AracinCirosu;
                }
                return toplam;
            } 
        }



        public void ArabaKirala(string plaka, int sure)
        {
            int index = this.IndexBulPlakayaGore(plaka);
            this.Arabalar[index].KiralanmaSureleri.Add(sure);
            this.Arabalar[index].Durum = DURUM.Kirada;
        }


        public void ArabaEkle(string plaka, string marka, float kiralamaBedeli, ARAC_TIPI aracTipi)
        {
            Araba arabaNesnesi = new Araba(plaka, marka, kiralamaBedeli, aracTipi);
            Arabalar.Add(arabaNesnesi);
        }

        public Araba ArabaBul(string plaka)
        {
            Araba x = new Araba();
            foreach(Araba t in Arabalar)
                if(t.Plaka == plaka.ToUpper())
                {
                    x = t;
                    break;
                }
            
                return x;
        } // İHTİYAÇ DOĞRULTUSUNDA EKLENDİ

        public int IndexBulPlakayaGore(string plaka)
        {
            return this.Arabalar.IndexOf(this.ArabaBul(plaka.ToUpper()));
        } // İHTİYAÇ DOĞRULTUSUNDA EKLENDİ

        public bool AracVarmi(string plaka)/*Plakaya ait aracın olup olmama durumunu sorgular*/
        {
            foreach (Araba item in Arabalar)
                if(item.Plaka == plaka.ToUpper())
                    return true;
            

            return false;
        }

    }
}