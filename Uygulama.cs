using System;
using System.Collections.Generic;
using System.Text;

namespace galeri_otomasyonu
{
    class Uygulama
    {
        public void Menu()
        {
            /*
                Galeri Otomasyon
                1- Araba Kirala (K)
                2- Araba Teslim Al (T)
                3- Kiradaki arabaları listele (R)
                4- Müsait arabaları listele (M)
                5- Tüm arabaları listele (A)
                6- Yeni araba Ekle (Y)
                7- Araba sil (S)
                8- Bilgileri göster (G)
                
            */
        }

        public string MenuSecim()
        {
            /*
                Menüye uygun seçim isteyen bir method
                doğru bilgi girilene kadar döngüden çıkamaz
            */
            return "";
        }

        public void AracKirala() /*SEÇİM 1*/
        {
            /*
                -Araç Kirala-
                Kiralanacak aracın plakası: 34US2342
                Araç müsait değil. Başka bir araç seçin.
                Kiralanacak aracın plakası: US23RR
                Giriş tanımlanamadı. Tekrar deneyin.
                Kiralanacak aracın plakası: 34HT2322
                Kiralama süresi: 2

                34HT2322 Plakalı araç 2 saatliğine kiralandı.
            */
        }

        public void AracTeslim()/*SEÇİM 2*/
        {
            /*
                -Araç Teslim-
                Teslim edilecek aracın plakası:  36MN2303
                Hatalı giriş yapıldı. Araç zaten galeride. 
                Teslim edilecek aracın plakası:  36MN2304
                Galeriye ait bu plakada bir araç yok.
                Teslim edilecek aracın plakası: US23LK
                Giriş tanımlanamadı. Tekrar deneyin.
                Teslim edilecek aracın plakası: 34TT2356

                Araç galeride beklemeye alındı.

            */
        }

        public void AracYazdir(Araba arac)
        {
            // Sadece bir aracı ekrana yazdıran method
        }

        public void KiradakiAraclariYazdir() /*SEÇİM 3*/
        {
            // kirada ki araçları yazdırır
        }
        
        public void MusaitAraclariYazdir() /*SEÇİM 4*/
        {
            // kirada ki araçları yazdırır
        }

        public void TumAraclariListele()/*Seçim 5*/
        {
            // Tüm araçları listeler
        }

        public void YeniAracKaydet()/*SEÇİM 6*/
        {
            /*
                -Yeni Araç Ekle-
                Plaka: 34TT2305
                Aynı plakada araç mevcut. Girdiğiniz plakayı kontrol edin.
                Plaka: 34TT2306
                Marka: FIAT
                KiralamaBedeli: 250
                Araç Tipleri:
                 - SUV için 1
                 - Hatchback için 2
                 - Sedan için 3
                Araç Tipi: 2

                Araç başarılı bir şekilde eklendi.

            */
            //Kullanıcıdan aldığı veriler ile Araç oluşturur
        }

        public void AracSil()
        {
            //plakaya göre araç araması yapar ve aracı siler
        }

        public void BilgiGoster()
        {
            /*
                -Galeri Bilgileri-
                Toplam Araç Sayısı: X
                Kiradaki Araç Sayısı: Y
                Galerideki Araç Sayısı: Z
                Toplam araç kiralanma süresi: T
                Toplam araç kiralanma adedi: R
                Ciro: Y
            */
        }
    }
}
