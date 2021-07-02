using System;
using System.Collections.Generic;
using System.Text;

namespace galeri_otomasyonu
{
    class Uygulama
    {
        Galeri galeri = new Galeri();
        public void Calistir()
        {
            this.Menu();
            string secim = "";
            while (true)
            {
                secim = SecimAl();
                switch (secim)
                {
                    case "1":
                    case "K":
                        AracKirala();
                        break;
                    case "2":
                    case "T":
                        AracTeslim();
                        break;
                    case "3":
                    case "R":
                        KiradakiAraclariYazdir();
                        break;
                    case "4":
                    case "M":
                        MusaitAraclariYazdir();
                        break;
                    case "5":
                    case "A":
                        TumAraclariListele();
                        break;
                    case "6":
                    case "Y":
                        YeniAracKaydet();
                        break;
                    case "7":
                    case "S":
                        AracSil();
                        break;
                    case "8":
                    case "G":
                        BilgiGoster();
                        break;
                }
            }
        }//end method

        public void Menu()
        {
            Console.WriteLine("Galeri Otomasyon ");
            Console.WriteLine("1 - Araba Kirala(K) ");
            Console.WriteLine("2 - Araba Teslim Al(T) ");
            Console.WriteLine("3 - Kiradaki arabaları listele(R) ");
            Console.WriteLine("4 - Müsait arabaları listele(M) ");
            Console.WriteLine("5 - Tüm arabaları listele(A) ");
            Console.WriteLine("6 - Yeni araba Ekle(Y) ");
            Console.WriteLine("7 - Araba sil(S) ");
            Console.WriteLine("8 - Bilgileri göster(G) ");
        }

        public string SecimAl()
        {
            Console.Write("\nSeçiminiz: ");
            return Console.ReadLine().ToUpper();
        }





        

        public void AracKirala() /*SEÇİM 1*/
        {
            if(this.galeri.GaleridekiAracSayisi == 0)
            {
                System.Console.WriteLine("Galeride araç yok");
                return;
            }
            Console.WriteLine("-Araç Kirala-");
            
            string plaka = "";
            while (true)
            {
                Console.Write("Kiralanacak aracın plakası: ");
                plaka = Console.ReadLine().ToUpper();
                string girdi = "";
                int sure = 0;
                
                if (!galeri.AracVarmi(plaka)) /*Plakaya ait araç yoksa uyarı verir*/
                {
                    System.Console.WriteLine("Giriş tanımlanamadı. Tekrar deneyin.");
                    continue;
                }

                int index = this.galeri.IndexBulPlakayaGore(plaka);

                if (this.galeri.Arabalar[index].KiradaMi())
                {
                    System.Console.WriteLine("Araç müsait değil. Başka bir araç seçin.");
                    continue;
                }
                else
                {
                    do
                    {
                        Console.WriteLine("Kiralama süresi: ");
                        girdi = Console.ReadLine();
                        if(!int.TryParse(girdi,out sure))
                            System.Console.WriteLine("Lütfen sayı giriniz...");
                        else
                            break;
                    } while (true);

                    this.galeri.ArabaKirala(plaka,sure);
                    System.Console.WriteLine();
                    System.Console.WriteLine(plaka + "Plakalı araç " + sure + " saatliğine kiralandı.");
                    return;
                } 
                
            }//end while
            
        } // end method

        public void AracTeslim()/*SEÇİM 2*/
        {
            if(this.galeri.KiradakiAracSayisi == 0)
            {
                System.Console.WriteLine("Kiarada araç yok");
                return;
            }
            Console.WriteLine("-Araç Teslim-");
            
            string plaka = "";
            while (true)
            {
                Console.Write("Teslim edilecek aracın plakası: ");
                plaka = Console.ReadLine().ToUpper();
                string girdi = "";
                int sure = 0;
                
                if (!galeri.AracVarmi(plaka)) /*Plakaya ait araç yoksa uyarı verir*/
                {
                    System.Console.WriteLine("Galeriye ait bu plakada bir araç yok..");
                    continue;
                }

                int index = this.galeri.IndexBulPlakayaGore(plaka);

                if (!this.galeri.Arabalar[index].KiradaMi())
                {
                    System.Console.WriteLine("Hatalı giriş yapıldı. Araç zaten galeride.");
                    continue;
                }
                else
                {
                    do
                    {
                        Console.WriteLine("Kiralama süresi: ");
                        girdi = Console.ReadLine();
                        if(!int.TryParse(girdi,out sure))
                            System.Console.WriteLine("Lütfen sayı giriniz...");
                        else
                            break;
                    } while (true);
                    System.Console.WriteLine();
                    this.galeri.Arabalar[index].Durum = DURUM.Galeride;
                    System.Console.WriteLine("Araç galeride beklemeye alındı.");
                } 
                
            }//end while
            
        }



