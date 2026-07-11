namespace _04_Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region OPERATÖRLER

            #region MATEMATİKSEL OPERATÖRLER (+,-,*,/,%)

            //int sayi1 = 10;
            //double sayi2 = 23;

            //Console.WriteLine(sayi2+sayi1);
            //Console.WriteLine(sayi2-sayi1);
            //Console.WriteLine(sayi2*sayi1);
            //Console.WriteLine(sayi2/sayi1);

            //Mod Al:Bir sayının bir sayıya bölümünden kalan değeri verir.

            //int sayi1 = 10;
            //int sayi2 = 3;

            //Console.WriteLine(sayi1%sayi2);

            #endregion


            #region ATAMA(=) ve İŞLEMLİ ATAMA OPERATÖRLERİ

            //int sayi = 10;

            //sayi = sayi + 5; // sayi+=5
            //sayi = sayi - 5; // sayi-=5
            //sayi = sayi * 5; // sayi*=5
            //sayi = sayi / 5; // sayi/=5

            //Console.WriteLine(sayi);

            #endregion


            #region BİR ARTTIRMA VE AZALTMA OPERATÖRÜ

            //int sayi = 10;
            //sayi++; //sayi=sayi+1;
            //sayi--;
            //Console.WriteLine(sayi);

            #endregion


            #region KARŞILAŞTIRMA OPERATÖRLERİ

            //int sayi = 5;
            //int sayi2 = 6;

            //bool sonuc = sayi>sayi2;
            //bool sonuc2 = sayi<sayi2;
            //bool sonuc3 = sayi>=sayi2;
            //bool sonuc4 = sayi<=sayi2;
            //bool sonuc5 = sayi==sayi2; // sayi1 sayi2'ye eşit mi?
            //bool sonuc6 = sayi!=sayi2; // sayi1 sayi2'ye eşit değiller mi?

            //Console.WriteLine(sonuc);
            //Console.WriteLine(sonuc2);
            //Console.WriteLine(sonuc3);
            //Console.WriteLine(sonuc4);
            //Console.WriteLine(sonuc5);
            //Console.WriteLine(sonuc6);



            //string username = "altanemre";

            //Console.WriteLine("Kullanıcı adınız:");
            //string kullaniciAdi = Console.ReadLine();

            //Console.WriteLine(kullaniciAdi==username);



            //Console.WriteLine("Yaşınız:");
            //int yas = Convert.ToInt32(Console.ReadLine());

            //bool sonuc = yas >= 18;

            //Console.WriteLine("Ehliyet alabilir mi:"+sonuc);



            #endregion


            #region KIYAS OPERATÖRÜ (?:)
            //Bİr karşılaştırma doğru(true) ise ? ile verdiğimiz alan, değilse(false) : ile verdiğimiz alan çalışır.

            //int sayi = 5;

            //string cevap = sayi < 6 ? "Sayı Büyüktür" : "Sayı Küçüktür";
            //int cevap = sayi < 6 ? 1 : 0;
            //Console.WriteLine(cevap);



            //string username = "altanemre";

            //Console.WriteLine("Kullanıcı adınız:");
            //string kullaniciAdi = Console.ReadLine();

            //string giris = kullaniciAdi == username ? "Giriş Başarılı" : "Giriş Başarısız";
            //Console.WriteLine(giris);
            #endregion


            #region ERİŞİM OPERATÖRÜ (.)

            //Console.ReadLine().ToUpper();

            //Convert.ToInt32("10");


            //Console.WriteLine();

            #endregion


            #region MANTIKSAL OPERATÖRLER

            #region AND OPERATÖRÜ &
            //Birden fazla koşulun kontrol edilmesi ve sonucun True olması için kontrol edilen her koşulun doğru olması gerekliyse AND & operatörü kullanılır.


            //Bir nevi çarpma işlemine benzer. Koşullardan biri 0 False olduğunda sonuç 0 yani false çıkar.

            //string username = "altanemre";
            //string password = "Ae123**";


            //Console.WriteLine("Kullanıcı adınız:");
            //string kullaniciAdi = Console.ReadLine();
            //Console.WriteLine("Şifre:");
            //string sifre = Console.ReadLine();

            //bool sonuc = kullaniciAdi == username && sifre == password;

            #endregion

            #region OR OPERATÖRÜ ||
            //Birden fazla koşulun kontrol edilmesi ve sonucun True olması için kontrol edilen koşullardan birinin doğru olması yeterliyse OR | operatörü kullanılır.


            //Bir nevi toplamı işlemine benzer. Koşullardan biri 1 True olduğunda sonuç 1 yani True çıkar.

            //string username = "altanemre";
            //string email = "altanemre@gmail.com";


            //Console.WriteLine("Kullanıcıadı / email:");
            //string kullanici = Console.ReadLine();

            ////Giriş başarılı olması için kullanıcı adı veya email bilgisinin doğru olması gereklidir.

            //bool sonuc = username == kullanici || email == kullanici;

            //Console.WriteLine(sonuc);

            #endregion

            #region NOT OPERATÖRÜ !
            //Sonucu True olan bir değeri False veya Sonucu False olan bir değeri True ya çevirir.

            bool sonuc = 5 > 4;
            Console.WriteLine(!sonuc);


            #endregion

            #endregion

            #endregion
        }
    }
}
