using System;
using System.Collections.Generic;
using System.Text;
namespace galeri_otomasyonu
{
    class Galeri
    {
        public List<Araba> Arabalar = new List<Araba>();

        public int ToplamAracSayisi { 
            get
            {
                // burada Arabalar listesinde ki araç sayısı return edilecek
                return 0;
            }
        }
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
        public int GaleridekiAracSayisi { 
            get
            {
                // burada Arabalar listesinde ki araçların arasından 
                //kaç tanesinin durumu galeride olduğu return edilecek
                return 0;
            } 
        }
        public int ToplamAracKiralanmaSuresi { 
            get
            {
                // her bir aracın toplam kiralama süresi toplanıp return edilecek
                return 0;
            } 
        
        }
        public int ToplamAracKiralanmaAdedi { 
            get
            {
                // her bir aracın kiralanma sayısı toplanıp return edilecek
                return 0;
            } 
        }
        public float Ciro { 
            get
            {
                // herbir aracın AracinCirosu toplanacak ve return edilecek
                return 0;
            } 
        }



        public void ArabaKirala(string plaka, int sure)
        {
            Araba a = null;

            foreach (Araba item in this.Arabalar)
            {
                if (item.Plaka == plaka)
                {
                    a = item;
                }
            }

            a.KiralanmaSureleri.Add(sure);
            a.Durum = DURUM.Kirada;
        }


        public void ArabaEkle(/* araç parametereli*/)
        {
            //Parametreneden geln değerler ile bir araç nesnesi oluşturulmalı ve
            //Arabalar listesine eklenmeli
            //bu metodun parametresinden arabaya ait tüm bilgiler tek tek gelmeli

        }

        public Araba ArabaBul(string plaka)
        {
            Araba x = new Araba();
            // plaka il eşleşen 
            return x;
        } // İHTİYAÇ DOĞRULTUSUNDA EKLENDİ
        
    }
}