        public void KiradakiAraclariYazdir() /*SEÇİM 3*/
        {
            if(this.galeri.KiradakiAracSayisi == 0)
            {
                System.Console.WriteLine("Kirada araç yok");
                return;
            }
            foreach(Araba item in galeri.Arabalar)
                if(item.KiradaMi())
                    System.Console.WriteLine(item.AracBilgisi());
                
            
        }

        public void MusaitAraclariYazdir() /*SEÇİM 4*/
        {
            if(this.galeri.GaleridekiAracSayisi == 0)
            {
                System.Console.WriteLine("Galeride araç yok");
                return;
            }
            foreach(Araba item in galeri.Arabalar)
                if(!item.KiradaMi())
                    System.Console.WriteLine(item.AracBilgisi());
        }

        public void TumAraclariListele()/*Seçim 5*/
        {
            Console.WriteLine();
            Console.WriteLine("-Tüm araçlar-");
            Console.WriteLine();
            Console.WriteLine("Plaka".PadRight(10) + "Marka".PadRight(15) + "Kiralama Bedeli".PadRight(20) + "Araç Tipi".PadRight(15) + "Kiralanma Sayısı".PadRight(20) + "Durum".PadRight(15));
            Console.WriteLine("------------------------------------------------------------------------------------");
            foreach (Araba i in galeri.Arabalar)
            {
                Console.WriteLine(i.AracBilgisi());
            }

        }

        public void YeniAracKaydet()/*SEÇİM 6*/
        {
            string plaka = "";
            System.Console.WriteLine("-Yeni Araç Ekle-");
            do
            {
                Console.Write("Plaka: ");
                plaka = Console.ReadLine();
                if (this.galeri.AracVarmi(plaka))
                    continue;
                else
                    break;

            } while (true);

            Console.Write("Marka: ");
            string marka = Console.ReadLine();
            string girdi = "";
            int kira_bedel = 0;

            do
            {
                Console.WriteLine("KiralamaBedeli: ");
                girdi = Console.ReadLine();
                if(!int.TryParse(girdi,out kira_bedel))
                    System.Console.WriteLine("Lütfen sayı giriniz...");
                else
                    break;
            } while (true);
            ARAC_TIPI tip = AracTipiSec();

            this.galeri.ArabaEkle(plaka,marka,kira_bedel,tip);
            System.Console.WriteLine();
            System.Console.WriteLine("Araç başarılı bir şekilde eklendi.");

        }

        public ARAC_TIPI AracTipiSec()
        {
            Console.WriteLine("Araç Tipleri: "); 
            Console.WriteLine(" - SUV için 1 "); 
            Console.WriteLine(" - Hatchback için 2 "); 
            Console.WriteLine(" - Sedan için 3 "); 
            string secim = "";
            while (true)
            {
                System.Console.Write("Araç Tipi:");
                secim = Console.ReadLine();
                if (secim == "1")
                    return ARAC_TIPI.SUV;
                else if(secim == "2")
                    return ARAC_TIPI.Hatcback;
                else if(secim == "3")
                    return ARAC_TIPI.Sedan; 
            }
        }

        public void AracSil() /*secim 7*/
        {
            string plaka = "";
            System.Console.Write("Silmek istediğiniz aracın plakası: ");
            plaka = Console.ReadLine();

            while (!galeri.AracVarmi(plaka))
            {
                Console.WriteLine("Galeriye ait bu plakada bir araç yok.");
                System.Console.Write("Silmek istediğiniz aracın plakası: ");
                plaka = Console.ReadLine();

            }

            Araba arabaNesnesi = galeri.ArabaBul(plaka);
            galeri.Arabalar.Remove(arabaNesnesi);
            System.Console.WriteLine("Araç silindi...."); 

        }

        public void BilgiGoster() /*secim 8*/
        {

            
            Console.WriteLine("-Galeri Bilgileri-");
            Console.WriteLine("Toplam Araç Sayısı: " + galeri.GaleridekiToplamArac);
            Console.WriteLine("Kiradaki Araç Sayısı: " + galeri.KiradakiAracSayisi);
            Console.WriteLine("Galerideki Araç Sayısı: " + galeri.GaleridekiAracSayisi);
            Console.WriteLine("Toplam araç kiralanma süresi:" + galeri.ToplamAracKiralanmaSuresi);
            Console.WriteLine("Toplam araç kiralanma adedi: " + galeri.ToplamAracKiralanmaAdedi);
            Console.WriteLine("Ciro: " + galeri.Ciro);
        

        }
    }
}
