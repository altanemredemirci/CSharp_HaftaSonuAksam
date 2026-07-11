namespace _06_Bankamatik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region BANKAMATİK
            /*   
    //             *   25000 tl parası olacak 
    //            Bir bankamatik düşünülerek tasarlanacak bir program  için 
    //            Kartlı işlem    1
    //            Kartsız işlem   2
    //            //********Kartlı işlem bölümü
    //            Şifre istenecek=> Şifre:ab18
    //            ==> şifrenin 3 defa yanlış olması halinde sistemden atılacak,değilse Ana Menü
    //            //*******************Ana Menü 
    //            Para Çekmek için    1
    //            Para yatırmak için  2
    //            Para Transferleri   3
    //            Eğitim Ödemeleri    4
    //            Ödemeler            5
    //            Bilgi Güncelleme    6
    //            //*********************Seçim 1************
    //            Bakiye yeterli ise para çekilecek,değilse yetersiz bakiye
    //            Ana meüye dönmek için   9
    //            Çıkmak için             0
    //            //******************Seçim 2***********************
    //            Kredi Kartına   1
    //            Kendi Hesabınıza yatırmak için  2
    //            Ana Menü        9
    //            Çıkmak için     0
    //            //------------------------------------
    //            //----1
    //            Kredi kardı için en az 12 haneli kart numarasını girsin
    //            bakiye yeterli ise hesaptan kredi kartına para yatırılaca
    //            Ana Menü        9
    //            Çıkmak için     0
    //            //--------------------------
    //            //---2
    //            hesaba yatırılacak para değeri istenir veişlem gerçekleştirilir
    //            Ana Menü        9
    //            Çıkmak için     0
    //            //*****************************Seçim 3
    //            Başka Hesaba EFT    1
    //            Başka Hesaba Havale 2
    //            //---------------------------------
    //            //--1
    //            EFT numarası istenecek ve başında tr olmalı ve sonrasında 12 haneli sayı işlemleri doğru ise
    //            yatılacak para istenir ,hesap uygun ise işlem gerçekleşir değilse
    //            Ana Menü        9
    //            Çıkmak için     0
    //            //-----------------------------
    //            //---2
    //            hesap için 11 haneli hesap numarası işlemler doğru ise
    //            gönderilecek para miktarı, hesap uygun ise transfer olacak ,değilse
    //            Ana Menü        9
    //            Çıkmak için     0
    //            //****************Seçim 4
    //            Eğitim Ödemeleri sayfası arızalı
    //            Ana Menü        9
    //            Çıkmak için     0
    //            //****************************Seçim 5
    //            Elektrik Faturası       1
    //            Telefon Faturası        2
    //            İnternet faturası       3
    //            Su Faturası             4
    //            OGS Ödemeleri           5
    //            //-----------------------------------------
    //            //---1 => bütün faturala için aşağıdaki şart yeterli
    //            fatura tutarı istenir, hesap uygun ise yatırılır değilse
    //            Ana Menü        9
    //            Çıkmak için     0
    //            //-----------------------------------
    //            //***************Seçim 6
    //            Şifre değiştirmek için 1
    //            Şifre değiştirme işlemi gerçekleştirilir
    //            Ana Menü        9
    //            Çıkmak için     0
    */


            #endregion

            string sifre = "ab18";
            double bakiye = 25000;
            int gunlukSinir = 10000;

            Console.WriteLine("Kartlı İşlem:1\nKartsız İşlem:2\nSeçiminiz:");
            int kartli = Convert.ToInt32(Console.ReadLine());

            if (kartli == 1)
            {
                int hak = 3;
                bool giris = false;
                while (hak > 0)
                {
                    Console.WriteLine("Şifreniz:");
                    string sfr = Console.ReadLine();

                    if (sfr == sifre)
                    {
                        giris = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Hatalı Şifre Girişi!");
                        hak--;
                    }
                }

                if (giris)
                {

                    while (true)
                    {
                        Console.WriteLine("Para Çekmek için    1\nPara yatırmak için  2\nPara Transferleri   3\nEğitim Ödemeleri    4\nÖdemeler            5\nBilgi Güncelleme    6");

                        Console.WriteLine("İşleminiz:");
                        string islem = Console.ReadLine();
                        if (islem == "1")
                        {
                            Console.WriteLine("Çekilecek Miktar:");
                            int miktar = Convert.ToInt32(Console.ReadLine());

                            if (bakiye >= miktar)
                            {
                                bakiye -= miktar;
                                Console.WriteLine("Paranızı Alınız.Yeni Bakiye:" + bakiye);
                            }
                            else
                            {
                                Console.WriteLine("Yetersiz Bakiye!");
                            }
                        }
                        else if (islem == "2")
                        {
                            Console.WriteLine("Kredi Kartı   1\nHesap         2\nSeçiminiz:");
                            int yatirma = Convert.ToInt32(Console.ReadLine());

                            if (yatirma == 1)
                            {
                                Console.WriteLine("16 haneli kart numaranız:");
                                string kartNo = Console.ReadLine();

                                if (kartNo.Length == 16)
                                {
                                    Console.WriteLine("Yatırılacak Miktar:");
                                    int miktar = Convert.ToInt32(Console.ReadLine());

                                    if (bakiye >= miktar)
                                    {
                                        bakiye -= miktar;
                                        Console.WriteLine("Kartınıza para yatırıldı.Yeni Bakiye:" + bakiye);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Yetersiz Bakiye!");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Kart numaranız hatalı!");
                                }

                            }
                            else if (yatirma == 2)
                            {
                                Console.WriteLine("Yatırılacak Miktar:");
                                int miktar = Convert.ToInt32(Console.ReadLine());

                                bakiye += miktar;

                                Console.WriteLine("Yeni Bakiye:" + bakiye);
                            }
                            else { Console.WriteLine("Hatalı İşlem Seçimi!"); }
                        }
                        else if (islem == "3") 
                        {
                            Console.WriteLine("EFT     1\nHavale   2\nSeçiminiz:");
                            int transfer = Convert.ToInt32(Console.ReadLine());

                            if (transfer == 1) 
                            {
                                Console.WriteLine("IBAN:");
                                string iban = Console.ReadLine().ToUpper(); //TR123456789098

                                if(iban.StartsWith("TR") && iban.Length == 14)
                                {
                                    string Iban = iban.Substring(2); //123456789098

                                    if(int.TryParse(Iban,out int IBAN))
                                    {
                                        Console.WriteLine("Transfer edilecek miktar:");
                                        int miktar = Convert.ToInt32(Console.ReadLine());

                                        if (bakiye >= miktar)
                                        {
                                            if (gunlukSinir >= miktar)
                                            {
                                                bakiye -= miktar;
                                                gunlukSinir -= miktar;

                                                Console.WriteLine("Transfer Başarılı.Yeni Bakiye:"+bakiye);
                                            }
                                            else
                                            {
                                                Console.WriteLine("Günlük Para Transfer Limitiniz Aşıldı!");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Yetersiz Bakiye!");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Iban 12 haneli rakamlar dizisinden oluşur.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Iban bilgisi hatalı!");
                                }
                            }
                            else if (transfer == 2) 
                            {
                                Console.WriteLine("Hesap Numarası:");
                                string hesapNo = Console.ReadLine();

                                if(hesapNo.Length==11 && int.TryParse(hesapNo,out int hesapno))
                                {
                                    Console.WriteLine("Transfer edilecek miktar:");
                                    int miktar = Convert.ToInt32(Console.ReadLine());

                                    if (bakiye >= miktar)
                                    {
                                        bakiye -= miktar;
                                        Console.WriteLine("Havale Başarılı.Yeni Bakiye:"+bakiye);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Yetersiz Bakiye!");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı Hesap Numarası!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Hatalı Seçim!");
                            }
                        }
                        else if (islem == "4") 
                        {
                            Console.WriteLine("Eğitim Ödemeleri Alanı Arızalı!");
                        }
                        else if (islem == "5") 
                        {
                            Console.WriteLine("Elektrik Faturası       1\nTelefon Faturası        2\nİnternet faturası       3\nSu Faturası             4\nOGS Ödemeleri           5");

                            Console.WriteLine("Seçiminiz:");
                            int fatura = Convert.ToInt32(Console.ReadLine());

                            if (fatura == 1) 
                            {
                                if (bakiye >= 1500)
                                {
                                    bakiye -= 1500;
                                    Console.WriteLine("Fatura ödendi.Yeni Bakiye:"+bakiye);
                                }
                                else
                                {
                                    Console.WriteLine("Yetersiz Bakiye!");
                                }
                            }
                            else if (fatura == 2) 
                            {
                                if (bakiye >= 1500)
                                {
                                    bakiye -= 1500;
                                    Console.WriteLine("Fatura ödendi.Yeni Bakiye:" + bakiye);
                                }
                                else
                                {
                                    Console.WriteLine("Yetersiz Bakiye!");
                                }
                            }
                            else if (fatura == 3) 
                            {
                                if (bakiye >= 1500)
                                {
                                    bakiye -= 1500;
                                    Console.WriteLine("Fatura ödendi.Yeni Bakiye:" + bakiye);
                                }
                                else
                                {
                                    Console.WriteLine("Yetersiz Bakiye!");
                                }
                            }
                            else if (fatura == 4) 
                            {
                                if (bakiye >= 1500)
                                {
                                    bakiye -= 1500;
                                    Console.WriteLine("Fatura ödendi.Yeni Bakiye:" + bakiye);
                                }
                                else
                                {
                                    Console.WriteLine("Yetersiz Bakiye!");
                                }
                            }
                            else if (fatura == 5) 
                            {
                                if (bakiye >= 1500)
                                {
                                    bakiye -= 1500;
                                    Console.WriteLine("Fatura ödendi.Yeni Bakiye:" + bakiye);
                                }
                                else
                                {
                                    Console.WriteLine("Yetersiz Bakiye!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Hatalı Fatura Seçimi!");
                            }
                        }
                        else if (islem == "6") 
                        {
                            Console.WriteLine("Yeni Şifreniz:");
                            string yeniSifre = Console.ReadLine();

                            Console.WriteLine("Tekrar Yeni Şifreniz:");
                            string yeniSifre2 = Console.ReadLine();
                            if (yeniSifre == yeniSifre2)
                            {
                                sifre = yeniSifre;
                            }

                        }
                        else { Console.WriteLine("Hatalı İşlem Seçimi!"); }

                    }
                }

            }
            else if (kartli == 2)
            {

            }
            else
            {
                Console.WriteLine("Hatalı Tuşlama!");
            }
        }
    }
}
