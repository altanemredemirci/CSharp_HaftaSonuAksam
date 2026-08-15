namespace _15_Class_9_RestaurantOtomasyonu
{
    internal class Program
    {
        static List<Masa> Masalar = new List<Masa>()
        {
            new Masa(){No=1,Dolu=false},
            new Masa(){No=2,Dolu=false},
            new Masa(){No=3,Dolu=false},
            new Masa(){No=4,Dolu=false},
            new Masa(){No=5,Dolu=false}
        };

        static List<Menu> Menuler = new List<Menu>()
        {
            new Menu(){No=1,Ad="Çorbalar",Yemekler = new List<Yemek>()
                {
                    new Yemek(){No=1,Ad="Mercimek",Fiyat=400},
                    new Yemek(){No=2,Ad="Ezogelin",Fiyat=350},
                    new Yemek(){No=3,Ad="Kelle Paça",Fiyat=1000}
                }
            },
            new Menu(){No=2,Ad="Salatalar",Yemekler = new List<Yemek>()
                {
                    new Yemek(){No=1,Ad="Sezar",Fiyat=400},
                    new Yemek(){No=2,Ad="Mevsim",Fiyat=350},
                    new Yemek(){No=3,Ad="Çoban",Fiyat=700}
                }
            },
            new Menu(){No=3,Ad="Balıklar",Yemekler = new List<Yemek>()
                {
                    new Yemek(){No=1,Ad="Mezgit",Fiyat=700},
                    new Yemek(){No=2,Ad="Çupra",Fiyat=650},
                    new Yemek(){No=3,Ad="Levrek",Fiyat=2000}
                }
            },
            new Menu(){No=4,Ad="Makarnalar",Yemekler = new List<Yemek>()
                {
                    new Yemek(){No=1,Ad="Tavuklu",Fiyat=400},
                    new Yemek(){No=2,Ad="Köri Soslu",Fiyat=350},
                    new Yemek(){No=3,Ad="Bolanezli",Fiyat=1000}
                }
            },
            new Menu(){No=5,Ad="Etler",Yemekler = new List<Yemek>()
                {
                    new Yemek(){No=1,Ad="Pirzola",Fiyat=4000},
                    new Yemek(){No=2,Ad="Biftek",Fiyat=3500},
                    new Yemek(){No=3,Ad="Antrikot",Fiyat=5000}
                }
            },
            new Menu(){No=6,Ad="İçecekler",Yemekler = new List<Yemek>()
                {
                    new Yemek(){No=1,Ad="Kola",Fiyat=400},
                    new Yemek(){No=2,Ad="Fanta",Fiyat=350},
                    new Yemek(){No=3,Ad="Şalgam",Fiyat=500}
                }
            }
        };

        static List<Siparis> RestaurantSiparisleri = new List<Siparis>();

        static List<Yemek> MusteriSiparisi = new List<Yemek>();

        static double kazanc = 0;

        static void Main(string[] args)
        {
            #region Restaurant Otomasyonu
            /*
            Başlangıçta Çorbalar,Salatalar,Makarnalar,Etler,Balıklar,İçecekler diye içlerinde 3'er adet yemek kaydı olan menüler(listeler) tanımlanacaktır.
            Yemek: No,Ad,Fiyat

            Menü: List<Yemek> yemekler, No, Ad

            Masa: No, List<Siparis> siparisler, Dolu(bool)

            Siparis: Masa No, List<Yemek> siparis

            Restaurant bünyesinde 5 adet masa bulunacaktır. Masalarda kişi sınırı yok.
            
            Uygulama çalıştığında ekrana aşağıdaki menü gelecek
                1-Sipariş Al
                2-Hesap Al
                3-Masa Durumu
                4-Z Raporu
                5-Çıkış
                100-Yönetici Girişi

            *** 1-Sipariş Al 
            Her gelen yeni müşteri veya müşteriler ilk boş masaya oturtulacaktır.
            
            Kaç kişi oldukları öğrenildikten sonra sırasıyla müşterilere Menülerden yemek seçmeleri istenilecektir.
            Menüler:
                Çorbalar
                Salatalar
                Makarnalar
                Etler
                Balıklar
                İçecekler
            seçilen menü içerisindeki 3 yemek adı ekrana yazıdrılacak ve seçim yapılması istenilecektir.
            
            seçim sonrası başka bir arzunuz var mı? Evet ise menüler tekrar yazdırılacak
                                                    Hayır ise diğer müşteriye geçilecek


            *** 2-Hesap Al
            Hangi masa olduğu sorulacak ve seçilen masadaki toplam tutar ekrana yazdırılacak.
            Hesap Ödendi Mi? Evet ise masayı boşaltacağız ve Z raporuna tutarı ekleyeceğiz.


            *** 100- Yönetici Girişi
            Menü ekleme
            Menüye yeni yemek ekleme
            Varolan yemeğin fiyatını güncelleme
            Varolan yemeği silme
            Varolan menüyü silme işlemleri yapılacak
            Yeni masa ekleme
            Z raporu(günlük kazanç sıfırlama) alma 
             */
            #endregion

            while (true)
            {
                Console.WriteLine("1-Sipariş Al\n2-Hesap Al\n3-Masa Durumu\n4-Günlük Kazanç\n5-Çıkış\n100-Yönetici Girişi\nSeçiminiz:");

                int secim = Convert.ToInt32(Console.ReadLine());

                if (secim == 1) 
                {
                    Masa musteriMasasi = Masa.MasaDoldur(Masalar);

                    if (musteriMasasi == null)
                    {
                        Console.WriteLine("Boş yerimiz yok!!");
                        continue;
                    }

                    Console.WriteLine("Kaç kişisiniz?");
                    int kisiSayisi = Convert.ToInt32(Console.ReadLine());
                    Siparis siparis = new Siparis();
                    siparis.MasaNo = musteriMasasi.No;
                    for (int i = 0; i < kisiSayisi; i++)
                    {
                        while (true)
                        {
                            Menu secilenMenu = Menu.MenuSec(Menuler);
                            if (secilenMenu == null)
                            {
                                Console.WriteLine("Hatalı Menü Seçimi!!");
                            }
                            else
                            {
                                Yemek secilenYemek = Yemek.YemekSec(secilenMenu);

                                if (secilenYemek == null)
                                {
                                    Console.WriteLine("Hatalı Yemek Seçimi!!");
                                }
                                else
                                {
                                    MusteriSiparisi.Add(secilenYemek);
                                    musteriMasasi.Hesap += secilenYemek.Fiyat;
                                    siparis.Yemekler = MusteriSiparisi;
                                }
                            }
                            Console.WriteLine("Başka Bir Arzunuz Var Mı?(E/H)");
                            string cevap = Console.ReadLine().ToUpper();

                            if (cevap == "E")
                            {
                                continue;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }

                    RestaurantSiparisleri.Add(siparis);

                }
                else if (secim == 2) 
                {
                    Masa.MasaDurumu(Masalar);

                    Console.WriteLine("Hesap Alınacak Masa No:");
                    int masaNo = Convert.ToInt32(Console.ReadLine());

                    Masa hesapMasa = Masalar.FirstOrDefault(i => i.No == masaNo);

                    Console.WriteLine(hesapMasa.Hesap);

                    Console.WriteLine("Hesap Ödendi Mi?(E/H)");
                    string cevap = Console.ReadLine().ToUpper();

                    if (cevap == "E")
                    {
                        kazanc += hesapMasa.Hesap;
                        hesapMasa.Dolu = false;
                        hesapMasa.Hesap = 0;
                        Siparis hesapSiparis = RestaurantSiparisleri.FirstOrDefault(i => i.MasaNo == hesapMasa.No);

                        RestaurantSiparisleri.Remove(hesapSiparis);                       
                    }
                    else
                    {
                        Console.WriteLine("Hesap Ödenmedi.");
                    }
                }
                else if (secim == 3) 
                {
                    Masa.MasaDurumu(Masalar);
                }
                else if (secim == 4) 
                {
                    Console.WriteLine("Günlük Kazanç:"+kazanc);
                }
                else if (secim == 5) 
                {
                    Console.WriteLine("Sistem Kapatılıyor...");
                    Thread.Sleep(2000);
                    break;
                }
                else if (secim == 100) 
                {
                    Console.WriteLine("1-Menü Ekle\n2-Menü Sil\n3-Yemek Ekle\n4-Yemek Güncelle\n5-Yemek Sil\nSeçiminiz:");
                    int islem = Convert.ToInt32(Console.ReadLine());

                    if (islem == 1) 
                    {
                        Menu.MenuEkle(Menuler);
                    }
                    else if (islem == 2) 
                    {
                        Menu.MenuSil(Menuler);
                    }
                    else if (islem == 3) 
                    {
                        Yemek.YemekEkle(Menuler);
                    }
                    else if (islem == 4) 
                    {
                        Yemek.YemekGuncelle(Menuler);
                    }
                    else if (islem == 5) 
                    { 
                        Yemek.YemekSil(Menuler);
                    }
                }
                else  
                {
                    Console.WriteLine("Hatalı Tuşlama!!");
                }
            }

        }
    }
}