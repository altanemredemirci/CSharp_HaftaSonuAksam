/*
 4 adet ürün olacak
 4 adet fiyat
 
Müşteriye ürünü ve fiyatını listeleyeceğiz.
Müşteri ürün seçecek sonra pra girişi yapacak.
Müşterinin girmiş olduğu miktar yeterli ise Afiyet olsun. Para üstü:
Müşterinin girmiş olduğu miktar yetersiz ise Para Ekle-1 İade-2


Yönetici 101 tuşlarsa ürün ekle,ürün sil,ürün güncelle alanlarına giriş yapacak ve bu işlemleri gerçekleştirecek.

** Ürün silerseniz alan(index) boş kalabilir.
** Ürün eklerseniz boş alana(indexe) veya dizi sonuna ekleyebilirsiniz.
** Ürün güncellerken ürün fiyatı güncellenecek.

 */
#region Emirhan
//int girishakki = 3;
//string[] urunler = { "Kola", "Fanta", "Ayran", "Su" };
//double[] fiyatlar = { 50, 50, 35, 20 };
//Console.WriteLine("Merhaba otomatımızda şu 4 icecek mevcut: ");
//for (int i = 0; i < urunler.Length; i++)
//{
//    Console.WriteLine(urunler[i]);
//    for (int j = 0; j < fiyatlar.Length; j++)
//    {
//        if (j == i)
//        {
//            Console.WriteLine("Bu icecegin fiyati: " + fiyatlar[j]);
//        }
//    }
//}
//Console.WriteLine("Kola için 1`i, Fanta için 2'yi, Ayran için 3'ü, Su için 4'u tuşlayınız");
//while (true)
//{
//    int sayi = Convert.ToInt32((Console.ReadLine()));
//    if (sayi == 1)
//    {
//        Console.WriteLine("Odeme yapmak icin para giriniz");
//        int para = Convert.ToInt32((Console.ReadLine()));
//        if (para >= 50)
//        {
//            int paraustu = para - 50;
//            Console.WriteLine("Para ustunuz: " + paraustu);
//            Console.WriteLine("Afiyet olsun");
//            break;
//        }
//        else
//        {
//            Console.WriteLine("Yetersiz bakiye!");
//            Console.WriteLine("Icecegi satın almak istiyor musunuz?");
//            while (true)
//            {
//                int karar = Convert.ToInt32(Console.ReadLine());
//                if (karar == 1)
//                {
//                    Console.WriteLine("Eklemek istediğiniz miktarı giriniz");
//                    int ekpara = Convert.ToInt32(Console.ReadLine());
//                    if (ekpara >= 50 - para)
//                    {
//                        int paraustu = ekpara + para - 50;
//                        Console.WriteLine("Para ustunuz " + paraustu);
//                        Console.WriteLine("Afitet olsun");
//                        break;
//                    }
//                    else
//                    {
//                        Console.WriteLine("Uzgunuz! Bakiye hala yeterli değil, islem basarisiz");
//                        int iade = para + ekpara;
//                        Console.WriteLine("Iade edilen para tutari: " + iade);
//                        break;
//                    }
//                }
//                else if (karar == 0)
//                {
//                    Console.WriteLine("Paraniz iade ediliyor lutfen bekleyiniz");
//                    Console.WriteLine("Paraniz iade edilmistir iyi gunler: ");
//                    Console.WriteLine("Iade edilen para tutari: " + para);
//                    break;
//                }
//                else
//                {
//                    Console.WriteLine("Gecersiz numara lütfen 1 ya da 0 tuşlayınız");
//                    continue;
//                }

