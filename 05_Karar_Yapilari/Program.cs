namespace _05_Karar_Yapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ************* KARAR YAPILARI - AKIŞ KONTROL - CONDITION ************
            // If-Else ve Switch-Case
            //Karar yapılarında bir durumun sonucuna bağlı olarak kodun devam etmesini kontrol ediyoruz.

            #region IF ELSEIF ELSE
            //Kod içerisinde true veya false olarak cevaplanacak ve kodun bu cevaba göre hareket edeceği durumlarda kullanılır.
            //Her zaman ilk koşul if deyimi ile başlar.
            //ilk koşul dışında kalan her durum-koşul için else if deyimi kullanılır.
            //Her koşul kontrol edildikten sonra geriye kalan durumlar için else kullanılır. 

            #region Kullanıcıdan bir sayı alınız. Sayı 100'den büyük ise Ekrana büyüktür. 100'den küçük ise ekrana küçüktür yazdırınız.

            //sayi=bir sayı alınız
            //eğer sayi>100'den ekrana BÜYÜKTÜR yaz
            //değilse ekrana KÜÇÜKTÜR yaz

            //Console.WriteLine("Lütfen bir sayı giriniz:");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //if (sayi > 100)//durum true ise {} içindeki kod çalıştırılır.
            //{
            //    Console.WriteLine("BÜYÜKTÜR");
            //}
            //else //**else deyiminde koşul yazılmaz.
            //{
            //    Console.WriteLine("KÜÇÜKTÜR");
            //}

            #endregion
            #region Kullanıcıdan yaş bilgisi alınız. Yaşı 18 altında ise Çocuk, 18 ile 30 arasında ise Genç, 31 ile 50 arasında ise Orta Yaş, 51 ve üzerinde ise Yaşlı mesajını ekrana yazdıralım

            /*
            1-Başla
            2-yas=kullanicidan yaş bilgisi al
            3-Eğer yas<18 ise ekrana "çocuk" yaz
            4-Değilse Eğer yas>17 ve yas<31 ise "genç" yaz
            5-Değilse Eğer yas>30 ve yas<51 ise "orta yaş" yaz
            6-Değilse ekrana "yaşlı" yaz
            7-Bitti
             */


            //Console.WriteLine("Yaşınız:");
            //int yas = Convert.ToInt32(Console.ReadLine());
            //if (yas < 18)
            //{
            //    Console.WriteLine("Çocuk");
            //}
            //else if (yas > 17 && yas < 31)
            //{
            //    Console.WriteLine("Genç");
            //}
            //else if (yas > 30 && yas < 51)
            //{
            //    Console.WriteLine("Orta Yaş");
            //}
            //else
            //{
            //    Console.WriteLine("Yaşlı");
            //}

            #endregion
            #region Haftanın kaçıncı gününde olduğumuzu kullanıcıdan alalım. Eğer 1 ise ekrana Pazartesi,2 ise Salı ,... yazdıralım

            //Console.WriteLine("Haftanın kaçıncı günündeyiz:");
            //int gun = Convert.ToInt32(Console.ReadLine());
            //if (gun == 1)
            //{
            //    Console.WriteLine("Pazartesi");
            //}
            //else if (gun == 2)
            //{
            //    Console.WriteLine("Salı");
            //}
            //else if (gun == 3)
            //{
            //    Console.WriteLine("Çarşamba");
            //}
            //else if (gun == 4)
            //{
            //    Console.WriteLine("Perşembe");
            //}
            //else if (gun == 5)
            //{
            //    Console.WriteLine("Cuma");
            //}
            //else if (gun == 6)
            //{
            //    Console.WriteLine("Cumartesi");
            //}
            //else if (gun == 7)
            //{
            //    Console.WriteLine("Pazar");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı Gün Bilgisi!!");
            //}


            //2.Yöntem

            //Console.WriteLine("Haftanın kaçıncı günü:");
            //int gun = Convert.ToInt32(Console.ReadLine());

            //if(gun<1 || gun > 7) //gun değer 1'den küçük veya 7'den büyük ise hatalı bir giriş olmuştur.
            //{
            //    Console.WriteLine("Gün bilgisi hatalı!");
            //}
            //else
            //{
            //    if (gun == 1)
            //    {
            //        Console.WriteLine("Pazartesi");
            //    }
            //    else if (gun == 2)
            //    {
            //        Console.WriteLine("Salı");
            //    }
            //    else if (gun == 3)
            //    {
            //        Console.WriteLine("Çarşamba");
            //    }
            //    else if (gun == 4)
            //    {
            //        Console.WriteLine("Perşembe");
            //    }
            //    else if (gun == 5)
            //    {
            //        Console.WriteLine("Cuma");
            //    }
            //    else if (gun == 6)
            //    {
            //        Console.WriteLine("Cumartesi");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Pazar");
            //    }
            //}



            #endregion

            #region Kullanıcıdan iki ürün fiyatı alınız,Ürün fiyat toplamı 2500 lirayı geçerse ucuz olan ürüne %25 indirim uygulayınız ve toplam ödemeyi kullanıcıya söyleyiniz.

            //Console.WriteLine("1.Ürün Fiyatı:");
            //double fiyat1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("2.Ürün Fiyatı:");
            //double fiyat2 = Convert.ToDouble(Console.ReadLine());

            //double toplam = fiyat1 + fiyat2;

            //if (toplam > 2500)
            //{
            //    if (fiyat1 > fiyat2)
            //    {
            //        fiyat2 = fiyat2 * 0.75; // fiyat2*0.75

            //        //double indirim = (fiyat2 / 100) * 25;

            //        //fiyat2 = fiyat2 - indirim;
            //    }
            //    else
            //    {
            //        fiyat1 = fiyat1 * 0.75;
            //    }

            //    Console.WriteLine("Ödemeniz:" + (fiyat1 + fiyat2));
            //}
            //else
            //{
            //    Console.WriteLine("Ödemeniz:" + toplam);
            //}
            #endregion

            #region Aylık Geliri kullanıcıdan alınız. 40000 üstünde ise %12 vergi kesilecek. 
            //Aylık geliri 40000 ve altında ise %9 vergi keserek net geliri ekrana yazdır.

            //Console.WriteLine("Aylık geliriniz?: ");
            //double para = Convert.ToDouble(Console.ReadLine());

            //if (para > 40000)
            //{
            //    //double vergi = para / 100 * 12;
            //    //para = para - vergi;

            //    para = para * 0.88;
            //    Console.WriteLine("Net geliriniz: " + para);
            //}
            //else if (para <= 40000)
            //{
            //    para = para * 0.91;
            //    Console.WriteLine("Net geliriniz: " + para);
            //}

            #endregion

            #region Harcanan m3 istenilecek ve
            /*
             0-100 harcanmışsa 0.35 
             101-250 arasında ise 0.38 
             251-400 arasında ise 0.41
             401-600 arasında ise 0.42
             600 ve üstünde ise 0.43 ile çarparak fiyat hesaplanacak
             ve ekrana fatura tutarı yazdırılacak
             */

            //Console.WriteLine("Kaç m3?");
            //int metreKup = Convert.ToInt32(Console.ReadLine());

            //if (metreKup >= 0 && metreKup <= 100)
            //{
            //    Console.WriteLine(metreKup * 0.35);
            //}
            //else if (metreKup > 100 && metreKup <= 250)
            //{
            //    Console.WriteLine(metreKup * 0.38);
            //}
            //else if (metreKup > 200 && metreKup <= 400)
            //{
            //    Console.WriteLine(metreKup * 0.41);
            //}
            //else if (metreKup > 400 && metreKup <= 600)
            //{
            //    Console.WriteLine(metreKup * 0.42);
            //}
            //else
            //{
            //    Console.WriteLine(metreKup * 0.43);
            //}

            #region Emirhan
            //Console.WriteLine("m3 cinsinden sayı giriniz: ");
            //double alan = Convert.ToDouble(Console.ReadLine());
            //if (alan <= 100)
            //{
            //    alan = alan * 0.35;
            //    Console.WriteLine("Net geliriniz: " + alan);
            //}
            //else if (101 <= alan && alan <= 250)
            //{
            //    alan = alan * 0.38;
            //    Console.WriteLine("Alanin degeri: " + alan);
            //}
            //else if (251 <= alan && alan <= 400)
            //{
            //    alan = alan * 0.41;
            //    Console.WriteLine("Alanin degeri: " + alan);
            //}
            //else if (401 <= alan && alan < 600)
            //{
            //    alan = alan * 0.42;
            //    Console.WriteLine("Alanin degeri: " + alan);
            //}
            //else if (alan >= 600)
            //{
            //    alan = alan * 0.43;
            //    Console.WriteLine("Alanin degeri: " + alan);
            //}
            #endregion




            #endregion

            #region Kullanıcıdan alınan vize ve final notlarını üzerinden ortalama hesaplanacak ve ortalama notuna göre harf notu ekrana yazdıralacak. 
            //Ortalama=vize*0.40 + final*0.60
            /*
            0-24 FF
            25-44 DD
            45-54 CC
            55-69 CB
            70-84 BB
            85    AA
             
             */
            //Console.WriteLine("Vize notu:");
            //int vize = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Final notu:");
            //int final = Convert.ToInt32(Console.ReadLine());

            //double ortalama = vize * 0.40 + final * 0.60;

            //if (ortalama >= 0 && ortalama < 25)
            //{
            //    Console.WriteLine("FF");
            //}
            //else if (ortalama >= 25 && ortalama < 45)
            //{
            //    Console.WriteLine("DD");
            //}
            //else if (ortalama >= 45 && ortalama < 55)
            //{
            //    Console.WriteLine("CC");
            //}
            //else if (ortalama >= 55 && ortalama < 70)
            //{
            //    Console.WriteLine("CB");
            //}
            //else if (ortalama >= 70 && ortalama < 85)
            //{
            //    Console.WriteLine("BB");
            //}
            //else if (ortalama >= 85 && ortalama <= 100)
            //{
            //    Console.WriteLine("AA");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı Not Girişi");
            //}


            //GOTO Komutu

            //VIZE:
            //    Console.WriteLine("Vize:");
            //    int vize = Convert.ToInt32(Console.ReadLine());

            //    if (vize < 0 || vize > 100)
            //    {
            //        Console.WriteLine("Not 0-100 aralığında olmalıdır.");
            //        goto VIZE;
            //    }

            //FINAL:
            //    Console.WriteLine("Final:");
            //    int final = Convert.ToInt32(Console.ReadLine());

            //    if (final < 0 || final > 100)
            //    {
            //        Console.WriteLine("Not 0-100 aralığında olmalıdır.");
            //        goto FINAL;
            //    }

            //    double ortalama = vize * 0.40 + final * 0.60;

            //    if (ortalama >= 0 && ortalama < 25)
            //    {
            //        Console.WriteLine("FF");
            //    }
            //    else if (ortalama >= 25 && ortalama < 45)
            //    {
            //        Console.WriteLine("DD");
            //    }
            //    else if (ortalama >= 45 && ortalama < 55)
            //    {
            //        Console.WriteLine("CC");
            //    }
            //    else if (ortalama >= 55 && ortalama < 70)
            //    {
            //        Console.WriteLine("CB");
            //    }
            //    else if (ortalama >= 70 && ortalama < 85)
            //    {
            //        Console.WriteLine("BB");
            //    }
            //    else
            //    {
            //        Console.WriteLine("AA");
            //    }



            #endregion

            #region Aşağıda belirtilen kullanıcı adı ve şifre ile bir giriş paneli kodlayınız. Kullanıcının 3 giriş hakkı olacak.

            //    string username = "altanemre";
            //    string password = "123";

            //    int hak = 3;

            //DON:
            //    Console.WriteLine("Kullanıcı Adınız:");
            //    string kullaniciAdi = Console.ReadLine();

            //    Console.WriteLine("Şifreniz:");
            //    string sifre = Console.ReadLine();

            //    hak--;

            //    if(kullaniciAdi==username && sifre == password)
            //    {
            //        Console.WriteLine("Giriş Başarılı");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Giriş Bilgileriniz Hatalı!!");
            //        if (hak > 0)
            //        {
            //            goto DON;
            //        }

            //    }


            #endregion

            #endregion

            #region SWITCH CASE

            #region Haftanın kaçıncı gününde olduğumuzu kullanıcıdan alalım. Eğer 1 ise ekrana Pazartesi,2 ise Salı ,... yazdıralım

            //Console.WriteLine("Haftanın kaçıncı günündeyiz:");
            //int gun = Convert.ToInt32(Console.ReadLine());

            //switch (gun)
            //{
            //    case 1:
            //        Console.WriteLine("Pazartesi");
            //        break;

            //    case 2:
            //        Console.WriteLine("Salı");
            //        break;

            //    case 3:
            //        Console.WriteLine("Çarşamba");
            //        break;

            //    case 4:
            //        Console.WriteLine("Perşembe");
            //        break;

            //    case 5:
            //        Console.WriteLine("Cuma");
            //        break;

            //    case 6:
            //        Console.WriteLine("Cumartesi");
            //        break;

            //    case 7:
            //        Console.WriteLine("Pazar");
            //        break;

            //    default:
            //        Console.WriteLine("Hafta 7 gündür");
            //        break;
            //}

            #endregion

            #region Kullanıcıdan 2 adet sayı isteyiniz.Bu iki sayıdan sonra birde işlem seçmesini isteyiniz. Seçilen işleme göre sayılara toplama,çıkarma,çarpma veya bölme işlemi uygulanarak sonucu ekrana yazdırınız.

            //Console.WriteLine("1.Sayı giriniz:");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("2.Sayı giriniz:");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("İşlem Seçiniz:(+,-,*,/)");
            //string islem = Console.ReadLine();

            //switch(islem) 
            //{
            //    case "+":
            //        Console.WriteLine(sayi1+sayi2);
            //        break;

            //    case "-":
            //        Console.WriteLine(sayi1-sayi2);
            //        break;

            //    case "*":
            //        Console.WriteLine(sayi1 * sayi2);
            //        break;

            //    case "/":
            //        Console.WriteLine(sayi1 / sayi2);
            //        break;

            //    default:
            //        Console.WriteLine("Hatalı İşlem Seçimi!");
            //        break;
            //}


            #endregion
            #region Emeklilik Hesaplama
            /*
             Kullanıcıdan cinsiyet bilgisi alınız.

            ==> ERKEK
                yaşı bilgisi alınız.
                    yaşı 60 ve üstünde ise Maaş bilgisi alarak maaş*10 ile emekli ikramiyeniz diye ekrana yazdıralım.
                    yaşı 60'ın altında ise sigorta prim günü sayısı alalım
                        prim gün sayısı 6000 ve üstünde ise Maaş bilgisi alarak maaş*11 ile emekli ikramiyeniz diye ekrana yazdıralım.
                        prim gün sayısı 6000'ın altında ise "Emekli olamazsınız" ekrana yazdıralım
            ==> KADIN
                yaşı bilgisi alınız.
                    yaşı 58 ve üstünde ise Maaş bilgisi alarak maaş*10 ile emekli ikramiyeniz diye ekrana yazdıralım.
                    yaşı 58'ın altında ise sigorta prim günü sayısı alalım
                        prim gün sayısı 4500 ve üstünde ise Maaş bilgisi alarak maaş*11 ile emekli ikramiyeniz diye ekrana yazdıralım.
                        prim gün sayısı 4500'ın altında ise "Emekli olamazsınız" ekrana yazdıralım
             */

            Console.WriteLine("Cinsiyetiniz(E/K):");
            string cinsiyet = Console.ReadLine().ToUpper();

            if (cinsiyet == "E")
            {
                Console.WriteLine("Yaşınız:");
                int yas = Convert.ToInt32(Console.ReadLine());

                if (yas >= 60)
                {
                    Console.WriteLine("Maaşınız:");
                    int maas = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Emekli oldunuz.İkramiye:"+(maas*10));
                }
                else
                {
                    Console.WriteLine("Prim günü giriniz:");
                    int prim = Convert.ToInt32(Console.ReadLine());

                    if (prim >= 6000)
                    {
                        Console.WriteLine("Maaşınız:");
                        int maas = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Emekli oldunuz.İkramiye:" + (maas * 11));
                    }
                    else
                    {
                        Console.WriteLine("Emekli olamazsınız.");
                    }

                }
            }
            else if (cinsiyet == "K")
            {
                Console.WriteLine("Yaşınız:");
                int yas = Convert.ToInt32(Console.ReadLine());

                if (yas >= 58)
                {
                    Console.WriteLine("Maaşınız:");
                    int maas = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Emekli oldunuz.İkramiye:"+(maas*10));
                }
                else
                {
                    Console.WriteLine("Prim günü giriniz:");
                    int prim = Convert.ToInt32(Console.ReadLine());
                    if (prim >= 4500)
                    {
                        Console.WriteLine("Maaşınız:");
                        int maas = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Emekli oldunuz.İkramiye:" + (maas * 11));
                    }
                    else
                    {
                        Console.WriteLine("Emekli olamazsınız.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Hatalı Cinsiyet Girişi!");
            }

            #endregion
            #endregion
        }

    }


}