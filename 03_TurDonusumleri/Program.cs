namespace _03_TurDonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region TÜR DÖNÜŞÜMLERİ - CONVERSION

            #region STRING(Sözel) Değeri Sayısala Çevirme
            //Console.WriteLine("Adınız:");
            //string ad = Console.ReadLine();

            //iki sayının toplamı kaçtır
            //Console.WriteLine("1.Sayı:");
            //int s1 = Console.ReadLine(); //Console.Readine() okunan string değerin int tipine dönüştürülmesi gereklidir.

            /*
            1.Bilinçsiz Tür Dönüşümü
            Genelde küçük veri tipinden büyük veri tipine atama işlemlerinde kullanılır.
             
             int sayi = 10;
             long sayi2 = sayi;
             
            2.Boxing
             long sayi = 10;
             int sayi2 = (int)sayi;
             

             long sayi = 102345678901297;
             int sayi2 = (int)sayi;
             Console.WriteLine(sayi2); //Değerin söylenen int değere sığmaması durumunda hatalı değer atanır.

            3.Bilinçli Tür Dönüşümü
             Farklı veri tipindeki değerleri birbirine kod yazılarak dönüştürülmesine denir.

             */

            //Console.WriteLine("Yaş:"); //36
            //string yas = Console.ReadLine();


            //Console.WriteLine("Yaş:"); //36
            //int yas = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(yas+5);


            #region Kullanıcıdan alınan 3 sayının toplamını ekrana yazdırınız.
            //Console.WriteLine("1. sayıyı girin: ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("2. sayıyı girin: ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("3. sayıyı girin: ");
            //int sayi3 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(sayi1 + sayi2 + sayi3);

            #endregion

            #region Kullanıcıdan Vize ve Final notlarını alınız. Girilen sınav notlarının toplamını 2 ye bölerek ortalamasını ekrana yazdırınız.

            //Console.WriteLine("Vize Notu:");
            //int vize = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Final Notu:");
            //int final = Convert.ToInt32(Console.ReadLine());

            ////Console.WriteLine((vize+final)/2);

            //double toplam = vize + final;
            //double ortalama = toplam / 2;
            //Console.WriteLine(ortalama);
            #endregion

            #region İki sayı alınız ve ortalamasını ekrana yazdırınız
            //Console.WriteLine("1.sayı:");
            //double sayi1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("2.sayı:");
            //double sayi2 = Convert.ToDouble(Console.ReadLine());

            //double ortalama = (sayi1 + sayi2) / 2;

            ////Console.WriteLine(ortalama);

            //Console.WriteLine("Ortalama:"+ortalama);
            #endregion




            #endregion


            #region SAYISAL Değeri SÖZELE Çevirme

            long tc = 12345678909;

            string TC = tc.ToString(); // Bu kod sayısal bir değeri sözel bir değere çevirir.

            Console.WriteLine(TC+5);
            #endregion


            #endregion



        }
    }
}
