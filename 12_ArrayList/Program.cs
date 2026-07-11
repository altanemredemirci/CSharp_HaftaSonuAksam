using System.Collections;

namespace _12_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array : Sabit veri tipi ve sabit uzunluk

            //string[] isimler = new string[4];

            //int[] sayilar = { 11, 12, 13 };

            //ArrayList: Değişken veri tipi ve sınırsız bir uzunluk

            //ArrayList kullanımı için mutlaka using System.Collections; eklenmelidir.


            //Boş bir ArrayList
            //ArrayList arrayList = new ArrayList();

            //arrayList.Add("Altan");
            //arrayList.Add(35);
            //arrayList.Add(35.5);
            //arrayList.Add(35.5f);
            //arrayList.Add(35.5m);
            //arrayList.Add('?');

            //for (int i = 0; i < arrayList.Count; i++)
            //{
            //    Console.WriteLine(arrayList[i]);
            //}

            #region Kullanıcıdan 5 isim alarak bir arraylist e ekleyiniz ve ekrana yazdırınız
            //ArrayList isimler = new ArrayList();

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write((i + 1) + ". ismi giriniz: ");
            //    isimler.Add(Console.ReadLine());
            //}

            //Console.WriteLine("Girilen İsimler:");

            ////for (int i = 0; i < isimler.Count; i++)
            ////{
            ////    Console.WriteLine(isimler[i]);
            ////}

            //foreach (string item in isimler)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion


            //Dolu ArrayList Tanımı
            //ArrayList sehirler = new ArrayList() { "İstanbul", "Ankara", "Çanakkale" };

            //Console.WriteLine(sehirler[2]);

            //sehirler[4] = "Hatay"; //Olmayan index e ekleme işlemi hatalı olur.

            //sehirler[1] = "Antalya";

            //****İstenilen Index Değerine Ekleme İşlemi

            //sehirler.Insert(1, "Adıyaman"); //1. indexe Adıyaman ekler ve Ankara bir index ilerler.



            // **** COUNT ve CAPACITY
            //ArrayList sehirler = new ArrayList() { "İstanbul", "Ankara", "Çanakkale","Adana","Kars","Hakkari","Balıkesir","Sivas","Tokat" };

            //Console.WriteLine(sehirler.Capacity);
            //Console.WriteLine(sehirler.Count);


            // **** CLEAR
            //ArrayList sehirler = new ArrayList() { "İstanbul", "Ankara", "Çanakkale", "Adana", "Kars", "Hakkari", "Balıkesir", "Sivas", "Tokat" };

            //sehirler.Clear(); //Bütün değerler silinir.


            #region Kullanıcıdan aile birey sayısını öğrenin daha sonra aile birey isimelrini alarak bir arrayliste ekleyin
            //ArrayList aileBireyleri = new ArrayList();
            //Console.WriteLine("Ailenizde kaç birey var?");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < sayi; i++)
            //{
            //    Console.WriteLine((i + 1) + ". aile bireyinin adını giriniz:");
            //    string isim = Console.ReadLine();
            //    aileBireyleri.Add(isim);
            //}
            //Console.WriteLine("Aile bireyleri:");
            //for (int i = 0; i < aileBireyleri.Count; i++)
            //{ 
            //    Console.WriteLine(aileBireyleri[i]); 
            //}
            //foreach (string ad in aileBireyleri)
            //{
            //    Console.WriteLine(ad);
            //}
            #endregion


            //**** REMOVE()
            //ArrayList sehirler = new ArrayList() { "İstanbul", "Ankara", "Çanakkale", "Adana", "Kars", "Hakkari", "Balıkesir", "Sivas", "Tokat" };

            //sehirler.Remove("Kars"); //Girilen değeri arraylisten siler.

            //sehirler.RemoveAt(2); //2. indexdeki değeri siler.


            //**** SORT()
            //sehirler.Sort(); //Alfabetik sıraya koyar.

            //foreach (string item in sehirler)
            //{
            //    Console.WriteLine(item);
            //}

            //**** REVERSE()

            //sehirler.Reverse(); //Tanımlı koleksiyonu tersine çevirir.
            //foreach (string item in sehirler)
            //{
            //    Console.WriteLine(item);
            //}


            //**** CLONE()

            //ArrayList sehirler = new ArrayList() { "İstanbul", "Ankara", "Çanakkale" };

            //ArrayList arrayList = new ArrayList();
            //arrayList = (ArrayList)sehirler.Clone();

            //foreach (string item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}


            //**** ADDRANGE()
            //ArrayList sehirler = new ArrayList() { "İstanbul", "Ankara", "Çanakkale" };
            //sehirler.Add("Kars");

            //ArrayList iller = new ArrayList() { "Adana", "Kahramanmaraş", "Siirt" };

            //sehirler.AddRange(iller);

            //foreach (string item in sehirler)
            //{
            //    Console.WriteLine(item);
            //}


            //**** CONTAINS()

            //ArrayList iller = new ArrayList() { "Adana", "Kahramanmaraş", "Siirt" };

            //if (iller.Contains("Kars"))
            //{
            //    Console.WriteLine("Kars mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Kayıtlı Değil");
            //}


            //**** INDEXOF()
            //ArrayList iller = new ArrayList() { "Adana", "Kahramanmaraş", "Siirt" };

            //Console.WriteLine(iller.IndexOf("Siirt"));

            #region Kullanıcıdan sayı girmesi istenilecek ve girilen değer sayı ise arraylist e eklenecek. Girilen değer "çık" değeri ise  arraylist toplanarak ekrana sonucç yazdırılacak.
            #region Ayşe
            //ArrayList sayilar = new ArrayList();

            //while (true)
            //{
            //    Console.WriteLine("Sayı giriniz. Çık yazınca biter:");
            //    string giris = Console.ReadLine();

            //    if (giris == "çık")
            //    {
            //        break;
            //    }

            //    try
            //    {
            //        sayilar.Add(Convert.ToInt32(giris));
            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Lütfen sayı giriniz veya çık yazınız.");
            //    }
            //}

            //int toplam = 0;

            //for (int i = 0; i < sayilar.Count; i++)
            //{
            //    toplam = toplam + Convert.ToInt32(sayilar[i]);
            //}

            //Console.WriteLine("Toplam = " + toplam);
            #endregion

            #region Arda
            //ArrayList sayilar = new ArrayList();

            //while (true)
            //{
            //    Console.WriteLine("Sayı giriniz (çık yazınca biter): ");
            //    string giris = Console.ReadLine();

            //    if (giris == "çık")
            //    {
            //        break;
            //    }

            //    sayilar.Add(Convert.ToInt32(giris));
            //}

            //int toplam = 0;

            //for (int i = 0; i < sayilar.Count; i++)
            //{
            //    toplam += (int)sayilar[i];
            //}

            //Console.WriteLine("Toplam = " + toplam);
            #endregion

            ArrayList sayilar = new ArrayList();

            while (true)
            {
                Console.WriteLine("Sayı giriniz:");
                string deger = Console.ReadLine();

                if(int.TryParse(deger,out int sayi))
                {
                    sayilar.Add(sayi);
                }
                else
                {
                    if (deger == "çık")
                    {
                        int toplam = 0;
                        foreach (int item in sayilar)
                        {
                            toplam += item;
                        }
                        Console.WriteLine("Sonuç:"+toplam);
                    }
                    else
                    {
                        Console.WriteLine("Sayıyı rakam olarak giriniz");
                    }
                }
            }     

            #endregion

        }
    }
}
