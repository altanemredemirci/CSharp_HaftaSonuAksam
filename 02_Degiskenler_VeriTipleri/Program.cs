namespace _02_Degiskenler_VeriTipleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DEĞİŞKENLER
            //Değişkenler:Yazılım içerisinde değer tanımlamaya,değeri taşımaya ve kullanmaya yarayan yazılım yapılarıdır.

            //** Değişken Tanımlama **
            //Veritipi değişkenadı = değer 

            //**** Yazılım dillerinde küçük harf BÜYÜK HARF duyarlılığı VARDIR.
            //*** Değişken İsimlendirme Kuralları ***
            /*
             yanlışlar:3sayi, ?sayi, sayi!, sa!yi, ad soyad, VeritipiİsmleriVerilemez int double = 10
             doğrular :sayi3, _sayi, sayi_, ad_soyad, adsoyad
                ** alt çizgi _ her yazılım dilinde kabul edilen tek özel karakterdir.
            
             
            string adSoyad = "Altan Emre Demirci"

            SnakeCase = ad_soyad
            KebabCase = ad-soyad
            UpperCase = ADSOYAD
            LowerCase = adsoyad
            PascalCase = AdSoyad
            CamelCase = adSoyad            
             
             
             */



            //int sayi = 10;
            //Console.WriteLine(sayi);


            //Console.WriteLine("Adınız:");
            //string ad = Console.ReadLine();

            //Console.WriteLine(ad);


            //double sayi1 = 10.5;
            //int sayi2 = 15;

            //Console.WriteLine(sayi2+sayi1);


            //long tc = 12345678901;//int max 10 basamaklı sayı alır. Üzerinde olan sayılarda long kullanılır.

            //float sayi = 10.5F;
            //double sayi2 = 10.5;
            //decimal sayi3 = 10.5m;


            //char not = 'A';
            //char islem = '?';
            //char sayi = '1';

            //string Ad = "Altan Emre";
            //string ad= "Sercan";
            //string metin = "Türkiye olağanüstü güzellikte bir ülkedir.";


            #endregion

            #region VERİ TİPLERİ

            /*
             Tanımlana bir değerin sözel,sayısal veya mantıksal veri tiplerinden hangisi olduğunu tanımlar.
            1-SAYISAL VERİ TİPLERİ
                *Tam Sayılar: +/- tam sayıları tanımlar. 
                    byte,sbyte,short,ushort,int,uint,long,ulong
                    
                
                *Ondalıklı Sayılar:+/- ondalıklı sayıları tanımlar.
                    float ve double
                    float tanımlarken sayının sonuna f harfi konur.
                
                decimal:Bütün sayı tiplerini karşılayan en büyük sayısal veri tipidir.decimal tanımlarken sayının sonuna m harfi konur.

            2-SÖZEL VERİ TİPLERİ
                *char:Tek bir karakter tutabilir.Tanımlarken ' tek tırnak ile tanımlanır.
                *string:Ram bellek boyutunca data tutabilir.Tanımlarken " çift tırnak ile tanımlanır.
                
            3-MANTIKSAL VERİ TİPİ(Boolean)
                *bool:Sadece bir karşılaştırma sonucu olarak true veya false değerini tutar.
             */

            //bool sonuc = 3>5;
            //bool sonuc2 = 3 < 5;
            //Console.WriteLine(sonuc2);

            #endregion

            #region SCOPE - KAPSAM
            //Süslü parantezler içerisinde tanımlanan değer sadece bu parantezler içerisinde kullanılabilir.
            //int a = 10;
            //{
            //    Console.WriteLine(a);

            //    int b = 5;

            //    Console.WriteLine(b);
            //}


            //Aşağıdaki örnek farklı kapsamlarda olması sebebiyle hata verir.
            //{
            //    int a = 10;
            //}

            //{
            //    Console.WriteLine(a);
            //}


            #endregion

            #region CONSTANT

            //int sayi = 10;
            //sayi = 20;//sayi değişkenin değerini revize ettim.
            //Console.WriteLine(sayi);


            ////Constant sabit değer anlamına gelir ve değiştirilemez.
            //const int sayi2 = 10;
            //sayi2 = 20;


            #endregion
        }
    }
}
