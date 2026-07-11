namespace _10_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             ********** ARRAYS - DİZİLER **********
             *Değişkenler tek bir veri tutarken, diziler aynı veri tipinde olmak şartı ile birden fazla değer tutabilirler.
             *Diziler içerisinde tutukları dataları INDEX adı verilen ve 0'dan başlayarak 1'er 1'er artan bir numaralandır yöntemi ile tanımlanırlar. 
             */

            //int sayi = 10; //Değişkendir ve tek data tutar.

            //**Boş Bir Dizi Tanımı
            //int[] sayilar = new int[10]; //10 adet int tipiden değer tutabilir.

            //**Diziye Değer Ekleme İşlemi
            //sayilar[0] = 10;
            //sayilar[5] = 70;

            //sayilar[10] = 25;//IndexOutOfRange aralık dizi index değeri girildi hatası

            //**Dolu Dizi Tanımı
            //string[] sehirler = { "İstanbul", "Kars", "Adıyaman", "İzmir" };

            //**Dizideki Elemanı Index Üzerinden Ekrana Yazdırma
            //Console.WriteLine(sehirler[2]);
            //Console.WriteLine(sehirler[6]);

            #region Kullanıcıdan 5 adet tam sayı alarak bir diziye ekleyiniz

            //int[] sayilar = new int[5];

            //for (int i = 0; i < 5; i++) //i:0,1,2,3,4
            //{
            //    Console.WriteLine("Sayı giriniz:");
            //    int sayi = Convert.ToInt32(Console.ReadLine());

            //    sayilar[i] = sayi;
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}



            #region Ayşe
            //int[] sayilar = new int[5];
            //Console.WriteLine("Lütfen 5 tane sayı giriniz:");
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write((i + 1) + ". sayıyı giriniz: ");
            //    sayilar[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("Diziniz şu şekildedir:");
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write(sayilar[i] + " ");
            //}
            #endregion

            #endregion

            #region Kullanıcıdan kaç personeli olduğu bilgisini alınız. Daha sonra personel isimlerini kullanıcıdan alarak diziye ekleyiniz.

            //Console.WriteLine("Kaç personeliniz?");
            //int personelSayisi = Convert.ToInt32(Console.ReadLine());

            //string[] personeller = new string[personelSayisi];

            //for (int i = 0; i < personelSayisi; i++)
            //{
            //    Console.WriteLine("Personel Ad:");
            //    personeller[i] = Console.ReadLine();
            //}

            //for (int i = 0; i < personelSayisi; i++)
            //{
            //    Console.WriteLine(personeller[i]);
            //}

            #endregion
            #region ARRAY SINIFI METOTLARI

            //int[] sayilar = { 11, 22, 33, 44, 55, 66, 77, 88, 99, 66, 44 };

            #region CLEAR()

            //Dizi içindeki değerleri siler
            //Array.Clear(sayilar,2,3); //2.indexten başla 3 değeri sil.

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}

            #endregion

            #region COPY()
            ////Belirli bir koleksiyonu bir diğerine kopyalar.

            //int[] sayilar2 = new int[10];
            ////Array.Copy(sayilar, sayilar2,3); //sayilar dizisinden sayilar2 dizine ilk 3 değeri kopyala

            //Array.Copy(sayilar, 2, sayilar2, 3, 4);//sayilar dizisinin 2. indexten itibaren sayilar2 dizisinin 3.indexinden itibaren 4 değeri kopyala

            //for (int i = 0; i < sayilar2.Length; i++)
            //{
            //    Console.WriteLine(sayilar2[i]);
            //}

            #endregion

            #region INDEXOF()

            //int indx = Array.IndexOf(sayilar, 22);
            //Console.WriteLine("22 sayısının index değeri:"+indx);

            //int indx = Array.IndexOf(sayilar, 44);
            //Console.WriteLine("44 sayısının ilk index değeri:" + indx);


            //int indx = Array.IndexOf(sayilar, 44,4);
            //Console.WriteLine("44 sayısının 2. index değeri:" + indx);


            //Aşağıdaki isimler dizisindeki Ali değerlerinin index numaraları ekrana yazdırınız

            //string[] isimler = { "Ali", "Veli", "Ali", "Emre", "Ayhan", "Ali" };

            #region Ayşe
            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    if (isimler[i] == "Ali")
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion

            //int indx = -1;
            //while (true)
            //{
            //    indx = Array.IndexOf(isimler,"Ali", indx + 1);
            //    if (indx != -1)
            //    {
            //        Console.WriteLine(indx);
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}


            #endregion

            #region LASTINDEXOF()
            ////Belirtilen değerin dizideki son index numarasını döndürür.

            //Console.WriteLine(Array.LastIndexOf(sayilar,44));

            #endregion

            #region SORT()

            //string[] sehirler = { "Zonguldak", "Adana", "İstanbul", "Yozgat", "Kars", "Balıkesir", "Çanakkale", "Şırnak", "Kırklareli" };

            //Array.Sort(sehirler);

            //for (int i = 0; i < sehirler.Length; i++)
            //{
            //    Console.WriteLine(sehirler[i]);
            //}


            #endregion

            #region REVERSE()

            //string[] sehirler = { "Zonguldak", "Adana", "İstanbul", "Yozgat", "Kars", "Balıkesir", "Çanakkale", "Şırnak", "Kırklareli" };

            //Array.Sort(sehirler);
            //Array.Reverse(sehirler);

            //for (int i = 0; i < sehirler.Length; i++)
            //{
            //    Console.WriteLine(sehirler[i]);
            //}

            #endregion

            #region RESIZE()

            //string[] isimler = { "Altan", "Kıvanç", "Kerem", "Uras" };

            ////isimler[4] = "Ceylan";

            //int[] rakamlar = new int[3];
            //rakamlar[0] = 11;
            //rakamlar[1] = 12;
            //rakamlar[2] = 13;

            //Array.Resize(ref rakamlar, 10);

            //rakamlar[3] = 14;

            #endregion


            #endregion

            #region Verilen bir string değerin harflerini alt alta yazdırma

            //string isim = "Altan Emre Demirci"; //String değerler aslında karakterleden oluşan bir dizidir.

            //for (int i = 0; i < isim.Length; i++)
            //{
            //    Console.WriteLine(isim[i]);
            //}


            #endregion

            #region Bir dizinin eleman sayısı 10 ile 20 arasında rastgele bir değer olarak atansın
            //Bu dizinin elemanlarını da sistem 0,100 aralığında ratgele olarak atasın.
            //Otomatik oluşturulan bu dizinin eleman sayısını ve elemanlarını kullanıcıya gösteriniz.
            //Aynı sayılar tekrar atanmasın
            //Dizinin en büyük ve en küçük değerilerini kullanıcıya gösteriniz. 
            #region Emirhan
            //Random r = new Random();
            //int i = r.Next(10, 20);
            //int[] sayilar = new int[i];
            //for (int j = 0; j < i; j++)
            //{
            //    int a = r.Next(1, 100);
            //    if (sayilar.Contains(a))
            //    {
            //        j -= 1;
            //        continue;
            //    }
            //    else
            //    {
            //        sayilar[j] = a;
            //    }
            //}
            //for (int w = 0; w < i; w++)
            //{
            //    Console.WriteLine(sayilar[w]);
            //}
            #endregion

            //Random r = new Random();

            //int[] dizi = new int[r.Next(10, 20)]; //10

            //int i = 0;
            //while (i < dizi.Length) //i:0,1,2,3,4,5,6,7,8,9
            //{
            //    int sayi = r.Next(0, 100);
            //    if (dizi.Contains(sayi) == false)
            //    {
            //        dizi[i] = sayi;
            //        i++;
            //    }
            //}

            //for (int x = 0; x < dizi.Length; x++)
            //{
            //    Console.WriteLine(dizi[x]);
            //}

            //Array.Sort(dizi); //küçükten büyüğe 

            //Console.WriteLine("En küçük değer:"+dizi[0]);
            //Console.WriteLine("En büyük değer:"+dizi[dizi.Length-1]);


            #endregion


            #region Sort() metodunu kullanmadan en büyük ve en küçük değeri bulma
            //int[] sayilar = { 1, 5, 45, 23, 12, 34, 7, 8, 9, 56, 6 };

            //int enkucuk = sayilar[0];
            //int enbuyuk = sayilar[0];

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] > enbuyuk)
            //    {
            //        enbuyuk = sayilar[i];
            //    }
            //    if (sayilar[i] < enkucuk)
            //    {
            //        enkucuk = sayilar[i];
            //    }
            //}

            //Console.WriteLine("En Küçük Sayı:"+enkucuk);
            //Console.WriteLine("En Büyük Sayı:"+enbuyuk);

            #endregion

            #region Kullanıcıdan 4 adet ürün fiyatı isteyiniz. Ürün fiyatlarında 1200 lira geçen ürünlerde %32 indirim uygulayarak bir diziye ekleyiniz.

            #region Emirhan
            //double[] fiyatlar = new double[4];

            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine("Urun fiyati diriniz: ");
            //    double fiyat = Convert.ToDouble(Console.ReadLine());
            //    if (fiyat > 1200)
            //    {
            //        //fiyat = fiyat * 68 / 100;
            //        fiyat = fiyat * 0.68;
            //    }
            //    fiyatlar[i] = fiyat;
            //}
            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine(fiyatlar[i]);
            //}
            #endregion

            #endregion


            #region FOREACH

            string[] isimler = { "Altan", "Emre", "Derya", "Tuğba" };

            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine(isimler[i]);
            //}

            foreach(string ad in isimler) //Sadece dizi içerisindeki elemanları yazdırmak için kullanılır.
            {
                Console.WriteLine(ad);
            }


            #endregion

        }
    }
}