//            }
//        }
//    }
//    else if (sayi == 2)
//    {
//        Console.WriteLine("Odeme yapmak icin para giriniz");
//        int para = Convert.ToInt32((Console.ReadLine()));
//        if (para >= 50)
//        {
//            int paraustu = para - 50;
//            Console.WriteLine("Para ustunuz: " + paraustu);
//            Console.WriteLine("Afiyet olsun");
//            break;
//        }
//        else
//        {
//            Console.WriteLine("Yetersiz bakiye!");
//            Console.WriteLine("Icecegi satın almak istiyor musunuz?");
//            while (true)
//            {
//                int karar = Convert.ToInt32(Console.ReadLine());
//                if (karar == 1)
//                {
//                    Console.WriteLine("Eklemek istediğiniz miktarı giriniz");
//                    int ekpara = Convert.ToInt32(Console.ReadLine());
//                    if (ekpara >= 50 - para)
//                    {
//                        int paraustu = ekpara + para - 50;
//                        Console.WriteLine("Para ustunuz " + paraustu);
//                        Console.WriteLine("Afitet olsun");
//                        break;
//                    }
//                    else
//                    {
//                        Console.WriteLine("Uzgunuz! Bakiye hala yeterli değil, islem basarisiz");
//                        int iade = para + ekpara;
//                        Console.WriteLine("Iade edilen para tutari: " + iade);
//                        break;
//                    }
//                }
//                else if (karar == 0)
//                {
//                    Console.WriteLine("Paraniz iade ediliyor lutfen bekleyiniz");
//                    Console.WriteLine("Paraniz iade edilmistir iyi gunler: ");
//                    Console.WriteLine("Iade edilen para tutari: " + para);
//                    break;
//                }
//                else
//                {
//                    Console.WriteLine("Gecersiz numara lütfen 1 ya da 0 tuşlayınız");
//                    continue;
//                }

//            }
//        }
//    }
//    else if (sayi == 3)
//    {
//        Console.WriteLine("Odeme yapmak icin para giriniz");
//        int para = Convert.ToInt32((Console.ReadLine()));
//        if (para >= 35)
//        {
//            int paraustu = para - 35;
//            Console.WriteLine("Para ustunuz: " + paraustu);
//            Console.WriteLine("Afiyet olsun");
//            break;
//        }
//        else
//        {
//            Console.WriteLine("Yetersiz bakiye!");
//            Console.WriteLine("Icecegi satın almak istiyor musunuz?");
//            while (true)
//            {
//                int karar = Convert.ToInt32(Console.ReadLine());
//                if (karar == 1)
//                {
//                    Console.WriteLine("Eklemek istediğiniz miktarı giriniz");
//                    int ekpara = Convert.ToInt32(Console.ReadLine());
//                    if (ekpara >= 35 - para)
//                    {
//                        int paraustu = ekpara + para - 35;
//                        Console.WriteLine("Para ustunuz " + paraustu);
//                        Console.WriteLine("Afitet olsun");
//                        break;
//                    }
//                    else
//                    {
//                        Console.WriteLine("Uzgunuz! Bakiye hala yeterli değil, islem basarisiz");
//                        int iade = para + ekpara;
//                        Console.WriteLine("Iade edilen para tutari: " + iade);
//                        break;
//                    }
//                }
//                else if (karar == 0)
//                {
//                    Console.WriteLine("Paraniz iade ediliyor lutfen bekleyiniz");
//                    Console.WriteLine("Paraniz iade edilmistir iyi gunler: ");
//                    Console.WriteLine("Iade edilen para tutari: " + para);
//                    break;
//                }
//                else
//                {
//                    Console.WriteLine("Gecersiz numara lütfen 1 ya da 0 tuşlayınız");
//                    continue;
//                }

