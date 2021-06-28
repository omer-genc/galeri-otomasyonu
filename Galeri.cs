using System;
using System.Collections.Generic;
using System.Text;
namespace galeri_otomasyonu
{
    class Galeri
    {
        public List<Araba> Arabalar = new List<Araba>();

        public int ToplamAracSayisi { get; }
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
        public int GaleridekiAracSayisi { get; }
        public int ToplamAracKiralanmaSuresi { get; }
        public int ToplamAracKiralanmaAdedi { get; }
        public int Ciro { get; }



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


        public void ArabaEkle()
        {
            //bu metodun parametresinden arabaya ait tüm bilgiler tek tek gelmeli

        }
        
    }
}
