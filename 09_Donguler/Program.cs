using System.Runtime.InteropServices.Marshalling;

namespace _09_Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             DÖNGÜLER: Belirli bir işlemi istenilen kadar tekrar çalıştırmayı sağlar.
            *While
            *For
            *Do While
            *Foreach
             */

            //1-10 aralığındaki sayıları ekrana yazdırınız
            //Console.WriteLine(1);
            //Console.WriteLine(2);
            //Console.WriteLine(3);
            //Console.WriteLine(4);
            //Console.WriteLine(5);
            //Console.WriteLine(6);
            //Console.WriteLine(7);
            //Console.WriteLine(8);
            //Console.WriteLine(9);
            //Console.WriteLine(10);

            //int i = 1;

            //while (i < 11) //i değeri 11'den küçük olduğu sürece tekrar tekrar çalıştır
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            #region 1-50 aralığındaki sayıları ekrana alt alta yazdırınız
            //int i = 1;

            //while (i <= 50)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            #endregion

            #region 250-50 aralığındaki sayıları 5'er 5'er azaltarak ekrana yazdırınız
            //int i = 250;

            //while (i > 50)
            //{
            //    Console.WriteLine(i);
            //    i = i - 5;
            //}
            #endregion

            #region 250-50 arasında 3'ün katları olan sayıları ekrana yazdırınız
            #region EMİR
            //int i = 249;

            //while (i >= 50)
            //{
            //    Console.WriteLine(i);
            //    i = i - 3;
            //}
            #endregion

            //int i = 250;
            //while (i >= 50)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i--;
            //}

            #endregion

            #region Kullanıcıdan bir sayı alınız. o sayıdan 0'a kadar olan sayılardan 3'ün katlarını ekrana yazdırınız. 

            //Console.WriteLine("Bir sayı giriniz:");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //while (sayi > 0)
            //{
            //    if (sayi % 3 == 0)
            //    {
            //        Console.WriteLine(sayi);
            //    }
            //    sayi--;
            //}


            #endregion
            #region 1-10 aralığındaki sayıların toplamını ekrana yazdırınız.

            //int i = 1;

            //int toplam = 0;

            //while (i < 11)
            //{
            //    toplam = toplam + i;
            //    i++;
            //}

            //Console.WriteLine("Sonuç:" + toplam);
            #endregion

            #region 1-100 aralığındaki tek sayıların toplamını ekrana yazdırınız

            #region Ayşe
            //int i = 1;
            //int toplam = 0;
            //while (i < 101)
            //{
            //    if (i % 2 == 1)
            //    {
            //        toplam = toplam + i;
            //    }
            //    i++;
            //}
            //Console.WriteLine("1-100 arasındaki tek sayıların toplamı: " + toplam);
            #endregion

            #endregion

            #region BREAK - CONTINUE
            /*
             Break:Döngüyü istenilen satırda kırar.

             Continue: Okunduğu satırdan programı tekrar döngü satırına geri getirir.
             
             Sonsuz döngü: While koşuluna true olması ile döngü çalışır. Eğer koşul satırına direk true yazarsak döngü sonsuza kadar çalışır.
             */

            //int i = 1;
            //while (i < 10)
            //{
            //    if (i == 3)
            //    {
            //        i++;
            //        continue;
            //    }

            //    if (i == 7)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
            //    i++;
            //}

            //while (true)
            //{
            //    Console.WriteLine("Devam etmek ister misiniz?(E/H)");
            //    string cevap = Console.ReadLine().ToUpper();

            //    if (cevap == "H")
            //    {
            //        break;
            //    }
            //}
            #endregion

            #region Kullanıcı 0 sayısını girene kadar alınan sayıları toplayan ve 0 girildiğinde döngüyü bitirerek toplamı ekrana yazdıran while döngüsü
            #region Ayşe
            //int toplam = 0;
            //int sayi = 1;
            //while (sayi != 0)
            //{
            //    Console.WriteLine("Bir sayı giriniz");
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //    if (sayi != 0)
            //    {
            //        toplam = toplam + sayi;
            //    }
            //}
            //Console.WriteLine("Toplam: " + toplam);
            #endregion

            //int toplam = 0;

            //while (true)
            //{
            //    Console.WriteLine("Sayı giriniz:");
            //    int sayi = Convert.ToInt32(Console.ReadLine());

            //    if (sayi == 0)
            //    {
            //        break;
            //    }

            //    toplam = toplam + sayi;
            //}

            //Console.WriteLine("Toplam:"+toplam);
            #endregion
            #region Kullanıcıdan 0 girilene kadar pozitif sayı girmesi istensin
            //0 girilene kadar girilen sayılar toplansın 
            //Kullanıcı 0 girdiğinde döngü bitsin. sayıların toplamı ve ortalaması ekrana yazdırılsın
            //**kullanıcı negatif sayı girerse "Lütfen pozitif sayı giriniz" diye uyarı verilsin.

            #region EMİR
            //int toplam = 0;
            //int adet = 0;
            //while (true)
            //{
            //    Console.WriteLine("Sayı giriniz:");
            //    int sayı = Convert.ToInt32(Console.ReadLine());

            //    if (sayı < 0)
            //    {
            //        Console.WriteLine("Pozitif sayı girin");
            //        continue;
            //    }
            //    if (sayı == 0)
            //    {
            //        break;
            //    }
            //    toplam = toplam + sayı;
            //    adet++;
            //}
            //double ortalama = (double)toplam / adet;
            //Console.WriteLine("Toplam = " + toplam);
            //Console.WriteLine("Ortalama = " + ortalama);
            #endregion




            #endregion


            #region FOR DÖNGÜSÜ

            //1-10 aralığındaki sayıları ekrana yazdırınız
            //int i = 0;
            //while (i < 11)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //for(sayaçTanımı,koşul,arttırma)
            //for (int i = 0; i < 11; i++)
            //{
            //    Console.WriteLine(i);
            //}

            #region Kullanıcadan alınan sayıdan 0'a kadar olan sayıları ekrana yazdıran for döngüsü
            #region AYŞE
            //Console.WriteLine("Bir sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //for (int i = sayi; i >= 0; i--)
            //{
            //    Console.WriteLine(i);
            //}



            #endregion


            #endregion

            #region Kullanıcıdan alınan bir sayının faktöriyelini hesaplayarank ekrana yazan for döngüsü

            //5 => 1*2*3*4*5 => 120

            //int faktoriyel = 1;

            //Console.WriteLine("Faktöriyel hesaplanacak sayı:");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= sayi; i++)
            //{
            //    faktoriyel *= i; //faktoriyel=faktoriyel*i;
            //}

            //Console.WriteLine("Sonuç:"+faktoriyel);
            #endregion

            #region 1-500 aralığıdan 13'ün katı olan kaç adet sayı vardır ekrana yazdırınız
            //int adet = 0;
            //for (int i = 1; i <= 500; i++)
            //{
            //    if (i % 13 == 0)
            //    {
            //        adet++;
            //    }
            //}
            //Console.WriteLine("13'ün katı olan sayı adedi: " + adet);
            #endregion

            #region Kullanıcıdan alınan başlangıç ve bitiş değerleri arasındaki tek sayıları ayrı çift sayıları ayrı toplayarak sonucu ekran yazdırınız

            //Console.WriteLine("Başlangıç Sayısı:");
            //int basla = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Bitiş Sayısı:");
            //int bitis = Convert.ToInt32(Console.ReadLine());

            //int tektoplam = 0;
            //int cifttoplam = 0;

            //for (int i = basla; i < bitis; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        cifttoplam += i;
            //    }
            //    else
            //    {
            //        tektoplam += i;
            //    }
            //}

            //Console.WriteLine("TekToplam:"+tektoplam);
            //Console.WriteLine("ÇiftToplam:"+cifttoplam);

            #endregion

            #endregion

            #region RANDOM Rastgele Sayı Oluşturma

            //Random r = new Random();

            //Console.WriteLine(r.Next(1,100)); //1-100 aralığında rastgele bir sayı oluşturur.

            //int sayi = r.Next(1, 2000);
            //Console.WriteLine(sayi);


            //1-100 aralığında bir rastgele sayı oluşacak kullanıcıdan 5 seferde bu sayıyı bilmesini isteyiniz

            #region Emirhan
            //Random r = new Random();
            //int sayi = r.Next(1, 100);
            //Console.WriteLine(sayi);
            //int denemehakki = 5;

            //while (denemehakki > 0)
            //{
            //    Console.WriteLine("Bir sayı giriniz");
            //    int tahmin = Convert.ToInt32(Console.ReadLine());


            //    if (tahmin == sayi)
            //    {
            //        Console.WriteLine("Tebrikler doğru bildiniz!");
            //        break;
            //    }
            //    else
            //    {
            //        denemehakki -= 1;
            //        Console.WriteLine("Yanlış tekrar deneyin!");

            //    }
            //}
            //if (denemehakki == 0)
            //{
            //    Console.WriteLine("Doğru cevap: " + sayi);
            //}
            #endregion

            Random r = new Random();
            int rast = r.Next(1, 100);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Tahmininiz:");
                int tahmin = Convert.ToInt32(Console.ReadLine());

                if (tahmin == rast)
                {
                    Console.WriteLine("Tebrikler Bildiniz..");
                    break;
                }
                else if (tahmin > rast)
                {
                    Console.WriteLine("Tahmininizi küçültünüz");
                }
                else
                {
                    Console.WriteLine("Tahmininizi büyültünüz");
                }
            }



            #endregion
        }
    }
}