//            }
//        }
//    }
//    else if (sayi == 4)
//    {
//        Console.WriteLine("Odeme yapmak icin para giriniz");
//        int para = Convert.ToInt32((Console.ReadLine()));
//        if (para >= 20)
//        {
//            int paraustu = para - 20;
//            Console.WriteLine("Para ustunuz: " + paraustu);
//            Console.WriteLine("Afiyet olsun");
//            break;
//        }
//        else
//        {
//            Console.WriteLine("Yetersiz bakiye!");
//            Console.WriteLine("Icecegi satın almak istiyor musunuz?");
//            while (true)
//            {
//                int karar = Convert.ToInt32(Console.ReadLine());
//                if (karar == 1)
//                {
//                    Console.WriteLine("Eklemek istediğiniz miktarı giriniz");
//                    int ekpara = Convert.ToInt32(Console.ReadLine());
//                    if (ekpara >= 20 - para)
//                    {
//                        int paraustu = ekpara + para - 20;
//                        Console.WriteLine("Para ustunuz " + paraustu);
//                        Console.WriteLine("Afitet olsun");
//                        break;
//                    }
//                    else
//                    {
//                        Console.WriteLine("Uzgunuz! Bakiye hala yeterli değil, islem basarisiz");
//                        int iade = para + ekpara;
//                        Console.WriteLine("Iade edilen para tutari: " + iade);
//                        break;
//                    }
//                }
//                else if (karar == 0)
//                {
//                    Console.WriteLine("Paraniz iade ediliyor lutfen bekleyiniz");
//                    Console.WriteLine("Paraniz iade edilmistir iyi gunler: ");
//                    Console.WriteLine("Iade edilen para tutari: " + para);
//                    break;
//                }
//                else
//                {
//                    Console.WriteLine("Gecersiz numara lütfen 1 ya da 0 tuşlayınız");
//                    continue;
//                }

//            }
//        }
//    }
//    else if (sayi == 101)
//    {
//        Console.WriteLine("Hosgeldiniz,mevcut iceceklerden hangisinin ismini değistirmek isterseniz ona gore su sayilari tuslayiniz,degisiklikleri onaylamak icin 9 sayisini tuslayiniz degilse rastgele bir rakama basiniz");
//        Console.WriteLine("kole icin 0, Fanta icin 1, Ayran icin 2, Su icin 3'u tuslayiniz.Icecek eklemek istemiyorsaniz kutucugu lutfen bos birakiniz");
//        while (true)
//        {
//        urunfiyatsec:
//            int icecek = Convert.ToInt32(Console.ReadLine());
//            if (icecek == 0)
//            {
//                Console.WriteLine("Yeni icecegin adi nedir?: ");
//                string yeniicecek = Console.ReadLine();
//                urunler[0] = yeniicecek;
//                if (urunler[0] == "")
//                {
//                    fiyatlar[0] = 0;
//                    goto Guncelonay;
//                }
//                Console.WriteLine("Yeni icecegin fiyati nedir?: ");
//                double yenifiyat = Convert.ToDouble(Console.ReadLine());
//                fiyatlar[0] = yenifiyat;
//            Guncelonay:
//                Console.WriteLine("Güncellemeyi onayliyor musunuz?: ");
//                int onay = Convert.ToInt32(Console.ReadLine());
//                if (onay == 9)
//                {
//                    Console.WriteLine("Güncelleme onaylandi,başka islem yapmak ister misiniz?");
//                devamonay:
//                    Console.WriteLine("Evet icin 1 Hayir icin 0 tuslayiniz");
//                    int devam = Convert.ToInt32(Console.ReadLine());
//                    if (devam == 1)
//                    {
//                        Console.WriteLine("Icecek sirasi giriniz");
//                        goto urunfiyatsec;
//                    }
//                    else if (devam == 0)
//                    {
//                        Console.WriteLine("Isleminiz tamam.Iyi gunler");
//                        break;
//                    }
//                    else
//                    {
//                        goto devamonay;
//                    }

//                }
//                else
//                {
//                    Console.WriteLine("Icecek sirasi giriniz");
//                    goto urunfiyatsec;
//                }

//            }
//            else if (icecek == 1)
//            {
//                Console.WriteLine("Yeni icecegin adi nedir?: ");
//                string yeniicecek = Console.ReadLine();
//                urunler[1] = yeniicecek;
//                if (urunler[1] == null)
//                {
//                    fiyatlar[1] = 0;
//                    goto Guncelonay1;
//                }
//                Console.WriteLine("Yeni icecegin fiyati nedir?: ");
//                double yenifiyat = Convert.ToDouble(Console.ReadLine());
//                fiyatlar[1] = yenifiyat;
//            Guncelonay1:
//                Console.WriteLine("Güncellemeyi onayliyor musunuz?: ");
//                int onay = Convert.ToInt32(Console.ReadLine());
//                if (onay == 9)
//                {
//                    Console.WriteLine("Güncelleme onaylandi,başka islem yapmak ister misiniz?");
//                devamonay1:
//                    Console.WriteLine("Evet icin 1 Hayir icin 0 tuslayiniz");
//                    int devam = Convert.ToInt32(Console.ReadLine());
//                    if (devam == 1)
//                    {
//                        Console.WriteLine("Icecek sirasi giriniz");
//                        goto urunfiyatsec;
//                    }
//                    else if (devam == 0)
//                    {
//                        Console.WriteLine("Isleminiz tamam.Iyi gunler");
//                        break;
//                    }
//                    else
//                    {
//                        goto devamonay1;
//                    }

//                }
//                else
//                {
//                    Console.WriteLine("Icecek sirasi giriniz");
//                    goto urunfiyatsec;
//                }
//            }
//            else if (icecek == 2)
//            {
//                Console.WriteLine("Yeni icecegin adi nedir?: ");
//                string yeniicecek = Console.ReadLine();
//                urunler[2] = yeniicecek;
//                if (urunler[2] == null)
//                {
//                    fiyatlar[2] = 0;
//                    goto Guncelonay2;
//                }
//                Console.WriteLine("Yeni icecegin fiyati nedir?: ");
//                double yenifiyat = Convert.ToDouble(Console.ReadLine());
//                fiyatlar[2] = yenifiyat;
//            Guncelonay2:
//                Console.WriteLine("Güncellemeyi onayliyor musunuz?: ");
//                int onay = Convert.ToInt32(Console.ReadLine());
//                if (onay == 9)
//                {
//                    Console.WriteLine("Güncelleme onaylandi,başka islem yapmak ister misiniz?");
//                devamonay2:
//                    Console.WriteLine("Evet icin 1 Hayir icin 0 tuslayiniz");
//                    int devam = Convert.ToInt32(Console.ReadLine());
//                    if (devam == 1)
//                    {
//                        Console.WriteLine("Icecek sirasi giriniz");
//                        goto urunfiyatsec;
//                    }
//                    else if (devam == 0)
//                    {
//                        Console.WriteLine("Isleminiz tamam.Iyi gunler");
//                        break;
//                    }
//                    else
//                    {
//                        goto devamonay2;
//                    }

//                }
//                else
//                {
//                    Console.WriteLine("Icecek sirasi giriniz");
//                    goto urunfiyatsec;
//                }
//            }
//            else if (icecek == 3)
//            {
//                Console.WriteLine("Yeni icecegin adi nedir?: ");
//                string yeniicecek = Console.ReadLine();
//                urunler[3] = yeniicecek;
//                if (urunler[3] == null)
//                {
//                    fiyatlar[3] = 0;
//                    goto Guncelonay3;
//                }
//                Console.WriteLine("Yeni icecegin fiyati nedir?: ");
//                double yenifiyat = Convert.ToDouble(Console.ReadLine());
//                fiyatlar[3] = yenifiyat;
//            Guncelonay3:
//                Console.WriteLine("Güncellemeyi onayliyor musunuz?: ");
//                int onay = Convert.ToInt32(Console.ReadLine());
//                if (onay == 9)
//                {
//                    Console.WriteLine("Güncelleme onaylandi,başka islem yapmak ister misiniz?");
//                devamonay3:
//                    Console.WriteLine("Evet icin 1 Hayir icin 0 tuslayiniz");
//                    int devam = Convert.ToInt32(Console.ReadLine());
//                    if (devam == 1)
//                    {
//                        Console.WriteLine("Icecek sirasi giriniz");
//                        goto urunfiyatsec;
//                    }
//                    else if (devam == 0)
//                    {
//                        Console.WriteLine("Isleminiz tamam.Iyi gunler");
//                        break;
//                    }
//                    else
//                    {
//                        goto devamonay3;
//                    }

//                }
//                else
//                {
//                    Console.WriteLine("Icecek sirasi giriniz");
//                    goto urunfiyatsec;
//                }
//            }
//            else
//            {
//                Console.WriteLine("Gecersiz numara,lutfen 0-3 arasi bir sayi giriniz!");
//                goto urunfiyatsec;
//            }
//        }

//    }
//    else
//    {
//        Console.WriteLine("Gecersiz deger lutfen 1-4 arasindan bir sayi seciniz");
//        girishakki -= 1;
//        if (girishakki > 0)
//        {
//            continue;
//        }
//        else if (girishakki == 0)
//        {
//            Console.WriteLine("Mevcut deneme hakkinizi doldurdunuz, gecici sureligine otomat kullanilamiyacak!");
//            break;
//        }
//    }
//}
#endregion

string[] products = { "Kola", "Fanta", "Ayran" };
int[] prices = { 50, 50, 25 };
int para = 0;
while (true)
{
    for (int i = 0; i < products.Length; i++)
    {
        Console.WriteLine(i + "-" + products[i] + ":" + prices[i]);
    }

    Console.WriteLine("Ürün Numarası:");
    int urunNo = Convert.ToInt32(Console.ReadLine());

    if (urunNo >= 0 && urunNo < products.Length)
    {
        while (true)
        {
            Console.WriteLine("Para Girişi:");
            para += Convert.ToInt32(Console.ReadLine());

            if (para >= prices[urunNo])
            {
                Console.WriteLine("Afiyet Olsun. Paraüstü:" + (para - prices[urunNo]));
                para = 0;
                break;
            }
            else
            {
                Console.WriteLine("Yetersiz Bakiye!\nPara Girişi-1\nPara İade-2");
                int secim = Convert.ToInt32(Console.ReadLine());

                if (secim == 1)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("İade tutarı:" + para);
                    para = 0;
                    break;
                }
            }
        }
    }
    else if (urunNo == 101)
    {
        Console.WriteLine("Ürün Ekle-1\nÜürn Güncelle-2\nÜrün Sil-3\nÜrün Listele-4\nİşleminiz:");
        int islem = Convert.ToInt32(Console.ReadLine());

        //Ürün Ekleme
        if (islem == 1) 
        {
            Console.WriteLine("Yeni ürün adı:");
            string urunAd = Console.ReadLine();

            Console.WriteLine("Yeni ürün fiyatı:");
            int fiyat = Convert.ToInt32(Console.ReadLine());

            Array.Resize(ref products, products.Length + 1);
            products[products.Length - 1] = urunAd; //products.Length-1 en son index numarasını verir.

            Array.Resize(ref prices, prices.Length + 1);
            prices[prices.Length - 1] = fiyat;

            Console.WriteLine("Ürün Eklendi.");
        }
        else if (islem == 2) 
        {
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(i + "-" + products[i] + ":" + prices[i]);
            }

            Console.WriteLine("Güncellenecek Ürün Numarası:");
            int guncelUrunNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Güncel Fiyat:");
            int fiyat = Convert.ToInt32(Console.ReadLine());

            prices[guncelUrunNo] = fiyat;

            Console.WriteLine("Ürün Güncellendi.");
        }
        else if (islem == 3) 
        {
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(i + "-" + products[i] + ":" + prices[i]);
            }

            Console.WriteLine("Silinecek Ürün Numarası:");
            int silUrunNo = Convert.ToInt32(Console.ReadLine());

            Array.Clear(products, silUrunNo, 1);
            Array.Clear(prices, silUrunNo, 1);

            Console.WriteLine("Ürün Silindi.");
        }
        else if (islem == 4)
        {
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(i + "-" + products[i] + ":" + prices[i]);
            }
        }
        else
        {
            Console.WriteLine("Hatalı Tuşlama!");
        }

    }
    else
    {
        Console.WriteLine("Hatalı Tuşlama!!");
    }
}



